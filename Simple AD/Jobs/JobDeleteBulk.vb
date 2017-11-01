Imports SimpleLib
Imports System.Runtime.Serialization
Imports System.Security.Permissions
Imports System.Threading

<Serializable()>
Public Class JobDeleteBulk
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetDomainObjects As IList
    Private TargetExplorerJob As JobExplorer

    Private ObjectErrors As New List(Of DomainObject)

    Public Sub New(ByVal DomainObjects As IList, ByVal Job As JobExplorer)
        JobType = SimpleADJobType.BulkDelete
        JobName = "Bulk Delete"
        JobProgressMax = DomainObjects.Count
        NewTask(Me)

        TargetDomainObjects = DomainObjects
        TargetExplorerJob = Job

        If TargetDomainObjects.Count > 1 Then
            DeleteBulk()
        End If

    End Sub

    Private Async Sub DeleteBulk()

        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & TargetDomainObjects.Count & " objects?", ConfirmationType.Delete)
        DeleteForm.Location = GetDialogLocation(DeleteForm)
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then

            JobStatus = SimpleADJobStatus.InProgress

            Dim DeleteTasks As New List(Of Task)()

            For i As Integer = 0 To TargetDomainObjects.Count - 1
                Dim ObjectToDelete As DomainObject = DirectCast(TargetDomainObjects(i), DomainObject)
                DeleteTasks.Add(Task.Run(Sub() DeleteObject(ObjectToDelete)))
            Next

            Await Task.WhenAll(DeleteTasks)

            DeletBulkFinished()
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

    Private Async Sub DeleteObject(ByVal DomainObject As DomainObject)

        If Not DeleteADObject(DomainObject) Then
            ObjectErrors.Add(DomainObject)
        End If

        JobProgress = JobProgress + 1

        Await Task.CompletedTask
    End Sub

    Private Sub DeletBulkFinished()

        If Not ObjectErrors.Count > 0 Then
            TargetExplorerJob.Refresh()
            JobStatus = SimpleADJobStatus.Completed

            Dim ResultForm = New FormAlert("Deleted the selected objects", AlertType.Success) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()

        Else
            TargetExplorerJob.Refresh()

            If ObjectErrors.Count = TargetDomainObjects.Count Then
                JobStatus = SimpleADJobStatus.Failed
            Else
                JobStatus = SimpleADJobStatus.Errors
            End If

            Dim ResultForm = New FormAlert("Failed to Delete " & ObjectErrors.Count & " Objects", AlertType.ErrorAlert) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.ShowDialog()
        End If

    End Sub

#Region "Serialisation"
    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        JobName = info.GetString("JobName")
        JobType = DirectCast([Enum].Parse(GetType(SimpleADJobType), info.GetString("JobType")), SimpleADJobType)
        JobOwner = info.GetString("JobOwner")
        JobCreated = info.GetDateTime("JobCreated")
        JobDescription = info.GetString("JobDescription")
        JobStatus = DirectCast([Enum].Parse(GetType(SimpleADJobStatus), info.GetString("JobStatus")), SimpleADJobStatus)
        JobProgress = info.GetInt32("JobProgress")
        JobProgressMax = info.GetInt32("JobProgressMax")
    End Sub

    <SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("JobName", JobName)
        info.AddValue("JobType", JobType.ToString)
        info.AddValue("JobOwner", JobOwner)
        info.AddValue("JobCreated", JobCreated)
        info.AddValue("JobDescription", JobDescription)
        info.AddValue("JobStatus", JobStatus)
        info.AddValue("JobProgress", JobProgress)
        info.AddValue("JobProgressMax", JobProgressMax)
    End Sub
#End Region

End Class
