Imports System.Drawing
Imports SimpleLib.Enums

Public Class FormConfirmation

    Public Sub New(ByVal Message As String, ByVal Type As ConfirmationType)

        InitializeComponent()

        MainLb.Text = Message
        DialogResult = DialogResult.Cancel

        Select Case Type
            Case ConfirmationType.Delete
                MainPb.Image = New Icon(My.Resources.Delete, New Size(48, 48)).ToBitmap
                AcceptBn.Text = "Delete"
            Case ConfirmationType.Close
                MainPb.Image = New Icon(My.Resources._Exit, New Size(48, 48)).ToBitmap
                AcceptBn.Text = "Exit"
            Case ConfirmationType.Warning
                MainPb.Image = New Icon(My.Resources.Warning, New Size(48, 48)).ToBitmap
                AcceptBn.Text = "Accept"
        End Select
    End Sub

    Private Sub AcceptBn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AcceptBn.Click
        DialogResult = DialogResult.Yes
        Close()
    End Sub

    Private Sub CancelBn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CancelBn.Click
        DialogResult = DialogResult.No
        Close()
    End Sub
End Class