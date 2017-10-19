Public Class JobDelete
    Inherits SimpleADJob

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New(SimpleADJobType.Delete, DomainObject.Name)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            DeleteObject()
        End If

    End Sub

    Private Sub DeleteObject()

        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & TargetDomainObject.Name & "?", ConfirmationType.Delete)
        DeleteForm.Location = GetDialogLocation(DeleteForm)
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then
            If DeleteADObject(TargetDomainObject) Then
                TargetExplorerJob.Refresh()
            End If
        End If

    End Sub

End Class
