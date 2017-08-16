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
        Dim SADMenuStrip As System.Windows.Forms.MenuStrip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulkUserWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office365ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntireDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAsCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenActiveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomainPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideEmptyColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.NodeContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportCSVDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialogImport = New System.Windows.Forms.OpenFileDialog()
        Me.ConnectionStatusToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTabCtrl = New SimpleAD.CustomTabControl()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelContext = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SpacerToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VersionLb = New MetroFramework.Controls.MetroLabel()
        SADMenuStrip = New System.Windows.Forms.MenuStrip()
        SADMenuStrip.SuspendLayout()
        Me.NodeContextMenu.SuspendLayout()
        Me.ContextMenuStripTrayIcon.SuspendLayout()
        Me.TabContextMenu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SADMenuStrip
        '
        SADMenuStrip.BackColor = System.Drawing.SystemColors.Window
        SADMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        SADMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.Office365ToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.PreferencesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.UserToolStripMenuItem})
        SADMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        SADMenuStrip.Location = New System.Drawing.Point(1, 60)
        SADMenuStrip.Name = "SADMenuStrip"
        SADMenuStrip.Size = New System.Drawing.Size(1221, 24)
        SADMenuStrip.TabIndex = 14
        SADMenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem, Me.ImportCSVToolStripMenuItem, Me.BulkUserWizardToolStripMenuItem, Me.NewFormToolStripMenuItem, Me.RecentFilesToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FileToolStripMenuItem.Text = "Simple AD"
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
        'NewFormToolStripMenuItem
        '
        Me.NewFormToolStripMenuItem.Name = "NewFormToolStripMenuItem"
        Me.NewFormToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NewFormToolStripMenuItem.Text = "Demo Form"
        '
        'Office365ToolStripMenuItem
        '
        Me.Office365ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem})
        Me.Office365ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office365ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Office365ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Office365ToolStripMenuItem.Name = "Office365ToolStripMenuItem"
        Me.Office365ToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.Office365ToolStripMenuItem.Text = "Office 365"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect..."
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisabledUsersToolStripMenuItem, Me.CustomQueryToolStripMenuItem, Me.EntireDirectoryToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'DisabledUsersToolStripMenuItem
        '
        Me.DisabledUsersToolStripMenuItem.Name = "DisabledUsersToolStripMenuItem"
        Me.DisabledUsersToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DisabledUsersToolStripMenuItem.Text = "Disabled Users..."
        '
        'CustomQueryToolStripMenuItem
        '
        Me.CustomQueryToolStripMenuItem.Name = "CustomQueryToolStripMenuItem"
        Me.CustomQueryToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CustomQueryToolStripMenuItem.Text = "Custom LDAP Query..."
        '
        'EntireDirectoryToolStripMenuItem
        '
        Me.EntireDirectoryToolStripMenuItem.Name = "EntireDirectoryToolStripMenuItem"
        Me.EntireDirectoryToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EntireDirectoryToolStripMenuItem.Text = "Entire Directory..."
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
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAsCSVToolStripMenuItem, Me.OpenActiveDirectoryToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ToolsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'ExportAsCSVToolStripMenuItem
        '
        Me.ExportAsCSVToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportAsCSVToolStripMenuItem.Name = "ExportAsCSVToolStripMenuItem"
        Me.ExportAsCSVToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ExportAsCSVToolStripMenuItem.Text = "&Export as CSV..."
        '
        'OpenActiveDirectoryToolStripMenuItem
        '
        Me.OpenActiveDirectoryToolStripMenuItem.Name = "OpenActiveDirectoryToolStripMenuItem"
        Me.OpenActiveDirectoryToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OpenActiveDirectoryToolStripMenuItem.Text = "Open Active Directory..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DomainPanelToolStripMenuItem, Me.ToolStripSeparator2, Me.HideEmptyColumnsToolStripMenuItem, Me.SelectColumnsToolStripMenuItem, Me.ToolStripSeparator3, Me.ConsoleToolStripMenuItem})
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
        Me.DomainPanelToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DomainPanelToolStripMenuItem.Text = "Domain Panel..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'HideEmptyColumnsToolStripMenuItem
        '
        Me.HideEmptyColumnsToolStripMenuItem.CheckOnClick = True
        Me.HideEmptyColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HideEmptyColumnsToolStripMenuItem.Name = "HideEmptyColumnsToolStripMenuItem"
        Me.HideEmptyColumnsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.HideEmptyColumnsToolStripMenuItem.Text = "&Hide Empty Columns"
        '
        'SelectColumnsToolStripMenuItem
        '
        Me.SelectColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectColumnsToolStripMenuItem.Name = "SelectColumnsToolStripMenuItem"
        Me.SelectColumnsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SelectColumnsToolStripMenuItem.Text = "&Select Columns..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ConsoleToolStripMenuItem.Text = "Console..."
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemLogin})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
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
        'ExportCSVDialog
        '
        '
        'OpenFileDialogImport
        '
        Me.OpenFileDialogImport.FileName = "OpenFileDialog1"
        '
        'TabContextMenu
        '
        Me.TabContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.TabContextMenu.Name = "TabContextMenu"
        Me.TabContextMenu.Size = New System.Drawing.Size(104, 26)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'MainTabCtrl
        '
        Me.MainTabCtrl.BackColor = System.Drawing.SystemColors.Window
        Me.MainTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabCtrl.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTabCtrl.HotTrack = True
        Me.MainTabCtrl.InactiveTabBackColor = System.Drawing.SystemColors.Window
        Me.MainTabCtrl.ItemSize = New System.Drawing.Size(100, 40)
        Me.MainTabCtrl.Location = New System.Drawing.Point(1, 84)
        Me.MainTabCtrl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTabCtrl.Name = "MainTabCtrl"
        Me.MainTabCtrl.Padding = New System.Drawing.Point(0, 0)
        Me.MainTabCtrl.SelectedIndex = 0
        Me.MainTabCtrl.Size = New System.Drawing.Size(1221, 592)
        Me.MainTabCtrl.TabIndex = 17
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelContext, Me.ToolStripStatusLabelStatus, Me.SpacerToolStripStatusLabel, Me.ConnectionToolStripStatusLabel, Me.UpdateToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(1, 676)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.ShowItemToolTips = True
        Me.StatusStrip.Size = New System.Drawing.Size(1221, 24)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.Stretch = False
        Me.StatusStrip.TabIndex = 18
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabelContext
        '
        Me.ToolStripStatusLabelContext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripStatusLabelContext.Name = "ToolStripStatusLabelContext"
        Me.ToolStripStatusLabelContext.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripStatusLabelContext.Size = New System.Drawing.Size(20, 19)
        '
        'ToolStripStatusLabelStatus
        '
        Me.ToolStripStatusLabelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripStatusLabelStatus.Name = "ToolStripStatusLabelStatus"
        Me.ToolStripStatusLabelStatus.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripStatusLabelStatus.Size = New System.Drawing.Size(20, 19)
        '
        'SpacerToolStripStatusLabel
        '
        Me.SpacerToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.SpacerToolStripStatusLabel.Name = "SpacerToolStripStatusLabel"
        Me.SpacerToolStripStatusLabel.Size = New System.Drawing.Size(1146, 19)
        Me.SpacerToolStripStatusLabel.Spring = True
        Me.SpacerToolStripStatusLabel.Text = " "
        '
        'ConnectionToolStripStatusLabel
        '
        Me.ConnectionToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ConnectionToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ConnectionToolStripStatusLabel.Name = "ConnectionToolStripStatusLabel"
        Me.ConnectionToolStripStatusLabel.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ConnectionToolStripStatusLabel.Size = New System.Drawing.Size(20, 19)
        '
        'UpdateToolStripStatusLabel
        '
        Me.UpdateToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.UpdateToolStripStatusLabel.Name = "UpdateToolStripStatusLabel"
        Me.UpdateToolStripStatusLabel.Size = New System.Drawing.Size(0, 19)
        '
        'VersionLb
        '
        Me.VersionLb.AutoSize = True
        Me.VersionLb.BackColor = System.Drawing.SystemColors.Window
        Me.VersionLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.VersionLb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.VersionLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.VersionLb.Location = New System.Drawing.Point(452, 35)
        Me.VersionLb.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.VersionLb.Name = "VersionLb"
        Me.VersionLb.Size = New System.Drawing.Size(46, 15)
        Me.VersionLb.TabIndex = 19
        Me.VersionLb.Text = "Version"
        Me.VersionLb.UseCustomBackColor = True
        Me.VersionLb.UseCustomForeColor = True
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1223, 701)
        Me.Controls.Add(Me.VersionLb)
        Me.Controls.Add(Me.MainTabCtrl)
        Me.Controls.Add(SADMenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.ControlText
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = SADMenuStrip
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(1, 60, 1, 1)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Simple AD - Active Directory Managment"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        SADMenuStrip.ResumeLayout(False)
        SADMenuStrip.PerformLayout()
        Me.NodeContextMenu.ResumeLayout(False)
        Me.ContextMenuStripTrayIcon.ResumeLayout(False)
        Me.TabContextMenu.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NodeContextMenu As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripTrayIcon As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemExit As ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportAsCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportCSVDialog As SaveFileDialog
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideEmptyColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialogImport As OpenFileDialog
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLogin As ToolStripMenuItem
    Friend WithEvents RecentFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionStatusToolTip As ToolTip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DomainPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulkUserWizardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisabledUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabContextMenu As ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenActiveDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Office365ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomQueryToolStripMenuItem As ToolStripMenuItem
    Private WithEvents MainTabCtrl As CustomTabControl
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabelContext As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelStatus As ToolStripStatusLabel
    Friend WithEvents SpacerToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ConnectionToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents VersionLb As Controls.MetroLabel
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents EntireDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewFormToolStripMenuItem As ToolStripMenuItem
End Class
