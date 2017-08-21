Imports System.DirectoryServices
Imports System.Security.Principal

Public Class JobUserReport
    Inherits SimpleADJob

    Private DataGrid As DataGridView
    Private TabPage As TabPage
    Private UserReportContainer As ContainerUserReport
    Private Spinner As ControlTabSpinner
    Private GetUsersThread As Threading.Thread
    Private _LDAPQuery As String
    Private _Type As ReportType

    Public Class Jobparameters
        Property DataGrid As DataGridView
        Property Type As ReportType
        Property Filter As String
        Property Entry As String
    End Class

    Public Sub New(ByVal Type As ReportType, Optional LDAPQuery As String = Nothing)
        Dim NewId = GenerateJobID()
        UserReportContainer = New ContainerUserReport(NewId, "Report - " & Type.ToString, Me)
        UserReportContainer.MainDataGrid.Visible = False

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
        DataGrid = UserReportContainer.GetMainDataGrid()
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

    Public Sub Refresh(Optional Path As String = Nothing)

        Spinner.SpinnerVisible = True

        Dim paras As New Jobparameters With {
            .DataGrid = DataGrid,
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
                End If
        End Select

        GetUsersThread = New Threading.Thread(AddressOf GetUsers) With {.IsBackground = True}
        GetUsersThread.Start(paras)
    End Sub

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
                    .Frozen = True
                    .FillWeight = 80
                    .DefaultCellStyle.BackColor = Color.WhiteSmoke
                End With

                datagrid.Columns.Insert(0, Name)

                For Each column As DataGridViewColumn In datagrid.Columns

                    column.HeaderText = GetFriendlyLDAPName(column.Name)

                    If Not DefaultLDAPColumns.Contains(column.Name) Then
                        column.Visible = False
                    Else
                        column.Width = 260
                        column.FillWeight = 50
                    End If
                Next

                Spinner.Dispose()
                UserReportContainer.MainDataGrid.Visible = True
                TabPage.ResumeLayout()
            End If
        End If
    End Sub

    Private Sub GetUsers(ByVal Param As Jobparameters)

        Dim DataGridPara As DataGridView = Param.DataGrid
        Dim Type As ReportType = Param.Type
        Dim Filter As String = Param.Filter
        Dim EntryPath As String = Param.Entry

        If Not DataGridPara.DataSource Is Nothing Then
            DataGridPara.DataSource.Dispose()
        End If

        Dim dt As New DataTable

        For Each Prop In GetLDAPProps()
            If Not dt.Columns.Contains(Prop) Then
                dt.Columns.Add(New DataColumn(Prop, GetType(String)))
            End If
        Next

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

        If Not My.Settings.LoadAdvLDAP Then
            DirSearcher.PropertiesToLoad.AddRange(GetLDAPProps())
        End If

        Try
            Dim results As SearchResultCollection = DirSearcher.FindAll()

            For Each result As SearchResult In results
                Dim NewRow As DataRow = dt.NewRow

                Dim myResultPropColl As ResultPropertyCollection
                myResultPropColl = result.Properties
                Dim myKey As String
                For Each myKey In myResultPropColl.PropertyNames
                    If Not dt.Columns.Contains(myKey) Then
                        dt.Columns.Add(New DataColumn(myKey, GetType(String)))
                    End If
                Next myKey

                For Each column As DataColumn In dt.Columns()
                    If Not result.Properties(column.ColumnName) Is Nothing Then
                        If result.Properties(column.ColumnName).Count > 0 Then
                            If result.Properties(column.ColumnName).Count > 1 Then
                                For i As Integer = 0 To result.Properties(column.ColumnName).Count - 1
                                    NewRow.Item(column.ColumnName) = result.Properties(column.ColumnName).Item(i).ToString
                                Next
                            Else
                                If result.Properties(column.ColumnName).Item(0).GetType() = GetType(Byte()) Then
                                    Try
                                        Dim DecodedByte As Guid = New Guid(DirectCast(result.Properties(column.ColumnName).Item(0), Byte()))
                                        NewRow.Item(column.ColumnName) = DecodedByte.ToString
                                    Catch
                                        NewRow.Item(column.ColumnName) = ""
                                    End Try
                                Else
                                    NewRow.Item(column.ColumnName) = result.Properties(column.ColumnName).Item(0).ToString
                                End If
                            End If
                        End If
                    Else
                        NewRow.Item(column.ColumnName) = ""
                    End If
                Next
                dt.Rows.Add(NewRow)
            Next

            ApplyDataSource(DataGridPara, dt)
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