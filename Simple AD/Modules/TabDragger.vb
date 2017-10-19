Imports System.Runtime.InteropServices

Friend Class TabDragger

    Public Sub New(ByVal tabControl As TabControl)
        MyBase.New()
        Me.tabControl = tabControl
        AddHandler tabControl.MouseDown, AddressOf tabControl_MouseDown
        AddHandler tabControl.MouseMove, AddressOf tabControl_MouseMove
        AddHandler tabControl.DoubleClick, AddressOf tabControl_DoubleClick
    End Sub

    Public Sub New(ByVal tabControl As TabControl, ByVal behavior As TabDragBehavior)
        Me.New(tabControl)
        Me._dragBehavior = behavior
    End Sub

    Private tabControl As TabControl
    Private dragTab As TabPage = Nothing
    Private _dragBehavior As TabDragBehavior = TabDragBehavior.TabDragArrange

    Private ReadOnly Property DragBehavior() As TabDragBehavior
        Get
            If (Not tabControl.Multiline) Then
                Return _dragBehavior
            End If
            Return TabDragBehavior.None
        End Get
    End Property

    Private Sub tabControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        dragTab = TabUnderMouse()
    End Sub

    Private Sub tabControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

        If (_dragBehavior = TabDragBehavior.None) Then
            Return
        End If

        If (e.Button = MouseButtons.Left) Then
            If (dragTab IsNot Nothing) Then
                If (tabControl.TabPages.Contains(dragTab)) Then
                    If (PointInTabStrip(e.Location)) Then
                        Dim hotTab As TabPage = TabUnderMouse()
                        If (hotTab IsNot dragTab AndAlso hotTab IsNot Nothing) Then
                            Dim id1 As Int32 = tabControl.TabPages.IndexOf(dragTab)
                            Dim id2 As Int32 = tabControl.TabPages.IndexOf(hotTab)
                            If (id1 > id2) Then
                                For id As Int32 = id2 To id1
                                    SwapTabPages(id1, id)
                                Next
                            Else
                                For id As Int32 = id2 To id1 Step -1
                                    SwapTabPages(id1, id)
                                Next
                            End If
                            tabControl.SelectedTab = dragTab
                        End If
                    Else
                        If (Me._dragBehavior = TabDragBehavior.TabDragOut) Then
                            If (dragTab.Tag IsNot Nothing) Then

                                DirectCast(dragTab.Tag, TabForm).Dispose()
                                dragTab.Tag = Nothing
                            Else
                                Dim frm As New TabForm(dragTab)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub tabControl_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        If (Me._dragBehavior = TabDragBehavior.TabDragOut) Then
            Dim frm As New TabForm(dragTab)
        End If
    End Sub

#Region " Private Methods "

    Private Function TabUnderMouse() As TabPage
        Dim HTI As NativeMethods.TCHITTESTINFO = New NativeMethods.TCHITTESTINFO(tabControl.PointToClient(Cursor.Position))
        Dim tabID As Int32 = NativeMethods.SendMessage(tabControl.Handle, NativeMethods.TCM_HITTEST, IntPtr.Zero, HTI)
        Return If(tabID = -1, Nothing, tabControl.TabPages(tabID))
    End Function

    Private Function PointInTabStrip(ByVal point As Point) As Boolean
        Dim tabBounds As Rectangle = Rectangle.Empty
        Dim displayRC As Rectangle = tabControl.DisplayRectangle

        Select Case tabControl.Alignment
            Case TabAlignment.Bottom
                tabBounds.Location = New Point(0, displayRC.Bottom)
                tabBounds.Size = New Size(tabControl.Width, tabControl.Height - displayRC.Height)

            Case TabAlignment.Left
                tabBounds.Size = New Size(displayRC.Left, tabControl.Height)

            Case TabAlignment.Right
                tabBounds.Location = New Point(displayRC.Right, 0)
                tabBounds.Size = New Size(tabControl.Width - displayRC.Width, tabControl.Height)

            Case Else
                tabBounds.Size = New Size(tabControl.Width, displayRC.Top)
        End Select

        tabBounds.Inflate(-3, -3)

        Return tabBounds.Contains(point)

    End Function

    Private Sub SwapTabPages(ByVal index1 As Int32, ByVal index2 As Int32)
        If ((index1 Or index2) <> -1) Then
            Dim tab1 As TabPage = tabControl.TabPages(index1)
            Dim tab2 As TabPage = tabControl.TabPages(index2)
            tabControl.TabPages(index1) = tab2
            tabControl.TabPages(index2) = tab1
        End If
    End Sub

#End Region

End Class

