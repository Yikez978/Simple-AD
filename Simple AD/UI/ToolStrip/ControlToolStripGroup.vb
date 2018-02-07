Imports System.Drawing
Imports System.Windows.Forms

Public Class ControlToolStripGroup

    Public Property DisplayText As String

    Public Sub New()
        InitializeComponent()

        BackColor = Color.FromArgb(245, 246, 247)

        Width = 12
    End Sub

    Private Sub ControlToolStripGroup_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim Rect As Rectangle = Me.DisplayRectangle
        'e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Rect.Location, New Size(Rect.Width - 1, Rect.Height - 1)))

        Dim TextRect As Rectangle = New Rectangle(Rect.Location, New Size(Rect.Width, Rect.Height - 4))

        Dim Font As New Font("Segoe Ui", 8, FontStyle.Regular, GraphicsUnit.Point)
        Try
            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.Bottom
            TextRenderer.DrawText(e.Graphics, DisplayText, Font, TextRect, Color.FromArgb(49, 12, 66), flags)
        Finally
            Font.Dispose()
        End Try

    End Sub

    Private Sub ControlToolStripGroup_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        Width = Width + e.Control.Width + 3
    End Sub
End Class
