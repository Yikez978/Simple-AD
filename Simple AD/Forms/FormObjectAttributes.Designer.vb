<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObjectAttributes
    Inherits SimpleAD.FormSimpleAD

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObjectAttributes))
        Me.TypeCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MainTabControl = New SimpleAD.CustomTabControl()
        Me.AttrTab = New System.Windows.Forms.TabPage()
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ValueCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.AttrTopPanel = New SimpleAD.ControlHeaderPanel()
        Me.DropDownFilter = New MetroFramework.Controls.MetroComboBox()
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        Me.MainTabControl.SuspendLayout()
        Me.AttrTab.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttrTopPanel.SuspendLayout()
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
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.AttrTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainTabControl.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.HotTrackTabColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.MainTabControl.ItemSize = New System.Drawing.Size(0, 32)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 8)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTabControl.Multiline = True
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.Padding = New System.Drawing.Point(48, 0)
        Me.MainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(549, 387)
        Me.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MainTabControl.TabColor = System.Drawing.SystemColors.Window
        Me.MainTabControl.TabIndex = 0
        '
        'AttrTab
        '
        Me.AttrTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.AttrTab.Controls.Add(Me.MainListView)
        Me.AttrTab.Controls.Add(Me.AttrTopPanel)
        Me.AttrTab.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.AttrTab.Location = New System.Drawing.Point(0, 35)
        Me.AttrTab.Margin = New System.Windows.Forms.Padding(0)
        Me.AttrTab.Name = "AttrTab"
        Me.AttrTab.Size = New System.Drawing.Size(549, 352)
        Me.AttrTab.TabIndex = 0
        Me.AttrTab.Text = "Attributes"
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.MainListView.AllColumns.Add(Me.NameCol)
        Me.MainListView.AllColumns.Add(Me.TypeCol)
        Me.MainListView.AllColumns.Add(Me.ValueCol)
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameCol, Me.ValueCol})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.EmptyListMsg = ""
        Me.MainListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HeaderUsesThemes = True
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(0, 46)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.OwnerDraw = False
        Me.MainListView.RowHeight = 21
        Me.MainListView.ShowGroups = False
        Me.MainListView.Size = New System.Drawing.Size(549, 306)
        Me.MainListView.TabIndex = 5
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseExplorerTheme = True
        Me.MainListView.UseFiltering = True
        Me.MainListView.UseHotControls = False
        Me.MainListView.UseNotifyPropertyChanged = True
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
        Me.ValueCol.Text = "Value"
        Me.ValueCol.WordWrap = True
        '
        'AttrTopPanel
        '
        Me.AttrTopPanel.BackColor = System.Drawing.SystemColors.Window
        Me.AttrTopPanel.Controls.Add(Me.DropDownFilter)
        Me.AttrTopPanel.Controls.Add(Me.SearchBoxTb)
        Me.AttrTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AttrTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.AttrTopPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.AttrTopPanel.Name = "AttrTopPanel"
        Me.AttrTopPanel.Size = New System.Drawing.Size(549, 46)
        Me.AttrTopPanel.TabIndex = 4
        '
        'DropDownFilter
        '
        Me.DropDownFilter.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.DropDownFilter.FormattingEnabled = True
        Me.DropDownFilter.ItemHeight = 19
        Me.DropDownFilter.Items.AddRange(New Object() {"All", "Only Attributes That Have Values"})
        Me.DropDownFilter.Location = New System.Drawing.Point(309, 12)
        Me.DropDownFilter.Name = "DropDownFilter"
        Me.DropDownFilter.Size = New System.Drawing.Size(228, 25)
        Me.DropDownFilter.Style = MetroFramework.MetroColorStyle.Purple
        Me.DropDownFilter.TabIndex = 1
        Me.DropDownFilter.UseSelectable = True
        '
        'SearchBoxTb
        '
        Me.SearchBoxTb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.SearchBoxTb.CustomButton.Image = Nothing
        Me.SearchBoxTb.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.SearchBoxTb.CustomButton.Name = ""
        Me.SearchBoxTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.SearchBoxTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchBoxTb.CustomButton.TabIndex = 1
        Me.SearchBoxTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchBoxTb.CustomButton.UseSelectable = True
        Me.SearchBoxTb.CustomButton.Visible = False
        Me.SearchBoxTb.Lines = New String(-1) {}
        Me.SearchBoxTb.Location = New System.Drawing.Point(12, 12)
        Me.SearchBoxTb.MaxLength = 32767
        Me.SearchBoxTb.Name = "SearchBoxTb"
        Me.SearchBoxTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBoxTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBoxTb.SelectedText = ""
        Me.SearchBoxTb.SelectionLength = 0
        Me.SearchBoxTb.SelectionStart = 0
        Me.SearchBoxTb.ShortcutsEnabled = True
        Me.SearchBoxTb.Size = New System.Drawing.Size(291, 23)
        Me.SearchBoxTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SearchBoxTb.TabIndex = 0
        Me.SearchBoxTb.UseSelectable = True
        Me.SearchBoxTb.WaterMark = "Filter Attributes..."
        Me.SearchBoxTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBoxTb.WaterMarkFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(462, 408)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 2
        Me.CancelBn.Text = "Close"
        Me.CancelBn.UseSelectable = True
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 395)
        Me.ControlFooterPl1.MaximumSize = New System.Drawing.Size(0, 48)
        Me.ControlFooterPl1.MinimumSize = New System.Drawing.Size(0, 48)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(549, 48)
        Me.ControlFooterPl1.TabIndex = 3
        '
        'FormObjectAttributes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(549, 443)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormObjectAttributes"
        Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUserAttributes"
        Me.MainTabControl.ResumeLayout(False)
        Me.AttrTab.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttrTopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TypeCol As OLVColumn
    Friend WithEvents MainTabControl As CustomTabControl
    Friend WithEvents AttrTab As TabPage
    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameCol As OLVColumn
    Friend WithEvents ValueCol As OLVColumn
    Friend WithEvents AttrTopPanel As SimpleAD.ControlHeaderPanel
    Friend WithEvents DropDownFilter As Controls.MetroComboBox
    Friend WithEvents SearchBoxTb As Controls.MetroTextBox
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
End Class
