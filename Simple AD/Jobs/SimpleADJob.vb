Public Class SimpleADJob

#Region "Properties"
    Public Property JobName As String
    Public Property JobType As SimpleADJobType
    Public Property JobOwner As String
    Public Property JobCreated As DateTime
    Public Property JobDescription As String

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

    Public Property TaskView As ControlTaskCard

#End Region

    Public Event StatusChanged(ByVal StatusChangedArgs As SimpleADJobStatus)

    Public Sub New(ByVal Type As SimpleADJobType, ByVal Name As String)

        JobType = Type
        JobName = Type.ToString & ": " & Name
        JobOwner = GetDisplayName()
        JobCreated = DateTime.Now

        JobStatus = SimpleADJobStatus.Idle

        CreateJobTaskView()
    End Sub

    Private Sub CreateJobTaskView()
        TaskView = New ControlTaskCard(Me)
    End Sub

End Class
