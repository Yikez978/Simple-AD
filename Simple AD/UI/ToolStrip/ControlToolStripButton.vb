Public Class ControlToolStripButton

    Public Property Image As Image
    Public Overrides Property Text As String

    Public Event ButtonClicked(sender As Object, e As MouseEventArgs)

    Public Sub New()
        InitializeComponent()
        Me.Size = New Size(56, 72)
    End Sub

    Private Sub ControlToolStripButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = Color.FromArgb(197, 197, 197)
    End Sub

    Private Sub ControlToolStripButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = Color.FromArgb(241, 241, 241)
    End Sub

    Private Sub OnClicked(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            RaiseEvent ButtonClicked(sender, e)
        End If
    End Sub

    Private Sub ControlToolStripButton_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim Rect As Rectangle = Me.DisplayRectangle

        Dim ImageX As Integer = Convert.ToInt32(Width / 2) - Convert.ToInt32(Image.Width / 2)
        Dim ImageY As Integer = Convert.ToInt32(Height / 2) - (Convert.ToInt32(Image.Height / 2) + 12)

        'Dim ImageRect = New Rectangle(New Point(ImageX, ImageY), New Size(Image.Width, Image.Height))
        'e.Graphics.DrawRectangle(Pens.Purple, ImageRect)

        e.Graphics.DrawImage(Image, ImageX, ImageY, Image.Width, Image.Height)

        Dim TextX As Integer = Rect.Location.X
        Dim TextY As Integer = Rect.Location.Y + 38

        Dim TextRect As Rectangle = New Rectangle(New Point(TextX, TextY), New Size(Rect.Width - 1, Rect.Height - (Rect.Location.Y + 38)))

        'e.Graphics.DrawRectangle(Pens.Purple, TextRect)

        Dim Font As New Font("Segoe Ui", 8, FontStyle.Regular, GraphicsUnit.Point)
        Try
            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.WordBreak Or TextFormatFlags.VerticalCenter
            TextRenderer.DrawText(e.Graphics, Text, Font, TextRect, Color.FromArgb(68, 68, 68), flags)
        Finally
            Font.Dispose()
        End Try

    End Sub
End Class
