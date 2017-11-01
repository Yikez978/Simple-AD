﻿Imports System.Runtime.Serialization
Imports System.Security.Permissions
Imports SimpleLib

<Serializable()>
Public Class JobMoveBulk
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetDomainObjects As IList
    Private TargetExplorerJob As JobExplorer

    Private TargetOU As String
    Private ObjectErrors As New List(Of DomainObject)

    Public Sub New(ByVal DomainObjects As IList, ByVal Job As JobExplorer)
        JobType = SimpleADJobType.BulkMove
        JobName = "Bulk Delete"
        JobProgressMax = DomainObjects.Count
        NewTask(Me)

        TargetDomainObjects = DomainObjects
        TargetExplorerJob = Job

        If TargetDomainObjects.Count > 1 Then
            MoveBulk()
        End If

    End Sub

    Private Async Sub MoveBulk()

        Dim MoveForm = New FormMoveObject
        MoveForm.Location = GetDialogLocation(MoveForm)
        MoveForm.ShowDialog(FormMain)
        If MoveForm.DialogResult = DialogResult.Yes Then

            JobStatus = SimpleADJobStatus.InProgress
            TargetOU = MoveForm.SelecetdOU

            Dim MoveTasks As New List(Of Task)()

            For i As Integer = 0 To TargetDomainObjects.Count - 1
                Dim ObjectToMove As DomainObject = DirectCast(TargetDomainObjects(i), DomainObject)
                MoveTasks.Add(Task.Run(Sub() MoveObject(ObjectToMove)))
            Next

            Await Task.WhenAll(MoveTasks)

            MoveBulkFinished()
        Else

            JobStatus = SimpleADJobStatus.Canceled

        End If
    End Sub

    Private Async Sub MoveObject(ByVal DomainObject As DomainObject)

        If Not MoveADObject(DomainObject, TargetOU) = True Then
            ObjectErrors.Add(DomainObject)
        End If

        JobProgress = JobProgress + 1

        Await Task.CompletedTask
    End Sub

    Private Sub MoveBulkFinished()

        If Not ObjectErrors.Count > 0 Then
            JobStatus = SimpleADJobStatus.Completed
            TargetExplorerJob.Refresh()
            Dim ResultForm = New FormAlert("Moved Selected Objects to:" & Environment.NewLine & TargetOU, AlertType.Success)
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()
        Else

            If ObjectErrors.Count = TargetDomainObjects.Count Then
                JobStatus = SimpleADJobStatus.Failed
            Else
                JobStatus = SimpleADJobStatus.Errors
            End If

            TargetExplorerJob.Refresh()
            Dim ResultForm = New FormAlert("An Error occured while trying to move objects to:" & Environment.NewLine & TargetOU, AlertType.ErrorAlert)
            ResultForm.StartPosition = FormStartPosition.CenterScreen
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