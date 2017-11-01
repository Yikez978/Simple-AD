Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory
Imports System.Runtime.InteropServices
Imports SimpleLib

Public Class ControlDomainTreeView
    Inherits TreeView

    Private _DomainName As String
    Private _DomainController As String
    Private _SelectedOU As String

    Public Event SelectedOUChanged(ByVal Path As String)
    Public Event EveryThingSeleceted()
    Public Event DisabledUsersSeleceted()
    Public Event AllAdminsSeleceted()

    Public EverythingTreeNode As TreeNode = New TreeNode("Everything", 3, 3)
    Public DisabledUsersTreeNode As TreeNode = New TreeNode("Disabled Users", 4, 4)
    Public AllAdminsTreeNode As TreeNode = New TreeNode("All Admins", 5, 5)
    Public BuiltInTreeNode As TreeNode = New TreeNode("Built In Views", 2, 2, New TreeNode() {EverythingTreeNode, DisabledUsersTreeNode, AllAdminsTreeNode})

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

    Public Property SelectedOU As String
        Set(value As String)
            _SelectedOU = value
            RaiseEvent SelectedOUChanged(_SelectedOU)
        End Set
        Get
            Return _SelectedOU
        End Get
    End Property

#End Region

#Region "Double Buffer"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        SendMessage(Me.Handle, TVM_SETEXTENDEDSTYLE, New IntPtr(TVS_EX_DOUBLEBUFFER), New IntPtr(TVS_EX_DOUBLEBUFFER))
        MyBase.OnHandleCreated(e)
    End Sub
    ' Pinvoke:
    Private Const TVM_SETEXTENDEDSTYLE As Integer = &H1100 + 44
    Private Const TVM_GETEXTENDEDSTYLE As Integer = &H1100 + 45
    Private Const TVS_EX_DOUBLEBUFFER As Integer = &H4
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
    End Function

#End Region

    Public Sub New()

        Me.Margin = New Padding(0, 0, 0, 0)
        Me.HotTracking = True
        Me.ShowLines = False
        Me.ItemHeight = 22
        Me.Dock = DockStyle.Fill
        Me.FullRowSelect = True
        Me.Font = SystemFonts.DefaultFont
        Me.HideSelection = False
        Me.Nodes.Clear()
        Me.BuiltInTreeNode.Expand()

        WindowsApi.SetWindowTheme(Me.Handle, "explorer", Nothing)

        Try
            Dim AdImages As New ImageList()

            AdImages.Images.Add("OuImage", IconOU)
            AdImages.Images.Add("DomainImage", IconDomian)
            AdImages.Images.Add("ContainerImage", IconContainer)
            AdImages.Images.Add("EveryThingImage", IconSearch)
            AdImages.Images.Add("DisabledUsers", IconDisabledUSer)
            AdImages.Images.Add("Users", IconUser)
            AdImages.ColorDepth = ColorDepth.Depth24Bit
            AdImages.ImageSize = New Size(16, 16)

            Me.ImageList = AdImages
        Catch ex As Exception
            MessageBox.Show("The following error was encountered whilst attempting to load domain/container/OU icons: " & ex.Message, "Error Loading Icons", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RefreshNodes()
        BeginControlUpdate(Me)
        Nodes.Clear()
        Nodes.Add(BuiltInTreeNode)
        InitialLoad()
    End Sub

    Public Sub InitialLoad()
        Try

            DomainName = GetLocalDomainName()

            If String.IsNullOrEmpty(_DomainController) Then
                _DomainController = GetSingleDomainController()
            End If

            Dim RootNode = New TreeNode
            Dim DomainObject As Domain = Domain.GetDomain(GetDomainContext)

            Using RootDirectoryEntry As DirectoryEntry = DomainObject.GetDirectoryEntry
                RootNode.ToolTipText = CStr(RootDirectoryEntry.Properties("distinguishedName").Value).Replace("/", "\/")
            End Using
            RootNode.Text = DomainName
            RootNode.Name = DomainName
            RootNode.Tag = ADNodeType.Domain
            RootNode.ImageKey = "DomainImage"
            RootNode.SelectedImageKey = "DomainImage"
            InitialLoadFinished(RootNode, Nothing)

        Catch Ex As Exception
            Debug.WriteLine("[Erorr] An error occured during the domain tree Inital Load: " & Ex.Message)
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

            Using RootDirectoryEntry

                For Each ChildObject As DirectoryEntry In RootDirectoryEntry.Children
                    Try

                        Dim ChildObjectType As String = ChildObject.SchemaClassName

                        If ChildObjectType = "organizationalUnit" OrElse ChildObjectType = "container" Then

                            Dim ChildNode As New TreeNode
                            Dim NodeName As String = CStr(ChildObject.Properties("name").Value)
                            ChildNode.Text = NodeName
                            ChildNode.Name = ChildObject.Properties("distinguishedName").Value
                            If ChildObjectType = "organizationalUnit" Then
                                ChildNode.Tag = ADNodeType.OU
                                ChildNode.ImageKey = "OuImage"
                                ChildNode.SelectedImageKey = "OuImage"
                            ElseIf ChildObjectType = "container" Then
                                ChildNode.Tag = ADNodeType.Container
                                ChildNode.ImageKey = "ContainerImage"
                                ChildNode.SelectedImageKey = "ContainerImage"
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
            LoadFinished(True, Nothing, RootNodeObject, Children)
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
                        Debug.WriteLine("[Error] Error Encountered During domain Tree View Load")
                    End If
                Catch ex As Exception
                    Debug.WriteLine("[Error] Error adding completed node to tree: " & ex.Message)
                Finally
                    EndControlUpdate(Me)
                End Try
            End If
        End If
    End Sub

    Private Sub ControlDomainTreeView_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles Me.BeforeExpand
        Try
            Dim ExpandedNode As TreeNode = e.Node

            If Not ExpandedNode.Tag Is Nothing Then
                If ExpandedNode.Tag.GetType = GetType(ADNodeType) Then
                    If ExpandedNode.Nodes.Count > 0 Then
                        Dim bgThread As New Threading.Thread(AddressOf LoadAdNodes)
                        bgThread.Start(ExpandedNode)
                    End If
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("[Error] Internal Error - Failed to get required information from expanded container node: " & ex.Message)
        End Try
    End Sub

    Private Sub ControlDomainTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Me.AfterSelect
        If Not e.Node Is Nothing Then
            Select Case SelectedNode.Text
                Case "Built In Views"
                Case "All Admins"
                    RaiseEvent AllAdminsSeleceted()
                Case "Disabled Users"
                    RaiseEvent DisabledUsersSeleceted()
                Case "Everything"
                    RaiseEvent EveryThingSeleceted()
                Case Else
                    If Not e.Node.ToolTipText Is Nothing Then
                        SelectedOU = SelectedNode.ToolTipText
                        RaiseEvent SelectedOUChanged(e.Node.ToolTipText)
                        FormMain.ToolStripStatusLabelStatus.Text = SelectedOU
                    End If
            End Select
        End If
    End Sub

End Class
