Imports SimpleLib.SystemHelper

Public Class FormProgressBar

    Private _Status As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property Maximum As Integer
        Set(value As Integer)
            MainProgressBar.Maximum = value
        End Set
        Get
            Return MainProgressBar.Maximum
        End Get
    End Property

    Public Property BarStep As Integer
        Set(value As Integer)
            MainProgressBar.Step = value
        End Set
        Get
            Return MainProgressBar.Step
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

    Public Sub New(ByVal Title As String, Optional IsMarquee As Boolean = False)
        InitializeComponent()
        Text = Title

        If IsMarquee Then
            MainProgressBar.Style = Windows.Forms.ProgressBarStyle.Marquee
        End If

    End Sub

    Public Sub SetStatusText(ByVal Status As String)
        If InvokeRequired Then
            BeginInvoke(New Action(Of String)(AddressOf SetStatusText), Status)
        Else
            StatusLb.Text = Status
        End If
    End Sub

    Public Sub PerformStep()
        If InvokeRequired Then
            BeginInvoke(New Action(AddressOf PerformStep))
        Else
            MainProgressBar.PerformStep()
            SetValue(Handle, MainProgressBar.Value, Maximum)

            If MainProgressBar.Value > (Maximum - 1) Then
                SetState(FormMain.Handle, TaskbarStates.NoProgress)
            End If

        End If
    End Sub

    Private Sub FormProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If InvokeRequired Then
            BeginInvoke(New Action(Of Object, EventArgs)(AddressOf FormProgressBar_Load), sender, e)
        Else
            SetState(Handle, TaskbarStates.Normal)
        End If
    End Sub

End Class