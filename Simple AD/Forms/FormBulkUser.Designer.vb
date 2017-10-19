<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBulkUser
    Inherits SimpleAD.FormSimpleAD

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
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.MainTabControl = New SimpleAD.CustomTabControl()
        Me.InputTab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValidateBn = New MetroFramework.Controls.MetroButton()
        Me.SnTb = New MetroFramework.Controls.MetroTextBox()
        Me.FnTb = New MetroFramework.Controls.MetroTextBox()
        Me.ControlHeaderPanel1 = New SimpleAD.ControlHeaderPanel()
        Me.UsernameConTab = New System.Windows.Forms.TabPage()
        Me.NumberComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.NumberBn = New MetroFramework.Controls.MetroButton()
        Me.StringDragTb = New MetroFramework.Controls.MetroTextBox()
        Me.StringDragBn = New MetroFramework.Controls.MetroButton()
        Me.MainUnPreview = New MetroFramework.Controls.MetroLabel()
        Me.PreviewFlavorLb = New MetroFramework.Controls.MetroLabel()
        Me.Sn1DragBn = New MetroFramework.Controls.MetroButton()
        Me.Fn1DragBn = New MetroFramework.Controls.MetroButton()
        Me.SnDragBn = New MetroFramework.Controls.MetroButton()
        Me.FnDragBn = New MetroFramework.Controls.MetroButton()
        Me.MainFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.ControlHeaderPanel2 = New SimpleAD.ControlHeaderPanel()
        Me.PropertiesTab = New System.Windows.Forms.TabPage()
        Me.GroupBn = New MetroFramework.Controls.MetroButton()
        Me.GroupLb = New MetroFramework.Controls.MetroLabel()
        Me.GroupListBox = New System.Windows.Forms.ListBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.PagerLb = New MetroFramework.Controls.MetroLabel()
        Me.PagerTb = New MetroFramework.Controls.MetroTextBox()
        Me.DescriptionLb = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.LogonScriptLb = New MetroFramework.Controls.MetroLabel()
        Me.LogonScriptTb = New MetroFramework.Controls.MetroTextBox()
        Me.HomeDriveLb = New MetroFramework.Controls.MetroLabel()
        Me.HomeDriveCombo = New MetroFramework.Controls.MetroComboBox()
        Me.ProfilePathLb = New MetroFramework.Controls.MetroLabel()
        Me.HomeFolderLb = New MetroFramework.Controls.MetroLabel()
        Me.ProfilePathBn = New MetroFramework.Controls.MetroButton()
        Me.HomeFolderBn = New MetroFramework.Controls.MetroButton()
        Me.ProfilePathTb = New MetroFramework.Controls.MetroTextBox()
        Me.HomeFolderTb = New MetroFramework.Controls.MetroTextBox()
        Me.ControlHeaderPanel3 = New SimpleAD.ControlHeaderPanel()
        Me.ToolTip = New MetroFramework.Components.MetroToolTip()
        Me.FooterPl = New System.Windows.Forms.Panel()
        Me.PreviewBn = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.MainTabControl.SuspendLayout()
        Me.InputTab.SuspendLayout()
        Me.ControlHeaderPanel1.SuspendLayout()
        Me.UsernameConTab.SuspendLayout()
        Me.PropertiesTab.SuspendLayout()
        Me.FooterPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Enabled = False
        Me.AcceptBn.Location = New System.Drawing.Point(553, 358)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 1
        Me.AcceptBn.Text = "Next"
        Me.AcceptBn.UseSelectable = True
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.InputTab)
        Me.MainTabControl.Controls.Add(Me.UsernameConTab)
        Me.MainTabControl.Controls.Add(Me.PropertiesTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainTabControl.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.HotTrackTabColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.MainTabControl.ItemSize = New System.Drawing.Size(0, 32)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 8)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.Padding = New System.Drawing.Point(24, 0)
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(640, 337)
        Me.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MainTabControl.TabColor = System.Drawing.SystemColors.Window
        Me.MainTabControl.TabIndex = 2
        '
        'InputTab
        '
        Me.InputTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InputTab.Controls.Add(Me.Label3)
        Me.InputTab.Controls.Add(Me.Label2)
        Me.InputTab.Controls.Add(Me.Label1)
        Me.InputTab.Controls.Add(Me.SnTb)
        Me.InputTab.Controls.Add(Me.FnTb)
        Me.InputTab.Controls.Add(Me.ControlHeaderPanel1)
        Me.InputTab.Location = New System.Drawing.Point(0, 35)
        Me.InputTab.Name = "InputTab"
        Me.InputTab.Size = New System.Drawing.Size(640, 302)
        Me.InputTab.TabIndex = 0
        Me.InputTab.Text = "Data Input"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(325, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(15, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Firstname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Paste the names of the users you want to import into the input fiels below. Then " &
    "click Next."
        '
        'ValidateBn
        '
        Me.ValidateBn.Location = New System.Drawing.Point(15, 269)
        Me.ValidateBn.Name = "ValidateBn"
        Me.ValidateBn.Size = New System.Drawing.Size(75, 23)
        Me.ValidateBn.TabIndex = 7
        Me.ValidateBn.Text = "Validate"
        Me.ValidateBn.UseSelectable = True
        '
        'SnTb
        '
        Me.SnTb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.SnTb.CustomButton.Image = Nothing
        Me.SnTb.CustomButton.Location = New System.Drawing.Point(110, 1)
        Me.SnTb.CustomButton.Name = ""
        Me.SnTb.CustomButton.Size = New System.Drawing.Size(189, 189)
        Me.SnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SnTb.CustomButton.TabIndex = 1
        Me.SnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SnTb.CustomButton.UseSelectable = True
        Me.SnTb.CustomButton.Visible = False
        Me.SnTb.Lines = New String(-1) {}
        Me.SnTb.Location = New System.Drawing.Point(328, 72)
        Me.SnTb.MaxLength = 32767
        Me.SnTb.Multiline = True
        Me.SnTb.Name = "SnTb"
        Me.SnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SnTb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.SnTb.SelectedText = ""
        Me.SnTb.SelectionLength = 0
        Me.SnTb.SelectionStart = 0
        Me.SnTb.ShortcutsEnabled = True
        Me.SnTb.ShowClearButton = True
        Me.SnTb.Size = New System.Drawing.Size(300, 191)
        Me.SnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SnTb.TabIndex = 8
        Me.SnTb.UseSelectable = True
        Me.SnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FnTb
        '
        Me.FnTb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.FnTb.CustomButton.Image = Nothing
        Me.FnTb.CustomButton.Location = New System.Drawing.Point(117, 1)
        Me.FnTb.CustomButton.Name = ""
        Me.FnTb.CustomButton.Size = New System.Drawing.Size(189, 189)
        Me.FnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FnTb.CustomButton.TabIndex = 1
        Me.FnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FnTb.CustomButton.UseSelectable = True
        Me.FnTb.CustomButton.Visible = False
        Me.FnTb.Lines = New String(-1) {}
        Me.FnTb.Location = New System.Drawing.Point(15, 72)
        Me.FnTb.MaxLength = 32767
        Me.FnTb.Multiline = True
        Me.FnTb.Name = "FnTb"
        Me.FnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FnTb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.FnTb.SelectedText = ""
        Me.FnTb.SelectionLength = 0
        Me.FnTb.SelectionStart = 0
        Me.FnTb.ShortcutsEnabled = True
        Me.FnTb.ShowClearButton = True
        Me.FnTb.Size = New System.Drawing.Size(307, 191)
        Me.FnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.FnTb.TabIndex = 7
        Me.FnTb.UseSelectable = True
        Me.FnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ControlHeaderPanel1
        '
        Me.ControlHeaderPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.ControlHeaderPanel1.Controls.Add(Me.ValidateBn)
        Me.ControlHeaderPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlHeaderPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ControlHeaderPanel1.Name = "ControlHeaderPanel1"
        Me.ControlHeaderPanel1.Size = New System.Drawing.Size(640, 302)
        Me.ControlHeaderPanel1.TabIndex = 12
        '
        'UsernameConTab
        '
        Me.UsernameConTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
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
        Me.UsernameConTab.Location = New System.Drawing.Point(0, 35)
        Me.UsernameConTab.Name = "UsernameConTab"
        Me.UsernameConTab.Size = New System.Drawing.Size(640, 302)
        Me.UsernameConTab.TabIndex = 1
        Me.UsernameConTab.Text = "Username Constructor"
        '
        'NumberComboBox
        '
        Me.NumberComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.NumberComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.NumberComboBox.FormattingEnabled = True
        Me.NumberComboBox.ItemHeight = 19
        Me.NumberComboBox.Items.AddRange(New Object() {"1", "01", "001"})
        Me.NumberComboBox.Location = New System.Drawing.Point(375, 133)
        Me.NumberComboBox.Name = "NumberComboBox"
        Me.NumberComboBox.Size = New System.Drawing.Size(150, 25)
        Me.NumberComboBox.Style = MetroFramework.MetroColorStyle.Purple
        Me.NumberComboBox.TabIndex = 13
        Me.NumberComboBox.UseSelectable = True
        '
        'NumberBn
        '
        Me.NumberBn.Location = New System.Drawing.Point(375, 105)
        Me.NumberBn.Name = "NumberBn"
        Me.NumberBn.Size = New System.Drawing.Size(150, 23)
        Me.NumberBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.NumberBn.TabIndex = 11
        Me.NumberBn.Text = "Number"
        Me.ToolTip.SetToolTip(Me.NumberBn, "Adds a dynamic number to the username based on if usernames that are current pres" &
        "ent in active directory")
        Me.NumberBn.UseSelectable = True
        '
        'StringDragTb
        '
        '
        '
        '
        Me.StringDragTb.CustomButton.Image = Nothing
        Me.StringDragTb.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.StringDragTb.CustomButton.Name = ""
        Me.StringDragTb.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.StringDragTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.StringDragTb.CustomButton.TabIndex = 1
        Me.StringDragTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.StringDragTb.CustomButton.UseSelectable = True
        Me.StringDragTb.CustomButton.Visible = False
        Me.StringDragTb.Lines = New String(-1) {}
        Me.StringDragTb.Location = New System.Drawing.Point(219, 133)
        Me.StringDragTb.MaxLength = 32767
        Me.StringDragTb.Name = "StringDragTb"
        Me.StringDragTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StringDragTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.StringDragTb.SelectedText = ""
        Me.StringDragTb.SelectionLength = 0
        Me.StringDragTb.SelectionStart = 0
        Me.StringDragTb.ShortcutsEnabled = True
        Me.StringDragTb.Size = New System.Drawing.Size(150, 25)
        Me.StringDragTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.StringDragTb.TabIndex = 10
        Me.StringDragTb.UseSelectable = True
        Me.StringDragTb.WaterMark = "Enter String..."
        Me.StringDragTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StringDragTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'StringDragBn
        '
        Me.StringDragBn.Location = New System.Drawing.Point(219, 105)
        Me.StringDragBn.Name = "StringDragBn"
        Me.StringDragBn.Size = New System.Drawing.Size(150, 23)
        Me.StringDragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.StringDragBn.TabIndex = 9
        Me.StringDragBn.Text = "String"
        Me.ToolTip.SetToolTip(Me.StringDragBn, "Allows a custom string to be inserted into a username")
        Me.StringDragBn.UseSelectable = True
        '
        'MainUnPreview
        '
        Me.MainUnPreview.AutoSize = True
        Me.MainUnPreview.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MainUnPreview.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MainUnPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainUnPreview.Location = New System.Drawing.Point(15, 201)
        Me.MainUnPreview.Name = "MainUnPreview"
        Me.MainUnPreview.Size = New System.Drawing.Size(156, 25)
        Me.MainUnPreview.TabIndex = 8
        Me.MainUnPreview.Text = "Username Preview"
        Me.MainUnPreview.UseCustomForeColor = True
        '
        'PreviewFlavorLb
        '
        Me.PreviewFlavorLb.AutoSize = True
        Me.PreviewFlavorLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PreviewFlavorLb.Location = New System.Drawing.Point(15, 173)
        Me.PreviewFlavorLb.Name = "PreviewFlavorLb"
        Me.PreviewFlavorLb.Size = New System.Drawing.Size(73, 19)
        Me.PreviewFlavorLb.TabIndex = 7
        Me.PreviewFlavorLb.Text = "John Smith"
        '
        'Sn1DragBn
        '
        Me.Sn1DragBn.Location = New System.Drawing.Point(99, 134)
        Me.Sn1DragBn.Name = "Sn1DragBn"
        Me.Sn1DragBn.Size = New System.Drawing.Size(75, 23)
        Me.Sn1DragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.Sn1DragBn.TabIndex = 6
        Me.Sn1DragBn.Text = "Last Initial"
        Me.Sn1DragBn.UseSelectable = True
        '
        'Fn1DragBn
        '
        Me.Fn1DragBn.Location = New System.Drawing.Point(18, 134)
        Me.Fn1DragBn.Name = "Fn1DragBn"
        Me.Fn1DragBn.Size = New System.Drawing.Size(75, 23)
        Me.Fn1DragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.Fn1DragBn.TabIndex = 5
        Me.Fn1DragBn.Text = "First Initial"
        Me.Fn1DragBn.UseSelectable = True
        '
        'SnDragBn
        '
        Me.SnDragBn.Location = New System.Drawing.Point(99, 105)
        Me.SnDragBn.Name = "SnDragBn"
        Me.SnDragBn.Size = New System.Drawing.Size(75, 23)
        Me.SnDragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.SnDragBn.TabIndex = 4
        Me.SnDragBn.Text = "Surname"
        Me.SnDragBn.UseSelectable = True
        '
        'FnDragBn
        '
        Me.FnDragBn.Location = New System.Drawing.Point(18, 105)
        Me.FnDragBn.Name = "FnDragBn"
        Me.FnDragBn.Size = New System.Drawing.Size(75, 23)
        Me.FnDragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.FnDragBn.TabIndex = 3
        Me.FnDragBn.Text = "FirstName"
        Me.FnDragBn.UseSelectable = True
        '
        'MainFlow
        '
        Me.MainFlow.AllowDrop = True
        Me.MainFlow.AutoScroll = True
        Me.MainFlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
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
        Me.ControlHeaderPanel2.Size = New System.Drawing.Size(640, 302)
        Me.ControlHeaderPanel2.TabIndex = 14
        '
        'PropertiesTab
        '
        Me.PropertiesTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
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
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 35)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(640, 302)
        Me.PropertiesTab.TabIndex = 2
        Me.PropertiesTab.Text = "Properties"
        '
        'GroupBn
        '
        Me.GroupBn.Location = New System.Drawing.Point(183, 111)
        Me.GroupBn.Name = "GroupBn"
        Me.GroupBn.Size = New System.Drawing.Size(34, 23)
        Me.GroupBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.GroupBn.TabIndex = 20
        Me.GroupBn.Text = "..."
        Me.GroupBn.UseSelectable = True
        '
        'GroupLb
        '
        Me.GroupLb.AutoSize = True
        Me.GroupLb.Location = New System.Drawing.Point(17, 111)
        Me.GroupLb.Name = "GroupLb"
        Me.GroupLb.Size = New System.Drawing.Size(124, 19)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(233, 196)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "RDS Profile Path"
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(344, 196)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(240, 23)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTextBox2.TabIndex = 16
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PagerLb
        '
        Me.PagerLb.AutoSize = True
        Me.PagerLb.Location = New System.Drawing.Point(233, 167)
        Me.PagerLb.Name = "PagerLb"
        Me.PagerLb.Size = New System.Drawing.Size(43, 19)
        Me.PagerLb.TabIndex = 15
        Me.PagerLb.Text = "Pager"
        '
        'PagerTb
        '
        '
        '
        '
        Me.PagerTb.CustomButton.Image = Nothing
        Me.PagerTb.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.PagerTb.CustomButton.Name = ""
        Me.PagerTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PagerTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PagerTb.CustomButton.TabIndex = 1
        Me.PagerTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PagerTb.CustomButton.UseSelectable = True
        Me.PagerTb.CustomButton.Visible = False
        Me.PagerTb.Lines = New String(-1) {}
        Me.PagerTb.Location = New System.Drawing.Point(344, 167)
        Me.PagerTb.MaxLength = 32767
        Me.PagerTb.Name = "PagerTb"
        Me.PagerTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PagerTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PagerTb.SelectedText = ""
        Me.PagerTb.SelectionLength = 0
        Me.PagerTb.SelectionStart = 0
        Me.PagerTb.ShortcutsEnabled = True
        Me.PagerTb.Size = New System.Drawing.Size(240, 23)
        Me.PagerTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.PagerTb.TabIndex = 14
        Me.PagerTb.UseSelectable = True
        Me.PagerTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PagerTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'DescriptionLb
        '
        Me.DescriptionLb.AutoSize = True
        Me.DescriptionLb.Location = New System.Drawing.Point(233, 138)
        Me.DescriptionLb.Name = "DescriptionLb"
        Me.DescriptionLb.Size = New System.Drawing.Size(74, 19)
        Me.DescriptionLb.TabIndex = 13
        Me.DescriptionLb.Text = "Description"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(344, 138)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(240, 23)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTextBox1.TabIndex = 12
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LogonScriptLb
        '
        Me.LogonScriptLb.AutoSize = True
        Me.LogonScriptLb.Location = New System.Drawing.Point(233, 109)
        Me.LogonScriptLb.Name = "LogonScriptLb"
        Me.LogonScriptLb.Size = New System.Drawing.Size(83, 19)
        Me.LogonScriptLb.TabIndex = 11
        Me.LogonScriptLb.Text = "Logon Script"
        '
        'LogonScriptTb
        '
        '
        '
        '
        Me.LogonScriptTb.CustomButton.Image = Nothing
        Me.LogonScriptTb.CustomButton.Location = New System.Drawing.Point(73, 1)
        Me.LogonScriptTb.CustomButton.Name = ""
        Me.LogonScriptTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.LogonScriptTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LogonScriptTb.CustomButton.TabIndex = 1
        Me.LogonScriptTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LogonScriptTb.CustomButton.UseSelectable = True
        Me.LogonScriptTb.CustomButton.Visible = False
        Me.LogonScriptTb.Lines = New String(-1) {}
        Me.LogonScriptTb.Location = New System.Drawing.Point(344, 107)
        Me.LogonScriptTb.MaxLength = 32767
        Me.LogonScriptTb.Name = "LogonScriptTb"
        Me.LogonScriptTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LogonScriptTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LogonScriptTb.SelectedText = ""
        Me.LogonScriptTb.SelectionLength = 0
        Me.LogonScriptTb.SelectionStart = 0
        Me.LogonScriptTb.ShortcutsEnabled = True
        Me.LogonScriptTb.Size = New System.Drawing.Size(95, 23)
        Me.LogonScriptTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.LogonScriptTb.TabIndex = 10
        Me.LogonScriptTb.UseSelectable = True
        Me.LogonScriptTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LogonScriptTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'HomeDriveLb
        '
        Me.HomeDriveLb.AutoSize = True
        Me.HomeDriveLb.Location = New System.Drawing.Point(445, 111)
        Me.HomeDriveLb.Name = "HomeDriveLb"
        Me.HomeDriveLb.Size = New System.Drawing.Size(79, 19)
        Me.HomeDriveLb.TabIndex = 9
        Me.HomeDriveLb.Text = "Home Drive"
        '
        'HomeDriveCombo
        '
        Me.HomeDriveCombo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.HomeDriveCombo.FormattingEnabled = True
        Me.HomeDriveCombo.IntegralHeight = False
        Me.HomeDriveCombo.ItemHeight = 19
        Me.HomeDriveCombo.Items.AddRange(New Object() {"A: ", "B: ", "C: ", "D: ", "E: ", "F: ", "G: ", "H: ", "I: ", "J: ", "K: ", "L: ", "M: ", "N: ", "O: ", "P: ", "Q: ", "R: ", "S: ", "T: ", "U: ", "V: ", "W: ", "X: ", "Y: ", "Z: "})
        Me.HomeDriveCombo.Location = New System.Drawing.Point(530, 107)
        Me.HomeDriveCombo.Name = "HomeDriveCombo"
        Me.HomeDriveCombo.Size = New System.Drawing.Size(54, 25)
        Me.HomeDriveCombo.Style = MetroFramework.MetroColorStyle.Purple
        Me.HomeDriveCombo.TabIndex = 8
        Me.HomeDriveCombo.UseSelectable = True
        '
        'ProfilePathLb
        '
        Me.ProfilePathLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProfilePathLb.AutoSize = True
        Me.ProfilePathLb.Location = New System.Drawing.Point(17, 57)
        Me.ProfilePathLb.Name = "ProfilePathLb"
        Me.ProfilePathLb.Size = New System.Drawing.Size(76, 19)
        Me.ProfilePathLb.TabIndex = 7
        Me.ProfilePathLb.Text = "Profile Path"
        '
        'HomeFolderLb
        '
        Me.HomeFolderLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeFolderLb.AutoSize = True
        Me.HomeFolderLb.Location = New System.Drawing.Point(17, 27)
        Me.HomeFolderLb.Name = "HomeFolderLb"
        Me.HomeFolderLb.Size = New System.Drawing.Size(87, 19)
        Me.HomeFolderLb.TabIndex = 6
        Me.HomeFolderLb.Text = "Home Folder"
        '
        'ProfilePathBn
        '
        Me.ProfilePathBn.Location = New System.Drawing.Point(550, 57)
        Me.ProfilePathBn.Name = "ProfilePathBn"
        Me.ProfilePathBn.Size = New System.Drawing.Size(34, 23)
        Me.ProfilePathBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.ProfilePathBn.TabIndex = 5
        Me.ProfilePathBn.Text = "..."
        Me.ProfilePathBn.UseSelectable = True
        '
        'HomeFolderBn
        '
        Me.HomeFolderBn.Location = New System.Drawing.Point(550, 27)
        Me.HomeFolderBn.Name = "HomeFolderBn"
        Me.HomeFolderBn.Size = New System.Drawing.Size(34, 23)
        Me.HomeFolderBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.HomeFolderBn.TabIndex = 4
        Me.HomeFolderBn.Text = "..."
        Me.HomeFolderBn.UseSelectable = True
        '
        'ProfilePathTb
        '
        '
        '
        '
        Me.ProfilePathTb.CustomButton.Image = Nothing
        Me.ProfilePathTb.CustomButton.Location = New System.Drawing.Point(412, 1)
        Me.ProfilePathTb.CustomButton.Name = ""
        Me.ProfilePathTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.ProfilePathTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ProfilePathTb.CustomButton.TabIndex = 1
        Me.ProfilePathTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ProfilePathTb.CustomButton.UseSelectable = True
        Me.ProfilePathTb.CustomButton.Visible = False
        Me.ProfilePathTb.Lines = New String(-1) {}
        Me.ProfilePathTb.Location = New System.Drawing.Point(110, 57)
        Me.ProfilePathTb.MaxLength = 32767
        Me.ProfilePathTb.Name = "ProfilePathTb"
        Me.ProfilePathTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProfilePathTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProfilePathTb.SelectedText = ""
        Me.ProfilePathTb.SelectionLength = 0
        Me.ProfilePathTb.SelectionStart = 0
        Me.ProfilePathTb.ShortcutsEnabled = True
        Me.ProfilePathTb.Size = New System.Drawing.Size(434, 23)
        Me.ProfilePathTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.ProfilePathTb.TabIndex = 3
        Me.ProfilePathTb.UseSelectable = True
        Me.ProfilePathTb.WaterMark = "\\fs1\home$\Profiles\%Username%"
        Me.ProfilePathTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ProfilePathTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'HomeFolderTb
        '
        '
        '
        '
        Me.HomeFolderTb.CustomButton.Image = Nothing
        Me.HomeFolderTb.CustomButton.Location = New System.Drawing.Point(412, 1)
        Me.HomeFolderTb.CustomButton.Name = ""
        Me.HomeFolderTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.HomeFolderTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HomeFolderTb.CustomButton.TabIndex = 1
        Me.HomeFolderTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HomeFolderTb.CustomButton.UseSelectable = True
        Me.HomeFolderTb.CustomButton.Visible = False
        Me.HomeFolderTb.Lines = New String(-1) {}
        Me.HomeFolderTb.Location = New System.Drawing.Point(110, 27)
        Me.HomeFolderTb.MaxLength = 32767
        Me.HomeFolderTb.Name = "HomeFolderTb"
        Me.HomeFolderTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HomeFolderTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HomeFolderTb.SelectedText = ""
        Me.HomeFolderTb.SelectionLength = 0
        Me.HomeFolderTb.SelectionStart = 0
        Me.HomeFolderTb.ShortcutsEnabled = True
        Me.HomeFolderTb.Size = New System.Drawing.Size(434, 23)
        Me.HomeFolderTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.HomeFolderTb.TabIndex = 2
        Me.HomeFolderTb.UseSelectable = True
        Me.HomeFolderTb.WaterMark = "\\fs1\home$\%Username%"
        Me.HomeFolderTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HomeFolderTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ControlHeaderPanel3
        '
        Me.ControlHeaderPanel3.BackColor = System.Drawing.SystemColors.Window
        Me.ControlHeaderPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlHeaderPanel3.Location = New System.Drawing.Point(0, 0)
        Me.ControlHeaderPanel3.Name = "ControlHeaderPanel3"
        Me.ControlHeaderPanel3.Size = New System.Drawing.Size(640, 302)
        Me.ControlHeaderPanel3.TabIndex = 21
        '
        'ToolTip
        '
        Me.ToolTip.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTip.StyleManager = Nothing
        Me.ToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'FooterPl
        '
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
        Me.PreviewBn.Location = New System.Drawing.Point(348, 13)
        Me.PreviewBn.Name = "PreviewBn"
        Me.PreviewBn.Size = New System.Drawing.Size(108, 23)
        Me.PreviewBn.TabIndex = 4
        Me.PreviewBn.Text = "Preview Users"
        Me.PreviewBn.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(472, 358)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 0
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'FormBulkUser
        '
        Me.AcceptButton = Me.AcceptBn
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(640, 393)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.FooterPl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBulkUser"
        Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk User Wizard"
        Me.MainTabControl.ResumeLayout(False)
        Me.InputTab.ResumeLayout(False)
        Me.InputTab.PerformLayout()
        Me.ControlHeaderPanel1.ResumeLayout(False)
        Me.UsernameConTab.ResumeLayout(False)
        Me.UsernameConTab.PerformLayout()
        Me.PropertiesTab.ResumeLayout(False)
        Me.PropertiesTab.PerformLayout()
        Me.FooterPl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AcceptBn As MetroFramework.Controls.MetroButton
    Friend WithEvents MainTabControl As SimpleAD.CustomTabControl
    Friend WithEvents UsernameConTab As TabPage
    Friend WithEvents Sn1DragBn As MetroFramework.Controls.MetroButton
    Friend WithEvents Fn1DragBn As MetroFramework.Controls.MetroButton
    Friend WithEvents SnDragBn As MetroFramework.Controls.MetroButton
    Friend WithEvents FnDragBn As MetroFramework.Controls.MetroButton
    Friend WithEvents MainFlow As FlowLayoutPanel
    Friend WithEvents MainUnPreview As MetroFramework.Controls.MetroLabel
    Friend WithEvents PreviewFlavorLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents StringDragTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents StringDragBn As MetroFramework.Controls.MetroButton
    Friend WithEvents NumberBn As MetroFramework.Controls.MetroButton
    Friend WithEvents ToolTip As MetroFramework.Components.MetroToolTip
    Friend WithEvents NumberComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents HomeFolderLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProfilePathBn As MetroFramework.Controls.MetroButton
    Friend WithEvents HomeFolderBn As MetroFramework.Controls.MetroButton
    Friend WithEvents ProfilePathTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents HomeFolderTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PropertiesTab As TabPage
    Friend WithEvents ProfilePathLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents HomeDriveLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents HomeDriveCombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DescriptionLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LogonScriptLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents LogonScriptTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBn As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupListBox As ListBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PagerLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents PagerTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FooterPl As Panel
    Friend WithEvents PreviewBn As Controls.MetroButton
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents InputTab As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ValidateBn As Controls.MetroButton
    Friend WithEvents SnTb As Controls.MetroTextBox
    Friend WithEvents FnTb As Controls.MetroTextBox
    Friend WithEvents ControlHeaderPanel1 As ControlHeaderPanel
    Friend WithEvents ControlHeaderPanel2 As ControlHeaderPanel
    Friend WithEvents ControlHeaderPanel3 As ControlHeaderPanel
End Class
