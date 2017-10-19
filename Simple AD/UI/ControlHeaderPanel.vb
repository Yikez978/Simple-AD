Public Class ControlHeaderPanel
    Inherits Panel

    Private Sub ControlHeaderPanel_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As ControlHeaderPanel = Me
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)
            e.Graphics.DrawLine(Pen, 0, 0, s.Width, 0)
        End If
    End Sub
End Class
