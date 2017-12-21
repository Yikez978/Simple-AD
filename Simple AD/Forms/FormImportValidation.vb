Public Class FormImportValidation

    Private DataTable As New DataTable()
    Private view As DataView

    Public Property Errors As New List(Of ImportError)

    Public Sub Add(ByVal ErrorType As String, ByVal Details As String)
        Errors.Add(New ImportError With {.ErrorName = ErrorType, .ErrorMessage = Details})
    End Sub

    Private Sub ImportValidationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorListView.SetObjects(Errors)
    End Sub

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        'UserImport()
        Me.Dispose()
    End Sub

    Public Class ImportError
        Public Property ErrorName As String
        Public Property ErrorMessage As String
    End Class

End Class