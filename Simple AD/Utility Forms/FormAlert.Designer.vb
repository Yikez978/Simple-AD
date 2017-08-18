<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlert))
        Me.CloseBn = New MetroFramework.Controls.MetroButton()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.MainLb = New MetroFramework.Controls.MetroLabel()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBn
        '
        Me.CloseBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBn.Location = New System.Drawing.Point(302, 112)
        Me.CloseBn.Name = "CloseBn"
        Me.CloseBn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBn.TabIndex = 0
        Me.CloseBn.Text = "Close"
        Me.CloseBn.UseSelectable = True
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(23, 63)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(64, 64)
        Me.MainPb.TabIndex = 2
        Me.MainPb.TabStop = False
        Me.MainPb.WaitOnLoad = True
        '
        'MainLb
        '
        Me.MainLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MainLb.Location = New System.Drawing.Point(93, 63)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(277, 49)
        Me.MainLb.TabIndex = 3
        Me.MainLb.Text = "Alert Text"
        Me.MainLb.WrapToLine = True
        '
        'FormAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(400, 158)
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.CloseBn)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAlert"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Alert"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseBn As Controls.MetroButton
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents MainLb As Controls.MetroLabel
End Class
