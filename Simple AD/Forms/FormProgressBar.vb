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
            If Me.InvokeRequired Then
                Me.Invoke(New Action(Sub() StatusLb.Text = _Status))
            Else
                StatusLb.Text = _Status
            End If
        End Set
        Get
            Return _Status
        End Get
    End Property

    Public Sub New(ByVal Title As String)
        InitializeComponent()
        Text = Title
    End Sub

    Private Sub FormProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MainSpinner.Spinning = True
    End Sub
End Class