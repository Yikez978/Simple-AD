Imports System.IO

Public Module LocalData

    Public Sub SaveRecentFile(Path As String)

        GetRecentFileList()

        Dim RecntFileStreamReader As New StreamReader(GlobalVariables.appData & "\Simple_AD.txt")
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
                Using RecntFileStreamWriter As StreamWriter = File.AppendText(GlobalVariables.appData & "\Simple_AD.txt")
                    RecntFileStreamWriter.WriteLine(Path)
                    RecntFileStreamWriter.Close()
                End Using
            End If

        End If
    End Sub

    Public Sub GetRecentFileList()

        If Not IO.Directory.Exists(GlobalVariables.appData) Then
            IO.Directory.CreateDirectory(GlobalVariables.appData)
        End If

        If Not IO.File.Exists(GlobalVariables.appData & "\Simple_AD.txt") Then
            File.Create(GlobalVariables.appData & "\Simple_AD.txt").Close()
        End If

    End Sub

    Public Sub PopulateRecentFileList()
        If IO.File.Exists(GlobalVariables.appData & "\Simple_AD.txt") Then

            Dim RecntFileStreamReader As New StreamReader(GlobalVariables.appData & "\Simple_AD.txt")
            Dim recentFilesList As New List(Of String)

            For Each item As ToolStripDropDownItem In FormMain.RecentFilesToolStripMenuItem.DropDownItems
                recentFilesList.Add(CStr(item.Text))
            Next

            While Not RecntFileStreamReader.EndOfStream
                Dim Line As String = RecntFileStreamReader.ReadLine
                If Not recentFilesList.Contains(Line) AndAlso Not String.IsNullOrEmpty(Line) Then
                    If File.Exists(Line) Then
                        Dim RecentFileItem As ToolStripMenuItem = FormMain.RecentFilesToolStripMenuItem.DropDownItems.Add(Line)
                        AddHandler RecentFileItem.Click, Sub(Sender, e) RecentFileMenuIte_CLick(Line)

                        Try
                            RecentFileItem.Image = New Bitmap(Drawing.Icon.ExtractAssociatedIcon(Line).ToBitmap, New Size(17, 17))
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
        Dim RecentImportFile = New JobUserBulk(ImportFile)
    End Sub

End Module
