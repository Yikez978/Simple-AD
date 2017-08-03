<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlUsernameContructorChunk
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
        Me.MainButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MainButton
        '
        Me.MainButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainButton.Location = New System.Drawing.Point(0, 0)
        Me.MainButton.Name = "MainButton"
        Me.MainButton.Size = New System.Drawing.Size(74, 42)
        Me.MainButton.TabIndex = 0
        Me.MainButton.Text = "Contructor Piece"
        Me.MainButton.UseSelectable = True
        '
        'UsernameContructorChunk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainButton)
        Me.Name = "UsernameContructorChunk"
        Me.Size = New System.Drawing.Size(74, 42)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainButton As MetroFramework.Controls.MetroButton
End Class
