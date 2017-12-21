<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        Me.OKBt = New MetroFramework.Controls.MetroButton()
        Me.CnBt = New MetroFramework.Controls.MetroButton()
        Me.LDAPTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PasswordTb = New MetroFramework.Controls.MetroTextBox()
        Me.UsernameTb = New MetroFramework.Controls.MetroTextBox()
        Me.ManualRadioBn = New System.Windows.Forms.RadioButton()
        Me.AutoRadioBn = New System.Windows.Forms.RadioButton()
        Me.ReportsGb = New System.Windows.Forms.GroupBox()
        Me.UpCb = New MetroFramework.Controls.MetroCheckBox()
        Me.Preferences = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel5 = New System.Windows.Forms.Label()
        Me.IconsToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel4 = New System.Windows.Forms.Label()
        Me.AutoLoginToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel3 = New System.Windows.Forms.Label()
        Me.ProxyToggle = New MetroFramework.Controls.MetroToggle()
        Me.DbGb = New System.Windows.Forms.GroupBox()
        Me.CoCb = New MetroFramework.Controls.MetroCheckBox()
        Me.VbCb = New MetroFramework.Controls.MetroCheckBox()
        Me.MainTabControl = New MetroFramework.Controls.MetroTabControl()
        Me.InterfaceTab = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WindowsStylingToggle = New MetroFramework.Controls.MetroToggle()
        Me.LDAPTabPage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ReportsGb.SuspendLayout()
        Me.Preferences.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DbGb.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.InterfaceTab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKBt
        '
        Me.OKBt.Location = New System.Drawing.Point(450, 337)
        Me.OKBt.Name = "OKBt"
        Me.OKBt.Size = New System.Drawing.Size(75, 23)
        Me.OKBt.TabIndex = 1
        Me.OKBt.Text = "OK"
        Me.OKBt.UseSelectable = True
        '
        'CnBt
        '
        Me.CnBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CnBt.Location = New System.Drawing.Point(369, 337)
        Me.CnBt.Name = "CnBt"
        Me.CnBt.Size = New System.Drawing.Size(75, 23)
        Me.CnBt.TabIndex = 2
        Me.CnBt.Text = "Cancel"
        Me.CnBt.UseSelectable = True
        '
        'LDAPTabPage
        '
        Me.LDAPTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.LDAPTabPage.Controls.Add(Me.GroupBox1)
        Me.LDAPTabPage.Controls.Add(Me.ReportsGb)
        Me.LDAPTabPage.HorizontalScrollbarBarColor = True
        Me.LDAPTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.LDAPTabPage.HorizontalScrollbarSize = 10
        Me.LDAPTabPage.Location = New System.Drawing.Point(4, 38)
        Me.LDAPTabPage.Name = "LDAPTabPage"
        Me.LDAPTabPage.Size = New System.Drawing.Size(503, 266)
        Me.LDAPTabPage.TabIndex = 1
        Me.LDAPTabPage.Text = "Active Directory"
        Me.LDAPTabPage.UseCustomBackColor = True
        Me.LDAPTabPage.VerticalScrollbarBarColor = True
        Me.LDAPTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.LDAPTabPage.VerticalScrollbarSize = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.PasswordTb)
        Me.GroupBox1.Controls.Add(Me.UsernameTb)
        Me.GroupBox1.Controls.Add(Me.ManualRadioBn)
        Me.GroupBox1.Controls.Add(Me.AutoRadioBn)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 158)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'PasswordTb
        '
        '
        '
        '
        Me.PasswordTb.CustomButton.Image = Nothing
        Me.PasswordTb.CustomButton.Location = New System.Drawing.Point(209, 1)
        Me.PasswordTb.CustomButton.Name = ""
        Me.PasswordTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PasswordTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTb.CustomButton.TabIndex = 1
        Me.PasswordTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTb.CustomButton.UseSelectable = True
        Me.PasswordTb.CustomButton.Visible = False
        Me.PasswordTb.Lines = New String(-1) {}
        Me.PasswordTb.Location = New System.Drawing.Point(13, 107)
        Me.PasswordTb.MaxLength = 32767
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTb.SelectedText = ""
        Me.PasswordTb.SelectionLength = 0
        Me.PasswordTb.SelectionStart = 0
        Me.PasswordTb.ShortcutsEnabled = True
        Me.PasswordTb.Size = New System.Drawing.Size(231, 23)
        Me.PasswordTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.PasswordTb.TabIndex = 3
        Me.PasswordTb.UseSelectable = True
        Me.PasswordTb.WaterMark = "Password"
        Me.PasswordTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UsernameTb
        '
        '
        '
        '
        Me.UsernameTb.CustomButton.Image = Nothing
        Me.UsernameTb.CustomButton.Location = New System.Drawing.Point(209, 1)
        Me.UsernameTb.CustomButton.Name = ""
        Me.UsernameTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsernameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTb.CustomButton.TabIndex = 1
        Me.UsernameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTb.CustomButton.UseSelectable = True
        Me.UsernameTb.CustomButton.Visible = False
        Me.UsernameTb.Lines = New String(-1) {}
        Me.UsernameTb.Location = New System.Drawing.Point(13, 77)
        Me.UsernameTb.MaxLength = 32767
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTb.SelectedText = ""
        Me.UsernameTb.SelectionLength = 0
        Me.UsernameTb.SelectionStart = 0
        Me.UsernameTb.ShortcutsEnabled = True
        Me.UsernameTb.Size = New System.Drawing.Size(231, 23)
        Me.UsernameTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.UsernameTb.TabIndex = 2
        Me.UsernameTb.UseSelectable = True
        Me.UsernameTb.WaterMark = "Username"
        Me.UsernameTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ManualRadioBn
        '
        Me.ManualRadioBn.AutoSize = True
        Me.ManualRadioBn.Location = New System.Drawing.Point(13, 46)
        Me.ManualRadioBn.Name = "ManualRadioBn"
        Me.ManualRadioBn.Size = New System.Drawing.Size(160, 17)
        Me.ManualRadioBn.TabIndex = 1
        Me.ManualRadioBn.TabStop = True
        Me.ManualRadioBn.Text = "Use the following credentials"
        Me.ManualRadioBn.UseVisualStyleBackColor = True
        '
        'AutoRadioBn
        '
        Me.AutoRadioBn.AutoSize = True
        Me.AutoRadioBn.Location = New System.Drawing.Point(13, 19)
        Me.AutoRadioBn.Name = "AutoRadioBn"
        Me.AutoRadioBn.Size = New System.Drawing.Size(72, 17)
        Me.AutoRadioBn.TabIndex = 0
        Me.AutoRadioBn.TabStop = True
        Me.AutoRadioBn.Text = "Automatic"
        Me.AutoRadioBn.UseVisualStyleBackColor = True
        '
        'ReportsGb
        '
        Me.ReportsGb.BackColor = System.Drawing.SystemColors.Window
        Me.ReportsGb.Controls.Add(Me.UpCb)
        Me.ReportsGb.Location = New System.Drawing.Point(0, 11)
        Me.ReportsGb.Name = "ReportsGb"
        Me.ReportsGb.Size = New System.Drawing.Size(494, 88)
        Me.ReportsGb.TabIndex = 7
        Me.ReportsGb.TabStop = False
        Me.ReportsGb.Text = "Reports"
        '
        'UpCb
        '
        Me.UpCb.AutoSize = True
        Me.UpCb.Location = New System.Drawing.Point(13, 31)
        Me.UpCb.Name = "UpCb"
        Me.UpCb.Size = New System.Drawing.Size(143, 15)
        Me.UpCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.UpCb.TabIndex = 3
        Me.UpCb.Text = "Use Paging for Reports"
        Me.UpCb.UseCustomBackColor = True
        Me.UpCb.UseSelectable = True
        '
        'Preferences
        '
        Me.Preferences.BackColor = System.Drawing.SystemColors.Window
        Me.Preferences.Controls.Add(Me.GroupBox2)
        Me.Preferences.Controls.Add(Me.DbGb)
        Me.Preferences.HorizontalScrollbarBarColor = True
        Me.Preferences.HorizontalScrollbarHighlightOnWheel = False
        Me.Preferences.HorizontalScrollbarSize = 10
        Me.Preferences.Location = New System.Drawing.Point(4, 38)
        Me.Preferences.Name = "Preferences"
        Me.Preferences.Padding = New System.Windows.Forms.Padding(3)
        Me.Preferences.Size = New System.Drawing.Size(503, 266)
        Me.Preferences.TabIndex = 0
        Me.Preferences.Text = "Preferences"
        Me.Preferences.UseCustomBackColor = True
        Me.Preferences.VerticalScrollbarBarColor = True
        Me.Preferences.VerticalScrollbarHighlightOnWheel = False
        Me.Preferences.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.IconsToggle)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.AutoLoginToggle)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.ProxyToggle)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 180)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(99, 90)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(180, 13)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Use System Icons (Requires Restart)"
        '
        'IconsToggle
        '
        Me.IconsToggle.AutoSize = True
        Me.IconsToggle.Location = New System.Drawing.Point(13, 88)
        Me.IconsToggle.Name = "IconsToggle"
        Me.IconsToggle.Size = New System.Drawing.Size(80, 17)
        Me.IconsToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.IconsToggle.TabIndex = 4
        Me.IconsToggle.Text = "Off"
        Me.IconsToggle.UseCustomBackColor = True
        Me.IconsToggle.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(99, 62)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(252, 13)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Automatically Login when 'Remember Me' is checkd"
        '
        'AutoLoginToggle
        '
        Me.AutoLoginToggle.AutoSize = True
        Me.AutoLoginToggle.Location = New System.Drawing.Point(13, 60)
        Me.AutoLoginToggle.Name = "AutoLoginToggle"
        Me.AutoLoginToggle.Size = New System.Drawing.Size(80, 17)
        Me.AutoLoginToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.AutoLoginToggle.TabIndex = 2
        Me.AutoLoginToggle.Text = "Off"
        Me.AutoLoginToggle.UseCustomBackColor = True
        Me.AutoLoginToggle.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(99, 33)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(150, 13)
        Me.MetroLabel3.TabIndex = 1
        Me.MetroLabel3.Text = "Use System Proxy for Updates"
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
        Me.ProxyToggle.UseCustomBackColor = True
        Me.ProxyToggle.UseSelectable = True
        '
        'DbGb
        '
        Me.DbGb.BackColor = System.Drawing.SystemColors.Window
        Me.DbGb.Controls.Add(Me.CoCb)
        Me.DbGb.Controls.Add(Me.VbCb)
        Me.DbGb.Location = New System.Drawing.Point(0, 197)
        Me.DbGb.Name = "DbGb"
        Me.DbGb.Size = New System.Drawing.Size(494, 67)
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
        Me.CoCb.UseCustomBackColor = True
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
        Me.VbCb.UseCustomBackColor = True
        Me.VbCb.UseSelectable = True
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.Preferences)
        Me.MainTabControl.Controls.Add(Me.LDAPTabPage)
        Me.MainTabControl.Controls.Add(Me.InterfaceTab)
        Me.MainTabControl.Location = New System.Drawing.Point(13, 13)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 1
        Me.MainTabControl.Size = New System.Drawing.Size(511, 308)
        Me.MainTabControl.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainTabControl.TabIndex = 0
        Me.MainTabControl.UseSelectable = True
        '
        'InterfaceTab
        '
        Me.InterfaceTab.Controls.Add(Me.GroupBox3)
        Me.InterfaceTab.HorizontalScrollbarBarColor = True
        Me.InterfaceTab.HorizontalScrollbarHighlightOnWheel = False
        Me.InterfaceTab.HorizontalScrollbarSize = 10
        Me.InterfaceTab.Location = New System.Drawing.Point(4, 38)
        Me.InterfaceTab.Name = "InterfaceTab"
        Me.InterfaceTab.Size = New System.Drawing.Size(503, 266)
        Me.InterfaceTab.TabIndex = 2
        Me.InterfaceTab.Text = "Interface"
        Me.InterfaceTab.VerticalScrollbarBarColor = True
        Me.InterfaceTab.VerticalScrollbarHighlightOnWheel = False
        Me.InterfaceTab.VerticalScrollbarSize = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.WindowsStylingToggle)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(494, 180)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "General"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Use native Windows styling were possible"
        '
        'WindowsStylingToggle
        '
        Me.WindowsStylingToggle.AutoSize = True
        Me.WindowsStylingToggle.Location = New System.Drawing.Point(13, 31)
        Me.WindowsStylingToggle.Name = "WindowsStylingToggle"
        Me.WindowsStylingToggle.Size = New System.Drawing.Size(80, 17)
        Me.WindowsStylingToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.WindowsStylingToggle.TabIndex = 0
        Me.WindowsStylingToggle.Text = "Off"
        Me.WindowsStylingToggle.UseCustomBackColor = True
        Me.WindowsStylingToggle.UseSelectable = True
        '
        'FormOptions
        '
        Me.AcceptButton = Me.OKBt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CnBt
        Me.ClientSize = New System.Drawing.Size(537, 372)
        Me.Controls.Add(Me.CnBt)
        Me.Controls.Add(Me.OKBt)
        Me.Controls.Add(Me.MainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOptions"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.LDAPTabPage.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ReportsGb.ResumeLayout(False)
        Me.ReportsGb.PerformLayout()
        Me.Preferences.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DbGb.ResumeLayout(False)
        Me.DbGb.PerformLayout()
        Me.MainTabControl.ResumeLayout(False)
        Me.InterfaceTab.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OKBt As Controls.MetroButton
    Friend WithEvents CnBt As Controls.MetroButton
    Friend WithEvents LDAPTabPage As Controls.MetroTabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PasswordTb As Controls.MetroTextBox
    Friend WithEvents UsernameTb As Controls.MetroTextBox
    Friend WithEvents ManualRadioBn As RadioButton
    Friend WithEvents AutoRadioBn As RadioButton
    Friend WithEvents ReportsGb As GroupBox
    Friend WithEvents UpCb As Controls.MetroCheckBox
    Friend WithEvents Preferences As Controls.MetroTabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel5 As Label
    Friend WithEvents IconsToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel4 As Label
    Friend WithEvents AutoLoginToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel3 As Label
    Friend WithEvents ProxyToggle As Controls.MetroToggle
    Friend WithEvents DbGb As GroupBox
    Friend WithEvents CoCb As Controls.MetroCheckBox
    Friend WithEvents VbCb As Controls.MetroCheckBox
    Friend WithEvents MainTabControl As Controls.MetroTabControl
    Friend WithEvents InterfaceTab As Controls.MetroTabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents WindowsStylingToggle As Controls.MetroToggle
End Class
