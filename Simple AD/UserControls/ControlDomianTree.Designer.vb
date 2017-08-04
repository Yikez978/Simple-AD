<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlDomianTree
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel = New MetroFramework.Controls.MetroPanel()
        Me.OUTreeView = New Simple_AD.NativeTreeView()
        Me.Splitter = New System.Windows.Forms.Splitter()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.AutoSize = True
        Me.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel.BackColor = System.Drawing.SystemColors.Window
        Me.Panel.Controls.Add(Me.OUTreeView)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.HorizontalScrollbar = True
        Me.Panel.HorizontalScrollbarBarColor = True
        Me.Panel.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel.HorizontalScrollbarSize = 10
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(200, 400)
        Me.Panel.Style = MetroFramework.MetroColorStyle.Silver
        Me.Panel.TabIndex = 2
        Me.Panel.VerticalScrollbar = True
        Me.Panel.VerticalScrollbarBarColor = True
        Me.Panel.VerticalScrollbarHighlightOnWheel = False
        Me.Panel.VerticalScrollbarSize = 18
        '
        'OUTreeView
        '
        Me.OUTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OUTreeView.Location = New System.Drawing.Point(0, 0)
        Me.OUTreeView.Name = "OUTreeView"
        Me.OUTreeView.Size = New System.Drawing.Size(200, 400)
        Me.OUTreeView.TabIndex = 2
        '
        'Splitter
        '
        Me.Splitter.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter.Location = New System.Drawing.Point(199, 0)
        Me.Splitter.Name = "Splitter"
        Me.Splitter.Size = New System.Drawing.Size(1, 400)
        Me.Splitter.TabIndex = 1
        Me.Splitter.TabStop = False
        '
        'ControlDomianTree
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Splitter)
        Me.Controls.Add(Me.Panel)
        Me.Name = "ControlDomianTree"
        Me.Size = New System.Drawing.Size(200, 400)
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel As MetroFramework.Controls.MetroPanel
    Friend WithEvents Splitter As Splitter
    Friend WithEvents OUTreeView As NativeTreeView
End Class
