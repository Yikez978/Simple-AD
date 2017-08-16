Public Class FormError

    Private _ErrorBodyText As String
    Private _ErrorImage As Image

    Public Sub New(ByVal _ErrorText As String, Image As Image)
        InitializeComponent()

        Me._ErrorBodyText = _ErrorText
        Me._ErrorImage = Image

        MainLb.Text = _ErrorText
        MainPb.Image = _ErrorImage
    End Sub

    Private Sub CloseBn_Click(sender As Object, e As EventArgs) Handles CloseBn.Click
        Me.Close()
    End Sub
End Class