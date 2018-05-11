Imports System.Windows.Forms
Imports BrightIdeasSoftware
Imports MetroFramework
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormImport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImport))
        Me.ImagePl = New System.Windows.Forms.Panel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.UsernameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PasswordCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ControlFooterPl = New System.Windows.Forms.Panel()
        Me.ExportBn = New System.Windows.Forms.Button()
        Me.BackBn = New System.Windows.Forms.Button()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.ControlSplitConatiner = New SimpleAD.ControlSplitConatiner()
        Me.ProgressLink = New System.Windows.Forms.LinkLabel()
        Me.PreferencesLink = New System.Windows.Forms.LinkLabel()
        Me.LocationLink = New System.Windows.Forms.LinkLabel()
        Me.PreviewLink = New System.Windows.Forms.LinkLabel()
        Me.MainTabControl = New SimpleAD.CustomTabControlNoHeaders()
        Me.WelcomeTab = New System.Windows.Forms.TabPage()
        Me.MenuFlow = New SimpleAD.ControlFlowLayoutPanel()
        Me.PreviewTab = New System.Windows.Forms.TabPage()
        Me.ContentPl = New System.Windows.Forms.Panel()
        Me.SearchTb = New SimpleAD.ControlTextBox()
        Me.MainListView = New SimpleAD.ControlCustomListView()
        Me.NameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DisplayNameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DomainTab = New System.Windows.Forms.TabPage()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.OptionsTab = New System.Windows.Forms.TabPage()
        Me.EnAcTg = New MetroFramework.Controls.MetroToggle()
        Me.EnAcLb = New System.Windows.Forms.Label()
        Me.CrHfldrLb = New System.Windows.Forms.Label()
        Me.CrHfldrTg = New MetroFramework.Controls.MetroToggle()
        Me.FpwdTg = New MetroFramework.Controls.MetroToggle()
        Me.FpwdLb = New System.Windows.Forms.Label()
        Me.ProgressTab = New System.Windows.Forms.TabPage()
        Me.MainProgressLb = New System.Windows.Forms.Label()
        Me.MainProgresBar = New System.Windows.Forms.ProgressBar()
        Me.ResultsTab = New System.Windows.Forms.TabPage()
        Me.DropDownFilter = New System.Windows.Forms.ComboBox()
        Me.FilterTb = New SimpleAD.ControlTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InfoBox = New System.Windows.Forms.RichTextBox()
        Me.ResultsListView = New SimpleAD.ControlCustomListView()
        Me.ResNameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ResStatusCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ResInfoCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImagePl.SuspendLayout()
        Me.ControlFooterPl.SuspendLayout()
        CType(Me.ControlSplitConatiner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlSplitConatiner.Panel1.SuspendLayout()
        Me.ControlSplitConatiner.Panel2.SuspendLayout()
        Me.ControlSplitConatiner.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.WelcomeTab.SuspendLayout()
        Me.PreviewTab.SuspendLayout()
        Me.ContentPl.SuspendLayout()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DomainTab.SuspendLayout()
        Me.OptionsTab.SuspendLayout()
        Me.ProgressTab.SuspendLayout()
        Me.ResultsTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ResultsListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Window
        Me.ImagePl.Controls.Add(Me.TitleLb)
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(658, 56)
        Me.ImagePl.TabIndex = 7
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(49, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Title"
        '
        'UsernameCol
        '
        Me.UsernameCol.AspectName = "SAMAccountName"
        Me.UsernameCol.IsVisible = False
        Me.UsernameCol.Text = "Username"
        '
        'PasswordCol
        '
        Me.PasswordCol.AspectName = "Password"
        Me.PasswordCol.IsVisible = False
        Me.PasswordCol.Searchable = False
        Me.PasswordCol.Text = "Password"
        '
        'ControlFooterPl
        '
        Me.ControlFooterPl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl.Controls.Add(Me.ExportBn)
        Me.ControlFooterPl.Controls.Add(Me.BackBn)
        Me.ControlFooterPl.Controls.Add(Me.AcceptBn)
        Me.ControlFooterPl.Controls.Add(Me.CancelBn)
        Me.ControlFooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl.Location = New System.Drawing.Point(0, 403)
        Me.ControlFooterPl.MaximumSize = New System.Drawing.Size(0, 44)
        Me.ControlFooterPl.MinimumSize = New System.Drawing.Size(0, 44)
        Me.ControlFooterPl.Name = "ControlFooterPl"
        Me.ControlFooterPl.Size = New System.Drawing.Size(658, 44)
        Me.ControlFooterPl.TabIndex = 2
        '
        'ExportBn
        '
        Me.ExportBn.Location = New System.Drawing.Point(12, 9)
        Me.ExportBn.Name = "ExportBn"
        Me.ExportBn.Size = New System.Drawing.Size(101, 23)
        Me.ExportBn.TabIndex = 3
        Me.ExportBn.Text = "Export Results"
        Me.ExportBn.UseVisualStyleBackColor = True
        Me.ExportBn.Visible = False
        '
        'BackBn
        '
        Me.BackBn.Location = New System.Drawing.Point(383, 9)
        Me.BackBn.Name = "BackBn"
        Me.BackBn.Size = New System.Drawing.Size(75, 23)
        Me.BackBn.TabIndex = 2
        Me.BackBn.Text = "Previous"
        Me.BackBn.UseVisualStyleBackColor = True
        Me.BackBn.Visible = False
        '
        'AcceptBn
        '
        Me.AcceptBn.Location = New System.Drawing.Point(464, 9)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 1
        Me.AcceptBn.Text = "Next"
        Me.AcceptBn.UseVisualStyleBackColor = True
        Me.AcceptBn.Visible = False
        '
        'CancelBn
        '
        Me.CancelBn.Location = New System.Drawing.Point(571, 9)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 0
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'ControlSplitConatiner
        '
        Me.ControlSplitConatiner.BackColor = System.Drawing.SystemColors.Control
        Me.ControlSplitConatiner.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.ControlSplitConatiner.Location = New System.Drawing.Point(0, 57)
        Me.ControlSplitConatiner.Margin = New System.Windows.Forms.Padding(1)
        Me.ControlSplitConatiner.Name = "ControlSplitConatiner"
        '
        'ControlSplitConatiner.Panel1
        '
        Me.ControlSplitConatiner.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.ControlSplitConatiner.Panel1.Controls.Add(Me.ProgressLink)
        Me.ControlSplitConatiner.Panel1.Controls.Add(Me.PreferencesLink)
        Me.ControlSplitConatiner.Panel1.Controls.Add(Me.LocationLink)
        Me.ControlSplitConatiner.Panel1.Controls.Add(Me.PreviewLink)
        '
        'ControlSplitConatiner.Panel2
        '
        Me.ControlSplitConatiner.Panel2.Controls.Add(Me.MainTabControl)
        Me.ControlSplitConatiner.Size = New System.Drawing.Size(658, 345)
        Me.ControlSplitConatiner.SpliterHeight = 32
        Me.ControlSplitConatiner.SplitterDistance = 132
        Me.ControlSplitConatiner.TabIndex = 8
        '
        'ProgressLink
        '
        Me.ProgressLink.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue
        Me.ProgressLink.AutoSize = True
        Me.ProgressLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ProgressLink.LinkColor = System.Drawing.SystemColors.MenuText
        Me.ProgressLink.Location = New System.Drawing.Point(23, 160)
        Me.ProgressLink.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.ProgressLink.Name = "ProgressLink"
        Me.ProgressLink.Size = New System.Drawing.Size(48, 13)
        Me.ProgressLink.TabIndex = 3
        Me.ProgressLink.TabStop = True
        Me.ProgressLink.Text = "Progress"
        '
        'PreferencesLink
        '
        Me.PreferencesLink.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue
        Me.PreferencesLink.AutoSize = True
        Me.PreferencesLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferencesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.PreferencesLink.LinkColor = System.Drawing.SystemColors.MenuText
        Me.PreferencesLink.Location = New System.Drawing.Point(23, 131)
        Me.PreferencesLink.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.PreferencesLink.Name = "PreferencesLink"
        Me.PreferencesLink.Size = New System.Drawing.Size(96, 13)
        Me.PreferencesLink.TabIndex = 2
        Me.PreferencesLink.TabStop = True
        Me.PreferencesLink.Text = "Import Preferences"
        '
        'LocationLink
        '
        Me.LocationLink.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue
        Me.LocationLink.AutoSize = True
        Me.LocationLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LocationLink.LinkColor = System.Drawing.SystemColors.MenuText
        Me.LocationLink.Location = New System.Drawing.Point(23, 102)
        Me.LocationLink.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.LocationLink.Name = "LocationLink"
        Me.LocationLink.Size = New System.Drawing.Size(81, 13)
        Me.LocationLink.TabIndex = 1
        Me.LocationLink.TabStop = True
        Me.LocationLink.Text = "Select Location"
        '
        'PreviewLink
        '
        Me.PreviewLink.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue
        Me.PreviewLink.AutoSize = True
        Me.PreviewLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviewLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.PreviewLink.LinkColor = System.Drawing.SystemColors.MenuText
        Me.PreviewLink.Location = New System.Drawing.Point(23, 73)
        Me.PreviewLink.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.PreviewLink.Name = "PreviewLink"
        Me.PreviewLink.Size = New System.Drawing.Size(45, 13)
        Me.PreviewLink.TabIndex = 0
        Me.PreviewLink.TabStop = True
        Me.PreviewLink.Text = "Preview"
        '
        'MainTabControl
        '
        Me.MainTabControl.BackColor = System.Drawing.SystemColors.Control
        Me.MainTabControl.Controls.Add(Me.WelcomeTab)
        Me.MainTabControl.Controls.Add(Me.PreviewTab)
        Me.MainTabControl.Controls.Add(Me.DomainTab)
        Me.MainTabControl.Controls.Add(Me.OptionsTab)
        Me.MainTabControl.Controls.Add(Me.ProgressTab)
        Me.MainTabControl.Controls.Add(Me.ResultsTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainTabControl.HotTrackTabColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainTabControl.ItemSize = New System.Drawing.Size(62, 12)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.Padding = New System.Drawing.Point(0, 0)
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.SelectedTabColor = System.Drawing.SystemColors.ButtonShadow
        Me.MainTabControl.Size = New System.Drawing.Size(522, 345)
        Me.MainTabControl.TabColor = System.Drawing.SystemColors.ControlLight
        Me.MainTabControl.TabIndex = 3
        Me.MainTabControl.Tag = "Select an Option..."
        '
        'WelcomeTab
        '
        Me.WelcomeTab.Controls.Add(Me.MenuFlow)
        Me.WelcomeTab.Location = New System.Drawing.Point(0, 15)
        Me.WelcomeTab.Name = "WelcomeTab"
        Me.WelcomeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.WelcomeTab.Size = New System.Drawing.Size(522, 330)
        Me.WelcomeTab.TabIndex = 5
        Me.WelcomeTab.Tag = "Select an Option"
        Me.WelcomeTab.Text = "Welcome Tab"
        '
        'MenuFlow
        '
        Me.MenuFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MenuFlow.Location = New System.Drawing.Point(24, 52)
        Me.MenuFlow.Name = "MenuFlow"
        Me.MenuFlow.Size = New System.Drawing.Size(441, 251)
        Me.MenuFlow.TabIndex = 0
        '
        'PreviewTab
        '
        Me.PreviewTab.Controls.Add(Me.ContentPl)
        Me.PreviewTab.Location = New System.Drawing.Point(0, 15)
        Me.PreviewTab.Name = "PreviewTab"
        Me.PreviewTab.Size = New System.Drawing.Size(522, 330)
        Me.PreviewTab.TabIndex = 0
        Me.PreviewTab.Text = "PreviewTab"
        Me.PreviewTab.UseVisualStyleBackColor = True
        '
        'ContentPl
        '
        Me.ContentPl.BackColor = System.Drawing.SystemColors.Control
        Me.ContentPl.Controls.Add(Me.SearchTb)
        Me.ContentPl.Controls.Add(Me.MainListView)
        Me.ContentPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPl.Location = New System.Drawing.Point(0, 0)
        Me.ContentPl.Name = "ContentPl"
        Me.ContentPl.Size = New System.Drawing.Size(522, 330)
        Me.ContentPl.TabIndex = 4
        '
        'SearchTb
        '
        Me.SearchTb.Location = New System.Drawing.Point(12, 8)
        Me.SearchTb.Name = "SearchTb"
        Me.SearchTb.PromptText = "Search"
        Me.SearchTb.Size = New System.Drawing.Size(470, 20)
        Me.SearchTb.TabIndex = 4
        '
        'MainListView
        '
        Me.MainListView.AllColumns.Add(Me.NameCol)
        Me.MainListView.AllColumns.Add(Me.DescCol)
        Me.MainListView.AllColumns.Add(Me.DisplayNameCol)
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameCol, Me.DescCol, Me.DisplayNameCol})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.EmptyListMsg = "Empty"
        Me.MainListView.EmptyListMsgFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HeaderFormatStyle.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(12, 40)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.RowHeight = 21
        Me.MainListView.ShowGroups = False
        Me.MainListView.Size = New System.Drawing.Size(470, 288)
        Me.MainListView.TabIndex = 3
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseFiltering = True
        Me.MainListView.UseHotControls = False
        Me.MainListView.UseHotItem = True
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'NameCol
        '
        Me.NameCol.AspectName = "Name"
        Me.NameCol.Text = "Name"
        Me.NameCol.Width = 108
        '
        'DescCol
        '
        Me.DescCol.AspectName = "Description"
        Me.DescCol.Text = "Description"
        Me.DescCol.Width = 123
        '
        'DisplayNameCol
        '
        Me.DisplayNameCol.AspectName = "DisplayName"
        Me.DisplayNameCol.FillsFreeSpace = True
        Me.DisplayNameCol.Text = "Display Name"
        Me.DisplayNameCol.Width = 150
        '
        'DomainTab
        '
        Me.DomainTab.BackColor = System.Drawing.SystemColors.Control
        Me.DomainTab.Controls.Add(Me.DomainTreeView)
        Me.DomainTab.Location = New System.Drawing.Point(0, 15)
        Me.DomainTab.Name = "DomainTab"
        Me.DomainTab.Size = New System.Drawing.Size(522, 330)
        Me.DomainTab.TabIndex = 1
        Me.DomainTab.Text = "DomainTab"
        '
        'DomainTreeView
        '
        Me.DomainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DomainTreeView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTreeView.FullRowSelect = True
        Me.DomainTreeView.HideSelection = False
        Me.DomainTreeView.HotTracking = True
        Me.DomainTreeView.ImageIndex = 0
        Me.DomainTreeView.ItemHeight = 22
        Me.DomainTreeView.LabelEdit = True
        Me.DomainTreeView.Location = New System.Drawing.Point(12, 40)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedItem = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(470, 288)
        Me.DomainTreeView.TabIndex = 7
        '
        'OptionsTab
        '
        Me.OptionsTab.BackColor = System.Drawing.SystemColors.Control
        Me.OptionsTab.Controls.Add(Me.EnAcTg)
        Me.OptionsTab.Controls.Add(Me.EnAcLb)
        Me.OptionsTab.Controls.Add(Me.CrHfldrLb)
        Me.OptionsTab.Controls.Add(Me.CrHfldrTg)
        Me.OptionsTab.Controls.Add(Me.FpwdTg)
        Me.OptionsTab.Controls.Add(Me.FpwdLb)
        Me.OptionsTab.Location = New System.Drawing.Point(0, 15)
        Me.OptionsTab.Name = "OptionsTab"
        Me.OptionsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.OptionsTab.Size = New System.Drawing.Size(522, 330)
        Me.OptionsTab.TabIndex = 2
        Me.OptionsTab.Text = "OptionsTab"
        '
        'EnAcTg
        '
        Me.EnAcTg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnAcTg.AutoSize = True
        Me.EnAcTg.BackColor = System.Drawing.SystemColors.Control
        Me.EnAcTg.Checked = True
        Me.EnAcTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnAcTg.Location = New System.Drawing.Point(65, 104)
        Me.EnAcTg.Name = "EnAcTg"
        Me.EnAcTg.Size = New System.Drawing.Size(80, 17)
        Me.EnAcTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.EnAcTg.TabIndex = 19
        Me.EnAcTg.Text = "On"
        Me.EnAcTg.UseCustomBackColor = True
        Me.EnAcTg.UseSelectable = True
        '
        'EnAcLb
        '
        Me.EnAcLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnAcLb.AutoSize = True
        Me.EnAcLb.BackColor = System.Drawing.SystemColors.Control
        Me.EnAcLb.Location = New System.Drawing.Point(151, 106)
        Me.EnAcLb.Name = "EnAcLb"
        Me.EnAcLb.Size = New System.Drawing.Size(145, 13)
        Me.EnAcLb.TabIndex = 20
        Me.EnAcLb.Text = "Enable &Accounts on Creation"
        '
        'CrHfldrLb
        '
        Me.CrHfldrLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrHfldrLb.AutoSize = True
        Me.CrHfldrLb.BackColor = System.Drawing.SystemColors.Control
        Me.CrHfldrLb.Location = New System.Drawing.Point(151, 79)
        Me.CrHfldrLb.Name = "CrHfldrLb"
        Me.CrHfldrLb.Size = New System.Drawing.Size(106, 13)
        Me.CrHfldrLb.TabIndex = 18
        Me.CrHfldrLb.Text = "Create &Home Folders"
        '
        'CrHfldrTg
        '
        Me.CrHfldrTg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrHfldrTg.AutoSize = True
        Me.CrHfldrTg.BackColor = System.Drawing.SystemColors.Control
        Me.CrHfldrTg.Checked = True
        Me.CrHfldrTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CrHfldrTg.Location = New System.Drawing.Point(65, 77)
        Me.CrHfldrTg.Name = "CrHfldrTg"
        Me.CrHfldrTg.Size = New System.Drawing.Size(80, 17)
        Me.CrHfldrTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.CrHfldrTg.TabIndex = 17
        Me.CrHfldrTg.Text = "On"
        Me.CrHfldrTg.UseCustomBackColor = True
        Me.CrHfldrTg.UseSelectable = True
        '
        'FpwdTg
        '
        Me.FpwdTg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FpwdTg.AutoSize = True
        Me.FpwdTg.BackColor = System.Drawing.SystemColors.Control
        Me.FpwdTg.Checked = True
        Me.FpwdTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FpwdTg.Location = New System.Drawing.Point(65, 52)
        Me.FpwdTg.Name = "FpwdTg"
        Me.FpwdTg.Size = New System.Drawing.Size(80, 17)
        Me.FpwdTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.FpwdTg.TabIndex = 15
        Me.FpwdTg.Text = "On"
        Me.FpwdTg.UseCustomBackColor = True
        Me.FpwdTg.UseSelectable = True
        '
        'FpwdLb
        '
        Me.FpwdLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FpwdLb.AutoSize = True
        Me.FpwdLb.BackColor = System.Drawing.SystemColors.Control
        Me.FpwdLb.Location = New System.Drawing.Point(151, 52)
        Me.FpwdLb.Name = "FpwdLb"
        Me.FpwdLb.Size = New System.Drawing.Size(180, 13)
        Me.FpwdLb.TabIndex = 16
        Me.FpwdLb.Text = "&Force Password Reset on First Login"
        '
        'ProgressTab
        '
        Me.ProgressTab.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressTab.Controls.Add(Me.MainProgressLb)
        Me.ProgressTab.Controls.Add(Me.MainProgresBar)
        Me.ProgressTab.Location = New System.Drawing.Point(0, 15)
        Me.ProgressTab.Name = "ProgressTab"
        Me.ProgressTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProgressTab.Size = New System.Drawing.Size(522, 330)
        Me.ProgressTab.TabIndex = 3
        Me.ProgressTab.Text = "ProgressTab"
        '
        'MainProgressLb
        '
        Me.MainProgressLb.AutoSize = True
        Me.MainProgressLb.Location = New System.Drawing.Point(12, 300)
        Me.MainProgressLb.Name = "MainProgressLb"
        Me.MainProgressLb.Size = New System.Drawing.Size(56, 13)
        Me.MainProgressLb.TabIndex = 2
        Me.MainProgressLb.Text = "Working..."
        '
        'MainProgresBar
        '
        Me.MainProgresBar.Location = New System.Drawing.Point(12, 270)
        Me.MainProgresBar.Name = "MainProgresBar"
        Me.MainProgresBar.Size = New System.Drawing.Size(470, 23)
        Me.MainProgresBar.TabIndex = 0
        '
        'ResultsTab
        '
        Me.ResultsTab.BackColor = System.Drawing.SystemColors.Control
        Me.ResultsTab.Controls.Add(Me.DropDownFilter)
        Me.ResultsTab.Controls.Add(Me.FilterTb)
        Me.ResultsTab.Controls.Add(Me.Panel1)
        Me.ResultsTab.Controls.Add(Me.ResultsListView)
        Me.ResultsTab.Location = New System.Drawing.Point(0, 15)
        Me.ResultsTab.Name = "ResultsTab"
        Me.ResultsTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.ResultsTab.Size = New System.Drawing.Size(522, 330)
        Me.ResultsTab.TabIndex = 4
        Me.ResultsTab.Text = "Results Tab"
        '
        'DropDownFilter
        '
        Me.DropDownFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DropDownFilter.FormattingEnabled = True
        Me.DropDownFilter.ItemHeight = 13
        Me.DropDownFilter.Items.AddRange(New Object() {"All", "Completed", "With Errors", "Failed"})
        Me.DropDownFilter.Location = New System.Drawing.Point(332, 8)
        Me.DropDownFilter.Name = "DropDownFilter"
        Me.DropDownFilter.Size = New System.Drawing.Size(149, 21)
        Me.DropDownFilter.TabIndex = 4
        '
        'FilterTb
        '
        Me.FilterTb.Location = New System.Drawing.Point(12, 8)
        Me.FilterTb.Name = "FilterTb"
        Me.FilterTb.PromptText = "Search"
        Me.FilterTb.Size = New System.Drawing.Size(314, 20)
        Me.FilterTb.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.InfoBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 48)
        Me.Panel1.TabIndex = 2
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfoBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoBox.HideSelection = False
        Me.InfoBox.Location = New System.Drawing.Point(0, 0)
        Me.InfoBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.ReadOnly = True
        Me.InfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.InfoBox.Size = New System.Drawing.Size(468, 46)
        Me.InfoBox.TabIndex = 1
        Me.InfoBox.Text = ""
        '
        'ResultsListView
        '
        Me.ResultsListView.AllColumns.Add(Me.ResNameCol)
        Me.ResultsListView.AllColumns.Add(Me.UsernameCol)
        Me.ResultsListView.AllColumns.Add(Me.PasswordCol)
        Me.ResultsListView.AllColumns.Add(Me.ResStatusCol)
        Me.ResultsListView.AllColumns.Add(Me.ResInfoCol)
        Me.ResultsListView.CellEditUseWholeCell = False
        Me.ResultsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ResNameCol, Me.ResStatusCol, Me.ResInfoCol})
        Me.ResultsListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResultsListView.FullRowSelect = True
        Me.ResultsListView.HeaderFormatStyle.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsListView.HideSelection = False
        Me.ResultsListView.Location = New System.Drawing.Point(12, 40)
        Me.ResultsListView.MultiSelect = False
        Me.ResultsListView.Name = "ResultsListView"
        Me.ResultsListView.RowHeight = 21
        Me.ResultsListView.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ResultsListView.SelectedForeColor = System.Drawing.Color.White
        Me.ResultsListView.ShowGroups = False
        Me.ResultsListView.ShowHeaderInAllViews = False
        Me.ResultsListView.Size = New System.Drawing.Size(470, 236)
        Me.ResultsListView.TabIndex = 0
        Me.ResultsListView.UseCompatibleStateImageBehavior = False
        Me.ResultsListView.UseFiltering = True
        Me.ResultsListView.UseHotItem = True
        Me.ResultsListView.View = System.Windows.Forms.View.Details
        '
        'ResNameCol
        '
        Me.ResNameCol.AspectName = "Name"
        Me.ResNameCol.Text = "Name"
        Me.ResNameCol.Width = 148
        '
        'ResStatusCol
        '
        Me.ResStatusCol.AspectName = "Meta"
        Me.ResStatusCol.Text = "Status"
        Me.ResStatusCol.Width = 111
        '
        'ResInfoCol
        '
        Me.ResInfoCol.AspectName = "Errors"
        Me.ResInfoCol.FillsFreeSpace = True
        Me.ResInfoCol.Text = "Info"
        Me.ResInfoCol.Width = 167
        '
        'FormImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(658, 447)
        Me.Controls.Add(Me.ControlSplitConatiner)
        Me.Controls.Add(Me.ControlFooterPl)
        Me.Controls.Add(Me.ImagePl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Import Wizard"
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ControlFooterPl.ResumeLayout(False)
        Me.ControlSplitConatiner.Panel1.ResumeLayout(False)
        Me.ControlSplitConatiner.Panel1.PerformLayout()
        Me.ControlSplitConatiner.Panel2.ResumeLayout(False)
        CType(Me.ControlSplitConatiner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlSplitConatiner.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.WelcomeTab.ResumeLayout(False)
        Me.PreviewTab.ResumeLayout(False)
        Me.ContentPl.ResumeLayout(False)
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DomainTab.ResumeLayout(False)
        Me.OptionsTab.ResumeLayout(False)
        Me.OptionsTab.PerformLayout()
        Me.ProgressTab.ResumeLayout(False)
        Me.ProgressTab.PerformLayout()
        Me.ResultsTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ResultsListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ControlFooterPl As Panel
    Friend WithEvents MainTabControl As CustomTabControlNoHeaders
    Friend WithEvents DomainTab As TabPage
    Friend WithEvents PreviewTab As TabPage
    Friend WithEvents ContentPl As Panel
    Friend WithEvents AcceptBn As Button
    Friend WithEvents CancelBn As Button
    Friend WithEvents BackBn As Button
    Friend WithEvents MainListView As ControlCustomListView
    Friend WithEvents NameCol As OLVColumn
    Friend WithEvents DescCol As OLVColumn
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents ImagePl As Panel
    Friend WithEvents OptionsTab As TabPage
    Friend WithEvents EnAcLb As Label
    Friend WithEvents EnAcTg As Controls.MetroToggle
    Friend WithEvents CrHfldrLb As Label
    Friend WithEvents CrHfldrTg As Controls.MetroToggle
    Friend WithEvents FpwdTg As Controls.MetroToggle
    Friend WithEvents FpwdLb As Label
    Friend WithEvents ProgressTab As TabPage
    Friend WithEvents MainProgressLb As Label
    Friend WithEvents MainProgresBar As ProgressBar
    Friend WithEvents ControlSplitConatiner As ControlSplitConatiner
    Friend WithEvents ProgressLink As LinkLabel
    Friend WithEvents PreferencesLink As LinkLabel
    Friend WithEvents LocationLink As LinkLabel
    Friend WithEvents PreviewLink As LinkLabel
    Friend WithEvents ResultsTab As TabPage
    Friend WithEvents ResultsListView As ControlCustomListView
    Friend WithEvents DisplayNameCol As OLVColumn
    Friend WithEvents ResNameCol As OLVColumn
    Friend WithEvents ResStatusCol As OLVColumn
    Friend WithEvents InfoBox As RichTextBox
    Friend WithEvents ResInfoCol As OLVColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FilterTb As SimpleAD.ControlTextBox
    Friend WithEvents DropDownFilter As ComboBox
    Friend WithEvents SearchTb As SimpleAD.ControlTextBox
    Friend WithEvents UsernameCol As OLVColumn
    Friend WithEvents PasswordCol As OLVColumn
    Friend WithEvents ExportBn As Button
    Friend WithEvents WelcomeTab As TabPage
    Friend WithEvents MenuFlow As ControlFlowLayoutPanel
    Friend WithEvents TitleLb As Label
End Class
