Imports System.DirectoryServices
Imports System.DirectoryServices.Protocols
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Imports SimpleLib

Public Class TaskExplorer
    Inherits TaskBase

    Public JobPath As String

    Private _MainListView As ControlDomainListView
    Private _MainTreeView As ControlDomainTreeView

    Private _UserReportContainer As ContainerExplorer
    Private _LastReportType As ReportManager.SimpleADReportType

    Private _Filter As String
    Private _Type As ReportManager.SimpleADReportType

    Private _GetTask As Task

    Private _Cts As CancellationTokenSource
    Private _LastCts As CancellationTokenSource

    Private _ObjectListLock As New Object

    Private _ColumnSizes As Integer() = {205, 18, 137, 253}

    Private _QueryStopwatch As New Stopwatch

    Public DomainObjectList As List(Of Object) = New List(Of Object)

    Public ExplorerAttrParser As New AttributeParser

    Private Delegate Sub Delegate_AfterFindObjects(ByVal DomainObjectList As List(Of Object))

    Public Sub New(ByVal Type As ReportManager.SimpleADReportType, Optional LDAPQuery As String = Nothing)
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
            .ImageGetter = New ImageGetterDelegate(AddressOf _MainListView.ImageGetter),
            .GroupKeyGetter = New GroupKeyGetterDelegate(AddressOf SortByNameGroupKeyGetter)
        }

        Dim FlagsCol As New OLVColumn With {
            .AspectName = "Flags",
            .Text = String.Empty,
            .Width = _ColumnSizes(1),
            .ImageGetter = New ImageGetterDelegate(AddressOf _MainListView.MetaImageGetter),
            .GroupKeyGetter = New GroupKeyGetterDelegate(AddressOf SortByNameGroupKeyGetter),
            .AspectToStringConverter = Function(rowObject As Object) String.Empty,
            .MaximumWidth = 20,
            .MinimumWidth = 20,
            .Hideable = False,
            .IsButton = False,
            .Sortable = False
        }

        Dim TypeCol As New OLVColumn With {
            .AspectName = "TypeFriendly",
            .Text = "Type",
            .IsTileViewColumn = True,
            .Width = _ColumnSizes(2)
        }

        Dim DescriptionCol As New OLVColumn With {
            .AspectName = "Description",
            .Text = "Description",
            .IsTileViewColumn = True,
            .Width = _ColumnSizes(3),
            .GroupKeyGetter = Function(rowObject As Object) SortByNameDynamicGroupKeyGetter(rowObject, "description")
        }

        _MainListView.PrimarySortColumn = TypeCol
        _MainListView.AttachToStatusBar()
        _MainListView.AllColumns.AddRange(New OLVColumn() {NameCol, FlagsCol, TypeCol, DescriptionCol})

    End Sub

    Public Sub Refresh(Optional Path As String = Nothing, Optional JobReport As ReportManager.SimpleADReportType = Nothing)

        _QueryStopwatch.Start()

        TaskStatus = ActiveTaskStatus.InProgress

        ExplorerAttrParser.EvaluateProtection = My.Settings.AdvEvaluateProtection

        If (Not JobReport = Nothing) And (Not JobReport = ReportManager.SimpleADReportType.Explorer) Then
            _Type = JobReport
            _Filter = ReportManager.GetReport(JobReport).ReportQuery
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


#If DEBUG Then
            Logger.Log(String.Format("[Info] Canceling GetObjects task: {0}", _GetTask.Id))
#End If

            '' Send a cancel request to the previous task if it is still running 
            '' so as not to cause a data race when updating the list view
            _LastCts.Cancel()
        Else

        End If

        DomainObjectList = Nothing

        If My.Settings.AdvUsePaging Then
            Select Case _Type
                Case SimpleADReportType.Explorer
                    _GetTask = Task.Run(Sub() GetObjectsPaged(_Cts.Token))
                Case Else
                    _GetTask = Task.Run(Sub() GetObjectsPaged(_Cts.Token))
            End Select
        Else
            _GetTask = Task.Run(Sub() GetObjects(_Cts.Token))
        End If

        _LastCts = _Cts

        '' Save a reference to the last task incase it needs to be canceled


    End Sub

    Private Sub GetObjectsPaged(ByVal CT As CancellationToken)

        If CT.IsCancellationRequested Then
            Exit Sub
        End If

        Dim IsPageDirty As Boolean

