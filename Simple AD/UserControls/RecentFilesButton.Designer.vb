<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecentFilesButton
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
        Me.FileTitleLb = New System.Windows.Forms.Label()
        Me.FileNameLb = New System.Windows.Forms.Label()
        Me.DateModifedLb = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileTitleLb
        '
        Me.FileTitleLb.AutoEllipsis = True
        Me.FileTitleLb.AutoSize = True
        Me.FileTitleLb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileTitleLb.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FileTitleLb.Location = New System.Drawing.Point(53, 31)
        Me.FileTitleLb.Name = "FileTitleLb"
        Me.FileTitleLb.Size = New System.Drawing.Size(222, 13)
        Me.FileTitleLb.TabIndex = 0
        Me.FileTitleLb.Text = "C:\Users\Joel\Documents\SampleUsers.csv"
        '
        'FileNameLb
        '
        Me.FileNameLb.AutoEllipsis = True
        Me.FileNameLb.AutoSize = True
        Me.FileNameLb.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNameLb.Location = New System.Drawing.Point(53, 4)
        Me.FileNameLb.Name = "FileNameLb"
        Me.FileNameLb.Size = New System.Drawing.Size(101, 21)
        Me.FileNameLb.TabIndex = 1
        Me.FileNameLb.Text = "FileName.csv"
        '
        'DateModifedLb
        '
        Me.DateModifedLb.AutoSize = True
        Me.DateModifedLb.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateModifedLb.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DateModifedLb.Location = New System.Drawing.Point(397, 4)
        Me.DateModifedLb.Name = "DateModifedLb"
        Me.DateModifedLb.Size = New System.Drawing.Size(95, 13)
        Me.DateModifedLb.TabIndex = 3
        Me.DateModifedLb.Text = "14:26 13/06/2017"
        Me.DateModifedLb.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 2
        Me.PictureBox.TabStop = False
        '
        'RecentFilesButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.DateModifedLb)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.FileNameLb)
        Me.Controls.Add(Me.FileTitleLb)
        Me.Name = "RecentFilesButton"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(496, 50)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileTitleLb As Label
    Friend WithEvents FileNameLb As Label
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents DateModifedLb As Label
End Class
