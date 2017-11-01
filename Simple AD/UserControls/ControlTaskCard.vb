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

        MainProgressBar.Maximum = HostJob.JobProgressMax
        MainProgressBar.Step = 1
        MainProgressBar.Value = HostJob.JobProgress

        AddHandler HostJob.ProgressChanged, AddressOf ProgressChanged

        Select Case HostJob.JobType
            Case SimpleADJobType.Explorer
                Me.Visible = False
        End Select

        TaskName = HostJob.JobType.ToString & " - " & HostJob.JobName
        TaskDescription = HostJob.JobOwner & " | " & HostJob.JobCreated

        UpdateStatus(Job.JobStatus)

        For Each Control As Control In Me.Controls
            AddHandler Control.MouseEnter, AddressOf ControlTaskCard_MouseEnter
            AddHandler Control.MouseLeave, AddressOf ControlTaskCard_MouseLeave
        Next

        GetTaskFlow.Controls.Add(Me)

        Dock = DockStyle.Top
        BringToFront()


    End Sub

    Private Sub ControlTaskCard_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = SystemColors.Control
    End Sub

    Private Sub ControlTaskCard_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = SystemColors.Window
    End Sub

    Private Sub JobStatusChanged(Status As SimpleADJobStatus) Handles HostJob.StatusChanged
        UpdateStatus(Status)
        SaveStatus()
    End Sub

    Private Sub ProgressChanged()

        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ProgressChanged))
        Else
            If Not MainProgressBar.IsDisposed Then

                If Not MainProgressBar.Visible Then
                    StatusLb.Visible = False
                    MainProgressBar.Visible = True
                End If

                MainProgressBar.PerformStep()

                If MainProgressBar.Value = MainProgressBar.Maximum Then
                    MainProgressBar.Dispose()
                    StatusLb.Visible = True
                End If

            End If
        End If
    End Sub

    Private Sub UpdateStatus(ByVal Status As SimpleADJobStatus)
        StatusLb.Text = "Status - " & Status.ToString
        MainPb.Image = New Icon(GetJobImage, New Size(16, 16)).ToBitmap
    End Sub

    Private Function GetJobImage() As Icon
        Select Case HostJob.JobType
            Case SimpleADJobType.Delete
                Return My.Resources.JobDelete
            Case SimpleADJobType.BulkDelete
                Return My.Resources.JobDelete
            Case SimpleADJobType.PasswordReset
                Return My.Resources.JobPasswordReset
            Case SimpleADJobType.Rename
                Return My.Resources.JobRename
            Case SimpleADJobType.UserImport
                Return My.Resources.JobImport
            Case SimpleADJobType.Move
                Return My.Resources.JobMove
            Case SimpleADJobType.BulkMove
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
