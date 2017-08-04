<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGroupSelection
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGroupSelection))
        Me.SearchBn = New MetroFramework.Controls.MetroButton()
        Me.SelectGroupTb = New MetroFramework.Controls.MetroTextBox()
        Me.MainGrid = New MetroFramework.Controls.MetroGrid()
        Me.NameCol = New Simple_AD.TextAndImageColumn()
        Me.TypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.MainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchBn
        '
        Me.SearchBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBn.Location = New System.Drawing.Point(478, 6)
        Me.SearchBn.Name = "SearchBn"
        Me.SearchBn.Size = New System.Drawing.Size(76, 23)
        Me.SearchBn.TabIndex = 7
        Me.SearchBn.Text = "Find"
        Me.SearchBn.UseSelectable = True
        '
        'SelectGroupTb
        '
        '
        '
        '
        Me.SelectGroupTb.CustomButton.Image = Nothing
        Me.SelectGroupTb.CustomButton.Location = New System.Drawing.Point(433, 1)
        Me.SelectGroupTb.CustomButton.Name = ""
        Me.SelectGroupTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.SelectGroupTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SelectGroupTb.CustomButton.TabIndex = 1
        Me.SelectGroupTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SelectGroupTb.CustomButton.UseSelectable = True
        Me.SelectGroupTb.CustomButton.Visible = False
        Me.SelectGroupTb.Lines = New String(-1) {}
        Me.SelectGroupTb.Location = New System.Drawing.Point(17, 6)
        Me.SelectGroupTb.MaxLength = 32767
        Me.SelectGroupTb.Name = "SelectGroupTb"
        Me.SelectGroupTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SelectGroupTb.PromptText = "Filter Groups.."
        Me.SelectGroupTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectGroupTb.SelectedText = ""
        Me.SelectGroupTb.SelectionLength = 0
        Me.SelectGroupTb.SelectionStart = 0
        Me.SelectGroupTb.ShortcutsEnabled = True
        Me.SelectGroupTb.Size = New System.Drawing.Size(455, 23)
        Me.SelectGroupTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SelectGroupTb.TabIndex = 6
        Me.SelectGroupTb.UseSelectable = True
        Me.SelectGroupTb.WaterMark = "Filter Groups.."
        Me.SelectGroupTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SelectGroupTb.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MainGrid
        '
        Me.MainGrid.AllowUserToAddRows = False
        Me.MainGrid.AllowUserToDeleteRows = False
        Me.MainGrid.AllowUserToResizeRows = False
        Me.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MainGrid.ColumnHeadersHeight = 24
        Me.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MainGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameCol, Me.TypeColumn, Me.DescriptionColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainGrid.EnableHeadersVisualStyles = False
        Me.MainGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainGrid.Location = New System.Drawing.Point(0, 66)
        Me.MainGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.MainGrid.Name = "MainGrid"
        Me.MainGrid.ReadOnly = True
        Me.MainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MainGrid.RowHeadersVisible = False
        Me.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MainGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.MainGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window
        Me.MainGrid.RowTemplate.Height = 20
        Me.MainGrid.RowTemplate.ReadOnly = True
        Me.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainGrid.Size = New System.Drawing.Size(686, 296)
        Me.MainGrid.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainGrid.TabIndex = 5
        '
        'NameCol
        '
        Me.NameCol.columnName = "NameCol"
        Me.NameCol.DataPropertyName = "Name"
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.NameCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameCol.FillWeight = 116.7513!
        Me.NameCol.HeaderText = "Name"
        Me.NameCol.Image = CType(resources.GetObject("NameCol.Image"), System.Drawing.Image)
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        '
        'TypeColumn
        '
        Me.TypeColumn.DataPropertyName = "Type"
        Me.TypeColumn.FillWeight = 56.62437!
        Me.TypeColumn.HeaderText = "Type"
        Me.TypeColumn.Name = "TypeColumn"
        Me.TypeColumn.ReadOnly = True
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.DataPropertyName = "Description"
        Me.DescriptionColumn.FillWeight = 56.62437!
        Me.DescriptionColumn.HeaderText = "Description"
        Me.DescriptionColumn.Name = "DescriptionColumn"
        Me.DescriptionColumn.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 36)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SelectGroupTb)
        Me.Panel2.Controls.Add(Me.SearchBn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 36)
        Me.Panel2.TabIndex = 9
        '
        'FormGroupSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 398)
        Me.Controls.Add(Me.MainGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGroupSelection"
        Me.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "GroupSelectionForm"
        CType(Me.MainGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NameColumn As TextAndImageColumn
    Friend WithEvents SearchBn As Controls.MetroButton
    Friend WithEvents SelectGroupTb As Controls.MetroTextBox
    Friend WithEvents MainGrid As Controls.MetroGrid
    Friend WithEvents NameCol As TextAndImageColumn
    Friend WithEvents TypeColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class