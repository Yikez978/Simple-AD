Imports System.Windows.Forms
Imports MetroFramework
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPasswordReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasswordReset))
        Me.Password0Tb = New SimpleAD.ControlTextBox()
        Me.Password1Tb = New SimpleAD.ControlTextBox()
        Me.ForceResetToggle = New MetroFramework.Controls.MetroToggle()
        Me.ErrorLb = New System.Windows.Forms.Label()
        Me.ForceResetLb = New System.Windows.Forms.Label()
        Me.UnlockCb = New System.Windows.Forms.CheckBox()
        Me.PwdProgressBar = New System.Windows.Forms.ProgressBar()
        Me.PwdStrLb = New System.Windows.Forms.Label()
        Me.ScoreLb = New System.Windows.Forms.Label()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Password0Tb
        '
        Me.Password0Tb.BackColor = System.Drawing.SystemColors.Window
        Me.Password0Tb.Location = New System.Drawing.Point(23, 72)
        Me.Password0Tb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.Password0Tb.Name = "Password0Tb"
        Me.Password0Tb.PromptText = "Type New Password"
        Me.Password0Tb.Size = New System.Drawing.Size(383, 22)
        Me.Password0Tb.TabIndex = 0
        Me.Password0Tb.UseSystemPasswordChar = True
        '
        'Password1Tb
        '
        Me.Password1Tb.BackColor = System.Drawing.SystemColors.Window
        Me.Password1Tb.Location = New System.Drawing.Point(23, 101)
        Me.Password1Tb.MinimumSize = New System.Drawing.Size(4, 22)
        Me.Password1Tb.Name = "Password1Tb"
        Me.Password1Tb.PromptText = "Confirm New Password"
        Me.Password1Tb.Size = New System.Drawing.Size(383, 22)
        Me.Password1Tb.TabIndex = 1
        Me.Password1Tb.UseSystemPasswordChar = True
        '
        'ForceResetToggle
        '
        Me.ForceResetToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ForceResetToggle.AutoSize = True
        Me.ForceResetToggle.BackColor = System.Drawing.SystemColors.Control
        Me.ForceResetToggle.Location = New System.Drawing.Point(20, 206)
        Me.ForceResetToggle.Name = "ForceResetToggle"
        Me.ForceResetToggle.Size = New System.Drawing.Size(80, 17)
        Me.ForceResetToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.ForceResetToggle.TabIndex = 7
        Me.ForceResetToggle.Text = "Off"
        Me.ForceResetToggle.UseCustomBackColor = True
        Me.ForceResetToggle.UseSelectable = True
        '
        'ErrorLb
        '
        Me.ErrorLb.AutoSize = True
        Me.ErrorLb.ForeColor = System.Drawing.Color.Maroon
        Me.ErrorLb.Location = New System.Drawing.Point(20, 129)
        Me.ErrorLb.Name = "ErrorLb"
        Me.ErrorLb.Size = New System.Drawing.Size(148, 13)
        Me.ErrorLb.TabIndex = 2
        Me.ErrorLb.Text = "The Passwords do not match."
        Me.ErrorLb.Visible = False
        '
        'ForceResetLb
        '
        Me.ForceResetLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ForceResetLb.AutoSize = True
        Me.ForceResetLb.BackColor = System.Drawing.SystemColors.Control
        Me.ForceResetLb.Location = New System.Drawing.Point(106, 207)
        Me.ForceResetLb.Name = "ForceResetLb"
        Me.ForceResetLb.Size = New System.Drawing.Size(114, 13)
        Me.ForceResetLb.TabIndex = 8
        Me.ForceResetLb.Text = "Force Password Reset"
        '
        'UnlockCb
        '
        Me.UnlockCb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UnlockCb.AutoSize = True
        Me.UnlockCb.Location = New System.Drawing.Point(23, 161)
        Me.UnlockCb.Name = "UnlockCb"
        Me.UnlockCb.Size = New System.Drawing.Size(103, 17)
        Me.UnlockCb.TabIndex = 3
        Me.UnlockCb.Text = "Unlock Account"
        Me.UnlockCb.UseVisualStyleBackColor = True
        '
        'PwdProgressBar
        '
        Me.PwdProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PwdProgressBar.Location = New System.Drawing.Point(150, 170)
        Me.PwdProgressBar.MarqueeAnimationSpeed = 1000
        Me.PwdProgressBar.Name = "PwdProgressBar"
        Me.PwdProgressBar.Size = New System.Drawing.Size(246, 10)
        Me.PwdProgressBar.TabIndex = 6
        '
        'PwdStrLb
        '
        Me.PwdStrLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PwdStrLb.AutoSize = True
        Me.PwdStrLb.Location = New System.Drawing.Point(147, 154)
        Me.PwdStrLb.Name = "PwdStrLb"
        Me.PwdStrLb.Size = New System.Drawing.Size(96, 13)
        Me.PwdStrLb.TabIndex = 4
        Me.PwdStrLb.Text = "Password Strength"
        '
        'ScoreLb
        '
        Me.ScoreLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScoreLb.AutoSize = True
        Me.ScoreLb.Location = New System.Drawing.Point(357, 154)
        Me.ScoreLb.Name = "ScoreLb"
        Me.ScoreLb.Size = New System.Drawing.Size(34, 13)
        Me.ScoreLb.TabIndex = 5
        Me.ScoreLb.Text = "Blank"
        '
        'CancelBn
        '
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(345, 202)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 10
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'AcceptBn
        '
        Me.AcceptBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AcceptBn.Location = New System.Drawing.Point(264, 202)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 9
        Me.AcceptBn.Text = "Accept"
        Me.AcceptBn.UseVisualStyleBackColor = True
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
        Me.ImagePl.Size = New System.Drawing.Size(432, 56)
        Me.ImagePl.TabIndex = 12
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(163, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Specify Password"
        '
        'FormPasswordReset
        '
        Me.AcceptButton = Me.AcceptBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(432, 237)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.ScoreLb)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.PwdStrLb)
        Me.Controls.Add(Me.PwdProgressBar)
        Me.Controls.Add(Me.UnlockCb)
        Me.Controls.Add(Me.ForceResetLb)
        Me.Controls.Add(Me.ErrorLb)
        Me.Controls.Add(Me.ForceResetToggle)
        Me.Controls.Add(Me.Password1Tb)
        Me.Controls.Add(Me.Password0Tb)
        Me.Controls.Add(Me.ImagePl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPasswordReset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Password0Tb As SimpleAD.ControlTextBox
    Friend WithEvents Password1Tb As SimpleAD.ControlTextBox
    Friend WithEvents ForceResetToggle As Controls.MetroToggle
    Friend WithEvents ErrorLb As Label
    Friend WithEvents ForceResetLb As Label
    Friend WithEvents UnlockCb As CheckBox
    Friend WithEvents PwdProgressBar As ProgressBar
    Friend WithEvents PwdStrLb As Label
    Friend WithEvents ScoreLb As Label
    Friend WithEvents CancelBn As Button
    Friend WithEvents AcceptBn As Button
    Friend WithEvents ImagePl As SimpleAD.ControlHeaderPanel
    Friend WithEvents TitleLb As Label
End Class
