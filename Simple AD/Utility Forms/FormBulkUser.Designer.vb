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
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.MainTabControl = New MetroFramework.Controls.MetroTabControl()
        Me.InputTab = New MetroFramework.Controls.MetroTabPage()
        Me.ValidateBn = New MetroFramework.Controls.MetroButton()
        Me.SnTb = New MetroFramework.Controls.MetroTextBox()
        Me.FnTb = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.SnLb = New MetroFramework.Controls.MetroLabel()
        Me.FnLb = New MetroFramework.Controls.MetroLabel()
        Me.UsernameConTab = New MetroFramework.Controls.MetroTabPage()
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
        Me.PropertiesTab = New MetroFramework.Controls.MetroTabPage()
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
        Me.ToolTip = New MetroFramework.Components.MetroToolTip()
        Me.MainTabControl.SuspendLayout()
        Me.InputTab.SuspendLayout()
        Me.UsernameConTab.SuspendLayout()
        Me.PropertiesTab.SuspendLayout()
        Me.SuspendLayout()
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
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.MainTabControl.Location = New System.Drawing.Point(13, 63)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(615, 289)
        Me.MainTabControl.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainTabControl.TabIndex = 2
        Me.MainTabControl.UseSelectable = True
        '
        'InputTab
        '
        Me.InputTab.Controls.Add(Me.ValidateBn)
        Me.InputTab.Controls.Add(Me.SnTb)
        Me.InputTab.Controls.Add(Me.FnTb)
        Me.InputTab.Controls.Add(Me.Label1)
        Me.InputTab.Controls.Add(Me.SnLb)
        Me.InputTab.Controls.Add(Me.FnLb)
        Me.InputTab.HorizontalScrollbarBarColor = True
        Me.InputTab.HorizontalScrollbarHighlightOnWheel = False
        Me.InputTab.HorizontalScrollbarSize = 10
        Me.InputTab.Location = New System.Drawing.Point(4, 38)
        Me.InputTab.Name = "InputTab"
        Me.InputTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InputTab.Size = New System.Drawing.Size(607, 247)
        Me.InputTab.TabIndex = 0
        Me.InputTab.Text = "Data Input"
        Me.InputTab.VerticalScrollbarBarColor = True
        Me.InputTab.VerticalScrollbarHighlightOnWheel = False
        Me.InputTab.VerticalScrollbarSize = 10
        '
        'ValidateBn
        '
        Me.ValidateBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ValidateBn.Location = New System.Drawing.Point(18, 218)
        Me.ValidateBn.Name = "ValidateBn"
        Me.ValidateBn.Size = New System.Drawing.Size(75, 23)
        Me.ValidateBn.TabIndex = 7
        Me.ValidateBn.Text = "Validate"
        Me.ValidateBn.UseSelectable = True
        '
        'SnTb
        '
        '
        '
        '
        Me.SnTb.CustomButton.Image = Nothing
        Me.SnTb.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.SnTb.CustomButton.Name = ""
        Me.SnTb.CustomButton.Size = New System.Drawing.Size(129, 129)
        Me.SnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SnTb.CustomButton.TabIndex = 1
        Me.SnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SnTb.CustomButton.UseSelectable = True
        Me.SnTb.CustomButton.Visible = False
        Me.SnTb.Lines = New String(-1) {}
        Me.SnTb.Location = New System.Drawing.Point(289, 75)
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
        Me.SnTb.Size = New System.Drawing.Size(257, 131)
        Me.SnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SnTb.TabIndex = 8
        Me.SnTb.UseSelectable = True
        Me.SnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FnTb
        '
        '
        '
        '
        Me.FnTb.CustomButton.Image = Nothing
        Me.FnTb.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.FnTb.CustomButton.Name = ""
        Me.FnTb.CustomButton.Size = New System.Drawing.Size(129, 129)
        Me.FnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FnTb.CustomButton.TabIndex = 1
        Me.FnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FnTb.CustomButton.UseSelectable = True
        Me.FnTb.CustomButton.Visible = False
        Me.FnTb.Lines = New String(-1) {}
        Me.FnTb.Location = New System.Drawing.Point(18, 75)
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
        Me.FnTb.Size = New System.Drawing.Size(257, 131)
        Me.FnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.FnTb.TabIndex = 7
        Me.FnTb.UseSelectable = True
        Me.FnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Paste the names of the users you want to import into the input fiels below. Then " &
    "click Next."
        '
        'SnLb
        '
        Me.SnLb.AutoSize = True
        Me.SnLb.Location = New System.Drawing.Point(293, 53)
        Me.SnLb.Name = "SnLb"
        Me.SnLb.Size = New System.Drawing.Size(67, 19)
        Me.SnLb.TabIndex = 5
        Me.SnLb.Text = "LastName"
        '
        'FnLb
        '
        Me.FnLb.AutoSize = True
        Me.FnLb.Location = New System.Drawing.Point(18, 53)
        Me.FnLb.Name = "FnLb"
        Me.FnLb.Size = New System.Drawing.Size(73, 19)
        Me.FnLb.TabIndex = 4
        Me.FnLb.Text = "First Name"
        '
        'UsernameConTab
        '
        Me.UsernameConTab.BackColor = System.Drawing.SystemColors.Control
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
        Me.UsernameConTab.HorizontalScrollbarBarColor = True
        Me.UsernameConTab.HorizontalScrollbarHighlightOnWheel = False
        Me.UsernameConTab.HorizontalScrollbarSize = 10
        Me.UsernameConTab.Location = New System.Drawing.Point(4, 35)
        Me.UsernameConTab.Name = "UsernameConTab"
        Me.UsernameConTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UsernameConTab.Size = New System.Drawing.Size(607, 250)
        Me.UsernameConTab.TabIndex = 1
        Me.UsernameConTab.Text = "Username Constructor"
        Me.UsernameConTab.VerticalScrollbarBarColor = True
        Me.UsernameConTab.VerticalScrollbarHighlightOnWheel = False
        Me.UsernameConTab.VerticalScrollbarSize = 10
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
        Me.StringDragTb.PromptText = "Enter String..."
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
        Me.MainUnPreview.Location = New System.Drawing.Point(8, 198)
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
        Me.PreviewFlavorLb.Location = New System.Drawing.Point(8, 179)
        Me.PreviewFlavorLb.Name = "PreviewFlavorLb"
        Me.PreviewFlavorLb.Size = New System.Drawing.Size(73, 19)
        Me.PreviewFlavorLb.TabIndex = 7
        Me.PreviewFlavorLb.Text = "John Smith"
        '
        'Sn1DragBn
        '
        Me.Sn1DragBn.Location = New System.Drawing.Point(87, 134)
        Me.Sn1DragBn.Name = "Sn1DragBn"
        Me.Sn1DragBn.Size = New System.Drawing.Size(75, 23)
        Me.Sn1DragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.Sn1DragBn.TabIndex = 6
        Me.Sn1DragBn.Text = "Last Initial"
        Me.Sn1DragBn.UseSelectable = True
        '
        'Fn1DragBn
        '
        Me.Fn1DragBn.Location = New System.Drawing.Point(6, 134)
        Me.Fn1DragBn.Name = "Fn1DragBn"
        Me.Fn1DragBn.Size = New System.Drawing.Size(75, 23)
        Me.Fn1DragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.Fn1DragBn.TabIndex = 5
        Me.Fn1DragBn.Text = "First Initial"
        Me.Fn1DragBn.UseSelectable = True
        '
        'SnDragBn
        '
        Me.SnDragBn.Location = New System.Drawing.Point(87, 105)
        Me.SnDragBn.Name = "SnDragBn"
        Me.SnDragBn.Size = New System.Drawing.Size(75, 23)
        Me.SnDragBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.SnDragBn.TabIndex = 4
        Me.SnDragBn.Text = "Surname"
        Me.SnDragBn.UseSelectable = True
        '
        'FnDragBn
        '
        Me.FnDragBn.Location = New System.Drawing.Point(6, 105)
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
        Me.MainFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainFlow.Location = New System.Drawing.Point(6, 38)
        Me.MainFlow.Name = "MainFlow"
        Me.MainFlow.Padding = New System.Windows.Forms.Padding(2)
        Me.MainFlow.Size = New System.Drawing.Size(594, 52)
        Me.MainFlow.TabIndex = 2
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
        Me.PropertiesTab.HorizontalScrollbarBarColor = True
        Me.PropertiesTab.HorizontalScrollbarHighlightOnWheel = False
        Me.PropertiesTab.HorizontalScrollbarSize = 10
        Me.PropertiesTab.Location = New System.Drawing.Point(4, 35)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(607, 250)
        Me.PropertiesTab.TabIndex = 2
        Me.PropertiesTab.Text = "Properties"
        Me.PropertiesTab.VerticalScrollbarBarColor = True
        Me.PropertiesTab.VerticalScrollbarHighlightOnWheel = False
        Me.PropertiesTab.VerticalScrollbarSize = 10
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
        Me.MetroLabel1.Size = New System.Drawing.Size(105, 19)
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
        Me.PagerLb.Size = New System.Drawing.Size(44, 19)
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
        Me.ProfilePathLb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ProfilePathLb.AutoSize = True
        Me.ProfilePathLb.Location = New System.Drawing.Point(17, 51)
        Me.ProfilePathLb.Name = "ProfilePathLb"
        Me.ProfilePathLb.Size = New System.Drawing.Size(77, 19)
        Me.ProfilePathLb.TabIndex = 7
        Me.ProfilePathLb.Text = "Profile Path"
        '
        'HomeFolderLb
        '
        Me.HomeFolderLb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.HomeFolderLb.AutoSize = True
        Me.HomeFolderLb.Location = New System.Drawing.Point(17, 21)
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
        Me.ProfilePathTb.PromptText = "\\fs1\home$\Profiles\%Username%"
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
        Me.HomeFolderTb.PromptText = "\\fs1\home$\%Username%"
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
        'ToolTip
        '
        Me.ToolTip.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTip.StyleManager = Nothing
        Me.ToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'FormBulkUser
        '
        Me.AcceptButton = Me.AcceptBn
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(640, 393)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.CancelBn)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBulkUser"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Bulk User Wizard"
        Me.MainTabControl.ResumeLayout(False)
        Me.InputTab.ResumeLayout(False)
        Me.InputTab.PerformLayout()
        Me.UsernameConTab.ResumeLayout(False)
        Me.UsernameConTab.PerformLayout()
        Me.PropertiesTab.ResumeLayout(False)
        Me.PropertiesTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelBn As MetroFramework.Controls.MetroButton
    Friend WithEvents AcceptBn As MetroFramework.Controls.MetroButton
    Friend WithEvents MainTabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents InputTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents UsernameConTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents SnLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents FnLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ValidateBn As MetroFramework.Controls.MetroButton
    Friend WithEvents SnTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FnTb As MetroFramework.Controls.MetroTextBox
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
    Friend WithEvents PropertiesTab As MetroFramework.Controls.MetroTabPage
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
End Class
