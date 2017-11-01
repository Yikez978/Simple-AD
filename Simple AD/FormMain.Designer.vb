<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits SimpleAD.FormSimpleAD

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
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulkUserWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenActiveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomainPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NodeContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportCSVDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ConnectionStatusToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainTabCtrl = New SimpleAD.CustomTabControl()
        Me.ExplorerTab = New System.Windows.Forms.TabPage()
        Me.ContainerUserAndComputers = New SimpleAD.ContainerExplorer()
        Me.ImportTab = New System.Windows.Forms.TabPage()
        Me.ContainerUserImport = New SimpleAD.ContainerImport()
        Me.TemplateTab = New System.Windows.Forms.TabPage()
        Me.ContainerTemplate = New SimpleAD.ContainerTemplate()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.StatusStrip = New SimpleAD.ControlStatusStrip()
        Me.ToolStripStatusLabelContext = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Filler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainSideBarSplitContainer = New SimpleAD.ControlSplitConatiner()
        Me.TaskFlow = New System.Windows.Forms.TableLayoutPanel()
        Me.TaskHeaderPl = New SimpleAD.ControlHeaderPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SADMenuStrip.SuspendLayout()
        Me.NodeContextMenu.SuspendLayout()
        Me.ContextMenuStripTrayIcon.SuspendLayout()
        Me.MainTabCtrl.SuspendLayout()
        Me.ExplorerTab.SuspendLayout()
        Me.ImportTab.SuspendLayout()
        Me.TemplateTab.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.MainSideBarSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSideBarSplitContainer.Panel1.SuspendLayout()
        Me.MainSideBarSplitContainer.Panel2.SuspendLayout()
        Me.MainSideBarSplitContainer.SuspendLayout()
        Me.TaskHeaderPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'SADMenuStrip
        '
        Me.SADMenuStrip.BackColor = System.Drawing.SystemColors.Window
        Me.SADMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.SADMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PreferencesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.UserToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.SADMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.SADMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SADMenuStrip.Name = "SADMenuStrip"
        Me.SADMenuStrip.Size = New System.Drawing.Size(1299, 24)
        Me.SADMenuStrip.TabIndex = 14
        Me.SADMenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem, Me.ImportCSVToolStripMenuItem, Me.BulkUserWizardToolStripMenuItem, Me.RecentFilesToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'ImportCSVToolStripMenuItem
        '
        Me.ImportCSVToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportCSVToolStripMenuItem.Name = "ImportCSVToolStripMenuItem"
        Me.ImportCSVToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ImportCSVToolStripMenuItem.Text = "Import CSV..."
        '
        'BulkUserWizardToolStripMenuItem
        '
        Me.BulkUserWizardToolStripMenuItem.Name = "BulkUserWizardToolStripMenuItem"
        Me.BulkUserWizardToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BulkUserWizardToolStripMenuItem.Text = "&Bulk User Wizard..."
        '
        'RecentFilesToolStripMenuItem
        '
        Me.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem"
        Me.RecentFilesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RecentFilesToolStripMenuItem.Text = "Recent Files"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for Updates..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DomainPanelToolStripMenuItem, Me.TaskPanelToolStripMenuItem, Me.ToolStripSeparator2, Me.ShowGroupsToolStripMenuItem, Me.ModeToolStripMenuItem, Me.ToolStripSeparator3, Me.ConsoleToolStripMenuItem, Me.VersionToolStripMenuItem})
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
        Me.DomainPanelToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DomainPanelToolStripMenuItem.Text = "Domain Panel..."
        '
        'TaskPanelToolStripMenuItem
        '
        Me.TaskPanelToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TaskPanelToolStripMenuItem.Checked = True
        Me.TaskPanelToolStripMenuItem.CheckOnClick = True
        Me.TaskPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TaskPanelToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TaskPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TaskPanelToolStripMenuItem.Name = "TaskPanelToolStripMenuItem"
        Me.TaskPanelToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TaskPanelToolStripMenuItem.Text = "Task Panel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'ShowGroupsToolStripMenuItem
        '
        Me.ShowGroupsToolStripMenuItem.Name = "ShowGroupsToolStripMenuItem"
        Me.ShowGroupsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ShowGroupsToolStripMenuItem.Text = "Show Groups"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallIconsToolStripMenuItem, Me.LargeIconsToolStripMenuItem, Me.ListToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.TileToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'SmallIconsToolStripMenuItem
        '
        Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SmallIconsToolStripMenuItem.Text = "Small Icons"
        '
        'LargeIconsToolStripMenuItem
        '
        Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LargeIconsToolStripMenuItem.Text = "Large Icons"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.TileToolStripMenuItem.Text = "Tile"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(153, 6)
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ConsoleToolStripMenuItem.Text = "Console..."
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.VersionToolStripMenuItem.Text = "Version"
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
        'MainTabCtrl
        '
        Me.MainTabCtrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MainTabCtrl.Controls.Add(Me.ExplorerTab)
        Me.MainTabCtrl.Controls.Add(Me.ImportTab)
        Me.MainTabCtrl.Controls.Add(Me.TemplateTab)
        Me.MainTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainTabCtrl.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTabCtrl.HotTrack = True
        Me.MainTabCtrl.HotTrackTabColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.MainTabCtrl.ItemSize = New System.Drawing.Size(0, 38)
        Me.MainTabCtrl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabCtrl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTabCtrl.Name = "MainTabCtrl"
        Me.MainTabCtrl.Padding = New System.Drawing.Point(48, 0)
        Me.MainTabCtrl.SelectedIndex = 0
        Me.MainTabCtrl.Size = New System.Drawing.Size(1030, 568)
        Me.MainTabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MainTabCtrl.TabColor = System.Drawing.SystemColors.Window
        Me.MainTabCtrl.TabIndex = 17
        '
        'ExplorerTab
        '
        Me.ExplorerTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ExplorerTab.Controls.Add(Me.ContainerUserAndComputers)
        Me.ExplorerTab.Location = New System.Drawing.Point(0, 41)
        Me.ExplorerTab.Name = "ExplorerTab"
        Me.ExplorerTab.Size = New System.Drawing.Size(1030, 527)
        Me.ExplorerTab.TabIndex = 0
        Me.ExplorerTab.Text = "Users and Computers"
        '
        'ContainerUserAndComputers
        '
        Me.ContainerUserAndComputers.BackColor = System.Drawing.SystemColors.Window
        Me.ContainerUserAndComputers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerUserAndComputers.Job = Nothing
        Me.ContainerUserAndComputers.Location = New System.Drawing.Point(0, 0)
        Me.ContainerUserAndComputers.Name = "ContainerUserAndComputers"
        Me.ContainerUserAndComputers.Path = "DC=dataspire,DC=co,DC=uk"
        Me.ContainerUserAndComputers.Size = New System.Drawing.Size(1030, 527)
        Me.ContainerUserAndComputers.TabIndex = 0
        '
        'ImportTab
        '
        Me.ImportTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ImportTab.Controls.Add(Me.ContainerUserImport)
        Me.ImportTab.Location = New System.Drawing.Point(0, 41)
        Me.ImportTab.Name = "ImportTab"
        Me.ImportTab.Size = New System.Drawing.Size(1027, 527)
        Me.ImportTab.TabIndex = 1
        Me.ImportTab.Text = "User Import"
        '
        'ContainerUserImport
        '
        Me.ContainerUserImport.BackColor = System.Drawing.SystemColors.Window
        Me.ContainerUserImport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerUserImport.Location = New System.Drawing.Point(0, 0)
        Me.ContainerUserImport.Name = "ContainerUserImport"
        Me.ContainerUserImport.Size = New System.Drawing.Size(1027, 527)
        Me.ContainerUserImport.TabIndex = 0
        '
        'TemplateTab
        '
        Me.TemplateTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TemplateTab.Controls.Add(Me.ContainerTemplate)
        Me.TemplateTab.Location = New System.Drawing.Point(0, 41)
        Me.TemplateTab.Name = "TemplateTab"
        Me.TemplateTab.Size = New System.Drawing.Size(1027, 527)
        Me.TemplateTab.TabIndex = 2
        Me.TemplateTab.Text = "Template Manager"
        '
        'ContainerTemplate
        '
        Me.ContainerTemplate.BackColor = System.Drawing.SystemColors.Window
        Me.ContainerTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerTemplate.Location = New System.Drawing.Point(0, 0)
        Me.ContainerTemplate.Name = "ContainerTemplate"
        Me.ContainerTemplate.Size = New System.Drawing.Size(1299, 527)
        Me.ContainerTemplate.TabIndex = 0
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
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelContext, Me.ToolStripStatusLabelStatus, Me.Filler, Me.UpdateToolStripStatusLabel, Me.ConnectionToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 592)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.ShowItemToolTips = True
        Me.StatusStrip.Size = New System.Drawing.Size(1299, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 18
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabelContext
        '
        Me.ToolStripStatusLabelContext.Name = "ToolStripStatusLabelContext"
        Me.ToolStripStatusLabelContext.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabelStatus
        '
        Me.ToolStripStatusLabelStatus.Name = "ToolStripStatusLabelStatus"
        Me.ToolStripStatusLabelStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Filler
        '
        Me.Filler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Filler.Name = "Filler"
        Me.Filler.Size = New System.Drawing.Size(1284, 17)
        Me.Filler.Spring = True
        '
        'UpdateToolStripStatusLabel
        '
        Me.UpdateToolStripStatusLabel.Name = "UpdateToolStripStatusLabel"
        Me.UpdateToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ConnectionToolStripStatusLabel
        '
        Me.ConnectionToolStripStatusLabel.Name = "ConnectionToolStripStatusLabel"
        Me.ConnectionToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'MainSideBarSplitContainer
        '
        Me.MainSideBarSplitContainer.BackColor = System.Drawing.SystemColors.Window
        Me.MainSideBarSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSideBarSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.MainSideBarSplitContainer.IsSplitterFixed = True
        Me.MainSideBarSplitContainer.Location = New System.Drawing.Point(0, 24)
        Me.MainSideBarSplitContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MainSideBarSplitContainer.Name = "MainSideBarSplitContainer"
        '
        'MainSideBarSplitContainer.Panel1
        '
        Me.MainSideBarSplitContainer.Panel1.Controls.Add(Me.MainTabCtrl)
        Me.MainSideBarSplitContainer.Panel1MinSize = 800
        '
        'MainSideBarSplitContainer.Panel2
        '
        Me.MainSideBarSplitContainer.Panel2.AutoScroll = True
        Me.MainSideBarSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.MainSideBarSplitContainer.Panel2.Controls.Add(Me.TaskFlow)
        Me.MainSideBarSplitContainer.Panel2.Controls.Add(Me.TaskHeaderPl)
        Me.MainSideBarSplitContainer.Size = New System.Drawing.Size(1299, 568)
        Me.MainSideBarSplitContainer.SpliterHeight = 0
        Me.MainSideBarSplitContainer.SplitterDistance = 1030
        Me.MainSideBarSplitContainer.SplitterWidth = 1
        Me.MainSideBarSplitContainer.TabIndex = 19
        '
        'TaskFlow
        '
        Me.TaskFlow.AutoScroll = True
        Me.TaskFlow.AutoSize = True
        Me.TaskFlow.ColumnCount = 1
        Me.TaskFlow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TaskFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskFlow.Location = New System.Drawing.Point(0, 41)
        Me.TaskFlow.Name = "TaskFlow"
        Me.TaskFlow.RowCount = 1
        Me.TaskFlow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TaskFlow.Size = New System.Drawing.Size(268, 527)
        Me.TaskFlow.TabIndex = 0
        '
        'TaskHeaderPl
        '
        Me.TaskHeaderPl.BackColor = System.Drawing.SystemColors.Control
        Me.TaskHeaderPl.Controls.Add(Me.Label1)
        Me.TaskHeaderPl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TaskHeaderPl.Location = New System.Drawing.Point(0, 0)
        Me.TaskHeaderPl.Name = "TaskHeaderPl"
        Me.TaskHeaderPl.Size = New System.Drawing.Size(268, 41)
        Me.TaskHeaderPl.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tasks"
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1299, 614)
        Me.Controls.Add(Me.MainSideBarSplitContainer)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SADMenuStrip)
        Me.DoubleBuffered = True
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
        Me.MainTabCtrl.ResumeLayout(False)
        Me.ExplorerTab.ResumeLayout(False)
        Me.ImportTab.ResumeLayout(False)
        Me.TemplateTab.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MainSideBarSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSideBarSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSideBarSplitContainer.Panel2.PerformLayout()
        CType(Me.MainSideBarSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSideBarSplitContainer.ResumeLayout(False)
        Me.TaskHeaderPl.ResumeLayout(False)
        Me.TaskHeaderPl.PerformLayout()
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
    Friend WithEvents MainTabCtrl As CustomTabControl
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowGroupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SADMenuStrip As SimpleAD.ControlMenuStrip
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents ExplorerTab As TabPage
    Friend WithEvents ImportTab As TabPage
    Friend WithEvents TemplateTab As TabPage
    Friend WithEvents ContainerUserAndComputers As ContainerExplorer
    Friend WithEvents ContainerUserImport As ContainerImport
    Friend WithEvents ContainerTemplate As ContainerTemplate
    Friend WithEvents MainSideBarSplitContainer As ControlSplitConatiner
    Friend WithEvents TaskFlow As TableLayoutPanel
    Friend WithEvents TaskPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskHeaderPl As ControlHeaderPanel
    Friend WithEvents Label1 As Label
End Class