#If DEBUG Then
        Dim PageSearchTime As Stopwatch = Stopwatch.StartNew
#End If

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
            Logger.Log("[Error] Unable to resolve hostname of domain controller")
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

        Connection.Timeout = TimeSpan.FromSeconds(6)

        Connection.SessionOptions.Sealing = True
        Connection.SessionOptions.SendTimeout = TimeSpan.FromSeconds(3)

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

        DomainObjectList = New List(Of Object)

        While True

            pageCount = pageCount + 1

            Try

                If CT.IsCancellationRequested Then

                    DomainObjectList = Nothing

                    Exit While
                End If

                Dim SearchResponse As SearchResponse = DirectCast(Connection.SendRequest(SearchRequest), SearchResponse)

                If (Not SearchResponse.Controls.Length = 1 Or (SearchResponse.Controls(0).GetType IsNot GetType(PageResultResponseControl))) Then
                    Logger.Log("[Debug] The server cannot page the result set")
                    Return
                End If

                Dim pageResponse As PageResultResponseControl = DirectCast(SearchResponse.Controls(0), PageResultResponseControl)

                For i As Integer = 0 To SearchResponse.Entries.Count - 1
                    Dim Entry As SearchResultEntry = SearchResponse.Entries(i)

                    Dim NewObject As Object = Nothing

                    NewObject = ExplorerAttrParser.GetObjectAttributesFromResultEntry(Entry, Report.AttributesToLoad)

                    If NewObject Is Nothing Then
                        Continue For
                    End If

                    If DomainObjectList Is Nothing Then
                        Continue For
                    End If

                    DomainObjectList.Add(NewObject)

                Next

                If pageResponse.Cookie.Length = 0 Then
                    Exit While
                End If

                pageRequest.Cookie = pageResponse.Cookie

            Catch Ex As Exception

                IsPageDirty = True

                Logger.Log(String.Format("[Error] Failed to complete paged LDAP search. Host: {0} Error Message: {1}", hostOrDomainName, Ex.Message))
                Exit While

            Finally

                If CT.IsCancellationRequested Then
                    IsPageDirty = True
                End If

            End Try

        End While

        Connection.Dispose()

        SyncLock _ObjectListLock

            If Not CT.IsCancellationRequested AndAlso Not IsPageDirty Then

                _MainListView.Invoke(New Delegate_AfterFindObjects(AddressOf AfterFindObjects), DomainObjectList)

            End If

        End SyncLock

#If DEBUG Then
        Logger.Log(String.Format("[Info] Completed paged search in {0} ms", Convert.ToUInt32(PageSearchTime.ElapsedMilliseconds)))
