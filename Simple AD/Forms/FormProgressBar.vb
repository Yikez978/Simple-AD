Imports System.ComponentModel

Public Class FormProgressBar

    Private _Status As String

    Public Property Maximum As Integer
        Set(value As Integer)
            Me.MainProgressBar.Maximum = value
        End Set
        Get
            Return Me.MainProgressBar.Maximum
        End Get
    End Property

    Public Property BarStep As Integer
        Set(value As Integer)
            Me.MainProgressBar.Step = value
        End Set
        Get
            Return Me.MainProgressBar.Step
        End Get
    End Property

    Public Property Status As String
        Set(value As String)
            _Status = value
        End Set
        Get
            Return _Status
        End Get
    End Property

    Public Sub New(ByVal Title As String)
        InitializeComponent()
        Text = Title
    End Sub

    Public Sub SetStatusText(ByVal Status As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String)(AddressOf SetStatusText), Status)
        Else
            StatusLb.Text = Status
        End If
    End Sub

    Public Sub PerformStep()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf PerformStep))
        Else
            MainProgressBar.PerformStep()
            TaskBarProgress.SetValue(Me.Handle, MainProgressBar.Value, Maximum)
        End If
    End Sub

    Private Sub FormProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MainSpinner.Spinning = True
        TaskBarProgress.SetState(Me.Handle, TaskbarStates.Normal)
    End Sub

    Private Sub FormProgressBar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TaskBarProgress.SetState(Me.Handle, TaskbarStates.NoProgress)
    End Sub
End Class