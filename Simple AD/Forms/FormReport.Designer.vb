Imports System.Windows.Forms
Imports MetroFramework
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReport
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.MainTabControl = New SimpleAD.CustomTabControlNoHeaders()
        Me.ConfigTab = New System.Windows.Forms.TabPage()
        Me.RemoveRuleBn = New System.Windows.Forms.Button()
        Me.AddRuleBn = New System.Windows.Forms.Button()
        Me.TypeLb = New System.Windows.Forms.Label()
        Me.ConfigFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.TypeCombo = New System.Windows.Forms.ComboBox()
        Me.ProgressTab = New System.Windows.Forms.TabPage()
        Me.ConsolePl = New System.Windows.Forms.Panel()
        Me.ConsoleTb = New System.Windows.Forms.RichTextBox()
        Me.MainProgressLb = New System.Windows.Forms.Label()
        Me.MainProgresBar = New System.Windows.Forms.ProgressBar()
        Me.ResultsTab = New System.Windows.Forms.TabPage()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.ControlFooterPl = New System.Windows.Forms.Panel()
        Me.BackBn = New System.Windows.Forms.Button()
        Me.AcceptBn = New System.Windows.Forms.Button()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.MainTabControl.SuspendLayout()
        Me.ConfigTab.SuspendLayout()
        Me.ProgressTab.SuspendLayout()
        Me.ConsolePl.SuspendLayout()
        Me.ImagePl.SuspendLayout()
        Me.ControlFooterPl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.BackColor = System.Drawing.SystemColors.Control
        Me.MainTabControl.Controls.Add(Me.ConfigTab)
        Me.MainTabControl.Controls.Add(Me.ProgressTab)
        Me.MainTabControl.Controls.Add(Me.ResultsTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainTabControl.HotTrackTabColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainTabControl.ItemSize = New System.Drawing.Size(62, 12)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 56)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.Padding = New System.Drawing.Point(0, 0)
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.SelectedTabColor = System.Drawing.SystemColors.ButtonShadow
        Me.MainTabControl.Size = New System.Drawing.Size(558, 294)
        Me.MainTabControl.TabColor = System.Drawing.SystemColors.ControlLight
        Me.MainTabControl.TabIndex = 4
        Me.MainTabControl.Tag = "Select an Option..."
        '
        'ConfigTab
        '
        Me.ConfigTab.BackColor = System.Drawing.SystemColors.Control
        Me.ConfigTab.Controls.Add(Me.RemoveRuleBn)
        Me.ConfigTab.Controls.Add(Me.AddRuleBn)
        Me.ConfigTab.Controls.Add(Me.TypeLb)
        Me.ConfigTab.Controls.Add(Me.ConfigFlow)
        Me.ConfigTab.Controls.Add(Me.TypeCombo)
        Me.ConfigTab.Location = New System.Drawing.Point(0, 15)
        Me.ConfigTab.Name = "ConfigTab"
        Me.ConfigTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ConfigTab.Size = New System.Drawing.Size(558, 279)
        Me.ConfigTab.TabIndex = 2
        Me.ConfigTab.Text = "OptionsTab"
        '
        'RemoveRuleBn
        '
        Me.RemoveRuleBn.Enabled = False
        Me.RemoveRuleBn.Location = New System.Drawing.Point(94, 22)
        Me.RemoveRuleBn.Name = "RemoveRuleBn"
        Me.RemoveRuleBn.Size = New System.Drawing.Size(75, 23)
        Me.RemoveRuleBn.TabIndex = 4
        Me.RemoveRuleBn.Text = "Remove Rule"
        Me.RemoveRuleBn.UseVisualStyleBackColor = True
        '
        'AddRuleBn
        '
        Me.AddRuleBn.Location = New System.Drawing.Point(13, 22)
        Me.AddRuleBn.Name = "AddRuleBn"
        Me.AddRuleBn.Size = New System.Drawing.Size(75, 23)
        Me.AddRuleBn.TabIndex = 3
        Me.AddRuleBn.Text = "Add Rule"
        Me.AddRuleBn.UseVisualStyleBackColor = True
        '
        'TypeLb
        '
        Me.TypeLb.AutoSize = True
        Me.TypeLb.Location = New System.Drawing.Point(302, 25)
        Me.TypeLb.Name = "TypeLb"
        Me.TypeLb.Size = New System.Drawing.Size(77, 13)
        Me.TypeLb.TabIndex = 2
        Me.TypeLb.Text = "Type to Query:"
        '
        'ConfigFlow
        '
        Me.ConfigFlow.BackColor = System.Drawing.SystemColors.Window
        Me.ConfigFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConfigFlow.Location = New System.Drawing.Point(12, 55)
        Me.ConfigFlow.Name = "ConfigFlow"
        Me.ConfigFlow.Size = New System.Drawing.Size(534, 224)
        Me.ConfigFlow.TabIndex = 1
        '
        'TypeCombo
        '
        Me.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeCombo.FormattingEnabled = True
        Me.TypeCombo.Items.AddRange(New Object() {"Users", "Groups", "Computers", "Contacts"})
        Me.TypeCombo.Location = New System.Drawing.Point(385, 22)
        Me.TypeCombo.Name = "TypeCombo"
        Me.TypeCombo.Size = New System.Drawing.Size(161, 21)
        Me.TypeCombo.TabIndex = 0
        '
        'ProgressTab
        '
        Me.ProgressTab.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressTab.Controls.Add(Me.ConsolePl)
        Me.ProgressTab.Controls.Add(Me.MainProgressLb)
        Me.ProgressTab.Controls.Add(Me.MainProgresBar)
        Me.ProgressTab.Location = New System.Drawing.Point(0, 15)
        Me.ProgressTab.Name = "ProgressTab"
        Me.ProgressTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProgressTab.Size = New System.Drawing.Size(558, 279)
        Me.ProgressTab.TabIndex = 3
        Me.ProgressTab.Text = "ProgressTab"
        '
        'ConsolePl
        '
        Me.ConsolePl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConsolePl.Controls.Add(Me.ConsoleTb)
        Me.ConsolePl.Location = New System.Drawing.Point(12, 14)
        Me.ConsolePl.Name = "ConsolePl"
        Me.ConsolePl.Size = New System.Drawing.Size(534, 218)
        Me.ConsolePl.TabIndex = 3
        '
        'ConsoleTb
        '
        Me.ConsoleTb.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ConsoleTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConsoleTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsoleTb.Location = New System.Drawing.Point(0, 0)
        Me.ConsoleTb.Name = "ConsoleTb"
        Me.ConsoleTb.Size = New System.Drawing.Size(532, 216)
        Me.ConsoleTb.TabIndex = 0
        Me.ConsoleTb.Text = ""
        '
        'MainProgressLb
        '
        Me.MainProgressLb.AutoSize = True
        Me.MainProgressLb.Location = New System.Drawing.Point(12, 300)
        Me.MainProgressLb.Name = "MainProgressLb"
        Me.MainProgressLb.Size = New System.Drawing.Size(56, 13)
        Me.MainProgressLb.TabIndex = 2
        Me.MainProgressLb.Text = "Working..."
        '
        'MainProgresBar
        '
        Me.MainProgresBar.Location = New System.Drawing.Point(12, 238)
        Me.MainProgresBar.Name = "MainProgresBar"
        Me.MainProgresBar.Size = New System.Drawing.Size(533, 23)
        Me.MainProgresBar.TabIndex = 0
        '
        'ResultsTab
        '
        Me.ResultsTab.BackColor = System.Drawing.SystemColors.Control
        Me.ResultsTab.Location = New System.Drawing.Point(0, 15)
        Me.ResultsTab.Name = "ResultsTab"
        Me.ResultsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ResultsTab.Size = New System.Drawing.Size(558, 279)
        Me.ResultsTab.TabIndex = 4
        Me.ResultsTab.Text = "Results Tab"
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
        Me.ImagePl.Size = New System.Drawing.Size(558, 56)
        Me.ImagePl.TabIndex = 22
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(122, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Define Rules"
        '
        'ControlFooterPl
        '
        Me.ControlFooterPl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ControlFooterPl.Controls.Add(Me.BackBn)
        Me.ControlFooterPl.Controls.Add(Me.AcceptBn)
        Me.ControlFooterPl.Controls.Add(Me.CancelBn)
        Me.ControlFooterPl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlFooterPl.Location = New System.Drawing.Point(0, 350)
        Me.ControlFooterPl.MaximumSize = New System.Drawing.Size(0, 44)
        Me.ControlFooterPl.MinimumSize = New System.Drawing.Size(0, 44)
        Me.ControlFooterPl.Name = "ControlFooterPl"
        Me.ControlFooterPl.Size = New System.Drawing.Size(558, 44)
        Me.ControlFooterPl.TabIndex = 23
        '
        'BackBn
        '
        Me.BackBn.Location = New System.Drawing.Point(309, 9)
        Me.BackBn.Name = "BackBn"
        Me.BackBn.Size = New System.Drawing.Size(75, 23)
        Me.BackBn.TabIndex = 2
        Me.BackBn.Text = "Previous"
        Me.BackBn.UseVisualStyleBackColor = True
        Me.BackBn.Visible = False
        '
        'AcceptBn
        '
        Me.AcceptBn.Location = New System.Drawing.Point(390, 9)
        Me.AcceptBn.Name = "AcceptBn"
        Me.AcceptBn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBn.TabIndex = 1
        Me.AcceptBn.Text = "Next"
        Me.AcceptBn.UseVisualStyleBackColor = True
        Me.AcceptBn.Visible = False
        '
        'CancelBn
        '
        Me.CancelBn.Location = New System.Drawing.Point(471, 9)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 0
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(558, 394)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.ControlFooterPl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReport"
        Me.Text = "Report Designer"
        Me.MainTabControl.ResumeLayout(False)
        Me.ConfigTab.ResumeLayout(False)
        Me.ConfigTab.PerformLayout()
        Me.ProgressTab.ResumeLayout(False)
        Me.ProgressTab.PerformLayout()
        Me.ConsolePl.ResumeLayout(False)
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ControlFooterPl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As CustomTabControlNoHeaders
    Friend WithEvents ConfigTab As TabPage
    Friend WithEvents ProgressTab As TabPage
    Friend WithEvents ConsolePl As Panel
    Friend WithEvents ConsoleTb As RichTextBox
    Friend WithEvents MainProgressLb As Label
    Friend WithEvents MainProgresBar As ProgressBar
    Friend WithEvents ResultsTab As TabPage
    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Label
    Friend WithEvents ControlFooterPl As Panel
    Friend WithEvents BackBn As Button
    Friend WithEvents AcceptBn As Button
    Friend WithEvents CancelBn As Button
    Friend WithEvents TypeLb As Label
    Friend WithEvents ConfigFlow As FlowLayoutPanel
    Friend WithEvents TypeCombo As ComboBox
    Friend WithEvents RemoveRuleBn As Button
    Friend WithEvents AddRuleBn As Button
End Class
