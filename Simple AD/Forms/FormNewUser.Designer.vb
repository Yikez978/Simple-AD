<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewUser
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewUser))
        Me.SnTb = New MetroFramework.Controls.MetroTextBox()
        Me.FnTb = New MetroFramework.Controls.MetroTextBox()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.Pass1Tb = New MetroFramework.Controls.MetroTextBox()
        Me.Pass0Tb = New MetroFramework.Controls.MetroTextBox()
        Me.FullnTb = New MetroFramework.Controls.MetroTextBox()
        Me.ChangePassCb = New System.Windows.Forms.CheckBox()
        Me.CannotChangePassCb = New System.Windows.Forms.CheckBox()
        Me.PassNeverExpiresCb = New System.Windows.Forms.CheckBox()
        Me.AccountDisabledCb = New System.Windows.Forms.CheckBox()
        Me.UsernameTb = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContainerLb = New System.Windows.Forms.Label()
        Me.ContainerPb = New System.Windows.Forms.PictureBox()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        Me.OkBn = New MetroFramework.Controls.MetroButton()
        Me.ErrorLb = New System.Windows.Forms.Label()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlFooterPl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SnTb
        '
        Me.SnTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.SnTb.CustomButton.Image = Nothing
        Me.SnTb.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.SnTb.CustomButton.Name = ""
        Me.SnTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.SnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SnTb.CustomButton.TabIndex = 1
        Me.SnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SnTb.CustomButton.UseSelectable = True
        Me.SnTb.CustomButton.Visible = False
        Me.SnTb.IconRight = True
        Me.SnTb.Lines = New String(-1) {}
        Me.SnTb.Location = New System.Drawing.Point(138, 77)
        Me.SnTb.MaxLength = 32767
        Me.SnTb.Name = "SnTb"
        Me.SnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SnTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SnTb.SelectedText = ""
        Me.SnTb.SelectionLength = 0
        Me.SnTb.SelectionStart = 0
        Me.SnTb.ShortcutsEnabled = True
        Me.SnTb.Size = New System.Drawing.Size(174, 23)
        Me.SnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.SnTb.TabIndex = 1
        Me.SnTb.UseSelectable = True
        Me.SnTb.WaterMark = "Surname"
        Me.SnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FnTb
        '
        Me.FnTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.FnTb.CustomButton.Image = Nothing
        Me.FnTb.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.FnTb.CustomButton.Name = ""
        Me.FnTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FnTb.CustomButton.TabIndex = 1
        Me.FnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FnTb.CustomButton.UseSelectable = True
        Me.FnTb.CustomButton.Visible = False
        Me.FnTb.Lines = New String(-1) {}
        Me.FnTb.Location = New System.Drawing.Point(138, 48)
        Me.FnTb.MaxLength = 32767
        Me.FnTb.Name = "FnTb"
        Me.FnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FnTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FnTb.SelectedText = ""
        Me.FnTb.SelectionLength = 0
        Me.FnTb.SelectionStart = 0
        Me.FnTb.ShortcutsEnabled = True
        Me.FnTb.Size = New System.Drawing.Size(174, 23)
        Me.FnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.FnTb.TabIndex = 0
        Me.FnTb.UseSelectable = True
        Me.FnTb.WaterMark = "Firstname"
        Me.FnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MainPb
        '
        Me.MainPb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MainPb.Location = New System.Drawing.Point(32, 48)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(100, 100)
        Me.MainPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MainPb.TabIndex = 21
        Me.MainPb.TabStop = False
        '
        'Pass1Tb
        '
        Me.Pass1Tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Pass1Tb.CustomButton.Image = Nothing
        Me.Pass1Tb.CustomButton.Location = New System.Drawing.Point(259, 1)
        Me.Pass1Tb.CustomButton.Name = ""
        Me.Pass1Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Pass1Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Pass1Tb.CustomButton.TabIndex = 1
        Me.Pass1Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Pass1Tb.CustomButton.UseSelectable = True
        Me.Pass1Tb.CustomButton.Visible = False
        Me.Pass1Tb.IconRight = True
        Me.Pass1Tb.Lines = New String(-1) {}
        Me.Pass1Tb.Location = New System.Drawing.Point(32, 338)
        Me.Pass1Tb.MaxLength = 32767
        Me.Pass1Tb.Name = "Pass1Tb"
        Me.Pass1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Pass1Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Pass1Tb.SelectedText = ""
        Me.Pass1Tb.SelectionLength = 0
        Me.Pass1Tb.SelectionStart = 0
        Me.Pass1Tb.ShortcutsEnabled = True
        Me.Pass1Tb.Size = New System.Drawing.Size(281, 23)
        Me.Pass1Tb.Style = MetroFramework.MetroColorStyle.Purple
        Me.Pass1Tb.TabIndex = 9
        Me.Pass1Tb.UseSelectable = True
        Me.Pass1Tb.WaterMark = "Confirm Password"
        Me.Pass1Tb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Pass1Tb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Pass0Tb
        '
        Me.Pass0Tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Pass0Tb.CustomButton.Image = Nothing
        Me.Pass0Tb.CustomButton.Location = New System.Drawing.Point(259, 1)
        Me.Pass0Tb.CustomButton.Name = ""
        Me.Pass0Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Pass0Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Pass0Tb.CustomButton.TabIndex = 1
        Me.Pass0Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Pass0Tb.CustomButton.UseSelectable = True
        Me.Pass0Tb.CustomButton.Visible = False
        Me.Pass0Tb.Lines = New String(-1) {}
        Me.Pass0Tb.Location = New System.Drawing.Point(32, 309)
        Me.Pass0Tb.MaxLength = 32767
        Me.Pass0Tb.Name = "Pass0Tb"
        Me.Pass0Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Pass0Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Pass0Tb.SelectedText = ""
        Me.Pass0Tb.SelectionLength = 0
        Me.Pass0Tb.SelectionStart = 0
        Me.Pass0Tb.ShortcutsEnabled = True
        Me.Pass0Tb.Size = New System.Drawing.Size(281, 23)
        Me.Pass0Tb.Style = MetroFramework.MetroColorStyle.Purple
        Me.Pass0Tb.TabIndex = 8
        Me.Pass0Tb.UseSelectable = True
        Me.Pass0Tb.WaterMark = "Password"
        Me.Pass0Tb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Pass0Tb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FullnTb
        '
        Me.FullnTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.FullnTb.CustomButton.Image = Nothing
        Me.FullnTb.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.FullnTb.CustomButton.Name = ""
        Me.FullnTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FullnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnTb.CustomButton.TabIndex = 1
        Me.FullnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FullnTb.CustomButton.UseSelectable = True
        Me.FullnTb.CustomButton.Visible = False
        Me.FullnTb.IconRight = True
        Me.FullnTb.Lines = New String(-1) {}
        Me.FullnTb.Location = New System.Drawing.Point(138, 125)
        Me.FullnTb.MaxLength = 32767
        Me.FullnTb.Name = "FullnTb"
        Me.FullnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullnTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FullnTb.SelectedText = ""
        Me.FullnTb.SelectionLength = 0
        Me.FullnTb.SelectionStart = 0
        Me.FullnTb.ShortcutsEnabled = True
        Me.FullnTb.Size = New System.Drawing.Size(174, 23)
        Me.FullnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.FullnTb.TabIndex = 2
        Me.FullnTb.UseSelectable = True
        Me.FullnTb.WaterMark = "Display Name"
        Me.FullnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FullnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ChangePassCb
        '
        Me.ChangePassCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChangePassCb.AutoSize = True
        Me.ChangePassCb.Location = New System.Drawing.Point(32, 204)
        Me.ChangePassCb.Name = "ChangePassCb"
        Me.ChangePassCb.Size = New System.Drawing.Size(224, 17)
        Me.ChangePassCb.TabIndex = 4
        Me.ChangePassCb.Text = "User must change password at next logon"
        Me.ChangePassCb.UseVisualStyleBackColor = True
        '
        'CannotChangePassCb
        '
        Me.CannotChangePassCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CannotChangePassCb.AutoSize = True
        Me.CannotChangePassCb.Location = New System.Drawing.Point(32, 227)
        Me.CannotChangePassCb.Name = "CannotChangePassCb"
        Me.CannotChangePassCb.Size = New System.Drawing.Size(171, 17)
        Me.CannotChangePassCb.TabIndex = 5
        Me.CannotChangePassCb.Text = "User cannot change password"
        Me.CannotChangePassCb.UseVisualStyleBackColor = True
        '
        'PassNeverExpiresCb
        '
        Me.PassNeverExpiresCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PassNeverExpiresCb.AutoSize = True
        Me.PassNeverExpiresCb.Location = New System.Drawing.Point(32, 250)
        Me.PassNeverExpiresCb.Name = "PassNeverExpiresCb"
        Me.PassNeverExpiresCb.Size = New System.Drawing.Size(138, 17)
        Me.PassNeverExpiresCb.TabIndex = 6
        Me.PassNeverExpiresCb.Text = "Password never expires"
        Me.PassNeverExpiresCb.UseVisualStyleBackColor = True
        '
        'AccountDisabledCb
        '
        Me.AccountDisabledCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AccountDisabledCb.AutoSize = True
        Me.AccountDisabledCb.Location = New System.Drawing.Point(32, 273)
        Me.AccountDisabledCb.Name = "AccountDisabledCb"
        Me.AccountDisabledCb.Size = New System.Drawing.Size(118, 17)
        Me.AccountDisabledCb.TabIndex = 7
        Me.AccountDisabledCb.Text = "Account is disabled"
        Me.AccountDisabledCb.UseVisualStyleBackColor = True
        '
        'UsernameTb
        '
        Me.UsernameTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.UsernameTb.CustomButton.Image = Nothing
        Me.UsernameTb.CustomButton.Location = New System.Drawing.Point(258, 1)
        Me.UsernameTb.CustomButton.Name = ""
        Me.UsernameTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsernameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTb.CustomButton.TabIndex = 1
        Me.UsernameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTb.CustomButton.UseSelectable = True
        Me.UsernameTb.CustomButton.Visible = False
        Me.UsernameTb.IconRight = True
        Me.UsernameTb.Lines = New String(-1) {}
        Me.UsernameTb.Location = New System.Drawing.Point(32, 163)
        Me.UsernameTb.MaxLength = 32767
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTb.SelectedText = ""
        Me.UsernameTb.SelectionLength = 0
        Me.UsernameTb.SelectionStart = 0
        Me.UsernameTb.ShortcutsEnabled = True
        Me.UsernameTb.Size = New System.Drawing.Size(280, 23)
        Me.UsernameTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.UsernameTb.TabIndex = 3
        Me.UsernameTb.UseSelectable = True
        Me.UsernameTb.WaterMark = "Username"
        Me.UsernameTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Create New user In"
        '
        'ContainerLb
        '
        Me.ContainerLb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ContainerLb.AutoSize = True
        Me.ContainerLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerLb.Location = New System.Drawing.Point(149, 14)
        Me.ContainerLb.Name = "ContainerLb"
        Me.ContainerLb.Size = New System.Drawing.Size(61, 13)
        Me.ContainerLb.TabIndex = 23
        Me.ContainerLb.Text = "Container"
        '
        'ContainerPb
        '
        Me.ContainerPb.Location = New System.Drawing.Point(32, 13)
        Me.ContainerPb.Name = "ContainerPb"
        Me.ContainerPb.Size = New System.Drawing.Size(16, 16)
        Me.ContainerPb.TabIndex = 24
        Me.ContainerPb.TabStop = False
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Enabled = False
        Me.CancelBn.Location = New System.Drawing.Point(259, 9)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 1
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.SystemColors.Control
        Me.ControlFooterPl1.Controls.Add(Me.OkBn)
        Me.ControlFooterPl1.Controls.Add(Me.ErrorLb)
        Me.ControlFooterPl1.Controls.Add(Me.CancelBn)
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 381)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(346, 44)
        Me.ControlFooterPl1.TabIndex = 10
        '
        'OkBn
        '
        Me.OkBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBn.DisplayFocus = True
        Me.OkBn.Location = New System.Drawing.Point(178, 9)
        Me.OkBn.Name = "OkBn"
        Me.OkBn.Size = New System.Drawing.Size(75, 23)
        Me.OkBn.TabIndex = 0
        Me.OkBn.Text = "Accept"
        Me.OkBn.UseSelectable = True
        '
        'ErrorLb
        '
        Me.ErrorLb.AutoSize = True
        Me.ErrorLb.ForeColor = System.Drawing.Color.Red
        Me.ErrorLb.Location = New System.Drawing.Point(29, 16)
        Me.ErrorLb.Name = "ErrorLb"
        Me.ErrorLb.Size = New System.Drawing.Size(74, 13)
        Me.ErrorLb.TabIndex = 2
        Me.ErrorLb.Text = "Input not valid"
        Me.ErrorLb.Visible = False
        '
        'FormNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(346, 425)
        Me.Controls.Add(Me.ContainerPb)
        Me.Controls.Add(Me.ContainerLb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.AccountDisabledCb)
        Me.Controls.Add(Me.PassNeverExpiresCb)
        Me.Controls.Add(Me.CannotChangePassCb)
        Me.Controls.Add(Me.ChangePassCb)
        Me.Controls.Add(Me.FullnTb)
        Me.Controls.Add(Me.Pass1Tb)
        Me.Controls.Add(Me.Pass0Tb)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.SnTb)
        Me.Controls.Add(Me.FnTb)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNewUser"
        Me.Text = "Add New User"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlFooterPl1.ResumeLayout(False)
        Me.ControlFooterPl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlFooterPl1 As ControlFooterPl
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents SnTb As Controls.MetroTextBox
    Friend WithEvents FnTb As Controls.MetroTextBox
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents Pass1Tb As Controls.MetroTextBox
    Friend WithEvents Pass0Tb As Controls.MetroTextBox
    Friend WithEvents FullnTb As Controls.MetroTextBox
    Friend WithEvents ChangePassCb As CheckBox
    Friend WithEvents CannotChangePassCb As CheckBox
    Friend WithEvents PassNeverExpiresCb As CheckBox
    Friend WithEvents AccountDisabledCb As CheckBox
    Friend WithEvents UsernameTb As Controls.MetroTextBox
    Friend WithEvents ErrorLb As Label
    Friend WithEvents OkBn As Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ContainerLb As Label
    Friend WithEvents ContainerPb As PictureBox
End Class
