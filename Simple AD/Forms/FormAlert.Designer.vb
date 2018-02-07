Imports System.Windows.Forms
Imports MetroFramework
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlert
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlert))
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.MainLb = New System.Windows.Forms.Label()
        Me.CloseBn = New System.Windows.Forms.Button()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(12, 76)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(64, 64)
        Me.MainPb.TabIndex = 2
        Me.MainPb.TabStop = False
        Me.MainPb.WaitOnLoad = True
        '
        'MainLb
        '
        Me.MainLb.AutoEllipsis = True
        Me.MainLb.Location = New System.Drawing.Point(92, 83)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(280, 52)
        Me.MainLb.TabIndex = 3
        Me.MainLb.Text = "Alert Text"
        '
        'CloseBn
        '
        Me.CloseBn.Location = New System.Drawing.Point(316, 138)
        Me.CloseBn.Name = "CloseBn"
        Me.CloseBn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBn.TabIndex = 0
        Me.CloseBn.Text = "Close"
        Me.CloseBn.UseVisualStyleBackColor = True
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Window
        Me.ImagePl.Controls.Add(Me.TitleLb)
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(403, 56)
        Me.ImagePl.TabIndex = 8
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(49, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Title"
        '
        'FormAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(403, 173)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.CloseBn)
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.MainPb)
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
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents MainLb As Label
    Friend WithEvents CloseBn As Button
    Friend WithEvents ImagePl As SimpleAD.ControlHeaderPanel
    Friend WithEvents TitleLb As Label
End Class
