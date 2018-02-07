Imports System.Windows.Forms
Imports BrightIdeasSoftware.OLVExporter


Public Module ExportHandler

    Public Sub ExportCSV(sender As Object, e As MouseEventArgs)

        If GetMainListView.Items.Count < 1 Then
            Exit Sub
        Else

            Dim SaveDialog As SaveFileDialog = New SaveFileDialog With {
                .Filter = "CSV (Comma delimited)|*.csv",
                .Title = "Save File"
            }
            SaveDialog.ShowDialog()

            If Not String.IsNullOrEmpty(SaveDialog.FileName) Then
                Dim ListViewExporter As OLVExporter = New OLVExporter With {
                    .ListView = GetMainListView(),
                    .ModelObjects = DirectCast(GetMainListView.Objects, IList),
                    .IncludeColumnHeaders = True,
                    .IncludeHiddenColumns = True
                    }

                Dim ExportedData As String = ListViewExporter.ExportTo(ExportFormat.CSV)

                Threading.ThreadPool.QueueUserWorkItem(Sub() ExportData(ExportedData, SaveDialog.FileName))
            End If

        End If
    End Sub

    Public Sub ExportHTML(sender As Object, e As MouseEventArgs)

        If GetMainListView.Items.Count < 1 Then
            Exit Sub
        Else

            Dim ExportPath As String = Nothing

            If My.Settings.OpenExports = True Then
                ExportPath = IO.Path.GetTempPath() & Guid.NewGuid.ToString & ".html"
            Else
                Dim SaveDialog As SaveFileDialog = New SaveFileDialog With {
                    .Filter = "HTML (Hyper Text Markup Language)|*.html",
                    .Title = "Save File"
                    }
                SaveDialog.ShowDialog()

                ExportPath = SaveDialog.FileName

            End If

            If Not String.IsNullOrEmpty(ExportPath) Then
                Dim ListViewExporter As OLVExporter = New OLVExporter With {
                    .ListView = GetMainListView(),
                    .ModelObjects = DirectCast(GetMainListView.Objects, IList),
                    .IncludeColumnHeaders = True,
                    .IncludeHiddenColumns = True
                    }

                Dim ExportedData As String = StyleHTMLExport(ListViewExporter.ExportTo(ExportFormat.HTML))

                Threading.ThreadPool.QueueUserWorkItem(Sub() ExportData(ExportedData, ExportPath))
            End If
        End If
    End Sub

    Public Sub ExportTab(sender As Object, e As MouseEventArgs)

        If GetMainListView.Items.Count < 1 Then
            Exit Sub
        Else

            Dim SaveDialog As SaveFileDialog = New SaveFileDialog With {
                .Filter = "Text (Tab delimited)|*.txt",
                .Title = "Save File"
            }

            SaveDialog.ShowDialog()

            If Not String.IsNullOrEmpty(SaveDialog.FileName) Then
                Dim ListViewExporter As OLVExporter = New OLVExporter With {
                    .ListView = GetMainListView(),
                    .ModelObjects = DirectCast(GetMainListView.Objects, IList),
                    .IncludeColumnHeaders = True,
                    .IncludeHiddenColumns = True
                    }

                Dim ExportedData As String = ListViewExporter.ExportTo(ExportFormat.TabSeparated)

                Threading.ThreadPool.QueueUserWorkItem(Sub() ExportData(ExportedData, SaveDialog.FileName))
            End If
        End If
    End Sub

    Public Sub ExportData(ByVal Data As String, ByVal Path As String)
        Dim FileToWrite As IO.StreamWriter
        FileToWrite = My.Computer.FileSystem.OpenTextFileWriter(Path, True)
        FileToWrite.WriteLine(Data)
        FileToWrite.Close()

        Try
            Process.Start(Path)
        Catch ex As Exception
            Debug.WriteLine("[Error] " & ex.Message)
        End Try

    End Sub

End Module
