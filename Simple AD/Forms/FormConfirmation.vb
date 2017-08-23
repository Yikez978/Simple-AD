Public Class FormConfirmation

    Public Sub New(ByVal Message As String, ByVal Type As ConfirmationType)

        InitializeComponent()

        MainLb.Text = Message
        DialogResult = DialogResult.Cancel

        Select Case Type
            Case ConfirmationType.Delete
                MainPb.Image = My.Resources.Delete
                AcceptBn.Text = "Delete"
        End Select
    End Sub

    Private Sub AcceptBn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AcceptBn.Click

        DialogResult = DialogResult.Yes
        Close()
    End Sub

    Private Sub CancelBn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CancelBn.Click

        DialogResult = Windows.Forms.DialogResult.No
        Close()
    End Sub
End Class