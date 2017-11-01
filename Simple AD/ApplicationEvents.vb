Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Diagnostics

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Public DebugStreamHandler As ConsoleHandler

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            DebugStreamHandler = New ConsoleHandler()
            Threading.ThreadPool.SetMaxThreads(8, 8)
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            My.Settings.ImportListViewSettings = Encoding.Default.GetString(GetContainerImport.MainListView.SaveState())
            My.Settings.ExplorerListViewSettings = Encoding.Default.GetString(GetContainerExplorer.MainListView.SaveState())
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If e.ExitApplication Then
                Dim o As Object = e.Exception.Message
                Debug.WriteLine("[Error] " & o.ToString)
                MessageBox.Show(o.ToString, "Simple AD has encountered an unexpected Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) ' use EventLog instead
            End If
        End Sub
    End Class
End Namespace
