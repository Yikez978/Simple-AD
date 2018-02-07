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
        Me.HeaderLb = New System.Windows.Forms.Label()
        Me.ImportBtn = New System.Windows.Forms.Button()
        Me.SplitterBottom = New System.Windows.Forms.Splitter()
        Me.SplitterTop = New System.Windows.Forms.Splitter()
        Me.ErrorListView = New SimpleAD.ControlDomainListView()
        Me.ErrorNameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ErrorMessageCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CancelBn = New System.Windows.Forms.Button()
        CType(Me.ErrorListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderLb
        '
        Me.HeaderLb.AutoSize = True
        Me.HeaderLb.BackColor = System.Drawing.SystemColors.Window
        Me.HeaderLb.Location = New System.Drawing.Point(12, 9)
        Me.HeaderLb.Name = "HeaderLb"
        Me.HeaderLb.Size = New System.Drawing.Size(301, 13)
        Me.HeaderLb.TabIndex = 0
        Me.HeaderLb.Text = "Simple AD has detected the following Errors in the imported file"
        '
        'ImportBtn
        '
        Me.ImportBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportBtn.Location = New System.Drawing.Point(260, 231)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(147, 23)
        Me.ImportBtn.TabIndex = 3
        Me.ImportBtn.Text = "Import a Different File..."
        Me.ImportBtn.UseVisualStyleBackColor = True
        '
        'SplitterBottom
        '
        Me.SplitterBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SplitterBottom.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterBottom.Location = New System.Drawing.Point(0, 222)
        Me.SplitterBottom.Name = "SplitterBottom"
        Me.SplitterBottom.Size = New System.Drawing.Size(500, 44)
        Me.SplitterBottom.TabIndex = 5
        Me.SplitterBottom.TabStop = False
        '
        'SplitterTop
        '
        Me.SplitterTop.BackColor = System.Drawing.SystemColors.Window
        Me.SplitterTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitterTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterTop.Location = New System.Drawing.Point(0, 0)
        Me.SplitterTop.Name = "SplitterTop"
        Me.SplitterTop.Size = New System.Drawing.Size(500, 34)
        Me.SplitterTop.TabIndex = 6
        Me.SplitterTop.TabStop = False
        '
        'ErrorListView
        '
        Me.ErrorListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ErrorListView.AllColumns.Add(Me.ErrorNameCol)
        Me.ErrorListView.AllColumns.Add(Me.ErrorMessageCol)
        Me.ErrorListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ErrorListView.CellEditUseWholeCell = False
        Me.ErrorListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ErrorNameCol, Me.ErrorMessageCol})
        Me.ErrorListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ErrorListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorListView.EmptyListMsgFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorListView.FullRowSelect = True
        Me.ErrorListView.HeaderUsesThemes = True
        Me.ErrorListView.HideSelection = False
        Me.ErrorListView.IncludeColumnHeadersInCopy = True
        Me.ErrorListView.Location = New System.Drawing.Point(0, 34)
        Me.ErrorListView.Name = "ErrorListView"
        Me.ErrorListView.OwnerDraw = False
        Me.ErrorListView.RowHeight = 21
        Me.ErrorListView.ShowGroups = False
        Me.ErrorListView.Size = New System.Drawing.Size(500, 188)
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
        Me.ErrorNameCol.Width = 140
        '
        'ErrorMessageCol
        '
        Me.ErrorMessageCol.AspectName = "ErrorMessage"
        Me.ErrorMessageCol.FillsFreeSpace = True
        Me.ErrorMessageCol.Text = "Details"
        '
        'CancelBn
        '
        Me.CancelBn.Location = New System.Drawing.Point(413, 231)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 8
        Me.CancelBn.Text = "Ignore"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'FormImportValidation
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(500, 266)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.ErrorListView)
        Me.Controls.Add(Me.HeaderLb)
        Me.Controls.Add(Me.SplitterTop)
        Me.Controls.Add(Me.ImportBtn)
        Me.Controls.Add(Me.SplitterBottom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormImportValidation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Validation"
        CType(Me.ErrorListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderLb As Label
    Friend WithEvents SplitterBottom As Splitter
    Friend WithEvents SplitterTop As Splitter
    Friend WithEvents ImportBtn As System.Windows.Forms.Button
    Friend WithEvents ErrorListView As ControlDomainListView
    Friend WithEvents ErrorNameCol As OLVColumn
    Friend WithEvents ErrorMessageCol As OLVColumn
    Friend WithEvents CancelBn As Button
End Class
