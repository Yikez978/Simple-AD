Public Class ControlTaskCard

#Region "Properties"
    Private _TaskName
    Public Property TaskName As String
        Set(value As String)
            _TaskName = value
            NameLb.Text = _TaskName
        End Set
        Get
            Return _TaskName
        End Get
    End Property

    Private _TaskDescription
    Public Property TaskDescription As String
        Set(value As String)
            _TaskDescription = value
            DescritptionLb.Text = _TaskDescription
        End Set
        Get
            Return _TaskDescription
        End Get
    End Property

    Private WithEvents HostJob As SimpleADJob
#End Region

    Public Sub New(ByVal Job As SimpleADJob)

        InitializeComponent()

        HostJob = Job

        TaskName = HostJob.JobName
        TaskDescription = HostJob.JobOwner & " | " & HostJob.JobCreated

        UpdateStatus(Job.JobStatus)

        Me.Dock = DockStyle.Top

        For Each Control As Control In Me.Controls
            AddHandler Control.MouseEnter, AddressOf ControlTaskCard_MouseEnter
            AddHandler Control.MouseLeave, AddressOf ControlTaskCard_MouseLeave
        Next

        GetTaskFlow.Controls.Add(Me)
    End Sub

    Private Sub StopTaskBn_Click(sender As Object, e As EventArgs) Handles StopTaskBn.Click
        Dispose()
    End Sub

    Private Sub ControlTaskCard_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = SystemColors.Control
        StopTaskBn.Visible = True
    End Sub

    Private Sub ControlTaskCard_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = SystemColors.Window
        StopTaskBn.Visible = False
    End Sub

    Private Sub JobStatusChanged(Status As SimpleADJobStatus) Handles HostJob.StatusChanged
        UpdateStatus(Status)
    End Sub

    Private Sub UpdateStatus(ByVal Status As SimpleADJobStatus)
        StatusLb.Text = "Status - " & Status.ToString
        MainPb.Image = New Icon(GetJobImage, New Size(16, 16)).ToBitmap
    End Sub

    Private Function GetJobImage() As Icon
        Select Case HostJob.JobType
            Case SimpleADJobType.Delete
                Return My.Resources.JobDelete
            Case SimpleADJobType.PasswordReset
                Return My.Resources.JobPasswordReset
            Case SimpleADJobType.Rename
                Return My.Resources.JobRename
            Case SimpleADJobType.UserImport
                Return My.Resources.JobExplorer
            Case SimpleADJobType.Move
                Return My.Resources.JobMove
            Case SimpleADJobType.Explorer
                Return My.Resources.JobExplorer
            Case SimpleADJobType.EnableDisable
                Return My.Resources.JobEnableDisable
            Case Else
                Return My.Resources.JobEnableDisable
        End Select
    End Function
End Class
