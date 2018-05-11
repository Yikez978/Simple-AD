Imports System
Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskEnableDisable
    Inherits TaskBase

    Private TargetDomainObject As UserDomainObject
    Private TargetExplorerJob As TaskExplorer
    Private TargetObjectState As Boolean

    Private Delegate Sub Delegate_EnableDisableObject(ByVal Result As SimpleResult)

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As TaskExplorer, ByVal ObjectState As Boolean)
        MyBase.New
        TaskType = ActiveTaskType.EnableDisable
        TaskName = DomainObject.Name


        TargetDomainObject = DirectCast(DomainObject, UserDomainObject)
        TargetExplorerJob = Job
        TargetObjectState = ObjectState

        If Not TargetDomainObject Is Nothing Then
            Threading.ThreadPool.QueueUserWorkItem(Sub() EnableDisableObject())
        End If

    End Sub

    Private Sub EnableDisableObject()
        Dim Result As SimpleResult

        If TargetObjectState Then
            Result = EnableADUserUsingUserAccountControl(TargetDomainObject)
        Else
            Result = DisableADUserUsingUserAccountControl(TargetDomainObject)
        End If

        GetContainerExplorer.Invoke(New Delegate_EnableDisableObject(AddressOf EnableDisableObjectFinished), Result)

    End Sub

    Private Sub EnableDisableObjectFinished(ByVal Result As SimpleResult)

        Logger.Log("[Info] New EnableDisableObject Request Finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then

            TaskStatus = ActiveTaskStatus.Completed
            GetMainListView.RefreshObject(TargetDomainObject)

        Else

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                Message = "Access Denied"
                MessageType = AlertType.AccessDenied
            Else
                Message = "An Error occured while trying to change the enabled state of " & TargetDomainObject.Name
            End If

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
                .StartPosition = FormStartPosition.CenterScreen
                }

            ResultForm.ShowDialog()

        End If

    End Sub

End Class
