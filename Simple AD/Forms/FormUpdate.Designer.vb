<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdate))
        Me.BodyLb = New System.Windows.Forms.Label()
        Me.UpdateToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New System.Windows.Forms.Label()
        Me.UpdateBn = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.OldVerLb = New System.Windows.Forms.Label()
        Me.OldBuildLb = New System.Windows.Forms.Label()
        Me.NewBuildPl = New MetroFramework.Controls.MetroPanel()
        Me.NewVerLb = New System.Windows.Forms.Label()
        Me.NewBuildLb = New System.Windows.Forms.Label()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        Me.MetroPanel1.SuspendLayout()
        Me.NewBuildPl.SuspendLayout()
        Me.ControlFooterPl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BodyLb
        '
        Me.BodyLb.AutoSize = True
        Me.BodyLb.Location = New System.Drawing.Point(20, 21)
        Me.BodyLb.Name = "BodyLb"
        Me.BodyLb.Size = New System.Drawing.Size(81, 13)
        Me.BodyLb.TabIndex = 0
        Me.BodyLb.Text = "Main Body Text"
        '
        'UpdateToggle
        '
        Me.UpdateToggle.AutoSize = True
        Me.UpdateToggle.Location = New System.Drawing.Point(21, 116)
        Me.UpdateToggle.Name = "UpdateToggle"
        Me.UpdateToggle.Size = New System.Drawing.Size(80, 17)
        Me.UpdateToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.UpdateToggle.TabIndex = 3
        Me.UpdateToggle.Text = "Off"
        Me.UpdateToggle.UseCustomBackColor = True
        Me.UpdateToggle.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(107, 118)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(148, 13)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Check for updates on Launch"
        '
        'UpdateBn
        '
        Me.UpdateBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateBn.Enabled = False
        Me.UpdateBn.Location = New System.Drawing.Point(302, 9)
        Me.UpdateBn.Name = "UpdateBn"
        Me.UpdateBn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBn.TabIndex = 5
        Me.UpdateBn.Text = "Update"
        Me.UpdateBn.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(383, 9)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 6
        Me.CancelBn.Text = "Close"
        Me.CancelBn.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.OldVerLb)
        Me.MetroPanel1.Controls.Add(Me.OldBuildLb)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 46)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(10, 16, 10, 10)
        Me.MetroPanel1.Size = New System.Drawing.Size(211, 53)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroPanel1.TabIndex = 7
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'OldVerLb
        '
        Me.OldVerLb.AutoSize = True
        Me.OldVerLb.Dock = System.Windows.Forms.DockStyle.Left
        Me.OldVerLb.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldVerLb.Location = New System.Drawing.Point(110, 16)
        Me.OldVerLb.Name = "OldVerLb"
        Me.OldVerLb.Size = New System.Drawing.Size(52, 21)
        Me.OldVerLb.TabIndex = 4
        Me.OldVerLb.Text = "0.0.1.0"
        '
        'OldBuildLb
        '
        Me.OldBuildLb.AutoSize = True
        Me.OldBuildLb.Dock = System.Windows.Forms.DockStyle.Left
        Me.OldBuildLb.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldBuildLb.Location = New System.Drawing.Point(10, 16)
        Me.OldBuildLb.Name = "OldBuildLb"
        Me.OldBuildLb.Size = New System.Drawing.Size(100, 21)
        Me.OldBuildLb.TabIndex = 5
        Me.OldBuildLb.Text = "Current Build"
        '
        'NewBuildPl
        '
        Me.NewBuildPl.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NewBuildPl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewBuildPl.Controls.Add(Me.NewVerLb)
        Me.NewBuildPl.Controls.Add(Me.NewBuildLb)
        Me.NewBuildPl.HorizontalScrollbarBarColor = True
        Me.NewBuildPl.HorizontalScrollbarHighlightOnWheel = False
        Me.NewBuildPl.HorizontalScrollbarSize = 10
        Me.NewBuildPl.Location = New System.Drawing.Point(240, 46)
        Me.NewBuildPl.Name = "NewBuildPl"
        Me.NewBuildPl.Padding = New System.Windows.Forms.Padding(10, 16, 10, 10)
        Me.NewBuildPl.Size = New System.Drawing.Size(211, 53)
        Me.NewBuildPl.Style = MetroFramework.MetroColorStyle.Silver
        Me.NewBuildPl.TabIndex = 8
        Me.NewBuildPl.UseCustomBackColor = True
        Me.NewBuildPl.UseStyleColors = True
        Me.NewBuildPl.VerticalScrollbarBarColor = True
        Me.NewBuildPl.VerticalScrollbarHighlightOnWheel = False
        Me.NewBuildPl.VerticalScrollbarSize = 10
        '
        'NewVerLb
        '
        Me.NewVerLb.AutoSize = True
        Me.NewVerLb.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewVerLb.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewVerLb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewVerLb.Location = New System.Drawing.Point(10, 16)
        Me.NewVerLb.Name = "NewVerLb"
        Me.NewVerLb.Size = New System.Drawing.Size(69, 21)
        Me.NewVerLb.TabIndex = 3
        Me.NewVerLb.Text = "Fetching"
        '
        'NewBuildLb
        '
        Me.NewBuildLb.AutoSize = True
        Me.NewBuildLb.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBuildLb.Location = New System.Drawing.Point(10, 16)
        Me.NewBuildLb.Name = "NewBuildLb"
        Me.NewBuildLb.Size = New System.Drawing.Size(89, 21)
        Me.NewBuildLb.TabIndex = 4
        Me.NewBuildLb.Text = "Latest Build"
        '
        'Spinner
        '
        Me.Spinner.Location = New System.Drawing.Point(414, 114)
        Me.Spinner.Maximum = 100
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(28, 28)
        Me.Spinner.Style = MetroFramework.MetroColorStyle.Purple
        Me.Spinner.TabIndex = 9
        Me.Spinner.UseCustomBackColor = True
        Me.Spinner.UseSelectable = True
        Me.Spinner.Value = 10
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl1.Controls.Add(Me.CancelBn)
        Me.ControlFooterPl1.Controls.Add(Me.UpdateBn)
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 158)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(470, 44)
        Me.ControlFooterPl1.TabIndex = 10
        '
        'FormUpdate
        '
        Me.AcceptButton = Me.UpdateBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(470, 202)
        Me.Controls.Add(Me.Spinner)
        Me.Controls.Add(Me.NewBuildPl)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.UpdateToggle)
        Me.Controls.Add(Me.BodyLb)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdate"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.NewBuildPl.ResumeLayout(False)
        Me.NewBuildPl.PerformLayout()
        Me.ControlFooterPl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateToggle As Controls.MetroToggle
    Friend WithEvents UpdateBn As Controls.MetroButton
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents MetroPanel1 As Controls.MetroPanel
    Friend WithEvents NewBuildPl As Controls.MetroPanel
    Friend WithEvents Spinner As Controls.MetroProgressSpinner
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
    Friend WithEvents BodyLb As Label
    Friend WithEvents MetroLabel2 As Label
    Friend WithEvents NewVerLb As Label
    Friend WithEvents OldVerLb As Label
    Friend WithEvents OldBuildLb As Label
    Friend WithEvents NewBuildLb As Label
End Class
