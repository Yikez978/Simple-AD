Imports System
Imports BrightIdeasSoftware

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPing))
        Me.CancelBn = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SendBn = New System.Windows.Forms.Button()
        Me.CountBox = New System.Windows.Forms.ComboBox()
        Me.CountLb = New System.Windows.Forms.Label()
        Me.IntervalLb = New System.Windows.Forms.Label()
        Me.IntervalBox = New System.Windows.Forms.ComboBox()
        Me.MainListView = New SimpleAD.ControlCustomListView()
        Me.TypeCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MessageCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.AddressCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.RTTCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TTLCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.BufferCol = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImagePl = New SimpleAD.ControlHeaderPanel()
        Me.TitleLb = New System.Windows.Forms.Label()
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImagePl.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelBn
        '
        Me.CancelBn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBn.Location = New System.Drawing.Point(478, 342)
        Me.CancelBn.Name = "CancelBn"
        Me.CancelBn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBn.TabIndex = 10
        Me.CancelBn.Text = "Close"
        Me.CancelBn.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Enabled = False
        Me.ProgressBar.Location = New System.Drawing.Point(29, 305)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(507, 23)
        Me.ProgressBar.TabIndex = 12
        '
        'SendBn
        '
        Me.SendBn.Location = New System.Drawing.Point(29, 342)
        Me.SendBn.Name = "SendBn"
        Me.SendBn.Size = New System.Drawing.Size(75, 23)
        Me.SendBn.TabIndex = 14
        Me.SendBn.Text = "Send Ping"
        Me.SendBn.UseVisualStyleBackColor = True
        '
        'CountBox
        '
        Me.CountBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountBox.FormattingEnabled = True
        Me.CountBox.ItemHeight = 13
        Me.CountBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "8", "Continuous"})
        Me.CountBox.Location = New System.Drawing.Point(163, 342)
        Me.CountBox.Name = "CountBox"
        Me.CountBox.Size = New System.Drawing.Size(90, 21)
        Me.CountBox.TabIndex = 15
        '
        'CountLb
        '
        Me.CountLb.AutoSize = True
        Me.CountLb.Location = New System.Drawing.Point(119, 345)
        Me.CountLb.Name = "CountLb"
        Me.CountLb.Size = New System.Drawing.Size(38, 13)
        Me.CountLb.TabIndex = 16
        Me.CountLb.Text = "Count:"
        '
        'IntervalLb
        '
        Me.IntervalLb.AutoSize = True
        Me.IntervalLb.Location = New System.Drawing.Point(288, 345)
        Me.IntervalLb.Name = "IntervalLb"
        Me.IntervalLb.Size = New System.Drawing.Size(45, 13)
        Me.IntervalLb.TabIndex = 18
        Me.IntervalLb.Text = "Interval:"
        '
        'IntervalBox
        '
        Me.IntervalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IntervalBox.FormattingEnabled = True
        Me.IntervalBox.ItemHeight = 13
        Me.IntervalBox.Items.AddRange(New Object() {"0.25 seconds", "0.5 seconds", "1 seconds", "2 seconds", "3 seconds", "4 seconds"})
        Me.IntervalBox.Location = New System.Drawing.Point(339, 342)
        Me.IntervalBox.Name = "IntervalBox"
        Me.IntervalBox.Size = New System.Drawing.Size(90, 21)
        Me.IntervalBox.TabIndex = 17
        '
        'MainListView
        '
        Me.MainListView.AllColumns.Add(Me.TypeCol)
        Me.MainListView.AllColumns.Add(Me.MessageCol)
        Me.MainListView.AllColumns.Add(Me.AddressCol)
        Me.MainListView.AllColumns.Add(Me.RTTCol)
        Me.MainListView.AllColumns.Add(Me.TTLCol)
        Me.MainListView.AllColumns.Add(Me.BufferCol)
        Me.MainListView.CellEditUseWholeCell = False
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TypeCol, Me.MessageCol, Me.AddressCol, Me.RTTCol, Me.TTLCol, Me.BufferCol})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Location = New System.Drawing.Point(29, 72)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.ShowGroups = False
        Me.MainListView.ShowHeaderInAllViews = False
        Me.MainListView.Size = New System.Drawing.Size(507, 227)
        Me.MainListView.TabIndex = 13
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'TypeCol
        '
        Me.TypeCol.AspectName = "Type"
        Me.TypeCol.Text = "Type"
        Me.TypeCol.Width = 39
        '
        'MessageCol
        '
        Me.MessageCol.AspectName = "Message"
        Me.MessageCol.Text = "Message"
        Me.MessageCol.Width = 122
        '
        'AddressCol
        '
        Me.AddressCol.AspectName = "Address"
        Me.AddressCol.Text = "Address"
        Me.AddressCol.Width = 121
        '
        'RTTCol
        '
        Me.RTTCol.AspectName = "RoundTripTime"
        Me.RTTCol.Text = "RTT"
        Me.RTTCol.Width = 55
        '
        'TTLCol
        '
        Me.TTLCol.AspectName = "TimeToLive"
        Me.TTLCol.Text = "TTL"
        Me.TTLCol.Width = 53
        '
        'BufferCol
        '
        Me.BufferCol.AspectName = "BufferSize"
        Me.BufferCol.Text = "Buffer Size"
        Me.BufferCol.Width = 77
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
        Me.ImagePl.Size = New System.Drawing.Size(565, 56)
        Me.ImagePl.TabIndex = 9
        '
        'TitleLb
        '
        Me.TitleLb.AutoSize = True
        Me.TitleLb.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLb.Location = New System.Drawing.Point(24, 8)
        Me.TitleLb.Name = "TitleLb"
        Me.TitleLb.Size = New System.Drawing.Size(172, 30)
        Me.TitleLb.TabIndex = 9
        Me.TitleLb.Text = "Pinging Machine..."
        '
        'FormPing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 377)
        Me.Controls.Add(Me.IntervalLb)
        Me.Controls.Add(Me.IntervalBox)
        Me.Controls.Add(Me.CountLb)
        Me.Controls.Add(Me.CountBox)
        Me.Controls.Add(Me.SendBn)
        Me.Controls.Add(Me.MainListView)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.CancelBn)
        Me.Controls.Add(Me.ImagePl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ping"
        CType(Me.MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImagePl.ResumeLayout(False)
        Me.ImagePl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagePl As ControlHeaderPanel
    Friend WithEvents TitleLb As Windows.Forms.Label
    Friend WithEvents CancelBn As Windows.Forms.Button
    Friend WithEvents ProgressBar As Windows.Forms.ProgressBar
    Friend WithEvents MainListView As SimpleAD.ControlCustomListView
    Friend WithEvents TypeCol As OLVColumn
    Friend WithEvents MessageCol As OLVColumn
    Friend WithEvents AddressCol As OLVColumn
    Friend WithEvents RTTCol As OLVColumn
    Friend WithEvents TTLCol As OLVColumn
    Friend WithEvents BufferCol As OLVColumn
    Friend WithEvents SendBn As Windows.Forms.Button
    Friend WithEvents CountBox As Windows.Forms.ComboBox
    Friend WithEvents CountLb As Windows.Forms.Label
    Friend WithEvents IntervalLb As Windows.Forms.Label
    Friend WithEvents IntervalBox As Windows.Forms.ComboBox
End Class
