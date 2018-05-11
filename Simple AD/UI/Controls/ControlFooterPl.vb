Imports System.Drawing
Imports System.Windows.Forms

Public Class ControlFooterPl
    Inherits Panel

    Private Sub ControlFooterPl_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As ControlFooterPl = Me
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, 0, s.Width, 0)
        End If
    End Sub

End Class
