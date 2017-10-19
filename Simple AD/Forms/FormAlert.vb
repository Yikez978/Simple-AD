Public Class FormAlert

    Public Sub New(ByVal Message As String, AlertType As AlertType)
        InitializeComponent()

        MainLb.Text = Message

        Select Case AlertType
            Case AlertType.ErrorAlert
                MainPb.Image = My.Resources.Failed
                Text = "Error"
            Case AlertType.Success
                MainPb.Image = My.Resources.Success
                Text = "Success"
        End Select

    End Sub

    Private Sub CloseBn_Click(sender As Object, e As EventArgs) Handles CloseBn.Click
        Me.Close()
    End Sub
End Class