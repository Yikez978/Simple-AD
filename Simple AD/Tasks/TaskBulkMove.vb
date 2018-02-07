Imports SimpleLib
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class TaskBulkMove
    Inherits ActiveTask

    Private TargetDomainObjects As IList
    Private TargetExplorerJob As TaskExplorer
    Private ObjectErrors As New List(Of DomainObject)

    Public Sub New(ByVal DomainObjects As IList, ByVal Job As TaskExplorer)
        TaskType = ActiveTaskType.BulkMove
        TaskName = "Bulk Delete"
        TaskProgressMax = DomainObjects.Count


        TargetDomainObjects = DomainObjects
        TargetExplorerJob = Job

        If TargetDomainObjects.Count > 1 Then
            MoveBulk()
        End If

    End Sub

    Private Async Sub MoveBulk()

        Dim MoveForm As FormMoveObject = New FormMoveObject
        MoveForm.Location = GetDialogLocation(MoveForm)
        MoveForm.ShowDialog(FormMain)
        If MoveForm.DialogResult = DialogResult.Yes Then

            TaskStatus = ActiveTaskStatus.InProgress
            Dim TargetOU As String = MoveForm.SelecetdOU

            Dim MoveTasks As New List(Of Task)()
            Dim FProgress As FormProgressBar = New FormProgressBar("Deleting Objects") With {.Maximum = TargetDomainObjects.Count - 1, .BarStep = 1}

            If FProgress IsNot Nothing Then
                FProgress.Show()
            Else
                TaskStatus = ActiveTaskStatus.Failed
                Exit Sub
            End If

            For i As Integer = 0 To TargetDomainObjects.Count - 1
                Dim ObjectToMove As DomainObject = DirectCast(TargetDomainObjects(i), DomainObject)
                MoveTasks.Add(Task.Run(Sub() MoveObject(ObjectToMove, FProgress, TargetOU)))
            Next

            Await Task.WhenAll(MoveTasks)

            FProgress.Dispose()

            MoveBulkFinished(TargetOU)
        Else
            TaskStatus = ActiveTaskStatus.Canceled
        End If
    End Sub

    Private Async Sub MoveObject(ByVal DomainObject As DomainObject, FProgress As FormProgressBar, TargetOU As String)

        FProgress.SetStatusText(String.Format("Moving {0}...", DomainObject.Name))

        Dim Result As SimpleResult = MoveADObject(DomainObject, TargetOU)

        If Not Result.IsSuccess Then
            ObjectErrors.Add(DomainObject)
        End If

        JobProgress = JobProgress + 1

        If FProgress IsNot Nothing Then
            FProgress.PerformStep()
        End If

        Await Task.CompletedTask
    End Sub

    Private Sub MoveBulkFinished(ByVal TargetOU As String)

        If Not ObjectErrors.Count > 0 Then
            TaskStatus = ActiveTaskStatus.Completed
            TargetExplorerJob.Refresh(Nothing)
            Dim ResultForm As FormAlert = New FormAlert("Successfully moved the selected Objects to:" & Environment.NewLine & DistToName(TargetOU), AlertType.Success)
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()
        Else

            If ObjectErrors.Count = TargetDomainObjects.Count Then
                TaskStatus = ActiveTaskStatus.Failed
            Else
                TaskStatus = ActiveTaskStatus.Errors
            End If

            TargetExplorerJob.Refresh(Nothing)
            Dim ResultForm As FormAlert = New FormAlert("An Error occured while trying to move objects to:" & Environment.NewLine & DistToName(TargetOU), AlertType.ErrorAlert)
            ResultForm.StartPosition = FormStartPosition.CenterScreen
            ResultForm.ShowDialog()
        End If

    End Sub

    Private Function DistToName(ByVal DistString As String) As String
        Dim sDelimStart As String = "="
        Dim sDelimEnd As String = ","
        Dim nIndexStart As Integer = DistString.IndexOf(sDelimStart)
        Dim nIndexEnd As Integer = DistString.IndexOf(sDelimEnd)

        Return Mid(DistString, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length)
    End Function

End Class
