<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfirmation))
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.MainLb = New MetroFramework.Controls.MetroLabel()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(302, 112)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 0
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseSelectable = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(221, 112)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 1
        Me.AcceptBn.Text = "Delete"
        Me.AcceptBn.UseSelectable = True
        '
        'MainLb
        '
        Me.MainLb.Location = New System.Drawing.Point(93, 63)
        Me.MainLb.MaximumSize = New System.Drawing.Size(277, 49)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(277, 46)
        Me.MainLb.TabIndex = 2
        Me.MainLb.Text = "Are you sure you wish to delete"
        Me.MainLb.WrapToLine = True
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(23, 63)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(64, 64)
        Me.MainPb.TabIndex = 3
        Me.MainPb.TabStop = False
        '
        'FormConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(400, 158)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.CancelBn)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConfirmation"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Confirm"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents AcceptBn As Controls.MetroButton
    Friend WithEvents MainLb As Controls.MetroLabel
    Friend WithEvents MainPb As PictureBox
End Class
