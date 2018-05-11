Imports System
Imports System.Windows.Forms
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2

    '
    'Handling the window messages
    '
    Protected Overrides Sub WndProc(ByRef message As Message)

        MyBase.WndProc(message)

        If message.Msg = WM_NCHITTEST AndAlso CInt(message.Result) = HTCLIENT Then
            message.Result = New IntPtr(HTCAPTION)
        End If
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.SADMenuStrip = New SimpleAD.ControlMenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulkUserWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThowExxceptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenActiveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomainPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RibbonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NodeContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportCSVDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ConnectionStatusToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.StatusStrip = New SimpleAD.ControlStatusStrip()
        Me.ToolStripStatusLabelContext = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContainerToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Filler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.QueryToolStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.ContainerExplorer = New SimpleAD.ContainerExplorer()
        Me.ControlToolStrip = New SimpleAD.ControlToolStrip()
        Me.RowObjectContextMenu = New System.Windows.Forms.ContextMenu()
        Me.CopyToClipBoardToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyDNToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopySamToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.RenameMenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.BulkModifyToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DisableBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenu()
        Me.RefreshMenuItem = New System.Windows.Forms.MenuItem()
        Me.SADMenuStrip.SuspendLayout()
        Me.NodeContextMenu.SuspendLayout()
        Me.ContextMenuStripTrayIcon.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SADMenuStrip
        '
        Me.SADMenuStrip.BackColor = System.Drawing.SystemColors.Window
        Me.SADMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.SADMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PreferencesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.UserToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.SADMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SADMenuStrip.Name = "SADMenuStrip"
        Me.SADMenuStrip.Size = New System.Drawing.Size(831, 24)
        Me.SADMenuStrip.TabIndex = 14
        Me.SADMenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportCSVToolStripMenuItem, Me.TemplateManagerToolStripMenuItem, Me.BulkUserWizardToolStripMenuItem, Me.RecentFilesToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator1, Me.ThowExxceptionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportCSVToolStripMenuItem
        '
        Me.ImportCSVToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportCSVToolStripMenuItem.Name = "ImportCSVToolStripMenuItem"
        Me.ImportCSVToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ImportCSVToolStripMenuItem.Text = "&Import..."
        '
        'TemplateManagerToolStripMenuItem
        '
        Me.TemplateManagerToolStripMenuItem.Enabled = False
        Me.TemplateManagerToolStripMenuItem.Name = "TemplateManagerToolStripMenuItem"
        Me.TemplateManagerToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.TemplateManagerToolStripMenuItem.Text = "[WIP] Template Manager"
        '
        'BulkUserWizardToolStripMenuItem
        '
        Me.BulkUserWizardToolStripMenuItem.Enabled = False
        Me.BulkUserWizardToolStripMenuItem.Name = "BulkUserWizardToolStripMenuItem"
        Me.BulkUserWizardToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BulkUserWizardToolStripMenuItem.Text = "[WIP] &Bulk User Wizard..."
        '
        'RecentFilesToolStripMenuItem
        '
        Me.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem"
        Me.RecentFilesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RecentFilesToolStripMenuItem.Text = "Recent Files"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for Updates..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'ThowExxceptionToolStripMenuItem
        '
        Me.ThowExxceptionToolStripMenuItem.Name = "ThowExxceptionToolStripMenuItem"
        Me.ThowExxceptionToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ThowExxceptionToolStripMenuItem.Text = "Thow Exception"
        Me.ThowExxceptionToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferencesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.PreferencesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreferencesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenActiveDirectoryToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ToolsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OpenActiveDirectoryToolStripMenuItem
        '
        Me.OpenActiveDirectoryToolStripMenuItem.Name = "OpenActiveDirectoryToolStripMenuItem"
        Me.OpenActiveDirectoryToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OpenActiveDirectoryToolStripMenuItem.Text = "Open Active Directory..."
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemLogin})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.UserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ToolStripMenuItemLogin
        '
        Me.ToolStripMenuItemLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItemLogin.Name = "ToolStripMenuItemLogin"
        Me.ToolStripMenuItemLogin.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripMenuItemLogin.Text = "Switch User..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DomainPanelToolStripMenuItem, Me.RibbonToolStripMenuItem, Me.ToolStripSeparator2, Me.ShowGroupsToolStripMenuItem, Me.ToolStripSeparator3})
        Me.ViewToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ViewToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'DomainPanelToolStripMenuItem
        '
        Me.DomainPanelToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DomainPanelToolStripMenuItem.Checked = True
        Me.DomainPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DomainPanelToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DomainPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DomainPanelToolStripMenuItem.Name = "DomainPanelToolStripMenuItem"
        Me.DomainPanelToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DomainPanelToolStripMenuItem.Text = "Show Domain Panel"
        '
        'RibbonToolStripMenuItem
        '
        Me.RibbonToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RibbonToolStripMenuItem.Checked = True
        Me.RibbonToolStripMenuItem.CheckOnClick = True
        Me.RibbonToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RibbonToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RibbonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RibbonToolStripMenuItem.Name = "RibbonToolStripMenuItem"
        Me.RibbonToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RibbonToolStripMenuItem.Text = "Show Tool Ribbon"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'ShowGroupsToolStripMenuItem
        '
        Me.ShowGroupsToolStripMenuItem.Checked = True
        Me.ShowGroupsToolStripMenuItem.CheckOnClick = True
        Me.ShowGroupsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowGroupsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowGroupsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShowGroupsToolStripMenuItem.Name = "ShowGroupsToolStripMenuItem"
        Me.ShowGroupsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ShowGroupsToolStripMenuItem.Text = "Show Groups"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(175, 6)
        '
        'NodeContextMenu
        '
        Me.NodeContextMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.NodeContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.NodeContextMenu.Name = "NodeContextMenu"
        Me.NodeContextMenu.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ContextMenuStripTrayIcon
        '
        Me.ContextMenuStripTrayIcon.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStripTrayIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemExit})
        Me.ContextMenuStripTrayIcon.Name = "ContextMenuStripTrayIcon"
        Me.ContextMenuStripTrayIcon.Size = New System.Drawing.Size(157, 26)
        '
        'ToolStripMenuItemExit
        '
        Me.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit"
        Me.ToolStripMenuItemExit.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItemExit.Text = "Exit Application"
        Me.ToolStripMenuItemExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 151)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(1299, 24)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(1299, 25)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightToolStripPanel.Location = New System.Drawing.Point(1299, 25)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 126)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 25)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 126)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(1299, 126)
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelContext, Me.ToolStripStatusLabelStatus, Me.ContainerToolStripStatusLabel, Me.Filler, Me.QueryToolStripLabel, Me.UpdateToolStripStatusLabel, Me.ConnectionToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.ShowItemToolTips = True
        Me.StatusStrip.Size = New System.Drawing.Size(831, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 18
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabelContext
        '
        Me.ToolStripStatusLabelContext.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabelContext.Name = "ToolStripStatusLabelContext"
        Me.ToolStripStatusLabelContext.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabelContext.Text = "Context Label"
        '
        'ToolStripStatusLabelStatus
        '
        Me.ToolStripStatusLabelStatus.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabelStatus.Name = "ToolStripStatusLabelStatus"
        Me.ToolStripStatusLabelStatus.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabelStatus.Text = "Status Label"
        '
        'ContainerToolStripStatusLabel
        '
        Me.ContainerToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.ContainerToolStripStatusLabel.Name = "ContainerToolStripStatusLabel"
        Me.ContainerToolStripStatusLabel.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.ContainerToolStripStatusLabel.Size = New System.Drawing.Size(91, 17)
        Me.ContainerToolStripStatusLabel.Text = "StatusLabel"
        '
        'Filler
        '
        Me.Filler.Enabled = False
        Me.Filler.ForeColor = System.Drawing.SystemColors.Window
        Me.Filler.Name = "Filler"
        Me.Filler.Size = New System.Drawing.Size(269, 17)
        Me.Filler.Spring = True
        '
        'QueryToolStripLabel
        '
        Me.QueryToolStripLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.QueryToolStripLabel.Name = "QueryToolStripLabel"
        Me.QueryToolStripLabel.Size = New System.Drawing.Size(100, 17)
        Me.QueryToolStripLabel.Text = "Query Time Label"
        '
        'UpdateToolStripStatusLabel
        '
        Me.UpdateToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.UpdateToolStripStatusLabel.Name = "UpdateToolStripStatusLabel"
        Me.UpdateToolStripStatusLabel.Size = New System.Drawing.Size(76, 17)
        Me.UpdateToolStripStatusLabel.Text = "Update Label"
        '
        'ConnectionToolStripStatusLabel
        '
        Me.ConnectionToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.ConnectionToolStripStatusLabel.Name = "ConnectionToolStripStatusLabel"
        Me.ConnectionToolStripStatusLabel.Size = New System.Drawing.Size(100, 17)
        Me.ConnectionToolStripStatusLabel.Text = "Connection Label"
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundPanel.Controls.Add(Me.ContainerExplorer)
        Me.BackgroundPanel.Controls.Add(Me.ControlToolStrip)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 24)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(831, 396)
        Me.BackgroundPanel.TabIndex = 20
        '
        'ContainerExplorer
        '
        Me.ContainerExplorer.BackColor = System.Drawing.SystemColors.Window
        Me.ContainerExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerExplorer.Job = Nothing
        Me.ContainerExplorer.Location = New System.Drawing.Point(0, 100)
        Me.ContainerExplorer.Name = "ContainerExplorer"
        Me.ContainerExplorer.Path = Nothing
        Me.ContainerExplorer.Size = New System.Drawing.Size(831, 296)
        Me.ContainerExplorer.TabIndex = 21
        '
        'ControlToolStrip
        '
        Me.ControlToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ControlToolStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ControlToolStrip.Name = "ControlToolStrip"
        Me.ControlToolStrip.Size = New System.Drawing.Size(831, 100)
        Me.ControlToolStrip.TabIndex = 20
        '
        'RowObjectContextMenu
        '
        Me.RowObjectContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyToClipBoardToolStripMenuItem, Me.RenameMenuItem, Me.ResetSingleToolStripMenuItem, Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem, Me.MoveSingleToolStripMenuItem, Me.DeleteSingleToolStripMenuItem, Me.BulkModifyToolStripMenuItem, Me.ResetBulkToolStripMenuItem, Me.EnableBulkToolStripMenuItem, Me.DisableBulkToolStripMenuItem, Me.MoveBulkToolStripMenuItem, Me.DeleteBulkToolStripMenuItem, Me.PropertiesToolStripMenuItem})
        '
        'CopyToClipBoardToolStripMenuItem
        '
        Me.CopyToClipBoardToolStripMenuItem.Index = 0
        Me.CopyToClipBoardToolStripMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyNameToolStripMenuItem, Me.CopyDNToolStripMenuItem, Me.CopySamToolStripMenuItem})
        Me.CopyToClipBoardToolStripMenuItem.Tag = "CopyToClipBoardToolStripMenuItem"
        Me.CopyToClipBoardToolStripMenuItem.Text = "Copy To Clipboard..."
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Index = 0
        Me.CopyNameToolStripMenuItem.Text = "Name"
        '
        'CopyDNToolStripMenuItem
        '
        Me.CopyDNToolStripMenuItem.Index = 1
        Me.CopyDNToolStripMenuItem.Text = "Distinguished Name"
        '
        'CopySamToolStripMenuItem
        '
        Me.CopySamToolStripMenuItem.Index = 2
        Me.CopySamToolStripMenuItem.Text = "sAMAccountName"
        '
        'RenameMenuItem
        '
        Me.RenameMenuItem.Index = 1
        Me.RenameMenuItem.Tag = "RenameMenuItem"
        Me.RenameMenuItem.Text = "Rename"
        '
        'ResetSingleToolStripMenuItem
        '
        Me.ResetSingleToolStripMenuItem.Index = 2
        Me.ResetSingleToolStripMenuItem.Tag = "ResetSingleToolStripMenuItem"
        Me.ResetSingleToolStripMenuItem.Text = "Reset Password"
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Index = 3
        Me.EnableToolStripMenuItem.Tag = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Index = 4
        Me.DisableToolStripMenuItem.Tag = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'MoveSingleToolStripMenuItem
        '
        Me.MoveSingleToolStripMenuItem.Index = 5
        Me.MoveSingleToolStripMenuItem.Tag = "MoveSingleToolStripMenuItem"
        Me.MoveSingleToolStripMenuItem.Text = "Move..."
        '
        'DeleteSingleToolStripMenuItem
        '
        Me.DeleteSingleToolStripMenuItem.Index = 6
        Me.DeleteSingleToolStripMenuItem.Tag = "DeleteSingleToolStripMenuItem"
        Me.DeleteSingleToolStripMenuItem.Text = "Delete"
        '
        'BulkModifyToolStripMenuItem
        '
        Me.BulkModifyToolStripMenuItem.Index = 7
        Me.BulkModifyToolStripMenuItem.Tag = "BulkModifyToolStripMenuItem"
        Me.BulkModifyToolStripMenuItem.Text = "Bulk Modify..."
        '
        'ResetBulkToolStripMenuItem
        '
        Me.ResetBulkToolStripMenuItem.Index = 8
        Me.ResetBulkToolStripMenuItem.Tag = "ResetBulkToolStripMenuItem"
        Me.ResetBulkToolStripMenuItem.Text = "Reset Passwords In bulk"
        '
        'EnableBulkToolStripMenuItem
        '
        Me.EnableBulkToolStripMenuItem.Index = 9
        Me.EnableBulkToolStripMenuItem.Tag = "EnableBulkToolStripMenuItem"
        Me.EnableBulkToolStripMenuItem.Text = "Enable Selected"
        '
        'DisableBulkToolStripMenuItem
        '
        Me.DisableBulkToolStripMenuItem.Index = 10
        Me.DisableBulkToolStripMenuItem.Tag = "DisableBulkToolStripMenuItem"
        Me.DisableBulkToolStripMenuItem.Text = "Disable Selecetd"
        '
        'MoveBulkToolStripMenuItem
        '
        Me.MoveBulkToolStripMenuItem.Index = 11
        Me.MoveBulkToolStripMenuItem.Tag = "MoveBulkToolStripMenuItem"
        Me.MoveBulkToolStripMenuItem.Text = "Move..."
        '
        'DeleteBulkToolStripMenuItem
        '
        Me.DeleteBulkToolStripMenuItem.Index = 12
        Me.DeleteBulkToolStripMenuItem.Tag = "DeleteBulkToolStripMenuItem"
        Me.DeleteBulkToolStripMenuItem.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Index = 13
        Me.PropertiesToolStripMenuItem.Tag = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Text = "Properties..."
        '
        'ListViewContextMenu
        '
        Me.ListViewContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.RefreshMenuItem})
        '
        'RefreshMenuItem
        '
        Me.RefreshMenuItem.Index = 0
        Me.RefreshMenuItem.Text = "Refresh"
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(831, 442)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.SADMenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.SADMenuStrip
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "FormMain"
        Me.Text = "Simple AD - Active Directory Managment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SADMenuStrip.ResumeLayout(False)
        Me.SADMenuStrip.PerformLayout()
        Me.NodeContextMenu.ResumeLayout(False)
        Me.ContextMenuStripTrayIcon.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NodeContextMenu As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripTrayIcon As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemExit As ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportCSVDialog As SaveFileDialog
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLogin As ToolStripMenuItem
    Friend WithEvents RecentFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionStatusToolTip As ToolTip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DomainPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulkUserWizardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenActiveDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ShowGroupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SADMenuStrip As SimpleAD.ControlMenuStrip
    Friend WithEvents StatusStrip As SimpleAD.ControlStatusStrip
    Friend WithEvents ConnectionToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelContext As ToolStripStatusLabel
    Friend WithEvents UpdateToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelStatus As ToolStripStatusLabel
    Friend WithEvents Filler As ToolStripStatusLabel
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents RibbonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemplateManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents ControlToolStrip As ControlToolStrip
    Friend WithEvents ContainerToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents RowObjectContextMenu As ContextMenu
    Friend WithEvents CopyToClipBoardToolStripMenuItem As MenuItem
    Friend WithEvents CopyNameToolStripMenuItem As MenuItem
    Friend WithEvents CopyDNToolStripMenuItem As MenuItem
    Friend WithEvents CopySamToolStripMenuItem As MenuItem
    Friend WithEvents RenameMenuItem As MenuItem
    Friend WithEvents ResetSingleToolStripMenuItem As MenuItem
    Friend WithEvents EnableToolStripMenuItem As MenuItem
    Friend WithEvents DisableToolStripMenuItem As MenuItem
    Friend WithEvents MoveSingleToolStripMenuItem As MenuItem
    Friend WithEvents DeleteSingleToolStripMenuItem As MenuItem
    Friend WithEvents BulkModifyToolStripMenuItem As MenuItem
    Friend WithEvents ResetBulkToolStripMenuItem As MenuItem
    Friend WithEvents EnableBulkToolStripMenuItem As MenuItem
    Friend WithEvents DisableBulkToolStripMenuItem As MenuItem
    Friend WithEvents MoveBulkToolStripMenuItem As MenuItem
    Friend WithEvents DeleteBulkToolStripMenuItem As MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As MenuItem
    Friend WithEvents ListViewContextMenu As ContextMenu
    Friend WithEvents RefreshMenuItem As MenuItem
    Friend WithEvents ContainerExplorer As ContainerExplorer
    Friend WithEvents ThowExxceptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueryToolStripLabel As ToolStripStatusLabel
End Class
