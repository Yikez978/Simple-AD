Imports System.Runtime.InteropServices

Public Class ControlListView
    Inherits ObjectListView

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub

    Public Sub New()
        Me.Font = SystemFonts.DefaultFont
        Me.UseNotifyPropertyChanged = True
        Me.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CellEditUseWholeCell = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmptyListMsg = "No Results"
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullRowSelect = True
        Me.HeaderUsesThemes = True
        Me.HideSelection = False
        Me.IncludeColumnHeadersInCopy = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.RowHeight = 21
        Me.ShowGroups = False
        Me.Size = New System.Drawing.Size(402, 271)
        Me.TabIndex = 1
        Me.UseCompatibleStateImageBehavior = False
        Me.UseExplorerTheme = True
        Me.UseFiltering = True
        Me.View = System.Windows.Forms.View.Details
    End Sub

End Class
