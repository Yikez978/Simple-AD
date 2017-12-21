

Public MustInherit Class SimpleADJob

#Region "Properties"
    Public Property JobName As String
    Public Property JobType As SimpleADJobType
    Public Property JobOwner As String
    Public Property JobCreated As DateTime
    Public Property JobDescription As String
    Public Property JobProgressMax As Integer
    Public Property JobErrors As List(Of String)

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

#End Region

    Public Event StatusChanged(ByVal StatusChangedArgs As SimpleADJobStatus)
    Public Event ProgressChanged()

    Public Sub New()
        JobOwner = GetDisplayName()
        JobCreated = DateTime.Now
        JobStatus = SimpleADJobStatus.Idle
    End Sub

    Public Overridable Sub Cancel()
        JobStatus = SimpleADJobStatus.Canceled
    End Sub


End Class

Public Class ProgressChangedEventArgs

    Public Sub New(ByVal S As String, ByVal DT As DateTime)
        MyBase.New()
    End Sub

End Class
