Imports System.Runtime.InteropServices

Public Class ControlDataGridView
    Inherits DataGridView

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

        SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub
End Class
