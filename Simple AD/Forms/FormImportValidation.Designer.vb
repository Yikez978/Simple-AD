<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportValidation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImportValidation))
        Me.HeaderLb = New System.Windows.Forms.Label()
        Me.ErrorDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.CancelBtn = New MetroFramework.Controls.MetroButton()
        Me.ImportBtn = New MetroFramework.Controls.MetroButton()
        Me.SplitterBottom = New System.Windows.Forms.Splitter()
        Me.SplitterTop = New System.Windows.Forms.Splitter()
        CType(Me.ErrorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderLb
        '
        Me.HeaderLb.AutoSize = True
        Me.HeaderLb.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLb.Location = New System.Drawing.Point(25, 72)
        Me.HeaderLb.Name = "HeaderLb"
        Me.HeaderLb.Size = New System.Drawing.Size(340, 14)
        Me.HeaderLb.TabIndex = 0
        Me.HeaderLb.Text = "Simple AD has detected the following Errors in the imported file"
        '
        'ErrorDataGrid
        '
        Me.ErrorDataGrid.AllowUserToAddRows = False
        Me.ErrorDataGrid.AllowUserToDeleteRows = False
        Me.ErrorDataGrid.AllowUserToResizeRows = False
        Me.ErrorDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ErrorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ErrorDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ErrorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ErrorDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ErrorDataGrid.ColumnHeadersHeight = 19
        Me.ErrorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ErrorDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.ErrorDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorDataGrid.EnableHeadersVisualStyles = False
        Me.ErrorDataGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ErrorDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ErrorDataGrid.Location = New System.Drawing.Point(20, 98)
        Me.ErrorDataGrid.Name = "ErrorDataGrid"
        Me.ErrorDataGrid.ReadOnly = True
        Me.ErrorDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ErrorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ErrorDataGrid.RowHeadersVisible = False
        Me.ErrorDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ErrorDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ErrorDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ErrorDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window
        Me.ErrorDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.ErrorDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ErrorDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ErrorDataGrid.Size = New System.Drawing.Size(460, 104)
        Me.ErrorDataGrid.Style = MetroFramework.MetroColorStyle.Purple
        Me.ErrorDataGrid.TabIndex = 1
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(397, 214)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Ignore"
        Me.CancelBtn.UseSelectable = True
        '
        'ImportBtn
        '
        Me.ImportBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportBtn.Location = New System.Drawing.Point(244, 214)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(147, 23)
        Me.ImportBtn.TabIndex = 3
        Me.ImportBtn.Text = "Import a Different File..."
        Me.ImportBtn.UseSelectable = True
        '
        'SplitterBottom
        '
        Me.SplitterBottom.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterBottom.Location = New System.Drawing.Point(20, 202)
        Me.SplitterBottom.Name = "SplitterBottom"
        Me.SplitterBottom.Size = New System.Drawing.Size(460, 44)
        Me.SplitterBottom.TabIndex = 5
        Me.SplitterBottom.TabStop = False
        '
        'SplitterTop
        '
        Me.SplitterTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitterTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterTop.Location = New System.Drawing.Point(20, 60)
        Me.SplitterTop.Name = "SplitterTop"
        Me.SplitterTop.Size = New System.Drawing.Size(460, 38)
        Me.SplitterTop.TabIndex = 6
        Me.SplitterTop.TabStop = False
        '
        'FormImportValidation
        '
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(500, 266)
        Me.Controls.Add(Me.ImportBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ErrorDataGrid)
        Me.Controls.Add(Me.HeaderLb)
        Me.Controls.Add(Me.SplitterBottom)
        Me.Controls.Add(Me.SplitterTop)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormImportValidation"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "File Validation"
        CType(Me.ErrorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderLb As Label
    Friend WithEvents SplitterBottom As Splitter
    Friend WithEvents SplitterTop As Splitter
    Friend WithEvents CancelBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents ImportBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorDataGrid As MetroFramework.Controls.MetroGrid
End Class
