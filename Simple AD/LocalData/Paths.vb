Imports System.Environment
Imports System.IO

Namespace LocalData

    Public Module Paths

        Public ReadOnly Property AppData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Simple AD"

        Public Sub SetupLocalData()

            If Not Directory.Exists(AppData) Then
                Directory.CreateDirectory(AppData)
            End If

            If Not File.Exists(AppData & "\RecentFiles.txt") Then
                File.Create(AppData & "\RecentFiles.txt").Close()
            End If

            If Not File.Exists(AppData & "\SimpleADConfig.ini") Then
                CreateDefaultConfig()
            End If

        End Sub

    End Module

End Namespace

