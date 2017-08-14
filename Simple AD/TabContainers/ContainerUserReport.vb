Public Class ContainerUserReport
    Inherits UserControl

    Private _ID
    Private _JobName

    Private DataTableSource As DataTable

    Public Property ID
        Set(value)
            _ID = value
        End Set
        Get
            Return _ID
        End Get
    End Property

    Public Property JobName
        Set(value)
            _JobName = value
        End Set
        Get
            Return _JobName
        End Get
    End Property

    Public Property Datasource As DataTable
        Set(value As DataTable)
            DataTableSource = value
            MainDataGrid.DataSource = DataTableSource
            DataTableSource.TableName = "Main"
        End Set
        Get
            Return MainDataGrid.DataSource
        End Get
    End Property

    Public Sub New(ByVal ID As Integer, ByVal JobName As String)

        Me.ID = ID
        Me.JobName = JobName

        Me.Dock = DockStyle.Fill

        InitializeComponent()

        MainDataGrid.DoubleBuffered(True)

        Me.MainSplitContainer.Panel1.Controls.Add(New ControlDomainTreeContainer(Me))
        Me.MainSplitContainer.Panel1Collapsed = True
    End Sub

    Public Function GetMainDataGrid() As DataGridView
        Return Me.MainDataGrid
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeContainer
        Return Me.MainSplitContainer.Panel1.Controls.Item(0)
    End Function

    Private Sub FilterDataGrid(ByVal Query As String)
        Dim FilteredDataView As DataView
        Try
            FilteredDataView = New DataView(DataTableSource, "DisplayName LIKE '*" & Query & "*' OR NAME LIKE '*" & Query & "*'", "DisplayName Desc", DataViewRowState.CurrentRows)
            MainDataGrid.DataSource = FilteredDataView
        Catch Ex As Exception
            Debug.WriteLine("[Error] Invalid Search String: " & Ex.Message)
        End Try
    End Sub

    Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs) Handles SearchBoxTb.TextChanged
        If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
            FilterDataGrid(SearchBoxTb.Text.Trim)
        Else
            MainDataGrid.DataSource = DataTableSource
        End If
    End Sub

    Private Sub MainDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MainDataGrid.CellFormatting
        If MainDataGrid.Columns.Contains("Name") Then
            If e.ColumnIndex = MainDataGrid.Columns("Name").Index Then
                e.CellStyle.BackColor = Color.WhiteSmoke
            End If
        End If

        If String.IsNullOrEmpty(MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountName").Value.ToString) Then
            MainDataGrid.Rows(e.RowIndex).DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
        End If

        Try
            If Not String.IsNullOrEmpty(MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountType").Value.ToString) Then

                Select Case MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountType").Value.ToString
                    Case "805306368"
                        If MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "546" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "514" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "66082" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "66050" Then
                            With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                                .Image = GlobalVariables.IconDisabledUSer
                            End With
                        Else
                            With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                                .Image = GlobalVariables.IconUser
                            End With
                        End If
                    Case "805306369"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconComputer
                        End With
                    Case "268435456"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconGroup
                        End With
                    Case "268435457"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconGroup
                        End With
                    Case "536870912"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconGroup
                        End With
                    Case Else
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconContainer
                        End With
                End Select
            End If

        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub MainDataGrid_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click, MainDataGrid.CellMouseDoubleClick
        Try
            If Not IsDBNull(MainDataGrid.SelectedRows(0).Cells("sAMAccountName").Value) Then
                Dim Sam = MainDataGrid.SelectedRows(0).Cells("sAMAccountName").Value
                Dim Name = MainDataGrid.SelectedRows(0).Cells("Name").Value
                Dim ShowUserProps = New FormUserAttributes(Sam, Name, MainDataGrid.SelectedRows(0).Index)
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to load object properties Form: " & Ex.Message)
        End Try
    End Sub

    Private Sub BulkModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkModifyToolStripMenuItem.Click
        Dim SelectedRows As New List(Of String)

        For Each DatagridviewRow As DataGridViewRow In MainDataGrid.SelectedRows
            SelectedRows.Add(MainDataGrid.Rows.Item(DatagridviewRow.Index).Cells("name").Value)
        Next

        Dim NewBulkModifyForm = New FormUserAttributesBulk(SelectedRows)
    End Sub

    Private Sub MainDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MainDataGrid.CellMouseClick
        If MainDataGrid.SelectedRows.Count > 0 Then
            If MainDataGrid.SelectedRows.Count = 1 Then
                ContextMenuHelper.GetDataGridViewConextMenu(MainDataGrid, e, SingleContextMenu)
            Else
                ContextMenuHelper.GetDataGridViewConextMenu(MainDataGrid, e, BulkContextMenu)
            End If
        End If

    End Sub

    Private Sub EnableDisableSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableSingleToolStripMenuItem.Click
        Try
            Dim Username As String = GetSelectedUser()

            If IsAccountEnabled(Username) Then
                Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(Username)
                If Not IsEnableAccountSuccessfull = Nothing Then
                    MainDataGrid.SelectedRows(0).Cells("userAccountControl").Value = IsEnableAccountSuccessfull
                    MainDataGrid.InvalidateRow(MainDataGrid.SelectedRows(0).Index)
                End If
            Else
                Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(Username)
                If Not IsDisnableAccountSuccessfull = Nothing Then
                    MainDataGrid.SelectedRows(0).Cells("userAccountControl").Value = IsDisnableAccountSuccessfull
                    MainDataGrid.InvalidateRow(MainDataGrid.SelectedRows(0).Index)
                End If
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Function GetSelectedUser() As String
        Try
            If Not String.IsNullOrEmpty(MainDataGrid.SelectedRows(0).Cells("sAMAccountName").Value) Then
                Return MainDataGrid.SelectedRows(0).Cells("sAMAccountName").Value
            Else
                Return Nothing
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to change the active state of the seleceted user account: " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If DeleteADObject(GetSelectedUser()) Then
            MainDataGrid.Rows.RemoveAt(MainDataGrid.SelectedRows(0).Index)
        End If
    End Sub

    Private Function GetSelectedUsers() As List(Of String)
        Try

            Dim UserArray As New List(Of String)

            For Each Row As DataGridViewRow In MainDataGrid.SelectedRows
                If Not String.IsNullOrEmpty(Row.Cells("sAMAccountName").Value) Then
                    UserArray.Add(Row.Cells("sAMAccountName").Value & "," & Row.Index.ToString)
                End If
            Next
            Return UserArray
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to change the active state of the seleceted users: " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub EnableDisableBulkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableBulkToolStripMenuItem.Click
        Try
            For Each User As String In GetSelectedUsers()

                Dim UserArray As String() = User.Split(New Char() {","})
                Dim Username As String = UserArray(0)
                Dim Row As Integer = UserArray(1)

                If IsAccountEnabled(Username) Then
                    Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(Username)
                    If Not IsEnableAccountSuccessfull = Nothing Then
                        MainDataGrid.Rows.Item(Row).Cells("userAccountControl").Value = IsEnableAccountSuccessfull
                        MainDataGrid.InvalidateRow(Row)
                    End If
                Else
                    Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(Username)
                    If Not IsDisnableAccountSuccessfull = Nothing Then
                        MainDataGrid.Rows.Item(Row).Cells("userAccountControl").Value = IsDisnableAccountSuccessfull
                        MainDataGrid.InvalidateRow(Row)
                    End If
                End If
            Next
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub
End Class
