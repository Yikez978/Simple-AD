<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DemoForm
    Inherits SimpleAD.FormSimpleAD

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoForm))
        Me.ImportCSV = New System.Windows.Forms.RibbonButton()
        Me.Office365Tab = New System.Windows.Forms.RibbonTab()
        Me.ActiveDirectoryTab = New System.Windows.Forms.RibbonTab()
        Me.ReportsTab = New System.Windows.Forms.RibbonTab()
        Me.ToolsTab = New System.Windows.Forms.RibbonTab()
        Me.ViewTab = New System.Windows.Forms.RibbonTab()
        Me.SuspendLayout()
        '
        'ImportCSV
        '
        Me.ImportCSV.Image = CType(resources.GetObject("ImportCSV.Image"), System.Drawing.Image)
        Me.ImportCSV.SmallImage = CType(resources.GetObject("ImportCSV.SmallImage"), System.Drawing.Image)
        Me.ImportCSV.Text = "Import CSV"
        '
        'Office365Tab
        '
        Me.Office365Tab.Text = "Office 365"
        '
        'ActiveDirectoryTab
        '
        Me.ActiveDirectoryTab.Text = "Active Directory"
        '
        'ReportsTab
        '
        Me.ReportsTab.Text = "Reports"
        '
        'ToolsTab
        '
        Me.ToolsTab.Text = "Tools"
        '
        'ViewTab
        '
        Me.ViewTab.Text = "View"
        '
        'DemoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 330)
        Me.CustomBackcolor = System.Drawing.SystemColors.Window
        Me.CustomForecolor = System.Drawing.SystemColors.MenuText
        Me.DisplayHeader = False
        Me.Name = "DemoForm"
        Me.Padding = New System.Windows.Forms.Padding(1, 30, 1, 1)
        Me.Text = "RibbonForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Office365Tab As RibbonTab
    Friend WithEvents ImportCSV As RibbonButton
    Friend WithEvents ActiveDirectoryTab As RibbonTab
    Friend WithEvents ReportsTab As RibbonTab
    Friend WithEvents ToolsTab As RibbonTab
    Friend WithEvents ViewTab As RibbonTab
End Class
