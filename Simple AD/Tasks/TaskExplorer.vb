Imports System.DirectoryServices
Imports System.DirectoryServices.Protocols
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Imports SimpleLib

Public Class TaskExplorer
    Inherits ActiveTask

    Public JobPath As String

    Private _MainListView As ControlDomainListView
    Private _MainTreeView As ControlDomainTreeView

    Private _UserReportContainer As ContainerExplorer
    Private _LastReportType As SimpleADReportType

    Private _Filter As String
    Private _Type As SimpleADReportType

    Private _GetTask As Task

    Private _Cts As CancellationTokenSource
    Private _LastCts As CancellationTokenSource

    Private _ColumnSizes As Integer() = {205, 137, 253}

    Private Delegate Sub Delegate_AfterFindObjects(ByVal DomainObjectList As List(Of Object))

    '' Defines columns that should use the Date GroupGetter delegate
    Private DateAttributes As String() = {"whenCreated", "whenChanged", "pwdLastSet", "lastLogon", "lastLogonTimestamp"}

    Public Sub New(ByVal Type As SimpleADReportType, Optional LDAPQuery As String = Nothing)
        MyBase.New

        TaskType = ActiveTaskType.Explorer
        TaskName = GetProperName(GetDomainNetBiosName())

        GetContainerExplorer.Job = Me

        _MainListView = GetContainerExplorer.MainListView
        _MainTreeView = GetContainerExplorer.DomainTreeView

        _Type = Type

        If LDAPQuery IsNot Nothing Then
            _Filter = LDAPQuery
        End If

        Dim NameCol As New OLVColumn With {
            .AspectName = "Name",
            .Text = "Name",
            .Width = _ColumnSizes(0),
            .ImageGetter = New ImageGetterDelegate(AddressOf ImageGetter),
            .GroupKeyGetter = New GroupKeyGetterDelegate(AddressOf SortByNameGroupKeyGetter)
        }

        Dim TypeCol As New OLVColumn With {
            .AspectName = "TypeFriendly",
            .Text = "Type",
            .IsTileViewColumn = True,
            .Width = _ColumnSizes(1)
        }

        Dim DescriptionCol As New OLVColumn With {
            .AspectName = "Description",
            .Text = "Description",
            .IsTileViewColumn = True,
            .Width = _ColumnSizes(2),
            .GroupKeyGetter = Function(rowObject As Object) SortByNameDynamicGroupKeyGetter(rowObject, "description")
        }

        _MainListView.PrimarySortColumn = TypeCol

        _MainListView.AllColumns.AddRange(New OLVColumn() {NameCol, TypeCol, DescriptionCol})

    End Sub

    Public Function ImageGetter(rowObject As Object) As Object

        Try

            Dim DomainObject As DomainObject = DirectCast(rowObject, DomainObject)

            Select Case DomainObject.Type
                Case "user"
                    Dim UserAccountControl As Integer = DomainObject.UserAccountControl
                    If UserAccountControl = 546 Or UserAccountControl = 514 Or UserAccountControl = 66082 Or UserAccountControl = 66050 Then
                        Return "DisabledUserImage"
                    Else
                        Return "UserImage"
                    End If
                Case "computer"
                    Return "ComputerImage"
                Case "group"
                    Return "GroupImage"
                Case "container"
                    Return "ContainerImage"
                Case "organizationalUnit"
                    Return "OuImage"
                Case "contact"
                    Return "ContactImage"
                Case Else
                    Return "UnknownImage"
            End Select

        Catch Ex As Exception

            Return Nothing
        End Try

    End Function

    Public Sub Refresh(Optional Path As String = Nothing, Optional JobReport As SimpleADReportType = Nothing)

        Debug.WriteLine("[Info] Get Objects Refreshed")

        TaskStatus = ActiveTaskStatus.InProgress

        If (Not JobReport = Nothing) And (Not JobReport = SimpleADReportType.Explorer) Then
            _Type = JobReport
            _Filter = GetReport(JobReport).ReportQuery
            JobPath = Nothing
        Else
            _Type = SimpleADReportType.Explorer
            _Filter = Nothing

            If Not String.IsNullOrEmpty(Path) Then
                JobPath = Path
            End If

        End If

        _Cts = New CancellationTokenSource()

        '' Check if a GetObjects task is already runnig before starting a new one
        If (_GetTask IsNot Nothing) AndAlso (_GetTask.IsCompleted = False OrElse
            _GetTask.Status = Threading.Tasks.TaskStatus.Running OrElse
            _GetTask.Status = Threading.Tasks.TaskStatus.WaitingToRun OrElse
            _GetTask.Status = Threading.Tasks.TaskStatus.WaitingForActivation) Then

            Debug.WriteLine("[Debug] Canceling previously running GetObjects task")

            '' Send a cancel request to the previous task if it is still running so as not to cause a data race when updating the list view
            _LastCts.Cancel()

        End If

        If My.Settings.UsePaging Then
            Select Case _Type
                Case SimpleADReportType.Explorer
                    _GetTask = Task.Run(Sub() GetObjects(_Cts.Token))
                Case Else
                    _GetTask = Task.Run(Sub() GetObjectsPaged(_Cts.Token))
            End Select
        Else
            _GetTask = Task.Run(Sub() GetObjects(_Cts.Token))
        End If

        '' Save a reference to the last task incase it needs to be canceled
        _LastCts = _Cts

    End Sub

    Private Sub GetObjectsPaged(ByVal CT As CancellationToken)

        Dim hostOrDomainName As String = Nothing

        If String.IsNullOrEmpty(LoginUsernamePrefix) Then

            Dim IPAddress As Net.IPAddress = GetDomainControllerIPAddress(0)

            If IPAddress IsNot Nothing Then
                hostOrDomainName = IPAddress.ToString
            End If

        Else
            hostOrDomainName = LoginUsernamePrefix
        End If


        If String.IsNullOrEmpty(hostOrDomainName) Then
            Debug.WriteLine("[Error] Unable to resolve hostname of domain controller")
            Exit Sub
        End If

        Dim startingDn As String
        If String.IsNullOrEmpty(JobPath) Then
            startingDn = GetFQDN()
        Else
            startingDn = JobPath
        End If

        Dim pageSize As Integer = 100
        Dim pageCount As Integer = 0

        Dim Connection As LdapConnection = New LdapConnection(
            New LdapDirectoryIdentifier(hostOrDomainName),
            If(String.IsNullOrEmpty(LoginPassword), Net.CredentialCache.DefaultNetworkCredentials, New Net.NetworkCredential(LoginUsername, LoginPassword))
        )

        Debug.WriteLine("[Debug] Performing a paged search ...")

        Dim ldapSearchFilter As String = _Filter

        Dim ScopeLvel As Protocols.SearchScope

        Select Case _Type
            Case SimpleADReportType.Explorer
                ScopeLvel = Protocols.SearchScope.OneLevel
            Case Else
                ScopeLvel = Protocols.SearchScope.Subtree
        End Select

        Dim Report As SimpleADReport = GetReport(_Type)
        Dim Attributes As String() = LDAPPropsShort

        If Report IsNot Nothing Then
            If Report.AttributesToLoad IsNot Nothing Then
                If Report.AttributesToLoad.Count > 0 Then
                    Attributes = Attributes.Union(Report.AttributesToLoad).ToArray
                End If
            End If
        End If

        Dim SearchRequest As SearchRequest = New SearchRequest(startingDn, ldapSearchFilter, ScopeLvel, Attributes)
        Dim pageRequest As PageResultRequestControl = New PageResultRequestControl(pageSize)


        SearchRequest.Controls.Add(pageRequest)

        Dim searchOptions As SearchOptionsControl = New SearchOptionsControl(SearchOption.DomainScope)

        SearchRequest.Controls.Add(searchOptions)

        Dim NewDomainObjectList As List(Of Object) = New List(Of Object)

        While True

            pageCount = pageCount + 1

            Try

                Dim SearchResponse As SearchResponse = DirectCast(Connection.SendRequest(SearchRequest), SearchResponse)

                If (Not SearchResponse.Controls.Length = 1 Or (SearchResponse.Controls(0).GetType IsNot GetType(PageResultResponseControl))) Then
                    Debug.WriteLine("[Debug] The server cannot page the result set")
                    Return
                End If

                Dim pageResponse As PageResultResponseControl = DirectCast(SearchResponse.Controls(0), PageResultResponseControl)


                For Each entry As SearchResultEntry In SearchResponse.Entries

                    Dim NewObject As DomainObject = Nothing

                    NewObject = GetObjectAttributesFromResultEntry(entry, Attributes)

                    If NewObject IsNot Nothing Then
                        NewDomainObjectList.Add(DirectCast(NewObject, DomainObject))
                    End If

                Next

                If pageResponse.Cookie.Length = 0 Then
                    Exit While
                End If

                pageRequest.Cookie = pageResponse.Cookie

            Catch Ex As Exception
                Debug.WriteLine("[Error] Failed to complete paged LDAP search. Host: {0} Error Message: {1}", hostOrDomainName, Ex.Message)
                Exit While
            End Try

        End While

        If Not CT.IsCancellationRequested Then
            _MainListView.Invoke(New Delegate_AfterFindObjects(AddressOf AfterFindObjects), NewDomainObjectList)
        End If



    End Sub

    Private Sub GetObjects(ByVal CT As CancellationToken)

        If CT.IsCancellationRequested Then
            Exit Sub
        End If

        Dim SearchResults As SearchResultCollection = Nothing

        Dim NewDomainObjectList As List(Of Object) = New List(Of Object)

        Try

            Dim Entry As DirectoryEntry = GetDirEntry(JobPath)
            Dim Report As SimpleADReport = GetReport(_Type)
            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = _Filter
                .PageSize = 1000
                .SizeLimit = 10000
                Select Case _Type
                    Case SimpleADReportType.Explorer
                        .SearchScope = CType(Protocols.SearchScope.OneLevel, DirectoryServices.SearchScope)
                    Case SimpleADReportType.AllDeletedObjects
                        .Tombstone = True
                        .SearchScope = CType(Protocols.SearchScope.Subtree, DirectoryServices.SearchScope)
                    Case Else
                        .SearchScope = CType(Protocols.SearchScope.Subtree, DirectoryServices.SearchScope)
                End Select
            End With

            DirSearcher.PropertiesToLoad.AddRange(LDAPPropsShort)

            If Report IsNot Nothing Then
                If Report.AttributesToLoad IsNot Nothing Then
                    If Report.AttributesToLoad.Count > 0 Then
                        DirSearcher.PropertiesToLoad.AddRange(Report.AttributesToLoad)
                    End If
                End If
            End If

            SearchResults = DirSearcher.FindAll()

            If CT.IsCancellationRequested Then
                Throw New TaskCanceledException
            End If

            For Each result As SearchResult In SearchResults

                Dim NewObject As Object = Nothing

                If Report IsNot Nothing Then
                    NewObject = GetObjectAttributesFromResult(result, Report.AttributesToLoad)
                Else
                    NewObject = GetObjectAttributesFromResult(result, Nothing)
                End If

                If NewObject IsNot Nothing Then
                    NewDomainObjectList.Add(NewObject)
                End If
            Next

            Debug.WriteLine("[Info] Get Objects Completed")

        Catch CancelEx As TaskCanceledException
            Debug.WriteLine("[Info] Get Objects Canceled: " & CancelEx.Message)
        Catch ArgEx As ArgumentException
            ReportError(ArgEx)
            Debug.WriteLine("[Error] " & ArgEx.GetBaseException.ToString & ArgEx.Message)
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.GetBaseException.ToString & Ex.Message)
            ReportError(Ex)
        Finally

            ''Cleanup
            If SearchResults IsNot Nothing Then
                SearchResults.Dispose()
            End If

            If Not CT.IsCancellationRequested Then
                _MainListView.Invoke(New Delegate_AfterFindObjects(AddressOf AfterFindObjects), NewDomainObjectList)
            End If

        End Try

    End Sub

    Private Sub AfterFindObjects(Optional DomainObjectList As List(Of Object) = Nothing)

        Debug.WriteLine("[Info] Find Objects After")

        If DomainObjectList IsNot Nothing Then

            If Not _LastReportType = _Type Then
                Setcolumns()
            ElseIf ColumnRebuildRequired = True Then
                Setcolumns()
            End If

            ColumnRebuildRequired = False
            _LastReportType = _Type

            _MainListView.SetObjects(DomainObjectList)
            TaskStatus = ActiveTaskStatus.Completed

        End If

        _MainListView.RebuildColumns()
        _MainListView.EndUpdate()

    End Sub

    Private Sub Setcolumns()

        _MainListView.BeginUpdate()
        _MainListView.PrimarySortColumn = _MainListView.AllColumns(1)
        _MainListView.AllColumns.RemoveRange(3, _MainListView.AllColumns.Count - 3)
        _MainListView.RebuildColumns()

        Dim Report As SimpleADReport = GetReport(_Type)

        _MainListView.AllColumns(1).IsVisible = True

        If Report IsNot Nothing Then

            If Report.AttributesToLoad IsNot Nothing Then
                If Report.AttributesToLoad.Count > 0 Then

                    _MainListView.AllColumns(1).IsVisible = False

                    For Each Attribute As String In Report.AttributesToLoad

                        Dim NewColumn As New OLVColumn With {
                            .AspectName = FirstCharToUpper(Attribute),
                            .Text = GetProperFromCamelCase(Attribute),
                            .Width = 200
                        }

                        If DateAttributes.Contains(Attribute) Then
                            NewColumn.GroupKeyGetter = Function(rowObject As Object) SortByDateGroupKeyGetter(rowObject, Attribute)
                            NewColumn.GroupKeyToTitleConverter = Function(groupKey As Object) If(Not DirectCast(groupKey, DateTime).Year = 1694, DirectCast(groupKey, DateTime).ToString("MMMM yyyy"), "N/A")
                        Else
                            NewColumn.GroupKeyGetter = Function(rowObject As Object) SortByNameDynamicGroupKeyGetter(rowObject, Attribute)
                        End If

                        _MainListView.AllColumns.Add(NewColumn)

                    Next
                End If
            End If

        End If

    End Sub

    Private Sub ReportError(ByVal ErrorMessage As Exception)

        TaskStatus = ActiveTaskStatus.Errors

        If Not _UserReportContainer Is Nothing Then

            If _UserReportContainer.InvokeRequired Then
                _UserReportContainer.Invoke(New Action(Of Exception)(AddressOf ReportError), ErrorMessage)
            Else
                Debug.WriteLine("[Error] " & ErrorMessage.Message)

                If ErrorMessage.StackTrace IsNot Nothing Then
                    Debug.WriteLine("[Error] " & ErrorMessage.StackTrace.ToString)
                End If

            End If

        End If

    End Sub

    Public Overloads Sub Cancel()
        Try
            _Cts.Cancel()
        Catch Ex As Exception
            Debug.WriteLine("[Error] Failed to cancel the running explorer task: " & Ex.Message)
        End Try
    End Sub



End Class