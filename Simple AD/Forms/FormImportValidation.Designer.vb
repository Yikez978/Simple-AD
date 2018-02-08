Imports System.Windows.Forms
Imports BrightIdeasSoftware
Imports SimpleLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormImportValidation
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImportValidation))
        Me.ImportBtn = New System.Windows.Forms.Button()
        Me.IgnoreBn = New System.Windows.Forms.Button()
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.MainPb = New System.Windows.Forms.PictureBox()
        Me.TitleLb = New System.Windows.Forms.Label()
        Me.ErrorListView = New SimpleAD.ControlCustomListView()
        Me.ErrorNameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ErrorMessageCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImagePl.SuspendLayout()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportBtn
        '
        Me.ImportBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportBtn.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.ImportBtn.Location = New System.Drawing.Point(266, 248)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(147, 23)
        Me.ImportBtn.TabIndex = 3
        Me.ImportBtn.Text = "Import a Different File..."
        Me.ImportBtn.UseVisualStyleBackColor = True
        '
        'IgnoreBn
        '
        Me.IgnoreBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IgnoreBn.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.IgnoreBn.Location = New System.Drawing.Point(419, 248)
        Me.IgnoreBn.Name = "IgnoreBn"
        Me.IgnoreBn.Size = New System.Drawing.Size(75, 23)
        Me.IgnoreBn.TabIndex = 8
        Me.IgnoreBn.Text = "Ignore"
        Me.IgnoreBn.UseVisualStyleBackColor = True
        '
        'ImagePl
        '
        Me.ImagePl.BackColor = System.Drawing.SystemColors.Window
        Me.ImagePl.Controls.Add(Me.MainPb)
        Me.ImagePl.Controls.Add(Me.TitleLb)
        Me.ImagePl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePl.Location = New System.Drawing.Point(0, 0)
        Me.ImagePl.MaximumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.MinimumSize = New System.Drawing.Size(0, 56)
        Me.ImagePl.Name = "ImagePl"
        Me.ImagePl.Size = New System.Drawing.Size(506, 56)
        Me.ImagePl.TabIndex = 32
        '
        'MainPb
        '
        Me.MainPb.Location = New System.Drawing.Point(12, 12)
        Me.MainPb.Name = "MainPb"
        Me.MainPb.Size = New System.Drawing.Size(32, 32)
        Me.MainPb.TabIndex = 10
        Me.MainPb.TabStop = False
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(50, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(130, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Import Errors"
        '
        'ErrorListView
        '
        Me.ErrorListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ErrorListView.AllColumns.Add(Me.ErrorNameCol)
        Me.ErrorListView.AllColumns.Add(Me.ErrorMessageCol)
        Me.ErrorListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorListView.CellEditUseWholeCell = False
        Me.ErrorListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ErrorNameCol, Me.ErrorMessageCol})
        Me.ErrorListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ErrorListView.EmptyListMsgFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorListView.FullRowSelect = True
        Me.ErrorListView.HeaderUsesThemes = True
        Me.ErrorListView.HideSelection = False
        Me.ErrorListView.IncludeColumnHeadersInCopy = True
        Me.ErrorListView.Location = New System.Drawing.Point(13, 65)
        Me.ErrorListView.Name = "ErrorListView"
        Me.ErrorListView.OwnerDraw = False
        Me.ErrorListView.RowHeight = 21
        Me.ErrorListView.ShowGroups = False
        Me.ErrorListView.Size = New System.Drawing.Size(481, 177)
        Me.ErrorListView.TabIndex = 7
        Me.ErrorListView.UseCompatibleStateImageBehavior = False
        Me.ErrorListView.UseExplorerTheme = True
        Me.ErrorListView.UseFiltering = True
        Me.ErrorListView.UseHotControls = False
        Me.ErrorListView.UseNotifyPropertyChanged = True
        Me.ErrorListView.View = System.Windows.Forms.View.Details
        '
        'ErrorNameCol
        '
        Me.ErrorNameCol.AspectName = "ErrorName"
        Me.ErrorNameCol.Text = "Error"
        Me.ErrorNameCol.Width = 195
        '
        'ErrorMessageCol
        '
        Me.ErrorMessageCol.AspectName = "ErrorMessage"
        Me.ErrorMessageCol.FillsFreeSpace = True
        Me.ErrorMessageCol.Text = "Details"
        '
        'FormImportValidation
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 283)
        Me.Controls.Add(Me.ImagePl)
        Me.Controls.Add(Me.IgnoreBn)
        Me.Controls.Add(Me.ErrorListView)
        Me.Controls.Add(Me.ImportBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormImportValidation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Validation"
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        CType(Me.MainPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImportBtn As System.Windows.Forms.Button
    Friend WithEvents ErrorListView As ControlCustomListView
    Friend WithEvents ErrorNameCol As OLVColumn
    Friend WithEvents ErrorMessageCol As OLVColumn
    Friend WithEvents IgnoreBn As Button
    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Label
    Friend WithEvents MainPb As PictureBox
End Class
