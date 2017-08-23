<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerUserBulk
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
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Everything", 3, 3)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disabled Users", 4, 4)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Built In Views", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Everything", 3, 3)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disabled Users", 4, 4)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Built In Views", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Everything", 3, 3)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disabled Users", 4, 4)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Built In Views", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Everything", 3, 3)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disabled Users", 4, 4)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Built In Views", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Me.MainSplitContainer0 = New System.Windows.Forms.SplitContainer()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TypeColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescriptionColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ControlListView1 = New SimpleAD.ControlListView()
        Me.AcceptBt = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroProgressSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenu()
        Me.CopyValueToClipboardToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.InsertNewRow = New System.Windows.Forms.MenuItem()
        Me.DeleteRow = New System.Windows.Forms.MenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.MenuItem()
        CType(Me.MainSplitContainer0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer0.Panel1.SuspendLayout()
        Me.MainSplitContainer0.Panel2.SuspendLayout()
        Me.MainSplitContainer0.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSplitContainer0
        '
        Me.MainSplitContainer0.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.MainSplitContainer0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer0.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer0.Name = "MainSplitContainer0"
        '
        'MainSplitContainer0.Panel1
        '
        Me.MainSplitContainer0.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer0.Panel1.Controls.Add(Me.DomainTreeView)
        '
        'MainSplitContainer0.Panel2
        '
        Me.MainSplitContainer0.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer0.Panel2.Controls.Add(Me.ControlListView1)
        Me.MainSplitContainer0.Size = New System.Drawing.Size(878, 439)
        Me.MainSplitContainer0.SplitterDistance = 220
        Me.MainSplitContainer0.SplitterWidth = 1
        Me.MainSplitContainer0.TabIndex = 6
        '
        'DomainTreeView
        '
        Me.DomainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DomainTreeView.DomainController = Nothing
        Me.DomainTreeView.DomainName = Nothing
        Me.DomainTreeView.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTreeView.FullRowSelect = True
        Me.DomainTreeView.HideSelection = False
        Me.DomainTreeView.HotTracking = True
        Me.DomainTreeView.ImageIndex = 0
        Me.DomainTreeView.ItemHeight = 24
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        TreeNode13.ImageIndex = 3
        TreeNode13.Name = "EverythingNode"
        TreeNode13.SelectedImageIndex = 3
        TreeNode13.Text = "Everything"
        TreeNode14.ImageIndex = 4
        TreeNode14.Name = "DisabledUsersNode"
        TreeNode14.SelectedImageIndex = 4
        TreeNode14.Text = "Disabled Users"
        TreeNode15.ImageIndex = 2
        TreeNode15.Name = "BuiltInRoot"
        TreeNode15.SelectedImageIndex = 2
        TreeNode15.Text = "Built In Views"
        TreeNode16.ImageIndex = 3
        TreeNode16.Name = "EverythingNode"
        TreeNode16.SelectedImageIndex = 3
        TreeNode16.Text = "Everything"
        TreeNode17.ImageIndex = 4
        TreeNode17.Name = "DisabledUsersNode"
        TreeNode17.SelectedImageIndex = 4
        TreeNode17.Text = "Disabled Users"
        TreeNode18.ImageIndex = 2
        TreeNode18.Name = "BuiltInRoot"
        TreeNode18.SelectedImageIndex = 2
        TreeNode18.Text = "Built In Views"
        TreeNode19.ImageIndex = 3
        TreeNode19.Name = "EverythingNode"
        TreeNode19.SelectedImageIndex = 3
        TreeNode19.Text = "Everything"
        TreeNode20.ImageIndex = 4
        TreeNode20.Name = "DisabledUsersNode"
        TreeNode20.SelectedImageIndex = 4
        TreeNode20.Text = "Disabled Users"
        TreeNode21.ImageIndex = 2
        TreeNode21.Name = "BuiltInRoot"
        TreeNode21.SelectedImageIndex = 2
        TreeNode21.Text = "Built In Views"
        TreeNode22.ImageIndex = 3
        TreeNode22.Name = "EverythingNode"
        TreeNode22.SelectedImageIndex = 3
        TreeNode22.Text = "Everything"
        TreeNode23.ImageIndex = 4
        TreeNode23.Name = "DisabledUsersNode"
        TreeNode23.SelectedImageIndex = 4
        TreeNode23.Text = "Disabled Users"
        TreeNode24.ImageIndex = 2
        TreeNode24.Name = "BuiltInRoot"
        TreeNode24.SelectedImageIndex = 2
        TreeNode24.Text = "Built In Views"
        Me.DomainTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode18, TreeNode21, TreeNode24})
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedOU = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(220, 439)
        Me.DomainTreeView.TabIndex = 1
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.AllColumns.Add(Me.NameColumn)
        Me.MainListView.AllColumns.Add(Me.TypeColumn)
        Me.MainListView.AllColumns.Add(Me.DescriptionColumn)
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.DescriptionColumn})
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
        Me.MainListView.Size = New System.Drawing.Size(657, 439)
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
        '
        'TypeColumn
        '
        Me.TypeColumn.AspectName = "TypeFriendly"
        Me.TypeColumn.Text = "Type"
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.AspectName = "Description"
        Me.DescriptionColumn.Text = "Description"
        '
        'ControlListView1
        '
        Me.ControlListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ControlListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ControlListView1.CellEditUseWholeCell = False
        Me.ControlListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ControlListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlListView1.EmptyListMsg = "No Results"
        Me.ControlListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlListView1.FullRowSelect = True
        Me.ControlListView1.HeaderUsesThemes = True
        Me.ControlListView1.HideSelection = False
        Me.ControlListView1.IncludeColumnHeadersInCopy = True
        Me.ControlListView1.Location = New System.Drawing.Point(0, 0)
        Me.ControlListView1.Name = "ControlListView1"
        Me.ControlListView1.OwnerDraw = False
        Me.ControlListView1.RowHeight = 21
        Me.ControlListView1.ShowGroups = False
        Me.ControlListView1.Size = New System.Drawing.Size(657, 439)
        Me.ControlListView1.TabIndex = 1
        Me.ControlListView1.UseCompatibleStateImageBehavior = False
        Me.ControlListView1.UseExplorerTheme = True
        Me.ControlListView1.UseFiltering = True
        Me.ControlListView1.UseNotifyPropertyChanged = True
        Me.ControlListView1.View = System.Windows.Forms.View.Details
        '
        'AcceptBt
        '
        Me.AcceptBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBt.DisplayFocus = True
        Me.AcceptBt.Location = New System.Drawing.Point(756, 7)
        Me.AcceptBt.Name = "AcceptBt"
        Me.AcceptBt.Size = New System.Drawing.Size(119, 23)
        Me.AcceptBt.TabIndex = 7
        Me.AcceptBt.Text = "Create Users"
        Me.AcceptBt.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.Location = New System.Drawing.Point(675, 7)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 8
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(10, 10)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(394, 17)
        Me.ProgressBar.Style = MetroFramework.MetroColorStyle.Purple
        Me.ProgressBar.TabIndex = 9
        Me.ProgressBar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.MetroProgressSpinner)
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Controls.Add(Me.AcceptBt)
        Me.Panel1.Controls.Add(Me.CancelBn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 439)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 36)
        Me.Panel1.TabIndex = 10
        '
        'MetroProgressSpinner
        '
        Me.MetroProgressSpinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressSpinner.Location = New System.Drawing.Point(652, 11)
        Me.MetroProgressSpinner.Maximum = 100
        Me.MetroProgressSpinner.Name = "MetroProgressSpinner"
        Me.MetroProgressSpinner.Size = New System.Drawing.Size(16, 16)
        Me.MetroProgressSpinner.Speed = 4.0!
        Me.MetroProgressSpinner.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroProgressSpinner.TabIndex = 10
        Me.MetroProgressSpinner.UseCustomBackColor = True
        Me.MetroProgressSpinner.UseSelectable = True
        Me.MetroProgressSpinner.Value = 30
        Me.MetroProgressSpinner.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyValueToClipboardToolStripMenuItem, Me.InsertNewRow, Me.DeleteRow, Me.PropertiesToolStripMenuItem})
        '
        'CopyValueToClipboardToolStripMenuItem
        '
        Me.CopyValueToClipboardToolStripMenuItem.Index = 0
        Me.CopyValueToClipboardToolStripMenuItem.Text = "&Copy"
        '
        'InsertNewRow
        '
        Me.InsertNewRow.Index = 1
        Me.InsertNewRow.Text = "Insert &New User"
        '
        'DeleteRow
        '
        Me.DeleteRow.Index = 2
        Me.DeleteRow.Text = "&Delete Selected User(s)"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Index = 3
        Me.PropertiesToolStripMenuItem.Text = "&Properties..."
        '
        'ContainerUserBulk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainSplitContainer0)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ContainerUserBulk"
        Me.Size = New System.Drawing.Size(878, 475)
        Me.MainSplitContainer0.Panel1.ResumeLayout(False)
        Me.MainSplitContainer0.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer0.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainSplitContainer0 As SplitContainer
    Friend WithEvents CancelBn As MetroFramework.Controls.MetroButton
    Friend WithEvents ProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents AcceptBt As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroProgressSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents CMStripRowRClick As ContextMenu
    Friend WithEvents CopyValueToClipboardToolStripMenuItem As MenuItem
    Friend WithEvents InsertNewRow As MenuItem
    Friend WithEvents DeleteRow As MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As MenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenu
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents ControlListView1 As ControlListView
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameColumn As OLVColumn
    Friend WithEvents DescriptionColumn As OLVColumn
    Friend WithEvents TypeColumn As OLVColumn
End Class
