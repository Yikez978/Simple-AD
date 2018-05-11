Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class CustomTabControlNoHeaders
    Inherits TabControl

    Private _hotTabIndex As Int32 = -1
    Private _SelectedTabColor As Color = SystemColors.ButtonFace
    Private _HotTrackTabColor As Color = Color.FromArgb(211, 191, 221)
    Private _TabColor As Color = SystemColors.Window

    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

    End Sub

    Public Sub InitializeTabControl()
        If DesignMode Then
            ItemSize = New Size(62, 20)
        Else
            ItemSize = New Size(62, 0)
        End If
    End Sub

#Region " Properties "

    Private Property HotTabIndex As Int32
        Get
            Return _hotTabIndex
        End Get
        Set(ByVal value As Int32)
            If _hotTabIndex <> value Then
                _hotTabIndex = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Public Property HotTrackTabColor As Color
        Set(value As Color)
            _HotTrackTabColor = value
        End Set
        Get
            Return _HotTrackTabColor
        End Get
    End Property

    Public Property SelectedTabColor As Color
        Set(value As Color)
            _SelectedTabColor = value
        End Set
        Get
            Return _SelectedTabColor
        End Get
    End Property

    Public Property TabColor As Color
        Set(value As Color)
            _TabColor = value
        End Set
        Get
            Return _TabColor
        End Get
    End Property

    Public Overrides ReadOnly Property DisplayRectangle() As Rectangle
        Get
            Dim tabStripHeight, itemHeight As Int32

            If Me.Alignment <= TabAlignment.Bottom Then
                itemHeight = Me.ItemSize.Height
            Else
                itemHeight = Me.ItemSize.Width
            End If

            If Me.Appearance = TabAppearance.Normal Then
                tabStripHeight = 3 + (itemHeight * Me.RowCount)
            Else
                tabStripHeight = (itemHeight) * Me.RowCount
            End If
            Select Case Me.Alignment
                Case TabAlignment.Top
                    Return New Rectangle(0, tabStripHeight, Width, Height - tabStripHeight)
                Case TabAlignment.Bottom
                    Return New Rectangle(4, 4, Width - 8, Height - tabStripHeight - 4)
                Case TabAlignment.Left
                    Return New Rectangle(tabStripHeight, 4, Width - tabStripHeight - 4, Height - 8)
                Case TabAlignment.Right
                    Return New Rectangle(4, 4, Width - tabStripHeight - 4, Height - 8)
            End Select
        End Get
    End Property

#End Region

#Region "Double Buffer"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        SendMessage(Me.Handle, TVM_SETEXTENDEDSTYLE, New IntPtr(TVS_EX_DOUBLEBUFFER), New IntPtr(TVS_EX_DOUBLEBUFFER))
        MyBase.OnHandleCreated(e)
    End Sub

    Private Const TVM_SETEXTENDEDSTYLE As Integer = &H1100 + 44
    Private Const TVM_GETEXTENDEDSTYLE As Integer = &H1100 + 45
    Private Const TVS_EX_DOUBLEBUFFER As Integer = &H4

#End Region

#Region " BackColor Manipulation "

    'As well as exposing the property to the Designer we want it to behave just like any other 
    'controls BackColor property so we need some clever manipulation.
    Private m_Backcolor As Color = Color.Empty
    <Browsable(True), Description("The background color used to display text and graphics in a control.")>
    Public Overrides Property BackColor() As Color
        Get
            If m_Backcolor.Equals(Color.Empty) Then
                If Parent Is Nothing Then
                    Return Control.DefaultBackColor
                Else
                    Return Parent.BackColor
                End If
            End If
            Return m_Backcolor
        End Get
        Set(ByVal Value As Color)
            If m_Backcolor.Equals(Value) Then Return
            m_Backcolor = Value
            Invalidate()
            'Let the Tabpages know that the backcolor has changed.
            MyBase.OnBackColorChanged(EventArgs.Empty)
        End Set
    End Property
    Public Function ShouldSerializeBackColor() As Boolean
        Return Not m_Backcolor.Equals(Color.Empty)
    End Function
    Public Overrides Sub ResetBackColor()
        m_Backcolor = Color.Empty
        Invalidate()
    End Sub

#End Region

