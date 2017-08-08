<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DomainTreeContainer
    Inherits MetroFramework.Controls.MetroUserControl

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
        Me.SuspendLayout()
        '
        'DomainTreeContainer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "DomainTreeContainer"
        Me.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.Size = New System.Drawing.Size(308, 417)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.UseCustomBackColor = True
        Me.ResumeLayout(False)

    End Sub
End Class
