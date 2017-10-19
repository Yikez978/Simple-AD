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
        Me.ForceResetLb = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Password0Tb
        '
        Me.Password0Tb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Password0Tb.CustomButton.Image = Nothing
        Me.Password0Tb.CustomButton.Location = New System.Drawing.Point(382, 1)
        Me.Password0Tb.CustomButton.Name = ""
        Me.Password0Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Password0Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password0Tb.CustomButton.TabIndex = 1
        Me.Password0Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password0Tb.CustomButton.UseSelectable = True
        Me.Password0Tb.CustomButton.Visible = False
        Me.Password0Tb.Lines = New String(-1) {}
        Me.Password0Tb.Location = New System.Drawing.Point(12, 12)
        Me.Password0Tb.MaxLength = 32767
        Me.Password0Tb.Name = "Password0Tb"
        Me.Password0Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password0Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password0Tb.SelectedText = ""
        Me.Password0Tb.SelectionLength = 0
        Me.Password0Tb.SelectionStart = 0
        Me.Password0Tb.ShortcutsEnabled = True
        Me.Password0Tb.Size = New System.Drawing.Size(404, 23)
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
        Me.Password1Tb.CustomButton.Location = New System.Drawing.Point(382, 1)
        Me.Password1Tb.CustomButton.Name = ""
        Me.Password1Tb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Password1Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password1Tb.CustomButton.TabIndex = 1
        Me.Password1Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password1Tb.CustomButton.UseSelectable = True
        Me.Password1Tb.CustomButton.Visible = False
        Me.Password1Tb.Lines = New String(-1) {}
        Me.Password1Tb.Location = New System.Drawing.Point(12, 41)
        Me.Password1Tb.MaxLength = 32767
        Me.Password1Tb.Name = "Password1Tb"
        Me.Password1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password1Tb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password1Tb.SelectedText = ""
        Me.Password1Tb.SelectionLength = 0
        Me.Password1Tb.SelectionStart = 0
        Me.Password1Tb.ShortcutsEnabled = True
        Me.Password1Tb.Size = New System.Drawing.Size(404, 23)
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
        Me.ForceResetToggle.AutoSize = True
        Me.ForceResetToggle.Location = New System.Drawing.Point(12, 95)
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
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(341, 89)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.Style = MetroFramework.MetroColorStyle.Purple
        Me.CancelBn.TabIndex = 3
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Location = New System.Drawing.Point(260, 89)
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
        Me.ErrorLb.Location = New System.Drawing.Point(12, 67)
        Me.ErrorLb.Name = "ErrorLb"
        Me.ErrorLb.Size = New System.Drawing.Size(148, 13)
        Me.ErrorLb.TabIndex = 5
        Me.ErrorLb.Text = "The Passwords do not match."
        Me.ErrorLb.Visible = False
        '
        'ForceResetLb
        '
        Me.ForceResetLb.AutoSize = True
        Me.ForceResetLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.ForceResetLb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ForceResetLb.Location = New System.Drawing.Point(98, 96)
        Me.ForceResetLb.Name = "ForceResetLb"
        Me.ForceResetLb.Size = New System.Drawing.Size(120, 15)
        Me.ForceResetLb.TabIndex = 6
        Me.ForceResetLb.Text = "Force Password Reset"
        Me.ForceResetLb.UseCustomBackColor = True
        '
        'FormPasswordReset
        '
        Me.AcceptButton = Me.AcceptBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(428, 124)
        Me.Controls.Add(Me.ForceResetLb)
        Me.Controls.Add(Me.ErrorLb)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.ForceResetToggle)
        Me.Controls.Add(Me.Password1Tb)
        Me.Controls.Add(Me.Password0Tb)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPasswordReset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
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
    Friend WithEvents ForceResetLb As Controls.MetroLabel
End Class
