<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLDAPQuery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLDAPQuery))
        Me.QueryTb = New MetroFramework.Controls.MetroTextBox()
        Me.RunBn = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'QueryTb
        '
        '
        '
        '
        Me.QueryTb.CustomButton.Image = Nothing
        Me.QueryTb.CustomButton.Location = New System.Drawing.Point(336, 1)
        Me.QueryTb.CustomButton.Name = ""
        Me.QueryTb.CustomButton.Size = New System.Drawing.Size(69, 69)
        Me.QueryTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QueryTb.CustomButton.TabIndex = 1
        Me.QueryTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QueryTb.CustomButton.UseSelectable = True
        Me.QueryTb.CustomButton.Visible = False
        Me.QueryTb.Lines = New String(-1) {}
        Me.QueryTb.Location = New System.Drawing.Point(12, 12)
        Me.QueryTb.MaxLength = 32767
        Me.QueryTb.Multiline = True
        Me.QueryTb.Name = "QueryTb"
        Me.QueryTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QueryTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QueryTb.SelectedText = ""
        Me.QueryTb.SelectionLength = 0
        Me.QueryTb.SelectionStart = 0
        Me.QueryTb.ShortcutsEnabled = True
        Me.QueryTb.Size = New System.Drawing.Size(406, 71)
        Me.QueryTb.Style = MetroFramework.MetroColorStyle.Silver
        Me.QueryTb.TabIndex = 0
        Me.QueryTb.UseSelectable = True
        Me.QueryTb.WaterMark = "LDAP Query"
        Me.QueryTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QueryTb.WaterMarkFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RunBn
        '
        Me.RunBn.Location = New System.Drawing.Point(343, 89)
        Me.RunBn.Name = "RunBn"
        Me.RunBn.Size = New System.Drawing.Size(75, 23)
        Me.RunBn.TabIndex = 1
        Me.RunBn.Text = "Run"
        Me.RunBn.UseSelectable = True
        '
        'FormLDAPQuery
        '
        Me.AcceptButton = Me.RunBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(429, 125)
        Me.Controls.Add(Me.RunBn)
        Me.Controls.Add(Me.QueryTb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLDAPQuery"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LDAPQueryForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QueryTb As Controls.MetroTextBox
    Friend WithEvents RunBn As Controls.MetroButton
End Class
