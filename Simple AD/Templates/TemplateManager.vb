Imports System.IO
Imports System.Environment
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Imports SimpleLib
Imports SimpleLib.SystemHelper

Public Module TemplateManager

    Public Property TemplateList As New List(Of UserTemplate)

    Private AppData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Simple AD\Templates"

    Public Event FinishedRefresh()

    Public Sub RefreshTamplates()
        TemplateList.Clear()

        Try

            If HasWritePermissionOnDir(AppData) Then

                If Not Directory.Exists(AppData) Then
                    Directory.CreateDirectory(AppData)
                End If

                For Each File As String In Directory.GetFiles(AppData)

                    Dim Formatter As IFormatter = New BinaryFormatter()
                    Dim Stream As Stream = New FileStream(File, FileMode.Open, FileAccess.ReadWrite, FileShare.None)

                    Try
                        Dim LoadTemplate As UserTemplate = DirectCast(Formatter.Deserialize(Stream), UserTemplate)
                        TemplateList.Add(LoadTemplate)
                    Catch Ex As Exception
                        Logger.Log("[Error] Unable to load template from file, source data is corrupt: " & Ex.Message)
                    End Try

                    Stream.Close()
                Next

                RaiseEvent FinishedRefresh()

            End If
        Catch Ex As Exception
            Logger.Log("[Error] Failed to load templates: " & Ex.Message)
        End Try
    End Sub

End Module
