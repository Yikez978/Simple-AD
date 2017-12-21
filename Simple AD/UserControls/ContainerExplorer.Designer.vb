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
        Me.MainSplitContainer = New SimpleAD.ControlSplitConatiner()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.MainListView = New SimpleAD.ControlListView()
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
        Me.RowObjectContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyToClipBoardToolStripMenuItem, Me.RenameMenuItem, Me.ResetSingleToolStripMenuItem, Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem, Me.MoveSingleToolStripMenuItem, Me.DeleteSingleToolStripMenuItem, Me.BulkModifyToolStripMenuItem, Me.ResetBulkToolStripMenuItem, Me.EnableBulkToolStripMenuItem, Me.DisableBulkToolStripMenuItem, Me.MoveBulkToolStripMenuItem, Me.DeleteBulkToolStripMenuItem, Me.PropertiesToolStripMenuItem})
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
        Me.MainSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.MainSplitContainer.Panel1.Controls.Add(Me.DomainTreeView)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer.Size = New System.Drawing.Size(823, 402)
        Me.MainSplitContainer.SpliterHeight = 0
        Me.MainSplitContainer.SplitterDistance = 264
        Me.MainSplitContainer.SplitterWidth = 12
        Me.MainSplitContainer.TabIndex = 5
        '
        'DomainTreeView
        '
        Me.DomainTreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
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
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedOU = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(264, 402)
        Me.DomainTreeView.TabIndex = 2
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.EmptyListMsgFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HeaderFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.HeaderMinimumHeight = 32
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(0, 0)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.RowHeight = 21
        Me.MainListView.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainListView.SelectedForeColor = System.Drawing.SystemColors.ControlText
        Me.MainListView.ShowCommandMenuOnRightClick = True
        Me.MainListView.ShowHeaderInAllViews = False
        Me.MainListView.Size = New System.Drawing.Size(547, 402)
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
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents RenameMenuItem As MenuItem
    Friend WithEvents EnableBulkToolStripMenuItem As MenuItem
    Friend WithEvents DisableBulkToolStripMenuItem As MenuItem
    Friend WithEvents DisableToolStripMenuItem As MenuItem
End Class