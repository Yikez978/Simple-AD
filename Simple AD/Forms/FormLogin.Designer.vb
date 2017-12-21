<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PwdTb = New MetroFramework.Controls.MetroTextBox()
        Me.UnTb = New MetroFramework.Controls.MetroTextBox()
        Me.ErLb = New System.Windows.Forms.Label()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.OKBn = New MetroFramework.Controls.MetroButton()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.RememberCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        Me.SuspendLayout()
        '
        'PwdTb
        '
        Me.PwdTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PwdTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PwdTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        '
        '
        '
        Me.PwdTb.CustomButton.Image = Nothing
        Me.PwdTb.CustomButton.Location = New System.Drawing.Point(372, 1)
        Me.PwdTb.CustomButton.Name = ""
        Me.PwdTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PwdTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PwdTb.CustomButton.TabIndex = 1
        Me.PwdTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PwdTb.CustomButton.UseSelectable = True
        Me.PwdTb.CustomButton.Visible = False
        Me.PwdTb.Icon = New Icon(My.Resources.Warning, New Size(16, 16)).ToBitmap
        Me.PwdTb.IconRight = True
        Me.PwdTb.Lines = New String(-1) {}
        Me.PwdTb.Location = New System.Drawing.Point(22, 41)
        Me.PwdTb.MaxLength = 32767
        Me.PwdTb.Name = "PwdTb"
        Me.PwdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PwdTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PwdTb.SelectedText = ""
        Me.PwdTb.SelectionLength = 0
        Me.PwdTb.SelectionStart = 0
        Me.PwdTb.ShortcutsEnabled = True
        Me.PwdTb.Size = New System.Drawing.Size(394, 23)
        Me.PwdTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.PwdTb.TabIndex = 18
        Me.PwdTb.UseSelectable = True
        Me.PwdTb.WaterMark = "Password"
        Me.PwdTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PwdTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UnTb
        '
        Me.UnTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UnTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        '
        '
        '
        Me.UnTb.CustomButton.Image = Nothing
        Me.UnTb.CustomButton.Location = New System.Drawing.Point(372, 1)
        Me.UnTb.CustomButton.Name = ""
        Me.UnTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UnTb.CustomButton.TabIndex = 1
        Me.UnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UnTb.CustomButton.UseSelectable = True
        Me.UnTb.CustomButton.Visible = False
        Me.UnTb.Lines = New String(-1) {}
        Me.UnTb.Location = New System.Drawing.Point(22, 12)
        Me.UnTb.MaxLength = 32767
        Me.UnTb.Name = "UnTb"
        Me.UnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UnTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UnTb.SelectedText = ""
        Me.UnTb.SelectionLength = 0
        Me.UnTb.SelectionStart = 0
        Me.UnTb.ShortcutsEnabled = True
        Me.UnTb.Size = New System.Drawing.Size(394, 23)
        Me.UnTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.UnTb.TabIndex = 17
        Me.UnTb.UseSelectable = True
        Me.UnTb.WaterMark = "Username"
        Me.UnTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UnTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ErLb
        '
        Me.ErLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ErLb.AutoSize = True
        Me.ErLb.ForeColor = System.Drawing.Color.IndianRed
        Me.ErLb.Location = New System.Drawing.Point(22, 89)
        Me.ErLb.Name = "ErLb"
        Me.ErLb.Size = New System.Drawing.Size(180, 15)
        Me.ErLb.TabIndex = 16
        Me.ErLb.Text = "Username or Password is Incorrect"
        Me.ErLb.Visible = False
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Enabled = False
        Me.CancelBn.Location = New System.Drawing.Point(338, 129)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 13
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'OKBn
        '
        Me.OKBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKBn.Location = New System.Drawing.Point(257, 129)
        Me.OKBn.Name = "OKBn"
        Me.OKBn.Size = New System.Drawing.Size(75, 23)
        Me.OKBn.TabIndex = 12
        Me.OKBn.Text = "OK"
        Me.OKBn.UseSelectable = True
        '
        'Spinner
        '
        Me.Spinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Spinner.Location = New System.Drawing.Point(377, 70)
        Me.Spinner.Maximum = 100
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(36, 34)
        Me.Spinner.Speed = 2.0!
        Me.Spinner.Style = MetroFramework.MetroColorStyle.Purple
        Me.Spinner.TabIndex = 19
        Me.Spinner.UseCustomBackColor = True
        Me.Spinner.UseSelectable = True
        Me.Spinner.Value = 30
        Me.Spinner.Visible = False
        '
        'RememberCheckBox
        '
        Me.RememberCheckBox.AutoSize = True
        Me.RememberCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RememberCheckBox.Location = New System.Drawing.Point(22, 70)
        Me.RememberCheckBox.Name = "RememberCheckBox"
        Me.RememberCheckBox.Size = New System.Drawing.Size(101, 15)
        Me.RememberCheckBox.Style = MetroFramework.MetroColorStyle.Purple
        Me.RememberCheckBox.TabIndex = 20
        Me.RememberCheckBox.Text = "Remember Me"
        Me.RememberCheckBox.UseCustomBackColor = True
        Me.RememberCheckBox.UseSelectable = True
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 121)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(428, 44)
        Me.ControlFooterPl1.TabIndex = 21
        '
        'FormLogin
        '
        Me.AcceptButton = Me.OKBn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(428, 165)
        Me.Controls.Add(Me.RememberCheckBox)
        Me.Controls.Add(Me.Spinner)
        Me.Controls.Add(Me.PwdTb)
        Me.Controls.Add(Me.UnTb)
        Me.Controls.Add(Me.ErLb)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.OKBn)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple AD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PwdTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UnTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErLb As Label
    Friend WithEvents CancelBn As MetroFramework.Controls.MetroButton
    Friend WithEvents OKBn As MetroFramework.Controls.MetroButton
    Friend WithEvents Spinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents RememberCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
End Class
