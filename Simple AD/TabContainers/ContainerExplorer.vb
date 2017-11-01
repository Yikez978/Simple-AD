Imports SimpleLib

Public Class ContainerExplorer
    Inherits UserControl

    Private WithEvents _ControlDomainTreeView As ControlDomainTreeView
    Private TextMatchFilter As TextMatchFilter

    Public Property Path As String
    Public Property Job As JobExplorer

    Public Sub New()

        InitializeComponent()

        ExplorerContainerHandle = Me

        _ControlDomainTreeView = Me.DomainTreeView
        _ControlDomainTreeView.InitialLoad()

        MainListView.Activation = ItemActivation.Standard
        NameColumn.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)

        LoadImages()

        MainListView.PrimarySortColumn = TypeColumn
        MainListView.Sort()

        If Not My.Settings.ExplorerListViewSettings Is Nothing Then
            MainListView.RestoreState(Encoding.Default.GetBytes(My.Settings.ExplorerListViewSettings))
        End If

        Me.DomainTreeView.TopNode.Expand()

    End Sub

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeView
        Return DirectCast(Me.MainSplitContainer.Panel1.Controls.Item(0), ControlDomainTreeView)
    End Function

    Public Function GetMainListView() As ObjectListView
        Return Me.MainListView
    End Function

    'Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs)
    '    If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
    '        TextMatchFilter = TextMatchFilter.Contains(MainListView, SearchBoxTb.Text)
    '        MainListView.ModelFilter = TextMatchFilter
    '    Else
    '        MainListView.ModelFilter = Nothing
    '    End If
    'End Sub

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
                    Case Else
                        Dim ShowUserProps = New FormObjectAttributes(MainListView.SelectedItem.RowObject, _Job)
                End Select
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to load object properties Form: " & Ex.Message)
        End Try
    End Sub

    Private Sub BulkModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkModifyToolStripMenuItem.Click
        Dim SelectedItems As List(Of OLVListItem) = GetSelectedUsers()
        Dim NewBulkModifyForm = New FormObjectAttributesBulk(SelectedItems, _Job)
    End Sub

    Private Sub EnableDisableSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableSingleToolStripMenuItem.Click
        Dim EnableDisableJob As JobEnableDisable = New JobEnableDisable(DirectCast(MainListView.SelectedItem.RowObject, UserDomainObject), Job)
    End Sub

    Private Sub DeleteSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSingleToolStripMenuItem.Click
        Dim DeleteJob As JobDelete = New JobDelete(DirectCast(MainListView.SelectedItem.RowObject, DomainObject), Job)
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

    Private Sub DeleteBulkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBulkToolStripMenuItem.Click
        Dim DeleteBulkJob As JobDeleteBulk = New JobDeleteBulk(MainListView.SelectedObjects, Job)
    End Sub

    Private Sub MoveSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveSingleToolStripMenuItem.Click
        Dim MoveJob As JobMove = New JobMove(DirectCast(MainListView.SelectedItem.RowObject, DomainObject), Job)
    End Sub

    Private Sub ResetSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSingleToolStripMenuItem.Click
        Dim ResetPassordJob As JobPasswordReset = New JobPasswordReset(DirectCast(MainListView.SelectedItem.RowObject, UserDomainObject), Job)
    End Sub

    Private Sub ResetBulkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetBulkToolStripMenuItem.Click
        Dim BulkResetForm = New FormPasswordResetBulk(GetSelectedUsers)
        BulkResetForm.ShowDialog()
    End Sub

    Public Sub SelecetdOu_changed(ByVal Path As String) Handles _ControlDomainTreeView.SelectedOUChanged
        If Not _Job Is Nothing Then
            Me.Path = Path
            _Job.Refresh(Path, ReportType.Explorer)
        End If
    End Sub

    Public Sub EveryThingSeleceted() Handles _ControlDomainTreeView.EveryThingSeleceted
        _Job.Refresh(Nothing, ReportType.AllObjects)
    End Sub

    Public Sub DisabledUsersSeleceted() Handles _ControlDomainTreeView.DisabledUsersSeleceted
        _Job.Refresh(Nothing, ReportType.DisabledUsers)
    End Sub

    Public Sub AllAdminsSeleceted() Handles _ControlDomainTreeView.AllAdminsSeleceted
        _Job.Refresh(Nothing, ReportType.AllAdmins)
    End Sub

    Private Sub MainListView_CellRightClick(sender As Object, e As CellRightClickEventArgs) Handles MainListView.CellRightClick
        If e.Item IsNot Nothing Then
            Dim DomainObject = DirectCast(e.Item.RowObject, DomainObject)
            GetListViewConextMenu(MainListView, e, RowObjectContextMenu, Me, DomainObject)
        Else
            GetListViewConextMenu(MainListView, e, ListViewContextMenu, Me, Nothing)
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

    Private Sub MainListView_CellEditFinishing(sender As Object, e As CellEditEventArgs) Handles MainListView.CellEditFinishing
        If Not e.RowObject.Name = e.NewValue Then
            If Not RenameObject(DirectCast(e.RowObject, DomainObject), e.NewValue) Then
                Dim RenameErrorDialog = New FormAlert("Failed to Rename Object, Access is Denied", AlertType.ErrorAlert)
                RenameErrorDialog.StartPosition = FormStartPosition.CenterScreen
                RenameErrorDialog.ShowDialog()
                e.Cancel = True
            End If
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

    Private Sub MoveBulkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveBulkToolStripMenuItem.Click
        Dim MoveBulkJob As JobMoveBulk = New JobMoveBulk(MainListView.SelectedObjects, Job)
    End Sub

    'Private Sub MainListView_ItemsChanging(sender As Object, e As ItemsChangingEventArgs) Handles MainListView.ItemsChanging
    '    MainListView.ListFilter = Nothing
    '    SearchBoxTb.Text = Nothing
    'End Sub

    Private Sub LoadImages()

        Dim AdImagesSmall As New ImageList()
        With AdImagesSmall
            .Images.Add("OuImage", IconOU)
            .Images.Add("DomainImage", IconDomian)
            .Images.Add("ContainerImage", IconContainer)
            .Images.Add("GroupImage", IconGroup)
            .Images.Add("ComputerImage", IconComputer)
            .Images.Add("UserImage", IconUser)
            .Images.Add("DisabledUserImage", IconDisabledUSer)
            .Images.Add("ContactImage", IconContact)
            .Images.Add("UnknownImage", IconUnknown)
            .ColorDepth = ColorDepth.Depth24Bit
            .ImageSize = New Size(16, 16)
        End With

        Dim AdImagesLarge As New ImageList()
        With AdImagesLarge
            .Images.Add("OuImage", IconOULarge)
            .Images.Add("DomainImage", IconDomianLarge)
            .Images.Add("ContainerImage", IconContainerLarge)
            .Images.Add("GroupImage", IconGroupLarge)
            .Images.Add("ComputerImage", IconComputerLarge)
            .Images.Add("UserImage", IconUserLarge)
            .Images.Add("DisabledUserImage", IconDisabledUserLarge)
            .Images.Add("ContactImage", IconContactLarge)
            .Images.Add("UnknownImage", IconUnknownLarge)
            .ColorDepth = ColorDepth.Depth24Bit
            .ImageSize = New Size(64, 64)
        End With

        MainListView.SmallImageList = AdImagesSmall
        MainListView.LargeImageList = AdImagesLarge

    End Sub

#Region "ListView Context Menu Handlers"

    Private Sub DetailsMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsMenuItem.Click
        MainListView.View = View.Details
    End Sub

    Private Sub ListMenuItem_Click(sender As Object, e As EventArgs) Handles ListMenuItem.Click
        MainListView.View = View.List
    End Sub

    Private Sub SmallIconsMenuItem_Click(sender As Object, e As EventArgs) Handles SmallIconsMenuItem.Click
        MainListView.View = View.SmallIcon
    End Sub

    Private Sub LargeIconsMenuItem_Click(sender As Object, e As EventArgs) Handles LargeIconsMenuItem.Click
        MainListView.View = View.LargeIcon
    End Sub

    Private Sub TilesMenuItem_Click(sender As Object, e As EventArgs) Handles TilesMenuItem.Click
        MainListView.View = View.Tile
    End Sub

    Private Sub RefreshMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshMenuItem.Click
        Job.Refresh(Nothing, ReportType.Explorer)
        _ControlDomainTreeView.RefreshNodes()
    End Sub

    Private Sub RenameMenuItem_Click(sender As Object, e As EventArgs) Handles RenameMenuItem.Click
        MainListView.EditModel(MainListView.SelectedObject)
    End Sub
#End Region

End Class
