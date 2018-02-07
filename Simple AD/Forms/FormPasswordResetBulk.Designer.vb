Imports System.Windows.Forms
Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPasswordResetBulk
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasswordResetBulk))
        Me.ForceResetLb = New System.Windows.Forms.Label()
        Me.ErrorLb = New System.Windows.Forms.Label()
        Me.ForceResetToggle = New MetroFramework.Controls.MetroToggle()
        Me.Password1Tb = New SimpleAD.ControlTextBox()
        Me.Password0Tb = New SimpleAD.ControlTextBox()
        Me.SpecifyRadioBn = New System.Windows.Forms.RadioButton()
        Me.GenerateRadioBn = New System.Windows.Forms.RadioButton()
        Me.SpecifyPl = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GeneratePl = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordLengthTb = New SimpleAD.ControlTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UseSymbolsCheckBox = New System.Windows.Forms.CheckBox()
        Me.UseNumbersCheckBox = New System.Windows.Forms.CheckBox()
        Me.UseUpperCheckBox = New System.Windows.Forms.CheckBox()
        Me.FooterPl = New System.Windows.Forms.Panel()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.SpecifyPl.SuspendLayout()
        Me.GeneratePl.SuspendLayout()
        Me.FooterPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ForceResetLb
        '
        Me.ForceResetLb.AutoSize = True
        Me.ForceResetLb.BackColor = System.Drawing.SystemColors.Control
        Me.ForceResetLb.Location = New System.Drawing.Point(98, 333)
        Me.ForceResetLb.Name = "ForceResetLb"
        Me.ForceResetLb.Size = New System.Drawing.Size(114, 13)
        Me.ForceResetLb.TabIndex = 13
        Me.ForceResetLb.Text = "Force Password Reset"
        '
        'ErrorLb
        '
        Me.ErrorLb.AutoSize = True
        Me.ErrorLb.ForeColor = System.Drawing.Color.Maroon
        Me.ErrorLb.Location = New System.Drawing.Point(11, 84)
        Me.ErrorLb.Name = "ErrorLb"
        Me.ErrorLb.Size = New System.Drawing.Size(148, 13)
        Me.ErrorLb.TabIndex = 12
        Me.ErrorLb.Text = "The Passwords do not match."
        Me.ErrorLb.Visible = False
        '
        'ForceResetToggle
        '
        Me.ForceResetToggle.AutoSize = True
        Me.ForceResetToggle.BackColor = System.Drawing.SystemColors.Control
        Me.ForceResetToggle.Location = New System.Drawing.Point(12, 332)
        Me.ForceResetToggle.Name = "ForceResetToggle"
        Me.ForceResetToggle.Size = New System.Drawing.Size(80, 17)
        Me.ForceResetToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.ForceResetToggle.TabIndex = 9
        Me.ForceResetToggle.Text = "Off"
        Me.ForceResetToggle.UseCustomBackColor = True
        Me.ForceResetToggle.UseSelectable = True
        '
        'Password1Tb
        '
        Me.Password1Tb.BackColor = System.Drawing.SystemColors.Window
        Me.Password1Tb.Location = New System.Drawing.Point(14, 58)
        Me.Password1Tb.Name = "Password1Tb"
        Me.Password1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password1Tb.PromptText = "Confirm New Password"
        Me.Password1Tb.Size = New System.Drawing.Size(352, 20)
        Me.Password1Tb.TabIndex = 8
        '
        'Password0Tb
        '
        Me.Password0Tb.BackColor = System.Drawing.SystemColors.Window
        Me.Password0Tb.Location = New System.Drawing.Point(14, 29)
        Me.Password0Tb.Name = "Password0Tb"
        Me.Password0Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password0Tb.PromptText = "Type New Password"
        Me.Password0Tb.Size = New System.Drawing.Size(352, 20)
        Me.Password0Tb.TabIndex = 7
        '
        'SpecifyRadioBn
        '
        Me.SpecifyRadioBn.AutoSize = True
        Me.SpecifyRadioBn.Location = New System.Drawing.Point(15, 12)
        Me.SpecifyRadioBn.Name = "SpecifyRadioBn"
        Me.SpecifyRadioBn.Size = New System.Drawing.Size(109, 17)
        Me.SpecifyRadioBn.TabIndex = 14
        Me.SpecifyRadioBn.TabStop = True
        Me.SpecifyRadioBn.Text = "Specify Password"
        Me.SpecifyRadioBn.UseVisualStyleBackColor = True
        '
        'GenerateRadioBn
        '
        Me.GenerateRadioBn.AutoSize = True
        Me.GenerateRadioBn.Location = New System.Drawing.Point(15, 151)
        Me.GenerateRadioBn.Name = "GenerateRadioBn"
        Me.GenerateRadioBn.Size = New System.Drawing.Size(161, 17)
        Me.GenerateRadioBn.TabIndex = 15
        Me.GenerateRadioBn.TabStop = True
        Me.GenerateRadioBn.Text = "Generate Random Password"
        Me.GenerateRadioBn.UseVisualStyleBackColor = True
        '
        'SpecifyPl
        '
        Me.SpecifyPl.BackColor = System.Drawing.SystemColors.Window
        Me.SpecifyPl.Controls.Add(Me.Label1)
        Me.SpecifyPl.Controls.Add(Me.ErrorLb)
        Me.SpecifyPl.Controls.Add(Me.Password1Tb)
        Me.SpecifyPl.Controls.Add(Me.Password0Tb)
        Me.SpecifyPl.Location = New System.Drawing.Point(-2, 35)
        Me.SpecifyPl.Margin = New System.Windows.Forms.Padding(0)
        Me.SpecifyPl.Name = "SpecifyPl"
        Me.SpecifyPl.Size = New System.Drawing.Size(430, 106)
        Me.SpecifyPl.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Reset Passwords to the Specified String"
        '
        'GeneratePl
        '
        Me.GeneratePl.BackColor = System.Drawing.SystemColors.Window
        Me.GeneratePl.Controls.Add(Me.Label3)
        Me.GeneratePl.Controls.Add(Me.PasswordLengthTb)
        Me.GeneratePl.Controls.Add(Me.Label2)
        Me.GeneratePl.Controls.Add(Me.UseSymbolsCheckBox)
        Me.GeneratePl.Controls.Add(Me.UseNumbersCheckBox)
        Me.GeneratePl.Controls.Add(Me.UseUpperCheckBox)
        Me.GeneratePl.Location = New System.Drawing.Point(-2, 174)
        Me.GeneratePl.Margin = New System.Windows.Forms.Padding(0)
        Me.GeneratePl.Name = "GeneratePl"
        Me.GeneratePl.Size = New System.Drawing.Size(430, 140)
        Me.GeneratePl.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(33, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Number of Characters to Use for Each Password"
        '
        'PasswordLengthTb
        '
        Me.PasswordLengthTb.Enabled = False
        Me.PasswordLengthTb.Location = New System.Drawing.Point(343, 104)
        Me.PasswordLengthTb.Name = "PasswordLengthTb"
        Me.PasswordLengthTb.PromptText = Nothing
        Me.PasswordLengthTb.Size = New System.Drawing.Size(75, 20)
        Me.PasswordLengthTb.TabIndex = 15
        Me.PasswordLengthTb.Text = "8"
        Me.PasswordLengthTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Generate a random password for each user "
        '
        'UseSymbolsCheckBox
        '
        Me.UseSymbolsCheckBox.AutoSize = True
        Me.UseSymbolsCheckBox.Enabled = False
        Me.UseSymbolsCheckBox.Location = New System.Drawing.Point(17, 82)
        Me.UseSymbolsCheckBox.Name = "UseSymbolsCheckBox"
        Me.UseSymbolsCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.UseSymbolsCheckBox.TabIndex = 2
        Me.UseSymbolsCheckBox.Text = "Use Symbols"
        Me.UseSymbolsCheckBox.UseVisualStyleBackColor = True
        '
        'UseNumbersCheckBox
        '
        Me.UseNumbersCheckBox.AutoSize = True
        Me.UseNumbersCheckBox.Enabled = False
        Me.UseNumbersCheckBox.Location = New System.Drawing.Point(17, 59)
        Me.UseNumbersCheckBox.Name = "UseNumbersCheckBox"
        Me.UseNumbersCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.UseNumbersCheckBox.TabIndex = 1
        Me.UseNumbersCheckBox.Text = "Use Numbers"
        Me.UseNumbersCheckBox.UseVisualStyleBackColor = True
        '
        'UseUpperCheckBox
        '
        Me.UseUpperCheckBox.AutoSize = True
        Me.UseUpperCheckBox.Enabled = False
        Me.UseUpperCheckBox.Location = New System.Drawing.Point(17, 36)
        Me.UseUpperCheckBox.Name = "UseUpperCheckBox"
        Me.UseUpperCheckBox.Size = New System.Drawing.Size(149, 17)
        Me.UseUpperCheckBox.TabIndex = 0
        Me.UseUpperCheckBox.Text = "Use UpperCase Charaters"
        Me.UseUpperCheckBox.UseVisualStyleBackColor = True
        '
        'FooterPl
        '
        Me.FooterPl.BackColor = System.Drawing.SystemColors.Control
        Me.FooterPl.Controls.Add(Me.CancelBn)
        Me.FooterPl.Controls.Add(Me.AcceptBn)
        Me.FooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPl.Location = New System.Drawing.Point(0, 317)
        Me.FooterPl.MaximumSize = New System.Drawing.Size(0, 44)
        Me.FooterPl.MinimumSize = New System.Drawing.Size(0, 44)
        Me.FooterPl.Name = "FooterPl"
        Me.FooterPl.Size = New System.Drawing.Size(428, 44)
        Me.FooterPl.TabIndex = 20
        '
        'AcceptBn
        '
        Me.AcceptBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AcceptBn.Location = New System.Drawing.Point(260, 9)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 0
        Me.AcceptBn.Text = "Accept"
        Me.AcceptBn.UseVisualStyleBackColor = True
        '
        'CancelBn
        '
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(341, 9)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 1
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'FormPasswordResetBulk
        '
        Me.AcceptButton = Me.AcceptBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(428, 361)
        Me.Controls.Add(Me.GeneratePl)
        Me.Controls.Add(Me.SpecifyPl)
        Me.Controls.Add(Me.GenerateRadioBn)
        Me.Controls.Add(Me.SpecifyRadioBn)
        Me.Controls.Add(Me.ForceResetLb)
        Me.Controls.Add(Me.ForceResetToggle)
        Me.Controls.Add(Me.FooterPl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPasswordResetBulk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk Reset Password"
        Me.SpecifyPl.ResumeLayout(False)
        Me.SpecifyPl.PerformLayout()
        Me.GeneratePl.ResumeLayout(False)
        Me.GeneratePl.PerformLayout()
        Me.FooterPl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ForceResetLb As Label
    Friend WithEvents ErrorLb As Label
    Friend WithEvents ForceResetToggle As Controls.MetroToggle
    Friend WithEvents Password1Tb As SimpleAD.ControlTextBox
    Friend WithEvents Password0Tb As SimpleAD.ControlTextBox
    Friend WithEvents SpecifyRadioBn As RadioButton
    Friend WithEvents GenerateRadioBn As RadioButton
    Friend WithEvents SpecifyPl As Panel
    Friend WithEvents GeneratePl As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordLengthTb As SimpleAD.ControlTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UseSymbolsCheckBox As CheckBox
    Friend WithEvents UseNumbersCheckBox As CheckBox
    Friend WithEvents UseUpperCheckBox As CheckBox
    Friend WithEvents FooterPl As Panel
    Friend WithEvents CancelBn As Button
    Friend WithEvents AcceptBn As Button
End Class
