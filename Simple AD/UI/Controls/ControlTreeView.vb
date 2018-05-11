Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports SimpleLib

Public Class ControlTreeView
    Inherits TreeView

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        NativeMethods.SendMessage(Me.Handle, NativeMethods.TVM_SETEXTENDEDSTYLE, New IntPtr(NativeMethods.TVS_EX_DOUBLEBUFFER), New IntPtr(NativeMethods.TVS_EX_DOUBLEBUFFER))
    End Sub

    Public Sub New()
        MyBase.New

        Margin = New Padding(0, 0, 0, 0)
        DrawMode = TreeViewDrawMode.Normal
        HotTracking = True
        ShowLines = False
        ItemHeight = 22
        Dock = DockStyle.Fill
        FullRowSelect = True
        Font = SystemFonts.DefaultFont
        HideSelection = False
        Nodes.Clear()
        ShowLines = False

        NativeMethods.SetWindowTheme(Me.Handle, "explorer", Nothing)

    End Sub
End Class
