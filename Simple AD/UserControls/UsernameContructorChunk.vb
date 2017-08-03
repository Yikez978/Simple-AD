Public Class UsernameContructorChunk
    Inherits UserControl

    Public Sub New(ByVal Name As String)

        ' This call is required by the designer.
        InitializeComponent()

        MainButton.Text = Name

    End Sub

    Private Sub MainButton_Click(sender As Object, e As EventArgs) Handles MainButton.Click
        Me.Dispose()
    End Sub

    Public Function GetText() As String
        Return MainButton.Text
    End Function

End Class