#End If

    End Sub

    Private Sub GetObjects(ByVal CT As CancellationToken)

        Dim SearchResults As SearchResultCollection = Nothing

        Try

            If CT.IsCancellationRequested Then
                Exit Try
            End If

            Dim Entry As DirectoryEntry = GetDirEntry(JobPath)
            Dim Report As SimpleADReport = GetReport(_Type)
            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = _Filter
                .CacheResults = My.Settings.AdvEnableResultCaching
                .ServerTimeLimit = TimeSpan.FromSeconds(5)
                .ClientTimeout = TimeSpan.FromSeconds(6)
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
                DirSearcher.Dispose()
                Exit Try
            End If

            DomainObjectList = New List(Of Object)

            If SearchResults Is Nothing Then
                Exit Try
            End If

            For Each result As SearchResult In SearchResults

                Dim NewObject As Object = Nothing

                If Report Is Nothing Then
                    NewObject = ExplorerAttrParser.GetObjectAttributesFromResult(result, Nothing)
                Else
                    NewObject = ExplorerAttrParser.GetObjectAttributesFromResult(result, Report.AttributesToLoad)
                End If

                If NewObject Is Nothing Then
                    Continue For
                End If

                If DomainObjectList Is Nothing Then
                    Exit For
                End If

                DomainObjectList.Add(NewObject)

            Next


        Catch CancelEx As TaskCanceledException
            Logger.Log("[Info] Get Objects Canceled: " & CancelEx.Message)
        Catch ArgEx As ArgumentException
            ReportError(ArgEx)
            Logger.Log("[Error] " & ArgEx.GetBaseException.ToString & ArgEx.Message)
        Catch Ex As Exception
            Logger.Log("[Error] Get Objects unhandled error: " & Ex.GetBaseException.ToString & Ex.Message)
            ReportError(Ex)
        Finally

            ''Cleanup
            If SearchResults IsNot Nothing Then
                SearchResults.Dispose()
            End If

            If Not CT.IsCancellationRequested Then
                _MainListView.Invoke(New Delegate_AfterFindObjects(AddressOf AfterFindObjects), DomainObjectList)
            End If

        End Try

    End Sub

    Private Sub AfterFindObjects(Optional DomainObjectList As List(Of Object) = Nothing)

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

        UpdateQueryTimeText(String.Format("{0} ms", _QueryStopwatch.ElapsedMilliseconds))

        _QueryStopwatch.Reset()

    End Sub

    Private Sub Setcolumns()

        _MainListView.BeginUpdate()
        _MainListView.PrimarySortColumn = _MainListView.AllColumns(2)
        _MainListView.AllColumns.RemoveRange(4, _MainListView.AllColumns.Count - 4)
        _MainListView.RebuildColumns()

        Dim Report As SimpleADReport = GetReport(_Type)

        _MainListView.AllColumns(2).IsVisible = True

        If Report Is Nothing Then
            Exit Sub
        End If

        If Report.AttributesToLoad IsNot Nothing Then
            If Report.AttributesToLoad.Count > 0 Then

                _MainListView.AllColumns(2).IsVisible = False

                For i As Integer = 0 To Report.AttributesToLoad.Count - 1

                    Dim Attribute As String = Report.AttributesToLoad(i)

                    Dim NewColumn As New OLVColumn With {
                            .AspectName = FirstCharToUpper(Attribute),
                            .Text = GetProperFromCamelCase(Attribute),
                            .Width = 200,
                            .IsVisible = False
                    }

                    _MainListView.AllColumns.Add(NewColumn)

                    If Attributes.ContainsKey(Attribute) Then

                        Dim SortKey As SortType = ReportAttributeStore.Attributes(Attribute).SortKey

                        If SortKey = SortType.Time Then
                            NewColumn.GroupKeyGetter = Function(rowObject As Object) SortByDateGroupKeyGetter(rowObject, Attribute)
                            NewColumn.GroupKeyToTitleConverter = Function(groupKey As Object) If(Not DirectCast(groupKey, DateTime).Year = 1694, DirectCast(groupKey, DateTime).ToString("MMMM yyyy"), "N/A")
                            NewColumn.AspectToStringConverter = New AspectToStringConverterDelegate(AddressOf DateToShortDelegate)
                        ElseIf SortKey = SortType.Alphabetic Then
                            NewColumn.GroupKeyGetter = Function(rowObject As Object) SortByNameDynamicGroupKeyGetter(rowObject, Attribute)
                        End If

                        If ReportAttributeStore.Attributes(Attribute).IsVisibleByDefault Then
                            NewColumn.IsVisible = True
                        End If

                        If Not String.IsNullOrEmpty(Report.PrimarySortCol) Then
                            If Report.PrimarySortCol = Attribute Then
                                _MainListView.PrimarySortColumn = NewColumn
                            End If
                        End If

                    End If

                Next
            End If
        End If

    End Sub

    Private Sub ReportError(ByVal ErrorMessage As Exception)

        TaskStatus = ActiveTaskStatus.Errors

        If Not _UserReportContainer Is Nothing Then

            If _UserReportContainer.InvokeRequired Then
                _UserReportContainer.Invoke(New Action(Of Exception)(AddressOf ReportError), ErrorMessage)
            Else
                Logger.Log("[Error] " & ErrorMessage.Message)

                If ErrorMessage.StackTrace IsNot Nothing Then
                    Logger.Log("[Error] " & ErrorMessage.StackTrace.ToString)
                End If

            End If

        End If

    End Sub

    Public Overloads Sub Cancel()
        Try
            _Cts.Cancel()
        Catch Ex As Exception
            Logger.Log("[Error] Failed to cancel the running explorer task: " & Ex.Message)
        End Try
    End Sub



End Class