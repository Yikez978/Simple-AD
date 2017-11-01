Imports SimpleLib
Imports System.ComponentModel

Public Class FormMain

    Public Sub New()
        InitializeComponent()

        TaskFlowHandle = TaskFlow

        For Each control As ToolStripMenuItem In MainMenuStrip.Items
            AddHandler control.DropDownOpening, AddressOf SubMenuClickHandler
        Next
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateRecentFileList()
        MainFormStart()

        GetTaskFlow.Width = MainSideBarSplitContainer.Panel2.Width

    End Sub

    Public Sub MainFormStart()

        UserToolStripMenuItem.Text = GetDisplayName()

        If My.Settings.CheckForUpdatesOnStart = True Then
            Dim RunUpdateCheck As New FormUpdate
        End If

        Dim ADC = New ADConnectionChecker
        ADC.Start()

        Dim NewReport As JobExplorer = New JobExplorer(ReportType.Explorer)
        GetContainerExplorer.DomainTreeView.SelectedNode = GetContainerExplorer.DomainTreeView.TopNode

    End Sub

#Region "Event Handlers"

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        FormOptions.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ImportCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportCSVToolStripMenuItem.Click
        UserImport()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Public Sub FileToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpening
        PopulateRecentFileList()
    End Sub

    Private Sub ToolStripMenuItemLogin_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLogin.Click
        Dim Login = New FormLogin
        Login.ShowDialog()
    End Sub

    Private Sub DomainPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomainPanelToolStripMenuItem.Click
        GetMainSplitContainer0.Panel1Collapsed = Not GetMainSplitContainer0.Panel1Collapsed
    End Sub

    Private Sub TaskPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskPanelToolStripMenuItem.Click
        MainSideBarSplitContainer.Panel2Collapsed = Not MainSideBarSplitContainer.Panel2Collapsed
    End Sub

    Private Sub BulkUserWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkUserWizardToolStripMenuItem.Click
        Dim BulkUser = New FormBulkUser()
        BulkUser.ShowDialog()
    End Sub

    Private Sub MainTabCtrl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MainTabCtrl.Click
        If e.Button = MouseButtons.Right Then
            For index As Integer = 0 To Me.MainTabCtrl.TabCount - 1 Step 1
                If Me.MainTabCtrl.GetTabRect(index).Contains(e.Location) Then
                    RightClickedTab = MainTabCtrl.TabPages(index)
                    Exit For
                End If
            Next index
        End If
    End Sub

    Private Sub OpenActiveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenActiveDirectoryToolStripMenuItem.Click
        Try
            Dim procInfo As New ProcessStartInfo() With {
            .UseShellExecute = True,
            .FileName = (Environment.SystemDirectory & "\dsa.msc"),
            .WorkingDirectory = "",
            .Verb = "runas"}

            Process.Start(procInfo)
        Catch ex As Exception
            Debug.WriteLine("[Error] " & ex.Message)
        End Try
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        FormUpdate.Show()
    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        FormConsole.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        GetMainListView().View = View.Details
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        GetMainListView().View = View.List
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeIconsToolStripMenuItem.Click
        GetMainListView().View = View.LargeIcon
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmallIconsToolStripMenuItem.Click
        GetMainListView().View = View.SmallIcon
    End Sub

    Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileToolStripMenuItem.Click
        GetMainListView().View = View.Tile
    End Sub

    Private Sub ShowGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowGroupsToolStripMenuItem.Click
        GetMainListView().ShowGroups = True
    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If GetMainListView() IsNot Nothing Then
            My.Settings.ExplorerListViewSettings = Encoding.Default.GetString(GetMainListView.SaveState)
            My.Settings.Save()
        End If
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.DropDownOpening
        VersionToolStripMenuItem.Text = "Version: " & Application.ProductVersion
    End Sub

    Private Sub SADMenuStrip_Paint(sender As Object, e As PaintEventArgs) Handles SADMenuStrip.Paint
        Dim s As MenuStrip = SADMenuStrip
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)
        End If
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If OngoingBulkJobs.Count > 0 Then

            Dim ClosePromptForm = New FormConfirmation("Are you sure you wish to close Simple AD? This will Cancel ongoing Jobs.", ConfirmationType.Close)
            ClosePromptForm.StartPosition = FormStartPosition.CenterScreen
            ClosePromptForm.ShowDialog()

            If ClosePromptForm.DialogResult = DialogResult.Yes Then

                For Each ImportJob As BulkADWorker In OngoingBulkJobs
                    ImportJob._JobClass.JobStatus = SimpleADJobStatus.Canceled
                Next

                OngoingBulkJobs.Clear()
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

End Class