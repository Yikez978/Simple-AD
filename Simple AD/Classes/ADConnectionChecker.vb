Imports System.ComponentModel

Public Class ADConnectionChecker

    Private bw As BackgroundWorker = New BackgroundWorker

    Private ConnectionState As Integer

    Public Sub New()

    End Sub


    Public Sub Start()

        ConnectionState = 2

        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True

        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted

        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If

        If bw.WorkerSupportsCancellation = True Then
            bw.CancelAsync()
        End If

    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        If bw.CancellationPending = True Then
            e.Cancel = True
        Else
            Dim connectionStatus As Boolean = ValidateActiveDirectoryLogin(GetFQDN, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword, GlobalVariables.LoginUsernamePrefix)

            If connectionStatus Then
                bw.ReportProgress(1)
            Else
                bw.ReportProgress(0)
            End If

            System.Threading.Thread.Sleep(5000)
        End If
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

        If Not ConnectionState = e.ProgressPercentage Then

            If (e.ProgressPercentage = 1) Then
                FormMain.ConnectionToolStripStatusLabel.Image = New Bitmap(My.Resources.appbar_network_server_connecting, 26, 26)
                FormMain.ConnectionToolStripStatusLabel.Text = "Connected to " & CStr(GetLocalDomainName())
                FormMain.ConnectionToolStripStatusLabel.ToolTipText = "Domain: " & GetLocalDomainName() & Environment.NewLine & "FQDN: " & GetFQDN() & Environment.NewLine & "DC Net BIOS: " & GetSingleDomainController(GetLocalDomainName(), GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)
            Else
                FormMain.ConnectionToolStripStatusLabel.Image = New Bitmap(My.Resources.appbar_network_server_disconnect, 24, 24)
                FormMain.ConnectionToolStripStatusLabel.Text = "Unable to connect to any valid login server"
            End If
        End If

        ConnectionState = e.ProgressPercentage

    End Sub

    Public Sub StopChecker()
        If bw.WorkerSupportsCancellation Then
            bw.CancelAsync()
        End If
    End Sub


End Class
