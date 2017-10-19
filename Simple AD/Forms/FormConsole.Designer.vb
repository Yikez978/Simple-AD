<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsole))
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox
        '
        Me.RichTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.ForeColor = System.Drawing.Color.Silver
        Me.RichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = True
        Me.RichTextBox.Size = New System.Drawing.Size(721, 387)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = ""
        '
        'FormConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 387)
        Me.Controls.Add(Me.RichTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConsole"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Console"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox As RichTextBox
End Class
