Imports System.Windows.Forms
Imports MetroFramework
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBulkUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBulkUser))
        Me.ToolTip = New MetroFramework.Components.MetroToolTip()
        Me.NumberBn = New System.Windows.Forms.Button()
        Me.StringDragBn = New System.Windows.Forms.Button()
        Me.FooterPl = New SimpleAD.ControlFooterPl()
        Me.PreviewBn = New System.Windows.Forms.Button()
        Me.ImagePl = New System.Windows.Forms.Panel()
        Me.MainTabControl = New SimpleAD.CustomTabControlNoHeaders()
        Me.InputTab = New System.Windows.Forms.TabPage()
        Me.ValidateBn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SnTb = New SimpleAD.ControlTextBox()
        Me.FnTb = New SimpleAD.ControlTextBox()
        Me.UsernameConTab = New System.Windows.Forms.TabPage()
        Me.NumberComboBox = New System.Windows.Forms.ComboBox()
        Me.StringDragTb = New SimpleAD.ControlTextBox()
        Me.MainUnPreview = New System.Windows.Forms.Label()
        Me.PreviewFlavorLb = New System.Windows.Forms.Label()
        Me.Sn1DragBn = New System.Windows.Forms.Button()
        Me.Fn1DragBn = New System.Windows.Forms.Button()
        Me.SnDragBn = New System.Windows.Forms.Button()
        Me.FnDragBn = New System.Windows.Forms.Button()
        Me.MainFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.ControlHeaderPanel2 = New SimpleAD.ControlFooterPl()
        Me.PropertiesTab = New System.Windows.Forms.TabPage()
        Me.GroupBn = New System.Windows.Forms.Button()
        Me.GroupLb = New System.Windows.Forms.Label()
        Me.GroupListBox = New System.Windows.Forms.ListBox()
        Me.MetroLabel1 = New System.Windows.Forms.Label()
        Me.MetroTextBox2 = New SimpleAD.ControlTextBox()
        Me.PagerLb = New System.Windows.Forms.Label()
        Me.PagerTb = New SimpleAD.ControlTextBox()
        Me.DescriptionLb = New System.Windows.Forms.Label()
        Me.MetroTextBox1 = New SimpleAD.ControlTextBox()
        Me.LogonScriptLb = New System.Windows.Forms.Label()
        Me.LogonScriptTb = New SimpleAD.ControlTextBox()
        Me.HomeDriveLb = New System.Windows.Forms.Label()
        Me.HomeDriveCombo = New System.Windows.Forms.ComboBox()
        Me.ProfilePathLb = New System.Windows.Forms.Label()
        Me.HomeFolderLb = New System.Windows.Forms.Label()
        Me.ProfilePathBn = New System.Windows.Forms.Button()
        Me.HomeFolderBn = New System.Windows.Forms.Button()
        Me.ProfilePathTb = New SimpleAD.ControlTextBox()
        Me.HomeFolderTb = New SimpleAD.ControlTextBox()
        Me.ControlHeaderPanel3 = New SimpleAD.ControlFooterPl()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.FooterPl.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.InputTab.SuspendLayout()
        Me.UsernameConTab.SuspendLayout()
        Me.PropertiesTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTip.StyleManager = Nothing
        Me.ToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'NumberBn
        '
        Me.NumberBn.Location = New System.Drawing.Point(375, 105)
        Me.NumberBn.Name = "NumberBn"
        Me.NumberBn.Size = New System.Drawing.Size(150, 23)
        Me.NumberBn.TabIndex = 11
        Me.NumberBn.Text = "Number"
        Me.ToolTip.SetToolTip(Me.NumberBn, "Adds a dynamic number to the username based on if usernames that are current pres" &
        "ent in active directory")
        '
        'StringDragBn
        '
        Me.StringDragBn.Location = New System.Drawing.Point(219, 105)
        Me.StringDragBn.Name = "StringDragBn"
        Me.StringDragBn.Size = New System.Drawing.Size(150, 23)
        Me.StringDragBn.TabIndex = 9
        Me.StringDragBn.Text = "String"
        Me.ToolTip.SetToolTip(Me.StringDragBn, "Allows a custom string to be inserted into a username")
        '
        'FooterPl
        '
        Me.FooterPl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.FooterPl.Controls.Add(Me.AcceptBn)
        Me.FooterPl.Controls.Add(Me.CancelBn)
        Me.FooterPl.Controls.Add(Me.PreviewBn)
        Me.FooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPl.Location = New System.Drawing.Point(0, 345)
        Me.FooterPl.MaximumSize = New System.Drawing.Size(0, 48)
        Me.FooterPl.Name = "FooterPl"
        Me.FooterPl.Size = New System.Drawing.Size(640, 48)
        Me.FooterPl.TabIndex = 3
        '
        'PreviewBn
        '
        Me.PreviewBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviewBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PreviewBn.Location = New System.Drawing.Point(15, 13)
        Me.PreviewBn.Name = "PreviewBn"
        Me.PreviewBn.Size = New System.Drawing.Size(108, 23)
        Me.PreviewBn.TabIndex = 4
        Me.PreviewBn.Text = "Preview Users"
        Me.PreviewBn.UseVisualStyleBackColor = True
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Control
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.Margin = New System.Windows.Forms.Padding(0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 44)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(640, 56)
        Me.ImagePl.TabIndex = 8
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.InputTab)
        Me.MainTabControl.Controls.Add(Me.UsernameConTab)
        Me.MainTabControl.Controls.Add(Me.PropertiesTab)
        Me.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.HotTrackTabColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.MainTabControl.ItemSize = New System.Drawing.Size(62, 0)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 56)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.SelectedTabColor = System.Drawing.SystemColors.ButtonFace
        Me.MainTabControl.Size = New System.Drawing.Size(640, 289)
        Me.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MainTabControl.TabColor = System.Drawing.SystemColors.Window
        Me.MainTabControl.TabIndex = 2
        '
        'InputTab
        '
        Me.InputTab.Controls.Add(Me.ValidateBn)
        Me.InputTab.Controls.Add(Me.Label3)
        Me.InputTab.Controls.Add(Me.Label2)
        Me.InputTab.Controls.Add(Me.Label1)
        Me.InputTab.Controls.Add(Me.SnTb)
        Me.InputTab.Controls.Add(Me.FnTb)
        Me.InputTab.Location = New System.Drawing.Point(0, 3)
        Me.InputTab.Name = "InputTab"
        Me.InputTab.Size = New System.Drawing.Size(640, 286)
        Me.InputTab.TabIndex = 0
        Me.InputTab.Text = "Data Input"
        '
        'ValidateBn
        '
        Me.ValidateBn.Location = New System.Drawing.Point(15, 221)
        Me.ValidateBn.Name = "ValidateBn"
        Me.ValidateBn.Size = New System.Drawing.Size(75, 23)
        Me.ValidateBn.TabIndex = 7
        Me.ValidateBn.Text = "Validate"
        Me.ValidateBn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(325, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(15, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Firstname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Paste the names of the users you want to import into the input fiels below. Then " &
    "click Next."
        '
        'SnTb
        '
        Me.SnTb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SnTb.Location = New System.Drawing.Point(328, 72)
        Me.SnTb.Multiline = True
        Me.SnTb.Name = "SnTb"
        Me.SnTb.PromptText = Nothing
        Me.SnTb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.SnTb.Size = New System.Drawing.Size(300, 143)
        Me.SnTb.TabIndex = 8
        '
        'FnTb
        '
        Me.FnTb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FnTb.Location = New System.Drawing.Point(15, 72)
        Me.FnTb.Multiline = True
        Me.FnTb.Name = "FnTb"
        Me.FnTb.PromptText = Nothing
        Me.FnTb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.FnTb.Size = New System.Drawing.Size(296, 143)
        Me.FnTb.TabIndex = 7
        '
        'UsernameConTab
        '
        Me.UsernameConTab.BackColor = System.Drawing.SystemColors.Window
        Me.UsernameConTab.Controls.Add(Me.NumberComboBox)
        Me.UsernameConTab.Controls.Add(Me.NumberBn)
        Me.UsernameConTab.Controls.Add(Me.StringDragTb)
        Me.UsernameConTab.Controls.Add(Me.StringDragBn)
        Me.UsernameConTab.Controls.Add(Me.MainUnPreview)
        Me.UsernameConTab.Controls.Add(Me.PreviewFlavorLb)
        Me.UsernameConTab.Controls.Add(Me.Sn1DragBn)
        Me.UsernameConTab.Controls.Add(Me.Fn1DragBn)
        Me.UsernameConTab.Controls.Add(Me.SnDragBn)
        Me.UsernameConTab.Controls.Add(Me.FnDragBn)
        Me.UsernameConTab.Controls.Add(Me.MainFlow)
        Me.UsernameConTab.Controls.Add(Me.ControlHeaderPanel2)
        Me.UsernameConTab.Location = New System.Drawing.Point(0, 3)
        Me.UsernameConTab.Name = "UsernameConTab"
        Me.UsernameConTab.Size = New System.Drawing.Size(640, 286)
        Me.UsernameConTab.TabIndex = 1
        Me.UsernameConTab.Text = "Username Constructor"
        '
        'NumberComboBox
        '
        Me.NumberComboBox.FormattingEnabled = True
        Me.NumberComboBox.ItemHeight = 13
        Me.NumberComboBox.Items.AddRange(New Object() {"1", "01", "001"})
        Me.NumberComboBox.Location = New System.Drawing.Point(375, 133)
        Me.NumberComboBox.Name = "NumberComboBox"
        Me.NumberComboBox.Size = New System.Drawing.Size(150, 21)
        Me.NumberComboBox.TabIndex = 13
        '
        'StringDragTb
        '
        Me.StringDragTb.Location = New System.Drawing.Point(219, 133)
        Me.StringDragTb.Name = "StringDragTb"
        Me.StringDragTb.PromptText = "Enter String..."
        Me.StringDragTb.Size = New System.Drawing.Size(150, 20)
        Me.StringDragTb.TabIndex = 10
        '
        'MainUnPreview
        '
        Me.MainUnPreview.AutoSize = True
        Me.MainUnPreview.BackColor = System.Drawing.SystemColors.Window
        Me.MainUnPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainUnPreview.Location = New System.Drawing.Point(15, 201)
        Me.MainUnPreview.Name = "MainUnPreview"
        Me.MainUnPreview.Size = New System.Drawing.Size(96, 13)
        Me.MainUnPreview.TabIndex = 8
        Me.MainUnPreview.Text = "Username Preview"
        '
        'PreviewFlavorLb
        '
        Me.PreviewFlavorLb.AutoSize = True
        Me.PreviewFlavorLb.BackColor = System.Drawing.SystemColors.Window
        Me.PreviewFlavorLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PreviewFlavorLb.Location = New System.Drawing.Point(15, 173)
        Me.PreviewFlavorLb.Name = "PreviewFlavorLb"
        Me.PreviewFlavorLb.Size = New System.Drawing.Size(59, 13)
        Me.PreviewFlavorLb.TabIndex = 7
        Me.PreviewFlavorLb.Text = "John Smith"
        '
        'Sn1DragBn
        '
        Me.Sn1DragBn.Location = New System.Drawing.Point(99, 134)
        Me.Sn1DragBn.Name = "Sn1DragBn"
        Me.Sn1DragBn.Size = New System.Drawing.Size(75, 23)
        Me.Sn1DragBn.TabIndex = 6
        Me.Sn1DragBn.Text = "Last Initial"
        '
        'Fn1DragBn
        '
        Me.Fn1DragBn.Location = New System.Drawing.Point(18, 134)
        Me.Fn1DragBn.Name = "Fn1DragBn"
        Me.Fn1DragBn.Size = New System.Drawing.Size(75, 23)
        Me.Fn1DragBn.TabIndex = 5
        Me.Fn1DragBn.Text = "First Initial"
        '
        'SnDragBn
        '
        Me.SnDragBn.Location = New System.Drawing.Point(99, 105)
        Me.SnDragBn.Name = "SnDragBn"
        Me.SnDragBn.Size = New System.Drawing.Size(75, 23)
        Me.SnDragBn.TabIndex = 4
        Me.SnDragBn.Text = "Surname"
        '
        'FnDragBn
        '
        Me.FnDragBn.Location = New System.Drawing.Point(18, 105)
        Me.FnDragBn.Name = "FnDragBn"
        Me.FnDragBn.Size = New System.Drawing.Size(75, 23)
        Me.FnDragBn.TabIndex = 3
        Me.FnDragBn.Text = "FirstName"
        '
        'MainFlow
        '
        Me.MainFlow.AllowDrop = True
        Me.MainFlow.AutoScroll = True
        Me.MainFlow.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainFlow.Location = New System.Drawing.Point(16, 38)
        Me.MainFlow.Name = "MainFlow"
        Me.MainFlow.Padding = New System.Windows.Forms.Padding(2)
        Me.MainFlow.Size = New System.Drawing.Size(606, 52)
        Me.MainFlow.TabIndex = 2
        '
        'ControlHeaderPanel2
        '
        Me.ControlHeaderPanel2.BackColor = System.Drawing.SystemColors.Window
        Me.ControlHeaderPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlHeaderPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ControlHeaderPanel2.Name = "ControlHeaderPanel2"
        Me.ControlHeaderPanel2.Size = New System.Drawing.Size(640, 286)
        Me.ControlHeaderPanel2.TabIndex = 14
        '
        'PropertiesTab
        '
        Me.PropertiesTab.BackColor = System.Drawing.SystemColors.Window
        Me.PropertiesTab.Controls.Add(Me.GroupBn)
        Me.PropertiesTab.Controls.Add(Me.GroupLb)
        Me.PropertiesTab.Controls.Add(Me.GroupListBox)
        Me.PropertiesTab.Controls.Add(Me.MetroLabel1)
        Me.PropertiesTab.Controls.Add(Me.MetroTextBox2)
        Me.PropertiesTab.Controls.Add(Me.PagerLb)
        Me.PropertiesTab.Controls.Add(Me.PagerTb)
        Me.PropertiesTab.Controls.Add(Me.DescriptionLb)
        Me.PropertiesTab.Controls.Add(Me.MetroTextBox1)
        Me.PropertiesTab.Controls.Add(Me.LogonScriptLb)
        Me.PropertiesTab.Controls.Add(Me.LogonScriptTb)
        Me.PropertiesTab.Controls.Add(Me.HomeDriveLb)
        Me.PropertiesTab.Controls.Add(Me.HomeDriveCombo)
        Me.PropertiesTab.Controls.Add(Me.ProfilePathLb)
        Me.PropertiesTab.Controls.Add(Me.HomeFolderLb)
        Me.PropertiesTab.Controls.Add(Me.ProfilePathBn)
        Me.PropertiesTab.Controls.Add(Me.HomeFolderBn)
        Me.PropertiesTab.Controls.Add(Me.ProfilePathTb)
        Me.PropertiesTab.Controls.Add(Me.HomeFolderTb)
        Me.PropertiesTab.Controls.Add(Me.ControlHeaderPanel3)
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 3)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(640, 286)
        Me.PropertiesTab.TabIndex = 2
        Me.PropertiesTab.Text = "Properties"
        '
        'GroupBn
        '
        Me.GroupBn.Location = New System.Drawing.Point(183, 111)
        Me.GroupBn.Name = "GroupBn"
        Me.GroupBn.Size = New System.Drawing.Size(34, 23)
        Me.GroupBn.TabIndex = 20
        Me.GroupBn.Text = "..."
        '
        'GroupLb
        '
        Me.GroupLb.AutoSize = True
        Me.GroupLb.BackColor = System.Drawing.SystemColors.Window
        Me.GroupLb.Location = New System.Drawing.Point(17, 111)
        Me.GroupLb.Name = "GroupLb"
        Me.GroupLb.Size = New System.Drawing.Size(96, 13)
        Me.GroupLb.TabIndex = 19
        Me.GroupLb.Text = "Group Membership"
        '
        'GroupListBox
        '
        Me.GroupListBox.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupListBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupListBox.FormattingEnabled = True
        Me.GroupListBox.ItemHeight = 15
        Me.GroupListBox.Location = New System.Drawing.Point(20, 140)
        Me.GroupListBox.Name = "GroupListBox"
        Me.GroupListBox.Size = New System.Drawing.Size(197, 79)
        Me.GroupListBox.TabIndex = 18
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.MetroLabel1.Location = New System.Drawing.Point(233, 196)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 13)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "RDS Profile Path"
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Location = New System.Drawing.Point(344, 196)
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PromptText = Nothing
        Me.MetroTextBox2.Size = New System.Drawing.Size(240, 20)
        Me.MetroTextBox2.TabIndex = 16
        '
        'PagerLb
        '
        Me.PagerLb.AutoSize = True
        Me.PagerLb.BackColor = System.Drawing.SystemColors.Window
        Me.PagerLb.Location = New System.Drawing.Point(233, 167)
        Me.PagerLb.Name = "PagerLb"
        Me.PagerLb.Size = New System.Drawing.Size(35, 13)
        Me.PagerLb.TabIndex = 15
        Me.PagerLb.Text = "Pager"
        '
        'PagerTb
        '
        Me.PagerTb.Location = New System.Drawing.Point(344, 167)
        Me.PagerTb.Name = "PagerTb"
        Me.PagerTb.PromptText = Nothing
        Me.PagerTb.Size = New System.Drawing.Size(240, 20)
        Me.PagerTb.TabIndex = 14
        '
        'DescriptionLb
        '
        Me.DescriptionLb.AutoSize = True
        Me.DescriptionLb.BackColor = System.Drawing.SystemColors.Window
        Me.DescriptionLb.Location = New System.Drawing.Point(233, 138)
        Me.DescriptionLb.Name = "DescriptionLb"
        Me.DescriptionLb.Size = New System.Drawing.Size(60, 13)
        Me.DescriptionLb.TabIndex = 13
        Me.DescriptionLb.Text = "Description"
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Location = New System.Drawing.Point(344, 138)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PromptText = Nothing
        Me.MetroTextBox1.Size = New System.Drawing.Size(240, 20)
        Me.MetroTextBox1.TabIndex = 12
        '
        'LogonScriptLb
        '
        Me.LogonScriptLb.AutoSize = True
        Me.LogonScriptLb.BackColor = System.Drawing.SystemColors.Window
        Me.LogonScriptLb.Location = New System.Drawing.Point(233, 109)
        Me.LogonScriptLb.Name = "LogonScriptLb"
        Me.LogonScriptLb.Size = New System.Drawing.Size(67, 13)
        Me.LogonScriptLb.TabIndex = 11
        Me.LogonScriptLb.Text = "Logon Script"
        '
        'LogonScriptTb
        '
        Me.LogonScriptTb.Location = New System.Drawing.Point(344, 107)
        Me.LogonScriptTb.Name = "LogonScriptTb"
        Me.LogonScriptTb.PromptText = Nothing
        Me.LogonScriptTb.Size = New System.Drawing.Size(95, 20)
        Me.LogonScriptTb.TabIndex = 10
        '
        'HomeDriveLb
        '
        Me.HomeDriveLb.AutoSize = True
        Me.HomeDriveLb.BackColor = System.Drawing.SystemColors.Window
        Me.HomeDriveLb.Location = New System.Drawing.Point(445, 111)
        Me.HomeDriveLb.Name = "HomeDriveLb"
        Me.HomeDriveLb.Size = New System.Drawing.Size(63, 13)
        Me.HomeDriveLb.TabIndex = 9
        Me.HomeDriveLb.Text = "Home Drive"
        '
        'HomeDriveCombo
        '
        Me.HomeDriveCombo.FormattingEnabled = True
        Me.HomeDriveCombo.IntegralHeight = False
        Me.HomeDriveCombo.ItemHeight = 13
        Me.HomeDriveCombo.Items.AddRange(New Object() {"A: ", "B: ", "C: ", "D: ", "E: ", "F: ", "G: ", "H: ", "I: ", "J: ", "K: ", "L: ", "M: ", "N: ", "O: ", "P: ", "Q: ", "R: ", "S: ", "T: ", "U: ", "V: ", "W: ", "X: ", "Y: ", "Z: "})
        Me.HomeDriveCombo.Location = New System.Drawing.Point(530, 107)
        Me.HomeDriveCombo.Name = "HomeDriveCombo"
        Me.HomeDriveCombo.Size = New System.Drawing.Size(54, 21)
        Me.HomeDriveCombo.TabIndex = 8
        '
        'ProfilePathLb
        '
        Me.ProfilePathLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProfilePathLb.AutoSize = True
        Me.ProfilePathLb.BackColor = System.Drawing.SystemColors.Window
        Me.ProfilePathLb.Location = New System.Drawing.Point(17, 57)
        Me.ProfilePathLb.Name = "ProfilePathLb"
        Me.ProfilePathLb.Size = New System.Drawing.Size(61, 13)
        Me.ProfilePathLb.TabIndex = 7
        Me.ProfilePathLb.Text = "Profile Path"
        '
        'HomeFolderLb
        '
        Me.HomeFolderLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeFolderLb.AutoSize = True
        Me.HomeFolderLb.BackColor = System.Drawing.SystemColors.Window
        Me.HomeFolderLb.Location = New System.Drawing.Point(17, 27)
        Me.HomeFolderLb.Name = "HomeFolderLb"
        Me.HomeFolderLb.Size = New System.Drawing.Size(67, 13)
        Me.HomeFolderLb.TabIndex = 6
        Me.HomeFolderLb.Text = "Home Folder"
        '
        'ProfilePathBn
        '
        Me.ProfilePathBn.Location = New System.Drawing.Point(550, 57)
        Me.ProfilePathBn.Name = "ProfilePathBn"
        Me.ProfilePathBn.Size = New System.Drawing.Size(34, 23)
        Me.ProfilePathBn.TabIndex = 5
        Me.ProfilePathBn.Text = "..."
        '
        'HomeFolderBn
        '
        Me.HomeFolderBn.Location = New System.Drawing.Point(550, 27)
        Me.HomeFolderBn.Name = "HomeFolderBn"
        Me.HomeFolderBn.Size = New System.Drawing.Size(34, 23)
        Me.HomeFolderBn.TabIndex = 4
        Me.HomeFolderBn.Text = "..."
        '
        'ProfilePathTb
        '
        Me.ProfilePathTb.Location = New System.Drawing.Point(110, 57)
        Me.ProfilePathTb.Name = "ProfilePathTb"
        Me.ProfilePathTb.PromptText = "\\fs1\home$\Profiles\%Username%"
        Me.ProfilePathTb.Size = New System.Drawing.Size(434, 20)
        Me.ProfilePathTb.TabIndex = 3
        '
        'HomeFolderTb
        '
        Me.HomeFolderTb.Location = New System.Drawing.Point(110, 27)
        Me.HomeFolderTb.Name = "HomeFolderTb"
        Me.HomeFolderTb.PromptText = "\\fs1\home$\%Username%"
        Me.HomeFolderTb.Size = New System.Drawing.Size(434, 20)
        Me.HomeFolderTb.TabIndex = 2
        '
        'ControlHeaderPanel3
        '
        Me.ControlHeaderPanel3.BackColor = System.Drawing.SystemColors.Window
        Me.ControlHeaderPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlHeaderPanel3.Location = New System.Drawing.Point(0, 0)
        Me.ControlHeaderPanel3.Name = "ControlHeaderPanel3"
        Me.ControlHeaderPanel3.Size = New System.Drawing.Size(640, 286)
        Me.ControlHeaderPanel3.TabIndex = 21
        '
        'CancelBn
        '
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(472, 13)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 5
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'AcceptBn
        '
        Me.AcceptBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AcceptBn.Location = New System.Drawing.Point(553, 13)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 6
        Me.AcceptBn.Text = "Next"
        Me.AcceptBn.UseVisualStyleBackColor = True
        '
        'FormBulkUser
        '
        Me.AcceptButton = Me.AcceptBn
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(640, 393)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.FooterPl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBulkUser"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk User Wizard"
        Me.FooterPl.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.InputTab.ResumeLayout(False)
        Me.InputTab.PerformLayout()
        Me.UsernameConTab.ResumeLayout(False)
        Me.UsernameConTab.PerformLayout()
        Me.PropertiesTab.ResumeLayout(False)
        Me.PropertiesTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As SimpleAD.CustomTabControlNoHeaders
    Friend WithEvents UsernameConTab As TabPage
    Friend WithEvents Sn1DragBn As System.Windows.Forms.Button
    Friend WithEvents Fn1DragBn As System.Windows.Forms.Button
    Friend WithEvents SnDragBn As System.Windows.Forms.Button
    Friend WithEvents FnDragBn As System.Windows.Forms.Button
    Friend WithEvents MainFlow As FlowLayoutPanel
    Friend WithEvents StringDragTb As SimpleAD.ControlTextBox
    Friend WithEvents StringDragBn As System.Windows.Forms.Button
    Friend WithEvents NumberBn As System.Windows.Forms.Button
    Friend WithEvents ToolTip As MetroFramework.Components.MetroToolTip
    Friend WithEvents NumberComboBox As ComboBox
    Friend WithEvents ProfilePathBn As System.Windows.Forms.Button
    Friend WithEvents HomeFolderBn As System.Windows.Forms.Button
    Friend WithEvents ProfilePathTb As SimpleAD.ControlTextBox
    Friend WithEvents HomeFolderTb As SimpleAD.ControlTextBox
    Friend WithEvents PropertiesTab As TabPage
    Friend WithEvents HomeDriveCombo As ComboBox
    Friend WithEvents MetroTextBox1 As SimpleAD.ControlTextBox
    Friend WithEvents LogonScriptTb As SimpleAD.ControlTextBox
    Friend WithEvents GroupBn As System.Windows.Forms.Button
    Friend WithEvents GroupListBox As ListBox
    Friend WithEvents MetroTextBox2 As SimpleAD.ControlTextBox
    Friend WithEvents PagerTb As SimpleAD.ControlTextBox
    Friend WithEvents FooterPl As SimpleAD.ControlFooterPl
    Friend WithEvents PreviewBn As Button
    Friend WithEvents InputTab As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ValidateBn As Button
    Friend WithEvents SnTb As SimpleAD.ControlTextBox
    Friend WithEvents FnTb As SimpleAD.ControlTextBox
    Friend WithEvents ControlHeaderPanel2 As ControlFooterPl
    Friend WithEvents ControlHeaderPanel3 As ControlFooterPl
    Friend WithEvents MainUnPreview As Label
    Friend WithEvents PreviewFlavorLb As Label
    Friend WithEvents HomeFolderLb As Label
    Friend WithEvents ProfilePathLb As Label
    Friend WithEvents HomeDriveLb As Label
    Friend WithEvents DescriptionLb As Label
    Friend WithEvents LogonScriptLb As Label
    Friend WithEvents GroupLb As Label
    Friend WithEvents MetroLabel1 As Label
    Friend WithEvents PagerLb As Label
    Friend WithEvents ImagePl As Panel
    Friend WithEvents AcceptBn As Button
    Friend WithEvents CancelBn As Button
End Class
