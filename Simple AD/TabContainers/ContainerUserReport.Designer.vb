<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerUserReport
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
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulkContextMenu = New System.Windows.Forms.ContextMenu()
        Me.BulkModifyToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.EnableDisableBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveBulkToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyToClipBoardToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyDNToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopySamToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.SingleContextMenu = New System.Windows.Forms.ContextMenu()
        Me.EnableDisableSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.DeleteSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.SpacerPanel = New System.Windows.Forms.Panel()
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TypeColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ListViewContextMenu.SuspendLayout()
        Me.SpacerPanel.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewContextMenu
        '
        Me.ListViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.ListViewContextMenu.Name = "ListViewContextMenu"
        Me.ListViewContextMenu.Size = New System.Drawing.Size(100, 26)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeIconsToolStripMenuItem, Me.ListToolStripMenuItem, Me.SmallIconsToolStripMenuItem, Me.DetailsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LargeIconsToolStripMenuItem
        '
        Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LargeIconsToolStripMenuItem.Text = "Large Icons"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'SmallIconsToolStripMenuItem
        '
        Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SmallIconsToolStripMenuItem.Text = "Small Icons"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'BulkContextMenu
        '
        Me.BulkContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BulkModifyToolStripMenuItem, Me.EnableDisableBulkToolStripMenuItem, Me.MoveBulkToolStripMenuItem, Me.DeleteToolStripMenuItem})
        '
        'BulkModifyToolStripMenuItem
        '
        Me.BulkModifyToolStripMenuItem.Index = 0
        Me.BulkModifyToolStripMenuItem.Text = "Bulk Modify..."
        '
        'EnableDisableBulkToolStripMenuItem
        '
        Me.EnableDisableBulkToolStripMenuItem.Index = 1
        Me.EnableDisableBulkToolStripMenuItem.Text = "Enable/Disable"
        '
        'MoveBulkToolStripMenuItem
        '
        Me.MoveBulkToolStripMenuItem.Index = 2
        Me.MoveBulkToolStripMenuItem.Text = "Move..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Index = 3
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CopyToClipBoardToolStripMenuItem
        '
        Me.CopyToClipBoardToolStripMenuItem.Index = 0
        Me.CopyToClipBoardToolStripMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyNameToolStripMenuItem, Me.CopyDNToolStripMenuItem, Me.CopySamToolStripMenuItem})
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
        'SingleContextMenu
        '
        Me.SingleContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyToClipBoardToolStripMenuItem, Me.EnableDisableSingleToolStripMenuItem, Me.MoveSingleToolStripMenuItem, Me.DeleteSingleToolStripMenuItem, Me.PropertiesToolStripMenuItem})
        '
        'EnableDisableSingleToolStripMenuItem
        '
        Me.EnableDisableSingleToolStripMenuItem.Index = 1
        Me.EnableDisableSingleToolStripMenuItem.Text = "Enable/Disable"
        '
        'MoveSingleToolStripMenuItem
        '
        Me.MoveSingleToolStripMenuItem.Index = 2
        Me.MoveSingleToolStripMenuItem.Text = "Move..."
        '
        'DeleteSingleToolStripMenuItem
        '
        Me.DeleteSingleToolStripMenuItem.Index = 3
        Me.DeleteSingleToolStripMenuItem.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Index = 4
        Me.PropertiesToolStripMenuItem.Text = "Properties..."
        '
        'SpacerPanel
        '
        Me.SpacerPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SpacerPanel.Controls.Add(Me.SearchBoxTb)
        Me.SpacerPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SpacerPanel.Location = New System.Drawing.Point(0, 408)
        Me.SpacerPanel.MaximumSize = New System.Drawing.Size(10000, 36)
        Me.SpacerPanel.Name = "SpacerPanel"
        Me.SpacerPanel.Padding = New System.Windows.Forms.Padding(12, 12, 48, 6)
        Me.SpacerPanel.Size = New System.Drawing.Size(823, 36)
        Me.SpacerPanel.TabIndex = 4
        '
        'SearchBoxTb
        '
        Me.SearchBoxTb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.SearchBoxTb.CustomButton.Image = Nothing
        Me.SearchBoxTb.CustomButton.Location = New System.Drawing.Point(247, 2)
        Me.SearchBoxTb.CustomButton.Name = ""
        Me.SearchBoxTb.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.SearchBoxTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchBoxTb.CustomButton.TabIndex = 1
        Me.SearchBoxTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchBoxTb.CustomButton.UseSelectable = True
        Me.SearchBoxTb.CustomButton.Visible = False
        Me.SearchBoxTb.DisplayIcon = True
        Me.SearchBoxTb.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.SearchBoxTb.Lines = New String(-1) {}
        Me.SearchBoxTb.Location = New System.Drawing.Point(6, 6)
        Me.SearchBoxTb.MaxLength = 32767
        Me.SearchBoxTb.Name = "SearchBoxTb"
        Me.SearchBoxTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBoxTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBoxTb.SelectedText = ""
        Me.SearchBoxTb.SelectionLength = 0
        Me.SearchBoxTb.SelectionStart = 0
        Me.SearchBoxTb.ShortcutsEnabled = True
        Me.SearchBoxTb.ShowClearButton = True
        Me.SearchBoxTb.Size = New System.Drawing.Size(269, 24)
        Me.SearchBoxTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SearchBoxTb.TabIndex = 3
        Me.SearchBoxTb.UseCustomBackColor = True
        Me.SearchBoxTb.UseSelectable = True
        Me.SearchBoxTb.WaterMark = "Filter..."
        Me.SearchBoxTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBoxTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.AllColumns.Add(Me.NameColumn)
        Me.MainListView.AllColumns.Add(Me.TypeColumn)
        Me.MainListView.AllColumns.Add(Me.DescColumn)
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.DescColumn})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.EmptyListMsg = "No Results"
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
        Me.MainListView.Size = New System.Drawing.Size(602, 408)
        Me.MainListView.TabIndex = 1
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseExplorerTheme = True
        Me.MainListView.UseFiltering = True
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
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 137
        '
        'DescColumn
        '
        Me.DescColumn.AspectName = "Description"
        Me.DescColumn.Text = "Description"
        Me.DescColumn.Width = 253
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
        Me.DomainTreeView.ItemHeight = 22
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        Me.DomainTreeView.SelectedOU = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(220, 408)
        Me.DomainTreeView.TabIndex = 2
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.DomainTreeView)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer.Size = New System.Drawing.Size(823, 408)
        Me.MainSplitContainer.SplitterDistance = 220
        Me.MainSplitContainer.SplitterWidth = 1
        Me.MainSplitContainer.TabIndex = 5
        '
        'ContainerUserReport
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.SpacerPanel)
        Me.Name = "ContainerUserReport"
        Me.Size = New System.Drawing.Size(823, 444)
        Me.ListViewContextMenu.ResumeLayout(False)
        Me.SpacerPanel.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BulkContextMenu As ContextMenu
    Friend WithEvents BulkModifyToolStripMenuItem As MenuItem
    Friend WithEvents EnableDisableBulkToolStripMenuItem As MenuItem
    Friend WithEvents MoveBulkToolStripMenuItem As MenuItem
    Friend WithEvents CopyToClipBoardToolStripMenuItem As MenuItem
    Friend WithEvents CopyDNToolStripMenuItem As MenuItem
    Friend WithEvents CopySamToolStripMenuItem As MenuItem
    Friend WithEvents CopyNameToolStripMenuItem As MenuItem
    Friend WithEvents DeleteToolStripMenuItem As MenuItem
    Friend WithEvents SingleContextMenu As ContextMenu
    Friend WithEvents EnableDisableSingleToolStripMenuItem As MenuItem
    Friend WithEvents MoveSingleToolStripMenuItem As MenuItem
    Friend WithEvents DeleteSingleToolStripMenuItem As MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As MenuItem
    Friend WithEvents SpacerPanel As Panel
    Friend WithEvents SearchBoxTb As Controls.MetroTextBox
    Friend WithEvents ListViewContextMenu As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameColumn As OLVColumn
    Friend WithEvents TypeColumn As OLVColumn
    Friend WithEvents DescColumn As OLVColumn
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents MainSplitContainer As SplitContainer
End Class