#Region " Overridden Methods"

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.OnFontChanged(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        MyBase.OnFontChanged(e)
        Dim hFont As IntPtr = Me.Font.ToHfont()
        SendMessage(Me.Handle, WM_SETFONT, hFont, New IntPtr(-1))
        SendMessage(Me.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero)
        Me.UpdateStyles()
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim HTI As New TCHITTESTINFO(e.X, e.Y)
        HotTabIndex = SendMessage(Me.Handle, TCM_HITTEST, IntPtr.Zero, HTI)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        HotTabIndex = -1
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(pevent)
        For id As Int32 = 0 To Me.TabCount - 1
            DrawTabBackground(pevent.Graphics, id)
        Next
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        For id As Int32 = 0 To Me.TabCount - 1
            DrawTabContent(e.Graphics, id)
        Next
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = TCM_SETPADDING Then
            m.LParam = MAKELPARAM(Me.Padding.X \ 2, Me.Padding.Y)
        End If
        If m.Msg = WM_MOUSEDOWN AndAlso Not Me.DesignMode Then
            Dim pt As Point = Me.PointToClient(Cursor.Position)
        End If
        MyBase.WndProc(m)
    End Sub

#End Region

#Region " Private Methods "

    Private Function MAKELPARAM(ByVal lo As Integer, ByVal hi As Integer) As IntPtr
        Return New IntPtr((hi << 16) Or (lo And &HFFFF))
    End Function

    Private Sub DrawTabBackground(ByVal graphics As Graphics, ByVal id As Integer)
        If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then

            If id = SelectedIndex Then
                Dim Brush As SolidBrush = New SolidBrush(_SelectedTabColor)
                Dim Pen As Pen = New Pen(_HotTrackTabColor)
                Dim rc As Rectangle = GetTabRect(id)
                graphics.FillRectangle(Brush, rc)
                graphics.DrawRectangle(Pen, rc)
            ElseIf id = HotTabIndex Then
                Dim rc As Rectangle = GetTabRect(id)
                Dim Brush As Brush = New SolidBrush(_HotTrackTabColor)
                Dim Pen As Pen = New Pen(Me.TabPages(id).BackColor)
                graphics.FillRectangle(Brush, rc)
                graphics.DrawRectangle(Pen, rc)
            Else
                Dim rc As Rectangle = GetTabRect(id)
                Dim Brush As Brush = New SolidBrush(_TabColor)
                Dim Pen As Pen = New Pen(Color.FromArgb(217, 217, 217))
                graphics.FillRectangle(Brush, rc)
                graphics.DrawRectangle(Pen, rc)
            End If

        End If

    End Sub

    Private Sub DrawTabContent(ByVal graphics As Graphics, ByVal id As Integer)
        Dim selectedOrHot As Boolean = id = Me.SelectedIndex OrElse id = Me.HotTabIndex
        Dim vertical As Boolean = Me.Alignment >= 2

        Dim tabRect As Rectangle = GetTabRect(id)
        Dim contentRect As Rectangle = New Rectangle(New Point(8, 0), tabRect.Size)
        Dim textrect As Rectangle = contentRect
        textrect.Width -= FontHeight

        Dim frColor As Color = If(id = SelectedIndex, Color.White, Me.ForeColor)
        Dim bkColor As Color = If(id = SelectedIndex, Me.TabPages(id).BackColor, Me.BackColor)
        Using bm As Bitmap = New Bitmap(contentRect.Width, contentRect.Height)
            Using bmGraphics As Graphics = Graphics.FromImage(bm)
                If selectedOrHot Then
                    If id = Me.SelectedIndex Then
                        TextRenderer.DrawText(bmGraphics, Me.TabPages(id).Text, Me.Font, textrect, frColor, _SelectedTabColor)
                    Else
                        TextRenderer.DrawText(bmGraphics, Me.TabPages(id).Text, Me.Font, textrect, frColor, _HotTrackTabColor)
                    End If
                Else
                    TextRenderer.DrawText(bmGraphics, Me.TabPages(id).Text, Me.Font, textrect, frColor, _TabColor)
                End If
            End Using
            If vertical Then
                If Me.Alignment = TabAlignment.Left Then
                    bm.RotateFlip(RotateFlipType.Rotate270FlipNone)
                Else
                    bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                End If
            End If
            graphics.DrawImage(bm, tabRect)
        End Using
    End Sub

#End Region

#Region " Interop "

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Int32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Int32, ByVal wParam As IntPtr, ByRef lParam As TCHITTESTINFO) As Int32
    End Function

    <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)>
    Private Structure TCHITTESTINFO
        Public pt As Point
        Public flags As TCHITTESTFLAGS
        Public Sub New(ByVal x As Int32, ByVal y As Int32)
            pt = New Point(x, y)
        End Sub
    End Structure

    <Flags()>
    Private Enum TCHITTESTFLAGS
        TCHT_NOWHERE = 1
        TCHT_ONITEMICON = 2
        TCHT_ONITEMLABEL = 4
        TCHT_ONITEM = TCHT_ONITEMICON Or TCHT_ONITEMLABEL
    End Enum

    Private Const WM_NULL As Int32 = &H0
    Private Const WM_SETFONT As Int32 = &H30
    Private Const WM_FONTCHANGE As Int32 = &H1D
    Private Const WM_MOUSEDOWN As Int32 = &H201

    Private Const TCM_FIRST As Int32 = &H1300
    Private Const TCM_HITTEST As Int32 = TCM_FIRST + 13
    Private Const TCM_SETPADDING As Int32 = TCM_FIRST ' + 43

#End Region

End Class