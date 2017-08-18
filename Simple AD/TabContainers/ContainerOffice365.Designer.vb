<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContainerOffice365
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.OfficeContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpacerPanel = New System.Windows.Forms.Panel()
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfficeContextMenuStrip.SuspendLayout()
        Me.SpacerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainDataGrid
        '
        Me.MainDataGrid.AllowUserToAddRows = False
        Me.MainDataGrid.AllowUserToDeleteRows = False
        Me.MainDataGrid.AllowUserToOrderColumns = True
        Me.MainDataGrid.AllowUserToResizeRows = False
        Me.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MainDataGrid.ColumnHeadersHeight = 28
        Me.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MainDataGrid.ContextMenuStrip = Me.OfficeContextMenuStrip
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGrid.EnableHeadersVisualStyles = False
        Me.MainDataGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.MainDataGrid.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.MainDataGrid.Name = "MainDataGrid"
        Me.MainDataGrid.ReadOnly = True
        Me.MainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MainDataGrid.RowHeadersVisible = False
        Me.MainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainDataGrid.RowTemplate.Height = 20
        Me.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainDataGrid.Size = New System.Drawing.Size(749, 307)
        Me.MainDataGrid.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainDataGrid.TabIndex = 0
        '
        'OfficeContextMenuStrip
        '
        Me.OfficeContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetPasswordToolStripMenuItem})
        Me.OfficeContextMenuStrip.Name = "OfficeContextMenuStrip"
        Me.OfficeContextMenuStrip.Size = New System.Drawing.Size(165, 26)
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Password..."
        '
        'SpacerPanel
        '
        Me.SpacerPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SpacerPanel.Controls.Add(Me.SearchBoxTb)
        Me.SpacerPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SpacerPanel.Location = New System.Drawing.Point(0, 307)
        Me.SpacerPanel.MaximumSize = New System.Drawing.Size(10000, 36)
        Me.SpacerPanel.Name = "SpacerPanel"
        Me.SpacerPanel.Padding = New System.Windows.Forms.Padding(12, 12, 48, 6)
        Me.SpacerPanel.Size = New System.Drawing.Size(749, 36)
        Me.SpacerPanel.TabIndex = 2
        '
        'SearchBoxTb
        '
        Me.SearchBoxTb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.SearchBoxTb.CustomButton.Image = Nothing
        Me.SearchBoxTb.CustomButton.Location = New System.Drawing.Point(247, 2)
        Me.SearchBoxTb.CustomButton.Name = ""
        Me.SearchBoxTb.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.SearchBoxTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchBoxTb.CustomButton.TabIndex = 1
        Me.SearchBoxTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchBoxTb.CustomButton.UseSelectable = True
        Me.SearchBoxTb.CustomButton.Visible = False
        Me.SearchBoxTb.DisplayIcon = True
        Me.SearchBoxTb.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.SearchBoxTb.Lines = New String(-1) {}
        Me.SearchBoxTb.Location = New System.Drawing.Point(6, 6)
        Me.SearchBoxTb.MaxLength = 32767
        Me.SearchBoxTb.Name = "SearchBoxTb"
        Me.SearchBoxTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBoxTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBoxTb.SelectedText = ""
        Me.SearchBoxTb.SelectionLength = 0
        Me.SearchBoxTb.SelectionStart = 0
        Me.SearchBoxTb.ShortcutsEnabled = True
        Me.SearchBoxTb.ShowClearButton = True
        Me.SearchBoxTb.Size = New System.Drawing.Size(269, 24)
        Me.SearchBoxTb.Style = MetroFramework.MetroColorStyle.Orange
        Me.SearchBoxTb.TabIndex = 4
        Me.SearchBoxTb.UseCustomBackColor = True
        Me.SearchBoxTb.UseSelectable = True
        Me.SearchBoxTb.WaterMark = "Filter..."
        Me.SearchBoxTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBoxTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ContainerOffice365
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainDataGrid)
        Me.Controls.Add(Me.SpacerPanel)
        Me.Name = "ContainerOffice365"
        Me.Size = New System.Drawing.Size(749, 343)
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfficeContextMenuStrip.ResumeLayout(False)
        Me.SpacerPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainDataGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents OfficeContextMenuStrip As ContextMenuStrip
    Friend WithEvents ResetPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpacerPanel As Panel
    Friend WithEvents SearchBoxTb As Controls.MetroTextBox
End Class
