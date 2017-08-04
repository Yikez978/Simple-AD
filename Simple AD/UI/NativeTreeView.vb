Public Class NativeTreeView : Inherits TreeView

    Private Declare Unicode Function SetWindowTheme Lib "uxtheme.dll" (hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        SetWindowTheme(Me.Handle, "Explorer", Nothing)
    End Sub

End Class
