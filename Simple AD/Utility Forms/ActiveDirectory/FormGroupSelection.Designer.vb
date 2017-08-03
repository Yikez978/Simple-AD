<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGroupSelection
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainTabControl = New MetroFramework.Controls.MetroTabControl()
        Me.GroupsTab = New MetroFramework.Controls.MetroTabPage()
        Me.SearchBn = New MetroFramework.Controls.MetroButton()
        Me.SelectGroupTb = New MetroFramework.Controls.MetroTextBox()
        Me.MainGrid = New MetroFramework.Controls.MetroGrid()
        Me.NameColumn = New Simple_AD.TextAndImageColumn()
        Me.TypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainTabControl.SuspendLayout()
        Me.GroupsTab.SuspendLayout()
        CType(Me.MainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.GroupsTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(20, 30)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(646, 314)
        Me.MainTabControl.TabIndex = 0
        Me.MainTabControl.UseSelectable = True
        '
        'GroupsTab
        '
        Me.GroupsTab.Controls.Add(Me.SearchBn)
        Me.GroupsTab.Controls.Add(Me.SelectGroupTb)
        Me.GroupsTab.Controls.Add(Me.MainGrid)
        Me.GroupsTab.HorizontalScrollbarBarColor = True
        Me.GroupsTab.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupsTab.HorizontalScrollbarSize = 10
        Me.GroupsTab.Location = New System.Drawing.Point(4, 38)
        Me.GroupsTab.Name = "GroupsTab"
        Me.GroupsTab.Size = New System.Drawing.Size(638, 272)
        Me.GroupsTab.TabIndex = 0
        Me.GroupsTab.Text = "Select Groups"
        Me.GroupsTab.VerticalScrollbarBarColor = True
        Me.GroupsTab.VerticalScrollbarHighlightOnWheel = False
        Me.GroupsTab.VerticalScrollbarSize = 10
        '
        'SearchBn
        '
        Me.SearchBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBn.Location = New System.Drawing.Point(562, 13)
        Me.SearchBn.Name = "SearchBn"
        Me.SearchBn.Size = New System.Drawing.Size(76, 23)
        Me.SearchBn.TabIndex = 4
        Me.SearchBn.Text = "Find"
        Me.SearchBn.UseSelectable = True
        '
        'SelectGroupTb
        '
        '
        '
        '
        Me.SelectGroupTb.CustomButton.Image = Nothing
        Me.SelectGroupTb.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.SelectGroupTb.CustomButton.Name = ""
        Me.SelectGroupTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.SelectGroupTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SelectGroupTb.CustomButton.TabIndex = 1
        Me.SelectGroupTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SelectGroupTb.CustomButton.UseSelectable = True
        Me.SelectGroupTb.CustomButton.Visible = False
        Me.SelectGroupTb.Lines = New String(-1) {}
        Me.SelectGroupTb.Location = New System.Drawing.Point(0, 13)
        Me.SelectGroupTb.MaxLength = 32767
        Me.SelectGroupTb.Name = "SelectGroupTb"
        Me.SelectGroupTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SelectGroupTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectGroupTb.SelectedText = ""
        Me.SelectGroupTb.SelectionLength = 0
        Me.SelectGroupTb.SelectionStart = 0
        Me.SelectGroupTb.ShortcutsEnabled = True
        Me.SelectGroupTb.Size = New System.Drawing.Size(556, 23)
        Me.SelectGroupTb.TabIndex = 3
        Me.SelectGroupTb.UseSelectable = True
        Me.SelectGroupTb.WaterMark = "Group Name"
        Me.SelectGroupTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SelectGroupTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MainGrid
        '
        Me.MainGrid.AllowUserToAddRows = False
        Me.MainGrid.AllowUserToDeleteRows = False
        Me.MainGrid.AllowUserToResizeRows = False
        Me.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MainGrid.ColumnHeadersHeight = 24
        Me.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MainGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameColumn, Me.TypeColumn, Me.DescriptionColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.MainGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainGrid.EnableHeadersVisualStyles = False
        Me.MainGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MainGrid.Location = New System.Drawing.Point(0, 42)
        Me.MainGrid.Name = "MainGrid"
        Me.MainGrid.ReadOnly = True
        Me.MainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
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
        Me.MainGrid.Size = New System.Drawing.Size(638, 230)
        Me.MainGrid.Style = MetroFramework.MetroColorStyle.Blue
        Me.MainGrid.TabIndex = 2
        '
        'NameColumn
        '
        Me.NameColumn.columnName = "NameCol"
        Me.NameColumn.DataPropertyName = "Name"
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.NameColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameColumn.FillWeight = 116.7513!
        Me.NameColumn.HeaderText = "Name"
        Me.NameColumn.Image = GlobalVariables.groupImage
        Me.NameColumn.Name = "NameCol"
        Me.NameColumn.ReadOnly = True
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
        'GroupSelectionForm
        '
        Me.AcceptButton = Me.SearchBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 364)
        Me.Controls.Add(Me.MainTabControl)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GroupSelectionForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "GroupSelectionForm"
        Me.MainTabControl.ResumeLayout(False)
        Me.GroupsTab.ResumeLayout(False)
        CType(Me.MainGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainTabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MainGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupsTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents SearchBn As MetroFramework.Controls.MetroButton
    Friend WithEvents SelectGroupTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents NameCol As TextAndImageColumn
    Friend WithEvents NameColumn As TextAndImageColumn
    Friend WithEvents TypeColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
End Class
