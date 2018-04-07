Imports System.Drawing
Imports System.Windows.Forms

Public Class MenuItemLarge

    Private Property Icon As Icon
    Private Property Title As String
    Private Property Description As String

    Private IsHot As Boolean
    Private IsSelected As Boolean
    Private IconRight As Icon

    Private Shadows DefaultBackColor As Color = SystemColors.Control
    Private HotColor As Color = Color.FromArgb(232, 239, 247)
    Private HotBorderColor As Color = Color.FromArgb(164, 206, 249)
    Private OnClickBackColor As Color = Color.FromArgb(201, 224, 247)
    Private OnClickBorderColor As Color = Color.FromArgb(98, 162, 228)

    Public Sub New(ByVal t As String, ByVal d As String, ByVal i As Icon)

        InitializeComponent()

        BackColor = DefaultBackColor

        Icon = i
        Title = t
        Description = d

    End Sub

    Private Sub MenuItemLarge_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = HotColor
        IsHot = True
    End Sub

    Private Sub MenuItemLarge_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = DefaultBackColor
        IsHot = False
    End Sub

    Private Sub MenuItemLarge_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim Rect As Rectangle = DisplayRectangle

        Dim BorderColor As Color

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

        If IsHot Or IsSelected Then

            If IsSelected Then
                BorderColor = OnClickBorderColor
            Else
                BorderColor = HotBorderColor
            End If

            e.Graphics.DrawRectangle(New Pen(BorderColor), New Rectangle(New Point(0, 0), New Size(Width - 1, Height - 1)))
        End If

        IsSelected = False

    End Sub

    Private Sub MenuItemLarge_Click(sender As Object, e As EventArgs) Handles Me.Click
        BackColor = OnClickBackColor
        IsSelected = True
    End Sub
End Class
