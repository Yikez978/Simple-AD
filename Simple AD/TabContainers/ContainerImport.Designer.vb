<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerImport
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
        Me.MainSplitContainer0 = New SimpleAD.ControlSplitConatiner()
        Me.MainTreeView = New SimpleAD.ControlTreeView()
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TypeColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescriptionColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.StatusColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.FooterPl = New SimpleAD.ControlFooterPl()
        Me.MetroProgressSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.AcceptBt = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ImportBn = New SimpleAD.ControlFlatButton()
        CType(Me.MainSplitContainer0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer0.Panel1.SuspendLayout()
        Me.MainSplitContainer0.Panel2.SuspendLayout()
        Me.MainSplitContainer0.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSplitContainer0
        '
        Me.MainSplitContainer0.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer0.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer0.Margin = New System.Windows.Forms.Padding(0)
        Me.MainSplitContainer0.Name = "MainSplitContainer0"
        '
        'MainSplitContainer0.Panel1
        '
        Me.MainSplitContainer0.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer0.Panel1.Controls.Add(Me.MainTreeView)
        Me.MainSplitContainer0.Panel1.Padding = New System.Windows.Forms.Padding(0, 24, 0, 0)
        '
        'MainSplitContainer0.Panel2
        '
        Me.MainSplitContainer0.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer0.Size = New System.Drawing.Size(878, 439)
        Me.MainSplitContainer0.SplitterDistance = 220
        Me.MainSplitContainer0.SplitterWidth = 1
        Me.MainSplitContainer0.TabIndex = 6
        '
        'MainTreeView
        '
        Me.MainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTreeView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTreeView.FullRowSelect = True
        Me.MainTreeView.HideSelection = False
        Me.MainTreeView.HotTracking = True
        Me.MainTreeView.ItemHeight = 22
        Me.MainTreeView.Location = New System.Drawing.Point(0, 24)
        Me.MainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTreeView.Name = "MainTreeView"
        Me.MainTreeView.ShowLines = False
        Me.MainTreeView.Size = New System.Drawing.Size(220, 415)
        Me.MainTreeView.TabIndex = 0
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.AllColumns.Add(Me.NameColumn)
        Me.MainListView.AllColumns.Add(Me.TypeColumn)
        Me.MainListView.AllColumns.Add(Me.DescriptionColumn)
        Me.MainListView.AllColumns.Add(Me.StatusColumn)
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.DescriptionColumn, Me.StatusColumn})
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
        Me.MainListView.ShowItemToolTips = True
        Me.MainListView.Size = New System.Drawing.Size(657, 439)
        Me.MainListView.TabIndex = 1
        Me.MainListView.TileSize = New System.Drawing.Size(32, 32)
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
        Me.NameColumn.Width = 218
        '
        'TypeColumn
        '
        Me.TypeColumn.AspectName = "TypeFriendly"
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 125
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.AspectName = "Description"
        Me.DescriptionColumn.Text = "Description"
        Me.DescriptionColumn.Width = 183
        '
        'StatusColumn
        '
        Me.StatusColumn.AspectName = "Status"
        Me.StatusColumn.Text = "Status"
        Me.StatusColumn.Width = 99
        '
        'FooterPl
        '
        Me.FooterPl.BackColor = System.Drawing.SystemColors.Window
        Me.FooterPl.Controls.Add(Me.MetroProgressSpinner)
        Me.FooterPl.Controls.Add(Me.ProgressBar)
        Me.FooterPl.Controls.Add(Me.AcceptBt)
        Me.FooterPl.Controls.Add(Me.CancelBn)
        Me.FooterPl.Controls.Add(Me.ImportBn)
        Me.FooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPl.Location = New System.Drawing.Point(0, 439)
        Me.FooterPl.MaximumSize = New System.Drawing.Size(0, 36)
        Me.FooterPl.MinimumSize = New System.Drawing.Size(0, 36)
        Me.FooterPl.Name = "FooterPl"
        Me.FooterPl.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.FooterPl.Size = New System.Drawing.Size(878, 36)
        Me.FooterPl.TabIndex = 10
        '
        'MetroProgressSpinner
        '
        Me.MetroProgressSpinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressSpinner.Location = New System.Drawing.Point(645, 10)
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
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(221, 6)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(394, 21)
        Me.ProgressBar.Style = MetroFramework.MetroColorStyle.Purple
        Me.ProgressBar.TabIndex = 9
        Me.ProgressBar.Visible = False
        '
        'AcceptBt
        '
        Me.AcceptBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBt.DisplayFocus = True
        Me.AcceptBt.Location = New System.Drawing.Point(749, 6)
        Me.AcceptBt.Name = "AcceptBt"
        Me.AcceptBt.Size = New System.Drawing.Size(119, 23)
        Me.AcceptBt.TabIndex = 7
        Me.AcceptBt.Text = "Create Users"
        Me.AcceptBt.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.Location = New System.Drawing.Point(668, 6)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 8
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'ImportBn
        '
        Me.ImportBn.DefaultBackColor = System.Drawing.SystemColors.Window
        Me.ImportBn.DefaultForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ImportBn.Dock = System.Windows.Forms.DockStyle.Left
        Me.ImportBn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportBn.HoverColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ImportBn.Location = New System.Drawing.Point(0, 1)
        Me.ImportBn.Margin = New System.Windows.Forms.Padding(0)
        Me.ImportBn.Name = "ImportBn"
        Me.ImportBn.OnClickColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ImportBn.Size = New System.Drawing.Size(127, 35)
        Me.ImportBn.TabIndex = 1
        Me.ImportBn.Text = "Import CSV"
        '
        'ContainerImport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainSplitContainer0)
        Me.Controls.Add(Me.FooterPl)
        Me.Name = "ContainerImport"
        Me.Size = New System.Drawing.Size(878, 475)
        Me.MainSplitContainer0.Panel1.ResumeLayout(False)
        Me.MainSplitContainer0.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer0.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainSplitContainer0 As SimpleAD.ControlSplitConatiner
    Friend WithEvents CancelBn As MetroFramework.Controls.MetroButton
    Friend WithEvents ProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents AcceptBt As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroProgressSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents CMStripRowRClick As ContextMenu
    Friend WithEvents FooterPl As ControlFooterPl
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameColumn As OLVColumn
    Friend WithEvents DescriptionColumn As OLVColumn
    Friend WithEvents TypeColumn As OLVColumn
    Friend WithEvents MainTreeView As ControlTreeView
    Friend WithEvents StatusColumn As OLVColumn
    Friend WithEvents ImportBn As ControlFlatButton
End Class
