﻿Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class CustomTabControl
    Inherits TabControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                ControlStyles.DoubleBuffer Or
                ControlStyles.ResizeRedraw Or
                ControlStyles.UserPaint, True)

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region

#Region " InterOP "

    <StructLayout(LayoutKind.Sequential)>
    Private Structure NMHDR
        Public HWND As Int32
        Public idFrom As Int32
        Public code As Int32
        Public Overloads Function ToString() As String
            Return String.Format("Hwnd: {0}, ControlID: {1}, Code: {2}", HWND, idFrom, code)
        End Function
    End Structure

    Private Const TCN_FIRST As Int32 = &HFFFFFFFFFFFFFDDA&
    Private Const TCN_SELCHANGING As Int32 = (TCN_FIRST - 2)

    Private Const WM_USER As Int32 = &H400&
    Private Const WM_NOTIFY As Int32 = &H4E&
    Private Const WM_REFLECT As Int32 = WM_USER + &H1C00&

#End Region

#Region " BackColor Manipulation "

    'As well as exposing the property to the Designer we want it to behave just like any other 
    'controls BackColor property so we need some clever manipulation.
    Private m_Backcolor As Color = Color.Empty
    <Browsable(True),
    Description("The background color used to display text and graphics in a control.")>
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

    Public Overrides ReadOnly Property DisplayRectangle() As System.Drawing.Rectangle
        Get
            Dim tabStripHeight, itemHeight As Int32

            If Me.Alignment <= TabAlignment.Bottom Then
                itemHeight = Me.ItemSize.Height
            Else
                itemHeight = Me.ItemSize.Width
            End If

            If Me.Appearance = TabAppearance.Normal Then
                tabStripHeight = 5 + (itemHeight * Me.RowCount)
            Else
                tabStripHeight = (3 + itemHeight) * Me.RowCount
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

    Protected Overrides Sub OnParentBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnParentBackColorChanged(e)
        Invalidate()
    End Sub

    Private _InactiveTabBackColor

    Public Property InactiveTabBackColor As Color
        Set(value As Color)
            _InactiveTabBackColor = value
        End Set
        Get
            Return _InactiveTabBackColor
        End Get
    End Property

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As System.EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        If Not SelectedTab Is Nothing Then
            MyBase.OnPaint(e)
            e.Graphics.Clear(BackColor)
            Dim r As Rectangle = Me.ClientRectangle
            If TabCount <= 0 Then Return
            'Draw a custom background for Transparent TabPages
            r = SelectedTab.Bounds
            Dim sf As New StringFormat
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center
            Dim DrawFont As New Font(Font.FontFamily, 24, FontStyle.Regular, GraphicsUnit.Pixel)
            ControlPaint.DrawStringDisabled(e.Graphics, "Micks Ownerdraw TabControl", DrawFont, BackColor, RectangleF.op_Implicit(r), sf)
            DrawFont.Dispose()
            'Draw a border around TabPage
            r.Inflate(3, 3)
            Dim tp As TabPage = TabPages(SelectedIndex)
            Dim PaintBrush As New SolidBrush(tp.BackColor)
            e.Graphics.FillRectangle(PaintBrush, r)
            ControlPaint.DrawBorder(e.Graphics, r, PaintBrush.Color, ButtonBorderStyle.None)
            'Draw the Tabs
            For index As Integer = 0 To TabCount - 1
                tp = TabPages(index)
                r = GetTabRect(index)
                Dim bs As ButtonBorderStyle = ButtonBorderStyle.None
                If index = SelectedIndex Then bs = ButtonBorderStyle.None

                If index = SelectedIndex Then
                    PaintBrush.Color = tp.BackColor
                Else
                    PaintBrush.Color = SystemColors.Window
                End If

                e.Graphics.FillRectangle(PaintBrush, r)
                ControlPaint.DrawBorder(e.Graphics, r, PaintBrush.Color, bs)

                If index = SelectedIndex Then
                    PaintBrush.Color = SystemColors.Window
                Else
                    PaintBrush.Color = tp.ForeColor
                End If


                'Set up rotation for left and right aligned tabs
                If Alignment = TabAlignment.Left Or Alignment = TabAlignment.Right Then
                    Dim RotateAngle As Single = 90
                    If Alignment = TabAlignment.Left Then RotateAngle = 270
                    Dim cp As New PointF(r.Left + (r.Width \ 2), r.Top + (r.Height \ 2))
                    e.Graphics.TranslateTransform(cp.X, cp.Y)
                    e.Graphics.RotateTransform(RotateAngle)
                    r = New Rectangle(-(r.Height \ 2), -(r.Width \ 2), r.Height, r.Width)
                End If
                'Draw the Tab Text

                If tp.Enabled Then
                    If index = tp.TabIndex Then
                        e.Graphics.DrawString(tp.Text, Font, PaintBrush, RectangleF.op_Implicit(r), sf)
                    Else
                        e.Graphics.DrawString(tp.Text, Font, PaintBrush, RectangleF.op_Implicit(r), sf)
                    End If
                Else
                    ControlPaint.DrawStringDisabled(e.Graphics, tp.Text, Font, tp.BackColor, RectangleF.op_Implicit(r), sf)
                End If

                e.Graphics.ResetTransform()

            Next
            PaintBrush.Dispose()
        End If
    End Sub

    <Description("Occurs as a tab is being changed.")>
    Public Event SelectedIndexChanging As SelectedTabPageChangeEventHandler

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = (WM_REFLECT + WM_NOTIFY) Then
            Dim hdr As NMHDR = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(NMHDR)), NMHDR)
            If hdr.code = TCN_SELCHANGING Then
                Dim tp As TabPage = TestTab(Me.PointToClient(Cursor.Position))
                If Not tp Is Nothing Then
                    Dim e As New TabPageChangeEventArgs(Me.SelectedTab, tp)
                    RaiseEvent SelectedIndexChanging(Me, e)
                    If e.Cancel OrElse tp.Enabled = False Then
                        m.Result = New IntPtr(1)
                        Return
                    End If
                End If
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Function TestTab(ByVal pt As Point) As TabPage
        For index As Integer = 0 To TabCount - 1
            If GetTabRect(index).Contains(pt.X, pt.Y) Then
                Return TabPages(index)
            End If
        Next
        Return Nothing
    End Function

End Class

#Region " EventArgs Class's "

Public Class TabPageChangeEventArgs
    Inherits EventArgs

    Private _Selected As TabPage
    Private _PreSelected As TabPage
    Public Cancel As Boolean = False

    Public ReadOnly Property CurrentTab() As TabPage
        Get
            Return _Selected
        End Get
    End Property

    Public ReadOnly Property NextTab() As TabPage
        Get
            Return _PreSelected
        End Get
    End Property

    Public Sub New(ByVal CurrentTab As TabPage, ByVal NextTab As TabPage)
        _Selected = CurrentTab
        _PreSelected = NextTab
    End Sub

End Class

Public Delegate Sub SelectedTabPageChangeEventHandler(ByVal sender As Object, ByVal e As TabPageChangeEventArgs)

#End Region