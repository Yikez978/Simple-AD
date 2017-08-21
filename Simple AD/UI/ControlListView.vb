Imports System.Runtime.InteropServices

Public Class ControlListView
    Inherits ListView

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

        SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub

    Public Sub New()
        Me.Font = SystemFonts.DefaultFont
        Me.FullRowSelect = True
        Me.HotTracking = True
    End Sub

End Class
