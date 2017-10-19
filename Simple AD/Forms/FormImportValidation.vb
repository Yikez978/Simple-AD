Public Class FormImportValidation

    Private DataTable As New DataTable()
    Private view As DataView

    Public Property Errors As New List(Of List(Of String))

    Public Sub Add(ByVal ErrorType As String, ByVal Details As String)
        Dim ErrorArray As New List(Of String) From {
            ErrorType,
            Details
        }
        Errors.Add(ErrorArray)

    End Sub

    Private Sub ImportValidationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim column As DataColumn

        column = New DataColumn() With {
        .ColumnName = "Error"}

        DataTable.Columns.Add(column)

        column = New DataColumn With {
            .ColumnName = "Details"}

        DataTable.Columns.Add(column)

        For i As Integer = 0 To Errors.Count - 1
            Dim NewRow As DataRow = DataTable.NewRow

            NewRow("Error") = _Errors(i)(0)
            NewRow("Details") = _Errors(i)(1)
            DataTable.Rows.Add(NewRow)
        Next

        view = New DataView(DataTable)

        ErrorDataGrid.DataSource = view

        ErrorDataGrid.Columns("Error").Width = 150
        ErrorDataGrid.Columns("Details").Width = 300
    End Sub

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        UserImport()
        Me.Dispose()
    End Sub

End Class