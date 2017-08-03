<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlTabSpinner
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
        Me.MainSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.MainLb = New MetroFramework.Controls.MetroLabel()
        Me.SpinnerTooltip = New MetroFramework.Components.MetroToolTip()
        Me.SuspendLayout()
        '
        'MainSpinner
        '
        Me.MainSpinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSpinner.BackColor = System.Drawing.SystemColors.Window
        Me.MainSpinner.Location = New System.Drawing.Point(173, 10)
        Me.MainSpinner.Maximum = 100
        Me.MainSpinner.Name = "MainSpinner"
        Me.MainSpinner.Size = New System.Drawing.Size(80, 80)
        Me.MainSpinner.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainSpinner.TabIndex = 0
        Me.MainSpinner.UseCustomBackColor = True
        Me.MainSpinner.UseSelectable = True
        Me.MainSpinner.Value = 20
        '
        'MainLb
        '
        Me.MainLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainLb.AutoSize = True
        Me.MainLb.BackColor = System.Drawing.SystemColors.Window
        Me.MainLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MainLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainLb.Location = New System.Drawing.Point(9, 65)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(158, 25)
        Me.MainLb.TabIndex = 1
        Me.MainLb.Text = "Main Spinner Label"
        Me.MainLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MainLb.UseCustomBackColor = True
        Me.MainLb.UseCustomForeColor = True
        Me.MainLb.UseMnemonic = False
        Me.MainLb.WrapToLine = True
        '
        'SpinnerTooltip
        '
        Me.SpinnerTooltip.StripAmpersands = True
        Me.SpinnerTooltip.Style = MetroFramework.MetroColorStyle.Blue
        Me.SpinnerTooltip.StyleManager = Nothing
        Me.SpinnerTooltip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'ControlTabSpinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.MainSpinner)
        Me.Name = "ControlTabSpinner"
        Me.Size = New System.Drawing.Size(342, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MainLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents SpinnerTooltip As MetroFramework.Components.MetroToolTip
End Class
