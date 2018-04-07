Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports SimpleLib

Public Class ControlDomainTreeView
    Inherits WindowsFormsAero.TreeView

    Private _DomainName As String
    Private _DomainController As String
    Private _SelectedItem As String

    Public RootNode As TreeNode

    Public Event SelectedItemChanged(ByVal Path As String)
    Public Event SelectedContainerChanged(ByVal Name As String, ByVal FormatPath As Boolean)
    Public Event ReportRequested(ByVal ReportType As SimpleADReportType)
    Public Event NodeClicked(sender As Object, e As TreeNodeMouseClickEventArgs)

#Region "Properties"

    Property DomainName As String
        Set(value As String)
            _DomainName = value
        End Set
        Get
            Return _DomainName
        End Get
    End Property

    Property DomainController As String
        Set(value As String)
            _DomainController = value
        End Set
        Get
            Return _DomainController
        End Get
    End Property

    Public Property SelectedItem As String
        Set(value As String)
            _SelectedItem = value
            RaiseEvent SelectedItemChanged(_SelectedItem)
        End Set
        Get
            Return _SelectedItem
        End Get
    End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H8000
            Return cp
        End Get
    End Property

#End Region

#Region "Native"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)

        'Double Buffer
        SendMessage(Me.Handle, TVM_SETEXTENDEDSTYLE, New IntPtr(TVS_EX_DOUBLEBUFFER), New IntPtr(TVS_EX_DOUBLEBUFFER))

        'Fade Effects
        'SendMessage(Me.Handle, TVM_SETEXTENDEDSTYLE, New IntPtr(TVS_EX_FADEINOUTEXPANDOS), New IntPtr(TVS_EX_FADEINOUTEXPANDOS))

        MyBase.OnHandleCreated(e)
    End Sub

    Private Const TVM_SETEXTENDEDSTYLE As Integer = &H1100 + 44
    Private Const TVM_GETEXTENDEDSTYLE As Integer = &H1100 + 45
    Private Const TVS_EX_FADEINOUTEXPANDOS As Integer = &H40
    Private Const TVS_EX_DOUBLEBUFFER As Integer = &H4

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
    End Function

