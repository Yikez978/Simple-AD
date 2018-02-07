Imports System.Drawing
Imports AutoUpdaterDotNET

Public Class FormUpdate

    Public Enum UpdateType
        Available
        UpdateError
        NoUpdates
    End Enum

    Public Sub New()

        InitializeComponent()
        AddHandler AutoUpdater.CheckForUpdateEvent, AddressOf AutoUpdaterOnCheckForUpdateEvent
        AutoUpdater.UseSystemProxy = My.Settings.UseProxy
        UpdateToggle.Checked = My.Settings.CheckForUpdatesOnStart
        CheckForUpdates()
    End Sub

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spinner.Visible = True
        Spinner.Spinning = True

        BodyLb.Text = "Checking for Updates..."
        OldVerLb.Text = My.Application.Info.Version.ToString
    End Sub

    Public Shared Sub CheckForUpdates()
        FormMain.UpdateToolStripStatusLabel.Text = " Checking for Updates...  "
        FormMain.UpdateToolStripStatusLabel.Image = New Icon(My.Resources.CheckUpdates, 16, 16).ToBitmap
        AutoUpdater.Start(UpdateURI)
    End Sub

    Private Sub AutoUpdaterOnCheckForUpdateEvent(args As UpdateInfoEventArgs)
        If args IsNot Nothing Then
            If args.IsUpdateAvailable Then
                If Not Me.IsDisposed Then
                    Me.Show()
                End If
                FormMain.UpdateToolStripStatusLabel.Text = ""
                Spinner.Visible = False
                BodyLb.Text = "New Version available. Click Update to upgrade"
                GetHeaderText(UpdateType.Available)

                NewVerLb.Text = args.CurrentVersion.ToString
                OldVerLb.Text = args.InstalledVersion.ToString

                UpdateBn.Enabled = True

            Else
                Spinner.Visible = False
                GetHeaderText(UpdateType.NoUpdates)
                BodyLb.Text = "There is no update available please try again later"
                FormMain.UpdateToolStripStatusLabel.Text = " Up To Date  "
                FormMain.UpdateToolStripStatusLabel.Image = New Icon(My.Resources.UpToDate, 16, 16).ToBitmap
                NewVerLb.Text = args.CurrentVersion.ToString
            End If
        Else
            Spinner.Visible = False
            GetHeaderText(UpdateType.UpdateError)
            BodyLb.Text = "Unable to reach update server"
            FormMain.UpdateToolStripStatusLabel.Text = " Unable to reach update server  "
        End If
        Me.Invalidate()
    End Sub

    Private Sub UpdateBn_Click(sender As Object, e As EventArgs) Handles UpdateBn.Click
        AutoUpdater.DownloadUpdate()
    End Sub

    Public Sub GetHeaderText(ByVal Type As UpdateType)
        Select Case Type
            Case UpdateType.Available
                Me.Text = "Update Availalbe"
            Case UpdateType.UpdateError
                Me.Text = "Unable to contact Update Server"
            Case UpdateType.NoUpdates
                Me.Text = "You're on the latest version"
        End Select
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub

    Private Sub UpdateToggle_CheckedChanged(sender As Object, e As EventArgs) Handles UpdateToggle.CheckedChanged
        My.Settings.CheckForUpdatesOnStart = UpdateToggle.Checked
    End Sub
End Class