Friend Class TabForm
    Inherits SimpleAD.FormSimpleAD

    Public Sub New(ByVal tabPage As TabPage)
        MyBase.New()
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.StartPosition = FormStartPosition.Manual
        Me.Padding = New Padding(1, 1, 1, 1)
        Me.Icon = My.Resources.SimpleADIcon
        Me.SizeGripStyle = SizeGripStyle.Show
        Me.MinimizeBox = True
        Me.MaximizeBox = True
        Me.BackColor = SystemColors.Window
        Me.tabPage = tabPage
        tabPage.Tag = Me
        Me.tabControl = DirectCast(tabPage.Parent, TabControl)
        Me.tabID = tabControl.TabPages.IndexOf(tabPage)
        Me.ClientSize = tabPage.Size
        Me.Location = tabControl.PointToScreen(New Point(tabPage.Left, tabControl.PointToClient(Cursor.Position).Y - SystemInformation.ToolWindowCaptionHeight \ 2))
        Me.Text = tabPage.Text
        UnDockFromTab()
        Me.dragOffset = tabControl.PointToScreen(Cursor.Position)
        Me.dragOffset.X -= Me.Location.X
        Me.dragOffset.Y -= Me.Location.Y
    End Sub

    Private tabPage As TabPage
    Private tabControl As TabControl
    Private tabID As Int32
    Private dragOffset As Point

    Protected Overrides Sub OnClosed(ByVal e As EventArgs)
        MyBase.OnClosed(e)
        DockToTab()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)

        If (m.Msg = NativeMethods.WM_MOVING) Then

            Dim rc As NativeMethods.RECT = DirectCast(m.GetLParam(GetType(NativeMethods.RECT)), NativeMethods.RECT)
            Dim pt As Point = tabControl.PointToClient(Cursor.Position)
            Dim pageRect As Rectangle = tabControl.DisplayRectangle
            Dim tabsRect As Rectangle = Rectangle.Empty

            Select Case tabControl.Alignment

                Case TabAlignment.Left
                    tabsRect.Size = New Size(pageRect.Left, tabControl.Height)

                Case TabAlignment.Bottom
                    tabsRect.Location = New Point(0, pageRect.Bottom)
                    tabsRect.Size = New Size(tabControl.Width, tabControl.Bottom - pageRect.Bottom)

                Case TabAlignment.Right
                    tabsRect.Location = New Point(pageRect.Right, 0)
                    tabsRect.Size = New Size(tabControl.Right - pageRect.Right, tabControl.Height)

                Case Else
                    tabsRect.Size = New Size(tabControl.Width, pageRect.Top)
            End Select

            If tabsRect.Contains(pt) Then
                DockToTab()
            Else
                UnDockFromTab()
            End If

        End If

        MyBase.WndProc(m)

        Select Case m.Msg
            Case NativeMethods.WM_NCLBUTTONDBLCLK
                Me.Close()

            Case NativeMethods.WM_EXITSIZEMOVE
                If (Not Me.Visible) Then
                    Me.Close()
                End If

            Case NativeMethods.WM_MOUSEMOVE
                If (m.WParam.ToInt32() = 1) Then

                    If (Not captured) Then
                        Dim pt As Point = tabControl.PointToScreen((Cursor.Position))
                        Dim newPosition As Point = New Point(pt.X - dragOffset.X, pt.Y - dragOffset.Y)
                        Me.Location = newPosition
                    End If
                    Dim rc As NativeMethods.RECT = New NativeMethods.RECT(Me.Bounds)
                    Dim lParam As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(rc))
                    Marshal.StructureToPtr(rc, lParam, True)
                    NativeMethods.SendMessage(Me.Handle, NativeMethods.WM_MOVING, IntPtr.Zero, lParam)
                    Marshal.FreeHGlobal(lParam)
                End If

            Case NativeMethods.WM_SETCURSOR
                captured = True

            Case Else

        End Select

    End Sub

    Private captured As Boolean

    Private Sub DockToTab()

        If (Not tabControl.TabPages.Contains(tabPage)) Then
            For id As Int32 = Me.Controls.Count - 1 To 0 Step -1

                tabPage.Controls.Add(Me.Controls(0))
            Next
            tabControl.TabPages.Insert(tabID, tabPage)
            tabControl.SelectedTab = tabPage

            tabControl.Capture = True
            Me.Close()
        End If
    End Sub

    Private Sub UnDockFromTab()

        If (Me.Visible OrElse Me.IsDisposed) Then
            Return
        End If

        For id As Int32 = tabPage.Controls.Count - 1 To 0 Step -1
            Me.Controls.Add(tabPage.Controls(0))
        Next

        tabControl.TabPages.Remove(tabPage)
        Me.Capture = True
        Me.Show()
    End Sub

End Class

Friend NotInheritable Class NativeMethods

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left, Top, Right, Bottom As Int32
        Public Sub New(ByVal bounds As Rectangle)
            Me.Left = bounds.Left
            Me.Top = bounds.Top
            Me.Right = bounds.Right
            Me.Bottom = bounds.Bottom
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0}, {1}, {2}, {3}", Left, Top, Right, Bottom)
        End Function
    End Structure

    Public Const WM_NCLBUTTONDBLCLK As Int32 = &HA3

    Public Const WM_SETCURSOR As Int32 = &H20

    Public Const WM_NCHITTEST As Int32 = &H84

    Public Const WM_MOUSEMOVE As Int32 = &H200
    Public Const WM_MOVING As Int32 = &H216
    Public Const WM_EXITSIZEMOVE As Int32 = &H232

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Int32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Int32
    End Function
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Int32, ByVal wParam As IntPtr, ByRef lParam As TCHITTESTINFO) As Int32
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure TCHITTESTINFO
        Public pt As Point
        Public flags As TCHITTESTFLAGS
        Public Sub New(ByVal point As Point)
            pt = point
            flags = TCHITTESTFLAGS.TCHT_ONITEM
        End Sub
    End Structure

    <Flags()>
    Public Enum TCHITTESTFLAGS
        TCHT_NOWHERE = 1
        TCHT_ONITEMICON = 2
        TCHT_ONITEMLABEL = 4
        TCHT_ONITEM = TCHT_ONITEMICON Or TCHT_ONITEMLABEL
    End Enum

    Public Const TCM_HITTEST As Int32 = &H130D

End Class

Public Enum TabDragBehavior
    None
    TabDragArrange
    TabDragOut
End Enum