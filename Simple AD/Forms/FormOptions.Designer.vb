<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        Me.LDAPTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.ReportsGb = New System.Windows.Forms.GroupBox()
        Me.LaCb = New MetroFramework.Controls.MetroCheckBox()
        Me.Preferences = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.IconsToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.AutoLoginToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.ProxyToggle = New MetroFramework.Controls.MetroToggle()
        Me.DbGb = New System.Windows.Forms.GroupBox()
        Me.CoCb = New MetroFramework.Controls.MetroCheckBox()
        Me.VbCb = New MetroFramework.Controls.MetroCheckBox()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.OKBt = New MetroFramework.Controls.MetroButton()
        Me.CnBt = New MetroFramework.Controls.MetroButton()
        Me.LDAPTabPage.SuspendLayout()
        Me.ReportsGb.SuspendLayout()
        Me.Preferences.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DbGb.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LDAPTabPage
        '
        Me.LDAPTabPage.BackColor = System.Drawing.SystemColors.Window
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
        'ReportsGb
        '
        Me.ReportsGb.BackColor = System.Drawing.SystemColors.Window
        Me.ReportsGb.Controls.Add(Me.LaCb)
        Me.ReportsGb.Location = New System.Drawing.Point(0, 11)
        Me.ReportsGb.Name = "ReportsGb"
        Me.ReportsGb.Size = New System.Drawing.Size(494, 250)
        Me.ReportsGb.TabIndex = 7
        Me.ReportsGb.TabStop = False
        Me.ReportsGb.Text = "Reports"
        '
        'LaCb
        '
        Me.LaCb.AutoSize = True
        Me.LaCb.Location = New System.Drawing.Point(13, 31)
        Me.LaCb.Name = "LaCb"
        Me.LaCb.Size = New System.Drawing.Size(160, 15)
        Me.LaCb.Style = MetroFramework.MetroColorStyle.Purple
        Me.LaCb.TabIndex = 3
        Me.LaCb.Text = "Load Advanced Attributes"
        Me.LaCb.UseCustomBackColor = True
        Me.LaCb.UseSelectable = True
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
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(99, 90)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(193, 15)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Use System Icons (Requires Restart)"
        Me.MetroLabel5.UseCustomBackColor = True
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
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(99, 62)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(285, 15)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Automatically Login when 'Remember Me' is checkd"
        Me.MetroLabel4.UseCustomBackColor = True
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
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(99, 33)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(163, 15)
        Me.MetroLabel3.TabIndex = 1
        Me.MetroLabel3.Text = "Use System Proxy for Updates"
        Me.MetroLabel3.UseCustomBackColor = True
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Preferences)
        Me.TabControl1.Controls.Add(Me.LDAPTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(511, 308)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Purple
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.UseSelectable = True
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
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOptions"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.LDAPTabPage.ResumeLayout(False)
        Me.ReportsGb.ResumeLayout(False)
        Me.ReportsGb.PerformLayout()
        Me.Preferences.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DbGb.ResumeLayout(False)
        Me.DbGb.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LDAPTabPage As Controls.MetroTabPage
    Friend WithEvents ReportsGb As GroupBox
    Friend WithEvents LaCb As Controls.MetroCheckBox
    Friend WithEvents Preferences As Controls.MetroTabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel5 As Controls.MetroLabel
    Friend WithEvents IconsToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel4 As Controls.MetroLabel
    Friend WithEvents AutoLoginToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel3 As Controls.MetroLabel
    Friend WithEvents ProxyToggle As Controls.MetroToggle
    Friend WithEvents DbGb As GroupBox
    Friend WithEvents CoCb As Controls.MetroCheckBox
    Friend WithEvents VbCb As Controls.MetroCheckBox
    Friend WithEvents TabControl1 As Controls.MetroTabControl
    Friend WithEvents OKBt As Controls.MetroButton
    Friend WithEvents CnBt As Controls.MetroButton
End Class
