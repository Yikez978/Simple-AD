<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMoveObject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMoveObject))
        Me.MainPl = New System.Windows.Forms.Panel()
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.FooterPl = New System.Windows.Forms.Panel()
        Me.OULb = New MetroFramework.Controls.MetroLabel()
        Me.FooterPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPl
        '
        Me.MainPl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPl.Location = New System.Drawing.Point(20, 30)
        Me.MainPl.Name = "MainPl"
        Me.MainPl.Size = New System.Drawing.Size(320, 286)
        Me.MainPl.TabIndex = 0
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(242, 50)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 1
        Me.CancelBn.Text = "cancel"
        Me.CancelBn.UseSelectable = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(161, 50)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 2
        Me.AcceptBn.Text = "Accept"
        Me.AcceptBn.UseSelectable = True
        '
        'FooterPl
        '
        Me.FooterPl.Controls.Add(Me.OULb)
        Me.FooterPl.Controls.Add(Me.AcceptBn)
        Me.FooterPl.Controls.Add(Me.CancelBn)
        Me.FooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPl.Location = New System.Drawing.Point(20, 316)
        Me.FooterPl.Name = "FooterPl"
        Me.FooterPl.Size = New System.Drawing.Size(320, 73)
        Me.FooterPl.TabIndex = 0
        '
        'OULb
        '
        Me.OULb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.OULb.Location = New System.Drawing.Point(3, 13)
        Me.OULb.Name = "OULb"
        Me.OULb.Size = New System.Drawing.Size(314, 34)
        Me.OULb.TabIndex = 3
        Me.OULb.Text = "Please Select a container..."
        '
        'FormMoveObject
        '
        Me.AcceptButton = Me.AcceptBn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(360, 409)
        Me.Controls.Add(Me.MainPl)
        Me.Controls.Add(Me.FooterPl)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.WindowText
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMoveObject"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Text = "Move Object"
        Me.FooterPl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPl As Panel
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents AcceptBn As Controls.MetroButton
    Friend WithEvents FooterPl As Panel
    Friend WithEvents OULb As Controls.MetroLabel
End Class
