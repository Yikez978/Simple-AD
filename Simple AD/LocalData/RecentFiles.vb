Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports SimpleLib

Namespace LocalData

    Public Class RecentFiles

        Public Shared Sub SaveRecentFile(Path As String)

            Try

                SetupLocalData()

                Dim RecentFileStreamReader As New StreamReader(AppData & "\RecentFiles.txt")
                Dim recentFilesList As New List(Of String)

                If File.Exists(Path) Then

                    While Not RecentFileStreamReader.EndOfStream
                        Dim Line As String = RecentFileStreamReader.ReadLine
                        If Not recentFilesList.Contains(Line) AndAlso Not String.IsNullOrEmpty(Line) Then
                            recentFilesList.Add(Line)
                        End If
                    End While

                    RecentFileStreamReader.Close()

                    If Not recentFilesList.Contains(Path) Then
                        Using RecntFileStreamWriter As StreamWriter = File.AppendText(AppData & "\RecentFiles.txt")
                            RecntFileStreamWriter.WriteLine(Path)
                            RecntFileStreamWriter.Close()
                        End Using
                    End If

                End If

            Catch Ex As Exception
                Logger.Log(String.Format("[Error] Faile to write path {0} to recent files: {1}", Path, Ex.Message))
            End Try

        End Sub

        Public Shared Sub PopulateRecentFileList()
            If File.Exists(AppData & "\RecentFiles.txt") Then

                Dim RecntFileStreamReader As New StreamReader(AppData & "\RecentFiles.txt")
                Dim recentFilesList As New List(Of String)

                For Each item As ToolStripDropDownItem In FormMain.RecentFilesToolStripMenuItem.DropDownItems
                    recentFilesList.Add(item.Text)
                Next

                While Not RecntFileStreamReader.EndOfStream
                    Dim Line As String = RecntFileStreamReader.ReadLine
                    If Not recentFilesList.Contains(Line) AndAlso Not String.IsNullOrEmpty(Line) Then
                        If File.Exists(Line) Then
                            Dim RecentFileItem As ToolStripItem = FormMain.RecentFilesToolStripMenuItem.DropDownItems.Add(Line)
                            AddHandler RecentFileItem.Click, Sub(Sender, e) RecentFileMenuItem_Click(Line)

                            Try
                                RecentFileItem.Image = New Bitmap(Icon.ExtractAssociatedIcon(Line).ToBitmap, New Size(17, 17))
                                RecentFileItem.ImageScaling = ToolStripItemImageScaling.None
                            Catch Ex As Exception
                                Logger.Log("[Error] Unable to load image from file " & Line & " {0}" & Ex.Message)
                            End Try
                        End If
                    End If
                End While
                RecntFileStreamReader.Close()
            End If
        End Sub

        Private Shared Sub RecentFileMenuItem_Click(ByVal ImportFile As String)
            Dim RecentImportForm As FormImport = New FormImport(ImportFile)
            RecentImportForm.ShowDialog()
        End Sub

    End Class
End Namespace
