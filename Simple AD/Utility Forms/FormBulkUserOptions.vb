Public Class FormBulkUserOptions

    Private _JobClass As JobUserBulk
    Private _ContainerUserBulk As ContainerUserBulk

    Public Sub New(ByVal JobClass As JobUserBulk, ByVal ContainerUserBulk As ContainerUserBulk)
        InitializeComponent()
        _JobClass = JobClass
        _ContainerUserBulk = ContainerUserBulk
    End Sub

    Private Sub ConfirmBn_Click(sender As Object, e As EventArgs) Handles ConfirmBn.Click
        Try
            _JobClass.CreateHomeFodlers = CrHfldrTg.Checked
            _JobClass.EnableAccounts = EnAcTg.Checked
            _JobClass.ForcePasswordReset = FpwdTg.Checked

            _ContainerUserBulk.MainDataGrid.ReadOnly = True
            _ContainerUserBulk.AcceptBt.Enabled = False
            FormMain.StatusStrip.BackColor = Color.FromArgb(202, 81, 0)
            FormMain.ToolStripStatusLabelStatus.Text = "Starting new Bulk User Job. ID: " & _ContainerUserBulk.ID
            FormMain.ToolStripStatusLabelContext.Text = ""

            _ContainerUserBulk.ProgressBar.Show()
            _ContainerUserBulk.ProgressBar.BringToFront()

            Dim Worker = New BulkADWorker(_ContainerUserBulk.MainDataGrid, _ContainerUserBulk, _ContainerUserBulk.JobClass)
            OngoingBulkJobs.Add(Worker)
            Worker.RunBulkUserSetup()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub
End Class