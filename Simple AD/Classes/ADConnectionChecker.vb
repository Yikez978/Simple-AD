Public Class ADConnectionChecker

    Private ConnectionState As Boolean
    Private IsRunning As Boolean
    Private ErrorForm As FormAlert

    Public Sub InitiateTimer()

        Dim ConnectionTimmer As Windows.Forms.Timer = New Windows.Forms.Timer With {
            .Interval = 10000,
            .Enabled = True
        }

        AddHandler ConnectionTimmer.Tick, AddressOf ConnectionTimmerTick

        ConnectionTimmer.Start()
        ConnectionTimmerTick(Me, Nothing)

        Debug.WriteLine("[Debug] Network Check Thread Started")

    End Sub

    Private Sub ConnectionTimmerTick(sender As Object, e As EventArgs)

        Debug.WriteLine("[Debug] AD Connection Checker Tick")

        If Not IsRunning Then
            IsRunning = True
            UpdateUI(ValidateActiveDirectoryLogin(LoginUsername, LoginPassword, LoginUsernamePrefix))
        End If
    End Sub

    Private Sub UpdateUI(ByVal State As Boolean)

        Debug.WriteLine("[Debug] Network Connection state: " & State)

        If FormMain.StatusStrip.InvokeRequired Then
            FormMain.StatusStrip.Invoke(New Action(Of Boolean)(AddressOf UpdateUI), State)
        Else

            Debug.WriteLine("[Debug] Updating Connection state")

            If State Then

                Dim DomainName As String = GetLocalDomainName()

                FormMain.ConnectionToolStripStatusLabel.Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                FormMain.ConnectionToolStripStatusLabel.Text = "Connected to " & DomainName
                FormMain.ConnectionToolStripStatusLabel.ToolTipText = "Domain: " & DomainName & Environment.NewLine & "FQDN: " & GetFQDN() & Environment.NewLine & "DC Net BIOS: " & GetSingleDomainController()
            Else
                FormMain.ConnectionToolStripStatusLabel.Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                FormMain.ConnectionToolStripStatusLabel.Text = "Unable to connect to any valid logon server"

                If ErrorForm Is Nothing Then
                    ErrorForm = New FormAlert("Unable to connect to a domain controller!", AlertType.ErrorAlert)
                    ErrorForm.ShowDialog()
                End If
            End If
        End If

        IsRunning = False

    End Sub

End Class