Public Module ControlUpdate

    ''' <summary>
    ''' An application sends the WM_SETREDRAW message to a window to allow changes in that 
    ''' window to be redrawn or to prevent changes in that window from being redrawn.
    ''' </summary>
    Private Const WM_SETREDRAW As Integer = 11

    ''' <summary>
    ''' Suspends painting for the target control. Do NOT forget to call EndControlUpdate!!!
    ''' </summary>
    ''' <param name="control">visual control</param>
    Public Sub BeginControlUpdate(control As Control)
        Dim msgSuspendUpdate As Message = Message.Create(control.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero)

        Dim window As NativeWindow = NativeWindow.FromHandle(control.Handle)
        window.DefWndProc(msgSuspendUpdate)
    End Sub

    ''' <summary>
    ''' Resumes painting for the target control. Intended to be called following a call to BeginControlUpdate()
    ''' </summary>
    ''' <param name="control">visual control</param>
    Public Sub EndControlUpdate(control As Control)
        ' Create a C "true" boolean as an IntPtr
        Dim wparam As New IntPtr(1)
        Dim msgResumeUpdate As Message = Message.Create(control.Handle, WM_SETREDRAW, wparam, IntPtr.Zero)

        Dim window As NativeWindow = NativeWindow.FromHandle(control.Handle)
        window.DefWndProc(msgResumeUpdate)
        control.Invalidate()
        control.Refresh()
    End Sub

End Module
