Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports SimpleLib

Public Class TaskBulkDelete
    Inherits TaskBase

    Private TargetDomainObjects As IList
    Private HostExplorerTask As TaskExplorer

    Private Results As New List(Of SimpleResult)
    Private FailedObjects As New List(Of DomainObject)

    Public Sub New(ByVal DomainObjects As IList, ByVal Job As TaskExplorer)
        TaskType = ActiveTaskType.BulkDelete
        TaskName = "Bulk Delete"
        TaskProgressMax = DomainObjects.Count


        TargetDomainObjects = DomainObjects
        HostExplorerTask = Job

        If TargetDomainObjects.Count > 1 Then
            DeleteBulk()
        End If

    End Sub

    Private Async Sub DeleteBulk()

        Dim DeleteForm As FormConfirmation = New FormConfirmation("Are you sure you wish to delete " & TargetDomainObjects.Count & " objects?", ConfirmationType.Delete)
        DeleteForm.ShowDialog()

        If DeleteForm.DialogResult = DialogResult.Yes Then

            TaskStatus = ActiveTaskStatus.InProgress

            Dim DeleteTasks As New List(Of Task)()
            Dim FProgress As FormProgressBar = New FormProgressBar("Deleting Objects") With {.Maximum = TargetDomainObjects.Count - 1, .BarStep = 1}

            If FProgress IsNot Nothing Then
                FProgress.Show()
            Else
                TaskStatus = ActiveTaskStatus.Failed
                Exit Sub
            End If

            For i As Integer = 0 To TargetDomainObjects.Count - 1
                Dim ObjectToDelete As DomainObject = DirectCast(TargetDomainObjects(i), DomainObject)
                DeleteTasks.Add(Task.Run(Sub() DeleteObject(ObjectToDelete, FProgress)))
            Next

            Await Task.WhenAll(DeleteTasks)

            FProgress.Dispose()

            DeletBulkFinished()
        Else
            TaskStatus = ActiveTaskStatus.Canceled
        End If

    End Sub

    Private Async Sub DeleteObject(ByVal ObjectToDelete As DomainObject, FProgress As FormProgressBar)

        FProgress.SetStatusText(String.Format("Deleting {0}...", ObjectToDelete.Name))

        Dim ObjectResult As SimpleResult = DeleteADObject(ObjectToDelete)
        Results.Add(ObjectResult)

        If Not ObjectResult.IsSuccess Then
            FailedObjects.Add(ObjectToDelete)
        End If

        JobProgress = JobProgress + 1

        If FProgress IsNot Nothing Then
            FProgress.PerformStep()
        End If

        Await Task.CompletedTask
    End Sub

    Private Sub DeletBulkFinished()

        If Not FailedObjects.Count > 0 Then
            HostExplorerTask.Refresh()
            TaskStatus = ActiveTaskStatus.Completed

            Dim ResultForm As FormAlert = New FormAlert("Deleted the selected objects", AlertType.Success) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()

        Else
            HostExplorerTask.Refresh()

            If FailedObjects.Count = TargetDomainObjects.Count Then
                TaskStatus = ActiveTaskStatus.Failed
            Else
                TaskStatus = ActiveTaskStatus.Errors
            End If

            Dim ResultForm As FormAlert = New FormAlert("Failed to Delete " & FailedObjects.Count & " Objects", AlertType.ErrorAlert) With {.Location = GetDialogLocation(FormMain)}
            ResultForm.ShowDialog()
        End If

    End Sub

End Class
