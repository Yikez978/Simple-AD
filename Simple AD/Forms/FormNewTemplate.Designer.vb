Imports System.Drawing
Imports System.Windows.Forms
Imports BrightIdeasSoftware
Imports MetroFramework
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewTemplate
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewTemplate))
        Me.Setup = New MetroFramework.Controls.MetroTabControl()
        Me.BasicTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.DetailsGPl = New System.Windows.Forms.GroupBox()
        Me.AuthorValLb = New System.Windows.Forms.Label()
        Me.AuthorLb = New System.Windows.Forms.Label()
        Me.IDLb = New System.Windows.Forms.Label()
        Me.IDTb = New SimpleAD.ControlTextBox()
        Me.LogoPb = New System.Windows.Forms.PictureBox()
        Me.DescriptionTb = New SimpleAD.ControlTextBox()
        Me.NameTb = New SimpleAD.ControlTextBox()
        Me.DescriptionLb = New System.Windows.Forms.Label()
        Me.NameLb = New System.Windows.Forms.Label()
        Me.IconTabPage = New System.Windows.Forms.TabPage()
        Me.IconListView = New SimpleAD.ControlDomainListView()
        Me.NameColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.BackPl = New System.Windows.Forms.Panel()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        Me.CnBt = New System.Windows.Forms.Button()
        Me.OKBt = New System.Windows.Forms.Button()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.Setup.SuspendLayout()
        Me.BasicTabPage.SuspendLayout()
        Me.DetailsGPl.SuspendLayout()
        CType(Me.LogoPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IconTabPage.SuspendLayout()
        CType(Me.IconListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackPl.SuspendLayout()
        Me.ControlFooterPl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Setup
        '
        Me.Setup.Controls.Add(Me.BasicTabPage)
        Me.Setup.Controls.Add(Me.IconTabPage)
        Me.Setup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Setup.Location = New System.Drawing.Point(8, 8)
        Me.Setup.Margin = New System.Windows.Forms.Padding(4)
        Me.Setup.Name = "Setup"
        Me.Setup.SelectedIndex = 1
        Me.Setup.Size = New System.Drawing.Size(615, 272)
        Me.Setup.Style = MetroFramework.MetroColorStyle.Purple
        Me.Setup.TabIndex = 1
        Me.Setup.UseSelectable = True
        '
        'BasicTabPage
        '
        Me.BasicTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.BasicTabPage.Controls.Add(Me.DetailsGPl)
        Me.BasicTabPage.HorizontalScrollbarBarColor = True
        Me.BasicTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.BasicTabPage.HorizontalScrollbarSize = 10
        Me.BasicTabPage.Location = New System.Drawing.Point(4, 38)
        Me.BasicTabPage.Name = "BasicTabPage"
        Me.BasicTabPage.Size = New System.Drawing.Size(607, 230)
        Me.BasicTabPage.TabIndex = 1
        Me.BasicTabPage.Text = "Basic Info"
        Me.BasicTabPage.UseCustomBackColor = True
        Me.BasicTabPage.VerticalScrollbarBarColor = True
        Me.BasicTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.BasicTabPage.VerticalScrollbarSize = 10
        '
        'DetailsGPl
        '
        Me.DetailsGPl.BackColor = System.Drawing.SystemColors.Window
        Me.DetailsGPl.Controls.Add(Me.AuthorValLb)
        Me.DetailsGPl.Controls.Add(Me.AuthorLb)
        Me.DetailsGPl.Controls.Add(Me.IDLb)
        Me.DetailsGPl.Controls.Add(Me.IDTb)
        Me.DetailsGPl.Controls.Add(Me.LogoPb)
        Me.DetailsGPl.Controls.Add(Me.DescriptionTb)
        Me.DetailsGPl.Controls.Add(Me.NameTb)
        Me.DetailsGPl.Controls.Add(Me.DescriptionLb)
        Me.DetailsGPl.Controls.Add(Me.NameLb)
        Me.DetailsGPl.Location = New System.Drawing.Point(0, 11)
        Me.DetailsGPl.Name = "DetailsGPl"
        Me.DetailsGPl.Size = New System.Drawing.Size(607, 220)
        Me.DetailsGPl.TabIndex = 7
        Me.DetailsGPl.TabStop = False
        Me.DetailsGPl.Text = "Template Details"
        '
        'AuthorValLb
        '
        Me.AuthorValLb.AutoSize = True
        Me.AuthorValLb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AuthorValLb.Location = New System.Drawing.Point(451, 154)
        Me.AuthorValLb.Name = "AuthorValLb"
        Me.AuthorValLb.Size = New System.Drawing.Size(97, 19)
        Me.AuthorValLb.TabIndex = 8
        Me.AuthorValLb.Text = "Author's Name"
        '
        'AuthorLb
        '
        Me.AuthorLb.AutoSize = True
        Me.AuthorLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AuthorLb.Location = New System.Drawing.Point(452, 138)
        Me.AuthorLb.Name = "AuthorLb"
        Me.AuthorLb.Size = New System.Drawing.Size(46, 15)
        Me.AuthorLb.TabIndex = 7
        Me.AuthorLb.Text = "Author"
        '
        'IDLb
        '
        Me.IDLb.AutoSize = True
        Me.IDLb.Location = New System.Drawing.Point(19, 181)
        Me.IDLb.Name = "IDLb"
        Me.IDLb.Size = New System.Drawing.Size(83, 19)
        Me.IDLb.TabIndex = 6
        Me.IDLb.Text = "Template ID:"
        '
        'IDTb
        '
        Me.IDTb.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.IDTb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IDTb.Lines = New String(-1) {}
        Me.IDTb.Location = New System.Drawing.Point(117, 179)
        Me.IDTb.MaxLength = 32767
        Me.IDTb.Name = "IDTb"
        Me.IDTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDTb.ReadOnly = True
        Me.IDTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.IDTb.SelectedText = ""
        Me.IDTb.SelectionLength = 0
        Me.IDTb.SelectionStart = 0
        Me.IDTb.ShortcutsEnabled = True
        Me.IDTb.Size = New System.Drawing.Size(278, 23)
        Me.IDTb.TabIndex = 5
        '
        'LogoPb
        '
        Me.LogoPb.Image = New Icon(My.Resources.Template, New Size(16, 16)).ToBitmap
        Me.LogoPb.Location = New System.Drawing.Point(452, 30)
        Me.LogoPb.Name = "LogoPb"
        Me.LogoPb.Size = New System.Drawing.Size(96, 96)
        Me.LogoPb.TabIndex = 4
        Me.LogoPb.TabStop = False
        '
        'DescriptionTb
        '
        '
        '
        '
        Me.DescriptionTb.Lines = New String(-1) {}
        Me.DescriptionTb.Location = New System.Drawing.Point(117, 59)
        Me.DescriptionTb.MaxLength = 32767
        Me.DescriptionTb.Multiline = True
        Me.DescriptionTb.Name = "DescriptionTb"
        Me.DescriptionTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescriptionTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DescriptionTb.SelectedText = ""
        Me.DescriptionTb.SelectionLength = 0
        Me.DescriptionTb.SelectionStart = 0
        Me.DescriptionTb.ShortcutsEnabled = True
        Me.DescriptionTb.Size = New System.Drawing.Size(278, 114)
        Me.DescriptionTb.TabIndex = 3
        '
        'NameTb
        '
        '
        '
        '
        Me.NameTb.Lines = New String(-1) {}
        Me.NameTb.Location = New System.Drawing.Point(117, 30)
        Me.NameTb.MaxLength = 32767
        Me.NameTb.Name = "NameTb"
        Me.NameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NameTb.SelectedText = ""
        Me.NameTb.SelectionLength = 0
        Me.NameTb.SelectionStart = 0
        Me.NameTb.ShortcutsEnabled = True
        Me.NameTb.Size = New System.Drawing.Size(278, 23)
        Me.NameTb.TabIndex = 2
        '
        'DescriptionLb
        '
        Me.DescriptionLb.AutoSize = True
        Me.DescriptionLb.Location = New System.Drawing.Point(19, 61)
        Me.DescriptionLb.Name = "DescriptionLb"
        Me.DescriptionLb.Size = New System.Drawing.Size(77, 19)
        Me.DescriptionLb.TabIndex = 1
        Me.DescriptionLb.Text = "Description:"
        '
        'NameLb
        '
        Me.NameLb.AutoSize = True
        Me.NameLb.Location = New System.Drawing.Point(19, 32)
        Me.NameLb.Name = "NameLb"
        Me.NameLb.Size = New System.Drawing.Size(48, 19)
        Me.NameLb.TabIndex = 0
        Me.NameLb.Text = "Name:"
        '
        'IconTabPage
        '
        Me.IconTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.IconTabPage.Controls.Add(Me.IconListView)
        Me.IconTabPage.Location = New System.Drawing.Point(4, 38)
        Me.IconTabPage.Name = "IconTabPage"
        Me.IconTabPage.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.IconTabPage.Size = New System.Drawing.Size(607, 230)
        Me.IconTabPage.TabIndex = 2
        Me.IconTabPage.Text = "Template Icon "
        '
        'IconListView
        '
        Me.IconListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.IconListView.AllColumns.Add(Me.NameColumn)
        Me.IconListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IconListView.CellEditUseWholeCell = False
        Me.IconListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn})
        Me.IconListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.IconListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconListView.EmptyListMsg = "No Results"
        Me.IconListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconListView.FullRowSelect = True
        Me.IconListView.HeaderUsesThemes = True
        Me.IconListView.HideSelection = False
        Me.IconListView.IncludeColumnHeadersInCopy = True
        Me.IconListView.Location = New System.Drawing.Point(0, 12)
        Me.IconListView.Name = "IconListView"
        Me.IconListView.OwnerDraw = False
        Me.IconListView.RowHeight = 21
        Me.IconListView.ShowGroups = False
        Me.IconListView.Size = New System.Drawing.Size(607, 218)
        Me.IconListView.TabIndex = 0
        Me.IconListView.UseCompatibleStateImageBehavior = False
        Me.IconListView.UseExplorerTheme = True
        Me.IconListView.UseFiltering = True
        Me.IconListView.UseHotControls = False
        Me.IconListView.UseNotifyPropertyChanged = True
        Me.IconListView.View = System.Windows.Forms.View.Tile
        '
        'NameColumn
        '
        Me.NameColumn.AspectName = "DisplayName"
        Me.NameColumn.FillsFreeSpace = True
        Me.NameColumn.Text = "Icon"
        '
        'BackPl
        '
        Me.BackPl.BackColor = System.Drawing.SystemColors.Window
        Me.BackPl.Controls.Add(Me.Setup)
        Me.BackPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackPl.Location = New System.Drawing.Point(0, 0)
        Me.BackPl.Name = "BackPl"
        Me.BackPl.Padding = New System.Windows.Forms.Padding(8)
        Me.BackPl.Size = New System.Drawing.Size(631, 288)
        Me.BackPl.TabIndex = 3
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.Controls.Add(Me.CnBt)
        Me.ControlFooterPl1.Controls.Add(Me.OKBt)
        Me.ControlFooterPl1.Controls.Add(Me.AcceptBn)
        Me.ControlFooterPl1.Controls.Add(Me.CancelBn)
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 288)
        Me.ControlFooterPl1.MaximumSize = New System.Drawing.Size(0, 48)
        Me.ControlFooterPl1.MinimumSize = New System.Drawing.Size(0, 48)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(631, 48)
        Me.ControlFooterPl1.TabIndex = 2
        '
        'CnBt
        '
        Me.CnBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CnBt.Location = New System.Drawing.Point(544, 13)
        Me.CnBt.Name = "CnBt"
        Me.CnBt.Size = New System.Drawing.Size(75, 23)
        Me.CnBt.TabIndex = 6
        Me.CnBt.Text = "Cancel"
        '
        'OKBt
        '
        Me.OKBt.Location = New System.Drawing.Point(463, 13)
        Me.OKBt.Name = "OKBt"
        Me.OKBt.Size = New System.Drawing.Size(75, 23)
        Me.OKBt.TabIndex = 5
        Me.OKBt.Text = "OK"
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(10559, 13)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 4
        Me.AcceptBn.Text = "Accept"
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(10640, 13)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 3
        Me.CancelBn.Text = "cancel"
        '
        'FormNewTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 336)
        Me.Controls.Add(Me.BackPl)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNewTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New User Template"
        Me.Setup.ResumeLayout(False)
        Me.BasicTabPage.ResumeLayout(False)
        Me.DetailsGPl.ResumeLayout(False)
        Me.DetailsGPl.PerformLayout()
        CType(Me.LogoPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IconTabPage.ResumeLayout(False)
        CType(Me.IconListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackPl.ResumeLayout(False)
        Me.ControlFooterPl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Setup As Controls.MetroTabControl
    Friend WithEvents BasicTabPage As Controls.MetroTabPage
    Friend WithEvents DetailsGPl As GroupBox
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
    Friend WithEvents BackPl As Panel
    Friend WithEvents AcceptBn As Button
    Friend WithEvents CancelBn As Button
    Friend WithEvents LogoPb As PictureBox
    Friend WithEvents DescriptionTb As SimpleAD.ControlTextBox
    Friend WithEvents NameTb As SimpleAD.ControlTextBox
    Friend WithEvents DescriptionLb As Label
    Friend WithEvents NameLb As Label
    Friend WithEvents CnBt As Button
    Friend WithEvents OKBt As Button
    Friend WithEvents IDLb As Label
    Friend WithEvents IDTb As SimpleAD.ControlTextBox
    Friend WithEvents AuthorValLb As Label
    Friend WithEvents AuthorLb As Label
    Friend WithEvents IconTabPage As TabPage
    Friend WithEvents IconListView As ControlDomainListView
    Friend WithEvents NameColumn As OLVColumn
End Class
