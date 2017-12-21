<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlert))
        Me.CloseBn = New MetroFramework.Controls.MetroButton()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.MainLb = New System.Windows.Forms.Label()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBn
        '
        Me.CloseBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBn.Location = New System.Drawing.Point(316, 101)
        Me.CloseBn.Name = "CloseBn"
        Me.CloseBn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBn.TabIndex = 0
        Me.CloseBn.Text = "Close"
        Me.CloseBn.UseSelectable = True
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(12, 12)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(64, 64)
        Me.MainPb.TabIndex = 2
        Me.MainPb.TabStop = False
        Me.MainPb.WaitOnLoad = True
        '
        'MainLb
        '
        Me.MainLb.Location = New System.Drawing.Point(82, 31)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(299, 30)
        Me.MainLb.TabIndex = 3
        Me.MainLb.Text = "Alert Text"
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 87)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(403, 49)
        Me.ControlFooterPl1.TabIndex = 4
        '
        'FormAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(403, 136)
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.CloseBn)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAlert"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alert"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseBn As Controls.MetroButton
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents MainLb As Label
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
End Class
