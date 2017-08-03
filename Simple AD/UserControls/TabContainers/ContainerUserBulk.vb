Public Class ContainerUserBulk
    Inherits UserControl

    Public Properties As New ControlUserProperties
    Private DomainTree As New ControlDomianTree(Me)

    Private Worker As BulkADWorker

    Private _ID
    Private _JobName

    Public Property ID
        Set(value)
            _ID = value
        End Set
        Get
            Return _ID
        End Get
    End Property

    Public Property JobName
        Set(value)
            _JobName = value
        End Set
        Get
            Return _JobName
        End Get
    End Property

    Public Sub New(ByVal ID As Integer, ByVal JobName As String)

        Me.ID = ID
        Me.JobName = JobName

        Me.Dock = DockStyle.Fill

        InitializeComponent()

        MainDataGrid.DoubleBuffered(True)

        With Properties
            .BringToFront()
            .Dock = DockStyle.Fill
            .Visible = True
        End With

        With DomainTree
            .BringToFront()
            .Dock = DockStyle.Fill
            .Visible = True
        End With

        GetMainSplitContainer1.Panel2.Controls.Add(Properties)
        GetMainSplitContainer0.Panel1.Controls.Add(DomainTree)

    End Sub

    Public Function GetMainDataGrid() As DataGridView
        Return Me.MainDataGrid
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer0
    End Function

    Public Function GetMainSplitContainer1() As SplitContainer
        Return Me.MainSplitContainer1
    End Function

    Public Function GetPropertisPanel() As ControlUserProperties
        Return Me.Properties
    End Function

    Public Function GetProgressBar() As ProgressBar
        Return Me.ProgressBar
    End Function

    Public Function GetSpinner() As MetroFramework.Controls.MetroProgressSpinner
        Return Me.MetroProgressSpinner
    End Function

    Private Sub MainDataGrid_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles MainDataGrid.RowStateChanged
        PopulateSidePanel()

        FormMain.ToolStripStatusLabelContext.Text = GetMainDataGrid().SelectedRows.Count & " Object(s) Selected of " & GetMainDataGrid().Rows.Count
    End Sub

    Private Sub MainDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MainDataGrid.CellMouseClick
        ContextMenuHelper.GetDataGridViewConextMenu(MainDataGrid, e, CMStripRowRClick)
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBt.Click
        FormMain.GetMainDataGrid.ReadOnly = True
        FormMain.StatusStrip.BackColor = Color.Orange
        FormMain.ToolStripStatusLabelStatus.Text = "Processing Users..."
        FormMain.ToolStripStatusLabelContext.Text = ""
        Me.ProgressBar.Show()
        Me.ProgressBar.BringToFront()

        Worker = New BulkADWorker(Me.MainDataGrid, Me)
        Worker.RunBulkUserSetup()
    End Sub

    Private Sub PopulateSidePanel()
        Try
            If MainDataGrid.SelectedRows.Count = 1 Then
                Properties.UpdateProperties(GetMainDataGrid())
            Else
                Properties.DisableControls()
            End If
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Try
            Worker.CancelWork()
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message.ToString)
        End Try
    End Sub

    Private Sub MainDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MainDataGrid.CellFormatting
        If MainDataGrid.Columns.Contains("Status") Then
            If e.ColumnIndex = MainDataGrid.Columns("Status").Index Then
                e.CellStyle.BackColor = Color.WhiteSmoke
            End If
        End If
    End Sub

    Private Sub DeleteRow_Click(sender As Object, e As EventArgs) Handles DeleteRow.Click
        For Each row As DataGridViewRow In MainDataGrid.SelectedRows
            MainDataGrid.Rows.Remove(row)
        Next
    End Sub

    Private Sub InsertNewRow_Click(sender As Object, e As EventArgs) Handles InsertNewRow.Click
        Dim newDT As DataTable = MainDataGrid.DataSource
        Dim SourceRow As DataGridViewRow = MainDataGrid.SelectedRows(0)
        Dim NewRow = newDT.NewRow()
        With NewRow
            For Each col As DataGridViewColumn In MainDataGrid.Columns
                If col.Name = "Name" Then
                    .Item(col.Name) = SourceRow.Cells.Item(col.Name).Value & " (Copy)"
                Else
                    .Item(col.Name) = SourceRow.Cells.Item(col.Name).Value
                End If
            Next
        End With
        newDT.Rows.InsertAt(NewRow, MainDataGrid.SelectedRows(0).Index)
        MainDataGrid.Refresh()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        If GetMainSplitContainer1.Panel2Collapsed Then
            GetMainSplitContainer1.Panel2Collapsed = False
        End If
    End Sub

    Private Sub CopyValueToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyValueToClipboardToolStripMenuItem.Click
        Try
            If Not String.IsNullOrEmpty(CStr(MainDataGrid.SelectedRows(0).Cells("Status").Value)) Then
                My.Computer.Clipboard.SetText(MainDataGrid.SelectedRows(0).Cells(0).Value, System.Windows.Forms.TextDataFormat.Rtf)
            End If
        Catch ex As Exception
            Debug.WriteLine("Error: " & ex.Message)
        End Try

    End Sub

End Class
