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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSpinner
        '
        Me.MainSpinner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSpinner.BackColor = System.Drawing.SystemColors.Window
        Me.MainSpinner.Location = New System.Drawing.Point(476, 17)
        Me.MainSpinner.Maximum = 100
        Me.MainSpinner.Name = "MainSpinner"
        Me.MainSpinner.Size = New System.Drawing.Size(60, 60)
        Me.MainSpinner.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainSpinner.TabIndex = 0
        Me.MainSpinner.UseCustomBackColor = True
        Me.MainSpinner.UseSelectable = True
        Me.MainSpinner.Value = 20
        '
        'MainLb
        '
        Me.MainLb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainLb.BackColor = System.Drawing.SystemColors.Window
        Me.MainLb.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MainLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainLb.Location = New System.Drawing.Point(148, 56)
        Me.MainLb.Name = "MainLb"
        Me.MainLb.Size = New System.Drawing.Size(322, 25)
        Me.MainLb.TabIndex = 1
        Me.MainLb.Text = "Main Spinner Label"
        Me.MainLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MainLb.UseCustomBackColor = True
        Me.MainLb.UseCustomForeColor = True
        Me.MainLb.UseMnemonic = False
        '
        'SpinnerTooltip
        '
        Me.SpinnerTooltip.StripAmpersands = True
        Me.SpinnerTooltip.Style = MetroFramework.MetroColorStyle.Blue
        Me.SpinnerTooltip.StyleManager = Nothing
        Me.SpinnerTooltip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MainLb)
        Me.MetroPanel1.Controls.Add(Me.MainSpinner)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 61)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(550, 93)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'ControlTabSpinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "ControlTabSpinner"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(550, 154)
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MainLb As MetroFramework.Controls.MetroLabel
    Friend WithEvents SpinnerTooltip As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroPanel1 As Controls.MetroPanel
End Class
