Imports System.Threading

Public Class FormO365Login

    Private LoginThread As Thread

    Private Sub OKBn_Click(sender As Object, e As EventArgs) Handles OKBn.Click
        If Not String.IsNullOrEmpty(UnTb.Text) Then
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

            If Not LoginThread.IsAlive Then
                LoginThread.Start()
            End If
        End If
    End Sub

    Private Sub Login()

        If ValidateOffice365Login(UnTb.Text, PwdTb.Text) Then
            Office365Username = UnTb.Text
            Office365Password = PwdTb.Text
            LoginSuccess()
        Else
            LoginFailed()
        End If

    End Sub

    Private Sub LoginSuccess()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf LoginSuccess))
        Else
            Dim New365Job As JobOffice365 = New JobOffice365(Office365Username, Office365Password)
            Me.Dispose()
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

    Private Sub UnTb_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles UnTb.KeyUp

        If (UnTb.Text IsNot Nothing) Then
            If (PwdTb.Text IsNot Nothing) Then
                OKBn.Enabled = True
            End If
        Else
            OKBn.Enabled = False
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
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub PwdTb_TextChanged(sender As Object, e As EventArgs) Handles PwdTb.TextChanged
        PwdTb.DisplayIcon = False
        ErLb.Hide()
    End Sub

    Private Sub UnTb_TextChanged(sender As Object, e As EventArgs) Handles UnTb.TextChanged
        PwdTb.DisplayIcon = False
        ErLb.Hide()
    End Sub

    Private Sub O365Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OKBn.Enabled = False
        Me.CancelBn.Enabled = False
    End Sub
End Class