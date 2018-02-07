Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports SimpleLib

Public Class ControlTreeView
    Inherits TreeView

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        NativeWinAPI.SendMessage(Me.Handle, NativeWinAPI.TVM_SETEXTENDEDSTYLE, New IntPtr(NativeWinAPI.TVS_EX_DOUBLEBUFFER), New IntPtr(NativeWinAPI.TVS_EX_DOUBLEBUFFER))
    End Sub

    Public Sub New()
        MyBase.New


        Me.Margin = New Padding(0, 0, 0, 0)
        Me.DrawMode = TreeViewDrawMode.Normal
        Me.HotTracking = True
        Me.ShowLines = False
        Me.ItemHeight = 22
        Me.Dock = DockStyle.Fill
        Me.FullRowSelect = True
        Me.Font = SystemFonts.DefaultFont
        Me.HideSelection = False
        Me.Nodes.Clear()
        Me.ShowLines = False
        NativeWinAPI.SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub
End Class
