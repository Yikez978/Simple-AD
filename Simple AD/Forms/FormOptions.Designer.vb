Imports System.Windows.Forms
Imports MetroFramework

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
        Me.OKBt = New System.Windows.Forms.Button()
        Me.CnBt = New System.Windows.Forms.Button()
        Me.LDAPTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PasswordTb = New SimpleAD.ControlTextBox()
        Me.UsernameTb = New SimpleAD.ControlTextBox()
        Me.ManualRadioBn = New System.Windows.Forms.RadioButton()
        Me.AutoRadioBn = New System.Windows.Forms.RadioButton()
        Me.ReportsGb = New System.Windows.Forms.GroupBox()
        Me.UpCb = New MetroFramework.Controls.MetroCheckBox()
        Me.Preferences = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel4 = New System.Windows.Forms.Label()
        Me.AutoLoginToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel3 = New System.Windows.Forms.Label()
        Me.ProxyToggle = New MetroFramework.Controls.MetroToggle()
        Me.DbGb = New System.Windows.Forms.GroupBox()
        Me.CoCb = New MetroFramework.Controls.MetroCheckBox()
        Me.VbCb = New MetroFramework.Controls.MetroCheckBox()
        Me.MainTabControl = New MetroFramework.Controls.MetroTabControl()
        Me.LDAPTabPage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ReportsGb.SuspendLayout()
        Me.Preferences.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DbGb.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKBt
        '
        Me.OKBt.Location = New System.Drawing.Point(450, 337)
        Me.OKBt.Name = "OKBt"
        Me.OKBt.Size = New System.Drawing.Size(75, 23)
        Me.OKBt.TabIndex = 1
        Me.OKBt.Text = "OK"
        Me.OKBt.UseVisualStyleBackColor = True
        '
        'CnBt
        '
        Me.CnBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CnBt.Location = New System.Drawing.Point(369, 337)
        Me.CnBt.Name = "CnBt"
        Me.CnBt.Size = New System.Drawing.Size(75, 23)
        Me.CnBt.TabIndex = 2
        Me.CnBt.Text = "Cancel"
        Me.CnBt.UseVisualStyleBackColor = True
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
        Me.LDAPTabPage.Text = "  Active Directory  "
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
        Me.GroupBox1.Size = New System.Drawing.Size(494, 159)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Authentication"
        '
        'PasswordTb
        '
        Me.PasswordTb.Location = New System.Drawing.Point(13, 107)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTb.PromptText = "Password"
        Me.PasswordTb.Size = New System.Drawing.Size(231, 20)
        Me.PasswordTb.TabIndex = 3
        '
        'UsernameTb
        '
        Me.UsernameTb.Location = New System.Drawing.Point(13, 77)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.PromptText = "Username"
        Me.UsernameTb.Size = New System.Drawing.Size(231, 20)
        Me.UsernameTb.TabIndex = 2
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
        Me.UpCb.Enabled = False
        Me.UpCb.Location = New System.Drawing.Point(13, 31)
        Me.UpCb.Name = "UpCb"
        Me.UpCb.Size = New System.Drawing.Size(175, 15)
        Me.UpCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.UpCb.TabIndex = 3
        Me.UpCb.Text = "Use Paging for Reports [WIP]"
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
        Me.Preferences.Text = "  Preferences  "
        Me.Preferences.UseCustomBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(0, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 180)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
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
        Me.MainTabControl.Location = New System.Drawing.Point(13, 13)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 1
        Me.MainTabControl.Size = New System.Drawing.Size(511, 308)
        Me.MainTabControl.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainTabControl.TabIndex = 0
        Me.MainTabControl.UseSelectable = True
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OKBt As Button
    Friend WithEvents CnBt As Button
    Friend WithEvents LDAPTabPage As Controls.MetroTabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PasswordTb As SimpleAD.ControlTextBox
    Friend WithEvents UsernameTb As SimpleAD.ControlTextBox
    Friend WithEvents ManualRadioBn As RadioButton
    Friend WithEvents AutoRadioBn As RadioButton
    Friend WithEvents ReportsGb As GroupBox
    Friend WithEvents UpCb As Controls.MetroCheckBox
    Friend WithEvents Preferences As Controls.MetroTabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel4 As Label
    Friend WithEvents AutoLoginToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel3 As Label
    Friend WithEvents ProxyToggle As Controls.MetroToggle
    Friend WithEvents DbGb As GroupBox
    Friend WithEvents CoCb As Controls.MetroCheckBox
    Friend WithEvents VbCb As Controls.MetroCheckBox
    Friend WithEvents MainTabControl As Controls.MetroTabControl
End Class
