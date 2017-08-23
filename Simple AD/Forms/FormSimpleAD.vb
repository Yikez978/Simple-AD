Imports System.Runtime.InteropServices

Public Class FormSimpleAD
    Inherits Forms.MetroForm

    Private _BackColor = SystemColors.ControlDarkDark
    Private _ForeColor = SystemColors.Window

    Private Const borderWidth As Integer = 5

    Public Sub New()
        Me.ShadowType = Forms.MetroFormShadowType.None
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

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

    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)

        Dim backColor As Color = CustomBackcolor
        Dim foreColor As Color = CustomForecolor

        e.Graphics.Clear(backColor)

        If DisplayHeader Then
            Dim bounds As New Rectangle(20, 20, ClientRectangle.Width - 2 * 20, 40)
            Dim flags As TextFormatFlags = TextFormatFlags.EndEllipsis 'Or GetTextFormatFlags()
            TextRenderer.DrawText(e.Graphics, Text, MetroFonts.Title, bounds, foreColor, flags)
        End If

        Using b As New SolidBrush(CustomBackcolor)
            Dim topRect As New Rectangle(0, 0, Width, borderWidth)
            e.Graphics.FillRectangle(b, topRect)
        End Using

        Dim BorderPen As New Pen(Color.FromArgb(124, 65, 153), 1)
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.DrawRectangle(BorderPen, rect)
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
        ' width of ellipse
    End Function

    <DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Public Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function

    Private m_aeroEnabled As Boolean
    ' variables for box shadow
    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const WM_NCPAINT As Integer = &H85
    Private Const WM_ACTIVATEAPP As Integer = &H1C

    Public Structure MARGINS
        ' struct for box shadow
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure

    Private Const WM_NCHITTEST As Integer = &H84
    ' variables for dragging the form
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            m_aeroEnabled = CheckAeroEnabled()

            Dim cp As CreateParams = MyBase.CreateParams
            If Not m_aeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            End If

            Return cp
        End Get
    End Property

    Private Function CheckAeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            DwmIsCompositionEnabled(enabled)
            Return If((enabled = 1), True, False)
        End If
        Return False
    End Function

    Protected Overrides Sub WndProc(ByRef message As Message)
        Select Case message.Msg
            Case WM_NCPAINT
                ' box shadow
                If m_aeroEnabled Then
                    Dim v = 2
                    DwmSetWindowAttribute(Me.Handle, 2, v, 4)
                    Dim margins As New MARGINS() With {
                        .bottomHeight = 1,
                        .leftWidth = 1,
                        .rightWidth = 1,
                        .topHeight = 1
                    }

                    DwmExtendFrameIntoClientArea(Me.Handle, margins)
                End If
                Exit Select
            Case Else
                Exit Select
        End Select

        'Code to allow rezing borderless forms
        MyBase.WndProc(message)
        If Me.Resizable Then
            If message.Msg = WM_NCHITTEST AndAlso CInt(message.Result) = HTCLIENT Then
                ' drag the form
                message.Result = New IntPtr(HTCAPTION)
            End If


            If message.Msg = &H84 Then
                ' WM_NCHITTEST
                Dim cursor__1 = Me.PointToClient(Cursor.Position)

                If TopLeft.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTTOPLEFT)
                ElseIf TopRight.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTTOPRIGHT)
                ElseIf BottomLeft.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTBOTTOMLEFT)
                ElseIf BottomRight.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTBOTTOMRIGHT)

                ElseIf Top.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTTOP)
                ElseIf Left.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTLEFT)
                ElseIf Right.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTRIGHT)
                ElseIf Bottom.Contains(cursor__1) Then
                    message.Result = New IntPtr(HTBOTTOM)
                End If
            End If
        End If
    End Sub


    Private Const HTLEFT As Integer = 10, HTRIGHT As Integer = 11, HTTOP As Integer = 12, HTTOPLEFT As Integer = 13, HTTOPRIGHT As Integer = 14, HTBOTTOM As Integer = 15,
    HTBOTTOMLEFT As Integer = 16, HTBOTTOMRIGHT As Integer = 17

    Const Value As Integer = 10

    Private Overloads ReadOnly Property Top() As Rectangle
        Get
            Return New Rectangle(0, 0, Me.ClientSize.Width, Value)
        End Get
    End Property
    Private Overloads ReadOnly Property Left() As Rectangle
        Get
            Return New Rectangle(0, 0, Value, Me.ClientSize.Height)
        End Get
    End Property
    Private Overloads ReadOnly Property Bottom() As Rectangle
        Get
            Return New Rectangle(0, Me.ClientSize.Height - Value, Me.ClientSize.Width, Value)
        End Get
    End Property
    Private Overloads ReadOnly Property Right() As Rectangle
        Get
            Return New Rectangle(Me.ClientSize.Width - Value, 0, Value, Me.ClientSize.Height)
        End Get
    End Property

    Private ReadOnly Property TopLeft() As Rectangle
        Get
            Return New Rectangle(0, 0, Value, Value)
        End Get
    End Property
    Private ReadOnly Property TopRight() As Rectangle
        Get
            Return New Rectangle(Me.ClientSize.Width - Value, 0, Value, Value)
        End Get
    End Property
    Private ReadOnly Property BottomLeft() As Rectangle
        Get
            Return New Rectangle(0, Me.ClientSize.Height - Value, Value, Value)
        End Get
    End Property
    Private ReadOnly Property BottomRight() As Rectangle
        Get
            Return New Rectangle(Me.ClientSize.Width - Value, Me.ClientSize.Height - Value, Value, Value)
        End Get
    End Property
End Class

