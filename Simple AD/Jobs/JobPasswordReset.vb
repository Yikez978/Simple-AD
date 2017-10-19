Public Class JobPasswordReset
    Inherits SimpleADJob

    Private TargetUser As UserDomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainUserObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New(SimpleADJobType.PasswordReset, DomainUserObject.Name)

        TargetUser = DomainUserObject
        TargetExplorerJob = Job

        If Not TargetUser Is Nothing Then
            ResetPassword()
        End If
    End Sub

    Private Sub ResetPassword()

        Dim ResetForm = New FormPasswordReset
        ResetForm.Location = GetDialogLocation(ResetForm)
        ResetForm.ShowDialog()

        If ResetForm.DialogResult = DialogResult.Yes Then
            If ResetUserPassword(TargetUser, ResetForm.Password, ResetForm.ForceResetToggle.Checked) = True Then
                TargetExplorerJob.Refresh()
                Dim ResultForm = New FormAlert("The Password has been reset for user " & TargetUser.Name, AlertType.Success)
                ResultForm.ShowDialog()
            Else
                Dim ResultForm = New FormAlert("An Error occured while trying to set the password for user " & TargetUser.Name, AlertType.ErrorAlert)
                ResultForm.ShowDialog()
            End If
        End If

    End Sub

End Class
