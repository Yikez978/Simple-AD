Imports System.Drawing

Public Class FormNewOu

    Public Property OuName As String

    Public Sub New()

        InitializeComponent()

        DialogResult = DialogResult.Cancel
        ContainerLb.Text = GetMainDomainTreeView.SelectedNode.Text
        NameTb.Select()

        MainPb.Image = New Icon(My.Resources.ContainerSelected, New Size(32, 32)).ToBitmap

    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub

    Private Sub OkBn_Click(sender As Object, e As EventArgs) Handles OkBn.Click

        If Not String.IsNullOrEmpty(NameTb.Text) Then
            OuName = NameTb.Text
            DialogResult = DialogResult.Yes
        End If

    End Sub

    Private Sub NameTb_TextChanged(sender As Object, e As EventArgs) Handles NameTb.TextChanged
        If String.IsNullOrEmpty(NameTb.Text) Then
            OkBn.Enabled = False
        Else
            OkBn.Enabled = True
        End If
    End Sub
End Class