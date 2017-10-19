Imports System.Runtime.InteropServices

Public Class ControlTreeView
    Inherits TreeView

#Region "Double Buffer"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        SendMessage(Me.Handle, TVM_SETEXTENDEDSTYLE, New IntPtr(TVS_EX_DOUBLEBUFFER), New IntPtr(TVS_EX_DOUBLEBUFFER))
        MyBase.OnHandleCreated(e)
    End Sub
    ' Pinvoke:
    Private Const TVM_SETEXTENDEDSTYLE As Integer = &H1100 + 44
    Private Const TVM_GETEXTENDEDSTYLE As Integer = &H1100 + 45
    Private Const TVS_EX_DOUBLEBUFFER As Integer = &H4
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
    End Function

#End Region

    Public Sub New()
        Me.Margin = New Padding(0, 0, 0, 0)
        Me.HotTracking = True
        Me.ShowLines = False
        Me.ItemHeight = 22
        Me.Dock = DockStyle.Fill
        Me.FullRowSelect = True
        Me.Font = SystemFonts.DefaultFont
        Me.HideSelection = False
        Me.Nodes.Clear()
        Me.ShowLines = False
        WindowsApi.SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub
End Class
