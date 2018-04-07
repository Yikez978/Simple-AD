Imports System.Drawing
Imports SimpleLib

Public Class ADConnectionChecker

    Private _ErrorForm As FormAlert

    Public Sub RunCheck()
        UpdateUI(ValidateActiveDirectoryLogin(LoginUsername, LoginPassword, LoginUsernamePrefix))
    End Sub

    Private Sub UpdateUI(ByVal State As Boolean)

        If FormMain.StatusStrip.InvokeRequired Then
            FormMain.StatusStrip.Invoke(New Action(Of Boolean)(AddressOf UpdateUI), State)
        Else

            If State Then

                Dim DomainName As String = GetLocalDomainName()

                With FormMain.ConnectionToolStripStatusLabel
                    .Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                    .Text = "Connected to " & GetSingleDomainController()
                    .ToolTipText = "Domain: " &
                        DomainName & Environment.NewLine &
                        "FQDN: " & GetFQDN() & Environment.NewLine &
                        "DC Net BIOS: " & GetSingleDomainController()
                End With

            Else
                With FormMain.ConnectionToolStripStatusLabel
                    .Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                    .Text = "Unable to connect to any valid logon server"
                End With

                If _ErrorForm Is Nothing Then
                    _ErrorForm = New FormAlert("Unable to connect to a domain controller!", AlertType.ErrorAlert)
                    _ErrorForm.ShowDialog()
                End If
            End If
        End If
    End Sub

End Class