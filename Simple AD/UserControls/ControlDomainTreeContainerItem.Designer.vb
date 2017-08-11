<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlDomainTreeContainerItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MainLb = New MetroFramework.Controls.MetroLabel()
        Me.MainFl = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.IconBox = New System.Windows.Forms.PictureBox()
        Me.MainPl = New System.Windows.Forms.Panel()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLb
        '
        Me.MainLb.AutoSize = True
        Me.MainLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MainLb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MainLb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.MainLb.Location = New System.Drawing.Point(42, 4)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(66, 15)
        Me.MainLb.TabIndex = 0
        Me.MainLb.Text = "Object Text"
        Me.MainLb.UseCustomBackColor = True
        Me.MainLb.UseCustomForeColor = True
        '
        'MainFl
        '
        Me.MainFl.AutoSize = True
        Me.MainFl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainFl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MainFl.Location = New System.Drawing.Point(-3, 17)
        Me.MainFl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainFl.Name = "MainFl"
        Me.MainFl.Size = New System.Drawing.Size(0, 0)
        Me.MainFl.TabIndex = 1
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.Simple_AD.My.Resources.Resources.Right
        Me.PictureBox.Location = New System.Drawing.Point(0, 4)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox.TabIndex = 2
        Me.PictureBox.TabStop = False
        '
        'IconBox
        '
        Me.IconBox.Image = Global.Simple_AD.My.Resources.Resources.Container
        Me.IconBox.Location = New System.Drawing.Point(22, 4)
        Me.IconBox.Margin = New System.Windows.Forms.Padding(0)
        Me.IconBox.Name = "IconBox"
        Me.IconBox.Size = New System.Drawing.Size(15, 14)
        Me.IconBox.TabIndex = 3
        Me.IconBox.TabStop = False
        '
        'MainPl
        '
        Me.MainPl.AutoSize = True
        Me.MainPl.BackColor = System.Drawing.Color.Transparent
        Me.MainPl.Controls.Add(Me.MainLb)
        Me.MainPl.Controls.Add(Me.IconBox)
        Me.MainPl.Controls.Add(Me.PictureBox)
        Me.MainPl.Location = New System.Drawing.Point(5, 0)
        Me.MainPl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPl.Name = "MainPl"
        Me.MainPl.Size = New System.Drawing.Size(434, 19)
        Me.MainPl.TabIndex = 4
        '
        'ControlDomainTreeContainerItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.CausesValidation = False
        Me.Controls.Add(Me.MainPl)
        Me.Controls.Add(Me.MainFl)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlDomainTreeContainerItem"
        Me.Size = New System.Drawing.Size(449, 21)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPl.ResumeLayout(False)
        Me.MainPl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainLb As Controls.MetroLabel
    Friend WithEvents MainFl As FlowLayoutPanel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents IconBox As PictureBox
    Friend WithEvents MainPl As Panel
End Class
