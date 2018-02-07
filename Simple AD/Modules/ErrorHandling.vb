Imports System.Windows.Forms

Public Module ErrorHandling

    Public Sub SafeInvoke(uiElement As Control, updater As Action, forceSynchronous As Boolean)
        If uiElement Is Nothing Then
            Throw New ArgumentNullException("uiElement")
        End If

        If uiElement.InvokeRequired Then
            If forceSynchronous Then
                uiElement.Invoke(DirectCast(Sub() SafeInvoke(uiElement, updater, forceSynchronous), Action))
            Else
                uiElement.BeginInvoke(DirectCast(Sub() SafeInvoke(uiElement, updater, forceSynchronous), Action))
            End If
        Else
            If uiElement.IsDisposed Then
                Throw New ObjectDisposedException("Control is already disposed.")
            End If

            updater()
        End If
    End Sub

End Module
