
Imports System.Runtime.Serialization
Imports System.Security.Permissions
Imports SimpleLib

<Serializable()>
Public Class JobRename
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.Rename
        JobName = DomainObject.Name
        NewTask(Me)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            RenameObject()
        End If

    End Sub

    Private Sub RenameObject()

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

