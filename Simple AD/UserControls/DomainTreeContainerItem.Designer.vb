<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DomainTreeContainerItem
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
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainLb
        '
        Me.MainLb.AutoSize = True
        Me.MainLb.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MainLb.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MainLb.Location = New System.Drawing.Point(26, 2)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(67, 15)
        Me.MainLb.TabIndex = 0
        Me.MainLb.Text = "Object Text"
        Me.MainLb.UseCustomBackColor = True
        '
        'MainFl
        '
        Me.MainFl.AutoSize = True
        Me.MainFl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainFl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MainFl.Location = New System.Drawing.Point(0, 15)
        Me.MainFl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainFl.Name = "MainFl"
        Me.MainFl.Size = New System.Drawing.Size(0, 0)
        Me.MainFl.TabIndex = 1
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.Simple_AD.My.Resources.Resources.Right
        Me.PictureBox.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox.TabIndex = 2
        Me.PictureBox.TabStop = False
        '
        'DomainTreeContainerItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.MainFl)
        Me.Controls.Add(Me.MainLb)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "DomainTreeContainerItem"
        Me.Size = New System.Drawing.Size(449, 20)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainLb As Controls.MetroLabel
    Friend WithEvents MainFl As FlowLayoutPanel
    Friend WithEvents PictureBox As PictureBox
End Class
