Public Class MenuItemLarge

    Private Property Icon As Icon
    Private Property Title As String
    Private Property Description As String

    Private IconRight As Icon

    Public Sub New(ByVal t As String, ByVal d As String, ByVal i As Icon)

        InitializeComponent()

        Icon = i
        Title = t
        Description = d

        BackColor = Color.FromArgb(241, 241, 241)

    End Sub

    Private Sub MenuItemLarge_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = Color.FromArgb(197, 197, 197)
    End Sub

    Private Sub MenuItemLarge_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = Color.FromArgb(241, 241, 241)
    End Sub

    Private Sub MenuItemLarge_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim Rect As Rectangle = DisplayRectangle

        Dim ImageToDraw0 As Image = New Icon(Icon, New Size(48, 48)).ToBitmap
        Dim ImageToDraw1 As Image = New Icon(My.Resources.Forward, New Size(32, 32)).ToBitmap

        Dim Image0X As Integer = 16
        Dim Image0Y As Integer = CInt((Height / 2) - (ImageToDraw0.Height / 2))

        Dim Image1X As Integer = Width - 4 - ImageToDraw1.Width
        Dim Image1Y As Integer = CInt((Height / 2) - (ImageToDraw1.Height / 2))

        Dim ImageRect0 As Rectangle = New Rectangle(New Point(Image0X, Image0Y), New Size(ImageToDraw0.Width, ImageToDraw0.Height))
        Dim ImageRect1 As Rectangle = New Rectangle(New Point(Image1X, Image1Y), New Size(ImageToDraw1.Width, ImageToDraw1.Height))

        'e.Graphics.DrawRectangle(Pens.Purple, ImageRect)

        Dim Font0 As New Font("Segoe Ui", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim Font1 As New Font("Segoe Ui", 8, FontStyle.Regular, GraphicsUnit.Point)

        e.Graphics.DrawImage(ImageToDraw0, Image0X, Image0Y, ImageToDraw0.Width, ImageToDraw0.Height)
        e.Graphics.DrawImage(ImageToDraw1, Image1X, Image1Y, ImageToDraw1.Width, ImageToDraw1.Height)

        Dim Text0X As Integer = 16 + ImageToDraw0.Width + 8
        Dim Text0Y As Integer = 16

        Dim Text1X As Integer = 16 + ImageToDraw0.Width + 8
        Dim Text1Y As Integer = 16 + CInt(e.Graphics.MeasureString(Title, Font0).Height) + 4

        Dim TextRect0 As Rectangle = New Rectangle(New Point(Text0X, Text0Y), New Size(CInt(e.Graphics.MeasureString(Title, Font0).Width) + 8, CInt(e.Graphics.MeasureString(Title, Font0).Height)))
        Dim TextRect1 As Rectangle = New Rectangle(New Point(Text1X, Text1Y), New Size(CInt(e.Graphics.MeasureString(Description, Font1).Width) + 8, CInt(e.Graphics.MeasureString(Description, Font1).Height)))

        'e.Graphics.DrawRectangle(Pens.Purple, TextRect0)
        'e.Graphics.DrawRectangle(Pens.Purple, TextRect1)

        Try
            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            TextRenderer.DrawText(e.Graphics, Title, Font0, TextRect0, Color.FromArgb(68, 68, 68), flags)
            TextRenderer.DrawText(e.Graphics, Description, Font1, TextRect1, Color.FromArgb(82, 42, 102), flags)
        Finally
            Font0.Dispose()
            Font1.Dispose()
        End Try

        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(217, 217, 217)), New Rectangle(New Point(0, 0), New Size(Width - 1, Height - 1)))

    End Sub

End Class
