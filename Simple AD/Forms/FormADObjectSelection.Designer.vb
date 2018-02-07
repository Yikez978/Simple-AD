Imports System.Windows.Forms
Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormADObjectSelection
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormADObjectSelection))
        Me.SearchBn = New System.Windows.Forms.Button()
        Me.SelectGroupTb = New SimpleAD.ControlTextBox()
        Me.MainGrid = New MetroFramework.Controls.MetroGrid()
        Me.TypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FooterPl = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.MainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchBn
        '
        Me.SearchBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBn.Location = New System.Drawing.Point(598, 6)
        Me.SearchBn.Name = "SearchBn"
        Me.SearchBn.Size = New System.Drawing.Size(76, 23)
        Me.SearchBn.TabIndex = 7
        Me.SearchBn.Text = "Find"
        '
        'SelectGroupTb
        '
        Me.SelectGroupTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.SelectGroupTb.Lines = New String(-1) {}
        Me.SelectGroupTb.Location = New System.Drawing.Point(17, 6)
        Me.SelectGroupTb.MaxLength = 32767
        Me.SelectGroupTb.Name = "SelectGroupTb"
        Me.SelectGroupTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SelectGroupTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectGroupTb.SelectedText = ""
        Me.SelectGroupTb.SelectionLength = 0
        Me.SelectGroupTb.SelectionStart = 0
        Me.SelectGroupTb.ShortcutsEnabled = True
        Me.SelectGroupTb.Size = New System.Drawing.Size(575, 23)
        Me.SelectGroupTb.TabIndex = 6
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
        Me.MainGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeColumn, Me.DescriptionColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainGrid.EnableHeadersVisualStyles = False
        Me.MainGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainGrid.Location = New System.Drawing.Point(0, 36)
        Me.MainGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.MainGrid.Name = "MainGrid"
        Me.MainGrid.ReadOnly = True
        Me.MainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MainGrid.RowHeadersVisible = False
        Me.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MainGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.MainGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window
        Me.MainGrid.RowTemplate.Height = 20
        Me.MainGrid.RowTemplate.ReadOnly = True
        Me.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainGrid.Size = New System.Drawing.Size(686, 295)
        Me.MainGrid.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainGrid.TabIndex = 5
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
        'FooterPl
        '
        Me.FooterPl.BackColor = System.Drawing.SystemColors.Control
        Me.FooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPl.Location = New System.Drawing.Point(0, 331)
        Me.FooterPl.Name = "FooterPl"
        Me.FooterPl.Size = New System.Drawing.Size(686, 67)
        Me.FooterPl.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SelectGroupTb)
        Me.Panel2.Controls.Add(Me.SearchBn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 36)
        Me.Panel2.TabIndex = 9
        '
        'FormADObjectSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(686, 398)
        Me.Controls.Add(Me.MainGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FooterPl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormADObjectSelection"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GroupSelectionForm"
        CType(Me.MainGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchBn As Button
    Friend WithEvents SelectGroupTb As SimpleAD.ControlTextBox
    Friend WithEvents MainGrid As Controls.MetroGrid
    Friend WithEvents TypeColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
    Friend WithEvents FooterPl As Panel
    Friend WithEvents Panel2 As Panel
End Class