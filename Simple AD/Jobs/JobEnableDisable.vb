

Public Class JobEnableDisable
    Inherits SimpleADJob

    Private TargetDomainObject As UserDomainObject
    Private TargetExplorerJob As JobExplorer
    Private TargetObjectState As Boolean

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer, ByVal ObjectState As Boolean)
        MyBase.New
        JobType = SimpleADJobType.EnableDisable
        JobName = DomainObject.Name
        

        TargetDomainObject = DirectCast(DomainObject, UserDomainObject)
        TargetExplorerJob = Job
        TargetObjectState = ObjectState

        If Not TargetDomainObject Is Nothing Then
            Threading.ThreadPool.QueueUserWorkItem(Sub() EnableDisableObject())
        End If

    End Sub

    Private Sub EnableDisableObject()
        Try
            If TargetObjectState Then
                If EnableADUserUsingUserAccountControl(TargetDomainObject) Then
                    GetMainListView.RefreshObject(TargetDomainObject)
                End If
            Else
                If DisableADUserUsingUserAccountControl(TargetDomainObject) Then
                    GetMainListView.RefreshObject(TargetDomainObject)
                End If
            End If

            JobStatus = SimpleADJobStatus.Completed

        Catch AccessDenideEx As UnauthorizedAccessException
            JobStatus = SimpleADJobStatus.AccessDenied

            Dim ErrorDialog As FormAlert = New FormAlert("Access Denied", AlertType.ErrorAlert)
            ErrorDialog.Location = GetDialogLocation(ErrorDialog)
            FormMain.Invoke(Sub() ErrorDialog.ShowDialog())
        Catch Ex As Exception
            JobStatus = SimpleADJobStatus.Failed
            Debug.WriteLine("[Error] Unable to Disable User account though userAccountControl property: " & Ex.Message)
        End Try

    End Sub

End Class
