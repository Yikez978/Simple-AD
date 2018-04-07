Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskRename
    Inherits TaskBase

    Private _TargetDomainObject As DomainObject
    Private _ResetForm As FormPasswordReset
    Private _ListView As ControlDomainListView

    Private Delegate Sub Delegate_Rename(ByVal Result As SimpleResult)

    Public NewName As String
    Public OldName As String

    Public Event RenameComplete(ByVal Status As Boolean)

    Public Sub New(ByVal DomainObject As DomainObject, ListView As ControlDomainListView, ByVal Name As String, ByVal OName As String)
        MyBase.New
        TaskType = ActiveTaskType.Rename
        TaskName = "Rename " & DomainObject.Name

        NewName = Name
        OldName = OName

        _TargetDomainObject = DomainObject
        _ListView = ListView

        If _TargetDomainObject IsNot Nothing Then
            Threading.ThreadPool.QueueUserWorkItem(Sub() Rename())
        End If

    End Sub

    Private Sub Rename()

        Dim Result As SimpleResult = RenameObject(_TargetDomainObject, NewName)

        If GetContainerExplorer.InvokeRequired Then
            GetContainerExplorer.Invoke(New Delegate_Rename(AddressOf RenameFinished), Result)
        End If

    End Sub

    Private Sub RenameFinished(ByVal Result As SimpleResult)

        Logger.Log("[Info] Rename request finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then

            TaskStatus = ActiveTaskStatus.Completed

        Else

            _TargetDomainObject.Name = OldName
            _ListView.RefreshObject(_TargetDomainObject)

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                MessageType = AlertType.AccessDenied
            End If

            Message = "Failed to rename " & _TargetDomainObject.Name & Environment.NewLine & Result.Message

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
            .StartPosition = FormStartPosition.CenterScreen
            }

            ResultForm.ShowDialog()

        End If

    End Sub

End Class

