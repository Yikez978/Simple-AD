﻿Imports System.ComponentModel


Public Module HideColumnsWorker

    Public cbw As BackgroundWorker = New BackgroundWorker
    Private _DataGrid

    Public Sub HideColumns(SourceGrid As DataGridView)

        _DataGrid = SourceGrid

        cbw.WorkerReportsProgress = True
        cbw.WorkerSupportsCancellation = True

        AddHandler cbw.DoWork, AddressOf Cbw_DoWork
        AddHandler cbw.ProgressChanged, AddressOf Cbw_ProgressChanged
        AddHandler cbw.RunWorkerCompleted, AddressOf Cbw_RunWorkerCompleted

        _DataGrid.SuspendLayout()

        If Not (cbw.IsBusy) Then
            cbw.RunWorkerAsync(_DataGrid)
        End If
        cbw.Dispose()

    End Sub

    Private Sub Cbw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim _DataGrid As DataGridView = e.Argument

        If cbw.CancellationPending = True Then
            e.Cancel = True

        Else

            Debug.WriteLine("[Info] HideColumnsWorker Work Started")

            Dim autoMainDataGrid As DataGridView = CopyMainDataGrid(_DataGrid)

            Dim sb As New System.Text.StringBuilder
            Dim IsCurrentColumnEmpty As Boolean = False

            For Each Column As DataGridViewColumn In autoMainDataGrid.Columns
                If Not PersistantColumns.Contains(Column.Name) Then
                    Dim variable As String = ""
                    sb.Remove(0, sb.Length)

                    For Each row As DataGridViewRow In autoMainDataGrid.Rows

                        variable = sb.Append(row.Cells(Column.Name).Value).ToString

                        If variable = "" Then
                            IsCurrentColumnEmpty = True
                        Else
                            Exit For
                        End If

                    Next

                    If IsCurrentColumnEmpty = True Then
                        cbw.ReportProgress(0, Column.Name.ToString)
                    End If
                    IsCurrentColumnEmpty = False

                End If
            Next
        End If

    End Sub

    Private Sub Cbw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        GetMainDataGrid.Columns(e.UserState.ToString).Visible = False
        Debug.WriteLine("[Info] The following Column in MainDataGrid Has been Hidden - " & e.UserState.ToString)
        HiddenColums.Add(e.UserState.ToString)
    End Sub

    Private Sub Cbw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Debug.WriteLine("[Info] HideColumnsWorker Work Complete")
        _DataGrid.resumeLayout
    End Sub

    Public Function GetCBWBusy()
        Return cbw.IsBusy
    End Function

End Module
