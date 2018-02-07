Imports SimpleLib
Imports SimpleLib.Enums

Public MustInherit Class ActiveTask

#Region "Properties"
    Public Property TaskName As String
    Public Property TaskType As ActiveTaskType
    Public Property TaskOwner As String
    Public Property TaskCreated As DateTime
    Public Property TaskDescription As String
    Public Property TaskProgressMax As Integer
    Public Property TaskErrors As List(Of String)

    Private ActiveTaskStatusValue As ActiveTaskStatus
    Public Property TaskStatus As ActiveTaskStatus
        Set(value As ActiveTaskStatus)
            ActiveTaskStatusValue = value

            If TaskStatus = ActiveTaskStatus.Canceled Or TaskStatus = ActiveTaskStatus.Completed Or TaskStatus = ActiveTaskStatus.Failed Then
                If TaskPool.Pool.Contains(Me) Then
                    TaskPool.Pool.Remove(Me)
                End If
            End If

            RaiseEvent StatusChanged(ActiveTaskStatusValue)
        End Set
        Get
            Return ActiveTaskStatusValue
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

    Private StatusMessageValue As String
    Public Property StatusMessage As String
        Set(value As String)
            StatusMessageValue = value
            RaiseEvent StatusMessageChanged(value)
        End Set
        Get
            Return StatusMessageValue
        End Get
    End Property


#End Region

    Public Event StatusChanged(ByVal StatusChangedArgs As ActiveTaskStatus)
    Public Event ProgressChanged()
    Public Event StatusMessageChanged(ByVal Message As String)

    Public Sub New()
        TaskOwner = ActiveDirectoryHelper.GetDisplayName()
        TaskCreated = DateTime.Now
        TaskStatus = ActiveTaskStatus.Idle

        If TaskType.ToString.Contains("Bulk") Then
            'TaskPool.Pool.Add(Me)
        End If

    End Sub

    Public Overridable Sub Cancel()
        TaskStatus = ActiveTaskStatus.Canceled
    End Sub


End Class

Public Class ProgressChangedEventArgs

    Public Sub New(ByVal S As String, ByVal DT As DateTime)
        MyBase.New()
    End Sub

End Class
