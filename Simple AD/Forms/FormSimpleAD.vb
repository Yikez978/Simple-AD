Public Class FormSimpleAD
    Inherits Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSimpleAD))
        Me.SuspendLayout()
        '
        'FormSimpleAD
        '
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSimpleAD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
End Class

