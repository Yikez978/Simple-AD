<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        Me.OKBt = New MetroFramework.Controls.MetroButton()
        Me.CnBt = New MetroFramework.Controls.MetroButton()
        Me.LDAPTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.ReportsGb = New System.Windows.Forms.GroupBox()
        Me.LaCb = New MetroFramework.Controls.MetroCheckBox()
        Me.GnGb = New System.Windows.Forms.GroupBox()
        Me.EaCb = New MetroFramework.Controls.MetroCheckBox()
        Me.FpCb = New MetroFramework.Controls.MetroCheckBox()
        Me.ChCb = New MetroFramework.Controls.MetroCheckBox()
        Me.Preferences = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.AutoLoginToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.ProxyToggle = New MetroFramework.Controls.MetroToggle()
        Me.DbGb = New System.Windows.Forms.GroupBox()
        Me.CoCb = New MetroFramework.Controls.MetroCheckBox()
        Me.VbCb = New MetroFramework.Controls.MetroCheckBox()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.Ofice365TabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Advanced365Gb = New System.Windows.Forms.GroupBox()
        Me.ResetShellURIBn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ShellURITb = New MetroFramework.Controls.MetroTextBox()
        Me.ResetURIBn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.URITb = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.results365Lb = New MetroFramework.Controls.MetroLabel()
        Me.results365Tb = New MetroFramework.Controls.MetroTextBox()
        Me.LDAPTabPage.SuspendLayout()
        Me.ReportsGb.SuspendLayout()
        Me.GnGb.SuspendLayout()
        Me.Preferences.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DbGb.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Ofice365TabPage.SuspendLayout()
        Me.Advanced365Gb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKBt
        '
        Me.OKBt.Location = New System.Drawing.Point(448, 326)
        Me.OKBt.Name = "OKBt"
        Me.OKBt.Size = New System.Drawing.Size(75, 23)
        Me.OKBt.TabIndex = 1
        Me.OKBt.Text = "OK"
        Me.OKBt.UseSelectable = True
        '
        'CnBt
        '
        Me.CnBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CnBt.Location = New System.Drawing.Point(367, 326)
        Me.CnBt.Name = "CnBt"
        Me.CnBt.Size = New System.Drawing.Size(75, 23)
        Me.CnBt.TabIndex = 2
        Me.CnBt.Text = "Cancel"
        Me.CnBt.UseSelectable = True
        '
        'LDAPTabPage
        '
        Me.LDAPTabPage.Controls.Add(Me.ReportsGb)
        Me.LDAPTabPage.Controls.Add(Me.GnGb)
        Me.LDAPTabPage.HorizontalScrollbarBarColor = True
        Me.LDAPTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.LDAPTabPage.HorizontalScrollbarSize = 10
        Me.LDAPTabPage.Location = New System.Drawing.Point(4, 38)
        Me.LDAPTabPage.Name = "LDAPTabPage"
        Me.LDAPTabPage.Size = New System.Drawing.Size(494, 256)
        Me.LDAPTabPage.TabIndex = 1
        Me.LDAPTabPage.Text = "LDAP"
        Me.LDAPTabPage.VerticalScrollbarBarColor = True
        Me.LDAPTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.LDAPTabPage.VerticalScrollbarSize = 10
        '
        'ReportsGb
        '
        Me.ReportsGb.BackColor = System.Drawing.SystemColors.Window
        Me.ReportsGb.Controls.Add(Me.LaCb)
        Me.ReportsGb.Location = New System.Drawing.Point(7, 152)
        Me.ReportsGb.Name = "ReportsGb"
        Me.ReportsGb.Size = New System.Drawing.Size(484, 108)
        Me.ReportsGb.TabIndex = 7
        Me.ReportsGb.TabStop = False
        Me.ReportsGb.Text = "Reports"
        '
        'LaCb
        '
        Me.LaCb.AutoSize = True
        Me.LaCb.Location = New System.Drawing.Point(13, 21)
        Me.LaCb.Name = "LaCb"
        Me.LaCb.Size = New System.Drawing.Size(160, 15)
        Me.LaCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.LaCb.TabIndex = 3
        Me.LaCb.Text = "Load Advanced Attributes"
        Me.LaCb.UseSelectable = True
        '
        'GnGb
        '
        Me.GnGb.BackColor = System.Drawing.SystemColors.Window
        Me.GnGb.Controls.Add(Me.EaCb)
        Me.GnGb.Controls.Add(Me.FpCb)
        Me.GnGb.Controls.Add(Me.ChCb)
        Me.GnGb.Location = New System.Drawing.Point(7, 11)
        Me.GnGb.Name = "GnGb"
        Me.GnGb.Size = New System.Drawing.Size(484, 135)
        Me.GnGb.TabIndex = 6
        Me.GnGb.TabStop = False
        Me.GnGb.Text = "Bulk Account Creation"
        '
        'EaCb
        '
        Me.EaCb.AutoSize = True
        Me.EaCb.Checked = True
        Me.EaCb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EaCb.Location = New System.Drawing.Point(13, 68)
        Me.EaCb.Name = "EaCb"
        Me.EaCb.Size = New System.Drawing.Size(176, 15)
        Me.EaCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.EaCb.TabIndex = 2
        Me.EaCb.Text = "Enable &Accounts on Creation"
        Me.EaCb.UseSelectable = True
        '
        'FpCb
        '
        Me.FpCb.AutoSize = True
        Me.FpCb.Checked = True
        Me.FpCb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FpCb.Location = New System.Drawing.Point(13, 22)
        Me.FpCb.Name = "FpCb"
        Me.FpCb.Size = New System.Drawing.Size(211, 15)
        Me.FpCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.FpCb.TabIndex = 1
        Me.FpCb.Text = "&Force Password Reset on First Login"
        Me.FpCb.UseSelectable = True
        '
        'ChCb
        '
        Me.ChCb.AutoSize = True
        Me.ChCb.Checked = True
        Me.ChCb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChCb.Location = New System.Drawing.Point(13, 45)
        Me.ChCb.Name = "ChCb"
        Me.ChCb.Size = New System.Drawing.Size(134, 15)
        Me.ChCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.ChCb.TabIndex = 0
        Me.ChCb.Text = "Create &Home Folders"
        Me.ChCb.UseSelectable = True
        '
        'Preferences
        '
        Me.Preferences.Controls.Add(Me.GroupBox2)
        Me.Preferences.Controls.Add(Me.DbGb)
        Me.Preferences.HorizontalScrollbarBarColor = True
        Me.Preferences.HorizontalScrollbarHighlightOnWheel = False
        Me.Preferences.HorizontalScrollbarSize = 10
        Me.Preferences.Location = New System.Drawing.Point(4, 38)
        Me.Preferences.Name = "Preferences"
        Me.Preferences.Padding = New System.Windows.Forms.Padding(3)
        Me.Preferences.Size = New System.Drawing.Size(494, 256)
        Me.Preferences.TabIndex = 0
        Me.Preferences.Text = "Preferences"
        Me.Preferences.UseVisualStyleBackColor = True
        Me.Preferences.VerticalScrollbarBarColor = True
        Me.Preferences.VerticalScrollbarHighlightOnWheel = False
        Me.Preferences.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.AutoLoginToggle)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.ProxyToggle)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 172)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(99, 58)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(255, 15)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Automatically Login when remember me is checkd"
        '
        'AutoLoginToggle
        '
        Me.AutoLoginToggle.AutoSize = True
        Me.AutoLoginToggle.Location = New System.Drawing.Point(13, 56)
        Me.AutoLoginToggle.Name = "AutoLoginToggle"
        Me.AutoLoginToggle.Size = New System.Drawing.Size(80, 17)
        Me.AutoLoginToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.AutoLoginToggle.TabIndex = 2
        Me.AutoLoginToggle.Text = "Off"
        Me.AutoLoginToggle.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(99, 31)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(96, 15)
        Me.MetroLabel3.TabIndex = 1
        Me.MetroLabel3.Text = "Use System Proxy"
        '
        'ProxyToggle
        '
        Me.ProxyToggle.AutoSize = True
        Me.ProxyToggle.Location = New System.Drawing.Point(13, 31)
        Me.ProxyToggle.Name = "ProxyToggle"
        Me.ProxyToggle.Size = New System.Drawing.Size(80, 17)
        Me.ProxyToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.ProxyToggle.TabIndex = 0
        Me.ProxyToggle.Text = "Off"
        Me.ProxyToggle.UseSelectable = True
        '
        'DbGb
        '
        Me.DbGb.BackColor = System.Drawing.SystemColors.Window
        Me.DbGb.Controls.Add(Me.CoCb)
        Me.DbGb.Controls.Add(Me.VbCb)
        Me.DbGb.Location = New System.Drawing.Point(7, 189)
        Me.DbGb.Name = "DbGb"
        Me.DbGb.Size = New System.Drawing.Size(481, 67)
        Me.DbGb.TabIndex = 3
        Me.DbGb.TabStop = False
        Me.DbGb.Text = "Debugging"
        '
        'CoCb
        '
        Me.CoCb.AutoSize = True
        Me.CoCb.Enabled = False
        Me.CoCb.Location = New System.Drawing.Point(13, 42)
        Me.CoCb.Name = "CoCb"
        Me.CoCb.Size = New System.Drawing.Size(169, 15)
        Me.CoCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.CoCb.TabIndex = 3
        Me.CoCb.Text = "Enable Live &Console Output"
        Me.CoCb.UseSelectable = True
        '
        'VbCb
        '
        Me.VbCb.AutoSize = True
        Me.VbCb.Enabled = False
        Me.VbCb.Location = New System.Drawing.Point(13, 19)
        Me.VbCb.Name = "VbCb"
        Me.VbCb.Size = New System.Drawing.Size(150, 15)
        Me.VbCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.VbCb.TabIndex = 2
        Me.VbCb.Text = "Enable &Verbose Logging"
        Me.VbCb.UseSelectable = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Preferences)
        Me.TabControl1.Controls.Add(Me.LDAPTabPage)
        Me.TabControl1.Controls.Add(Me.Ofice365TabPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(502, 298)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Purple
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.UseSelectable = True
        '
        'Ofice365TabPage
        '
        Me.Ofice365TabPage.Controls.Add(Me.Advanced365Gb)
        Me.Ofice365TabPage.Controls.Add(Me.GroupBox1)
        Me.Ofice365TabPage.HorizontalScrollbarBarColor = True
        Me.Ofice365TabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.Ofice365TabPage.HorizontalScrollbarSize = 10
        Me.Ofice365TabPage.Location = New System.Drawing.Point(4, 38)
        Me.Ofice365TabPage.Name = "Ofice365TabPage"
        Me.Ofice365TabPage.Size = New System.Drawing.Size(494, 256)
        Me.Ofice365TabPage.TabIndex = 2
        Me.Ofice365TabPage.Text = "Office 365"
        Me.Ofice365TabPage.VerticalScrollbarBarColor = True
        Me.Ofice365TabPage.VerticalScrollbarHighlightOnWheel = False
        Me.Ofice365TabPage.VerticalScrollbarSize = 10
        '
        'Advanced365Gb
        '
        Me.Advanced365Gb.BackColor = System.Drawing.SystemColors.Window
        Me.Advanced365Gb.Controls.Add(Me.ResetShellURIBn)
        Me.Advanced365Gb.Controls.Add(Me.MetroLabel2)
        Me.Advanced365Gb.Controls.Add(Me.ShellURITb)
        Me.Advanced365Gb.Controls.Add(Me.ResetURIBn)
        Me.Advanced365Gb.Controls.Add(Me.MetroLabel1)
        Me.Advanced365Gb.Controls.Add(Me.URITb)
        Me.Advanced365Gb.Location = New System.Drawing.Point(7, 122)
        Me.Advanced365Gb.Name = "Advanced365Gb"
        Me.Advanced365Gb.Size = New System.Drawing.Size(484, 105)
        Me.Advanced365Gb.TabIndex = 3
        Me.Advanced365Gb.TabStop = False
        Me.Advanced365Gb.Text = "Advanced"
        '
        'ResetShellURIBn
        '
        Me.ResetShellURIBn.Location = New System.Drawing.Point(365, 53)
        Me.ResetShellURIBn.Name = "ResetShellURIBn"
        Me.ResetShellURIBn.Size = New System.Drawing.Size(97, 23)
        Me.ResetShellURIBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.ResetShellURIBn.TabIndex = 5
        Me.ResetShellURIBn.Text = "Restore Default"
        Me.ResetShellURIBn.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 58)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(59, 15)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Shell URI: "
        '
        'ShellURITb
        '
        '
        '
        '
        Me.ShellURITb.CustomButton.Image = Nothing
        Me.ShellURITb.CustomButton.Location = New System.Drawing.Point(222, 1)
        Me.ShellURITb.CustomButton.Name = ""
        Me.ShellURITb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.ShellURITb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ShellURITb.CustomButton.TabIndex = 1
        Me.ShellURITb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ShellURITb.CustomButton.UseSelectable = True
        Me.ShellURITb.CustomButton.Visible = False
        Me.ShellURITb.Lines = New String(-1) {}
        Me.ShellURITb.Location = New System.Drawing.Point(115, 53)
        Me.ShellURITb.MaxLength = 32767
        Me.ShellURITb.Name = "ShellURITb"
        Me.ShellURITb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ShellURITb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ShellURITb.SelectedText = ""
        Me.ShellURITb.SelectionLength = 0
        Me.ShellURITb.SelectionStart = 0
        Me.ShellURITb.ShortcutsEnabled = True
        Me.ShellURITb.Size = New System.Drawing.Size(244, 23)
        Me.ShellURITb.Style = MetroFramework.MetroColorStyle.Purple
        Me.ShellURITb.TabIndex = 3
        Me.ShellURITb.UseSelectable = True
        Me.ShellURITb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ShellURITb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ResetURIBn
        '
        Me.ResetURIBn.Location = New System.Drawing.Point(365, 24)
        Me.ResetURIBn.Name = "ResetURIBn"
        Me.ResetURIBn.Size = New System.Drawing.Size(97, 23)
        Me.ResetURIBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.ResetURIBn.TabIndex = 2
        Me.ResetURIBn.Text = "Restore Default"
        Me.ResetURIBn.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(96, 15)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Connection URI: "
        '
        'URITb
        '
        '
        '
        '
        Me.URITb.CustomButton.Image = Nothing
        Me.URITb.CustomButton.Location = New System.Drawing.Point(222, 1)
        Me.URITb.CustomButton.Name = ""
        Me.URITb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.URITb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.URITb.CustomButton.TabIndex = 1
        Me.URITb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.URITb.CustomButton.UseSelectable = True
        Me.URITb.CustomButton.Visible = False
        Me.URITb.Lines = New String(-1) {}
        Me.URITb.Location = New System.Drawing.Point(115, 24)
        Me.URITb.MaxLength = 32767
        Me.URITb.Name = "URITb"
        Me.URITb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.URITb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.URITb.SelectedText = ""
        Me.URITb.SelectionLength = 0
        Me.URITb.SelectionStart = 0
        Me.URITb.ShortcutsEnabled = True
        Me.URITb.Size = New System.Drawing.Size(244, 23)
        Me.URITb.Style = MetroFramework.MetroColorStyle.Purple
        Me.URITb.TabIndex = 0
        Me.URITb.UseSelectable = True
        Me.URITb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.URITb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.results365Lb)
        Me.GroupBox1.Controls.Add(Me.results365Tb)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preferences"
        '
        'results365Lb
        '
        Me.results365Lb.AutoSize = True
        Me.results365Lb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.results365Lb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.results365Lb.Location = New System.Drawing.Point(13, 29)
        Me.results365Lb.Name = "results365Lb"
        Me.results365Lb.Size = New System.Drawing.Size(122, 15)
        Me.results365Lb.TabIndex = 1
        Me.results365Lb.Text = "Maximum Result Size:"
        '
        'results365Tb
        '
        '
        '
        '
        Me.results365Tb.CustomButton.Image = Nothing
        Me.results365Tb.CustomButton.Location = New System.Drawing.Point(37, 1)
        Me.results365Tb.CustomButton.Name = ""
        Me.results365Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.results365Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.results365Tb.CustomButton.TabIndex = 1
        Me.results365Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.results365Tb.CustomButton.UseSelectable = True
        Me.results365Tb.CustomButton.Visible = False
        Me.results365Tb.Lines = New String(-1) {}
        Me.results365Tb.Location = New System.Drawing.Point(138, 24)
        Me.results365Tb.MaxLength = 32767
        Me.results365Tb.Name = "results365Tb"
        Me.results365Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.results365Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.results365Tb.SelectedText = ""
        Me.results365Tb.SelectionLength = 0
        Me.results365Tb.SelectionStart = 0
        Me.results365Tb.ShortcutsEnabled = True
        Me.results365Tb.Size = New System.Drawing.Size(59, 23)
        Me.results365Tb.Style = MetroFramework.MetroColorStyle.Purple
        Me.results365Tb.TabIndex = 0
        Me.results365Tb.UseSelectable = True
        Me.results365Tb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.results365Tb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FormOptions
        '
        Me.AcceptButton = Me.OKBt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CnBt
        Me.ClientSize = New System.Drawing.Size(537, 372)
        Me.Controls.Add(Me.CnBt)
        Me.Controls.Add(Me.OKBt)
        Me.Controls.Add(Me.TabControl1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOptions"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Options"
        Me.LDAPTabPage.ResumeLayout(False)
        Me.ReportsGb.ResumeLayout(False)
        Me.ReportsGb.PerformLayout()
        Me.GnGb.ResumeLayout(False)
        Me.GnGb.PerformLayout()
        Me.Preferences.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DbGb.ResumeLayout(False)
        Me.DbGb.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Ofice365TabPage.ResumeLayout(False)
        Me.Advanced365Gb.ResumeLayout(False)
        Me.Advanced365Gb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OKBt As MetroFramework.Controls.MetroButton
    Friend WithEvents CnBt As MetroFramework.Controls.MetroButton
    Friend WithEvents LDAPTabPage As Controls.MetroTabPage
    Friend WithEvents ReportsGb As GroupBox
    Friend WithEvents LaCb As Controls.MetroCheckBox
    Friend WithEvents GnGb As GroupBox
    Friend WithEvents EaCb As Controls.MetroCheckBox
    Friend WithEvents FpCb As Controls.MetroCheckBox
    Friend WithEvents ChCb As Controls.MetroCheckBox
    Friend WithEvents Preferences As Controls.MetroTabPage
    Friend WithEvents DbGb As GroupBox
    Friend WithEvents CoCb As Controls.MetroCheckBox
    Friend WithEvents VbCb As Controls.MetroCheckBox
    Friend WithEvents TabControl1 As Controls.MetroTabControl
    Friend WithEvents Ofice365TabPage As Controls.MetroTabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents results365Lb As Controls.MetroLabel
    Friend WithEvents results365Tb As Controls.MetroTextBox
    Friend WithEvents Advanced365Gb As GroupBox
    Friend WithEvents MetroLabel1 As Controls.MetroLabel
    Friend WithEvents URITb As Controls.MetroTextBox
    Friend WithEvents ResetURIBn As Controls.MetroButton
    Friend WithEvents ResetShellURIBn As Controls.MetroButton
    Friend WithEvents MetroLabel2 As Controls.MetroLabel
    Friend WithEvents ShellURITb As Controls.MetroTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel3 As Controls.MetroLabel
    Friend WithEvents ProxyToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel4 As Controls.MetroLabel
    Friend WithEvents AutoLoginToggle As Controls.MetroToggle
End Class
