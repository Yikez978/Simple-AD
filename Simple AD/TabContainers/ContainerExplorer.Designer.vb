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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Everything", 3, 3)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disabled Users", 4, 4)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All Admins")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Built In Views", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Me.CopyToClipBoardToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyDNToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopySamToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.RowObjectContextMenu = New System.Windows.Forms.ContextMenu()
        Me.RenameMenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableDisableSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.BulkModifyToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableDisableBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenu()
        Me.RefreshMenuItem = New System.Windows.Forms.MenuItem()
        Me.ViewMenuItem = New System.Windows.Forms.MenuItem()
        Me.DetailsMenuItem = New System.Windows.Forms.MenuItem()
        Me.ListMenuItem = New System.Windows.Forms.MenuItem()
        Me.SmallIconsMenuItem = New System.Windows.Forms.MenuItem()
        Me.LargeIconsMenuItem = New System.Windows.Forms.MenuItem()
        Me.TilesMenuItem = New System.Windows.Forms.MenuItem()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MainSplitContainer = New SimpleAD.ControlSplitConatiner()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TypeColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
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
        Me.RowObjectContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyToClipBoardToolStripMenuItem, Me.RenameMenuItem, Me.ResetSingleToolStripMenuItem, Me.EnableDisableSingleToolStripMenuItem, Me.MoveSingleToolStripMenuItem, Me.DeleteSingleToolStripMenuItem, Me.BulkModifyToolStripMenuItem, Me.ResetBulkToolStripMenuItem, Me.EnableDisableBulkToolStripMenuItem, Me.MoveBulkToolStripMenuItem, Me.DeleteBulkToolStripMenuItem, Me.PropertiesToolStripMenuItem})
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
        'EnableDisableSingleToolStripMenuItem
        '
        Me.EnableDisableSingleToolStripMenuItem.Index = 3
        Me.EnableDisableSingleToolStripMenuItem.Tag = "EnableDisableSingleToolStripMenuItem"
        Me.EnableDisableSingleToolStripMenuItem.Text = "Enable/Disable"
        '
        'MoveSingleToolStripMenuItem
        '
        Me.MoveSingleToolStripMenuItem.Index = 4
        Me.MoveSingleToolStripMenuItem.Tag = "MoveSingleToolStripMenuItem"
        Me.MoveSingleToolStripMenuItem.Text = "Move..."
        '
        'DeleteSingleToolStripMenuItem
        '
        Me.DeleteSingleToolStripMenuItem.Index = 5
        Me.DeleteSingleToolStripMenuItem.Tag = "DeleteSingleToolStripMenuItem"
        Me.DeleteSingleToolStripMenuItem.Text = "Delete"
        '
        'BulkModifyToolStripMenuItem
        '
        Me.BulkModifyToolStripMenuItem.Index = 6
        Me.BulkModifyToolStripMenuItem.Tag = "BulkModifyToolStripMenuItem"
        Me.BulkModifyToolStripMenuItem.Text = "Bulk Modify..."
        '
        'ResetBulkToolStripMenuItem
        '
        Me.ResetBulkToolStripMenuItem.Index = 7
        Me.ResetBulkToolStripMenuItem.Tag = "ResetBulkToolStripMenuItem"
        Me.ResetBulkToolStripMenuItem.Text = "Reset Passwords In bulk"
        '
        'EnableDisableBulkToolStripMenuItem
        '
        Me.EnableDisableBulkToolStripMenuItem.Index = 8
        Me.EnableDisableBulkToolStripMenuItem.Tag = "EnableDisableBulkToolStripMenuItem"
        Me.EnableDisableBulkToolStripMenuItem.Text = "Enable/Disable"
        '
        'MoveBulkToolStripMenuItem
        '
        Me.MoveBulkToolStripMenuItem.Index = 9
        Me.MoveBulkToolStripMenuItem.Tag = "MoveBulkToolStripMenuItem"
        Me.MoveBulkToolStripMenuItem.Text = "Move..."
        '
        'DeleteBulkToolStripMenuItem
        '
        Me.DeleteBulkToolStripMenuItem.Index = 10
        Me.DeleteBulkToolStripMenuItem.Tag = "DeleteBulkToolStripMenuItem"
        Me.DeleteBulkToolStripMenuItem.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Index = 11
        Me.PropertiesToolStripMenuItem.Tag = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Text = "Properties..."
        '
        'ListViewContextMenu
        '
        Me.ListViewContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.RefreshMenuItem, Me.ViewMenuItem})
        '
        'RefreshMenuItem
        '
        Me.RefreshMenuItem.Index = 0
        Me.RefreshMenuItem.Text = "Refresh"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.Index = 1
        Me.ViewMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DetailsMenuItem, Me.ListMenuItem, Me.SmallIconsMenuItem, Me.LargeIconsMenuItem, Me.TilesMenuItem})
        Me.ViewMenuItem.Text = "View"
        '
        'DetailsMenuItem
        '
        Me.DetailsMenuItem.Index = 0
        Me.DetailsMenuItem.Text = "Details"
        '
        'ListMenuItem
        '
        Me.ListMenuItem.Index = 1
        Me.ListMenuItem.Text = "List"
        '
        'SmallIconsMenuItem
        '
        Me.SmallIconsMenuItem.Index = 2
        Me.SmallIconsMenuItem.Text = "Small Icons"
        '
        'LargeIconsMenuItem
        '
        Me.LargeIconsMenuItem.Index = 3
        Me.LargeIconsMenuItem.Text = "Large Icons"
        '
        'TilesMenuItem
        '
        Me.TilesMenuItem.Index = 4
        Me.TilesMenuItem.Text = "Tiles"
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer.Panel1.Controls.Add(Me.DomainTreeView)
        Me.MainSplitContainer.Panel1.Padding = New System.Windows.Forms.Padding(0, 22, 0, 0)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer.Size = New System.Drawing.Size(823, 402)
        Me.MainSplitContainer.SplitterDistance = 220
        Me.MainSplitContainer.SplitterWidth = 1
        Me.MainSplitContainer.TabIndex = 5
        '
        'DomainTreeView
        '
        Me.DomainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DomainTreeView.DomainController = Nothing
        Me.DomainTreeView.DomainName = Nothing
        Me.DomainTreeView.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTreeView.FullRowSelect = True
        Me.DomainTreeView.HideSelection = False
        Me.DomainTreeView.HotTracking = True
        Me.DomainTreeView.ImageIndex = 0
        Me.DomainTreeView.ItemHeight = 22
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 22)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        TreeNode1.ImageIndex = 3
        TreeNode1.Name = "EverythingNode"
        TreeNode1.SelectedImageIndex = 3
        TreeNode1.Text = "Everything"
        TreeNode2.ImageIndex = 4
        TreeNode2.Name = "DisabledUsersNode"
        TreeNode2.SelectedImageIndex = 4
        TreeNode2.Text = "Disabled Users"
        TreeNode3.ImageKey = "Users"
        TreeNode3.Name = "AllAdminsNode"
        TreeNode3.SelectedImageKey = "Users"
        TreeNode3.Tag = "All Admins"
        TreeNode3.Text = "All Admins"
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = "BuiltInRoot"
        TreeNode4.SelectedImageIndex = 2
        TreeNode4.Text = "Built In Views"
        Me.DomainTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedOU = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(220, 380)
        Me.DomainTreeView.TabIndex = 2
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.AllColumns.Add(Me.NameColumn)
        Me.MainListView.AllColumns.Add(Me.TypeColumn)
        Me.MainListView.AllColumns.Add(Me.DescColumn)
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.DescColumn})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.EmptyListMsg = "No Results"
        Me.MainListView.EmptyListMsgFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HeaderUsesThemes = True
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(0, 0)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.OwnerDraw = False
        Me.MainListView.RowHeight = 21
        Me.MainListView.ShowGroups = False
        Me.MainListView.ShowHeaderInAllViews = False
        Me.MainListView.Size = New System.Drawing.Size(602, 402)
        Me.MainListView.TabIndex = 1
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseExplorerTheme = True
        Me.MainListView.UseFiltering = True
        Me.MainListView.UseHotControls = False
        Me.MainListView.UseNotifyPropertyChanged = True
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.AspectName = "Name"
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 205
        '
        'TypeColumn
        '
        Me.TypeColumn.AspectName = "TypeFriendly"
        Me.TypeColumn.IsTileViewColumn = True
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 137
        '
        'DescColumn
        '
        Me.DescColumn.AspectName = "Description"
        Me.DescColumn.IsTileViewColumn = True
        Me.DescColumn.Text = "Description"
        Me.DescColumn.Width = 253
        '
        'ContainerExplorer
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "ContainerExplorer"
        Me.Size = New System.Drawing.Size(823, 402)
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
    Friend WithEvents EnableDisableSingleToolStripMenuItem As MenuItem
    Friend WithEvents MoveSingleToolStripMenuItem As MenuItem
    Friend WithEvents DeleteSingleToolStripMenuItem As MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As MenuItem
    Friend WithEvents MainSplitContainer As SimpleAD.ControlSplitConatiner
    Friend WithEvents ResetSingleToolStripMenuItem As MenuItem
    Friend WithEvents BulkModifyToolStripMenuItem As MenuItem
    Friend WithEvents ResetBulkToolStripMenuItem As MenuItem
    Friend WithEvents EnableDisableBulkToolStripMenuItem As MenuItem
    Friend WithEvents MoveBulkToolStripMenuItem As MenuItem
    Friend WithEvents DeleteBulkToolStripMenuItem As MenuItem
    Friend WithEvents ListViewContextMenu As ContextMenu
    Friend WithEvents RefreshMenuItem As MenuItem
    Friend WithEvents ViewMenuItem As MenuItem
    Friend WithEvents DetailsMenuItem As MenuItem
    Friend WithEvents ListMenuItem As MenuItem
    Friend WithEvents SmallIconsMenuItem As MenuItem
    Friend WithEvents LargeIconsMenuItem As MenuItem
    Friend WithEvents TilesMenuItem As MenuItem
    Friend WithEvents ContextMenu1 As ContextMenu
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameColumn As OLVColumn
    Friend WithEvents TypeColumn As OLVColumn
    Friend WithEvents DescColumn As OLVColumn
    Friend WithEvents RenameMenuItem As MenuItem
End Class