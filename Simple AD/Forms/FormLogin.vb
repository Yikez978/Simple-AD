Imports System.Threading
Imports SimpleLib

Public Class FormLogin

    Private LoginThread As Thread
    Public Property SwitchUser As Boolean

    Private Class LoginCredentials
        Property Username As String
        Property Password As String
    End Class

    Public Sub New()
        InitializeComponent()

        UnTb.Select()
        OKBn.Enabled = False

        UnTb_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click

        Try
            If LoginThread.IsAlive Then
                LoginThread.Abort()

                Spinner.Visible = False
                Spinner.Spinning = False

                UnTb.Enabled = True
                PwdTb.Enabled = True

                OKBn.Enabled = True
                CancelBn.Enabled = False
            End If

        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub OKBn_Click(sender As Object, e As EventArgs) Handles OKBn.Click

        LoginThread = New Thread(AddressOf Login)

        With LoginThread
            .IsBackground = True
        End With

        Spinner.Visible = True
        Spinner.Spinning = True

        UnTb.Enabled = False
        PwdTb.Enabled = False

        OKBn.Enabled = False
        CancelBn.Enabled = True

        Dim creds As New LoginCredentials With {
            .Username = UnTb.Text,
            .Password = PwdTb.Text
        }

        LoginThread.Start(creds)
    End Sub

    Private Sub Login(ByVal CredentialsObject As Object)

        Dim Credentials As LoginCredentials = DirectCast(CredentialsObject, LoginCredentials)

        Dim TempUsername As String
        Dim TempPassword As String
        Dim TempLoginPrefix As String = ""

        If Not UnTb.Text.Contains("\") Then
            TempUsername = Credentials.Username
        Else
            Dim UsernameArray As String() = UnTb.Text.Split(New Char() {"\"c})
            TempLoginPrefix = UsernameArray(0)
            TempUsername = UsernameArray(1)
        End If

        TempPassword = Credentials.Password

        If ValidateActiveDirectoryLogin(TempUsername, TempPassword, TempLoginPrefix) Then

            LoginUsername = TempUsername
            LoginPassword = TempPassword

            If Not String.IsNullOrEmpty(TempLoginPrefix) Then
                LoginUsernamePrefix = TempLoginPrefix
            End If

            If RememberCheckBox.Checked Then
                If Not String.IsNullOrEmpty(TempLoginPrefix) Then
                    My.Settings.Username = DataProtection.Protect(TempLoginPrefix & "\" & TempUsername, "Letme1n$")
                Else
                    My.Settings.Username = DataProtection.Protect(TempUsername, "Letme1n$")
                End If
                My.Settings.Password = DataProtection.Protect(TempPassword, "Letme1n$")
            End If

            LoginSuccess()

        Else
            LoginFailed()
        End If

    End Sub

    Private Sub LoginSuccess()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf LoginSuccess))
        Else
            GetContainerExplorer.DomainTreeView.RefreshNodes()
            FormMain.MainFormStart()
            Me.Close()
        End If
    End Sub

    Private Sub LoginFailed()

        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf LoginFailed))
        Else

            Me.Show()

            Spinner.Visible = False
            Spinner.Spinning = False

            UnTb.Enabled = True
            PwdTb.Enabled = True

            OKBn.Enabled = True

            ErLb.Show()
            PwdTb.DisplayIcon = True
        End If
    End Sub

    Private Sub UnTb_TextChanged(sender As Object, e As EventArgs) Handles UnTb.TextChanged, PwdTb.TextChanged
        PwdTb.DisplayIcon = False
        ErLb.Hide()

        If (UnTb.Text IsNot Nothing) Then
            OKBn.Enabled = True
        Else
            OKBn.Enabled = False
        End If
    End Sub

End Class