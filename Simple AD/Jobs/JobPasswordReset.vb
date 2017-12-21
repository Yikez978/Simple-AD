

Public Class JobPasswordReset
    Inherits SimpleADJob

    Public TargetUser As UserDomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainUserObject As UserDomainObject, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.PasswordReset
        JobName = DomainUserObject.Name
        

        TargetUser = DomainUserObject

        If TargetUser.GetType() IsNot GetType(UserDomainObject) Then
            JobStatus = SimpleADJobStatus.Failed
            Exit Sub
        ElseIf Not TargetUser Is Nothing Then
            TargetExplorerJob = Job
            ResetPassword()

        End If
    End Sub

    Private Sub ResetPassword()

        Dim ResetForm As FormPasswordReset = New FormPasswordReset
        ResetForm.Location = GetDialogLocation(ResetForm)
        ResetForm.ShowDialog()

        If ResetForm.DialogResult = DialogResult.Yes Then
            If ResetUserPassword(TargetUser, ResetForm.Password, ResetForm.ForceResetToggle.Checked, ResetForm.UnlockAccount) = True Then
                JobStatus = SimpleADJobStatus.Completed
                TargetExplorerJob.Refresh()
                Dim ResultForm As FormAlert = New FormAlert("The Password has been reset for user " & TargetUser.Name, AlertType.Success) With {
                    .StartPosition = FormStartPosition.CenterScreen
                }
                ResultForm.ShowDialog()
            Else
                JobStatus = SimpleADJobStatus.Failed
                Dim ResultForm As FormAlert = New FormAlert("An Error occured while trying to set the password for user " & TargetUser.Name, AlertType.ErrorAlert) With {
                    .StartPosition = FormStartPosition.CenterScreen
                }
                ResultForm.ShowDialog()
            End If
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

End Class
