Public Class ContainerUserBulk
    Inherits UserControl

    Public DomainTree As ControlDomainTreeView

    Private _ID
    Private _JobName
    Private _JobClass

    Public Property ID
        Set(value)
            _ID = value
        End Set
        Get
            Return _ID
        End Get
    End Property

    Public Property JobName
        Set(value)
            _JobName = value
        End Set
        Get
            Return _JobName
        End Get
    End Property

    Public Property JobClass
        Set(value)
            _JobClass = value
        End Set
        Get
            Return _JobClass
        End Get
    End Property

    Public Sub New(ByVal ID As Integer, ByVal JobName As String, JobClass As JobUserBulk)

        Me.ID = ID
        Me.JobName = JobName
        Me.Dock = DockStyle.Fill
        Me.JobClass = JobClass

        InitializeComponent()

        DomainTree = Me.DomainTreeView
        DomainTree.InitialLoad()
        MainListView.RestoreState(Encoding.Default.GetBytes(My.Settings.ListViewSettings))
    End Sub

    Public Function GetAccecptButton() As Controls.MetroButton
        Return Me.AcceptBt
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer0
    End Function

    Public Function GetProgressBar() As ProgressBar
        Return Me.ProgressBar
    End Function

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBt.Click
        If Not String.IsNullOrEmpty(SelectedOU) Then
            Dim ShowOptions As New FormBulkUserOptions(_JobClass, Me)
            ShowOptions.ShowDialog()
        End If
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Try
            For Each Worker As BulkADWorker In OngoingBulkJobs
                If Worker.BulkUserContainerObject Is Me Then
                    Worker.CancelWork()
                End If
            Next
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message.ToString)
        End Try
    End Sub

End Class
