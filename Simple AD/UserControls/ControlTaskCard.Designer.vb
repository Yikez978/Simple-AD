<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTaskCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.NameLb = New System.Windows.Forms.Label()
        Me.DescritptionLb = New System.Windows.Forms.Label()
        Me.MainProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.StopTaskBn = New MetroFramework.Controls.MetroButton()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.StatusLb = New System.Windows.Forms.Label()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLb
        '
        Me.NameLb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameLb.AutoEllipsis = True
        Me.NameLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.NameLb.Location = New System.Drawing.Point(30, 8)
        Me.NameLb.Name = "NameLb"
        Me.NameLb.Size = New System.Drawing.Size(205, 16)
        Me.NameLb.TabIndex = 0
        Me.NameLb.Text = "Task Heading"
        '
        'DescritptionLb
        '
        Me.DescritptionLb.AutoEllipsis = True
        Me.DescritptionLb.AutoSize = True
        Me.DescritptionLb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DescritptionLb.Location = New System.Drawing.Point(5, 33)
        Me.DescritptionLb.Name = "DescritptionLb"
        Me.DescritptionLb.Size = New System.Drawing.Size(186, 13)
        Me.DescritptionLb.TabIndex = 1
        Me.DescritptionLb.Text = "This is a short description of the Task."
        '
        'MainProgressBar
        '
        Me.MainProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainProgressBar.Location = New System.Drawing.Point(6, 70)
        Me.MainProgressBar.Margin = New System.Windows.Forms.Padding(6)
        Me.MainProgressBar.Name = "MainProgressBar"
        Me.MainProgressBar.Size = New System.Drawing.Size(255, 12)
        Me.MainProgressBar.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainProgressBar.TabIndex = 2
        Me.MainProgressBar.Visible = False
        '
        'StopTaskBn
        '
        Me.StopTaskBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopTaskBn.BackColor = System.Drawing.SystemColors.Window
        Me.StopTaskBn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.StopTaskBn.Location = New System.Drawing.Point(241, 4)
        Me.StopTaskBn.Name = "StopTaskBn"
        Me.StopTaskBn.Size = New System.Drawing.Size(23, 23)
        Me.StopTaskBn.TabIndex = 3
        Me.StopTaskBn.Text = "X"
        Me.StopTaskBn.UseCustomBackColor = True
        Me.StopTaskBn.UseCustomForeColor = True
        Me.StopTaskBn.UseSelectable = True
        Me.StopTaskBn.Visible = False
        '
        'MainPb
        '
        Me.MainPb.Image = Global.SimpleAD.My.Resources.Resources.CheckTick
        Me.MainPb.Location = New System.Drawing.Point(8, 8)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(16, 16)
        Me.MainPb.TabIndex = 4
        Me.MainPb.TabStop = False
        '
        'StatusLb
        '
        Me.StatusLb.AutoSize = True
        Me.StatusLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusLb.Location = New System.Drawing.Point(5, 51)
        Me.StatusLb.Name = "StatusLb"
        Me.StatusLb.Size = New System.Drawing.Size(43, 13)
        Me.StatusLb.TabIndex = 5
        Me.StatusLb.Text = "Status"
        '
        'ControlTaskCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.StatusLb)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.StopTaskBn)
        Me.Controls.Add(Me.MainProgressBar)
        Me.Controls.Add(Me.DescritptionLb)
        Me.Controls.Add(Me.NameLb)
        Me.DoubleBuffered = True
        Me.Name = "ControlTaskCard"
        Me.Size = New System.Drawing.Size(267, 93)
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLb As Label
    Friend WithEvents DescritptionLb As Label
    Friend WithEvents MainProgressBar As Controls.MetroProgressBar
    Friend WithEvents StopTaskBn As Controls.MetroButton
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents StatusLb As Label
End Class
