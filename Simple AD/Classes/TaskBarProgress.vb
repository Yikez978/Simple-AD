Imports System.Runtime.InteropServices

Public Module TaskBarProgress

    Public Enum TaskbarStates
        NoProgress = 0
        Indeterminate = 1
        Normal = 2
        [Error] = 4
        Paused = 8
    End Enum

    <ComImport()>
    <Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Private Interface ITaskbarList3

        <PreserveSig>
        Sub HrInit()

        <PreserveSig>
        Sub AddTab(ByVal hwnd As IntPtr)

        <PreserveSig>
        Sub DeleteTab(ByVal hwnd As IntPtr)

        <PreserveSig>
        Sub ActivateTab(ByVal hwnd As IntPtr)

        <PreserveSig>
        Sub SetActiveAlt(ByVal hwnd As IntPtr)

        <PreserveSig>
        Sub MarkFullscreenWindow(ByVal hwnd As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal fFullscreen As Boolean)

        <PreserveSig>
        Sub SetProgressValue(ByVal hwnd As IntPtr, ByVal ullCompleted As UInt64, ByVal ullTotal As UInt64)

        <PreserveSig>
        Sub SetProgressState(ByVal hwnd As IntPtr, ByVal state As TaskbarStates)

    End Interface

    <ComImport()>
    <Guid("56fdf344-fd6d-11d0-958a-006097c9a090")>
    <ClassInterface(ClassInterfaceType.None)>
    Private Class TaskbarInstanceObject
    End Class

    Private _TaskbarInstance As ITaskbarList3 = CType(New TaskbarInstanceObject(), ITaskbarList3)

    Private _TaskbarSupported As Boolean = Environment.OSVersion.Version >= New Version(6, 1)

    Sub SetState(ByVal WindowHandle As IntPtr, ByVal TaskbarState As TaskbarStates)
        If _TaskbarSupported Then
            Try
                _TaskbarInstance.SetProgressState(WindowHandle, TaskbarState)
            Catch
                Dim TaskBarAlert =
                    New FormAlert("SimpleAD detected that the current environment supports task bar progress indicators, 
                    but threw an exception when trying to invoke the system interface!",
                                  SimpleLib.Enums.AlertType.ErrorAlert)
                TaskBarAlert.ShowDialog()
            End Try
        End If
    End Sub

    Sub SetValue(ByVal WindowHandle As IntPtr, ByVal ProgressValue As Double, ByVal ProgressMax As Double)
        If _TaskbarSupported Then
            _TaskbarInstance.SetProgressValue(WindowHandle, CULng(ProgressValue), CULng(ProgressMax))
        End If
    End Sub
End Module

