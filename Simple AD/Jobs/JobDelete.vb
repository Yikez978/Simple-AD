

Public Class JobDelete
    Inherits SimpleADJob

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        JobType = SimpleADJobType.Delete
        JobName = DomainObject.Name


        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            DeleteObject()
        End If

    End Sub

    Private Sub DeleteObject()

        Dim DeleteForm As FormConfirmation = New FormConfirmation("Are you sure you wish to delete " & TargetDomainObject.Name & "?", ConfirmationType.Delete) With {
            .StartPosition = FormStartPosition.CenterScreen
        }

        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then
            If DeleteADObject(TargetDomainObject) Then
                JobStatus = SimpleADJobStatus.Completed
                TargetExplorerJob.Refresh()
            Else
                JobStatus = SimpleADJobStatus.Failed
            End If
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

End Class
