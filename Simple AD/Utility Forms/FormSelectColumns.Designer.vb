﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectColumns))
        Me.CnBt = New MetroFramework.Controls.MetroButton()
        Me.AcBt = New MetroFramework.Controls.MetroButton()
        Me.AvailableColumnsLb = New System.Windows.Forms.ListBox()
        Me.CurrentColumnsLb = New System.Windows.Forms.ListBox()
        Me.AddBn = New MetroFramework.Controls.MetroButton()
        Me.AddAllBn = New MetroFramework.Controls.MetroButton()
        Me.RmvBn = New MetroFramework.Controls.MetroButton()
        Me.RmvAllBn = New MetroFramework.Controls.MetroButton()
        Me.AvailableColumnsLabel = New MetroFramework.Controls.MetroLabel()
        Me.LoadedColumnsLabel = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'CnBt
        '
        Me.CnBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CnBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CnBt.Location = New System.Drawing.Point(563, 387)
        Me.CnBt.Name = "CnBt"
        Me.CnBt.Size = New System.Drawing.Size(75, 23)
        Me.CnBt.TabIndex = 1
        Me.CnBt.Text = "Cancel"
        Me.CnBt.UseSelectable = True
        '
        'AcBt
        '
        Me.AcBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcBt.Location = New System.Drawing.Point(482, 387)
        Me.AcBt.Name = "AcBt"
        Me.AcBt.Size = New System.Drawing.Size(75, 23)
        Me.AcBt.TabIndex = 2
        Me.AcBt.Text = "Accept"
        Me.AcBt.UseSelectable = True
        '
        'AvailableColumnsLb
        '
        Me.AvailableColumnsLb.BackColor = System.Drawing.SystemColors.Window
        Me.AvailableColumnsLb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableColumnsLb.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableColumnsLb.ItemHeight = 17
        Me.AvailableColumnsLb.Location = New System.Drawing.Point(23, 102)
        Me.AvailableColumnsLb.Name = "AvailableColumnsLb"
        Me.AvailableColumnsLb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.AvailableColumnsLb.Size = New System.Drawing.Size(262, 255)
        Me.AvailableColumnsLb.Sorted = True
        Me.AvailableColumnsLb.TabIndex = 3
        '
        'CurrentColumnsLb
        '
        Me.CurrentColumnsLb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentColumnsLb.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentColumnsLb.ItemHeight = 17
        Me.CurrentColumnsLb.Location = New System.Drawing.Point(372, 102)
        Me.CurrentColumnsLb.Name = "CurrentColumnsLb"
        Me.CurrentColumnsLb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.CurrentColumnsLb.Size = New System.Drawing.Size(266, 255)
        Me.CurrentColumnsLb.Sorted = True
        Me.CurrentColumnsLb.TabIndex = 4
        '
        'AddBn
        '
        Me.AddBn.Location = New System.Drawing.Point(291, 105)
        Me.AddBn.Name = "AddBn"
        Me.AddBn.Size = New System.Drawing.Size(75, 23)
        Me.AddBn.TabIndex = 5
        Me.AddBn.Text = "&Add"
        Me.AddBn.UseSelectable = True
        '
        'AddAllBn
        '
        Me.AddAllBn.Location = New System.Drawing.Point(291, 134)
        Me.AddAllBn.Name = "AddAllBn"
        Me.AddAllBn.Size = New System.Drawing.Size(75, 23)
        Me.AddAllBn.TabIndex = 6
        Me.AddAllBn.Text = "A&dd All"
        Me.AddAllBn.UseSelectable = True
        '
        'RmvBn
        '
        Me.RmvBn.Location = New System.Drawing.Point(291, 177)
        Me.RmvBn.Name = "RmvBn"
        Me.RmvBn.Size = New System.Drawing.Size(75, 23)
        Me.RmvBn.TabIndex = 7
        Me.RmvBn.Text = "&Remove"
        Me.RmvBn.UseSelectable = True
        '
        'RmvAllBn
        '
        Me.RmvAllBn.Location = New System.Drawing.Point(291, 206)
        Me.RmvAllBn.Name = "RmvAllBn"
        Me.RmvAllBn.Size = New System.Drawing.Size(75, 23)
        Me.RmvAllBn.TabIndex = 8
        Me.RmvAllBn.Text = "R&emove All"
        Me.RmvAllBn.UseSelectable = True
        '
        'AvailableColumnsLabel
        '
        Me.AvailableColumnsLabel.AutoSize = True
        Me.AvailableColumnsLabel.Location = New System.Drawing.Point(23, 80)
        Me.AvailableColumnsLabel.Name = "AvailableColumnsLabel"
        Me.AvailableColumnsLabel.Size = New System.Drawing.Size(117, 19)
        Me.AvailableColumnsLabel.TabIndex = 9
        Me.AvailableColumnsLabel.Text = "Available Columns"
        '
        'LoadedColumnsLabel
        '
        Me.LoadedColumnsLabel.AutoSize = True
        Me.LoadedColumnsLabel.Location = New System.Drawing.Point(372, 80)
        Me.LoadedColumnsLabel.Name = "LoadedColumnsLabel"
        Me.LoadedColumnsLabel.Size = New System.Drawing.Size(108, 19)
        Me.LoadedColumnsLabel.TabIndex = 10
        Me.LoadedColumnsLabel.Text = "Loaded Columns"
        '
        'SelectColumns
        '
        Me.AcceptButton = Me.AcBt
        Me.CancelButton = Me.CnBt
        Me.ClientSize = New System.Drawing.Size(661, 433)
        Me.Controls.Add(Me.LoadedColumnsLabel)
        Me.Controls.Add(Me.AvailableColumnsLabel)
        Me.Controls.Add(Me.RmvAllBn)
        Me.Controls.Add(Me.RmvBn)
        Me.Controls.Add(Me.AddAllBn)
        Me.Controls.Add(Me.AddBn)
        Me.Controls.Add(Me.CurrentColumnsLb)
        Me.Controls.Add(Me.AvailableColumnsLb)
        Me.Controls.Add(Me.AcBt)
        Me.Controls.Add(Me.CnBt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectColumns"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Select Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvailableColumnsLb As ListBox
    Friend WithEvents CurrentColumnsLb As ListBox
    Friend WithEvents CnBt As MetroFramework.Controls.MetroButton
    Friend WithEvents AcBt As MetroFramework.Controls.MetroButton
    Friend WithEvents AddBn As MetroFramework.Controls.MetroButton
    Friend WithEvents AddAllBn As MetroFramework.Controls.MetroButton
    Friend WithEvents RmvBn As MetroFramework.Controls.MetroButton
    Friend WithEvents RmvAllBn As MetroFramework.Controls.MetroButton
    Friend WithEvents AvailableColumnsLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadedColumnsLabel As MetroFramework.Controls.MetroLabel
End Class