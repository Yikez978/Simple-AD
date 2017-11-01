﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTaskCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.NameLb = New System.Windows.Forms.Label()
        Me.DescritptionLb = New System.Windows.Forms.Label()
        Me.MainProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.StatusLb = New System.Windows.Forms.Label()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLb
        '
        Me.NameLb.AutoEllipsis = True
        Me.NameLb.AutoSize = True
        Me.NameLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.NameLb.Location = New System.Drawing.Point(30, 9)
        Me.NameLb.Name = "NameLb"
        Me.NameLb.Size = New System.Drawing.Size(83, 15)
        Me.NameLb.TabIndex = 0
        Me.NameLb.Text = "Task Heading"
        Me.NameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescritptionLb
        '
        Me.DescritptionLb.AutoEllipsis = True
        Me.DescritptionLb.AutoSize = True
        Me.DescritptionLb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DescritptionLb.Location = New System.Drawing.Point(6, 30)
        Me.DescritptionLb.Margin = New System.Windows.Forms.Padding(3)
        Me.DescritptionLb.Name = "DescritptionLb"
        Me.DescritptionLb.Size = New System.Drawing.Size(186, 13)
        Me.DescritptionLb.TabIndex = 1
        Me.DescritptionLb.Text = "This is a short description of the Task."
        '
        'MainProgressBar
        '
        Me.MainProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainProgressBar.Location = New System.Drawing.Point(4, 56)
        Me.MainProgressBar.Margin = New System.Windows.Forms.Padding(6)
        Me.MainProgressBar.Name = "MainProgressBar"
        Me.MainProgressBar.Size = New System.Drawing.Size(191, 8)
        Me.MainProgressBar.Style = MetroFramework.MetroColorStyle.Purple
        Me.MainProgressBar.TabIndex = 2
        Me.MainProgressBar.Visible = False
        '
        'MainPb
        '
        Me.MainPb.Image = Global.SimpleAD.My.Resources.Resources.CheckTick
        Me.MainPb.Location = New System.Drawing.Point(8, 8)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(16, 16)
        Me.MainPb.TabIndex = 4
        Me.MainPb.TabStop = False
        '
        'StatusLb
        '
        Me.StatusLb.AutoSize = True
        Me.StatusLb.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusLb.Location = New System.Drawing.Point(7, 48)
        Me.StatusLb.Margin = New System.Windows.Forms.Padding(3)
        Me.StatusLb.Name = "StatusLb"
        Me.StatusLb.Size = New System.Drawing.Size(38, 13)
        Me.StatusLb.TabIndex = 5
        Me.StatusLb.Text = "Status"
        '
        'ControlTaskCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.StatusLb)
        Me.Controls.Add(Me.MainPb)
        Me.Controls.Add(Me.MainProgressBar)
        Me.Controls.Add(Me.DescritptionLb)
        Me.Controls.Add(Me.NameLb)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(0, 68)
        Me.MinimumSize = New System.Drawing.Size(0, 68)
        Me.Name = "ControlTaskCard"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(199, 68)
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLb As Label
    Friend WithEvents DescritptionLb As Label
    Friend WithEvents MainProgressBar As Controls.MetroProgressBar
    Friend WithEvents MainPb As PictureBox
    Friend WithEvents StatusLb As Label
End Class