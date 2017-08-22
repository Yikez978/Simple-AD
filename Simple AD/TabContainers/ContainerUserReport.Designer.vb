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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.DirectoryHeaderPl = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.SingleContextMenu = New System.Windows.Forms.ContextMenu()
        Me.EnableDisableSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.MoveSingleToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.MenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.SpacerPanel = New System.Windows.Forms.Panel()
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TypeColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.DirectoryHeaderPl.SuspendLayout()
        Me.ListViewContextMenu.SuspendLayout()
        Me.SpacerPanel.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainDataGrid
        '
        Me.MainDataGrid.AllowUserToAddRows = False
        Me.MainDataGrid.AllowUserToDeleteRows = False
        Me.MainDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.MainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.MainDataGrid.ColumnHeadersHeight = 28
        Me.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.DefaultCellStyle = DataGridViewCellStyle18
        Me.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGrid.EnableHeadersVisualStyles = False
        Me.MainDataGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.HighLightPercentage = 0.8!
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.MainDataGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.MainDataGrid.Name = "MainDataGrid"
        Me.MainDataGrid.ReadOnly = True
        Me.MainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.MainDataGrid.RowHeadersVisible = False
        Me.MainDataGrid.RowHeadersWidth = 44
        Me.MainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MainDataGrid.RowTemplate.Height = 20
        Me.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainDataGrid.ShowEditingIcon = False
        Me.MainDataGrid.Size = New System.Drawing.Size(402, 271)
        Me.MainDataGrid.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainDataGrid.TabIndex = 0
        Me.MainDataGrid.UseCustomBackColor = True
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
        Me.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer.Panel1.Controls.Add(Me.DomainTreeView)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.DirectoryHeaderPl)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainDataGrid)
        Me.MainSplitContainer.Size = New System.Drawing.Size(536, 271)
        Me.MainSplitContainer.SplitterDistance = 133
        Me.MainSplitContainer.SplitterWidth = 1
        Me.MainSplitContainer.TabIndex = 3
        '
        'DirectoryHeaderPl
        '
        Me.DirectoryHeaderPl.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DirectoryHeaderPl.Controls.Add(Me.Label1)
        Me.DirectoryHeaderPl.Dock = System.Windows.Forms.DockStyle.Top
        Me.DirectoryHeaderPl.Location = New System.Drawing.Point(0, 0)
        Me.DirectoryHeaderPl.MaximumSize = New System.Drawing.Size(0, 28)
        Me.DirectoryHeaderPl.MinimumSize = New System.Drawing.Size(0, 28)
        Me.DirectoryHeaderPl.Name = "DirectoryHeaderPl"
        Me.DirectoryHeaderPl.Size = New System.Drawing.Size(133, 28)
        Me.DirectoryHeaderPl.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directory"
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
        'SingleContextMenu
        '
        Me.SingleContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.EnableDisableSingleToolStripMenuItem, Me.MoveSingleToolStripMenuItem, Me.ToolStripMenuItem4, Me.PropertiesToolStripMenuItem})
        '
        'EnableDisableSingleToolStripMenuItem
        '
        Me.EnableDisableSingleToolStripMenuItem.Index = 0
        Me.EnableDisableSingleToolStripMenuItem.Text = "Enable/Disable"
        '
        'MoveSingleToolStripMenuItem
        '
        Me.MoveSingleToolStripMenuItem.Index = 1
        Me.MoveSingleToolStripMenuItem.Text = "Move..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Index = 2
        Me.ToolStripMenuItem4.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Index = 3
        Me.PropertiesToolStripMenuItem.Text = "Properties..."
        '
        'SpacerPanel
        '
        Me.SpacerPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SpacerPanel.Controls.Add(Me.SearchBoxTb)
        Me.SpacerPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SpacerPanel.Location = New System.Drawing.Point(0, 271)
        Me.SpacerPanel.MaximumSize = New System.Drawing.Size(10000, 36)
        Me.SpacerPanel.Name = "SpacerPanel"
        Me.SpacerPanel.Padding = New System.Windows.Forms.Padding(12, 12, 48, 6)
        Me.SpacerPanel.Size = New System.Drawing.Size(536, 36)
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
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 28)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedOU = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(133, 243)
        Me.DomainTreeView.TabIndex = 2
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
        Me.MainListView.RowHeight = 21
        Me.MainListView.ShowGroups = False
        Me.MainListView.Size = New System.Drawing.Size(402, 271)
        Me.MainListView.TabIndex = 1
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseExplorerTheme = True
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.AspectName = "Name"
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 117
        '
        'TypeColumn
        '
        Me.TypeColumn.AspectName = "Type"
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 116
        '
        'DescColumn
        '
        Me.DescColumn.AspectName = "Description"
        Me.DescColumn.Text = "Description"
        Me.DescColumn.Width = 125
        '
        'ContainerUserReport
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.SpacerPanel)
        Me.DoubleBuffered = True
        Me.Name = "ContainerUserReport"
        Me.Size = New System.Drawing.Size(536, 307)
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.DirectoryHeaderPl.ResumeLayout(False)
        Me.DirectoryHeaderPl.PerformLayout()
        Me.ListViewContextMenu.ResumeLayout(False)
        Me.SpacerPanel.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainDataGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents BulkContextMenu As ContextMenu
    Friend WithEvents BulkModifyToolStripMenuItem As MenuItem
    Friend WithEvents EnableDisableBulkToolStripMenuItem As MenuItem
    Friend WithEvents MoveBulkToolStripMenuItem As MenuItem
    Friend WithEvents DeleteToolStripMenuItem As MenuItem
    Friend WithEvents SingleContextMenu As ContextMenu
    Friend WithEvents EnableDisableSingleToolStripMenuItem As MenuItem
    Friend WithEvents MoveSingleToolStripMenuItem As MenuItem
    Friend WithEvents ToolStripMenuItem4 As MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As MenuItem
    Friend WithEvents DirectoryHeaderPl As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SpacerPanel As Panel
    Friend WithEvents SearchBoxTb As Controls.MetroTextBox
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents ListViewContextMenu As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameColumn As BrightIdeasSoftware.OLVColumn
    Friend WithEvents TypeColumn As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DescColumn As BrightIdeasSoftware.OLVColumn
End Class