Public Class JobRename
    Inherits SimpleADJob

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New(SimpleADJobType.Rename, DomainObject.Name)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            RenameObject()
        End If

    End Sub

    Private Sub RenameObject()

    End Sub

End Class

