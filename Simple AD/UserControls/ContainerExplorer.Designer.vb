Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerExplorer
    Inherits UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CopyToClipBoardToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyDNToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopySamToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.RowObjectContextMenu = New System.Windows.Forms.ContextMenu()
        Me.Seperator1 = New System.Windows.Forms.MenuItem()
        Me.RenameMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.Seperator2 = New System.Windows.Forms.MenuItem()
        Me.PingMachineToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.BulkModifyToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DisableBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.Seperator3 = New System.Windows.Forms.MenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenu()
        Me.RefreshMenuItem = New System.Windows.Forms.MenuItem()
        Me.DomainViewContextMenu = New System.Windows.Forms.ContextMenu()
        Me.SearchMenuItem = New System.Windows.Forms.MenuItem()
        Me.NewMenuItem = New System.Windows.Forms.MenuItem()
        Me.NewReportMenutItem = New System.Windows.Forms.MenuItem()
        Me.NewOuMenutItem = New System.Windows.Forms.MenuItem()
        Me.NewUserMenuItem = New System.Windows.Forms.MenuItem()
        Me.NewGroupMenuItem = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.RenameOuMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteOuMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveOuMenuItem = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.OuPropertiesMenuItem = New System.Windows.Forms.MenuItem()
        Me.MainSplitContainer = New SimpleAD.ControlSplitConatiner()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.MainListView = New SimpleAD.ControlDomainListView()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'RowObjectContextMenu
        '
        Me.RowObjectContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyToClipBoardToolStripMenuItem, Me.Seperator1, Me.RenameMenuItem, Me.MoveSingleToolStripMenuItem, Me.DeleteSingleToolStripMenuItem, Me.Seperator2, Me.PingMachineToolStripMenuItem, Me.ResetSingleToolStripMenuItem, Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem, Me.BulkModifyToolStripMenuItem, Me.ResetBulkToolStripMenuItem, Me.EnableBulkToolStripMenuItem, Me.DisableBulkToolStripMenuItem, Me.MoveBulkToolStripMenuItem, Me.DeleteBulkToolStripMenuItem, Me.Seperator3, Me.PropertiesToolStripMenuItem})
        '
        'Seperator1
        '
        Me.Seperator1.Index = 1
        Me.Seperator1.Tag = "Seperator1"
        Me.Seperator1.Text = "-"
        '
        'RenameMenuItem
        '
        Me.RenameMenuItem.Index = 2
        Me.RenameMenuItem.Tag = "RenameMenuItem"
        Me.RenameMenuItem.Text = "Rename"
        '
        'MoveSingleToolStripMenuItem
        '
        Me.MoveSingleToolStripMenuItem.Index = 3
        Me.MoveSingleToolStripMenuItem.Tag = "MoveSingleToolStripMenuItem"
        Me.MoveSingleToolStripMenuItem.Text = "Move..."
        '
        'DeleteSingleToolStripMenuItem
        '
        Me.DeleteSingleToolStripMenuItem.Index = 4
        Me.DeleteSingleToolStripMenuItem.Tag = "DeleteSingleToolStripMenuItem"
        Me.DeleteSingleToolStripMenuItem.Text = "Delete"
        '
        'Seperator2
        '
        Me.Seperator2.Index = 5
        Me.Seperator2.Tag = "Seperator2"
        Me.Seperator2.Text = "-"
        '
        'PingMachineToolStripMenuItem
        '
        Me.PingMachineToolStripMenuItem.Index = 6
        Me.PingMachineToolStripMenuItem.Tag = "PingMachineToolStripMenuItem"
        Me.PingMachineToolStripMenuItem.Text = "Ping..."
        '
        'ResetSingleToolStripMenuItem
        '
        Me.ResetSingleToolStripMenuItem.Index = 7
        Me.ResetSingleToolStripMenuItem.Tag = "ResetSingleToolStripMenuItem"
        Me.ResetSingleToolStripMenuItem.Text = "Reset Password"
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Index = 8
        Me.EnableToolStripMenuItem.Tag = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Index = 9
        Me.DisableToolStripMenuItem.Tag = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'BulkModifyToolStripMenuItem
        '
        Me.BulkModifyToolStripMenuItem.Index = 10
        Me.BulkModifyToolStripMenuItem.Tag = "BulkModifyToolStripMenuItem"
        Me.BulkModifyToolStripMenuItem.Text = "Bulk Modify..."
        '
        'ResetBulkToolStripMenuItem
        '
        Me.ResetBulkToolStripMenuItem.Index = 11
        Me.ResetBulkToolStripMenuItem.Tag = "ResetBulkToolStripMenuItem"
        Me.ResetBulkToolStripMenuItem.Text = "Reset Passwords In bulk"
        '
        'EnableBulkToolStripMenuItem
        '
        Me.EnableBulkToolStripMenuItem.Index = 12
        Me.EnableBulkToolStripMenuItem.Tag = "EnableBulkToolStripMenuItem"
        Me.EnableBulkToolStripMenuItem.Text = "Enable Selected"
        '
        'DisableBulkToolStripMenuItem
        '
        Me.DisableBulkToolStripMenuItem.Index = 13
        Me.DisableBulkToolStripMenuItem.Tag = "DisableBulkToolStripMenuItem"
        Me.DisableBulkToolStripMenuItem.Text = "Disable Selecetd"
        '
        'MoveBulkToolStripMenuItem
        '
        Me.MoveBulkToolStripMenuItem.Index = 14
        Me.MoveBulkToolStripMenuItem.Tag = "MoveBulkToolStripMenuItem"
        Me.MoveBulkToolStripMenuItem.Text = "Move..."
        '
        'DeleteBulkToolStripMenuItem
        '
        Me.DeleteBulkToolStripMenuItem.Index = 15
        Me.DeleteBulkToolStripMenuItem.Tag = "DeleteBulkToolStripMenuItem"
        Me.DeleteBulkToolStripMenuItem.Text = "Delete"
        '
        'Seperator3
        '
        Me.Seperator3.Index = 16
        Me.Seperator3.Tag = "Seperator3"
        Me.Seperator3.Text = "-"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Index = 17
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
        'DomainViewContextMenu
        '
        Me.DomainViewContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.SearchMenuItem, Me.NewMenuItem, Me.MenuItem10, Me.RenameOuMenuItem, Me.DeleteOuMenuItem, Me.MoveOuMenuItem, Me.MenuItem8, Me.OuPropertiesMenuItem})
        '
        'SearchMenuItem
        '
        Me.SearchMenuItem.Index = 0
        Me.SearchMenuItem.Tag = "SearchMenuItem"
        Me.SearchMenuItem.Text = "Search"
        '
        'NewMenuItem
        '
        Me.NewMenuItem.Index = 1
        Me.NewMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewReportMenutItem, Me.NewOuMenutItem, Me.NewUserMenuItem, Me.NewGroupMenuItem})
        Me.NewMenuItem.Text = "New"
        '
        'NewReportMenutItem
        '
        Me.NewReportMenutItem.Enabled = False
        Me.NewReportMenutItem.Index = 0
        Me.NewReportMenutItem.Tag = "NewReportMenutItem"
        Me.NewReportMenutItem.Text = "Report"
        '
        'NewOuMenutItem
        '
        Me.NewOuMenutItem.Index = 1
        Me.NewOuMenutItem.Text = "Organizational Unit"
        '
        'NewUserMenuItem
        '
        Me.NewUserMenuItem.Index = 2
        Me.NewUserMenuItem.Text = "User"
        '
        'NewGroupMenuItem
        '
        Me.NewGroupMenuItem.Enabled = False
        Me.NewGroupMenuItem.Index = 3
        Me.NewGroupMenuItem.Text = "Group"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.Text = "-"
        '
        'RenameOuMenuItem
        '
        Me.RenameOuMenuItem.Enabled = False
        Me.RenameOuMenuItem.Index = 3
        Me.RenameOuMenuItem.Text = "Rename"
        '
        'DeleteOuMenuItem
        '
        Me.DeleteOuMenuItem.Enabled = False
        Me.DeleteOuMenuItem.Index = 4
        Me.DeleteOuMenuItem.Text = "Delete"
        '
        'MoveOuMenuItem
        '
        Me.MoveOuMenuItem.Enabled = False
        Me.MoveOuMenuItem.Index = 5
        Me.MoveOuMenuItem.Text = "Move"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "-"
        '
        'OuPropertiesMenuItem
        '
        Me.OuPropertiesMenuItem.Enabled = False
        Me.OuPropertiesMenuItem.Index = 7
        Me.OuPropertiesMenuItem.Text = "Properties"
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer.Panel1.Controls.Add(Me.DomainTreeView)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer.Size = New System.Drawing.Size(823, 339)
        Me.MainSplitContainer.SpliterHeight = 0
        Me.MainSplitContainer.SplitterDistance = 264
        Me.MainSplitContainer.SplitterWidth = 1
        Me.MainSplitContainer.TabIndex = 5
        '
        'DomainTreeView
        '
        Me.DomainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DomainTreeView.DomainController = Nothing
        Me.DomainTreeView.DomainName = Nothing
        Me.DomainTreeView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTreeView.FullRowSelect = True
        Me.DomainTreeView.HideSelection = False
        Me.DomainTreeView.HotTracking = True
        Me.DomainTreeView.ImageIndex = 0
        Me.DomainTreeView.ItemHeight = 22
        Me.DomainTreeView.LabelEdit = True
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedItem = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(264, 339)
        Me.DomainTreeView.TabIndex = 0
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.EmptyListMsg = "Empty"
        Me.MainListView.EmptyListMsgFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(0, 0)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.OffRowContextMenu = Nothing
        Me.MainListView.RowContextMenu = Nothing
        Me.MainListView.RowHeight = 21
        Me.MainListView.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainListView.SelectedForeColor = System.Drawing.SystemColors.ControlText
        Me.MainListView.ShowFilterMenuOnRightClick = False
        Me.MainListView.ShowHeaderInAllViews = False
        Me.MainListView.ShowImagesOnSubItems = True
        Me.MainListView.ShowItemToolTips = True
        Me.MainListView.Size = New System.Drawing.Size(558, 339)
        Me.MainListView.SortGroupItemsByPrimaryColumn = False
        Me.MainListView.SpaceBetweenGroups = 4
        Me.MainListView.TabIndex = 1
        Me.MainListView.UseCellFormatEvents = True
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseFiltering = True
        Me.MainListView.UseHotControls = False
        Me.MainListView.UseHotItem = True
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'ContainerExplorer
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "ContainerExplorer"
        Me.Size = New System.Drawing.Size(823, 339)
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CopyToClipBoardToolStripMenuItem As MenuItem
    Friend WithEvents CopyDNToolStripMenuItem As MenuItem
    Friend WithEvents CopySamToolStripMenuItem As MenuItem
    Friend WithEvents CopyNameToolStripMenuItem As MenuItem
    Friend WithEvents RowObjectContextMenu As ContextMenu
    Friend WithEvents EnableToolStripMenuItem As MenuItem
    Friend WithEvents MoveSingleToolStripMenuItem As MenuItem
    Friend WithEvents DeleteSingleToolStripMenuItem As MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As MenuItem
    Friend WithEvents MainSplitContainer As SimpleAD.ControlSplitConatiner
    Friend WithEvents ResetSingleToolStripMenuItem As MenuItem
    Friend WithEvents BulkModifyToolStripMenuItem As MenuItem
    Friend WithEvents ResetBulkToolStripMenuItem As MenuItem
    Friend WithEvents MoveBulkToolStripMenuItem As MenuItem
    Friend WithEvents DeleteBulkToolStripMenuItem As MenuItem
    Friend WithEvents ListViewContextMenu As ContextMenu
    Friend WithEvents RefreshMenuItem As MenuItem
    Friend WithEvents MainListView As ControlDomainListView
    Friend WithEvents RenameMenuItem As MenuItem
    Friend WithEvents EnableBulkToolStripMenuItem As MenuItem
    Friend WithEvents DisableBulkToolStripMenuItem As MenuItem
    Friend WithEvents DisableToolStripMenuItem As MenuItem
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents DomainViewContextMenu As ContextMenu
    Friend WithEvents NewMenuItem As MenuItem
    Friend WithEvents NewOuMenutItem As MenuItem
    Friend WithEvents NewUserMenuItem As MenuItem
    Friend WithEvents NewGroupMenuItem As MenuItem
    Friend WithEvents RenameOuMenuItem As MenuItem
    Friend WithEvents DeleteOuMenuItem As MenuItem
    Friend WithEvents MoveOuMenuItem As MenuItem
    Friend WithEvents MenuItem10 As MenuItem
    Friend WithEvents MenuItem8 As MenuItem
    Friend WithEvents OuPropertiesMenuItem As MenuItem
    Friend WithEvents Seperator1 As MenuItem
    Friend WithEvents Seperator2 As MenuItem
    Friend WithEvents Seperator3 As MenuItem
    Friend WithEvents SearchMenuItem As MenuItem
    Friend WithEvents PingMachineToolStripMenuItem As MenuItem
    Friend WithEvents NewReportMenutItem As MenuItem
End Class