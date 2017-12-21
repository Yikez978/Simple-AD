Imports System.DirectoryServices.Protocols

Public Class JobExplorer
    Inherits SimpleADJob

    Private MainListView As ControlListView
    Private MainTreeView As ControlDomainTreeView

    Private UserReportContainer As ContainerExplorer

    Private lastReportType As SimpleADReportType

    Public JobPath As String

    Private _Filter As String
    Private _Type As SimpleADReportType

    Private DomainObjectList As New List(Of Object)

    Public Sub New(ByVal Type As SimpleADReportType, Optional LDAPQuery As String = Nothing)
        MyBase.New

        JobType = SimpleADJobType.Explorer
        JobName = GetProperName(GetDomainNetBiosName())

        _Type = Type

        GetContainerExplorer.Job = Me
        MainListView = GetContainerExplorer.MainListView
        MainTreeView = GetContainerExplorer.DomainTreeView

        If LDAPQuery IsNot Nothing Then
            _Filter = LDAPQuery
        End If

    End Sub

    Public Sub Refresh(Optional Path As String = Nothing, Optional JobReport As SimpleADReportType = Nothing)

        Debug.WriteLine("[Info] Get Objects Refreshed")

        JobStatus = SimpleADJobStatus.InProgress

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

        If Not lastReportType = _Type Then
            Setcolumns()
        ElseIf ColumnRebuildRequired = True Then
            Setcolumns()
        End If

        ColumnRebuildRequired = False
        lastReportType = _Type

        If My.Settings.UsePaging Then
            Select Case _Type
                Case SimpleADReportType.Explorer
                    Threading.ThreadPool.QueueUserWorkItem(Sub() GetObjects())
                Case Else
                    Threading.ThreadPool.QueueUserWorkItem(Sub() GetObjectsPaged())
            End Select
        Else
            Threading.ThreadPool.QueueUserWorkItem(Sub() GetObjects())
        End If



    End Sub

    Private Sub GetObjectsPaged()

        Dim hostOrDomainName As String = GetDomainNetBiosName()

        Dim startingDn As String
        If String.IsNullOrEmpty(JobPath) Then
            startingDn = GetFQDN()
        Else
            startingDn = JobPath
        End If



        '' for returning up to 5 entries in each page
        Dim pageSize As Integer = 100
        '' for tracking the pages returned by the search request
        Dim pageCount As Integer = 0

        Dim Connection As LdapConnection = New LdapConnection(hostOrDomainName)
        Debug.WriteLine("[Debug] Performing a paged search ...")

        Dim ldapSearchFilter As String = _Filter

        Dim ScopeLvel As SearchScope

        Select Case _Type
            Case SimpleADReportType.Explorer
                ScopeLvel = SearchScope.OneLevel
            Case Else
                ScopeLvel = SearchScope.Subtree
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

        Debug.WriteLine("[Debug] Attributes to Load: [" & String.Join(", ", Attributes) & "]")

        '' create a SearchRequest object
        Dim SearchRequest As SearchRequest =
            New SearchRequest(startingDn, ldapSearchFilter, ScopeLvel, Attributes)

        '' create the PageResultRequestControl object 
        '' pass it the size of each page.

        Dim pageRequest As PageResultRequestControl =
            New PageResultRequestControl(pageSize)

        '' add the PageResultRequestControl object to the
        '' SearchRequest object's directory control collection 
        '' to enable a paged search request
        SearchRequest.Controls.Add(pageRequest)

        '' turn off referral chasing so that data from other partitions Is
        '' Not returned. This Is necessary when scoping a search
        '' to a single naming context, such as a domain Or the 
        '' configuration container
        Dim searchOptions As SearchOptionsControl =
            New SearchOptionsControl(SearchOption.DomainScope)

        '' add the SearchOptionsControl object to the
        '' SearchRequest object's directory control collection 
        '' to disable referral chasing
        SearchRequest.Controls.Add(searchOptions)

        Dim NewDomainObjectList As List(Of Object) = New List(Of Object)
        MainListView.SetObjects(NewDomainObjectList)

        While True

            '' increment the pageCount by 1
            pageCount = pageCount + 1

            '' cast the directory response into a 
            '' SearchResponse object
            Dim SearchResponse As SearchResponse =
            DirectCast(Connection.SendRequest(SearchRequest), SearchResponse)

            '' verify support for this advanced search operation
            If (Not SearchResponse.Controls.Length = 1 Or (SearchResponse.Controls(0).GetType IsNot GetType(PageResultResponseControl))) Then

                Console.WriteLine("[Debug] The server cannot page the result set")
                Return
            End If

            '' cast the diretory control into 
            '' a PageResultResponseControl object.
            Dim pageResponse As PageResultResponseControl =
            DirectCast(SearchResponse.Controls(0), PageResultResponseControl)

            '' display the retrieved page number And the number of 
            '' directory entries in the retrieved page                    
            Debug.WriteLine("[Debug] Page:{0} contains {1} response entries", pageCount, SearchResponse.Entries.Count)

            '' display the entries within this page
            For Each entry As SearchResultEntry In SearchResponse.Entries

                Dim NewObject As Object

                NewObject = GetObjectAttributesFromResultEntry(entry, Attributes)


                If NewObject IsNot Nothing Then
                    NewDomainObjectList.Add(DirectCast(NewObject, DomainObject))
                End If


                Debug.WriteLine(String.Format("[Debug] {0}:{1}", SearchResponse.Entries.IndexOf(entry) + 1, entry.DistinguishedName))
            Next


            '' if this Is true, there 
            '' are no more pages to request
            If pageResponse.Cookie.Length = 0 Then
                Exit While
            End If
            '' set the cookie of the pageRequest equal to the cookie 
            '' of the pageResponse to request the next page of data
            '' in the send request
            pageRequest.Cookie = pageResponse.Cookie

        End While

        MainListView.Invoke(Sub() AfterFindObjects(NewDomainObjectList))

    End Sub

    Private Sub GetObjects()

        Dim NewDomainObjectList As List(Of Object) = New List(Of Object)

        Try

            Dim Entry As DirectoryEntry = GetDirEntry(JobPath)
            Dim Report As SimpleADReport = GetReport(_Type)
            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = _Filter
                Select Case _Type
                    Case SimpleADReportType.Explorer
                        .SearchScope = CType(SearchScope.OneLevel, DirectoryServices.SearchScope)
                    Case Else
                        .SearchScope = CType(SearchScope.Subtree, DirectoryServices.SearchScope)
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

            Dim results As SearchResultCollection = DirSearcher.FindAll()

            For Each result As SearchResult In results

                Dim NewObject As Object

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

        Catch ArgEx As ArgumentException
            ReportError(ArgEx)
            Debug.WriteLine("[Error] " & ArgEx.GetBaseException.ToString & ArgEx.Message)
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.GetBaseException.ToString & Ex.Message)
            ReportError(Ex)
        End Try

        MainListView.Invoke(Sub() AfterFindObjects(NewDomainObjectList))

    End Sub

    Private Sub AfterFindObjects(Optional DomainObjectList As List(Of Object) = Nothing)

        Debug.WriteLine("[Info] Find Objects After")

        If DomainObjectList IsNot Nothing Then

            MainListView.SetObjects(DomainObjectList)
            JobStatus = SimpleADJobStatus.Completed

        End If

        MainListView.RebuildColumns()
        MainListView.EndUpdate()

    End Sub

    Public Sub Setcolumns()

        MainListView.SuspendLayout

        MainListView.BeginUpdate()
        MainListView.AllColumns.Clear()

        Dim NameCol As New OLVColumn With {
            .AspectName = "Name",
            .Text = "Name",
            .Width = 205,
            .ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter),
            .GroupKeyGetter = New GroupKeyGetterDelegate(AddressOf SortByNameGroupKeyGetter)
        }

        Dim TypeCol As New OLVColumn With {
            .AspectName = "TypeFriendly",
            .Text = "Type",
            .IsTileViewColumn = True,
            .Width = 137
        }

        Dim DescriptionCol As New OLVColumn With {
            .AspectName = "Description",
            .Text = "Description",
            .IsTileViewColumn = True,
            .Width = 253
        }

        Dim FillerColStyle As HeaderFormatStyle = New HeaderFormatStyle

        With FillerColStyle
            .Hot.BackColor = SystemColors.Window
            .Normal.BackColor = SystemColors.Window
            .Pressed.BackColor = SystemColors.Window

            .Hot.FrameWidth = 0
            .Normal.FrameWidth = 0
            .Pressed.FrameWidth = 0
        End With

        Dim FillerCol As OLVColumn = New OLVColumn With {
            .FillsFreeSpace = True,
            .Text = "",
            .ShowTextInHeader = False,
            .Searchable = False,
            .Sortable = False,
            .HeaderFormatStyle = FillerColStyle
        }

        MainListView.PrimarySortColumn = TypeCol

        MainListView.AllColumns.AddRange(New OLVColumn() {NameCol, TypeCol, DescriptionCol})

        Dim Report As SimpleADReport = GetReport(_Type)


        If Report IsNot Nothing Then

            If Report.AttributesToLoad IsNot Nothing Then
                If Report.AttributesToLoad.Count > 0 Then

                    For Each Attribute As String In Report.AttributesToLoad

                        Dim NewColumn As New OLVColumn With {
                            .AspectName = FirstCharToUpper(Attribute),
                            .Text = GetProperFromCamelCase(Attribute),
                            .IsTileViewColumn = True,
                            .Width = 200
                        }

                        MainListView.AllColumns.Add(NewColumn)

                    Next
                End If
            End If

        End If

        If My.Settings.UseNativeWindowsTheme = False Then
            MainListView.AllColumns.Add(FillerCol)
        End If

    End Sub

    Private Sub ReportError(ByVal ErrorMessage As Exception)
        JobStatus = SimpleADJobStatus.Errors
        If Not UserReportContainer Is Nothing Then
            If UserReportContainer.InvokeRequired Then
                UserReportContainer.Invoke(New Action(Of Exception)(AddressOf ReportError), ErrorMessage)
            Else
                Debug.WriteLine("[Error] " & ErrorMessage.Message)
                Debug.WriteLine("[Error] " & ErrorMessage.StackTrace.ToString)
            End If
        End If
    End Sub

End Class