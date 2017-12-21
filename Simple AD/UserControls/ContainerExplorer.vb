Public Class ContainerExplorer
    Inherits UserControl

    Private WithEvents _ControlDomainTreeView As ControlDomainTreeView
    Private TextMatchFilter As TextMatchFilter

    Public Property Path As String
    Public Property Job As JobExplorer

    Public Sub New()

        InitializeComponent()

        AddHandler MainListView.SelectionChanged, AddressOf RefreshToolStrip
        AddHandler MainListView.ItemsChanged, AddressOf RefreshToolStrip

        AddHandler DeleteBulkToolStripMenuItem.Click, AddressOf DeleteBulk_Click
        AddHandler MoveSingleToolStripMenuItem.Click, AddressOf MoveSingle_Click
        AddHandler ResetSingleToolStripMenuItem.Click, AddressOf ResetSingle_Click
        AddHandler EnableToolStripMenuItem.Click, AddressOf Enable_Click
        AddHandler DisableToolStripMenuItem.Click, AddressOf Disable_Click
        AddHandler EnableBulkToolStripMenuItem.Click, AddressOf EnableBulk_Click
        AddHandler DisableBulkToolStripMenuItem.Click, AddressOf DisableBulk_Click
        AddHandler DeleteSingleToolStripMenuItem.Click, AddressOf DeleteSingle_Click
        AddHandler BulkModifyToolStripMenuItem.Click, AddressOf BulkModify_Click
        AddHandler MoveBulkToolStripMenuItem.Click, AddressOf MoveBulk_Click
        AddHandler ResetBulkToolStripMenuItem.Click, AddressOf ResetBulk_Click

        AddHandler DomainTreeView.SelectedOUChanged, AddressOf ContainerUpdated

        ExplorerContainerHandle = Me
        MainListViewHandle = MainListView
        ExplorerSplitContainerHandle = MainSplitContainer
        MainDomainTreeViewHandle = DomainTreeView

        _ControlDomainTreeView = Me.DomainTreeView

        MainListView.Activation = ItemActivation.Standard

        LoadImages()

        If Not My.Settings.ExplorerListViewSettings Is Nothing Then
            MainListView.RestoreState(Encoding.Default.GetBytes(My.Settings.ExplorerListViewSettings))
        End If

    End Sub

    Private Sub ContainerExplorer_Load(sender As Object, e As EventArgs) Handles Me.Load

        AddHandler _ControlDomainTreeView.SelectedOUChanged, AddressOf SelecetdOu_changed
        AddHandler _ControlDomainTreeView.ReportRequested, AddressOf ReportRequested

    End Sub

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
            If MainListView.SelectedItems.Count = 1 Then
                Dim DomainObject As DomainObject = DirectCast(MainListView.SelectedItem.RowObject, DomainObject)
                Dim oClass As String = DomainObject.Type
                Select Case True
                    Case (oClass = "container" Or oClass = "organizationalUnit")

                        If sender Is PropertiesToolStripMenuItem Then
                            Dim ShowUserProps As FormObjectAttributes = New FormObjectAttributes(DomainObject, _Job)
                        Else
                            Me.Path = DomainObject.DistinguishedName
                            Dim Nodes As TreeNode() = _ControlDomainTreeView.Nodes.Find(Path, True)
                            If Nodes.Count > 0 Then
                                _ControlDomainTreeView.SelectedNode = Nodes(0)
                                Nodes(0).Expand()
                            End If
                            _Job.Refresh(Path)
                        End If
                    Case Else
                        Dim ShowUserProps As FormObjectAttributes = New FormObjectAttributes(DomainObject, _Job)
                End Select
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to load object properties Form: " & Ex.Message)
        End Try
    End Sub

    Public Function GetSelectedUsers() As List(Of OLVListItem)
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

    Private Sub SelecetdOu_changed(ByVal Path As String)
        If Not _Job Is Nothing Then
            Me.Path = Path
            Debug.WriteLine("[Info] Selected OU changed to: " & Path)
            _Job.Refresh(Path, SimpleADReportType.Explorer)
        End If
    End Sub

    Private Sub ReportRequested(ByVal ReportType As SimpleADReportType)
        Debug.WriteLine("[Info] Report Requested: " & ReportType.ToString)
        _Job.Refresh(Nothing, ReportType)
    End Sub

    Private Sub MainListView_CellRightClick(sender As Object, e As CellRightClickEventArgs) Handles MainListView.CellRightClick
        If e.Item IsNot Nothing Then
            Dim DomainObject As DomainObject = DirectCast(e.Item.RowObject, DomainObject)
            GetListViewConextMenu(MainListView, e, RowObjectContextMenu, Me, DomainObject)
        Else
            GetListViewConextMenu(MainListView, e, ListViewContextMenu, Me, Nothing)
        End If
    End Sub

    Private Sub MainListView_CellEditFinishing(sender As Object, e As CellEditEventArgs) Handles MainListView.CellEditFinishing

        Dim DomainObject As DomainObject = DirectCast(e.RowObject, DomainObject)

        If Not DomainObject.Name = e.NewValue.ToString Then
            If Not RenameObject(DirectCast(e.RowObject, DomainObject), e.NewValue.ToString) Then
                Dim RenameErrorDialog As FormAlert = New FormAlert("Failed to Rename Object, Access is Denied", AlertType.ErrorAlert) With {
                    .StartPosition = FormStartPosition.CenterScreen
                }
                RenameErrorDialog.ShowDialog()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim DomainObject As DomainObject = DirectCast(MainListView.SelectedItem.RowObject, DomainObject)
        Dim StringToCopy As String = DomainObject.Name
        My.Computer.Clipboard.SetText(StringToCopy)
    End Sub

    Private Sub CopySamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySamToolStripMenuItem.Click
        Dim DomainObject As DomainObject = DirectCast(MainListView.SelectedItem.RowObject, DomainObject)
        Dim StringToCopy As String = DomainObject.SAMAccountName
        My.Computer.Clipboard.SetText(StringToCopy)
    End Sub

    Private Sub CopyDNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyDNToolStripMenuItem.Click
        Dim DomainObject As DomainObject = DirectCast(MainListView.SelectedItem.RowObject, DomainObject)
        Dim StringToCopy As String = DomainObject.DistinguishedName
        My.Computer.Clipboard.SetText(StringToCopy)
    End Sub

    'Private Sub MainListView_ItemsChanging(sender As Object, e As ItemsChangingEventArgs) Handles MainListView.ItemsChanging
    '    MainListView.ListFilter = Nothing
    '    SearchBoxTb.Text = Nothing
    'End Sub

    Private Sub LoadImages()

        Dim Images As New ImageList()
        With Images
            .Images.Add("OuImage", New Icon(My.Resources.Container, New Size(16, 16)).ToBitmap)
            .Images.Add("DomainImage", New Icon(My.Resources.Domain, New Size(16, 16)).ToBitmap)
            .Images.Add("ContainerImage", New Icon(My.Resources.Container, New Size(16, 16)).ToBitmap)
            .Images.Add("GroupImage", New Icon(My.Resources.Group, New Size(16, 16)).ToBitmap)
            .Images.Add("ComputerImage", New Icon(My.Resources.Computer, New Size(16, 16)).ToBitmap)
            .Images.Add("UserImage", New Icon(My.Resources.User, New Size(16, 16)).ToBitmap)
            .Images.Add("DisabledUserImage", New Icon(My.Resources.UserDisabled, New Size(16, 16)).ToBitmap)
            .Images.Add("ContactImage", New Icon(My.Resources.Contact, New Size(16, 16)).ToBitmap)
            .Images.Add("UnknownImage", New Icon(My.Resources.Unknown, New Size(16, 16)).ToBitmap)
            .ColorDepth = ColorDepth.Depth24Bit
            .ImageSize = New Size(16, 16)
        End With

        MainListView.SmallImageList = Images

    End Sub

#Region "ListView Context Menu Handlers"

    Private Sub RefreshMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshMenuItem.Click
        Job.Refresh(Nothing)
        _ControlDomainTreeView.RefreshNodes()
    End Sub

    Private Sub RenameMenuItem_Click(sender As Object, e As EventArgs) Handles RenameMenuItem.Click
        MainListView.EditModel(MainListView.SelectedObject)
    End Sub

#End Region

End Class
