Public Class ContainerUserReport
    Inherits UserControl

    Private _ID As Integer
    Private _Job As JobUserReport
    Private _JobName As String
    Private _Path As String

    Private WithEvents _ControlDomainTreeView As ControlDomainTreeView

    Private DataTableSource As DataTable

    Public Property ID As Integer
        Set(value As Integer)
            _ID = value
        End Set
        Get
            Return _ID
        End Get
    End Property

    Public Property JobName As String
        Set(value As String)
            _JobName = value
        End Set
        Get
            Return _JobName
        End Get
    End Property

    Public Property Path As String
        Set(value As String)
            _Path = value
        End Set
        Get
            Return _Path
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

    Public Sub New(ByVal ID As Integer, ByVal JobName As String, ByVal Job As JobUserReport)

        Me.ID = ID
        Me.JobName = JobName

        Me.Dock = DockStyle.Fill
        InitializeComponent()

        _Job = Job
        _ControlDomainTreeView = Me.DomainTreeView
    End Sub

    Public Function GetMainDataGrid() As DataGridView
        Return Me.MainDataGrid
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeView
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
        Try
            If Not MainDataGrid.Rows(e.RowIndex).Cells("objectClass").Value Is Nothing Then

                Dim ObjectClass As String = MainDataGrid.Rows(e.RowIndex).Cells("objectClass").Value.ToString

                If MainDataGrid.Columns.Contains("name") Then

                    Dim CellImage As TextAndImageCell = DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)

                    Select Case ObjectClass
                        Case "user"
                            If MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "546" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "514" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "66082" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "66050" Then
                                CellImage.Image = IconDisabledUSer
                            Else
                                CellImage.Image = IconUser
                            End If
                        Case "computer"
                            CellImage.Image = IconComputer
                        Case "group"
                            CellImage.Image = IconGroup
                        Case "container"
                            CellImage.Image = IconContainer
                        Case "organizationalUnit"
                            CellImage.Image = IconOU
                        Case "contact"
                            CellImage.Image = IconContact
                        Case Else
                            CellImage.Style.ForeColor = SystemColors.ControlDarkDark
                    End Select
                End If
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] CellFormatting Failed: " & Ex.Message)
        End Try
    End Sub

    Private Sub MainDataGrid_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click, MainDataGrid.CellMouseDoubleClick
        Try
            Dim oClass As String = MainDataGrid.SelectedRows(0).Cells("objectClass").Value.ToString
            Select Case True
                Case (oClass = "container" Or oClass = "organizationalUnit")
                    Me.Path = MainDataGrid.SelectedRows(0).Cells("distinguishedName").Value
                    _Job.Refresh(Path)
                Case (oClass = "user" Or oClass = "group" Or oClass = "computer")
                    If Not IsDBNull(MainDataGrid.SelectedRows(0).Cells("sAMAccountName").Value) Then
                        Dim Sam = MainDataGrid.SelectedRows(0).Cells("sAMAccountName").Value
                        Dim Name = MainDataGrid.SelectedRows(0).Cells("name").Value
                        Dim ShowUserProps = New FormUserAttributes(Sam, Name, MainDataGrid.SelectedRows(0).Index)
                    End If
                Case Else
            End Select
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to load object properties Form: " & Ex.Message)
        End Try
    End Sub

    Private Sub BulkModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkModifyToolStripMenuItem.Click
        Dim SelectedRows As List(Of UserRow) = GetSelectedUsers()
        Dim NewBulkModifyForm = New FormUserAttributesBulk(SelectedRows)
    End Sub

    Private Sub MainDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MainDataGrid.CellMouseClick
        If MainDataGrid.SelectedRows.Count > 0 Then
            If MainDataGrid.SelectedRows.Count = 1 Then
                GetDataGridViewConextMenu(MainDataGrid, e, SingleContextMenu, sender)
            Else
                GetDataGridViewConextMenu(MainDataGrid, e, BulkContextMenu, sender)
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
        Dim User = GetSelectedUser()
        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & User & "?", ConfirmationType.Delete)
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then
            If DeleteADObject(User) Then
                MainDataGrid.Rows.RemoveAt(MainDataGrid.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Private Function GetSelectedUsers() As List(Of UserRow)
        Try
            Dim UserArray As New List(Of UserRow)

            For Each Row As DataGridViewRow In MainDataGrid.SelectedRows
                If Not String.IsNullOrEmpty(Row.Cells("sAMAccountName").Value) Then
                    Dim User = New UserRow With {.Username = Row.Cells("sAMAccountName").Value, .Row = Row}
                    UserArray.Add(User)
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
            For Each User As UserRow In GetSelectedUsers()

                Dim Username As String = User.Username
                Dim Row As DataGridViewRow = User.Row

                If IsAccountEnabled(Username) Then
                    Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(Username)
                    If Not IsEnableAccountSuccessfull = Nothing Then
                        Row.Cells("userAccountControl").Value = IsEnableAccountSuccessfull
                        MainDataGrid.InvalidateRow(Row.Index)
                    End If
                Else
                    Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(Username)
                    If Not IsDisnableAccountSuccessfull = Nothing Then
                        Row.Cells("userAccountControl").Value = IsDisnableAccountSuccessfull
                        MainDataGrid.InvalidateRow(Row.Index)
                    End If
                End If
            Next
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim SelectedUsers As List(Of UserRow) = GetSelectedUsers()
        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & SelectedUsers.Count & " objects?", ConfirmationType.Delete)
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then
            For Each User As UserRow In SelectedUsers
                If DeleteADObject(User.Username) Then
                    MainDataGrid.Rows.Remove(User.Row)
                End If
            Next
        End If
    End Sub

    Private Sub MoveSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveSingleToolStripMenuItem.Click
        Dim User = GetSelectedUser()
        Dim MoveForm = New FormMoveObject
        MoveForm.ShowDialog()
        If MoveForm.DialogResult = DialogResult.Yes Then
            If MoveADObject(User, MoveForm.SelecetdOU) = True Then
                Dim ResultForm = New FormAlert(User & " has been moved to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.Success)
                ResultForm.ShowDialog()
            Else
                Dim ResultForm = New FormAlert("An Error occured while trying to move" & User & " to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.ErrorAlert)
                ResultForm.ShowDialog()
            End If
        End If
    End Sub

    Public Sub SelecetdOu_changed(ByVal Path As String) Handles _ControlDomainTreeView.SelectedOUChanged
        Me.Path = Path
        _Job.Refresh(Path)
    End Sub

End Class

Public Class UserRow
    Property Username As String
    Property Row As DataGridViewRow
End Class
