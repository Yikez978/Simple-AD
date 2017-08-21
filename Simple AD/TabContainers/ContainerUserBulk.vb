Imports System.Runtime.InteropServices

Public Class ContainerUserBulk
    Inherits UserControl

    Public DomainTree As ControlDomainTreeView

    Private _ID
    Private _JobName
    Private _JobClass

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

    Public Property JobClass
        Set(value)
            _JobClass = value
        End Set
        Get
            Return _JobClass
        End Get
    End Property

    Public Sub New(ByVal ID As Integer, ByVal JobName As String, JobClass As JobUserBulk)

        Me.ID = ID
        Me.JobName = JobName
        Me.Dock = DockStyle.Fill
        Me.JobClass = JobClass

        InitializeComponent()

        DomainTree = Me.DomainTreeView
        MainDataGrid.DoubleBuffered(True)
    End Sub

    Public Function GetMainDataGrid() As DataGridView
        Return Me.MainDataGrid
    End Function

    Public Function GetAccecptButton() As Controls.MetroButton
        Return Me.AcceptBt
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer0
    End Function

    Public Function GetProgressBar() As ProgressBar
        Return Me.ProgressBar
    End Function

    Public Function GetSpinner() As MetroFramework.Controls.MetroProgressSpinner
        Return Me.MetroProgressSpinner
    End Function

    Private Sub MainDataGrid_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs)
        If MainDataGrid.SelectedRows.Count > 0 Then
            FormMain.ToolStripStatusLabelContext.Text = GetMainDataGrid().SelectedRows.Count & " Object(s) Selected of " & GetMainDataGrid().Rows.Count
        End If
    End Sub

    Private Sub MainDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MainDataGrid.CellMouseClick
        ContextMenuHelper.GetDataGridViewConextMenu(MainDataGrid, e, CMStripRowRClick, sender)
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBt.Click
        If Not String.IsNullOrEmpty(SelectedOU) Then
            Dim ShowOptions As New FormBulkUserOptions(_JobClass, Me)
            ShowOptions.ShowDialog()
        End If
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Try
            For Each Worker As BulkADWorker In OngoingBulkJobs
                If Worker.BulkUserContainerObject Is Me Then
                    Worker.CancelWork()
                End If
            Next
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message.ToString)
        End Try
    End Sub

    Private Sub MainDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
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
                Try
                    If col.Name = "nameCol" Then
                        .Item(col.Name) = SourceRow.Cells.Item(col.Name).Value & " (Copy)"
                    Else
                        .Item(col.Name) = SourceRow.Cells.Item(col.Name).Value
                    End If
                Catch ex As Exception
                    Debug.WriteLine("[Error] " & ex.Message)
                End Try
            Next
        End With
        newDT.Rows.InsertAt(NewRow, MainDataGrid.SelectedRows(0).Index)
        MainDataGrid.Refresh()
    End Sub

    Private Sub CopyValueToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyValueToClipboardToolStripMenuItem.Click
        Try
            If Not String.IsNullOrEmpty(CStr(MainDataGrid.SelectedRows(0).Cells("Status").Value)) Then
                My.Computer.Clipboard.SetText(MainDataGrid.SelectedRows(0).Cells(0).Value, TextDataFormat.Rtf)
            End If
        Catch ex As Exception
            Debug.WriteLine("[Error] " & ex.Message)
        End Try
    End Sub

End Class
