Imports SimpleLib

Public Class FormBulkUserOptions

    Private _JobClass As JobImport
    Private _ContainerUserBulk As ContainerImport
    Private _ListView As ObjectListView
    Private WithEvents _Worker As BulkADWorker

    Private _Path As String

    Public Event JobCompleted()

    Public Sub New(ByVal MainlistView As ObjectListView, ByVal JobClass As JobImport, ByVal ContainerUserBulk As ContainerImport)
        InitializeComponent()
        _ListView = MainlistView
        _JobClass = JobClass

        _ContainerUserBulk = ContainerUserBulk
        Me.ThreadTb.Text = CStr(My.Settings.BulkUserThreadCount)
        Me.DomainTreeView.InitialLoad()
    End Sub

    Private Sub ConfirmBn_Click(sender As Object, e As EventArgs) Handles ConfirmBn.Click

        If Not DomainTreeView.SelectedNode Is DomainTreeView.TopNode Then

            _JobClass.CreateHomeFodlers = CrHfldrTg.Checked
            _JobClass.EnableAccounts = EnAcTg.Checked
            _JobClass.ForcePasswordReset = FpwdTg.Checked

            _ContainerUserBulk.AcceptBt.Enabled = False

            WorkInProgress = True

            Dim ObjectsList As New List(Of DomainObject)

            _ListView.SelectAll()
            For Each DomainObject As DomainObject In _ListView.SelectedObjects
                ObjectsList.Add(DomainObject)
            Next
            _ListView.DeselectAll()

            _Worker = New BulkADWorker(ObjectsList, _ListView, _ContainerUserBulk, _JobClass, _Path)
            OngoingBulkJobs.Add(_Worker)
            Me.Close()
        End If
    End Sub

    Public Function GetBulkWorker() As BulkADWorker
        Return Me._Worker
    End Function

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub

    Private Sub DomainTreeView_SelectedOUChanged(Path As String) Handles DomainTreeView.SelectedOUChanged
        Me.PathTb.Text = Path
        Me._Path = Path
    End Sub

    Private Sub WorkCompleted() Handles _Worker.JobCompleted
        RaiseEvent JobCompleted()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim p As Panel = Panel1
        If Not p Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, 0, 0, p.Height)
        End If
    End Sub
End Class