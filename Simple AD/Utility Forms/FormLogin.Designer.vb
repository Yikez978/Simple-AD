﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PwdTb = New MetroFramework.Controls.MetroTextBox()
        Me.UnTb = New MetroFramework.Controls.MetroTextBox()
        Me.ErLb = New MetroFramework.Controls.MetroLabel()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.OKBn = New MetroFramework.Controls.MetroButton()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.RememberCheckBox = New MetroFramework.Controls.MetroCheckBox()
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
        Me.PwdTb.CustomButton.Location = New System.Drawing.Point(354, 1)
        Me.PwdTb.CustomButton.Name = ""
        Me.PwdTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PwdTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PwdTb.CustomButton.TabIndex = 1
        Me.PwdTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PwdTb.CustomButton.UseSelectable = True
        Me.PwdTb.CustomButton.Visible = False
        Me.PwdTb.Icon = Global.SimpleAD.My.Resources.Resources.ErrorAlt
        Me.PwdTb.IconRight = True
        Me.PwdTb.Lines = New String(-1) {}
        Me.PwdTb.Location = New System.Drawing.Point(23, 92)
        Me.PwdTb.MaxLength = 32767
        Me.PwdTb.Name = "PwdTb"
        Me.PwdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PwdTb.PromptText = "Password"
        Me.PwdTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PwdTb.SelectedText = ""
        Me.PwdTb.SelectionLength = 0
        Me.PwdTb.SelectionStart = 0
        Me.PwdTb.ShortcutsEnabled = True
        Me.PwdTb.Size = New System.Drawing.Size(376, 23)
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
        Me.UnTb.CustomButton.Location = New System.Drawing.Point(354, 1)
        Me.UnTb.CustomButton.Name = ""
        Me.UnTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UnTb.CustomButton.TabIndex = 1
        Me.UnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UnTb.CustomButton.UseSelectable = True
        Me.UnTb.CustomButton.Visible = False
        Me.UnTb.Lines = New String(-1) {}
        Me.UnTb.Location = New System.Drawing.Point(23, 63)
        Me.UnTb.MaxLength = 32767
        Me.UnTb.Name = "UnTb"
        Me.UnTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UnTb.PromptText = "Username"
        Me.UnTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UnTb.SelectedText = ""
        Me.UnTb.SelectionLength = 0
        Me.UnTb.SelectionStart = 0
        Me.UnTb.ShortcutsEnabled = True
        Me.UnTb.Size = New System.Drawing.Size(376, 23)
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
        Me.ErLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.ErLb.ForeColor = System.Drawing.Color.IndianRed
        Me.ErLb.Location = New System.Drawing.Point(12, 142)
        Me.ErLb.Name = "ErLb"
        Me.ErLb.Size = New System.Drawing.Size(181, 15)
        Me.ErLb.TabIndex = 16
        Me.ErLb.Text = "Username or Password is Incorrect"
        Me.ErLb.Visible = False
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Enabled = False
        Me.CancelBn.Location = New System.Drawing.Point(338, 138)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 13
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'OKBn
        '
        Me.OKBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKBn.Location = New System.Drawing.Point(257, 138)
        Me.OKBn.Name = "OKBn"
        Me.OKBn.Size = New System.Drawing.Size(75, 23)
        Me.OKBn.TabIndex = 12
        Me.OKBn.Text = "OK"
        Me.OKBn.UseSelectable = True
        '
        'Spinner
        '
        Me.Spinner.Location = New System.Drawing.Point(363, 23)
        Me.Spinner.Maximum = 100
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(36, 34)
        Me.Spinner.Speed = 2.0!
        Me.Spinner.Style = MetroFramework.MetroColorStyle.Purple
        Me.Spinner.TabIndex = 19
        Me.Spinner.UseSelectable = True
        Me.Spinner.Value = 30
        Me.Spinner.Visible = False
        '
        'RememberCheckBox
        '
        Me.RememberCheckBox.AutoSize = True
        Me.RememberCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RememberCheckBox.Location = New System.Drawing.Point(23, 121)
        Me.RememberCheckBox.Name = "RememberCheckBox"
        Me.RememberCheckBox.Size = New System.Drawing.Size(101, 15)
        Me.RememberCheckBox.Style = MetroFramework.MetroColorStyle.Purple
        Me.RememberCheckBox.TabIndex = 20
        Me.RememberCheckBox.Text = "Remember Me"
        Me.RememberCheckBox.UseSelectable = True
        '
        'FormLogin
        '
        Me.AcceptButton = Me.OKBn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(428, 174)
        Me.Controls.Add(Me.RememberCheckBox)
        Me.Controls.Add(Me.Spinner)
        Me.Controls.Add(Me.PwdTb)
        Me.Controls.Add(Me.UnTb)
        Me.Controls.Add(Me.ErLb)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.OKBn)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Simple AD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PwdTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UnTb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents CancelBn As MetroFramework.Controls.MetroButton
    Friend WithEvents OKBn As MetroFramework.Controls.MetroButton
    Friend WithEvents Spinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents RememberCheckBox As MetroFramework.Controls.MetroCheckBox
End Class
