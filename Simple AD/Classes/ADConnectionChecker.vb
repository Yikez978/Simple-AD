Imports System.ComponentModel

Public Class ADConnectionChecker

    Private BackgroundWorker As BackgroundWorker = New BackgroundWorker

    Private ConnectionState As Integer

    Public Sub Start()

        ConnectionState = 2

        BackgroundWorker.WorkerReportsProgress = True
        BackgroundWorker.WorkerSupportsCancellation = True

        AddHandler BackgroundWorker.DoWork, AddressOf BackgroundWorker_DoWork
        AddHandler BackgroundWorker.ProgressChanged, AddressOf BackgroundWorker_ProgressChanged
        AddHandler BackgroundWorker.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted

        If Not BackgroundWorker.IsBusy = True Then
            BackgroundWorker.RunWorkerAsync()
        End If

        If BackgroundWorker.WorkerSupportsCancellation = True Then
            BackgroundWorker.CancelAsync()
        End If

    End Sub

    Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        If BackgroundWorker.CancellationPending = True Then
            e.Cancel = True
        Else
            Dim connectionStatus As Boolean = ValidateActiveDirectoryLogin(GetFQDN, LoginUsername, LoginPassword, LoginUsernamePrefix)

            If connectionStatus Then
                BackgroundWorker.ReportProgress(1)
            Else
                BackgroundWorker.ReportProgress(0)
            End If

            System.Threading.Thread.Sleep(5000)
        End If
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        If Not BackgroundWorker.IsBusy = True Then
            BackgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

        If Not ConnectionState = e.ProgressPercentage Then

            If (e.ProgressPercentage = 1) Then
                FormMain.ConnectionToolStripStatusLabel.Image = New Bitmap(My.Resources.Connection, 26, 26)
                FormMain.ConnectionToolStripStatusLabel.Text = "Connected to " & CStr(GetLocalDomainName())
                FormMain.ConnectionToolStripStatusLabel.ToolTipText = "Domain: " & GetLocalDomainName() & Environment.NewLine & "FQDN: " & GetFQDN() & Environment.NewLine & "DC Net BIOS: " & GetSingleDomainController()
            Else
                FormMain.ConnectionToolStripStatusLabel.Image = New Bitmap(My.Resources.Connection, 24, 24)
                FormMain.ConnectionToolStripStatusLabel.Text = "Unable to connect to any valid login server"
            End If
        End If

        ConnectionState = e.ProgressPercentage

    End Sub

    Public Sub StopChecker()
        If BackgroundWorker.WorkerSupportsCancellation Then
            BackgroundWorker.CancelAsync()
        End If
    End Sub


End Class
