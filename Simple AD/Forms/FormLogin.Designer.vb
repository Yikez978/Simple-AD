Imports System.Drawing
Imports System.Windows.Forms
Imports SimpleLib

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
        Me.ErLb = New System.Windows.Forms.Label()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.RememberCheckBox = New System.Windows.Forms.CheckBox()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.OKBn = New System.Windows.Forms.Button()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.PwdTb = New SimpleAD.ControlTextBox()
        Me.UnTb = New SimpleAD.ControlTextBox()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErLb
        '
        Me.ErLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ErLb.AutoSize = True
        Me.ErLb.ForeColor = System.Drawing.Color.IndianRed
        Me.ErLb.Location = New System.Drawing.Point(26, 172)
        Me.ErLb.Name = "ErLb"
        Me.ErLb.Size = New System.Drawing.Size(171, 13)
        Me.ErLb.TabIndex = 16
        Me.ErLb.Text = "Username or Password is Incorrect"
        Me.ErLb.Visible = False
        '
        'Spinner
        '
        Me.Spinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Spinner.Location = New System.Drawing.Point(425, 11)
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
        Me.RememberCheckBox.Location = New System.Drawing.Point(25, 129)
        Me.RememberCheckBox.Name = "RememberCheckBox"
        Me.RememberCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.RememberCheckBox.TabIndex = 20
        Me.RememberCheckBox.Text = "Remember Me"
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Enabled = False
        Me.CancelBn.Location = New System.Drawing.Point(398, 167)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 13
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'OKBn
        '
        Me.OKBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKBn.Location = New System.Drawing.Point(317, 167)
        Me.OKBn.Name = "OKBn"
        Me.OKBn.Size = New System.Drawing.Size(75, 23)
        Me.OKBn.TabIndex = 12
        Me.OKBn.Text = "OK"
        Me.OKBn.UseVisualStyleBackColor = True
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Window
        Me.ImagePl.Controls.Add(Me.TitleLb)
        Me.ImagePl.Controls.Add(Me.Spinner)
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(485, 56)
        Me.ImagePl.TabIndex = 21
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(113, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Switch User"
        '
        'PwdTb
        '
        Me.PwdTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PwdTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PwdTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.PwdTb.Location = New System.Drawing.Point(25, 100)
        Me.PwdTb.MinimumSize = New System.Drawing.Size(0, 22)
        Me.PwdTb.Name = "PwdTb"
        Me.PwdTb.PromptText = "Password"
        Me.PwdTb.Size = New System.Drawing.Size(436, 22)
        Me.PwdTb.TabIndex = 18
        Me.PwdTb.UseSystemPasswordChar = True
        '
        'UnTb
        '
        Me.UnTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UnTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.UnTb.Location = New System.Drawing.Point(25, 71)
        Me.UnTb.MinimumSize = New System.Drawing.Size(0, 22)
        Me.UnTb.Name = "UnTb"
        Me.UnTb.PromptText = "Username"
        Me.UnTb.Size = New System.Drawing.Size(436, 22)
        Me.UnTb.TabIndex = 17
        '
        'FormLogin
        '
        Me.AcceptButton = Me.OKBn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(485, 202)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.RememberCheckBox)
        Me.Controls.Add(Me.PwdTb)
        Me.Controls.Add(Me.UnTb)
        Me.Controls.Add(Me.ErLb)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.OKBn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple AD"
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PwdTb As SimpleAD.ControlTextBox
    Friend WithEvents UnTb As SimpleAD.ControlTextBox
    Friend WithEvents ErLb As Label
    Friend WithEvents Spinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents RememberCheckBox As CheckBox
    Friend WithEvents CancelBn As Button
    Friend WithEvents OKBn As Button
    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Label
End Class
