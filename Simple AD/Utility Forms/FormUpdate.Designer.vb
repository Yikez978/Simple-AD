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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.updateBn = New MetroFramework.Controls.MetroButton()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.OldVerLb = New MetroFramework.Controls.MetroLabel()
        Me.OldBuildLb = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.NewVerLb = New MetroFramework.Controls.MetroLabel()
        Me.NewBuildLb = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 72)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Main Body Text"
        '
        'MetroToggle1
        '
        Me.MetroToggle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Location = New System.Drawing.Point(23, 186)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle1.TabIndex = 3
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.UseSelectable = True
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
        'updateBn
        '
        Me.updateBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBn.Location = New System.Drawing.Point(321, 184)
        Me.updateBn.Name = "updateBn"
        Me.updateBn.Size = New System.Drawing.Size(75, 23)
        Me.updateBn.TabIndex = 5
        Me.updateBn.Text = "Update"
        Me.updateBn.UseSelectable = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(402, 184)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 6
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
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
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.NewVerLb)
        Me.MetroPanel2.Controls.Add(Me.NewBuildLb)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(240, 107)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(10, 16, 10, 10)
        Me.MetroPanel2.Size = New System.Drawing.Size(211, 53)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroPanel2.TabIndex = 8
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
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
        Me.NewVerLb.Size = New System.Drawing.Size(64, 25)
        Me.NewVerLb.TabIndex = 3
        Me.NewVerLb.Text = "0.1.0.6"
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
        'FormUpdate
        '
        Me.AcceptButton = Me.updateBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(500, 226)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.updateBn)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroToggle1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdate"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Update"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As Controls.MetroLabel
    Friend WithEvents MetroToggle1 As Controls.MetroToggle
    Friend WithEvents MetroLabel2 As Controls.MetroLabel
    Friend WithEvents updateBn As Controls.MetroButton
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents MetroPanel1 As Controls.MetroPanel
    Friend WithEvents MetroPanel2 As Controls.MetroPanel
    Friend WithEvents NewVerLb As Controls.MetroLabel
    Friend WithEvents OldVerLb As Controls.MetroLabel
    Friend WithEvents OldBuildLb As Controls.MetroLabel
    Friend WithEvents NewBuildLb As Controls.MetroLabel
End Class
