<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdate
    Inherits MetroFramework.Forms.MetroForm

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
        Me.BodyLb = New MetroFramework.Controls.MetroLabel()
        Me.UpdateToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.UpdateBn = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.OldVerLb = New MetroFramework.Controls.MetroLabel()
        Me.OldBuildLb = New MetroFramework.Controls.MetroLabel()
        Me.NewBuildPl = New MetroFramework.Controls.MetroPanel()
        Me.NewVerLb = New MetroFramework.Controls.MetroLabel()
        Me.NewBuildLb = New MetroFramework.Controls.MetroLabel()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.MetroPanel1.SuspendLayout()
        Me.NewBuildPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'BodyLb
        '
        Me.BodyLb.AutoSize = True
        Me.BodyLb.Location = New System.Drawing.Point(23, 72)
        Me.BodyLb.Name = "BodyLb"
        Me.BodyLb.Size = New System.Drawing.Size(100, 19)
        Me.BodyLb.TabIndex = 0
        Me.BodyLb.Text = "Main Body Text"
        '
        'UpdateToggle
        '
        Me.UpdateToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UpdateToggle.AutoSize = True
        Me.UpdateToggle.Location = New System.Drawing.Point(23, 186)
        Me.UpdateToggle.Name = "UpdateToggle"
        Me.UpdateToggle.Size = New System.Drawing.Size(80, 17)
        Me.UpdateToggle.Style = MetroFramework.MetroColorStyle.Purple
        Me.UpdateToggle.TabIndex = 3
        Me.UpdateToggle.Text = "Off"
        Me.UpdateToggle.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(109, 184)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(178, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Check for updates on Launch"
        '
        'UpdateBn
        '
        Me.UpdateBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateBn.Enabled = False
        Me.UpdateBn.Location = New System.Drawing.Point(321, 184)
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
        Me.CancelBn.Location = New System.Drawing.Point(402, 184)
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
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 107)
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
        Me.OldVerLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.OldVerLb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.OldVerLb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OldVerLb.Location = New System.Drawing.Point(122, 16)
        Me.OldVerLb.Name = "OldVerLb"
        Me.OldVerLb.Size = New System.Drawing.Size(64, 25)
        Me.OldVerLb.TabIndex = 4
        Me.OldVerLb.Text = "0.0.1.0"
        Me.OldVerLb.UseCustomBackColor = True
        Me.OldVerLb.UseCustomForeColor = True
        '
        'OldBuildLb
        '
        Me.OldBuildLb.AutoSize = True
        Me.OldBuildLb.Dock = System.Windows.Forms.DockStyle.Left
        Me.OldBuildLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.OldBuildLb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OldBuildLb.Location = New System.Drawing.Point(10, 16)
        Me.OldBuildLb.Name = "OldBuildLb"
        Me.OldBuildLb.Size = New System.Drawing.Size(112, 25)
        Me.OldBuildLb.TabIndex = 5
        Me.OldBuildLb.Text = "Current Build"
        Me.OldBuildLb.UseCustomBackColor = True
        Me.OldBuildLb.UseCustomForeColor = True
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
        Me.NewBuildPl.Location = New System.Drawing.Point(240, 107)
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
        Me.NewVerLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.NewVerLb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.NewVerLb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewVerLb.Location = New System.Drawing.Point(108, 16)
        Me.NewVerLb.Name = "NewVerLb"
        Me.NewVerLb.Size = New System.Drawing.Size(79, 25)
        Me.NewVerLb.TabIndex = 3
        Me.NewVerLb.Text = "Fetching"
        Me.NewVerLb.UseCustomBackColor = True
        Me.NewVerLb.UseCustomForeColor = True
        '
        'NewBuildLb
        '
        Me.NewBuildLb.AutoSize = True
        Me.NewBuildLb.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewBuildLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.NewBuildLb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewBuildLb.Location = New System.Drawing.Point(10, 16)
        Me.NewBuildLb.Name = "NewBuildLb"
        Me.NewBuildLb.Size = New System.Drawing.Size(98, 25)
        Me.NewBuildLb.TabIndex = 4
        Me.NewBuildLb.Text = "Latest Build"
        Me.NewBuildLb.UseCustomBackColor = True
        Me.NewBuildLb.UseCustomForeColor = True
        '
        'Spinner
        '
        Me.Spinner.Location = New System.Drawing.Point(427, 21)
        Me.Spinner.Maximum = 100
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(50, 52)
        Me.Spinner.Style = MetroFramework.MetroColorStyle.Purple
        Me.Spinner.TabIndex = 9
        Me.Spinner.UseSelectable = True
        Me.Spinner.Value = 10
        '
        'FormUpdate
        '
        Me.AcceptButton = Me.UpdateBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(500, 226)
        Me.Controls.Add(Me.Spinner)
        Me.Controls.Add(Me.NewBuildPl)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.UpdateBn)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.UpdateToggle)
        Me.Controls.Add(Me.BodyLb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdate"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Update"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.NewBuildPl.ResumeLayout(False)
        Me.NewBuildPl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BodyLb As Controls.MetroLabel
    Friend WithEvents UpdateToggle As Controls.MetroToggle
    Friend WithEvents MetroLabel2 As Controls.MetroLabel
    Friend WithEvents UpdateBn As Controls.MetroButton
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents MetroPanel1 As Controls.MetroPanel
    Friend WithEvents NewBuildPl As Controls.MetroPanel
    Friend WithEvents NewVerLb As Controls.MetroLabel
    Friend WithEvents OldVerLb As Controls.MetroLabel
    Friend WithEvents OldBuildLb As Controls.MetroLabel
    Friend WithEvents NewBuildLb As Controls.MetroLabel
    Friend WithEvents Spinner As Controls.MetroProgressSpinner
End Class
