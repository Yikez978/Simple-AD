Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            Threading.ThreadPool.SetMaxThreads(8, 8)

            If My.Settings.Username IsNot Nothing And My.Settings.Password IsNot Nothing Then
                If My.Settings.ManualLogin = True Then

                    Dim Username As String = Unprotect(My.Settings.Username, "Letme1n$")

                    If Username.Contains("\") Then
                        Dim UsernameArray As String() = Username.Split(New Char() {"\"c})
                        LoginUsernamePrefix = UsernameArray(0)
                        LoginUsername = UsernameArray(1)
                    Else
                        LoginUsernamePrefix = Nothing
                        LoginUsername = Username
                    End If

                    LoginPassword = Unprotect(My.Settings.Password, "Letme1n$")
                End If
            End If

            FormMain.WindowState = DirectCast(My.Settings.FormWindowState, FormWindowState)

            If Not FormMain.WindowState = FormWindowState.Maximized Then

                Dim FormLocation As Point = My.Settings.FormLocation

                If (FormLocation.X = -1) And (FormLocation.Y = -1) Then
                    Return
                End If

                Dim FormLocationVisible As Boolean = False
                For Each S As Screen In Screen.AllScreens
                    If S.Bounds.Contains(FormLocation) Then
                        FormLocationVisible = True
                        Exit For
                    End If
                Next

                If Not FormLocationVisible = True Then
                    Return
                End If

                FormMain.StartPosition = FormStartPosition.Manual
                FormMain.Location = FormLocation
                FormMain.Size = My.Settings.FormSize

            End If

        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            Settings.ExplorerListViewSettings = Encoding.Default.GetString(GetContainerExplorer.MainListView.SaveState())
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If e.ExitApplication Then
                Dim o As String = e.Exception.Message
                Dim s As String = e.Exception.StackTrace

                Debug.WriteLine("[Error] " & o)
                MessageBox.Show(o + vbNewLine + s, "Simple AD has encountered an unexpected Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) ' use EventLog instead
            End If
        End Sub
    End Class
End Namespace
