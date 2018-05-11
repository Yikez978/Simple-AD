Imports System.Windows.Forms
Imports BrightIdeasSoftware

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormObjectAttributes
    Inherits Form

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObjectAttributes))
        Me.TypeCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImagePl = New System.Windows.Forms.Panel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.ContentPl = New System.Windows.Forms.Panel()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.AttrTab = New System.Windows.Forms.TabPage()
        Me.AttrPanel = New System.Windows.Forms.Panel()
        Me.MainListView = New SimpleAD.ControlCustomListView()
        Me.NameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ValueCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DropDownFilter = New System.Windows.Forms.ComboBox()
        Me.SearchBoxTb = New SimpleAD.ControlTextBox()
        Me.ImagePl.SuspendLayout()
        Me.ContentPl.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.AttrTab.SuspendLayout()
        Me.AttrPanel.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypeCol
        '
        Me.TypeCol.AspectName = "Type"
        Me.TypeCol.DisplayIndex = 1
        Me.TypeCol.IsVisible = False
        Me.TypeCol.Text = "Type"
        Me.TypeCol.Width = 100
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
        Me.ImagePl.Size = New System.Drawing.Size(609, 56)
        Me.ImagePl.TabIndex = 8
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(49, 30)
        Me.TitleLb.TabIndex = 0
        Me.TitleLb.Text = "Title"
        '
        'ContentPl
        '
        Me.ContentPl.BackColor = System.Drawing.SystemColors.Control
        Me.ContentPl.Controls.Add(Me.MainTabControl)
        Me.ContentPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPl.Location = New System.Drawing.Point(0, 56)
        Me.ContentPl.Name = "ContentPl"
        Me.ContentPl.Padding = New System.Windows.Forms.Padding(8)
        Me.ContentPl.Size = New System.Drawing.Size(609, 433)
        Me.ContentPl.TabIndex = 4
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.AttrTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.Location = New System.Drawing.Point(8, 8)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(593, 417)
        Me.MainTabControl.TabIndex = 0
        '
        'AttrTab
        '
        Me.AttrTab.BackColor = System.Drawing.SystemColors.Window
        Me.AttrTab.Controls.Add(Me.AttrPanel)
        Me.AttrTab.Location = New System.Drawing.Point(4, 22)
        Me.AttrTab.Margin = New System.Windows.Forms.Padding(0)
        Me.AttrTab.Name = "AttrTab"
        Me.AttrTab.Size = New System.Drawing.Size(585, 391)
        Me.AttrTab.TabIndex = 0
        Me.AttrTab.Text = "  Attributes  "
        '
        'AttrPanel
        '
        Me.AttrPanel.BackColor = System.Drawing.SystemColors.Window
        Me.AttrPanel.Controls.Add(Me.MainListView)
        Me.AttrPanel.Controls.Add(Me.DropDownFilter)
        Me.AttrPanel.Controls.Add(Me.SearchBoxTb)
        Me.AttrPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AttrPanel.Location = New System.Drawing.Point(0, 0)
        Me.AttrPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.AttrPanel.Name = "AttrPanel"
        Me.AttrPanel.Padding = New System.Windows.Forms.Padding(8)
        Me.AttrPanel.Size = New System.Drawing.Size(585, 391)
        Me.AttrPanel.TabIndex = 4
        Me.AttrPanel.Tag = "Property Inspector"
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.AllColumns.Add(Me.NameCol)
        Me.MainListView.AllColumns.Add(Me.TypeCol)
        Me.MainListView.AllColumns.Add(Me.ValueCol)
        Me.MainListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameCol, Me.ValueCol})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.EmptyListMsg = ""
        Me.MainListView.EmptyListMsgFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HeaderUsesThemes = True
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(12, 43)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.OwnerDraw = False
        Me.MainListView.RowHeight = 21
        Me.MainListView.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainListView.SelectedForeColor = System.Drawing.SystemColors.ControlText
        Me.MainListView.ShowFilterMenuOnRightClick = False
        Me.MainListView.ShowGroups = False
        Me.MainListView.Size = New System.Drawing.Size(561, 337)
        Me.MainListView.TabIndex = 7
        Me.MainListView.UseCellFormatEvents = True
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseExplorerTheme = True
        Me.MainListView.UseFiltering = True
        Me.MainListView.UseHotControls = False
        Me.MainListView.UseOverlays = False
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'NameCol
        '
        Me.NameCol.AspectName = "Name"
        Me.NameCol.Hideable = False
        Me.NameCol.Text = "Attribute Name"
        Me.NameCol.Width = 200
        '
        'ValueCol
        '
        Me.ValueCol.AspectName = "Value"
        Me.ValueCol.CellEditUseWholeCell = True
        Me.ValueCol.FillsFreeSpace = True
        Me.ValueCol.Hideable = False
        Me.ValueCol.Sortable = False
        Me.ValueCol.Text = "Value"
        Me.ValueCol.WordWrap = True
        '
        'DropDownFilter
        '
        Me.DropDownFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropDownFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DropDownFilter.FormattingEnabled = True
        Me.DropDownFilter.ItemHeight = 13
        Me.DropDownFilter.Items.AddRange(New Object() {"All", "Only Attributes That Have Values"})
        Me.DropDownFilter.Location = New System.Drawing.Point(382, 12)
        Me.DropDownFilter.Name = "DropDownFilter"
        Me.DropDownFilter.Size = New System.Drawing.Size(191, 21)
        Me.DropDownFilter.TabIndex = 1
        '
        'SearchBoxTb
        '
        Me.SearchBoxTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBoxTb.BackColor = System.Drawing.SystemColors.Window
        Me.SearchBoxTb.Location = New System.Drawing.Point(12, 12)
        Me.SearchBoxTb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.SearchBoxTb.Name = "SearchBoxTb"
        Me.SearchBoxTb.PromptText = "Filter Attributes..."
        Me.SearchBoxTb.Size = New System.Drawing.Size(364, 22)
        Me.SearchBoxTb.TabIndex = 0
        '
        'FormObjectAttributes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(609, 489)
        Me.Controls.Add(Me.ContentPl)
        Me.Controls.Add(Me.ImagePl)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormObjectAttributes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUserAttributes"
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ContentPl.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.AttrTab.ResumeLayout(False)
        Me.AttrPanel.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TypeCol As OLVColumn
    Friend WithEvents ImagePl As Panel
    Friend WithEvents ContentPl As Panel
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents AttrTab As TabPage
    Friend WithEvents AttrPanel As Panel
    Friend WithEvents MainListView As ControlCustomListView
    Friend WithEvents NameCol As OLVColumn
    Friend WithEvents ValueCol As OLVColumn
    Friend WithEvents DropDownFilter As ComboBox
    Friend WithEvents SearchBoxTb As ControlTextBox
    Friend WithEvents TitleLb As Label
End Class
