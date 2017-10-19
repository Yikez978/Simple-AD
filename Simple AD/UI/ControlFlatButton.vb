Imports System.ComponentModel

Public Class ControlFlatButton
    Inherits Panel

#Region "Properties"

    Private OnClicked As Boolean

    Private m_Backcolor As Color = Color.Empty
    <Browsable(True), Description("The background color used to display text and graphics in a control.")>
    Public Overrides Property BackColor() As Color
        Get
            If m_Backcolor.Equals(Color.Empty) Then
                Return Me.DefaultBackColor
            End If
            Return m_Backcolor
        End Get
        Set(ByVal Value As Color)
            If m_Backcolor.Equals(Value) Then Return
            m_Backcolor = Value
            Invalidate()
        End Set
    End Property

    Private m_Forecolor As Color = Color.Empty
    <Browsable(True), Description("The background color used to display text and graphics in a control.")>
    Public Overrides Property ForeColor() As Color
        Get
            If m_Forecolor.Equals(Color.Empty) Then
                Return Me.DefaultForeColor
            End If
            Return m_Forecolor
        End Get
        Set(ByVal Value As Color)
            If m_Forecolor.Equals(Value) Then Return
            m_Forecolor = Value
            Invalidate()
        End Set
    End Property

    Private m_DefaultBackColor As Color
    Public Overloads Property DefaultBackColor() As Color
        Get
            If m_DefaultBackColor.Equals(Color.Empty) Then
                If Parent Is Nothing Then
                    Return Control.DefaultBackColor
                Else
                    Return SystemColors.Window
                End If
            End If
            Return m_DefaultBackColor
        End Get
        Set(ByVal Value As Color)
            If m_DefaultBackColor.Equals(Value) Then Return
            m_DefaultBackColor = Value
            Invalidate()
        End Set
    End Property

    Private m_DefaultForeColor As Color = Color.Empty
    Public Overloads Property DefaultForeColor() As Color
        Get
            If m_DefaultForeColor.Equals(Color.Empty) Then
                If Parent Is Nothing Then
                    Return Control.DefaultForeColor
                Else
                    Return Color.FromArgb(238, 238, 238)
                End If
            End If
            Return m_DefaultForeColor
        End Get
        Set(ByVal Value As Color)
            If m_DefaultForeColor.Equals(Value) Then Return
            m_DefaultForeColor = Value
            Invalidate()
        End Set
    End Property

    <Browsable(True), Description("The Buttons Label Text.")>
    Public Overrides Property Text As String

    Public Property HoverColor As Color
    Public Property OnClickColor As Color

#End Region

    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub ControlFlatButton_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackColor = Me.HoverColor
        Me.Invalidate()
    End Sub

    Private Sub ControlFlatButton_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.OnClicked = False
        Me.BackColor = Me.DefaultBackColor
        Me.ForeColor = SystemColors.ControlDarkDark

        Me.Invalidate()
    End Sub

    Private Sub ControlFlatButton_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.OnClicked = True
        Me.BackColor = Me.OnClickColor
        Me.Forecolor = Color.White
        Me.Refresh()
    End Sub

    Private Overloads Sub ControlFlatButton_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As ControlFlatButton = Me
        If Not s Is Nothing Then
            DrawLabel(e.Graphics)
            DrawIcon(e.Graphics)
        End If
    End Sub

    Private Sub DrawLabel(ByVal Graphics As Graphics)

        Dim TextToDraw As String = Text
        Dim Font As Font = Me.Font
        Dim Brush As New SolidBrush(ForeColor)
        Dim Location As New Point(32, 6)

        Graphics.DrawString(TextToDraw, Font, Brush, Location)

    End Sub

    Private Sub DrawIcon(ByVal Graphics As Graphics)

        Dim ImageToDraw As Image = New Bitmap(My.Resources.Import, 24, 24)

        Dim ImageY As Integer = ((Me.Height / 2) - (ImageToDraw.Height / 2))

        Dim Location As New Point(8, ImageY)

        If Me.OnClicked Then
            Graphics.DrawImage(ImageToDraw, Location)
        Else
            Graphics.DrawImage(ImageToDraw, Location)
        End If
    End Sub

End Class

