<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerUserBulk
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainSplitContainer0 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.nameCol = New SimpleAD.TextAndImageColumn()
        Me.status = New SimpleAD.TextAndImageColumn()
        Me.AcceptBt = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroProgressSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.CMStripRowRClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyValueToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertNewRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MainSplitContainer0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer0.Panel1.SuspendLayout()
        Me.MainSplitContainer0.Panel2.SuspendLayout()
        Me.MainSplitContainer0.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CMStripRowRClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSplitContainer0
        '
        Me.MainSplitContainer0.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MainSplitContainer0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer0.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer0.Name = "MainSplitContainer0"
        '
        'MainSplitContainer0.Panel1
        '
        Me.MainSplitContainer0.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainSplitContainer0.Panel1.Controls.Add(Me.Panel2)
        '
        'MainSplitContainer0.Panel2
        '
        Me.MainSplitContainer0.Panel2.Controls.Add(Me.MainDataGrid)
        Me.MainSplitContainer0.Size = New System.Drawing.Size(878, 439)
        Me.MainSplitContainer0.SplitterDistance = 170
        Me.MainSplitContainer0.SplitterWidth = 2
        Me.MainSplitContainer0.TabIndex = 6
        Me.MainSplitContainer0.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(0, 28)
        Me.Panel2.MinimumSize = New System.Drawing.Size(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 28)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directory"
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
        Me.MainDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nameCol, Me.status})
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
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 0)
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
        Me.MainDataGrid.RowTemplate.Height = 20
        Me.MainDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainDataGrid.ShowEditingIcon = False
        Me.MainDataGrid.Size = New System.Drawing.Size(706, 439)
        Me.MainDataGrid.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainDataGrid.TabIndex = 1
        '
        'nameCol
        '
        Me.nameCol.columnName = Nothing
        Me.nameCol.DataPropertyName = "name"
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.nameCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.nameCol.Frozen = True
        Me.nameCol.HeaderText = "Name"
        Me.nameCol.Image = Global.SimpleAD.My.Resources.Resources.User
        Me.nameCol.MinimumWidth = 100
        Me.nameCol.Name = "nameCol"
        Me.nameCol.Width = 260
        '
        'status
        '
        Me.status.columnName = Nothing
        Me.status.DataPropertyName = "status"
        Me.status.Frozen = True
        Me.status.HeaderText = "Status"
        Me.status.Image = Nothing
        Me.status.MinimumWidth = 100
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 200
        '
        'AcceptBt
        '
        Me.AcceptBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBt.DisplayFocus = True
        Me.AcceptBt.Location = New System.Drawing.Point(756, 7)
        Me.AcceptBt.Name = "AcceptBt"
        Me.AcceptBt.Size = New System.Drawing.Size(119, 23)
        Me.AcceptBt.TabIndex = 7
        Me.AcceptBt.Text = "Create Users"
        Me.AcceptBt.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.Location = New System.Drawing.Point(675, 7)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 8
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(10, 10)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(394, 17)
        Me.ProgressBar.Style = MetroFramework.MetroColorStyle.Purple
        Me.ProgressBar.TabIndex = 9
        Me.ProgressBar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.MetroProgressSpinner)
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Controls.Add(Me.AcceptBt)
        Me.Panel1.Controls.Add(Me.CancelBn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 439)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 36)
        Me.Panel1.TabIndex = 10
        '
        'MetroProgressSpinner
        '
        Me.MetroProgressSpinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressSpinner.Location = New System.Drawing.Point(652, 11)
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
        'CMStripRowRClick
        '
        Me.CMStripRowRClick.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CMStripRowRClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyValueToClipboardToolStripMenuItem, Me.InsertNewRow, Me.DeleteRow, Me.PropertiesToolStripMenuItem})
        Me.CMStripRowRClick.Name = "ContextMenuStrip1"
        Me.CMStripRowRClick.Size = New System.Drawing.Size(194, 92)
        '
        'CopyValueToClipboardToolStripMenuItem
        '
        Me.CopyValueToClipboardToolStripMenuItem.Name = "CopyValueToClipboardToolStripMenuItem"
        Me.CopyValueToClipboardToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CopyValueToClipboardToolStripMenuItem.Text = "&Copy"
        '
        'InsertNewRow
        '
        Me.InsertNewRow.Name = "InsertNewRow"
        Me.InsertNewRow.Size = New System.Drawing.Size(193, 22)
        Me.InsertNewRow.Text = "Insert &New User"
        '
        'DeleteRow
        '
        Me.DeleteRow.Name = "DeleteRow"
        Me.DeleteRow.Size = New System.Drawing.Size(193, 22)
        Me.DeleteRow.Text = "&Delete Selected User(s)"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PropertiesToolStripMenuItem.Text = "&Properties..."
        '
        'ContainerUserBulk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.MainSplitContainer0)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ContainerUserBulk"
        Me.Size = New System.Drawing.Size(878, 475)
        Me.MainSplitContainer0.Panel1.ResumeLayout(False)
        Me.MainSplitContainer0.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer0.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.CMStripRowRClick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainSplitContainer0 As SplitContainer
    Friend WithEvents CancelBn As MetroFramework.Controls.MetroButton
    Friend WithEvents ProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents AcceptBt As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroProgressSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents CMStripRowRClick As ContextMenuStrip
    Friend WithEvents CopyValueToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertNewRow As ToolStripMenuItem
    Friend WithEvents DeleteRow As ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainDataGrid As Controls.MetroGrid
    Friend WithEvents nameCol As TextAndImageColumn
    Friend WithEvents status As TextAndImageColumn
    Friend WithEvents Panel1 As Panel
End Class
