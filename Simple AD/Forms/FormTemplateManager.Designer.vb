<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTemplateManager
    Inherits System.Windows.Forms.Form

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
        Me.MainListView = New SimpleAD.ControlListView()
        Me.NameCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DescCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Authcol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.RightClickItemMenu = New System.Windows.Forms.ContextMenu()
        Me.DeleteTemplateMenuItem = New System.Windows.Forms.MenuItem()
        Me.TemplatePropertiesMenuItem = New System.Windows.Forms.MenuItem()
        Me.RightClickMenu = New System.Windows.Forms.ContextMenu()
        Me.AddMenuItem = New System.Windows.Forms.MenuItem()
        Me.RefreshMenuItem = New System.Windows.Forms.MenuItem()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainListView
        '
        Me.MainListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.MainListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.MainListView.AllColumns.Add(Me.NameCol)
        Me.MainListView.AllColumns.Add(Me.DescCol)
        Me.MainListView.AllColumns.Add(Me.Authcol)
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameCol, Me.DescCol, Me.Authcol})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.EmptyListMsg = "No Results"
        Me.MainListView.EmptyListMsgFont = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainListView.FullRowSelect = True
        Me.MainListView.HeaderUsesThemes = True
        Me.MainListView.HideSelection = False
        Me.MainListView.IncludeColumnHeadersInCopy = True
        Me.MainListView.Location = New System.Drawing.Point(0, 0)
        Me.MainListView.Margin = New System.Windows.Forms.Padding(0)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.OwnerDraw = False
        Me.MainListView.RowHeight = 32
        Me.MainListView.ShowGroups = False
        Me.MainListView.ShowHeaderInAllViews = False
        Me.MainListView.ShowItemCountOnGroups = True
        Me.MainListView.Size = New System.Drawing.Size(762, 339)
        Me.MainListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.MainListView.TabIndex = 14
        Me.MainListView.TileSize = New System.Drawing.Size(256, 64)
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.UseExplorerTheme = True
        Me.MainListView.UseFiltering = True
        Me.MainListView.UseHotControls = False
        Me.MainListView.UseNotifyPropertyChanged = True
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'NameCol
        '
        Me.NameCol.AspectName = "Name"
        Me.NameCol.Text = "Name"
        Me.NameCol.Width = 263
        '
        'DescCol
        '
        Me.DescCol.AspectName = "Description"
        Me.DescCol.Text = "Description"
        Me.DescCol.Width = 254
        '
        'Authcol
        '
        Me.Authcol.AspectName = "Author"
        Me.Authcol.Text = "Author"
        Me.Authcol.Width = 188
        '
        'RightClickItemMenu
        '
        Me.RightClickItemMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DeleteTemplateMenuItem, Me.TemplatePropertiesMenuItem})
        '
        'DeleteTemplateMenuItem
        '
        Me.DeleteTemplateMenuItem.Index = 0
        Me.DeleteTemplateMenuItem.Text = "Delete Template"
        '
        'TemplatePropertiesMenuItem
        '
        Me.TemplatePropertiesMenuItem.Index = 1
        Me.TemplatePropertiesMenuItem.Text = "Properties"
        '
        'RightClickMenu
        '
        Me.RightClickMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddMenuItem, Me.RefreshMenuItem})
        '
        'AddMenuItem
        '
        Me.AddMenuItem.Index = 0
        Me.AddMenuItem.Text = "Add New Template"
        '
        'RefreshMenuItem
        '
        Me.RefreshMenuItem.Index = 1
        Me.RefreshMenuItem.Text = "Refresh"
        '
        'FormTemplateManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 339)
        Me.Controls.Add(Me.MainListView)
        Me.Name = "FormTemplateManager"
        Me.Text = "FormTemplateManager"
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainListView As ControlListView
    Friend WithEvents NameCol As OLVColumn
    Friend WithEvents DescCol As OLVColumn
    Friend WithEvents Authcol As OLVColumn
    Friend WithEvents RightClickItemMenu As ContextMenu
    Friend WithEvents DeleteTemplateMenuItem As MenuItem
    Friend WithEvents TemplatePropertiesMenuItem As MenuItem
    Friend WithEvents RightClickMenu As ContextMenu
    Friend WithEvents AddMenuItem As MenuItem
    Friend WithEvents RefreshMenuItem As MenuItem
End Class
