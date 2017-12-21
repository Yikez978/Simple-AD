Public Class FormAlert

    Public Sub New(ByVal Message As String, AlertType As AlertType)
        InitializeComponent()

        MainLb.Text = Message

        Select Case AlertType
            Case AlertType.ErrorAlert
                MainPb.Image = New Icon(My.Resources.Failed, New Size(48, 48)).ToBitmap
                Text = "Error"
            Case AlertType.Success
                MainPb.Image = New Icon(My.Resources.Success, New Size(48, 48)).ToBitmap
                Text = "Success"
        End Select

    End Sub

    Private Sub CloseBn_Click(sender As Object, e As EventArgs) Handles CloseBn.Click
        Me.Close()
    End Sub
End Class