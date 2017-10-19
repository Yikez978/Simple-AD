Public Class ControlStatusStrip
    Inherits StatusStrip

    Private Sub ControlHeaderPanel_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As ControlStatusStrip = Me
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(191, 191, 191))
            e.Graphics.DrawLine(Pen, 0, 0, s.Width, 0)
        End If
    End Sub
End Class
