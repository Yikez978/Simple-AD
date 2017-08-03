<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TabSpinner
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
        Me.MainSpinner.BackColor = System.Drawing.SystemColors.Control
        Me.MainSpinner.Location = New System.Drawing.Point(145, 135)
        Me.MainSpinner.Maximum = 100
        Me.MainSpinner.Name = "MainSpinner"
        Me.MainSpinner.Size = New System.Drawing.Size(100, 100)
        Me.MainSpinner.TabIndex = 0
        Me.MainSpinner.UseCustomBackColor = True
        Me.MainSpinner.UseSelectable = True
        Me.MainSpinner.Value = 20
        '
        'MainLb
        '
        Me.MainLb.AutoSize = True
        Me.MainLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MainLb.Location = New System.Drawing.Point(121, 363)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(158, 25)
        Me.MainLb.TabIndex = 1
        Me.MainLb.Text = "Main Spinner Lable"
        Me.MainLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MainLb.UseCustomBackColor = True
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
        'TabSpinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.MainLb)
        Me.Controls.Add(Me.MainSpinner)
        Me.Name = "TabSpinner"
        Me.Size = New System.Drawing.Size(400, 400)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MainLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents SpinnerTooltip As MetroFramework.Components.MetroToolTip
End Class
