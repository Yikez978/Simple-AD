Imports System.IO.File
Imports System.ComponentModel

Public Class FileExportHelper

    Public Shared Sub ExportFile(Source As DataGridView, Dialog As SaveFileDialog)

        Debug.WriteLine("[Info] Started File Export...")
        Dim workerArgs As Array = {Dialog, Source}

        Dim ExportFileBW As BackgroundWorker = New BackgroundWorker

        With ExportFileBW
            .WorkerSupportsCancellation = True
            .WorkerReportsProgress = True
        End With

        AddHandler ExportFileBW.DoWork, AddressOf ExportFileBW_DoWork
        AddHandler ExportFileBW.ProgressChanged, AddressOf ExportFileBW_ProgressChanged
        AddHandler ExportFileBW.RunWorkerCompleted, AddressOf ExportFileBW_RunWorkerCompleted

        ExportFileBW.RunWorkerAsync(workerArgs)
        ExportFileBW.Dispose()
    End Sub

    Shared Sub ExportFileBW_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim args As Array = e.Argument
        Dim autoMainDataGrid As DataGridView = GetMainDataGrid(args(1))

        Debug.WriteLine("[Info] Export File Background worker Initiated")

        Try
            For i As Integer = 0 To GlobalVariables.HiddenColums.Count - 1
                If Not GlobalVariables.HiddenColums(i) = "Status" Then
                    autoMainDataGrid.Columns.Remove(CStr(GlobalVariables.HiddenColums(i)))
                End If
            Next

        Catch Ex As Exception
            Debug.WriteLine("[Error] DataGridView Columns IconColumn and or Status do not Exist...")
            Debug.WriteLine("[Error] " & Ex.ToString)
        End Try

        autoMainDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        autoMainDataGrid.SelectAll()
        autoMainDataGrid.RowHeadersVisible = False

        Dim DataObject As DataObject = autoMainDataGrid.GetClipboardContent()

        WriteAllText(args(0).FileName, DataObject.GetData("Csv"))

    End Sub

    Shared Sub ExportFileBW_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

    End Sub

    Shared Sub ExportFileBW_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then

        ElseIf e.Error IsNot Nothing Then

        Else
            Debug.WriteLine("[Info] File Export Completed")
        End If

    End Sub

End Class
