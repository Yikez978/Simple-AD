<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearch))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.RowObjectContextMenu = New System.Windows.Forms.ContextMenu()
        Me.CopyToClipBoardToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopyDNToolStripMenuItem = New System.Windows.Forms.MenuItem()
        Me.CopySamToolStripMenuItem = New System.Windows.Forms.MenuItem()
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
        Me.ContentPl = New System.Windows.Forms.Panel()
        Me.ListPl = New System.Windows.Forms.Panel()
        Me.SearchResultsListView = New SimpleAD.ControlDomainListView()
        Me.NameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TypeCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.SearchPanel = New System.Windows.Forms.Panel()
        Me.SearchBn = New System.Windows.Forms.Button()
        Me.SearchTb = New SimpleAD.ControlTextBox()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.ContentPl.SuspendLayout()
        Me.ListPl.SuspendLayout()
        CType(Me.SearchResultsListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchPanel.SuspendLayout()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'RowObjectContextMenu
        '
        Me.RowObjectContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyToClipBoardToolStripMenuItem, Me.Seperator1, Me.RenameMenuItem, Me.MoveSingleToolStripMenuItem, Me.DeleteSingleToolStripMenuItem, Me.Seperator2, Me.PingMachineToolStripMenuItem, Me.ResetSingleToolStripMenuItem, Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem, Me.BulkModifyToolStripMenuItem, Me.ResetBulkToolStripMenuItem, Me.EnableBulkToolStripMenuItem, Me.DisableBulkToolStripMenuItem, Me.MoveBulkToolStripMenuItem, Me.DeleteBulkToolStripMenuItem, Me.Seperator3, Me.PropertiesToolStripMenuItem})
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
        'ContentPl
        '
        Me.ContentPl.BackColor = System.Drawing.SystemColors.Control
        Me.ContentPl.Controls.Add(Me.ListPl)
        Me.ContentPl.Controls.Add(Me.SearchPanel)
        Me.ContentPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPl.Location = New System.Drawing.Point(0, 56)
        Me.ContentPl.Name = "ContentPl"
        Me.ContentPl.Size = New System.Drawing.Size(599, 351)
        Me.ContentPl.TabIndex = 0
        '
        'ListPl
        '
        Me.ListPl.Controls.Add(Me.SearchResultsListView)
        Me.ListPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPl.Location = New System.Drawing.Point(0, 44)
        Me.ListPl.Name = "ListPl"
        Me.ListPl.Padding = New System.Windows.Forms.Padding(12)
        Me.ListPl.Size = New System.Drawing.Size(599, 307)
        Me.ListPl.TabIndex = 4
        '
        'SearchResultsListView
        '
        Me.SearchResultsListView.AllColumns.Add(Me.NameCol)
        Me.SearchResultsListView.AllColumns.Add(Me.TypeCol)
        Me.SearchResultsListView.AllColumns.Add(Me.DescCol)
        Me.SearchResultsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchResultsListView.CellEditUseWholeCell = False
        Me.SearchResultsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameCol, Me.TypeCol, Me.DescCol})
        Me.SearchResultsListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.SearchResultsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchResultsListView.Location = New System.Drawing.Point(12, 12)
        Me.SearchResultsListView.Name = "SearchResultsListView"
        Me.SearchResultsListView.OffRowContextMenu = Nothing
        Me.SearchResultsListView.RowContextMenu = Nothing
        Me.SearchResultsListView.ShowGroups = False
        Me.SearchResultsListView.Size = New System.Drawing.Size(575, 283)
        Me.SearchResultsListView.TabIndex = 3
        Me.SearchResultsListView.UseCompatibleStateImageBehavior = False
        Me.SearchResultsListView.View = System.Windows.Forms.View.Details
        '
        'NameCol
        '
        Me.NameCol.AspectName = "Name"
        Me.NameCol.Text = "Name"
        Me.NameCol.Width = 190
        '
        'TypeCol
        '
        Me.TypeCol.AspectName = "TypeFriendly"
        Me.TypeCol.Text = "Type"
        Me.TypeCol.Width = 108
        '
        'DescCol
        '
        Me.DescCol.AspectName = "Description"
        Me.DescCol.Text = "Description"
        Me.DescCol.Width = 199
        '
        'SearchPanel
        '
        Me.SearchPanel.Controls.Add(Me.SearchBn)
        Me.SearchPanel.Controls.Add(Me.SearchTb)
        Me.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchPanel.MinimumSize = New System.Drawing.Size(0, 44)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(599, 44)
        Me.SearchPanel.TabIndex = 3
        '
        'SearchBn
        '
        Me.SearchBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBn.Location = New System.Drawing.Point(512, 11)
        Me.SearchBn.Name = "SearchBn"
        Me.SearchBn.Size = New System.Drawing.Size(75, 23)
        Me.SearchBn.TabIndex = 2
        Me.SearchBn.Text = "Search"
        Me.SearchBn.UseVisualStyleBackColor = True
        '
        'SearchTb
        '
        Me.SearchTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTb.Location = New System.Drawing.Point(12, 12)
        Me.SearchTb.MinimumSize = New System.Drawing.Size(0, 22)
        Me.SearchTb.Name = "SearchTb"
        Me.SearchTb.PromptText = "Enter Search Query"
        Me.SearchTb.Size = New System.Drawing.Size(494, 22)
        Me.SearchTb.TabIndex = 0
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Window
        Me.ImagePl.Controls.Add(Me.TitleLb)
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(599, 56)
        Me.ImagePl.TabIndex = 31
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(157, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Search Directory"
        '
        'FormSearch
        '
        Me.AcceptButton = Me.SearchBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(599, 407)
        Me.Controls.Add(Me.ContentPl)
        Me.Controls.Add(Me.ImagePl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.MinimizeBox = False
        Me.Name = "FormSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple AD - Search"
        Me.ContentPl.ResumeLayout(False)
        Me.ListPl.ResumeLayout(False)
        CType(Me.SearchResultsListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchPanel.ResumeLayout(False)
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainMenu As Windows.Forms.MainMenu
    Friend WithEvents RowObjectContextMenu As Windows.Forms.ContextMenu
    Friend WithEvents CopyToClipBoardToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents CopyNameToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents CopyDNToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents CopySamToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents Seperator1 As Windows.Forms.MenuItem
    Friend WithEvents RenameMenuItem As Windows.Forms.MenuItem
    Friend WithEvents MoveSingleToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents DeleteSingleToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents Seperator2 As Windows.Forms.MenuItem
    Friend WithEvents ResetSingleToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents EnableToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents DisableToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents BulkModifyToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents ResetBulkToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents EnableBulkToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents DisableBulkToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents MoveBulkToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents DeleteBulkToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents Seperator3 As Windows.Forms.MenuItem
    Friend WithEvents PropertiesToolStripMenuItem As Windows.Forms.MenuItem
    Friend WithEvents ContentPl As Windows.Forms.Panel
    Friend WithEvents ListPl As Windows.Forms.Panel
    Friend WithEvents SearchResultsListView As ControlDomainListView
    Friend WithEvents NameCol As OLVColumn
    Friend WithEvents TypeCol As OLVColumn
    Friend WithEvents DescCol As OLVColumn
    Friend WithEvents SearchPanel As Windows.Forms.Panel
    Friend WithEvents SearchBn As Windows.Forms.Button
    Friend WithEvents SearchTb As ControlTextBox
    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Windows.Forms.Label
    Friend WithEvents PingMachineToolStripMenuItem As Windows.Forms.MenuItem
End Class
