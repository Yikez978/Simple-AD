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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBulkUserOptions))
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.ConfirmBn = New MetroFramework.Controls.MetroButton()
        Me.CrHfldrLb = New MetroFramework.Controls.MetroLabel()
        Me.CrHfldrTg = New MetroFramework.Controls.MetroToggle()
        Me.FpwdLb = New MetroFramework.Controls.MetroLabel()
        Me.FpwdTg = New MetroFramework.Controls.MetroToggle()
        Me.EnAcLb = New MetroFramework.Controls.MetroLabel()
        Me.EnAcTg = New MetroFramework.Controls.MetroToggle()
        Me.DomainTreeView = New SimpleAD.ControlDomainTreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ThreadsLb = New MetroFramework.Controls.MetroLabel()
        Me.ThreadTb = New MetroFramework.Controls.MetroTextBox()
        Me.PathLb = New MetroFramework.Controls.MetroLabel()
        Me.PathTb = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(505, 331)
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
        Me.ConfirmBn.Location = New System.Drawing.Point(424, 331)
        Me.ConfirmBn.Name = "ConfirmBn"
        Me.ConfirmBn.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmBn.TabIndex = 8
        Me.ConfirmBn.Text = "Confirm"
        Me.ConfirmBn.UseSelectable = True
        '
        'CrHfldrLb
        '
        Me.CrHfldrLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrHfldrLb.AutoSize = True
        Me.CrHfldrLb.BackColor = System.Drawing.SystemColors.Control
        Me.CrHfldrLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.CrHfldrLb.Location = New System.Drawing.Point(113, 46)
        Me.CrHfldrLb.Name = "CrHfldrLb"
        Me.CrHfldrLb.Size = New System.Drawing.Size(114, 15)
        Me.CrHfldrLb.TabIndex = 12
        Me.CrHfldrLb.Text = "Create &Home Folders"
        Me.CrHfldrLb.UseCustomBackColor = True
        '
        'CrHfldrTg
        '
        Me.CrHfldrTg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrHfldrTg.AutoSize = True
        Me.CrHfldrTg.BackColor = System.Drawing.SystemColors.Control
        Me.CrHfldrTg.Checked = True
        Me.CrHfldrTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CrHfldrTg.Location = New System.Drawing.Point(27, 44)
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
        Me.FpwdLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FpwdLb.AutoSize = True
        Me.FpwdLb.BackColor = System.Drawing.SystemColors.Control
        Me.FpwdLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.FpwdLb.Location = New System.Drawing.Point(113, 19)
        Me.FpwdLb.Name = "FpwdLb"
        Me.FpwdLb.Size = New System.Drawing.Size(188, 15)
        Me.FpwdLb.TabIndex = 10
        Me.FpwdLb.Text = "&Force Password Reset on First Login"
        Me.FpwdLb.UseCustomBackColor = True
        '
        'FpwdTg
        '
        Me.FpwdTg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FpwdTg.AutoSize = True
        Me.FpwdTg.BackColor = System.Drawing.SystemColors.Control
        Me.FpwdTg.Checked = True
        Me.FpwdTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FpwdTg.Location = New System.Drawing.Point(27, 19)
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
        Me.EnAcLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnAcLb.AutoSize = True
        Me.EnAcLb.BackColor = System.Drawing.SystemColors.Control
        Me.EnAcLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.EnAcLb.Location = New System.Drawing.Point(113, 73)
        Me.EnAcLb.Name = "EnAcLb"
        Me.EnAcLb.Size = New System.Drawing.Size(150, 15)
        Me.EnAcLb.TabIndex = 14
        Me.EnAcLb.Text = "Enable &Accounts on Creation"
        Me.EnAcLb.UseCustomBackColor = True
        '
        'EnAcTg
        '
        Me.EnAcTg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnAcTg.AutoSize = True
        Me.EnAcTg.BackColor = System.Drawing.SystemColors.Control
        Me.EnAcTg.Checked = True
        Me.EnAcTg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnAcTg.Location = New System.Drawing.Point(27, 71)
        Me.EnAcTg.Name = "EnAcTg"
        Me.EnAcTg.Size = New System.Drawing.Size(80, 17)
        Me.EnAcTg.Style = MetroFramework.MetroColorStyle.Purple
        Me.EnAcTg.TabIndex = 13
        Me.EnAcTg.Text = "On"
        Me.EnAcTg.UseCustomBackColor = True
        Me.EnAcTg.UseSelectable = True
        '
        'DomainTreeView
        '
        Me.DomainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DomainTreeView.DomainController = Nothing
        Me.DomainTreeView.DomainName = Nothing
        Me.DomainTreeView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTreeView.FullRowSelect = True
        Me.DomainTreeView.HideSelection = False
        Me.DomainTreeView.HotTracking = True
        Me.DomainTreeView.ImageIndex = 0
        Me.DomainTreeView.ItemHeight = 22
        Me.DomainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DomainTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.DomainTreeView.Name = "DomainTreeView"
        Me.DomainTreeView.SelectedImageIndex = 0
        Me.DomainTreeView.SelectedOU = Nothing
        Me.DomainTreeView.ShowLines = False
        Me.DomainTreeView.Size = New System.Drawing.Size(287, 377)
        Me.DomainTreeView.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ThreadsLb)
        Me.Panel1.Controls.Add(Me.EnAcLb)
        Me.Panel1.Controls.Add(Me.ThreadTb)
        Me.Panel1.Controls.Add(Me.EnAcTg)
        Me.Panel1.Controls.Add(Me.PathLb)
        Me.Panel1.Controls.Add(Me.CrHfldrLb)
        Me.Panel1.Controls.Add(Me.PathTb)
        Me.Panel1.Controls.Add(Me.CrHfldrTg)
        Me.Panel1.Controls.Add(Me.FpwdTg)
        Me.Panel1.Controls.Add(Me.FpwdLb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(287, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 377)
        Me.Panel1.TabIndex = 16
        '
        'ThreadsLb
        '
        Me.ThreadsLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThreadsLb.AutoSize = True
        Me.ThreadsLb.BackColor = System.Drawing.SystemColors.Control
        Me.ThreadsLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.ThreadsLb.Location = New System.Drawing.Point(24, 273)
        Me.ThreadsLb.Name = "ThreadsLb"
        Me.ThreadsLb.Size = New System.Drawing.Size(168, 15)
        Me.ThreadsLb.TabIndex = 19
        Me.ThreadsLb.Text = "Max Number of Threads to Use:"
        Me.ThreadsLb.UseCustomBackColor = True
        '
        'ThreadTb
        '
        Me.ThreadTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ThreadTb.CustomButton.Image = Nothing
        Me.ThreadTb.CustomButton.Location = New System.Drawing.Point(66, 1)
        Me.ThreadTb.CustomButton.Name = ""
        Me.ThreadTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.ThreadTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ThreadTb.CustomButton.TabIndex = 1
        Me.ThreadTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ThreadTb.CustomButton.UseSelectable = True
        Me.ThreadTb.CustomButton.Visible = False
        Me.ThreadTb.Lines = New String(-1) {}
        Me.ThreadTb.Location = New System.Drawing.Point(205, 270)
        Me.ThreadTb.MaxLength = 32767
        Me.ThreadTb.Name = "ThreadTb"
        Me.ThreadTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ThreadTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ThreadTb.SelectedText = ""
        Me.ThreadTb.SelectionLength = 0
        Me.ThreadTb.SelectionStart = 0
        Me.ThreadTb.ShortcutsEnabled = True
        Me.ThreadTb.Size = New System.Drawing.Size(88, 23)
        Me.ThreadTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.ThreadTb.TabIndex = 18
        Me.ThreadTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ThreadTb.UseSelectable = True
        Me.ThreadTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ThreadTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PathLb
        '
        Me.PathLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PathLb.AutoSize = True
        Me.PathLb.BackColor = System.Drawing.SystemColors.Control
        Me.PathLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.PathLb.Location = New System.Drawing.Point(24, 303)
        Me.PathLb.Name = "PathLb"
        Me.PathLb.Size = New System.Drawing.Size(33, 15)
        Me.PathLb.TabIndex = 17
        Me.PathLb.Text = "Path:"
        Me.PathLb.UseCustomBackColor = True
        '
        'PathTb
        '
        Me.PathTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.PathTb.CustomButton.Image = Nothing
        Me.PathTb.CustomButton.Location = New System.Drawing.Point(204, 1)
        Me.PathTb.CustomButton.Name = ""
        Me.PathTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PathTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PathTb.CustomButton.TabIndex = 1
        Me.PathTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PathTb.CustomButton.UseSelectable = True
        Me.PathTb.CustomButton.Visible = False
        Me.PathTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PathTb.Lines = New String(-1) {}
        Me.PathTb.Location = New System.Drawing.Point(67, 299)
        Me.PathTb.MaxLength = 32767
        Me.PathTb.Name = "PathTb"
        Me.PathTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PathTb.ReadOnly = True
        Me.PathTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PathTb.SelectedText = ""
        Me.PathTb.SelectionLength = 0
        Me.PathTb.SelectionStart = 0
        Me.PathTb.ShortcutsEnabled = True
        Me.PathTb.ShowClearButton = True
        Me.PathTb.Size = New System.Drawing.Size(226, 23)
        Me.PathTb.Style = MetroFramework.MetroColorStyle.Purple
        Me.PathTb.TabIndex = 0
        Me.PathTb.UseSelectable = True
        Me.PathTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PathTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FormBulkUserOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 377)
        Me.Controls.Add(Me.DomainTreeView)
        Me.Controls.Add(Me.ConfirmBn)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBulkUserOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk AccountSetup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents ConfirmBn As Controls.MetroButton
    Friend WithEvents CrHfldrLb As Controls.MetroLabel
    Friend WithEvents CrHfldrTg As Controls.MetroToggle
    Friend WithEvents FpwdLb As Controls.MetroLabel
    Friend WithEvents FpwdTg As Controls.MetroToggle
    Friend WithEvents EnAcLb As Controls.MetroLabel
    Friend WithEvents EnAcTg As Controls.MetroToggle
    Friend WithEvents DomainTreeView As ControlDomainTreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ThreadsLb As Controls.MetroLabel
    Friend WithEvents ThreadTb As Controls.MetroTextBox
    Friend WithEvents PathLb As Controls.MetroLabel
    Friend WithEvents PathTb As Controls.MetroTextBox
End Class
