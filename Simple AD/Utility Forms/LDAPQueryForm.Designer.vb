<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LDAPQueryForm
    Inherits MetroFramework.Forms.MetroForm

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
        Me.QueryTb = New MetroFramework.Controls.MetroTextBox()
        Me.RunBn = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'QueryTb
        '
        Me.QueryTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.QueryTb.CustomButton.Image = Nothing
        Me.QueryTb.CustomButton.Location = New System.Drawing.Point(343, 1)
        Me.QueryTb.CustomButton.Name = ""
        Me.QueryTb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.QueryTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QueryTb.CustomButton.TabIndex = 1
        Me.QueryTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QueryTb.CustomButton.UseSelectable = True
        Me.QueryTb.CustomButton.Visible = False
        Me.QueryTb.Lines = New String(-1) {}
        Me.QueryTb.Location = New System.Drawing.Point(23, 29)
        Me.QueryTb.MaxLength = 32767
        Me.QueryTb.Name = "QueryTb"
        Me.QueryTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QueryTb.PromptText = "LDAP Query"
        Me.QueryTb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QueryTb.SelectedText = ""
        Me.QueryTb.SelectionLength = 0
        Me.QueryTb.SelectionStart = 0
        Me.QueryTb.ShortcutsEnabled = True
        Me.QueryTb.Size = New System.Drawing.Size(396, 23)
        Me.QueryTb.TabIndex = 0
        Me.QueryTb.UseSelectable = True
        Me.QueryTb.WaterMark = "LDAP Query"
        Me.QueryTb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QueryTb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'RunBn
        '
        Me.RunBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunBn.Location = New System.Drawing.Point(425, 29)
        Me.RunBn.Name = "RunBn"
        Me.RunBn.Size = New System.Drawing.Size(75, 23)
        Me.RunBn.TabIndex = 1
        Me.RunBn.Text = "Run"
        Me.RunBn.UseSelectable = True
        '
        'LDAPQueryForm
        '
        Me.AcceptButton = Me.RunBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 75)
        Me.Controls.Add(Me.RunBn)
        Me.Controls.Add(Me.QueryTb)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LDAPQueryForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "LDAPQueryForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QueryTb As Controls.MetroTextBox
    Friend WithEvents RunBn As Controls.MetroButton
End Class
