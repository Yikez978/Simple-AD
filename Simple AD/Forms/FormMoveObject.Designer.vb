<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMoveObject
    Inherits SimpleAD.FormSimpleAD

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMoveObject))
        Me.CancelBn = New MetroFramework.Controls.MetroButton()
        Me.AcceptBn = New MetroFramework.Controls.MetroButton()
        Me.FooterPl = New System.Windows.Forms.Panel()
        Me.OULb = New System.Windows.Forms.Label()
        Me.MainPl = New System.Windows.Forms.Panel()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.FooterPl.SuspendLayout()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(291, 13)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 1
        Me.CancelBn.Text = "cancel"
        Me.CancelBn.UseSelectable = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(210, 13)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 2
        Me.AcceptBn.Text = "Accept"
        Me.AcceptBn.UseSelectable = True
        '
        'FooterPl
        '
        Me.FooterPl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.FooterPl.Controls.Add(Me.AcceptBn)
        Me.FooterPl.Controls.Add(Me.CancelBn)
        Me.FooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPl.Location = New System.Drawing.Point(0, 278)
        Me.FooterPl.MaximumSize = New System.Drawing.Size(0, 48)
        Me.FooterPl.MinimumSize = New System.Drawing.Size(0, 48)
        Me.FooterPl.Name = "FooterPl"
        Me.FooterPl.Size = New System.Drawing.Size(378, 48)
        Me.FooterPl.TabIndex = 0
        '
        'OULb
        '
        Me.OULb.BackColor = System.Drawing.SystemColors.Window
        Me.OULb.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OULb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OULb.Location = New System.Drawing.Point(53, 9)
        Me.OULb.Name = "OULb"
        Me.OULb.Size = New System.Drawing.Size(313, 49)
        Me.OULb.TabIndex = 3
        Me.OULb.Text = "Please Select a container..."
        '
        'MainPl
        '
        Me.MainPl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPl.Location = New System.Drawing.Point(15, 58)
        Me.MainPl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPl.Name = "MainPl"
        Me.MainPl.Size = New System.Drawing.Size(352, 203)
        Me.MainPl.TabIndex = 1
        '
        'MainPb
        '
        Me.MainPb.Image = Global.SimpleAD.My.Resources.Resources.Move
        Me.MainPb.Location = New System.Drawing.Point(15, 9)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(32, 32)
        Me.MainPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MainPb.TabIndex = 4
        Me.MainPb.TabStop = False
        '
        'FormMoveObject
        '
        Me.AcceptButton = Me.AcceptBn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(378, 326)
        Me.Controls.Add(Me.OULb)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.MainPl)
        Me.Controls.Add(Me.FooterPl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMoveObject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Move Object"
        Me.FooterPl.ResumeLayout(False)
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelBn As Controls.MetroButton
    Friend WithEvents AcceptBn As Controls.MetroButton
    Friend WithEvents FooterPl As Panel
    Friend WithEvents OULb As Label
    Friend WithEvents MainPl As Panel
    Friend WithEvents MainPb As PictureBox
End Class
