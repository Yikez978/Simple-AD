<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerUserReport
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainDataGrid = New MetroFramework.Controls.MetroGrid()
        Me.SpacerPanel = New System.Windows.Forms.Panel()
        Me.SearchBoxTb = New MetroFramework.Controls.MetroTextBox()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.BulkContextMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.BulkModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleContextMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EnableDisableSingleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpacerPanel.SuspendLayout()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.BulkContextMenu.SuspendLayout()
        Me.SingleContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainDataGrid
        '
        Me.MainDataGrid.AllowUserToAddRows = False
        Me.MainDataGrid.AllowUserToDeleteRows = False
        Me.MainDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MainDataGrid.ColumnHeadersHeight = 28
        Me.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGrid.EnableHeadersVisualStyles = False
        Me.MainDataGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainDataGrid.HighLightPercentage = 0.8!
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.MainDataGrid.Name = "MainDataGrid"
        Me.MainDataGrid.ReadOnly = True
        Me.MainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MainDataGrid.RowHeadersVisible = False
        Me.MainDataGrid.RowHeadersWidth = 44
        Me.MainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainDataGrid.RowTemplate.Height = 20
        Me.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainDataGrid.ShowEditingIcon = False
        Me.MainDataGrid.Size = New System.Drawing.Size(547, 307)
        Me.MainDataGrid.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainDataGrid.TabIndex = 0
        Me.MainDataGrid.UseCustomBackColor = True
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
        Me.SpacerPanel.Size = New System.Drawing.Size(547, 36)
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
        Me.SearchBoxTb.PromptText = "Filter..."
        Me.SearchBoxTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBoxTb.SelectedText = ""
        Me.SearchBoxTb.SelectionLength = 0
        Me.SearchBoxTb.SelectionStart = 0
        Me.SearchBoxTb.ShortcutsEnabled = True
        Me.SearchBoxTb.ShowClearButton = True
        Me.SearchBoxTb.Size = New System.Drawing.Size(269, 24)
        Me.SearchBoxTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SearchBoxTb.TabIndex = 3
        Me.SearchBoxTb.UseCustomBackColor = True
        Me.SearchBoxTb.UseSelectable = True
        Me.SearchBoxTb.WaterMark = "Filter..."
        Me.SearchBoxTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBoxTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainDataGrid)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.SpacerPanel)
        Me.MainSplitContainer.Size = New System.Drawing.Size(749, 343)
        Me.MainSplitContainer.SplitterDistance = 200
        Me.MainSplitContainer.SplitterWidth = 2
        Me.MainSplitContainer.TabIndex = 3
        '
        'BulkContextMenu
        '
        Me.BulkContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BulkModifyToolStripMenuItem, Me.EnableDisableToolStripMenuItem, Me.MoveToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.BulkContextMenu.Name = "BulkContextMenu"
        Me.BulkContextMenu.Size = New System.Drawing.Size(153, 92)
        Me.BulkContextMenu.Style = MetroFramework.MetroColorStyle.Purple
        '
        'BulkModifyToolStripMenuItem
        '
        Me.BulkModifyToolStripMenuItem.Name = "BulkModifyToolStripMenuItem"
        Me.BulkModifyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BulkModifyToolStripMenuItem.Text = "Bulk Modify..."
        '
        'EnableDisableToolStripMenuItem
        '
        Me.EnableDisableToolStripMenuItem.Name = "EnableDisableToolStripMenuItem"
        Me.EnableDisableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnableDisableToolStripMenuItem.Text = "Enable/Disable"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MoveToolStripMenuItem.Text = "Move..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SingleContextMenu
        '
        Me.SingleContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableDisableSingleToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.PropertiesToolStripMenuItem})
        Me.SingleContextMenu.Name = "BulkContextMenu"
        Me.SingleContextMenu.Size = New System.Drawing.Size(153, 114)
        Me.SingleContextMenu.Style = MetroFramework.MetroColorStyle.Purple
        '
        'EnableDisableSingleToolStripMenuItem
        '
        Me.EnableDisableSingleToolStripMenuItem.Name = "EnableDisableSingleToolStripMenuItem"
        Me.EnableDisableSingleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnableDisableSingleToolStripMenuItem.Text = "Enable/Disable"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "Move..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties..."
        '
        'ContainerUserReport
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "ContainerUserReport"
        Me.Size = New System.Drawing.Size(749, 343)
        CType(Me.MainDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpacerPanel.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.BulkContextMenu.ResumeLayout(False)
        Me.SingleContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainDataGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents SpacerPanel As Panel
    Friend WithEvents SearchBoxTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents BulkContextMenu As Controls.MetroContextMenu
    Friend WithEvents BulkModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableDisableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SingleContextMenu As Controls.MetroContextMenu
    Friend WithEvents EnableDisableSingleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
End Class
