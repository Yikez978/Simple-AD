Public Class JobEnableDisable
    Inherits SimpleADJob

    Private TargetDomainObject As UserDomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New(SimpleADJobType.EnableDisable, DomainObject.Name)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            EnableDisableObject()
        End If

    End Sub

    Private Sub EnableDisableObject()

        Try
            If IsAccountEnabled(TargetDomainObject) Then
                Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(TargetDomainObject)
                If Not IsEnableAccountSuccessfull = Nothing Then
                    TargetExplorerJob.Refresh()
                End If
            Else
                Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(TargetDomainObject)
                If Not IsDisnableAccountSuccessfull = Nothing Then
                    TargetExplorerJob.Refresh()
                End If
            End If
        Catch Ex As Exception
            JobStatus = SimpleADJobStatus.Failed
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try

    End Sub

End Class
