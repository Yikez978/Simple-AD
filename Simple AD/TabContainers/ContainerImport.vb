Imports SimpleLib

Public Class ContainerImport
    Inherits UserControl

    Private WithEvents FormOptions As FormBulkUserOptions
    Private CurrentJob As JobImport

    Public Enum UserFilter
        All
        Pending
        Completed
        Errors
        Failed
    End Enum

#Region "Image Lists"

    Public Property AdListImages As New ImageList()
    Public Property AdTReeViewImages As New ImageList()

    Private Sub LoadImages()
        With AdListImages
            .Images.Add("OuImage", IconOU)
            .Images.Add("DomainImage", IconDomian)
            .Images.Add("ContainerImage", IconContainer)
            .Images.Add("GroupImage", IconGroup)
            .Images.Add("ComputerImage", IconComputer)
            .Images.Add("UserImagePending", IconUserPending)
            .Images.Add("UserErrorImage", IconUserError)
            .Images.Add("UserFailedImage", IconUserFailed)
            .Images.Add("UserSuccessImage", IconUserSuccess)
            .Images.Add("ContactImage", IconContact)
            .Images.Add("UnknownImage", IconUnknown)
            .ColorDepth = ColorDepth.Depth24Bit
            .ImageSize = New Size(16, 16)
        End With

        With AdTReeViewImages
            .Images.Add("Import", IconUnknown)
            .Images.Add("UserFlat", IconUserFlat)
            .Images.Add("GroupFlat", IconGroupFlat)
            .Images.Add("Success", My.Resources.SuccessSmall)
            .Images.Add("Error", My.Resources.ErrorSmall)
            .Images.Add("Failed", My.Resources.FailedSmall)
            .ColorDepth = ColorDepth.Depth24Bit
            .ImageSize = New Size(16, 16)
        End With
    End Sub

