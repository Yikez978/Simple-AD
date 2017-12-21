<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormObjectAttributesBulk
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObjectAttributesBulk))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.Ready = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Attribute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DropDownFilter = New MetroFramework.Controls.MetroComboBox()
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.StatusStrip.SuspendLayout()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLb})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 416)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(652, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "Object Name"
        '
        'StatusLb
        '
        Me.StatusLb.ForeColor = System.Drawing.SystemColors.Window
        Me.StatusLb.Name = "StatusLb"
        Me.StatusLb.Size = New System.Drawing.Size(39, 17)
        Me.StatusLb.Text = "Status"
        '
        'MainDataGrid
        '
        Me.MainDataGrid.AllowUserToAddRows = False
        Me.MainDataGrid.AllowUserToDeleteRows = False
        Me.MainDataGrid.AllowUserToOrderColumns = True
        Me.MainDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MainDataGrid.ColumnHeadersHeight = 28
        Me.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MainDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ready, Me.Attribute, Me.Value})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGrid.EnableHeadersVisualStyles = False
        Me.MainDataGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 42)
        Me.MainDataGrid.Name = "MainDataGrid"
        Me.MainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.MainDataGrid.RowHeadersVisible = False
        Me.MainDataGrid.RowHeadersWidth = 44
        Me.MainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainDataGrid.RowTemplate.Height = 20
        Me.MainDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainDataGrid.ShowEditingIcon = False
        Me.MainDataGrid.Size = New System.Drawing.Size(652, 337)
        Me.MainDataGrid.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainDataGrid.TabIndex = 4
        Me.MainDataGrid.VirtualMode = True
        '
        'Ready
        '
        Me.Ready.DataPropertyName = "Ready"
        Me.Ready.FalseValue = "false"
        Me.Ready.FillWeight = 20.0!
        Me.Ready.HeaderText = "Ready"
        Me.Ready.IndeterminateValue = "nothing"
        Me.Ready.Name = "Ready"
        Me.Ready.TrueValue = "true"
        Me.Ready.Width = 60
        '
        'Attribute
        '
        Me.Attribute.DataPropertyName = "Attribute"
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Attribute.DefaultCellStyle = DataGridViewCellStyle3
        Me.Attribute.HeaderText = "Attribute"
        Me.Attribute.Name = "Attribute"
        Me.Attribute.ReadOnly = True
        Me.Attribute.Width = 242
        '
        'Value
        '
        Me.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Value.DataPropertyName = "Value"
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DropDownFilter)
        Me.Panel1.Controls.Add(Me.SearchBoxTb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 42)
        Me.Panel1.TabIndex = 5
        '
        'DropDownFilter
        '
        Me.DropDownFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DropDownFilter.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.DropDownFilter.FormattingEnabled = True
        Me.DropDownFilter.ItemHeight = 19
        Me.DropDownFilter.Items.AddRange(New Object() {"All", "Only those that have values"})
        Me.DropDownFilter.Location = New System.Drawing.Point(475, 3)
        Me.DropDownFilter.Name = "DropDownFilter"
        Me.DropDownFilter.Size = New System.Drawing.Size(170, 25)
        Me.DropDownFilter.Style = MetroFramework.MetroColorStyle.Purple
        Me.DropDownFilter.TabIndex = 1
        Me.DropDownFilter.UseSelectable = True
        '
        'SearchBoxTb
        '
        '
        '
        '
        Me.SearchBoxTb.CustomButton.Image = Nothing
        Me.SearchBoxTb.CustomButton.Location = New System.Drawing.Point(432, 1)
        Me.SearchBoxTb.CustomButton.Name = ""
        Me.SearchBoxTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.SearchBoxTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchBoxTb.CustomButton.TabIndex = 1
        Me.SearchBoxTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchBoxTb.CustomButton.UseSelectable = True
        Me.SearchBoxTb.CustomButton.Visible = False
        Me.SearchBoxTb.Lines = New String(-1) {}
        Me.SearchBoxTb.Location = New System.Drawing.Point(15, 3)
        Me.SearchBoxTb.MaxLength = 32767
        Me.SearchBoxTb.Name = "SearchBoxTb"
        Me.SearchBoxTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBoxTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBoxTb.SelectedText = ""
        Me.SearchBoxTb.SelectionLength = 0
        Me.SearchBoxTb.SelectionStart = 0
        Me.SearchBoxTb.ShortcutsEnabled = True
        Me.SearchBoxTb.Size = New System.Drawing.Size(454, 23)
        Me.SearchBoxTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SearchBoxTb.TabIndex = 0
        Me.SearchBoxTb.UseSelectable = True
        Me.SearchBoxTb.WaterMark = "Filter Attributes..."
        Me.SearchBoxTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBoxTb.WaterMarkFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.MetroPanel1.Controls.Add(Me.AcceptBn)
        Me.MetroPanel1.Controls.Add(Me.MetroProgressBar1)
        Me.MetroPanel1.Controls.Add(Me.CancelBn)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 379)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(652, 37)
        Me.MetroPanel1.TabIndex = 6
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'AcceptBn
        '
        Me.AcceptBn.Location = New System.Drawing.Point(467, 6)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(86, 23)
        Me.AcceptBn.TabIndex = 4
        Me.AcceptBn.Text = "Apply"
        Me.AcceptBn.UseSelectable = True
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(15, 6)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(315, 23)
        Me.MetroProgressBar1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroProgressBar1.TabIndex = 3
        Me.MetroProgressBar1.Visible = False
        '
        'CancelBn
        '
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(559, 6)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(86, 23)
        Me.CancelBn.TabIndex = 2
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'FormUserAttributesBulk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(652, 438)
        Me.Controls.Add(Me.MainDataGrid)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUserAttributesBulk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk Modify"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents MainDataGrid As Controls.MetroGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DropDownFilter As Controls.MetroComboBox
    Friend WithEvents SearchBoxTb As Controls.MetroTextBox
    Friend WithEvents StatusLb As ToolStripStatusLabel
    Friend WithEvents Ready As DataGridViewCheckBoxColumn
    Friend WithEvents Attribute As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents MetroPanel1 As Controls.MetroPanel
    Friend WithEvents MetroProgressBar1 As Controls.MetroProgressBar
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents AcceptBn As Controls.MetroButton
End Class
