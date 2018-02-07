Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskNewUser
    Inherits ActiveTask

    Private TargetExplorerJob As TaskExplorer
    Private TargetContainer As String
    Private TargetPath As String

    Private NewUserForm As FormNewUser

    Private Delegate Sub Delegate_NewUserObjectFinished(ByVal Result As SimpleResult)

    Public Sub New(ByVal Container As String, ByVal Job As TaskExplorer)
        MyBase.New
        TaskType = ActiveTaskType.NewUser
        TaskName = "New User"

        TargetExplorerJob = Job
        TargetContainer = Container
        TargetPath = GetDirEntryPath() & "/" & Container

        If Not Container Is Nothing Then

            NewUserForm = New FormNewUser

            With NewUserForm
                .ContainerPath = TargetContainer
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

            If NewUserForm.DialogResult = DialogResult.Yes Then
                Threading.ThreadPool.QueueUserWorkItem(Sub() NewUserObject(NewUserForm.User, TargetPath))
            Else
                TaskStatus = ActiveTaskStatus.Canceled
            End If

        End If

    End Sub

    Private Sub NewUserObject(ByVal UserObject As UserDomainObject, ByVal Container As String)
        Dim Result As SimpleResult = CreateNewUser(UserObject, Container)

        If GetContainerExplorer.InvokeRequired Then
            GetContainerExplorer.Invoke(New Delegate_NewUserObjectFinished(AddressOf NewUserObjectFinished), Result)
        End If

    End Sub

    Private Sub NewUserObjectFinished(Result As SimpleResult)

        Debug.WriteLine("[Info] New User Request Finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then
            TaskStatus = ActiveTaskStatus.Completed

            TargetExplorerJob.Refresh(Nothing)
        Else

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                Message = "Unable create a new user object in the seleceted directory, access is denied."
                MessageType = AlertType.AccessDenied
            Else
                Message = "An Error occured while trying to create user"
            End If

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
                .StartPosition = FormStartPosition.CenterScreen
                }

            ResultForm.ShowDialog()

        End If

    End Sub

End Class

