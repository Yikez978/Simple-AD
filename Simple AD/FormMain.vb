Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports SimpleLib
Imports SimpleAD.LocalData

Imports System

Public Class FormMain

    Public Sub New()
        InitializeComponent()

        For Each control As ToolStripMenuItem In MainMenuStrip.Items
            AddHandler control.DropDownOpening, AddressOf SubMenuClickHandler
        Next
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        MainFormStart()
        BuildUIHandlers()

    End Sub

    Public Sub MainFormStart()

        RecentFiles.PopulateRecentFileList()

        If My.Settings.CheckForUpdatesOnStart = True Then
            Dim RunUpdateCheck As New FormUpdate
        End If

        If ValidateActiveDirectoryLogin(LoginUsername, LoginPassword, LoginUsernamePrefix) Then

            ContainerExplorer.DomainTreeView.RefreshNodes()

            Dim NewReport As TaskExplorer = New TaskExplorer(SimpleADReportType.Explorer)
            UserToolStripMenuItem.Text = GetDisplayName(True)

            ReportAttributeStore.RegisterReportAttributes()

            UpdateConnectionStatus()
        Else

            ConnectionToolStripStatusLabel.Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
            ConnectionToolStripStatusLabel.Text = "Unable to connect to any valid logon server"

            Dim ErrorForm As FormAlert = New FormAlert("Unable to connect to a domain controller!", AlertType.ErrorAlert)
            ErrorForm.ShowDialog()
        End If

    End Sub

    Private Sub UpdateConnectionStatus()

        Dim State As Boolean = ValidateActiveDirectoryLogin(LoginUsername, LoginPassword, LoginUsernamePrefix)

        If StatusStrip.InvokeRequired Then
            StatusStrip.Invoke(New Action(AddressOf UpdateConnectionStatus))
        Else

            If State Then

                Dim DomainName As String = GetLocalDomainName()

                With ConnectionToolStripStatusLabel
                    .Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                    .Text = "Connected to " & GetSingleDomainController()
                    .ToolTipText = "Domain: " &
                        DomainName & Environment.NewLine &
                        "FQDN: " & GetFQDN() & Environment.NewLine &
                        "DC Net BIOS: " & GetSingleDomainController()
                End With

            Else
                With ConnectionToolStripStatusLabel
                    .Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                    .Text = "Unable to connect to any valid logon server"
                End With

                Dim ErrorForm = New FormAlert("Unable to connect to a domain controller!", AlertType.ErrorAlert)
                ErrorForm.ShowDialog()

            End If
        End If
    End Sub

    Private Sub BuildUIHandlers()

        Dim _ToolStripHandler As UIHandler = New UIHandler(ContainerExplorer.MainListView, ContainerExplorer)

        AddHandler ImportCSVToolStripMenuItem.Click, AddressOf _ToolStripHandler.ImportCSV_Click
        AddHandler TemplateManagerToolStripMenuItem.Click, AddressOf _ToolStripHandler.TemplateManager_Click
        AddHandler OpenActiveDirectoryToolStripMenuItem.Click, AddressOf _ToolStripHandler.OpenActiveDirectory_Click

        ControlToolStrip.LoadToolStrip(_ToolStripHandler)

    End Sub



#Region "Event Handlers"

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click

        Dim OptionsForm = New FormOptions
        OptionsForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Public Sub FileToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpening
        RecentFiles.PopulateRecentFileList()
    End Sub

    Private Sub ToolStripMenuItemLogin_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLogin.Click
        Dim Login As FormLogin = New FormLogin
        Login.ShowDialog()
    End Sub

    Private Sub DomainPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomainPanelToolStripMenuItem.Click
        ContainerExplorer.MainSplitContainer.Panel1Collapsed = Not ContainerExplorer.MainSplitContainer.Panel1Collapsed
    End Sub

    Private Sub BulkUserWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkUserWizardToolStripMenuItem.Click
        Dim BulkUser As FormBulkUser = New FormBulkUser()
        BulkUser.ShowDialog()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        FormUpdate.Show()
    End Sub

    Private Sub ShowGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowGroupsToolStripMenuItem.Click
        ContainerExplorer.MainListView.ShowGroups = ShowGroupsToolStripMenuItem.Checked
    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ContainerExplorer.MainListView IsNot Nothing Then

            My.Settings.FormWindowState = WindowState
            If Not WindowState = FormWindowState.Maximized Then
                My.Settings.FormSize = Me.Size
                My.Settings.FormLocation = Me.Location
            End If

            My.Settings.Save()
        End If
    End Sub

    Private Sub SADMenuStrip_Paint(sender As Object, e As PaintEventArgs) Handles SADMenuStrip.Paint
        Dim s As MenuStrip = SADMenuStrip

        If ControlToolStrip IsNot Nothing Then
            If ControlToolStrip.Visible Then
                If Not s Is Nothing Then
                    Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
                    e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)
                End If
            End If
        End If

    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TaskHandler.BatchTasks.Count > 0 Then

            Dim ClosePromptForm As FormConfirmation = New FormConfirmation("Are you sure you wish to close Simple AD? This will Cancel ongoing Jobs.", ConfirmationType.Close) With {
                .StartPosition = FormStartPosition.CenterScreen
            }
            ClosePromptForm.ShowDialog()

            If ClosePromptForm.DialogResult = DialogResult.Yes Then

                For Each Task As TaskBase In BatchTasks
                    Task.TaskStatus = ActiveTaskStatus.Canceled
                Next

                TaskHandler.BatchTasks.Clear()
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            ContainerExplorer.DomainTreeView.SelectedNode = ContainerExplorer.DomainTreeView.RootNode
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub ContainerExplorer_Paint(sender As Object, e As PaintEventArgs) Handles ContainerExplorer.Paint
        Dim s As ContainerExplorer = ContainerExplorer
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)
        End If
    End Sub

    Private Sub RibbonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RibbonToolStripMenuItem.Click
        ControlToolStrip.Visible = Not ControlToolStrip.Visible
        SADMenuStrip.Invalidate()
    End Sub

#End Region

End Class