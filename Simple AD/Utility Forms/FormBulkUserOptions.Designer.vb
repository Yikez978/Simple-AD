<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBulkUserOptions
    Inherits SimpleAD.FormSimpleAD

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
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ConfirmBn = New MetroFramework.Controls.MetroButton()
        Me.CrHfldrLb = New MetroFramework.Controls.MetroLabel()
        Me.CrHfldrTg = New MetroFramework.Controls.MetroToggle()
        Me.FpwdLb = New MetroFramework.Controls.MetroLabel()
        Me.FpwdTg = New MetroFramework.Controls.MetroToggle()
        Me.EnAcLb = New MetroFramework.Controls.MetroLabel()
        Me.EnAcTg = New MetroFramework.Controls.MetroToggle()
        Me.SuspendLayout()
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(298, 174)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 7
        Me.CancelBn.Text = "Close"
        Me.CancelBn.UseSelectable = True
        '
        'ConfirmBn
        '
        Me.ConfirmBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfirmBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ConfirmBn.Location = New System.Drawing.Point(217, 174)
        Me.ConfirmBn.Name = "ConfirmBn"
        Me.ConfirmBn.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmBn.TabIndex = 8
        Me.ConfirmBn.Text = "Confirm"
        Me.ConfirmBn.UseSelectable = True
        '
        'CrHfldrLb
        '
        Me.CrHfldrLb.AutoSize = True
        Me.CrHfldrLb.BackColor = System.Drawing.SystemColors.Window
        Me.CrHfldrLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.CrHfldrLb.Location = New System.Drawing.Point(114, 106)
        Me.CrHfldrLb.Name = "CrHfldrLb"
        Me.CrHfldrLb.Size = New System.Drawing.Size(114, 15)
        Me.CrHfldrLb.TabIndex = 12
        Me.CrHfldrLb.Text = "Create &Home Folders"
        Me.CrHfldrLb.UseCustomBackColor = True
        '
        'CrHfldrTg
        '
        Me.CrHfldrTg.AutoSize = True
        Me.CrHfldrTg.BackColor = System.Drawing.SystemColors.Window
        Me.CrHfldrTg.Checked = True
        Me.CrHfldrTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CrHfldrTg.Location = New System.Drawing.Point(28, 104)
        Me.CrHfldrTg.Name = "CrHfldrTg"
        Me.CrHfldrTg.Size = New System.Drawing.Size(80, 17)
        Me.CrHfldrTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.CrHfldrTg.TabIndex = 11
        Me.CrHfldrTg.Text = "On"
        Me.CrHfldrTg.UseCustomBackColor = True
        Me.CrHfldrTg.UseSelectable = True
        '
        'FpwdLb
        '
        Me.FpwdLb.AutoSize = True
        Me.FpwdLb.BackColor = System.Drawing.SystemColors.Window
        Me.FpwdLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.FpwdLb.Location = New System.Drawing.Point(114, 79)
        Me.FpwdLb.Name = "FpwdLb"
        Me.FpwdLb.Size = New System.Drawing.Size(188, 15)
        Me.FpwdLb.TabIndex = 10
        Me.FpwdLb.Text = "&Force Password Reset on First Login"
        Me.FpwdLb.UseCustomBackColor = True
        '
        'FpwdTg
        '
        Me.FpwdTg.AutoSize = True
        Me.FpwdTg.BackColor = System.Drawing.SystemColors.Window
        Me.FpwdTg.Checked = True
        Me.FpwdTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FpwdTg.Location = New System.Drawing.Point(28, 79)
        Me.FpwdTg.Name = "FpwdTg"
        Me.FpwdTg.Size = New System.Drawing.Size(80, 17)
        Me.FpwdTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.FpwdTg.TabIndex = 9
        Me.FpwdTg.Text = "On"
        Me.FpwdTg.UseCustomBackColor = True
        Me.FpwdTg.UseSelectable = True
        '
        'EnAcLb
        '
        Me.EnAcLb.AutoSize = True
        Me.EnAcLb.BackColor = System.Drawing.SystemColors.Window
        Me.EnAcLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.EnAcLb.Location = New System.Drawing.Point(114, 133)
        Me.EnAcLb.Name = "EnAcLb"
        Me.EnAcLb.Size = New System.Drawing.Size(150, 15)
        Me.EnAcLb.TabIndex = 14
        Me.EnAcLb.Text = "Enable &Accounts on Creation"
        Me.EnAcLb.UseCustomBackColor = True
        '
        'EnAcTg
        '
        Me.EnAcTg.AutoSize = True
        Me.EnAcTg.BackColor = System.Drawing.SystemColors.Window
        Me.EnAcTg.Checked = True
        Me.EnAcTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnAcTg.Location = New System.Drawing.Point(28, 131)
        Me.EnAcTg.Name = "EnAcTg"
        Me.EnAcTg.Size = New System.Drawing.Size(80, 17)
        Me.EnAcTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.EnAcTg.TabIndex = 13
        Me.EnAcTg.Text = "On"
        Me.EnAcTg.UseCustomBackColor = True
        Me.EnAcTg.UseSelectable = True
        '
        'FormBulkUserOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 220)
        Me.Controls.Add(Me.EnAcLb)
        Me.Controls.Add(Me.EnAcTg)
        Me.Controls.Add(Me.CrHfldrLb)
        Me.Controls.Add(Me.CrHfldrTg)
        Me.Controls.Add(Me.FpwdLb)
        Me.Controls.Add(Me.FpwdTg)
        Me.Controls.Add(Me.ConfirmBn)
        Me.Controls.Add(Me.CancelBn)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.Name = "FormBulkUserOptions"
        Me.Text = "FormBulkUserOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents ConfirmBn As Controls.MetroButton
    Friend WithEvents CrHfldrLb As Controls.MetroLabel
    Friend WithEvents CrHfldrTg As Controls.MetroToggle
    Friend WithEvents FpwdLb As Controls.MetroLabel
    Friend WithEvents FpwdTg As Controls.MetroToggle
    Friend WithEvents EnAcLb As Controls.MetroLabel
    Friend WithEvents EnAcTg As Controls.MetroToggle
End Class
