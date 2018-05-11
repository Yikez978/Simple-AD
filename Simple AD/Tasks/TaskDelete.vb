Imports System
Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskDelete
    Inherits TaskBase

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As TaskExplorer

    Private DeleteForm As FormConfirmation

    Private Delegate Sub Delegate_DeleteObject(ByVal Result As SimpleResult)

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As TaskExplorer)
        TaskType = ActiveTaskType.Delete
        TaskName = DomainObject.Name


        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then

            DeleteForm = New FormConfirmation(String.Format("Are you sure you wish to delete {0}?", TargetDomainObject.Name), ConfirmationType.Delete)

            With DeleteForm
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

            If DeleteForm.DialogResult = DialogResult.Yes Then
                Threading.ThreadPool.QueueUserWorkItem(Sub() DeleteObject(TargetDomainObject))
            Else
                TaskStatus = ActiveTaskStatus.Canceled
            End If

        End If

    End Sub

    Private Sub DeleteObject(ByVal ObjectToDelete As DomainObject)

        Dim Result As SimpleResult = DeleteADObject(ObjectToDelete)

        GetContainerExplorer.Invoke(New Delegate_DeleteObject(AddressOf DeleteObjectFinished), Result)

    End Sub

    Private Sub DeleteObjectFinished(ByVal Result As SimpleResult)

        Logger.Log("[Info] Delete object request finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then
            TaskStatus = ActiveTaskStatus.Completed

            TargetExplorerJob.Refresh()

        Else

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                Message = String.Format("Failed to delete {0} {1}, Access is denied", TargetDomainObject.TypeFriendly, TargetDomainObject.Name)
                MessageType = AlertType.AccessDenied
            Else
                Message = String.Format("An Error occured while trying to delete {0} {1}", TargetDomainObject.TypeFriendly, TargetDomainObject.Name)
            End If

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
                .StartPosition = FormStartPosition.CenterScreen
                }

            ResultForm.ShowDialog()

        End If

    End Sub

End Class
