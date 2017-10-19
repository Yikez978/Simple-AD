Public Class JobMove
    Inherits SimpleADJob

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New(SimpleADJobType.Move, DomainObject.Name)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            MoveObject()
        End If

    End Sub

    Private Sub MoveObject()

        Dim MoveForm = New FormMoveObject
        MoveForm.Location = GetDialogLocation(MoveForm)
        MoveForm.ShowDialog()
        If MoveForm.DialogResult = DialogResult.Yes Then
            If MoveADObject(TargetDomainObject, MoveForm.SelecetdOU) = True Then
                TargetExplorerJob.Refresh()
                Dim ResultForm = New FormAlert(TargetDomainObject.Name & " has been moved to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.Success)
                ResultForm.Location = GetDialogLocation(MoveForm)
                ResultForm.ShowDialog()
            Else
                JobStatus = SimpleADJobStatus.Failed
                Dim ResultForm = New FormAlert("An Error occured while trying to move " & TargetDomainObject.Name & " to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.ErrorAlert)
                ResultForm.Location = GetDialogLocation(MoveForm)
                ResultForm.ShowDialog()
            End If
        End If

    End Sub

End Class
