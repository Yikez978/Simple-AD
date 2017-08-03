Public Module Updater

    Public Sub RunUpdater()
        Dim Updater = New RedCell.Diagnostics.Update.Updater()
        Updater.StartMonitoring()
    End Sub

End Module
