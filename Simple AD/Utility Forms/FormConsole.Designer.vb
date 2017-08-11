<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsole
    Inherits Simple_AD.FormSimpleAD

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
        Me.RichTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.RichTextBox.Location = New System.Drawing.Point(2, 30)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = True
        Me.RichTextBox.Size = New System.Drawing.Size(587, 257)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = ""
        '
        'FormConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 289)
        Me.Controls.Add(Me.RichTextBox)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConsole"
        Me.Padding = New System.Windows.Forms.Padding(2, 30, 2, 2)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Console"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox As RichTextBox
End Class
