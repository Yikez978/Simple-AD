Public Module ImportHelper

    Public Sub UserImport()

        Dim OpenFileDialogImport = New OpenFileDialog

        OpenFileDialogImport.Title = "Import a CSV File"
        OpenFileDialogImport.Filter = "Comma Delimited|*.csv|All Files|*.*"
        OpenFileDialogImport.ShowDialog()

        Dim csvPathSs = OpenFileDialogImport.FileName

        If csvPathSs IsNot Nothing Then
            Try
                If IO.File.Exists(OpenFileDialogImport.FileName) Then
                    If Not FileInUse(OpenFileDialogImport.FileName) Then

                        SaveRecentFile(OpenFileDialogImport.FileName)
                        Dim NewImportFile = New JobImport(OpenFileDialogImport.FileName)

                    Else
                        Debug.WriteLine("[Error] Unable to open file as it is being used by another process")
                        MsgBox("Unable to open file as it is being used by another process")
                    End If
                End If
            Catch Ex As Exception
                Debug.WriteLine("[Error] " & Ex.Message)
            End Try
        End If

    End Sub

End Module
