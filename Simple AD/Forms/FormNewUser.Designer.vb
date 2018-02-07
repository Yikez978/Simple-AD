Imports System.Windows.Forms
Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewUser))
        Me.SnTb = New SimpleAD.ControlTextBox()
        Me.FnTb = New SimpleAD.ControlTextBox()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.Pass1Tb = New SimpleAD.ControlTextBox()
        Me.Pass0Tb = New SimpleAD.ControlTextBox()
        Me.FullnTb = New SimpleAD.ControlTextBox()
        Me.ChangePassCb = New System.Windows.Forms.CheckBox()
        Me.CannotChangePassCb = New System.Windows.Forms.CheckBox()
        Me.PassNeverExpiresCb = New System.Windows.Forms.CheckBox()
        Me.AccountDisabledCb = New System.Windows.Forms.CheckBox()
        Me.UsernameTb = New SimpleAD.ControlTextBox()
        Me.ContainerLb = New System.Windows.Forms.LinkLabel()
        Me.ContainerPb = New System.Windows.Forms.PictureBox()
        Me.ErrorLb = New System.Windows.Forms.Label()
        Me.OkBn = New System.Windows.Forms.Button()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.BasicTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExtendedTab = New System.Windows.Forms.TabPage()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImagePl.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.BasicTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'SnTb
        '
        Me.SnTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SnTb.Location = New System.Drawing.Point(122, 66)
        Me.SnTb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.SnTb.Name = "SnTb"
        Me.SnTb.PromptText = "Surname"
        Me.SnTb.Size = New System.Drawing.Size(266, 22)
        Me.SnTb.TabIndex = 1
        '
        'FnTb
        '
        Me.FnTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FnTb.Location = New System.Drawing.Point(122, 38)
        Me.FnTb.MaximumSize = New System.Drawing.Size(266, 22)
        Me.FnTb.MinimumSize = New System.Drawing.Size(266, 22)
        Me.FnTb.Name = "FnTb"
        Me.FnTb.PromptText = "Firstname"
        Me.FnTb.Size = New System.Drawing.Size(266, 22)
        Me.FnTb.TabIndex = 0
        '
        'MainPb
        '
        Me.MainPb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MainPb.BackColor = System.Drawing.SystemColors.Window
        Me.MainPb.Location = New System.Drawing.Point(16, 17)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(100, 100)
        Me.MainPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MainPb.TabIndex = 21
        Me.MainPb.TabStop = False
        '
        'Pass1Tb
        '
        Me.Pass1Tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pass1Tb.Location = New System.Drawing.Point(16, 307)
        Me.Pass1Tb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.Pass1Tb.Name = "Pass1Tb"
        Me.Pass1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Pass1Tb.PromptText = "Confirm Password"
        Me.Pass1Tb.Size = New System.Drawing.Size(373, 22)
        Me.Pass1Tb.TabIndex = 9
        '
        'Pass0Tb
        '
        Me.Pass0Tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pass0Tb.Location = New System.Drawing.Point(16, 278)
        Me.Pass0Tb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.Pass0Tb.Name = "Pass0Tb"
        Me.Pass0Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Pass0Tb.PromptText = "Password"
        Me.Pass0Tb.Size = New System.Drawing.Size(373, 22)
        Me.Pass0Tb.TabIndex = 8
        '
        'FullnTb
        '
        Me.FullnTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FullnTb.Location = New System.Drawing.Point(122, 94)
        Me.FullnTb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.FullnTb.Name = "FullnTb"
        Me.FullnTb.PromptText = "Display Name"
        Me.FullnTb.Size = New System.Drawing.Size(266, 22)
        Me.FullnTb.TabIndex = 2
        '
        'ChangePassCb
        '
        Me.ChangePassCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChangePassCb.AutoSize = True
        Me.ChangePassCb.BackColor = System.Drawing.SystemColors.Window
        Me.ChangePassCb.Location = New System.Drawing.Point(16, 173)
        Me.ChangePassCb.Name = "ChangePassCb"
        Me.ChangePassCb.Size = New System.Drawing.Size(224, 17)
        Me.ChangePassCb.TabIndex = 4
        Me.ChangePassCb.Text = "User must change password at next logon"
        Me.ChangePassCb.UseVisualStyleBackColor = False
        '
        'CannotChangePassCb
        '
        Me.CannotChangePassCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CannotChangePassCb.AutoSize = True
        Me.CannotChangePassCb.BackColor = System.Drawing.SystemColors.Window
        Me.CannotChangePassCb.Location = New System.Drawing.Point(16, 196)
        Me.CannotChangePassCb.Name = "CannotChangePassCb"
        Me.CannotChangePassCb.Size = New System.Drawing.Size(171, 17)
        Me.CannotChangePassCb.TabIndex = 5
        Me.CannotChangePassCb.Text = "User cannot change password"
        Me.CannotChangePassCb.UseVisualStyleBackColor = False
        '
        'PassNeverExpiresCb
        '
        Me.PassNeverExpiresCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PassNeverExpiresCb.AutoSize = True
        Me.PassNeverExpiresCb.BackColor = System.Drawing.SystemColors.Window
        Me.PassNeverExpiresCb.Location = New System.Drawing.Point(16, 219)
        Me.PassNeverExpiresCb.Name = "PassNeverExpiresCb"
        Me.PassNeverExpiresCb.Size = New System.Drawing.Size(138, 17)
        Me.PassNeverExpiresCb.TabIndex = 6
        Me.PassNeverExpiresCb.Text = "Password never expires"
        Me.PassNeverExpiresCb.UseVisualStyleBackColor = False
        '
        'AccountDisabledCb
        '
        Me.AccountDisabledCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AccountDisabledCb.AutoSize = True
        Me.AccountDisabledCb.BackColor = System.Drawing.SystemColors.Window
        Me.AccountDisabledCb.Location = New System.Drawing.Point(16, 242)
        Me.AccountDisabledCb.Name = "AccountDisabledCb"
        Me.AccountDisabledCb.Size = New System.Drawing.Size(118, 17)
        Me.AccountDisabledCb.TabIndex = 7
        Me.AccountDisabledCb.Text = "Account is disabled"
        Me.AccountDisabledCb.UseVisualStyleBackColor = False
        '
        'UsernameTb
        '
        Me.UsernameTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UsernameTb.Location = New System.Drawing.Point(16, 132)
        Me.UsernameTb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.PromptText = "Username"
        Me.UsernameTb.Size = New System.Drawing.Size(372, 22)
        Me.UsernameTb.TabIndex = 3
        '
        'ContainerLb
        '
        Me.ContainerLb.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContainerLb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ContainerLb.AutoSize = True
        Me.ContainerLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerLb.LinkColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ContainerLb.Location = New System.Drawing.Point(193, 14)
        Me.ContainerLb.Name = "ContainerLb"
        Me.ContainerLb.Size = New System.Drawing.Size(61, 13)
        Me.ContainerLb.TabIndex = 23
        Me.ContainerLb.TabStop = True
        Me.ContainerLb.Text = "Container"
        '
        'ContainerPb
        '
        Me.ContainerPb.Location = New System.Drawing.Point(127, 12)
        Me.ContainerPb.Name = "ContainerPb"
        Me.ContainerPb.Size = New System.Drawing.Size(16, 16)
        Me.ContainerPb.TabIndex = 24
        Me.ContainerPb.TabStop = False
        '
        'ErrorLb
        '
        Me.ErrorLb.AutoSize = True
        Me.ErrorLb.ForeColor = System.Drawing.Color.Red
        Me.ErrorLb.Location = New System.Drawing.Point(29, 455)
        Me.ErrorLb.Name = "ErrorLb"
        Me.ErrorLb.Size = New System.Drawing.Size(74, 13)
        Me.ErrorLb.TabIndex = 27
        Me.ErrorLb.Text = "Input not valid"
        Me.ErrorLb.Visible = False
        '
        'OkBn
        '
        Me.OkBn.Location = New System.Drawing.Point(269, 450)
        Me.OkBn.Name = "OkBn"
        Me.OkBn.Size = New System.Drawing.Size(75, 23)
        Me.OkBn.TabIndex = 28
        Me.OkBn.Text = "Accept"
        Me.OkBn.UseVisualStyleBackColor = True
        '
        'CancelBn
        '
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(350, 450)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 29
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
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
        Me.ImagePl.Size = New System.Drawing.Size(437, 56)
        Me.ImagePl.TabIndex = 30
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(41, 9)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(163, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Create New User"
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.BasicTab)
        Me.MainTabControl.Controls.Add(Me.ExtendedTab)
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.Location = New System.Drawing.Point(12, 62)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(413, 382)
        Me.MainTabControl.TabIndex = 31
        '
        'BasicTab
        '
        Me.BasicTab.BackColor = System.Drawing.SystemColors.Window
        Me.BasicTab.Controls.Add(Me.Label1)
        Me.BasicTab.Controls.Add(Me.ContainerLb)
        Me.BasicTab.Controls.Add(Me.ContainerPb)
        Me.BasicTab.Controls.Add(Me.Pass0Tb)
        Me.BasicTab.Controls.Add(Me.FnTb)
        Me.BasicTab.Controls.Add(Me.SnTb)
        Me.BasicTab.Controls.Add(Me.MainPb)
        Me.BasicTab.Controls.Add(Me.UsernameTb)
        Me.BasicTab.Controls.Add(Me.Pass1Tb)
        Me.BasicTab.Controls.Add(Me.AccountDisabledCb)
        Me.BasicTab.Controls.Add(Me.FullnTb)
        Me.BasicTab.Controls.Add(Me.PassNeverExpiresCb)
        Me.BasicTab.Controls.Add(Me.ChangePassCb)
        Me.BasicTab.Controls.Add(Me.CannotChangePassCb)
        Me.BasicTab.Location = New System.Drawing.Point(4, 22)
        Me.BasicTab.Name = "BasicTab"
        Me.BasicTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BasicTab.Size = New System.Drawing.Size(405, 356)
        Me.BasicTab.TabIndex = 0
        Me.BasicTab.Text = "Basic"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Container"
        '
        'ExtendedTab
        '
        Me.ExtendedTab.Location = New System.Drawing.Point(4, 22)
        Me.ExtendedTab.Name = "ExtendedTab"
        Me.ExtendedTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ExtendedTab.Size = New System.Drawing.Size(405, 356)
        Me.ExtendedTab.TabIndex = 1
        Me.ExtendedTab.Text = "Extended"
        Me.ExtendedTab.UseVisualStyleBackColor = True
        '
        'FormNewUser
        '
        Me.AcceptButton = Me.OkBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(437, 485)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.OkBn)
        Me.Controls.Add(Me.ErrorLb)
        Me.Controls.Add(Me.MainTabControl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNewUser"
        Me.Text = "Add User"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.MainTabControl.ResumeLayout(False)
        Me.BasicTab.ResumeLayout(False)
        Me.BasicTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SnTb As SimpleAD.ControlTextBox
    Friend WithEvents FnTb As SimpleAD.ControlTextBox
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents Pass1Tb As SimpleAD.ControlTextBox
    Friend WithEvents Pass0Tb As SimpleAD.ControlTextBox
    Friend WithEvents FullnTb As SimpleAD.ControlTextBox
    Friend WithEvents ChangePassCb As CheckBox
    Friend WithEvents CannotChangePassCb As CheckBox
    Friend WithEvents PassNeverExpiresCb As CheckBox
    Friend WithEvents AccountDisabledCb As CheckBox
    Friend WithEvents UsernameTb As SimpleAD.ControlTextBox
    Friend WithEvents ContainerLb As LinkLabel
    Friend WithEvents ContainerPb As PictureBox
    Friend WithEvents ErrorLb As Label
    Friend WithEvents OkBn As Button
    Friend WithEvents CancelBn As Button
    Friend WithEvents ImagePl As SimpleAD.ControlHeaderPanel
    Friend WithEvents TitleLb As Label
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents ExtendedTab As TabPage
    Friend WithEvents BasicTab As TabPage
    Friend WithEvents Label1 As Label
End Class
