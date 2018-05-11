Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports SimpleLib
Imports SimpleLib.SystemHelper
Imports WindowsFormsAero.TaskDialog

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            Logger.Init()

            If Settings.Username IsNot Nothing And Settings.Password IsNot Nothing Then
                If Settings.ManualLogin = True Then

                    Dim Username As String = DataProtection.Unprotect(Settings.Username, "Letme1n$")

                    If Username.Contains("\") Then
                        Dim UsernameArray As String() = Username.Split(New Char() {"\"c})
                        LoginUsernamePrefix = UsernameArray(0)
                        LoginUsername = UsernameArray(1)
                    Else
                        LoginUsernamePrefix = Nothing
                        LoginUsername = Username
                    End If

                    LoginPassword = DataProtection.Unprotect(Settings.Password, "Letme1n$")
                End If
            End If

            FormMain.WindowState = DirectCast(Settings.FormWindowState, FormWindowState)

            If Not FormMain.WindowState = FormWindowState.Maximized Then

                Dim FormLocation As Point = Settings.FormLocation

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
                FormMain.Size = Settings.FormSize

            End If

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If e.ExitApplication Then

                Dim o As String = e.Exception.Message
                Dim s As String = e.Exception.StackTrace

                Dim ErrorDialog As TaskDialog =
                    New TaskDialog("Something went wrong  :(",
                                   "Simple AD Panicked",
                                   "Simple AD has encountered an unexpected Error" &
                                   vbNewLine & vbNewLine & o,
                                   CommonButton.Cancel, CommonIcon.Stop)

                ErrorDialog.ExpandedInformation = s
                ErrorDialog.CollapsedControlText = "Show Debug Information"
                ErrorDialog.ExpandedControlText = "Hide Debug Information"
                ErrorDialog.IsExpanded = False
                ErrorDialog.ShowExpandedInfoInFooter = False

                ErrorDialog.CustomIcon = Resources.Bug

                ErrorDialog.CustomButtons = New CustomButton() {
                    New CustomButton(100, "Copy To Clipboard")
                }

                Dim Results As TaskDialogResult = ErrorDialog.Show(FormMain.Handle)

                If Results.ButtonID = 100 Then
                    Computer.Clipboard.SetText(o & vbNewLine & vbNewLine & s)
                End If

            End If

        End Sub
    End Class
End Namespace
