Imports System.IO

Public Module LocalData

    Public Sub SaveRecentFile(Path As String)

        GetRecentFileList()

        Dim RecntFileStreamReader As New StreamReader(appData & "\SimpleAD.txt")
        Dim recentFilesList As New List(Of String)

        If File.Exists(Path) Then

            While Not RecntFileStreamReader.EndOfStream
                Dim Line As String = RecntFileStreamReader.ReadLine
                If Not recentFilesList.Contains(Line) AndAlso Not String.IsNullOrEmpty(Line) Then
                    recentFilesList.Add(Line)
                End If
            End While

            RecntFileStreamReader.Close()

            If Not recentFilesList.Contains(Path) Then
                Using RecntFileStreamWriter As StreamWriter = File.AppendText(appData & "\SimpleAD.txt")
                    RecntFileStreamWriter.WriteLine(Path)
                    RecntFileStreamWriter.Close()
                End Using
            End If

        End If
    End Sub

    Public Sub GetRecentFileList()

        If Not Directory.Exists(appData) Then
            Directory.CreateDirectory(appData)
        End If

        If Not File.Exists(appData & "\SimpleAD.txt") Then
            File.Create(appData & "\SimpleAD.txt").Close()
        End If

    End Sub

    Public Sub PopulateRecentFileList()
        If File.Exists(appData & "\SimpleAD.txt") Then

            Dim RecntFileStreamReader As New StreamReader(appData & "\SimpleAD.txt")
            Dim recentFilesList As New List(Of String)

            For Each item As ToolStripDropDownItem In FormMain.RecentFilesToolStripMenuItem.DropDownItems
                recentFilesList.Add(item.Text)
            Next

            While Not RecntFileStreamReader.EndOfStream
                Dim Line As String = RecntFileStreamReader.ReadLine
                If Not recentFilesList.Contains(Line) AndAlso Not String.IsNullOrEmpty(Line) Then
                    If File.Exists(Line) Then
                        Dim RecentFileItem As ToolStripMenuItem = FormMain.RecentFilesToolStripMenuItem.DropDownItems.Add(Line)
                        AddHandler RecentFileItem.Click, Sub(Sender, e) RecentFileMenuIte_CLick(Line)

                        Try
                            RecentFileItem.Image = New Bitmap(Icon.ExtractAssociatedIcon(Line).ToBitmap, New Size(17, 17))
                            RecentFileItem.ImageScaling = ToolStripItemImageScaling.None
                        Catch Ex As Exception
                            Debug.WriteLine("Unable to load image from file " & Line & " {0}" & Ex.Message)
                        End Try
                    End If
                End If
            End While
            RecntFileStreamReader.Close()
        End If
    End Sub

    Private Sub RecentFileMenuIte_CLick(ByVal ImportFile As String)
        Dim RecentImportFile = New JobImport(ImportFile)
    End Sub

End Module
