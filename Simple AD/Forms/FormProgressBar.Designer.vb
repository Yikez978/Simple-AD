Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProgressBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProgressBar))
        Me.MainProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StatusLb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MainProgressBar
        '
        Me.MainProgressBar.Location = New System.Drawing.Point(23, 45)
        Me.MainProgressBar.Name = "MainProgressBar"
        Me.MainProgressBar.Size = New System.Drawing.Size(375, 23)
        Me.MainProgressBar.TabIndex = 0
        '
        'StatusLb
        '
        Me.StatusLb.AutoEllipsis = True
        Me.StatusLb.AutoSize = True
        Me.StatusLb.Location = New System.Drawing.Point(20, 23)
        Me.StatusLb.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.StatusLb.Name = "StatusLb"
        Me.StatusLb.Size = New System.Drawing.Size(61, 13)
        Me.StatusLb.TabIndex = 2
        Me.StatusLb.Text = "Status Text"
        '
        'FormProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(428, 79)
        Me.Controls.Add(Me.StatusLb)
        Me.Controls.Add(Me.MainProgressBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProgressBar"
        Me.Padding = New System.Windows.Forms.Padding(20, 0, 20, 8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProgressBar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusLb As Label
End Class
