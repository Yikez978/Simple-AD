Imports AutoUpdaterDotNET

Public Module Updater

    Public Sub StartUpdateCheck()

        AddHandler AutoUpdater.CheckForUpdateEvent, AddressOf AutoUpdaterOnCheckForUpdateEvent
        AutoUpdater.Start("http://storage.googleapis.com/simple-ad.appspot.com/SimpleAD/versioninfo.xml")
    End Sub

    Private Sub AutoUpdaterOnCheckForUpdateEvent(args As UpdateInfoEventArgs)
        If args IsNot Nothing Then
            If args.IsUpdateAvailable Then
                Dim dialogResult__1 = MessageBox.Show(String.Format("There is new version {0} available. You are using version {1}. Do you want to update the application now?", args.CurrentVersion, args.InstalledVersion), "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialogResult__1.Equals(DialogResult.Yes) Then
                    Try
                        'You can use Download Update dialog used by AutoUpdater.NET to download the update.
                        AutoUpdater.DownloadUpdate()
                    Catch exception As Exception
                        MessageBox.Show(exception.Message, exception.[GetType]().ToString(), MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End Try
                End If
            Else
                MessageBox.Show("There is no update available please try again later.", "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("There is a problem reaching update server please check your internet connection and try again later.", "Update check failed", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

End Module