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
        UserToolStripMenuItem.Text = GetDisplayName()

        'Dim DragTabs As New TabDragger(MainTabCtrl, TabDragBehavior.TabDragOut)

        If My.Settings.CheckForUpdatesOnStart = True Then
            Dim RunUpdateCheck As New FormUpdate
        End If

        Dim ADC = New ADConnectionChecker
        ADC.Start()

        Dim NewReport As JobExplorer = New JobExplorer(ReportType.Explorer)
        GetContainerExplorer.DomainTreeView.SelectedNode = GetContainerExplorer.DomainTreeView.TopNode
    End Sub

    Private Sub ExportAsCSVToolStripMenuItem_Click(sender As Object, e As EventArgs)
        With ExportCSVDialog
            .Title = "Export CSV File"
            .Filter = "Comma Dellimited|*.csv"
            .FileName = "SimpleAD_Export"
        End With

        ExportCSVDialog.ShowDialog()
    End Sub

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

    Private Sub MainApplicationForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub ViewSideBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GetMainSplitContainer1.Panel2Collapsed = Not GetMainSplitContainer1.Panel2Collapsed
    End Sub

    Public Sub FileToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpening
        PopulateRecentFileList()
    End Sub

    Private Sub ToolStripMenuItemLogin_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLogin.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub DomainPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomainPanelToolStripMenuItem.Click
        GetMainSplitContainer0.Panel1Collapsed = Not GetMainSplitContainer0.Panel1Collapsed
    End Sub

    Private Sub BulkUserWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkUserWizardToolStripMenuItem.Click
        Dim BulkUser = New FormBulkUser()
        BulkUser.ShowDialog()
    End Sub

    Public Sub CloseTab(TabPage As TabPage)
        GetMainTabCtrl.TabPages.Remove(TabPage)
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

    Private Sub DisabledUsersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim NewReport As JobExplorer = New JobExplorer(ReportType.DisabledUsers)
    End Sub

    Private Sub CustomQueryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormLDAPQuery.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CloseTab(RightClickedTab)
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

    Private Sub MainTabCtrl_Selected(sender As Object, e As TabControlEventArgs)
        If Not e.TabPage Is Nothing Then
            If e.TabPage.Tag = "365" Then
                Me.Refresh()
            ElseIf e.TabPage.Tag = "Report" Then

                Me.Refresh()
            Else
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        FormUpdate.Show()
    End Sub

    Private Sub EntireDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim NewReport As JobExplorer = New JobExplorer(ReportType.AllObjects)
    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        FormConsole.Show()
    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        Dim NewReport As JobExplorer = New JobExplorer(ReportType.Explorer)
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
            ClosePromptForm.ShowDialog()

            If ClosePromptForm.DialogResult = DialogResult.Yes Then
                OngoingBulkJobs.Clear()
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SideBarToggle_Click(sender As Object, e As EventArgs) Handles SideBarToggle.Click
        MainSideBarSplitContainer.Panel2Collapsed = Not SideBarToggle.Checked
    End Sub
End Class