#End Region

    Public Sub New()

        ImportContainerHandle = Me

        Me.Dock = DockStyle.Fill

        InitializeComponent()

        NameColumn.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)

        LoadImages()
        MainListView.SmallImageList = AdListImages
        MainListView.LargeImageList = AdListImages

        MainTreeView.ImageList = AdTReeViewImages

        MainListView.ShowGroups = True
        MainListView.PrimarySortColumn = StatusColumn
        MainListView.RestoreState(Encoding.Default.GetBytes(My.Settings.ImportListViewSettings))
    End Sub

    Public Function GetAccecptButton() As Controls.MetroButton
        Return Me.AcceptBt
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer0
    End Function

    Public Function GetMainListView() As ObjectListView
        Return Me.MainListView
    End Function

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBt.Click
        FormOptions = New FormBulkUserOptions(MainListView, CurrentJob, Me)
        FormOptions.ShowDialog()
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click

    End Sub

    Private Sub MainTreeView_NodeMouseClick(sender As Object, e As TreeViewEventArgs) Handles MainTreeView.AfterSelect

        MainListView.BeginUpdate()

        Dim INode As ImportJobNode = DirectCast(e.Node, ImportJobNode)

        Dim SelectedJob As JobImport = INode.Job

        If SelectedJob IsNot CurrentJob Then
            CurrentJob = SelectedJob
            Threading.ThreadPool.QueueUserWorkItem(Sub() RefreshJob(CurrentJob, INode))
        Else
            FilterUsers(INode)
            MainListView.EndUpdate()
        End If

        Select Case SelectedJob.JobStatus
            Case SimpleADJobStatus.Idle
                Me.AcceptBt.Enabled = True
                Me.AcceptBt.Text = "Start"
            Case SimpleADJobStatus.InProgress
                Me.AcceptBt.Enabled = False
                Me.AcceptBt.Text = "Running"
            Case SimpleADJobStatus.Completed
                Me.AcceptBt.Enabled = False
                Me.AcceptBt.Text = "Done"
        End Select


    End Sub

    Private Sub RefreshJob(ByVal CurrentJob As JobImport, INode As ImportJobNode)
        MainListView.SetObjects(CurrentJob.Users)
        FilterUsers(INode)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of JobImport, ImportJobNode)(AddressOf RefreshJob), CurrentJob, INode)
        Else
            MainListView.EndUpdate()
        End If
    End Sub

    Private Sub FilterUsers(ByVal INode As ImportJobNode)
        If Not INode.FilterKey Is Nothing Then

            Dim Filter As StatusFilter = Nothing

            Select Case INode.FilterKey
                Case "All"
                    Filter = Nothing
                Case "Pending"
                    Filter = New StatusFilter(UserFilter.Pending)
                Case "Completed"
                    Filter = New StatusFilter(UserFilter.Completed)
                Case "Errors"
                    Filter = New StatusFilter(UserFilter.Errors)
                Case "Failed"
                    Filter = New StatusFilter(UserFilter.Failed)
            End Select

            Me.Invoke(Sub() Me.MainListView.ModelFilter = Filter)

        End If
    End Sub

    Private Sub WorkerComplpeted() Handles FormOptions.JobCompleted
        If Not OngoingBulkJobs.Count > 0 Then
            WorkInProgress = False
        End If
    End Sub

    Public Function NameImageGetter(rowObject As Object) As Object
        Dim DomainObject As DomainObject = DirectCast(rowObject, DomainObject)
        Select Case DomainObject.Type
            Case "user"
                Dim Status As String = DomainObject.Status
                Select Case Status
                    Case "Pending"
                        Return "UserImagePending"
                    Case "Completed"
                        Return "UserSuccessImage"
                    Case "Errors"
                        Return "UserErrorImage"
                    Case "Failed"
                        Return "UserFailedImage"
                End Select
            Case Else
                Return "UnknownImage"
        End Select
        Return Nothing
    End Function

    Private Sub MainListView_CellToolTipShowing(sender As Object, e As ToolTipShowingEventArgs) Handles MainListView.CellToolTipShowing
        If Not e.Item.RowObject.Errors Is Nothing Then
            If e.Item.RowObject.Errors.count > 0 Then
                Dim Builder As New StringBuilder
                For Each ObjectError As String In e.Item.RowObject.Errors
                    Builder.Append(ObjectError & Environment.NewLine)
                Next
                e.Text = Builder.ToString
            End If
        End If
    End Sub

    Private Sub ImportBn_MouseClick(sender As Object, e As MouseEventArgs) Handles ImportBn.MouseClick
        If e.Button = MouseButtons.Left Then
            UserImport()
        End If
    End Sub

    Public Sub ClearJobNodes()
        BeginControlUpdate(TreeViewPanel)
        MainTreeView.Nodes.Clear()
    End Sub

    Public Sub LoadJobNodes(ByVal Job As JobImport)

        Dim RootNode As New ImportJobNode With {.Name = Job.JobName, .Text = Job.JobName, .Job = Job, .FilterKey = "All", .ImageKey = "Import", .SelectedImageKey = "Import"}
        MainTreeView.Nodes.Add(RootNode)

        Dim All As New ImportJobNode With {.Name = Job.JobName, .Text = "All", .Job = Job, .FilterKey = "All", .ImageKey = "GroupFlat", .SelectedImageKey = "GroupFlat"}
        Dim Pending As New ImportJobNode With {.Name = Job.FileName, .Text = "Pending", .Job = Job, .FilterKey = "Pending", .ImageKey = "UserFlat", .SelectedImageKey = "UserFlat"}
        Dim Completed As New ImportJobNode With {.Name = Job.FileName, .Text = "Completed", .Job = Job, .FilterKey = "Completed", .ImageKey = "Success", .SelectedImageKey = "Success"}
        Dim Errors As New ImportJobNode With {.Name = Job.FileName, .Text = "Errors", .Job = Job, .FilterKey = "Errors", .ImageKey = "Error", .SelectedImageKey = "Error"}
        Dim Failed As New ImportJobNode With {.Name = Job.FileName, .Text = "Failed", .Job = Job, .FilterKey = "Failed", .ImageKey = "Failed", .SelectedImageKey = "Failed"}

        Dim SubNodes As TreeNode() = {All, Pending, Completed, Errors, Failed}

        RootNode.Nodes.AddRange(SubNodes)

        CurrentJob = Job
    End Sub

    Public Class StatusFilter
        Implements IModelFilter

        Private FilterType As UserFilter

        Public Sub New(ByVal UserFilter As UserFilter)
            Me.FilterType = UserFilter
        End Sub

        Public Function Filter(modelObject As Object) As Boolean Implements IModelFilter.Filter
            Select Case FilterType
                Case UserFilter.Pending
                    Return (DirectCast(modelObject, SimpleADBulkUserDomainObject).Status) = "Pending"
                Case UserFilter.Completed
                    Return (DirectCast(modelObject, SimpleADBulkUserDomainObject).Status) = "Completed"
                Case UserFilter.Errors
                    Return (DirectCast(modelObject, SimpleADBulkUserDomainObject).Status) = "Errors"
                Case UserFilter.Failed
                    Return (DirectCast(modelObject, SimpleADBulkUserDomainObject).Status) = "Failed"
                Case Else
                    Return False
            End Select
        End Function
    End Class

End Class

Public Class ImportJobNode
    Inherits TreeNode

    Public Sub New()
        MyBase.New()
    End Sub

    Public Property FilterKey As String
    Public Property Job As JobImport

End Class



