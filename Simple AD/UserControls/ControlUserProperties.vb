Public Class ControlUserProperties
    Inherits UserControl

    Dim User As UserObject

    Private Username As String
    Private Password As String
    Private DisplayName As String
    Private Firstname As String
    Private Surname As String
    Private HomeDrive As String
    Private HomeDirectory As String
    Private Pager As String
    Private Description As String
    Private MailDomain As String
    Private TsProfilePath As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub UpdateProperties(DataGrid As DataGridView)

        DataGridView.Rows.Clear()

        Username = DataGrid.SelectedRows.Item(0).Cells("Username").Value.ToString
        Password = DataGrid.SelectedRows.Item(0).Cells("Password").Value.ToString
        DisplayName = DataGrid.SelectedRows.Item(0).Cells("DisplayName").Value.ToString
        Firstname = DataGrid.SelectedRows.Item(0).Cells("Firstname").Value.ToString
        Surname = DataGrid.SelectedRows.Item(0).Cells("Surname").Value.ToString
        HomeDrive = DataGrid.SelectedRows.Item(0).Cells("HomeDrive").Value.ToString
        HomeDirectory = DataGrid.SelectedRows.Item(0).Cells("HomeDirectory").Value.ToString
        Pager = DataGrid.SelectedRows.Item(0).Cells("Pager").Value.ToString
        Description = DataGrid.SelectedRows.Item(0).Cells("Description").Value.ToString
        MailDomain = DataGrid.SelectedRows.Item(0).Cells("MailDomain").Value.ToString
        TsProfilePath = DataGrid.SelectedRows.Item(0).Cells("TsProfilePath").Value.ToString


        User = New UserObject(Username, Password, DisplayName, Firstname, Surname, HomeDrive, HomeDirectory, Pager, Description, MailDomain, TsProfilePath)

        For Each Item As System.Reflection.PropertyInfo In User.GetType().GetProperties()
            DataGridView.Rows.Add(Item.Name, Item.GetValue(User))
        Next

        For Each control As Control In Me.Controls
            control.Enabled = True
        Next

    End Sub

    Public Sub DisableControls()
        For Each control As Control In Me.Controls
            control.Enabled = False
        Next
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)
        FormMain.GetMainSplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub DataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        FormMain.GetMainDataGrid.SelectedRows.Item(0).Cells(DataGridView.Rows(e.RowIndex).Cells.Item(0).Value.ToString).Value = DataGridView.Rows(e.RowIndex).Cells.Item(1).Value
    End Sub

    Private Sub DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseClick
        Me.DataGridView.BeginEdit(True)
    End Sub
End Class
