Imports System.ComponentModel

Imports Simple_AD.ContextMenuHelper


Public Class AccountListPreview
    Inherits UserControl

    Dim MainDataGrid As DataGridView
    Dim cbw As BackgroundWorker = New BackgroundWorker
    Dim ftdt As New System.Data.DataTable
    Dim ProcessedUsers As Integer = 0

    Private Sub InitializeComponent()
        Me.MainDataGrid = New DataGridView
        Me.SuspendLayout()
        Me.MainDataGrid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.MainDataGrid.Name = "MainDataGrid"
        Me.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGrid.Size = New System.Drawing.Size(851, 447)
        Me.MainDataGrid.DoubleBuffered(True)
        Me.MainDataGrid.Visible = True

        Me.Controls.Add(Me.MainDataGrid)
        Me.Name = "AccountListPreview"
        Me.ResumeLayout(False)


        cbw.WorkerReportsProgress = True
        cbw.WorkerSupportsCancellation = True

        AddHandler cbw.DoWork, AddressOf Cbw_DoWork
        AddHandler cbw.ProgressChanged, AddressOf Cbw_ProgressChanged
        AddHandler cbw.RunWorkerCompleted, AddressOf Cbw_RunWorkerCompleted

        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)

    End Sub


    Private Sub MainDataGrid_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs)
        Dim row As DataGridViewRow
        Dim FirstValue As Boolean = True

        For Each row In MainDataGrid.SelectedRows
            MainApplicationForm.ToolStripStatusLabelContext.Text = MainDataGrid.SelectedRows.Count & " Object(s) Selected of " & MainDataGrid.Rows.Count
        Next
    End Sub

    Private Sub MainDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        'GetDataGridViewConextMenu(MainDataGrid, e, CMStripRowRClick)
    End Sub

    Private Sub DeleteRow_Click(sender As Object, e As EventArgs)

        For Each row As DataGridViewRow In MainDataGrid.SelectedRows
            MainDataGrid.Rows.Remove(row)
        Next
    End Sub

    Private Sub InsertNewRow_Click(sender As Object, e As EventArgs)

        Dim newDT As DataTable = MainDataGrid.DataSource
        Dim NewRow = newDT.NewRow()
        newDT.Rows.InsertAt(NewRow, MainDataGrid.SelectedRows(0).Index)
        MainDataGrid.Refresh()
    End Sub

    Private Sub CopyValueToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs)

        If Not String.IsNullOrEmpty(MainDataGrid.SelectedRows(0).Cells("Status").Value) Then
            My.Computer.Clipboard.SetText(MainDataGrid.SelectedRows(0).Cells(0).Value, System.Windows.Forms.TextDataFormat.Rtf)
        End If

    End Sub

#Region "Hide Columns Background Worker"

    Private Sub Cbw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        If cbw.CancellationPending = True Then
            e.Cancel = True

        Else

            System.Diagnostics.Debug.WriteLine("CBW Work Started")

            Dim autoMainDataGrid As DataGridView = GetMainDataGrid(MainDataGrid)

            Dim sb As New System.Text.StringBuilder
            Dim IsCurrentColumnEmpty As Boolean = False

            For Each Column As DataGridViewColumn In autoMainDataGrid.Columns
                If Not Column.Name = "Status" Then
                    Dim variable As String = ""
                    sb.Remove(0, sb.Length)
                    System.Diagnostics.Debug.WriteLine("Currently Scanning the column " & Column.Name)

                    For Each row As DataGridViewRow In autoMainDataGrid.Rows

                        variable = sb.Append(row.Cells(Column.Name).Value).ToString

                        System.Diagnostics.Debug.WriteLine(Column.Name & " variable = " & variable)

                        If variable = "" Then
                            IsCurrentColumnEmpty = True
                            System.Diagnostics.Debug.WriteLine("Column " & Column.Name & " is empty")
                        Else
                            System.Diagnostics.Debug.WriteLine("Column " & Column.Name & " is not empty")
                            Exit For
                        End If

                    Next
                End If

                If IsCurrentColumnEmpty = True Then
                    cbw.ReportProgress(0, Column.Name.ToString)
                End If
                IsCurrentColumnEmpty = False
            Next
        End If

    End Sub

    Private Sub Cbw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        MainDataGrid.Columns(e.UserState.ToString).Visible = False
        System.Diagnostics.Debug.WriteLine("The following Column in MainDataGrid Has been Hidden - " & e.UserState.ToString)
        GlobalVariables.HiddenColums.Add(e.UserState.ToString)
    End Sub

    Private Sub Cbw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        System.Diagnostics.Debug.WriteLine("CBW Work Complete")
    End Sub

#End Region

End Class
