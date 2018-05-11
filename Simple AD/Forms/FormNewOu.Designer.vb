Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewOu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewOu))
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.NameTb = New SimpleAD.ControlTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContainerLb = New System.Windows.Forms.Label()
        Me.OkBn = New System.Windows.Forms.Button()
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(12, 65)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(64, 64)
        Me.MainPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MainPb.TabIndex = 5
        Me.MainPb.TabStop = False
        Me.MainPb.WaitOnLoad = True
        '
        'NameTb
        '
        Me.NameTb.Location = New System.Drawing.Point(90, 91)
        Me.NameTb.Name = "NameTb"
        Me.NameTb.PromptText = "Enter Name"
        Me.NameTb.Size = New System.Drawing.Size(281, 23)
        Me.NameTb.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Create organizational unit in"
        '
        'ContainerLb
        '
        Me.ContainerLb.AutoSize = True
        Me.ContainerLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerLb.Location = New System.Drawing.Point(222, 73)
        Me.ContainerLb.Name = "ContainerLb"
        Me.ContainerLb.Size = New System.Drawing.Size(61, 13)
        Me.ContainerLb.TabIndex = 24
        Me.ContainerLb.Text = "Container"
        '
        'OkBn
        '
        Me.OkBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OkBn.Enabled = False
        Me.OkBn.Location = New System.Drawing.Point(235, 125)
        Me.OkBn.Name = "OkBn"
        Me.OkBn.Size = New System.Drawing.Size(75, 23)
        Me.OkBn.TabIndex = 2
        Me.OkBn.Text = "Accept"
        Me.OkBn.UseVisualStyleBackColor = True
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(316, 125)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 3
        Me.CancelBn.Text = "Cancel"
        Me.CancelBn.UseVisualStyleBackColor = True
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
        Me.ImagePl.Size = New System.Drawing.Size(403, 56)
        Me.ImagePl.TabIndex = 25
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(203, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Name New Container"
        '
        'FormNewOu
        '
        Me.AcceptButton = Me.OkBn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelBn
        Me.ClientSize = New System.Drawing.Size(403, 160)
        Me.Controls.Add(Me.OkBn)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.ContainerLb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTb)
        Me.Controls.Add(Me.MainPb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNewOu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Organizational Unit"
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainPb As Windows.Forms.PictureBox
    Friend WithEvents NameTb As SimpleAD.ControlTextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ContainerLb As Windows.Forms.Label
    Friend WithEvents OkBn As System.Windows.Forms.Button
    Friend WithEvents CancelBn As System.Windows.Forms.Button
    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Windows.Forms.Label
End Class
