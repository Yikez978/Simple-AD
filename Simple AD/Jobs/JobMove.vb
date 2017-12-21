Imports System.Runtime.Serialization
Imports System.Security.Permissions

Public Class JobMove
    Inherits SimpleADJob


    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.Move
        JobName = DomainObject.Name

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            
            MoveObject()
        End If

    End Sub

    Private Sub MoveObject()

        Dim MoveForm As FormMoveObject = New FormMoveObject
        MoveForm.StartPosition = FormStartPosition.CenterScreen
        MoveForm.ShowDialog()
        If MoveForm.DialogResult = DialogResult.Yes Then
            If MoveADObject(TargetDomainObject, MoveForm.SelecetdOU) = True Then
                JobStatus = SimpleADJobStatus.Completed
                TargetExplorerJob.Refresh()
                Dim ResultForm As FormAlert = New FormAlert(TargetDomainObject.Name & " has been moved to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.Success) With {.Location = GetDialogLocation(MoveForm)}
                ResultForm.StartPosition = FormStartPosition.CenterScreen
                ResultForm.ShowDialog()
            Else
                JobStatus = SimpleADJobStatus.Failed
                Dim ResultForm As FormAlert = New FormAlert("An Error occured while trying to move " & TargetDomainObject.Name & " to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.ErrorAlert) With {.Location = GetDialogLocation(MoveForm)}
                ResultForm.StartPosition = FormStartPosition.CenterScreen
                ResultForm.ShowDialog()
            End If
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

End Class
