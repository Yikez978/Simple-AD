Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportRule
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportRule))
        Me.RuleCombo = New System.Windows.Forms.ComboBox()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.LogicCombo = New System.Windows.Forms.ComboBox()
        Me.ValuePl = New System.Windows.Forms.Panel()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'RuleCombo
        '
        Me.RuleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RuleCombo.FormattingEnabled = True
        Me.RuleCombo.ItemHeight = 13
        Me.RuleCombo.Location = New System.Drawing.Point(29, 84)
        Me.RuleCombo.Name = "RuleCombo"
        Me.RuleCombo.Size = New System.Drawing.Size(183, 21)
        Me.RuleCombo.Sorted = True
        Me.RuleCombo.TabIndex = 0
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Window
        Me.ImagePl.Controls.Add(Me.TitleLb)
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(505, 56)
        Me.ImagePl.TabIndex = 9
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(246, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Add New Query Definition"
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(418, 134)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 10
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'AcceptBn
        '
        Me.AcceptBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptBn.Location = New System.Drawing.Point(337, 134)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 11
        Me.AcceptBn.Text = "Add"
        Me.AcceptBn.UseVisualStyleBackColor = True
        '
        'LogicCombo
        '
        Me.LogicCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LogicCombo.FormattingEnabled = True
        Me.LogicCombo.ItemHeight = 13
        Me.LogicCombo.Location = New System.Drawing.Point(218, 84)
        Me.LogicCombo.Name = "LogicCombo"
        Me.LogicCombo.Size = New System.Drawing.Size(113, 21)
        Me.LogicCombo.Sorted = True
        Me.LogicCombo.TabIndex = 12
        '
        'ValuePl
        '
        Me.ValuePl.Location = New System.Drawing.Point(337, 84)
        Me.ValuePl.Name = "ValuePl"
        Me.ValuePl.Size = New System.Drawing.Size(156, 44)
        Me.ValuePl.TabIndex = 13
        '
        'FormReportRule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 169)
        Me.Controls.Add(Me.ValuePl)
        Me.Controls.Add(Me.LogicCombo)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.AcceptBn)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.RuleCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReportRule"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Rule"
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RuleCombo As Windows.Forms.ComboBox
    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Windows.Forms.Label
    Friend WithEvents CancelBn As Windows.Forms.Button
    Friend WithEvents AcceptBn As Windows.Forms.Button
    Friend WithEvents LogicCombo As Windows.Forms.ComboBox
    Friend WithEvents ValuePl As Windows.Forms.Panel
End Class
