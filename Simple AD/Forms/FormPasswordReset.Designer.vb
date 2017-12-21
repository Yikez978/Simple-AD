<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPasswordReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasswordReset))
        Me.Password0Tb = New MetroFramework.Controls.MetroTextBox()
        Me.Password1Tb = New MetroFramework.Controls.MetroTextBox()
        Me.ForceResetToggle = New MetroFramework.Controls.MetroToggle()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.ErrorLb = New System.Windows.Forms.Label()
        Me.ForceResetLb = New System.Windows.Forms.Label()
        Me.UnlockCb = New System.Windows.Forms.CheckBox()
        Me.PwdProgressBar = New System.Windows.Forms.ProgressBar()
        Me.PwdStrLb = New System.Windows.Forms.Label()
        Me.ScoreLb = New System.Windows.Forms.Label()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        Me.SuspendLayout()
        '
        'Password0Tb
        '
        Me.Password0Tb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Password0Tb.CustomButton.Image = Nothing
        Me.Password0Tb.CustomButton.Location = New System.Drawing.Point(361, 1)
        Me.Password0Tb.CustomButton.Name = ""
        Me.Password0Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Password0Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password0Tb.CustomButton.TabIndex = 1
        Me.Password0Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password0Tb.CustomButton.UseSelectable = True
        Me.Password0Tb.CustomButton.Visible = False
        Me.Password0Tb.Lines = New String(-1) {}
        Me.Password0Tb.Location = New System.Drawing.Point(23, 12)
        Me.Password0Tb.MaxLength = 32767
        Me.Password0Tb.Name = "Password0Tb"
        Me.Password0Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password0Tb.PromptText = "Type New Password"
        Me.Password0Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password0Tb.SelectedText = ""
        Me.Password0Tb.SelectionLength = 0
        Me.Password0Tb.SelectionStart = 0
        Me.Password0Tb.ShortcutsEnabled = True
        Me.Password0Tb.Size = New System.Drawing.Size(383, 23)
        Me.Password0Tb.Style = MetroFramework.MetroColorStyle.Purple
        Me.Password0Tb.TabIndex = 0
        Me.Password0Tb.UseCustomBackColor = True
        Me.Password0Tb.UseSelectable = True
        Me.Password0Tb.WaterMark = "Type New Password"
        Me.Password0Tb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Password0Tb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Password1Tb
        '
        Me.Password1Tb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Password1Tb.CustomButton.Image = Nothing
        Me.Password1Tb.CustomButton.Location = New System.Drawing.Point(361, 1)
        Me.Password1Tb.CustomButton.Name = ""
        Me.Password1Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Password1Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password1Tb.CustomButton.TabIndex = 1
        Me.Password1Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password1Tb.CustomButton.UseSelectable = True
        Me.Password1Tb.CustomButton.Visible = False
        Me.Password1Tb.Lines = New String(-1) {}
        Me.Password1Tb.Location = New System.Drawing.Point(23, 41)
        Me.Password1Tb.MaxLength = 32767
        Me.Password1Tb.Name = "Password1Tb"
        Me.Password1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password1Tb.PromptText = "Confirm New Password"
        Me.Password1Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password1Tb.SelectedText = ""
        Me.Password1Tb.SelectionLength = 0
        Me.Password1Tb.SelectionStart = 0
        Me.Password1Tb.ShortcutsEnabled = True
        Me.Password1Tb.Size = New System.Drawing.Size(383, 23)
        Me.Password1Tb.Style = MetroFramework.MetroColorStyle.Purple
        Me.Password1Tb.TabIndex = 1
        Me.Password1Tb.UseCustomBackColor = True
        Me.Password1Tb.UseSelectable = True
        Me.Password1Tb.WaterMark = "Confirm New Password"
        Me.Password1Tb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Password1Tb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'ForceResetToggle
        '
        Me.ForceResetToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ForceResetToggle.AutoSize = True
        Me.ForceResetToggle.BackColor = System.Drawing.SystemColors.Control
        Me.ForceResetToggle.Location = New System.Drawing.Point(12, 144)
        Me.ForceResetToggle.Name = "ForceResetToggle"
        Me.ForceResetToggle.Size = New System.Drawing.Size(80, 17)
        Me.ForceResetToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.ForceResetToggle.TabIndex = 2
        Me.ForceResetToggle.Text = "Off"
        Me.ForceResetToggle.UseCustomBackColor = True
        Me.ForceResetToggle.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(341, 138)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.CancelBn.TabIndex = 3
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(260, 138)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.AcceptBn.TabIndex = 4
        Me.AcceptBn.Text = "Accept"
        Me.AcceptBn.UseSelectable = True
        '
        'ErrorLb
        '
        Me.ErrorLb.AutoSize = True
        Me.ErrorLb.ForeColor = System.Drawing.Color.Maroon
        Me.ErrorLb.Location = New System.Drawing.Point(20, 67)
        Me.ErrorLb.Name = "ErrorLb"
        Me.ErrorLb.Size = New System.Drawing.Size(148, 13)
        Me.ErrorLb.TabIndex = 5
        Me.ErrorLb.Text = "The Passwords do not match."
        Me.ErrorLb.Visible = False
        '
        'ForceResetLb
        '
        Me.ForceResetLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ForceResetLb.AutoSize = True
        Me.ForceResetLb.BackColor = System.Drawing.SystemColors.Control
        Me.ForceResetLb.Location = New System.Drawing.Point(98, 145)
        Me.ForceResetLb.Name = "ForceResetLb"
        Me.ForceResetLb.Size = New System.Drawing.Size(114, 13)
        Me.ForceResetLb.TabIndex = 6
        Me.ForceResetLb.Text = "Force Password Reset"
        '
        'UnlockCb
        '
        Me.UnlockCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UnlockCb.AutoSize = True
        Me.UnlockCb.Location = New System.Drawing.Point(23, 97)
        Me.UnlockCb.Name = "UnlockCb"
        Me.UnlockCb.Size = New System.Drawing.Size(103, 17)
        Me.UnlockCb.TabIndex = 8
        Me.UnlockCb.Text = "Unlock Account"
        Me.UnlockCb.UseVisualStyleBackColor = True
        '
        'PwdProgressBar
        '
        Me.PwdProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PwdProgressBar.Location = New System.Drawing.Point(150, 106)
        Me.PwdProgressBar.MarqueeAnimationSpeed = 1000
        Me.PwdProgressBar.Name = "PwdProgressBar"
        Me.PwdProgressBar.Size = New System.Drawing.Size(246, 10)
        Me.PwdProgressBar.TabIndex = 9
        '
        'PwdStrLb
        '
        Me.PwdStrLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PwdStrLb.AutoSize = True
        Me.PwdStrLb.Location = New System.Drawing.Point(147, 90)
        Me.PwdStrLb.Name = "PwdStrLb"
        Me.PwdStrLb.Size = New System.Drawing.Size(96, 13)
        Me.PwdStrLb.TabIndex = 10
        Me.PwdStrLb.Text = "Password Strength"
        '
        'ScoreLb
        '
        Me.ScoreLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScoreLb.AutoSize = True
        Me.ScoreLb.Location = New System.Drawing.Point(353, 90)
        Me.ScoreLb.Name = "ScoreLb"
        Me.ScoreLb.Size = New System.Drawing.Size(34, 13)
        Me.ScoreLb.TabIndex = 11
        Me.ScoreLb.Text = "Blank"
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.SystemColors.Control
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 129)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(428, 44)
        Me.ControlFooterPl1.TabIndex = 7
        '
        'FormPasswordReset
        '
        Me.AcceptButton = Me.AcceptBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(428, 173)
        Me.Controls.Add(Me.ScoreLb)
        Me.Controls.Add(Me.PwdStrLb)
        Me.Controls.Add(Me.PwdProgressBar)
        Me.Controls.Add(Me.UnlockCb)
        Me.Controls.Add(Me.ForceResetLb)
        Me.Controls.Add(Me.ErrorLb)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.ForceResetToggle)
        Me.Controls.Add(Me.Password1Tb)
        Me.Controls.Add(Me.Password0Tb)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPasswordReset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Password0Tb As Controls.MetroTextBox
    Friend WithEvents Password1Tb As Controls.MetroTextBox
    Friend WithEvents ForceResetToggle As Controls.MetroToggle
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents AcceptBn As Controls.MetroButton
    Friend WithEvents ErrorLb As Label
    Friend WithEvents ForceResetLb As Label
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
    Friend WithEvents UnlockCb As CheckBox
    Friend WithEvents PwdProgressBar As ProgressBar
    Friend WithEvents PwdStrLb As Label
    Friend WithEvents ScoreLb As Label
End Class
