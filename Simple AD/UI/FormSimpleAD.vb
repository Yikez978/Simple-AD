Public Class FormSimpleAD
    Inherits MetroFramework.Forms.MetroForm

    Private _BackColor = SystemColors.ControlDarkDark
    Private _ForeColor = SystemColors.Window

    Private Const borderWidth As Integer = 5

    Public Property CustomBackcolor As Color
        Set(value As Color)
            _BackColor = value
        End Set
        Get
            Return _BackColor
        End Get
    End Property

    Public Property CustomForecolor As Color
        Set(value As Color)
            _ForeColor = value
        End Set
        Get
            Return _ForeColor
        End Get
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        Dim backColor As Color = CustomBackcolor
        Dim foreColor As Color = CustomForecolor

        e.Graphics.Clear(backColor)

        Using b As New SolidBrush(CustomBackcolor)
            Dim topRect As New Rectangle(0, 0, Width, borderWidth)
            e.Graphics.FillRectangle(b, topRect)
        End Using

        If DisplayHeader Then
            Dim bounds As New Rectangle(20, 20, ClientRectangle.Width - 2 * 20, 40)
            Dim flags As TextFormatFlags = TextFormatFlags.EndEllipsis 'Or GetTextFormatFlags()
            TextRenderer.DrawText(e.Graphics, Text, MetroFonts.Title, bounds, foreColor, flags)
        End If

        If Resizable AndAlso (SizeGripStyle = SizeGripStyle.Auto OrElse SizeGripStyle = SizeGripStyle.Show) Then
            Using b As New SolidBrush(SystemColors.Control)
                Dim resizeHandleSize As New Size(2, 2)
                e.Graphics.FillRectangles(b, New Rectangle() {New Rectangle(New Point(ClientRectangle.Width - 6, ClientRectangle.Height - 6), resizeHandleSize), New Rectangle(New Point(ClientRectangle.Width - 10, ClientRectangle.Height - 10), resizeHandleSize), New Rectangle(New Point(ClientRectangle.Width - 10, ClientRectangle.Height - 6), resizeHandleSize), New Rectangle(New Point(ClientRectangle.Width - 6, ClientRectangle.Height - 10), resizeHandleSize), New Rectangle(New Point(ClientRectangle.Width - 14, ClientRectangle.Height - 6), resizeHandleSize), New Rectangle(New Point(ClientRectangle.Width - 6, ClientRectangle.Height - 14), resizeHandleSize)})
            End Using
        End If

    End Sub

End Class

