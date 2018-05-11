Imports System
Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskPasswordReset
    Inherits TaskBase

    Public TargetUser As UserDomainObject
    Private TargetExplorerJob As TaskExplorer
    Private ResetForm As FormPasswordReset

    Private Delegate Sub Delegate_ResetPassword(ByVal Result As SimpleResult)

    Public Sub New(ByVal DomainUserObject As UserDomainObject, ByVal Job As TaskExplorer)
        MyBase.New
        TaskType = ActiveTaskType.PasswordReset
        TaskName = DomainUserObject.Name


        TargetUser = DomainUserObject

        If TargetUser.GetType() IsNot GetType(UserDomainObject) Then
            TaskStatus = ActiveTaskStatus.Failed
            Exit Sub
        ElseIf Not TargetUser Is Nothing Then
            TargetExplorerJob = Job

            ResetForm = New FormPasswordReset()
            ResetForm.ShowDialog()

            If ResetForm.DialogResult = DialogResult.Yes Then
                Threading.ThreadPool.QueueUserWorkItem(Sub() ResetPassword())
            Else
                TaskStatus = ActiveTaskStatus.Canceled
                Exit Sub
            End If

        End If
    End Sub

    Private Sub ResetPassword()

        Dim Result As SimpleResult = ResetUserPassword(TargetUser, ResetForm.Password, ResetForm.ForceResetToggle.Checked, ResetForm.UnlockAccount)

        GetContainerExplorer.Invoke(New Delegate_ResetPassword(AddressOf ResetPasswordFinished), Result)

    End Sub

    Private Sub ResetPasswordFinished(ByVal Result As SimpleResult)

        Logger.Log("[Info] New password reset request finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then

            TaskStatus = ActiveTaskStatus.Completed
            GetMainListView.RefreshObject(TargetUser)

            Dim ResultForm As FormAlert = New FormAlert("The Password has been reset for user " & TargetUser.Name, AlertType.Success) With {
                    .StartPosition = FormStartPosition.CenterScreen
                }
            ResultForm.ShowDialog()

        Else

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                MessageType = AlertType.AccessDenied
            End If

            Message = "Failed to reset the password for " & TargetUser.Name & Environment.NewLine & Result.Message

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
            .StartPosition = FormStartPosition.CenterScreen
            }

            ResultForm.ShowDialog()

        End If

    End Sub

End Class
