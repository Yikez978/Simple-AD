

Public Class JobDeleteBulk
    Inherits SimpleADJob


    Private TargetDomainObjects As IList
    Private TargetExplorerJob As JobExplorer
    Private ProgressForm As FormProgressBar
    Private ObjectErrors As New List(Of DomainObject)

    Public Sub New(ByVal DomainObjects As IList, ByVal Job As JobExplorer)
        JobType = SimpleADJobType.BulkDelete
        JobName = "Bulk Delete"
        JobProgressMax = DomainObjects.Count
        

        TargetDomainObjects = DomainObjects
        TargetExplorerJob = Job

        If TargetDomainObjects.Count > 1 Then
            ProgressForm = New FormProgressBar("Deleting Objects") With {.Maximum = TargetDomainObjects.Count - 1, .BarStep = 1}
            DeleteBulk()
        End If

    End Sub

    Private Async Sub DeleteBulk()

        Dim DeleteForm As FormConfirmation = New FormConfirmation("Are you sure you wish to delete " & TargetDomainObjects.Count & " objects?", ConfirmationType.Delete)
        DeleteForm.Location = GetDialogLocation(DeleteForm)
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then

            JobStatus = SimpleADJobStatus.InProgress

            Dim DeleteTasks As New List(Of Task)()

            For i As Integer = 0 To TargetDomainObjects.Count - 1
                Dim ObjectToDelete As DomainObject = DirectCast(TargetDomainObjects(i), DomainObject)
                DeleteTasks.Add(Task.Run(Sub() DeleteObject(ObjectToDelete)))
            Next

            ProgressForm.Show()

            Await Task.WhenAll(DeleteTasks)

            DeletBulkFinished()
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

    Private Async Sub DeleteObject(ByVal DomainObject As DomainObject)

        ProgressForm.SetStatusText(String.Format("Deleting {0}...", DomainObject.Name))

        If Not DeleteADObject(DomainObject) Then
            ObjectErrors.Add(DomainObject)
        End If

        JobProgress = JobProgress + 1

        If ProgressForm IsNot Nothing Then
            ProgressForm.PerformStep()
        End If

        Await Task.CompletedTask
    End Sub

    Private Sub DeletBulkFinished()

        ProgressForm.Dispose()

        If Not ObjectErrors.Count > 0 Then
            TargetExplorerJob.Refresh()
            JobStatus = SimpleADJobStatus.Completed

            Dim ResultForm As FormAlert = New FormAlert("Deleted the selected objects", AlertType.Success) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()

        Else
            TargetExplorerJob.Refresh()

            If ObjectErrors.Count = TargetDomainObjects.Count Then
                JobStatus = SimpleADJobStatus.Failed
            Else
                JobStatus = SimpleADJobStatus.Errors
            End If

            Dim ResultForm As FormAlert = New FormAlert("Failed to Delete " & ObjectErrors.Count & " Objects", AlertType.ErrorAlert) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.ShowDialog()
        End If

    End Sub

End Class
