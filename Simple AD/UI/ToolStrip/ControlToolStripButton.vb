Imports System.Drawing
Imports System.Windows.Forms

Public Class ControlToolStripButton

    Public Property Image As Image
    Private _Enabled As Boolean

    Public Property LabelColor As Color

    Private _DefaultLabelColor As Color = Color.FromArgb(68, 68, 68)
    Private _DisabledLabelColor As Color = Color.FromArgb(165, 165, 166)

    Public Overloads Property Enabled As Boolean
        Set(value As Boolean)
            _Enabled = value
            If Not value Then
                Image = ConvertToGrayScale(Image)
                LabelColor = _DisabledLabelColor
            Else
                Image = Image
                LabelColor = _DefaultLabelColor
            End If
        End Set
        Get
            Return _Enabled
        End Get
    End Property

    Public Overrides Property Text As String

    Public Event ButtonClicked(sender As Object, e As MouseEventArgs)

    Private IsHot As Boolean

    Public Sub New()
        InitializeComponent()
        Size = New Size(56, 72)
        BackColor = Color.FromArgb(245, 246, 247)
    End Sub

    Private Sub ControlToolStripButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Enabled Then
            BackColor = Color.FromArgb(232, 239, 247)
            IsHot = True
        End If
    End Sub

    Private Sub ControlToolStripButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = Color.FromArgb(245, 246, 247)
        IsHot = False
    End Sub

    Private Sub OnClicked(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left And Enabled Then
            RaiseEvent ButtonClicked(sender, e)
        End If
    End Sub

    Private Sub ControlToolStripButton_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim Rect As Rectangle = Me.DisplayRectangle

        Dim BorderRect As Rectangle = New Rectangle(New Point(0, 0), New Size(Width - 1, Height - 1))

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
            TextRenderer.DrawText(e.Graphics, Text, Font, TextRect, LabelColor, flags)
        Finally
            Font.Dispose()
        End Try

        If IsHot And Enabled Then
            e.Graphics.DrawRectangle(New Pen(Color.FromArgb(164, 206, 249)), BorderRect)
        End If

    End Sub
End Class
