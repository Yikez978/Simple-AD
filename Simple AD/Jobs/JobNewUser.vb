

Public Class JobNewUser
    Inherits SimpleADJob

    Private TargetExplorerJob As JobExplorer
    Private TargetContainer As String
    Private TargetPath As String

    Private NewUserForm As FormNewUser

    Public Sub New(ByVal Container As String, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.NewUser
        JobName = "New User"

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
                JobStatus = SimpleADJobStatus.Canceled
            End If

        End If

    End Sub

    Private Sub NewUserObject(ByVal UserObject As UserDomainObject, ByVal Container As String)
        Dim Result As SimpleResult = CreateNewUser(UserObject, Container)

        Debug.WriteLine("[Info] New User Request Finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then
            JobStatus = SimpleADJobStatus.Completed
            TargetExplorerJob.Refresh()
        Else

            Dim Message As String = String.Empty

            If Result.Status = SimpleADJobStatus.AccessDenied Then
                Message = "Access Denied"
            Else
                Message = "An Error occured while trying to create user"
            End If

            Dim ResultForm As FormAlert = New FormAlert("An Error occured while trying to create user", AlertType.ErrorAlert) With {
                .StartPosition = FormStartPosition.CenterScreen
                }

            ResultForm.ShowDialog()

        End If

    End Sub


End Class

