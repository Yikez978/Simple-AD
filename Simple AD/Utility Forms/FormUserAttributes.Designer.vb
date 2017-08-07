<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserAttributes
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserAttributes))
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DropDownFilter = New MetroFramework.Controls.MetroComboBox()
        Me.MainDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.Attribute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBoxTb
        '
        '
        '
        '
        Me.SearchBoxTb.CustomButton.Image = Nothing
        Me.SearchBoxTb.CustomButton.Location = New System.Drawing.Point(284, 1)
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
        Me.SearchBoxTb.PromptText = "Filter Attributes..."
        Me.SearchBoxTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBoxTb.SelectedText = ""
        Me.SearchBoxTb.SelectionLength = 0
        Me.SearchBoxTb.SelectionStart = 0
        Me.SearchBoxTb.ShortcutsEnabled = True
        Me.SearchBoxTb.Size = New System.Drawing.Size(306, 23)
        Me.SearchBoxTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SearchBoxTb.TabIndex = 0
        Me.SearchBoxTb.UseSelectable = True
        Me.SearchBoxTb.WaterMark = "Filter Attributes..."
        Me.SearchBoxTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBoxTb.WaterMarkFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DropDownFilter)
        Me.Panel1.Controls.Add(Me.SearchBoxTb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 42)
        Me.Panel1.TabIndex = 1
        '
        'DropDownFilter
        '
        Me.DropDownFilter.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.DropDownFilter.FormattingEnabled = True
        Me.DropDownFilter.ItemHeight = 19
        Me.DropDownFilter.Items.AddRange(New Object() {"All", "Only those that have values"})
        Me.DropDownFilter.Location = New System.Drawing.Point(327, 3)
        Me.DropDownFilter.Name = "DropDownFilter"
        Me.DropDownFilter.Size = New System.Drawing.Size(170, 25)
        Me.DropDownFilter.Style = MetroFramework.MetroColorStyle.Purple
        Me.DropDownFilter.TabIndex = 1
        Me.DropDownFilter.UseSelectable = True
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
        Me.MainDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Attribute, Me.Value})
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
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 72)
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
        Me.MainDataGrid.Size = New System.Drawing.Size(549, 393)
        Me.MainDataGrid.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainDataGrid.TabIndex = 1
        Me.MainDataGrid.VirtualMode = True
        '
        'Attribute
        '
        Me.Attribute.DataPropertyName = "Attribute"
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
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
        'FormUserAttributes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 465)
        Me.Controls.Add(Me.MainDataGrid)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUserAttributes"
        Me.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "FormUserAttributes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchBoxTb As Controls.MetroTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MainDataGrid As Controls.MetroGrid
    Friend WithEvents Attribute As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents DropDownFilter As Controls.MetroComboBox
End Class
