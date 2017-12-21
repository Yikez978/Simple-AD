<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfirmation))
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.MainLb = New System.Windows.Forms.Label()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.ControlFooterPl1 = New SimpleAD.ControlFooterPl()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlFooterPl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(313, 13)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 0
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(232, 13)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 1
        Me.AcceptBn.Text = "Delete"
        Me.AcceptBn.UseSelectable = True
        '
        'MainLb
        '
        Me.MainLb.Location = New System.Drawing.Point(82, 26)
        Me.MainLb.MaximumSize = New System.Drawing.Size(277, 49)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(277, 32)
        Me.MainLb.TabIndex = 2
        Me.MainLb.Text = "Are you sure you wish to delete"
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(12, 12)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(64, 64)
        Me.MainPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MainPb.TabIndex = 3
        Me.MainPb.TabStop = False
        '
        'ControlFooterPl1
        '
        Me.ControlFooterPl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl1.Controls.Add(Me.CancelBn)
        Me.ControlFooterPl1.Controls.Add(Me.AcceptBn)
        Me.ControlFooterPl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl1.Location = New System.Drawing.Point(0, 91)
        Me.ControlFooterPl1.Name = "ControlFooterPl1"
        Me.ControlFooterPl1.Size = New System.Drawing.Size(400, 48)
        Me.ControlFooterPl1.TabIndex = 4
        '
        'FormConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(400, 139)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.ControlFooterPl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConfirmation"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirm"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlFooterPl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents AcceptBn As Controls.MetroButton
    Friend WithEvents MainLb As Label
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents ControlFooterPl1 As ControlFooterPl
End Class
