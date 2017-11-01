Imports SimpleLib
Imports System.Runtime.Serialization
Imports System.Security.Permissions

<Serializable()>
Public MustInherit Class SimpleADJob
    Implements ISerializable

#Region "Properties"
    Public Property JobName As String
    Public Property JobType As SimpleADJobType
    Public Property JobOwner As String
    Public Property JobCreated As DateTime
    Public Property JobDescription As String
    Public Property JobProgressMax As Integer

    Private JobStatusValue As SimpleADJobStatus
    Public Property JobStatus As SimpleADJobStatus
        Set(value As SimpleADJobStatus)
            JobStatusValue = value
            RaiseEvent StatusChanged(JobStatusValue)
        End Set
        Get
            Return JobStatusValue
        End Get
    End Property

    Private JobProgressValue As Integer
    Public Property JobProgress As Integer
        Set(value As Integer)
            JobProgressValue = value
            RaiseEvent ProgressChanged()
        End Set
        Get
            Return JobProgressValue
        End Get
    End Property

    Public Property TaskView As ControlTaskCard
#End Region

    Public Event StatusChanged(ByVal StatusChangedArgs As SimpleADJobStatus)
    Public Event ProgressChanged()

    Public Sub New()
        JobOwner = GetDisplayName()
        JobCreated = DateTime.Now
        JobStatus = SimpleADJobStatus.Idle
    End Sub

#Region "Serialisation"
    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        JobName = info.GetString("JobName")
        JobType = DirectCast([Enum].Parse(GetType(SimpleADJobType), info.GetString("JobType")), SimpleADJobType)
        JobOwner = info.GetString("JobOwner")
        JobCreated = info.GetDateTime("JobCreated")
        JobDescription = info.GetString("JobDescription")
        JobStatus = DirectCast([Enum].Parse(GetType(SimpleADJobStatus), info.GetString("JobStatus")), SimpleADJobStatus)
        JobProgress = info.GetInt32("JobProgress")
        JobProgressMax = info.GetInt32("JobProgressMax")
    End Sub

    <SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    Public Overridable Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("JobName", JobName)
        info.AddValue("JobType", JobType.ToString)
        info.AddValue("JobOwner", JobOwner)
        info.AddValue("JobCreated", JobCreated)
        info.AddValue("JobDescription", JobDescription)
        info.AddValue("JobStatus", JobStatus)
        info.AddValue("JobProgress", JobProgress)
        info.AddValue("JobProgressMax", JobProgressMax)
    End Sub
#End Region

End Class
