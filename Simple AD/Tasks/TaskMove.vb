Imports System
Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskMove
    Inherits TaskBase

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As TaskExplorer

    Private MoveForm As FormMoveObject

    Private Delegate Sub Delegate_MoveObject(ByVal Result As SimpleResult)

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As TaskExplorer)
        MyBase.New
        TaskType = ActiveTaskType.Move
        TaskName = DomainObject.Name

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then

            MoveForm = New FormMoveObject()

            With MoveForm
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

            If MoveForm.DialogResult = DialogResult.Yes Then
                Threading.ThreadPool.QueueUserWorkItem(Sub() MoveObject(TargetDomainObject, MoveForm.SelecetdOU))
            Else
                TaskStatus = ActiveTaskStatus.Canceled
            End If

        End If

    End Sub

    Private Sub MoveObject(ByVal ObjectToMove As DomainObject, ByVal Container As String)

        Dim Result As SimpleResult = MoveADObject(ObjectToMove, Container)

        GetContainerExplorer.Invoke(New Delegate_MoveObject(AddressOf MoveObjectFinished), Result)

    End Sub

    Private Sub MoveObjectFinished(ByVal Result As SimpleResult)

        Logger.Log("[Info] Move object request finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then
            TaskStatus = ActiveTaskStatus.Completed

            TargetExplorerJob.Refresh()

        Else

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                Message = String.Format("Failed to move {0} {1}, Access is denied", TargetDomainObject.TypeFriendly, TargetDomainObject.Name)
                MessageType = AlertType.AccessDenied
            Else
                Message = String.Format("An Error occured while trying to move {0} {1}", TargetDomainObject.TypeFriendly, TargetDomainObject.Name)
            End If

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
                .StartPosition = FormStartPosition.CenterScreen
                }

            ResultForm.ShowDialog()

        End If

    End Sub

End Class
