Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports SimpleLib

Public Class TaskPing
    Inherits TaskBase

    Private _TargetComputer As ComputerDomainObject

    Private WithEvents _PingForm As FormPing

    Private _PingTask As Task
    Private _PingSender As Ping
    Private _FormClosed As Boolean

    Private _CancellationSource As CancellationTokenSource

    Private Delegate Sub Delegate_PingComputer()

    Private Delegate Sub Delegate_WritetoList(ByVal Type As PingMessageType, ByVal message As String)
    Private Delegate Sub Delegate_WritetoListItem(ByVal Item As PingListItem)

    Public Property PingCount As Integer
    Public Property PingCountMax As Integer
    Public Property IsRunning As Boolean
    Public Property IsCanceled As Boolean

    Public Property PingInterval As Integer = 1000

    Public Enum PingMessageType
        Info = 0
        Response = 1
        Canceled = 2
        Err = 3
    End Enum

    Public Sub New(ByVal ComputerObject As ComputerDomainObject)
        MyBase.New

        If ComputerObject Is Nothing Then
            Return
        End If

        TaskType = ActiveTaskType.Ping
        TaskName = "Ping"

        _TargetComputer = ComputerObject

        PingCount = 0
        PingCountMax = 4

        _PingForm = New FormPing(Me, ComputerObject)

        AddHandler _PingForm.FormClosed, AddressOf PingFormClosed

        With _PingForm
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With

        _PingForm.MainListView.SetObjects(New List(Of PingListItem))

    End Sub

    Public Sub SendPing()

        _PingForm.ProgressBar.Style = ProgressBarStyle.Marquee

        _CancellationSource = New CancellationTokenSource

        IsRunning = True
        TaskStatus = TaskStatus.InProgress

        _PingTask = Task.Run(Sub() PingComputer(_TargetComputer, _CancellationSource.Token))
    End Sub

    Private Sub PingComputer(ByVal TargetComputer As ComputerDomainObject, Ct As CancellationToken)

        If Ct.IsCancellationRequested Then
            OutList(PingMessageType.Canceled, "Ping Canceled")
            Exit Sub
        End If

        _PingSender = New Ping()

        AddHandler _PingSender.PingCompleted, AddressOf PingCompletedCallback

        Dim Data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer As Byte() = Encoding.ASCII.GetBytes(Data)

        Dim Timeout As Integer = 8000

        Dim Options As PingOptions = New PingOptions(64, True)

        _PingSender.SendAsync(TargetComputer.Name, Timeout, buffer, Options, Nothing)

    End Sub

    Private Sub PingCompletedCallback(Sender As Object, e As PingCompletedEventArgs)

        If _FormClosed Then
            Exit Sub
        End If

        If e.Cancelled Then
            OutList(PingMessageType.Canceled, "Ping Canceled")
        End If

        If e.Error IsNot Nothing Then

            Dim ErrMessage As String = String.Empty

            Dim ErrType As Type = e.Error.GetBaseException.GetType()

            If ErrType = GetType(Net.Sockets.SocketException) Then
                ErrMessage = String.Format("Host '{0}' not found", _TargetComputer.Name)
            Else
                ErrMessage = e.Error.Message
            End If

            OutList(PingMessageType.Err, "Ping Failed")
            OutList(PingMessageType.Err, ErrMessage)

        End If

        If e.Reply Is Nothing Then

            PingCount = PingCountMax
            _PingForm.Invoke(New Delegate_PingComputer(AddressOf PingComputerFinished))

            Exit Sub
        End If

        If Not e.Reply.Status = IPStatus.Success Then
            OutList(PingMessageType.Err, e.Reply.Status.ToString)

            PingCount = PingCountMax
            _PingForm.Invoke(New Delegate_PingComputer(AddressOf PingComputerFinished))

            Exit Sub
        End If

        Dim Responce As PingListItem = Nothing

        If e.Reply.Address IsNot Nothing Then
            Responce = New PingListItem With {
            .Type = PingMessageType.Response,
            .Address = e.Reply.Address.ToString,
            .BufferSize = e.Reply.Buffer.Length,
            .RoundTripTime = e.Reply.RoundtripTime,
            .TimeToLive = If(e.Reply.Options IsNot Nothing, e.Reply.Options.Ttl, 0),
            .Message = " - Responce"
            }
        End If

        If Responce Is Nothing Then
            Exit Sub
        End If

        OutList(Responce)

        If Not IsCanceled Then

            Thread.Sleep(PingInterval)
            PingCount += 1

            If IsCanceled Then
                Exit Sub
            Else
                PingComputerFinished()
            End If

        End If

    End Sub

    Private Sub PingComputerFinished()

        If _FormClosed Then
            Exit Sub
        End If

        If _PingForm.InvokeRequired Then
            _PingForm.Invoke(New Action(AddressOf PingComputerFinished))
        Else

            IsRunning = False

            If IsCanceled Then
                Exit Sub
            End If

            If TaskStatus = TaskStatus.Canceled Then

                If _PingForm IsNot Nothing Or (Not _PingForm.IsDisposed) Then
                    OutList(PingMessageType.Canceled, "Ping Canceled")

                    _PingForm.ToggleButtons()
                    _PingForm.ProgressBar.Value = 0
                    _PingForm.ProgressBar.Style = ProgressBarStyle.Blocks
                End If

                Exit Sub
            End If

            TaskStatus = TaskStatus.Idle

            If PingCount < PingCountMax Or PingCountMax = -1 Then

                IsRunning = True

                _PingTask = Task.Run(Sub() PingComputer(_TargetComputer, _CancellationSource.Token))

            Else

                PingCount = 0

                OutList(PingMessageType.Info, "Ping Completed")

                _PingForm.ToggleButtons()
                _PingForm.ProgressBar.Value = 0
                _PingForm.ProgressBar.Style = ProgressBarStyle.Blocks
            End If
        End If
    End Sub

    Private Sub PingFormClosed()

        _FormClosed = True

        Cancel()

        _PingForm.Dispose()

    End Sub

    Public Overrides Sub Cancel()
        MyBase.Cancel()

        _PingSender.SendAsyncCancel()
        _CancellationSource.Cancel()

        TaskStatus = TaskStatus.Canceled
    End Sub

    Private Sub OutList(ByVal Item As PingListItem)
        If Not IsCanceled Then
            _PingForm.WritetoList(Item)
        End If
    End Sub

    Private Sub OutList(ByVal Type As PingMessageType, ByVal message As String)
        If Not IsCanceled Then
            _PingForm.WritetoList(Type, message)
        End If
    End Sub

End Class


