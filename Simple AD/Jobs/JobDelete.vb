Imports SimpleLib
Imports System.Runtime.Serialization
Imports System.Security.Permissions

<Serializable()>
Public Class JobDelete
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        JobType = SimpleADJobType.Delete
        JobName = DomainObject.Name
        NewTask(Me)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            DeleteObject()
        End If

    End Sub

    Private Sub DeleteObject()

        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & TargetDomainObject.Name & "?", ConfirmationType.Delete) With {
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

#Region "Serialisation"
    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        JobName = info.GetString("JobName")
        JobType = DirectCast([Enum].Parse(GetType(SimpleADJobType), info.GetString("JobType")), SimpleADJobType)
        JobOwner = info.GetString("JobOwner")
        JobCreated = info.GetDateTime("JobCreated")
        JobDescription = info.GetString("JobDescription")
        JobStatus = DirectCast([Enum].Parse(GetType(SimpleADJobStatus), info.GetString("JobStatus")), SimpleADJobStatus)
    End Sub

    <SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("JobName", JobName)
        info.AddValue("JobType", JobType.ToString)
        info.AddValue("JobOwner", JobOwner)
        info.AddValue("JobCreated", JobCreated)
        info.AddValue("JobDescription", JobDescription)
        info.AddValue("JobStatus", JobStatus)
    End Sub
#End Region
End Class