#End Region

    Public Sub New()

        Margin = New Padding(0, 0, 0, 0)
        HotTracking = True
        ShowLines = False
        ItemHeight = 22
        FullRowSelect = True
        Font = SystemFonts.DefaultFont
        HideSelection = False
        Nodes.Clear()
        LabelEdit = False
        BorderStyle = BorderStyle.None

        NativeMethods.SetWindowTheme(Me.Handle, "explorer", Nothing)

        Try
            Dim AdImages As New ImageList()

            AdImages.Images.Add("Search", New Icon(My.Resources.Search, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("OuImage", New Icon(My.Resources.OU, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("OuSelected", New Icon(My.Resources.OUSelecetd, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("DomainImage", New Icon(My.Resources.Domain, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("ContainerImage", New Icon(My.Resources.Container, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("ContainerSelected", New Icon(My.Resources.ContainerSelected, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("Everything", New Icon(My.Resources.Search, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllDisabledUsers", New Icon(My.Resources.UserDisabled, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllEnabledUsers", New Icon(My.Resources.User, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllAdmins", New Icon(My.Resources.Admin, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllDeletedObjects", New Icon(My.Resources.Delete, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("ProtectedObjects", New Icon(My.Resources.Protect, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllComputers", New Icon(My.Resources.Computer, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllServers", New Icon(My.Resources.Server, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllDomainControllers", New Icon(My.Resources.Organization, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllClients", New Icon(My.Resources.Client, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllUsersNotLoggedOn", New Icon(My.Resources.LogonTime, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("Import", New Icon(My.Resources.JobImport, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllUsers", New Icon(My.Resources.Group, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("AllGroups", New Icon(My.Resources.Group, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("Builtin", New Icon(My.Resources.Builtin, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("LostAndFound", New Icon(My.Resources.LostAndFound, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("Quota", New Icon(My.Resources.Quota, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("TPMImage", New Icon(My.Resources.SecurityLock, New Size(16, 16)).ToBitmap)
            AdImages.Images.Add("ExchSystemObject", New Icon(My.Resources.Message, New Size(16, 16)).ToBitmap)
            AdImages.ColorDepth = ColorDepth.Depth32Bit

            Me.ImageList = AdImages
        Catch ex As Exception
            MessageBox.Show("The following error was encountered whilst attempting to load domain/container/OU icons: " & ex.Message, "Error Loading Icons", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RefreshNodes()

        Logger.Log("[Info] Refreshing Domain TreeView")

        ControlHelper.BeginControlUpdate(Me)
        Nodes.Clear()

        Dim ReportsNode As TreeNode = GetReportNodes()
        Nodes.Add(GetReportNodes)
        GetReportNodes.Expand()

        InitialLoad()
    End Sub

    Private Function GetReportNodes() As TreeNode

        Dim BuiltInTreeNode As ReportTreeNode = New ReportTreeNode("Quick Reports", "DomainImage", "DomainImage", Nothing)

        For Each Report As SimpleADReport In GetReports()
            Dim ReportNode As ReportTreeNode = New ReportTreeNode(Report.ReportName, Report.ImageKey, Report.SelecetdImageKey, Report)
            Dim ReportNodeCast As TreeNode = DirectCast(ReportNode, TreeNode)

            Report.Node = ReportNodeCast

            ReportNodeCast.Tag = ADNodeType.Report
            BuiltInTreeNode.Nodes.Add(ReportNodeCast)
        Next

        For Each ChildReport As SimpleADReport In GetChildReports()
            Dim ChildReportNode As ReportTreeNode = New ReportTreeNode(ChildReport.ReportName, ChildReport.ImageKey, ChildReport.SelecetdImageKey, ChildReport)

            ChildReportNode.Tag = ADNodeType.Report

            If ChildReport.ParentReportNode IsNot Nothing Then
                ChildReport.ParentReportNode.Nodes.Add(ChildReportNode)
            End If

        Next

        Return BuiltInTreeNode
    End Function

    Public Sub InitialLoad()
        Try

            DomainName = GetLocalDomainName()

            If String.IsNullOrEmpty(_DomainController) Then
                _DomainController = GetSingleDomainController()
            End If

            RootNode = New TreeNode
            Dim DomainObject As Domain = Domain.GetDomain(GetDomainContext)

            Using RootDirectoryEntry As DirectoryEntry = DomainObject.GetDirectoryEntry
                RootNode.ToolTipText = CStr(RootDirectoryEntry.Properties("distinguishedName").Value).Replace("/", "\/")
                RootNode.Name = RootNode.ToolTipText
            End Using
            RootNode.Text = DomainName
            RootNode.Tag = ADNodeType.Domain
            RootNode.ImageKey = "DomainImage"
            RootNode.SelectedImageKey = "DomainImage"
            InitialLoadFinished(RootNode, Nothing)

        Catch Ex As Exception
            Logger.Log("[Erorr] An error occured during the domain tree Inital Load: " & Ex.Message)
            InitialLoadFinished(Nothing, Ex.Message)
        End Try
    End Sub

    Private Sub InitialLoadFinished(ByVal RootNode As TreeNode, ByVal ErrorMessage As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of TreeNode, String)(AddressOf InitialLoadFinished), RootNode, ErrorMessage)
        Else
            If Not Me.IsDisposed Then
                Try
                    If String.IsNullOrEmpty(ErrorMessage) Then
                        RootNode.Nodes.Add(New TreeNode)
                        Me.Nodes.Add(RootNode)
                        RootNode.Expand()
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Public Sub LoadAdNodes(ByVal RootNodeObject As Object)
        Dim RootNode As TreeNode = DirectCast(RootNodeObject, TreeNode)
        Dim Children As New List(Of TreeNode)

        Try

            Dim RootDirectoryEntry As New DirectoryEntry(GetDirEntryPath() & ":389/" & RootNode.ToolTipText, LoginUsername, LoginPassword, AuthenticationTypes.Secure)

            RootDirectoryEntry.UsePropertyCache = True

            Using RootDirectoryEntry

                For Each ChildObject As DirectoryEntry In RootDirectoryEntry.Children
                    Try

                        Dim ChildObjectType As String = ChildObject.SchemaClassName

                        'Logger.Log(String.Format("[Schema Info] {0} - {1}", ChildObject.Name, ChildObject.SchemaClassName))

                        If (ChildObjectType = "organizationalUnit" OrElse ChildObjectType = "container" OrElse ChildObjectType = "builtinDomain" OrElse ChildObjectType = "lostAndFound" _
                                                        OrElse ChildObjectType = "msDS-QuotaContainer" OrElse ChildObjectType = "msTPM-InformationObjectsContainer" OrElse ChildObjectType = "msExchSystemObjectsContainer") Then

                            Dim ChildNode As New TreeNode
                            Dim NodeName As String = ChildObject.Properties("name").Value.ToString
                            ChildNode.Text = NodeName
                            ChildNode.Name = ChildObject.Properties("distinguishedName").Value.ToString
                            If ChildObjectType = "organizationalUnit" Then
                                ChildNode.Tag = ADNodeType.OU
                                ChildNode.ImageKey = "OuImage"
                                ChildNode.SelectedImageKey = "OuSelected"
                            ElseIf ChildObjectType = "container" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "ContainerImage"
                                ChildNode.SelectedImageKey = "ContainerSelected"
                            ElseIf ChildObjectType = "builtinDomain" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "Builtin"
                                ChildNode.SelectedImageKey = "Builtin"
                            ElseIf ChildObjectType = "lostAndFound" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "LostAndFound"
                                ChildNode.SelectedImageKey = "LostAndFound"
                            ElseIf ChildObjectType = "msDS-QuotaContainer" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "Quota"
                                ChildNode.SelectedImageKey = "Quota"
                            ElseIf ChildObjectType = "msTPM-InformationObjectsContainer" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "TPMImage"
                                ChildNode.SelectedImageKey = "TPMImage"
                            ElseIf ChildObjectType = "msExchSystemObjectsContainer" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "ExchSystemObject"
                                ChildNode.SelectedImageKey = "ExchSystemObject"
                            Else
                                ChildNode.Tag = ADNodeType.Unknown
                            End If
                            ChildNode.ToolTipText = CStr(ChildObject.Properties("distinguishedName").Value).Replace("/", "\/")

                            For Each ChildChildObject As DirectoryEntry In ChildObject.Children
                                Try
                                    If ChildChildObject.SchemaClassName = "organizationalUnit" OrElse ChildChildObject.SchemaClassName = "container" Then
                                        ChildNode.Nodes.Add(New TreeNode)
                                        Exit For
                                    End If
                                Finally
                                    ChildChildObject.Dispose()
                                End Try
                            Next

                            Children.Add(ChildNode)
                        End If
                    Finally
                        ChildObject.Dispose()
                    End Try
                Next
            End Using
            LoadFinished(True, Nothing, RootNode, Children)
        Catch Ex As Exception

        End Try
    End Sub

    Private Sub LoadFinished(ByVal Success As Boolean, ByVal Message As String, ByVal Node As TreeNode, ByVal NewChildren As List(Of TreeNode))
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of Boolean, String, TreeNode, List(Of TreeNode))(AddressOf LoadFinished), Success, Message, Node, NewChildren)
        Else
            If Not Me.IsDisposed Then
                Try
                    If Success Then
                        Node.Nodes.Clear()
                        For i As Integer = 0 To NewChildren.Count - 1
                            Node.Nodes.Add(NewChildren(i))
                        Next
                    Else
                        Logger.Log("[Error] Error Encountered During domain Tree View Load")
                    End If
                Catch ex As Exception
                    Logger.Log("[Error] Error adding completed node to tree: " & ex.Message)
                Finally
                    Me.TopNode.Expand()
                    ControlHelper.EndControlUpdate(Me)
                End Try
            End If
        End If
    End Sub

    Private Sub ControlDomainTreeView_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles Me.BeforeExpand
        Try
            Dim ExpandedNode As TreeNode = e.Node

            If Not ExpandedNode.Tag Is Nothing Then
                If CInt(ExpandedNode.Tag) <> ADNodeType.Report Then
                    If ExpandedNode.Nodes.Count > 0 Then
                        ControlHelper.BeginControlUpdate(Me)
                        Threading.ThreadPool.QueueUserWorkItem(Sub() LoadAdNodes(ExpandedNode))
                    End If
                End If
            End If
        Catch ex As Exception
            Logger.Log("[Error] Internal Error - Failed to get required information from expanded container node: " & ex.Message)
        End Try
    End Sub

    Private Sub ControlDomainTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Me.AfterSelect

        Try
            If Not CInt(e.Node.Tag) = 0 Then

                RaiseEvent SelectedContainerChanged(SelectedNode.ToolTipText, True)

                SelectedItem = SelectedNode.ToolTipText
                Exit Sub

            Else

                Try

                    Dim ReportNode As ReportTreeNode = DirectCast(e.Node, ReportTreeNode)

                    If ReportNode.SimpleADReport IsNot Nothing Then

                        RaiseEvent SelectedContainerChanged(ReportNode.SimpleADReport.ReportName, False)

                        Logger.Log("[Info] ReportRequested (" & e.Node.Text & ")")
                        RaiseEvent ReportRequested(DirectCast([Enum].Parse(GetType(SimpleADReportType), ReportNode.SimpleADReport.ImageKey), SimpleADReportType))

                    End If

                Catch Ex As Exception
                    Logger.Log("[Error] Failed to cast (" & e.Node.Text & ") to Type SimpleADReportType: " & Ex.Message)
                End Try

            End If

        Catch Ex As Exception
            Logger.Log("[Error] :" & Ex.Message)
        End Try
    End Sub

End Class
