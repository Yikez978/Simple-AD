Imports System.DirectoryServices

Public Class JobUserReport
    Inherits SimpleADJob

    Private MainListView As ControlListView
    Private ListView As ListView
    Private TabPage As TabPage
    Private UserReportContainer As ContainerUserReport
    Private Spinner As ControlTabSpinner

    Private _Path As String
    Private _LDAPQuery As String
    Private _Type As ReportType

    Public Class Jobparameters
        Property Type As ReportType
        Property Filter As String
        Property Entry As String
    End Class

    Public Sub New(ByVal Type As ReportType, Optional LDAPQuery As String = Nothing)
        Dim NewId = GenerateJobID()
        UserReportContainer = New ContainerUserReport(NewId, "Report - " & Type.ToString, Me)
        UserReportContainer.Dock = DockStyle.Fill

        _Type = Type

        TabPage = New TabPage
        With TabPage
            .Name = UserReportContainer.JobName
            .Text = UserReportContainer.JobName
            .Visible = True
            .BackColor = Color.FromArgb(124, 65, 153)
            .ForeColor = SystemColors.ControlText
            .Controls.Add(UserReportContainer)
        End With

        GetMainTabCtrl().TabPages.Add(TabPage)
        TabPage.SuspendLayout()
        TabPage.Controls.Add(UserReportContainer)
        MainListView = UserReportContainer.MainListView
        GetMainTabCtrl().SelectTab(GetMainTabCtrl().TabCount - 1)
        GetMainTabCtrl().Visible = True

        If LDAPQuery IsNot Nothing Then
            _LDAPQuery = LDAPQuery
        End If

        Select Case Type
            Case ReportType.Explorer
                UserReportContainer.MainSplitContainer.Panel1Collapsed = False
            Case Else
                UserReportContainer.MainSplitContainer.Panel1Collapsed = True
        End Select

        Spinner = New ControlTabSpinner("Generating Report...", UserReportContainer)
        TabPage.Controls.Add(Spinner)

        Refresh()
    End Sub

    Public Sub Refresh(Optional Path As String = Nothing, Optional JobType As ReportType = Nothing)

        If Not JobType = Nothing Then
            _Type = JobType
        End If

        Dim paras As New Jobparameters With {
            .Type = _Type
        }

        Select Case paras.Type
            Case ReportType.DisabledUsers
                paras.Filter = "(&(objectCategory=person)(objectClass=user)(userAccountControl:1.2.840.113556.1.4.803:=2))"
            Case ReportType.CustomLDAP
                paras.Filter = _LDAPQuery
            Case ReportType.AllObjects
                paras.Filter = "(objectClass=*)"
            Case ReportType.Explorer
                If Not String.IsNullOrEmpty(Path) Then
                    paras.Entry = Path
                    _Path = Path
                Else
                    paras.Entry = _Path
                End If
        End Select
        GetUsersListView(paras)
    End Sub

    Private Sub GetUsersListView(ByVal Param As Jobparameters)
        Try
            MainListView.BeginUpdate()
            MainListView.HideSelection = False
            MainListView.Font = SystemFonts.DefaultFont

            Dim Type As ReportType = Param.Type
            Dim Filter As String = Param.Filter
            Dim EntryPath As String = Param.Entry

            Dim Entry As DirectoryEntry = GetDirEntry(Param.Entry)

            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = Param.Filter
                Select Case Type
                    Case ReportType.Explorer
                        .SearchScope = SearchScope.OneLevel
                    Case Else
                        .SearchScope = SearchScope.Subtree
                End Select
            End With

            DirSearcher.PropertiesToLoad.AddRange(LDAPPropsShort)

            Dim results As SearchResultCollection = DirSearcher.FindAll()

            Dim AdImages As New ImageList()

            AdImages.Images.Add("OuImage", IconOU)
            AdImages.Images.Add("DomainImage", IconDomian)
            AdImages.Images.Add("ContainerImage", IconContainer)
            AdImages.Images.Add("GroupImage", IconGroup)
            AdImages.Images.Add("ComputerImage", IconComputer)
            AdImages.Images.Add("UserImage", IconUser)
            AdImages.Images.Add("DisabledUserImage", IconDisabledUSer)
            AdImages.Images.Add("ContactImage", IconContact)
            AdImages.Images.Add("UnknownImage", IconUnknown)
            AdImages.ColorDepth = ColorDepth.Depth24Bit
            AdImages.ImageSize = New Size(16, 16)

            MainListView.SmallImageList = AdImages
            MainListView.LargeImageList = AdImages

            Dim DomainObjectList = New List(Of DomainObject)

            For Each result As SearchResult In results
                If result.Properties("name").Count > 0 Then

                    Dim DomainObject = New DomainObject

                    DomainObject.Name = (CStr(result.Properties("name").Item(0)))

                    If result.Properties("sAMAccountName").Count > 0 Then
                        DomainObject.SAMAccountName = result.Properties("sAMAccountName").Item(0)
                    Else
                        DomainObject.SAMAccountName = Nothing
                    End If

                    If result.Properties("distinguishedName").Count > 0 Then
                        DomainObject.DistinguishedName = result.Properties("distinguishedName").Item(0)
                    End If

                    If result.Properties("description").Count > 0 Then
                        DomainObject.Description = result.Properties.Item("description").Item(0)
                    End If

                    If result.Properties("userAccountControl").Count > 0 Then
                        DomainObject.UserAccountControl = result.Properties.Item("userAccountControl").Item(0)
                    End If

                    If result.Properties.Item("objectClass").Count > 0 Then
                        Dim ObjectType As String = result.Properties.Item("objectClass").Item(result.Properties.Item("objectClass").Count - 1)
                        DomainObject.Type = ObjectType
                        DomainObject.TypeFriendly = GetFriendlyTypeName(ObjectType)

                        Dim TypeStringBuilder As New StringBuilder

                        For Each Item As Object In result.Properties.Item("objectClass")
                            TypeStringBuilder.AppendLine(CStr(Item) & ";")
                        Next
                        DomainObject.TypeFull = TypeStringBuilder.ToString
                    End If

                    DomainObjectList.Add(DomainObject)

                    End If
            Next

            MainListView.SetObjects(DomainObjectList)
            MainListView.EndUpdate()

        Catch ArgEx As System.ArgumentException
            ReportError(ArgEx)
            Debug.WriteLine("[Error] " & ArgEx.GetBaseException.ToString & ArgEx.Message)
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.GetBaseException.ToString & Ex.Message)
        ReportError(Ex)
        End Try
    End Sub

    Private Sub ReportError(ByVal ErrorMessage As Exception)
        If UserReportContainer.InvokeRequired Then
            UserReportContainer.Invoke(New Action(Of Exception)(AddressOf ReportError), ErrorMessage)
        Else
            Spinner.DisplayText = ErrorMessage.Message
            Spinner.ErrorBoxText = ErrorMessage.StackTrace.ToString
            Spinner.MainSpinner.Spinning = False
        End If
    End Sub

End Class