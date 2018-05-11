Imports System
Imports System.Drawing
Imports SimpleLib.Enums

Public Class FormAlert

    Public Sub New(ByVal Message As String, AlertType As AlertType)
        InitializeComponent()

        MainLb.Text = Message

        Select Case AlertType
            Case AlertType.ErrorAlert
                MainPb.Image = New Icon(My.Resources.Failed, New Size(48, 48)).ToBitmap
                Text = "Error"
                TitleLb.Text = "An Error Occured"
            Case AlertType.AccessDenied
                MainPb.Image = New Icon(My.Resources.Lock, New Size(48, 48)).ToBitmap
                Text = "Access Denied"
                TitleLb.Text = "Unauthorised"
            Case AlertType.Warning
                MainPb.Image = New Icon(My.Resources.Warning, New Size(48, 48)).ToBitmap
                Text = "Warning"
                TitleLb.Text = "Warning"
            Case AlertType.Success
                MainPb.Image = New Icon(My.Resources.Success, New Size(48, 48)).ToBitmap
                Text = "Success"
                TitleLb.Text = "Operation Complete"
        End Select

    End Sub

    Public Overloads Shared Sub Show(ByVal Message As String, AlertType As AlertType)

        Dim AlertForm As FormAlert =
                New FormAlert(Message, AlertType)

        AlertForm.ShowDialog()

    End Sub

    Private Sub CloseBn_Click(sender As Object, e As EventArgs) Handles CloseBn.Click
        Me.Close()
    End Sub

End Class