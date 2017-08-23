Public Class ContainerUserReport
    Inherits UserControl

    Private _ID As Integer
    Private _Job As JobUserReport
    Private _JobName As String
    Private _Path As String

    Private WithEvents _ControlDomainTreeView As ControlDomainTreeView
    Private TextMatchFilter As TextMatchFilter

    Public Property ID As Integer
        Set(value As Integer)
            _ID = value
        End Set
        Get
            Return _ID
        End Get
    End Property

    Public Property JobName As String
        Set(value As String)
            _JobName = value
        End Set
        Get
            Return _JobName
        End Get
    End Property

    Public Property Path As String
        Set(value As String)
            _Path = value
        End Set
        Get
            Return _Path
        End Get
    End Property

    Public Sub New(ByVal ID As Integer, ByVal JobName As String, ByVal Job As JobUserReport)

        Me.ID = ID
        Me.JobName = JobName

        InitializeComponent()

        _Job = Job
        _ControlDomainTreeView = Me.DomainTreeView
        _ControlDomainTreeView.InitialLoad()

        MainListView.Activation = ItemActivation.Standard
        NameColumn.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)

        Dim HighlightTextRenderer = New HighlightTextRenderer(TextMatchFilter)

        HighlightTextRenderer.FramePen = New Pen(Color.AliceBlue)

        MainListView.DefaultRenderer = HighlightTextRenderer
        MainListView.RestoreState(Encoding.Default.GetBytes(My.Settings.ListViewSettings))

        Me.Dock = DockStyle.Fill

    End Sub

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeView
        Return Me.MainSplitContainer.Panel1.Controls.Item(0)
    End Function

    Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs) Handles SearchBoxTb.TextChanged
        If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
            TextMatchFilter = TextMatchFilter.Contains(MainListView, SearchBoxTb.Text)
            MainListView.ModelFilter = TextMatchFilter
        Else
            MainListView.ModelFilter = Nothing
        End If
    End Sub


    Private Sub Item_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click, MainListView.ItemActivate
        Try
            If MainListView.SelectedItems.Count > 0 Then
                Dim oClass As String = MainListView.SelectedItem.RowObject.Type
                Select Case True
                    Case (oClass = "container" Or oClass = "organizationalUnit")
                        Me.Path = MainListView.SelectedItem.RowObject.DistinguishedName
                        Dim Nodes As TreeNode() = _ControlDomainTreeView.Nodes.Find(Path, True)
                        If Nodes.Count > 0 Then
                            _ControlDomainTreeView.SelectedNode = Nodes(0)
                            Nodes(0).Expand()
                        End If
                        _Job.Refresh(Path)
                    Case (oClass = "user" Or oClass = "group" Or oClass = "computer")
                        If Not IsDBNull(MainListView.SelectedItem.RowObject.SAMAccountName) Then
                            Dim ShowUserProps = New FormUserAttributes(MainListView.SelectedItem.RowObject, _Job)
                        End If
                    Case Else
                End Select
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to load object properties Form: " & Ex.Message)
        End Try
    End Sub

    Private Sub BulkModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkModifyToolStripMenuItem.Click
        Dim SelectedItems As List(Of OLVListItem) = GetSelectedUsers()
        Dim NewBulkModifyForm = New FormUserAttributesBulk(SelectedItems, _Job)
    End Sub

    Private Sub EnableDisableSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableSingleToolStripMenuItem.Click
        Try
            Dim DomainObject As DomainObject = GetSelectedUser()

            If IsAccountEnabled(DomainObject) Then
                Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(DomainObject)
                If Not IsEnableAccountSuccessfull = Nothing Then
                    _Job.Refresh()
                End If
            Else
                Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(DomainObject)
                If Not IsDisnableAccountSuccessfull = Nothing Then
                    _Job.Refresh()
                End If
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Function GetSelectedUser() As DomainObject
        Try
            Return MainListView.SelectedItem.RowObject
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to change the active state of the seleceted user account: " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub DeleteSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSingleToolStripMenuItem.Click
        Dim DomainObject As DomainObject = GetSelectedUser()
        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & DomainObject.Name & "?", ConfirmationType.Delete)
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then
            If DeleteADObject(DomainObject) Then
                _Job.Refresh()
            End If
        End If
    End Sub

    Private Function GetSelectedUsers() As List(Of OLVListItem)
        Try
            Dim UserArray As New List(Of OLVListItem)

            For Each Item As OLVListItem In MainListView.SelectedItems
                UserArray.Add(Item)
            Next
            Return UserArray
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to change the active state of the seleceted users: " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub EnableDisableBulkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableBulkToolStripMenuItem.Click
        Try
            For Each Item As OLVListItem In GetSelectedUsers()

                Dim DomainObject As DomainObject = Item.RowObject

                If IsAccountEnabled(DomainObject) Then
                    Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(DomainObject)
                    If Not IsEnableAccountSuccessfull = Nothing Then
                        _Job.Refresh()
                    End If
                Else
                    Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(DomainObject)
                    If Not IsDisnableAccountSuccessfull = Nothing Then
                        _Job.Refresh()
                    End If
                End If
            Next
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim SelectedUsers As List(Of OLVListItem) = GetSelectedUsers()
        Dim DeleteForm = New FormConfirmation("Are you sure you wish to delete " & SelectedUsers.Count & " objects?", ConfirmationType.Delete)
        Dim IsBatchSuccesfull = False
        DeleteForm.ShowDialog()
        If DeleteForm.DialogResult = DialogResult.Yes Then
            For Each Item As OLVListItem In SelectedUsers
                If DeleteADObject(Item.RowObject.SAMAccountName) Then
                    IsBatchSuccesfull = True
                End If
            Next
            If IsBatchSuccesfull = True Then
                _Job.Refresh()
            End If
        End If
    End Sub

    Private Sub MoveSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveSingleToolStripMenuItem.Click
        Dim DomainObject As DomainObject = MainListView.SelectedItem.RowObject
        Dim MoveForm = New FormMoveObject
        MoveForm.ShowDialog()
        If MoveForm.DialogResult = DialogResult.Yes Then
            If MoveADObject(DomainObject, MoveForm.SelecetdOU) = True Then
                _Job.Refresh()
                Dim ResultForm = New FormAlert(DomainObject.Name & " has been moved to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.Success)
                ResultForm.ShowDialog()
            Else
                Dim ResultForm = New FormAlert("An Error occured while trying to move " & DomainObject.Name & " to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.ErrorAlert)
                ResultForm.ShowDialog()
            End If
        End If
    End Sub

    Public Sub SelecetdOu_changed(ByVal Path As String) Handles _ControlDomainTreeView.SelectedOUChanged
        Me.Path = Path
        _Job.Refresh(Path, ReportType.Explorer)
    End Sub

    Public Sub EveryThingSeleceted() Handles _ControlDomainTreeView.EveryThingSeleceted
        _Job.Refresh(Nothing, ReportType.AllObjects)
    End Sub

    Public Sub DisabledUsersSeleceted() Handles _ControlDomainTreeView.DisabledUsersSeleceted
        _Job.Refresh(Nothing, ReportType.DisabledUsers)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        MainListView.View = View.Details
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmallIconsToolStripMenuItem.Click
        MainListView.View = View.SmallIcon
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeIconsToolStripMenuItem.Click
        MainListView.View = View.LargeIcon
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        MainListView.View = View.List
    End Sub

    Private Sub MainListView_CellRightClick(sender As Object, e As CellRightClickEventArgs) Handles MainListView.CellRightClick
        If MainListView.SelectedItems.Count = 1 Then
            Dim oClass = MainListView.SelectedItem.RowObject.Type
            If (oClass = "user" Or oClass = "group" Or oClass = "computer" Or oClass = "container" Or oClass = "organizationalUnit") Then
                GetListViewConextMenu(MainListView, e, SingleContextMenu, Me)
            End If
        ElseIf MainListView.SelectedItems.Count > 1 Then
            GetListViewConextMenu(MainListView, e, BulkContextMenu, Me)
        End If
    End Sub

    Public Function NameImageGetter(rowObject As Object) As Object
        Dim DomainObject As DomainObject = DirectCast(rowObject, DomainObject)
        Select Case DomainObject.Type
            Case "user"
                Dim UserAccountControl As String = DomainObject.UserAccountControl
                If UserAccountControl = "546" Or UserAccountControl = "514" Or UserAccountControl = "66082" Or UserAccountControl = "66050" Then
                    Return "DisabledUserImage"
                Else
                    Return "UserImage"
                End If
            Case "computer"
                Return "ComputerImage"
            Case "group"
                Return "GroupImage"
            Case "container"
                Return "ContainerImage"
            Case "organizationalUnit"
                Return "OuImage"
            Case "contact"
                Return "ContactImage"
            Case Else
                Return "UnknownImage"
        End Select
        Return Nothing
    End Function

    Private Sub MainListView_CellToolTipShowing(sender As Object, e As ToolTipShowingEventArgs) Handles MainListView.CellToolTipShowing
        If e.Column Is TypeColumn Then
            e.Text = CStr(e.Model.TypeFull)
        End If
        If e.Column Is NameColumn Then
            e.Text = CStr(e.Model.DistinguishedName)
        End If
    End Sub

    Private Sub MainListView_AfterSorting(sender As Object, e As AfterSortingEventArgs) Handles MainListView.AfterSorting
        If Not e.SortOrder = SortOrder.None Then
            MainListView.ShowGroups = True
        End If
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim StringToCopy As String = MainListView.SelectedItem.RowObject.Name
        My.Computer.Clipboard.SetText(StringToCopy)
    End Sub

    Private Sub CopySamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySamToolStripMenuItem.Click
        Dim StringToCopy As String = MainListView.SelectedItem.RowObject.SAMAccountName
        My.Computer.Clipboard.SetText(StringToCopy)
    End Sub

    Private Sub CopyDNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyDNToolStripMenuItem.Click
        Dim StringToCopy As String = MainListView.SelectedItem.RowObject.DistinguishedName
        My.Computer.Clipboard.SetText(StringToCopy)
    End Sub
End Class
