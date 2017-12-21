Imports System.Runtime.Serialization
Imports System.Security.Permissions


Public Class JobEnableDisableBulk
    Inherits SimpleADJob


    Private TargetDomainObjects As IList
    Private TargetExplorerJob As JobExplorer
    Private TargetObjectState As Boolean

    Private ObjectErrors As New List(Of DomainObject)

    Public Sub New(ByVal DomainObjects As IList, ByVal Job As JobExplorer, ByVal ObjectState As Boolean)
        JobType = SimpleADJobType.BulkEnableDisable
        JobName = "Bulk Enable Disabled"
        JobProgressMax = DomainObjects.Count
        

        TargetDomainObjects = DomainObjects
        TargetExplorerJob = Job
        TargetObjectState = ObjectState

        If TargetDomainObjects.Count > 1 Then
            ProccessObjects()
        End If

    End Sub

    Private Async Sub ProccessObjects()

        Dim InnerText As String = String.Empty

        If TargetObjectState Then
            InnerText = "Enable"
        Else
            InnerText = "Disable"
        End If

        Dim ConfirmationForm As FormConfirmation = New FormConfirmation("Are you sure you wish to " & InnerText & " " & TargetDomainObjects.Count & " objects?", ConfirmationType.Warning)
        ConfirmationForm.ShowDialog()
        If ConfirmationForm.DialogResult = DialogResult.Yes Then

            JobStatus = SimpleADJobStatus.InProgress

            Dim JobTasks As New List(Of Task)()

            For i As Integer = 0 To TargetDomainObjects.Count - 1
                Dim TargetObject As DomainObject = DirectCast(TargetDomainObjects(i), DomainObject)
                JobTasks.Add(Task.Run(Sub() ProccessObject(TargetObject, TargetObjectState)))
            Next

            Await Task.WhenAll(JobTasks)

            TasksFinished()
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

    Private Async Sub ProccessObject(ByVal DomainObject As DomainObject, ByVal State As Boolean)

        If State Then
            If Not EnableADUserUsingUserAccountControl(DomainObject) Then
                ObjectErrors.Add(DomainObject)
            End If
        Else
            If Not DisableADUserUsingUserAccountControl(DomainObject) Then
                ObjectErrors.Add(DomainObject)
            End If
        End If

        JobProgress = JobProgress + 1

        Await Task.CompletedTask
    End Sub

    Private Sub TasksFinished()

        If Not ObjectErrors.Count > 0 Then
            TargetExplorerJob.Refresh()
            JobStatus = SimpleADJobStatus.Completed

            Dim ResultForm As FormAlert = New FormAlert("Success", AlertType.Success) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()

        Else
            TargetExplorerJob.Refresh()

            If ObjectErrors.Count = TargetDomainObjects.Count Then
                JobStatus = SimpleADJobStatus.Failed
            Else
                JobStatus = SimpleADJobStatus.Errors
            End If

            Dim InnerText As String = String.Empty

            If TargetObjectState Then
                InnerText = "Enable"
            Else
                InnerText = "Disable"
            End If

            Dim ResultForm As FormAlert = New FormAlert("Failed to " & InnerText & " " & ObjectErrors.Count & " of " & TargetDomainObjects.Count & " Objects", AlertType.ErrorAlert)
            ResultForm.ShowDialog()
        End If

    End Sub

End Class
