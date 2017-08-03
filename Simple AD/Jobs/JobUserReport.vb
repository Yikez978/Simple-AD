Imports System.DirectoryServices

Public Class JobUserReport

    Private DataGrid As DataGridView
    Private TabPage As TabPage
    Private UserReportContainer As ContainerUserReport
    Private Spinner As ControlTabSpinner
    Private GetUsersThread As New Threading.Thread(AddressOf GetUsers)
    Private _LDAPQuery As String

    Public Sub New(ByVal Type As ReportType, Optional LDAPQuery As String = Nothing)

        Dim NewId = GenerateJobID()
        UserReportContainer = New ContainerUserReport(NewId, "Report - " & "Disabled Users")
        UserReportContainer.Visible = False

        TabPage = New TabPage
        With TabPage
            .Name = UserReportContainer.JobName
            .Text = UserReportContainer.JobName
            .Visible = True
            .BackColor = Color.FromArgb(124, 65, 153)
            .ForeColor = SystemColors.ControlText
            .Controls.Add(UserReportContainer)
        End With

        FormMain.GetMainTabCtrl().TabPages.Add(TabPage)
        DataGrid = UserReportContainer.GetMainDataGrid()

        FormMain.GetMainTabCtrl.SelectTab(FormMain.GetMainTabCtrl.TabCount - 1)

        FormMain.GetMainTabCtrl.SelectedTab.Controls.Add(UserReportContainer)
        FormMain.GetMainTabCtrl.Visible = True

        If LDAPQuery IsNot Nothing Then
            _LDAPQuery = LDAPQuery
        End If

        Spinner = New ControlTabSpinner("Generating Report...", UserReportContainer)
        Spinner.SpinnerVisible = True

        TabPage.Controls.Add(Spinner)
        Spinner.BringToFront()

        Dim paras As New Jobparameters
        paras.DataGrid = DataGrid
        paras.Type = Type

        GetUsersThread.IsBackground = True
        GetUsersThread.Start(paras)
    End Sub

    Public Class Jobparameters
        Property DataGrid As DataGridView
        Property Type As ReportType
    End Class

    Private Function GenerateJobID() As Integer

        Dim random As Random = New Random()
        Dim randNumber As Byte = random.Next(255)
        Return CInt(randNumber)

    End Function

    Private Sub ApplyDataSource(ByVal datagrid As DataGridView, ByVal datasource As DataTable)
        If datagrid.InvokeRequired Then
            datagrid.Invoke(New Action(Of DataGridView, DataTable)(AddressOf ApplyDataSource), datagrid, datasource)
        Else
            If Not FormMain.IsDisposed Then
                UserReportContainer.Datasource = datasource

                datagrid.Columns.Remove("name")

                Dim Name As New TextAndImageColumn

                With Name
                    .Name = "name"
                    .DataPropertyName = "name"
                    .HeaderText = "Name"
                    .Visible = True
                    .FillWeight = 80
                    .Image = ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.DisabledUser).ToBitmap
                End With

                datagrid.Columns.Insert(0, Name)

                For Each column As DataGridViewColumn In datagrid.Columns
                    If Not DefaultLDAPColumns.Contains(column.Name) Then
                        column.Visible = False
                    Else
                        column.FillWeight = 20
                    End If
                Next

                Spinner.Dispose()
                UserReportContainer.Visible = True
            End If
        End If
    End Sub

    Private Sub GetUsers(ByVal Param As Object)

        Dim p As Jobparameters = CType(Param, Jobparameters)
        Dim DataGridPara = p.DataGrid
        Dim Type = p.Type

        Dim dt As New DataTable

        For Each Prop In GetLDAPProps()
            If Not dt.Columns.Contains(Prop) Then
                dt.Columns.Add(New DataColumn(Prop, GetType(String)))
            End If
        Next

        Dim Entry As DirectoryEntry = New DirectoryEntry(GetDirEntry, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)

        Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntry)

        With DirSearcher
            .SearchRoot = Entry
        End With

        Select Case p.Type
            Case ReportType.DisabledUsers
                DirSearcher.Filter = "(&(objectCategory=person)(objectClass=user)(userAccountControl:1.2.840.113556.1.4.803:=2))"
            Case ReportType.CustomLDAP
                DirSearcher.Filter = _LDAPQuery
        End Select

        DirSearcher.PropertiesToLoad.AddRange(GetLDAPProps())

        Try
            Dim results As SearchResultCollection = DirSearcher.FindAll()

            For Each result As SearchResult In results
                Dim NewRow As DataRow = dt.NewRow

                For Each LDAPProp In GetLDAPProps()
                    If Not result.GetDirectoryEntry().Properties(LDAPProp).Value Is Nothing Then
                        NewRow.Item(LDAPProp) = result.GetDirectoryEntry().Properties(LDAPProp).Value
                    Else
                        NewRow.Item(LDAPProp) = ""
                    End If
                Next
                dt.Rows.Add(NewRow)
            Next

            ApplyDataSource(DataGridPara, dt)

        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
        End Try
    End Sub

End Class