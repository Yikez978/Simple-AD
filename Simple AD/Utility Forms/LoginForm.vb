﻿Imports System.Threading

Public Class LoginForm

    Private LoginThread As Thread

    Public Class LoginCredentials
        Property Username As String
        Property Password As String
    End Class

    Public Sub New()
        InitializeComponent()
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf UnhandledExceptionEventRaised
        GlobalVariables.Load()
    End Sub

    Sub UnhandledExceptionEventRaised(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        If e.IsTerminating Then
            Dim o As Object = e.ExceptionObject
            Debug.WriteLine(o.ToString)
            MessageBox.Show(o.ToString, "Simple AD has encountered an unexpected Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) ' use EventLog instead
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Application.OpenForms().OfType(Of MainApplicationForm).Any Then
            AutoLogin()
        End If

        UnTb.Select()
        OKBn.Enabled = False
    End Sub

    Private Sub AutoLogin()
        If Not String.IsNullOrEmpty(My.Settings.Username) Then
            Try
                UnTb.Text = DataProtection.Unprotect(My.Settings.Username)
                PwdTb.Text = DataProtection.Unprotect(My.Settings.Password)

                LoginThread = New Thread(AddressOf Login)

                With LoginThread
                    .IsBackground = True
                End With

                Dim creds As New LoginCredentials
                creds.Username = UnTb.Text
                creds.Password = PwdTb.Text

                If Not LoginThread.IsAlive Then
                    LoginThread.Start(creds)
                End If

            Catch Ex As Exception
                Debug.WriteLine(Ex.Message)
            End Try
        End If
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

        Dim creds As New LoginCredentials
        creds.Username = UnTb.Text
        creds.Password = PwdTb.Text

        If Not LoginThread.IsAlive Then
            LoginThread.Start(creds)
        End If
    End Sub

    Private Sub Login(ByVal Credentials As LoginCredentials)

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

        If ValidateActiveDirectoryLogin(GetFQDN, TempUsername, TempPassword, TempLoginPrefix) Then

            GlobalVariables.LoginUsername = TempUsername
            GlobalVariables.LoginPassword = TempPassword

            If Not String.IsNullOrEmpty(TempLoginPrefix) Then
                GlobalVariables.LoginUsernamePrefix = TempLoginPrefix
            End If

            If RememberCheckBox.Checked Then
                If Not String.IsNullOrEmpty(TempLoginPrefix) Then
                    My.Settings.Username = DataProtection.Protect(TempLoginPrefix & "\" & TempUsername)
                Else
                    My.Settings.Username = DataProtection.Protect(TempUsername)
                End If
                My.Settings.Password = DataProtection.Protect(TempPassword)
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
            MainApplicationForm.Show()

            Dim ADC = New ADConnectionChecker

            ADC.Start()
            Close()
        End If
    End Sub

    Private Sub LoginFailed()

        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf LoginFailed))
        Else
            Spinner.Visible = False
            Spinner.Spinning = False

            UnTb.Enabled = True
            PwdTb.Enabled = True

            OKBn.Enabled = True

            ErLb.Show()
            PwdTb.DisplayIcon = True
        End If
    End Sub

    Private Sub PwdTb_TextChanged(sender As Object, e As EventArgs) Handles PwdTb.TextChanged
        PwdTb.DisplayIcon = False
        ErLb.Hide()
    End Sub

    Private Sub UnTb_TextChanged(sender As Object, e As EventArgs) Handles UnTb.TextChanged
        PwdTb.DisplayIcon = False
        ErLb.Hide()

        If (UnTb.Text IsNot Nothing) Then
            OKBn.Enabled = True
        Else
            OKBn.Enabled = False
        End If
    End Sub
End Class