Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Imports SimpleLib


Public Class ContainerExplorer
    Inherits UserControl

    Private WithEvents _ControlDomainTreeView As ControlDomainTreeView
    Private TextMatchFilter As TextMatchFilter

    Public Property Path As String
    Public Property Job As TaskExplorer

    Private _UIHandler As UIHandler

    Public Sub New()

        InitializeComponent()

        MainListView.SetListStyle()
        MainSplitContainer.SpliterHeight = 18

        InitEventHandlers()

        ExplorerContainerHandle = Me
        MainListViewHandle = MainListView
        ExplorerSplitContainerHandle = MainSplitContainer
        MainDomainTreeViewHandle = DomainTreeView

        _ControlDomainTreeView = DomainTreeView

    End Sub

    Private Sub ContainerExplorer_Load(sender As Object, e As EventArgs) Handles Me.Load

        AddHandler _ControlDomainTreeView.SelectedOUChanged, AddressOf SelecetdOu_changed
        AddHandler _ControlDomainTreeView.ReportRequested, AddressOf ReportRequested

    End Sub

    Private Sub Item_MouseDoubleClick(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click, MainListView.ItemActivate
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
                                _ControlDomainTreeView.SelectedNode.Expand()
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

    Private Sub InitEventHandlers()

        MainListView.RowContextMenu = RowObjectContextMenu
        MainListView.OffRowContextMenu = ListViewContextMenu

        _UIHandler = New UIHandler(MainListView, Me)

        AddHandler MainListView.SelectionChanged, AddressOf RefreshToolStrip
        AddHandler MainListView.ItemsChanged, AddressOf RefreshToolStrip

        AddHandler DeleteBulkToolStripMenuItem.Click, AddressOf _UIHandler.DeleteBulk_Click
        AddHandler MoveSingleToolStripMenuItem.Click, AddressOf _UIHandler.MoveSingle_Click
        AddHandler ResetSingleToolStripMenuItem.Click, AddressOf _UIHandler.ResetSingle_Click
        AddHandler EnableToolStripMenuItem.Click, AddressOf _UIHandler.Enable_Click
        AddHandler DisableToolStripMenuItem.Click, AddressOf _UIHandler.Disable_Click
        AddHandler EnableBulkToolStripMenuItem.Click, AddressOf _UIHandler.EnableBulk_Click
        AddHandler DisableBulkToolStripMenuItem.Click, AddressOf _UIHandler.DisableBulk_Click
        AddHandler DeleteSingleToolStripMenuItem.Click, AddressOf _UIHandler.DeleteSingle_Click
        AddHandler BulkModifyToolStripMenuItem.Click, AddressOf _UIHandler.BulkModify_Click
        AddHandler MoveBulkToolStripMenuItem.Click, AddressOf _UIHandler.MoveBulk_Click
        AddHandler ResetBulkToolStripMenuItem.Click, AddressOf _UIHandler.ResetBulk_Click
        AddHandler PingMachineToolStripMenuItem.Click, AddressOf _UIHandler.Ping_Click

        AddHandler SearchMenuItem.Click, AddressOf _UIHandler.SearchMenuItem_Click
        AddHandler NewOuMenutItem.Click, AddressOf _UIHandler.NewOrganizationalUnit_Click
        AddHandler NewUserMenuItem.Click, AddressOf _UIHandler.NewUserButton_Click
        AddHandler NewReportMenutItem.Click, AddressOf _UIHandler.NewReportMenutItem_Click

        AddHandler CopyDNToolStripMenuItem.Click, AddressOf _UIHandler.CopyDNToolStripMenuItem_Click
        AddHandler CopyNameToolStripMenuItem.Click, AddressOf _UIHandler.CopyNameToolStripMenuItem_Click
        AddHandler CopySamToolStripMenuItem.Click, AddressOf _UIHandler.CopySamToolStripMenuItem_Click

        AddHandler MainListView.CellEditFinishing, AddressOf _UIHandler.CellEditFinishing

        AddHandler DomainTreeView.SelectedOUChanged, AddressOf ContainerUpdated

    End Sub

    Private Sub ControlDomainTreeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles DomainTreeView.NodeMouseClick
        If e.Button = MouseButtons.Right Then
            _ControlDomainTreeView.SelectedNode = e.Node
            GetDomianConextMenu(e.Node, DomainViewContextMenu)
        End If
    End Sub

#Region "ListView Context Menu Handlers"

    Private Sub RefreshMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshMenuItem.Click
        If Job IsNot Nothing Then
            Job.Refresh(Nothing)
            _ControlDomainTreeView.RefreshNodes()
        End If
    End Sub

    Private Sub RenameMenuItem_Click(sender As Object, e As EventArgs) Handles RenameMenuItem.Click

        If MainListView.SelectedObject IsNot Nothing Then
            Try
                MainListView.EditModel(MainListView.SelectedObject)
            Catch Ex As Exception
                Debug.WriteLine("[Error] Unable to begin edit on selected object: " & Ex.Message)
            End Try
        End If

    End Sub

#End Region

    Private Sub ContainerExplorer_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As ContainerExplorer = Me
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)
        End If
    End Sub

End Class
