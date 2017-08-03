Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class DomianTree

    Private _Container As Object

    Public Sub New(ByVal container As Object)
        InitializeComponent()

        _Container = container

        Try
            Dim AdImages As New ImageList()

            AdImages.Images.Add("OUFolder", ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.OU).ToBitmap)
            AdImages.Images.Add("DomainImage", ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.Domain).ToBitmap)
            AdImages.Images.Add("ContainerImage", ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.Container).ToBitmap)
            OUTreeView.ImageList = AdImages
        Catch ex As Exception
            MessageBox.Show("The following error was encountered whilst attempting to load domain/container/OU icons: " & ex.Message, "Error Loading Icons", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        AddHandler OUTreeView.BeforeExpand, AddressOf TreeView_BeforeExpand
        AddHandler OUTreeView.AfterSelect, AddressOf TreeView_AfterSelect
        AddHandler OUTreeView.AfterExpand, AddressOf OUTreeView_AfterExpand
        AddHandler OUTreeView.AfterCollapse, AddressOf OUTreeView_AfterCollapse


        InitialLoad()

    End Sub

    Private Sub DisableForm()
        Me.Enabled = False
    End Sub

    Private Sub EnableForm()
        Me.Enabled = True
    End Sub

    Private Sub TreeView_BeforeExpand(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs)
        Try
            Dim ExpandedNode As AdTreeNode = DirectCast(e.Node, AdTreeNode)
            If ExpandedNode.Nodes.Count > 0 Then
                DisableForm()
                Dim bgThread As New System.Threading.Thread(AddressOf LoadAdNodes)
                bgThread.Start(ExpandedNode)
            End If
        Catch ex As Exception
            MessageBox.Show("Internal Error - Failed to get required information from expanded container node: " & ex.Message, "Container Expand Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EnableForm()
        End Try
    End Sub

    Private Sub TreeView_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs)
        If Not (OUTreeView.SelectedNode Is Nothing) Then
            GlobalVariables.SelectedOU = DirectCast(OUTreeView.SelectedNode, AdTreeNode).DistinguishedName
            MainApplicationForm.ToolStripStatusLabelStatus.Text = GlobalVariables.SelectedOU
            _Container.AcceptBt.Enabled = True
        End If

        OUTreeView.SelectedNode = e.Node

    End Sub

    Private Sub InitialLoad()

        Try
            If String.IsNullOrEmpty(_DomainName) Then
                DomainName = GetLocalDomainName()
            End If
            If String.IsNullOrEmpty(_DomainController) Then
                _DomainController = GetSingleDomainController(GetLocalDomainName, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)
            End If

            Dim RootNode As New AdTreeNode
            Dim DomainObject As Domain = Domain.GetDomain(GetDomainContext(Environment.UserDomainName, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword))
            Using RootDirectoryEntry As DirectoryEntry = DomainObject.GetDirectoryEntry
                RootNode.DistinguishedName = CStr(RootDirectoryEntry.Properties("distinguishedName").Value).Replace("/", "\/")
            End Using
            RootNode.DisplayName = DomainName
            RootNode.Type = AdTreeNode.AdObjectType.Domain
            InitialLoadFinished(RootNode, Nothing)
        Catch ex As Exception
            InitialLoadFinished(Nothing, ex.Message)
        End Try
    End Sub

    Private Sub InitialLoadFinished(ByVal RootNode As AdTreeNode, ByVal ErrorMessage As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of AdTreeNode, String)(AddressOf InitialLoadFinished), RootNode, ErrorMessage)
        Else
            If Not Me.IsDisposed Then
                Try
                    If String.IsNullOrEmpty(ErrorMessage) Then

                        RootNode.Nodes.Add(New AdTreeNode With {.DisplayName = "Loading..."})
                        OUTreeView.Nodes.Add(RootNode)
                        Dim bgThread As New System.Threading.Thread(AddressOf LoadAdNodes)
                        bgThread.Start(RootNode)
                    Else
                        MessageBox.Show("The domain tree load could not be completed due to the following error: " & ErrorMessage &
                                        vbNewLine & "Verify that the domain name specified is correct (and is a fully qualified DNS domain name) and the credentials used are valid.", "Error Encountered During Domain Tree Load", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Finally
                    EnableForm()
                End Try
            End If
        End If
    End Sub

    Private Sub LoadAdNodes(ByVal RootNodeObject As Object)
        Dim RootNode As AdTreeNode = DirectCast(RootNodeObject, AdTreeNode)
        Dim Children As New List(Of AdTreeNode)
        Try

            Dim RootDirectoryEntry As New DirectoryEntry(GetDirEntry() & ":389/" & RootNode.DistinguishedName)

            Using RootDirectoryEntry

                RootDirectoryEntry.AuthenticationType = AuthenticationTypes.Secure

                RootDirectoryEntry.Username = GlobalVariables.LoginUsername
                RootDirectoryEntry.Password = GlobalVariables.LoginPassword

                For Each ChildObject As DirectoryEntry In RootDirectoryEntry.Children
                    Try
                        Dim ChildObjectType As String = ChildObject.SchemaClassName
                        If ChildObjectType = "organizationalUnit" OrElse ChildObjectType = "container" Then
                            Dim ChildNode As New AdTreeNode
                            ChildNode.DisplayName = CStr(ChildObject.Properties("name").Value)
                            If ChildObjectType = "organizationalUnit" Then
                                ChildNode.Type = AdTreeNode.AdObjectType.OU
                            ElseIf ChildObjectType = "container" Then
                                ChildNode.Type = AdTreeNode.AdObjectType.Container
                            Else
                                ChildNode.Type = AdTreeNode.AdObjectType.Unknown
                            End If
                            ChildNode.DistinguishedName = CStr(ChildObject.Properties("distinguishedName").Value).Replace("/", "\/")
                            For Each ChildChildObject As DirectoryEntry In ChildObject.Children
                                Try
                                    If ChildChildObject.SchemaClassName = "organizationalUnit" OrElse ChildChildObject.SchemaClassName = "container" Then
                                        ChildNode.Nodes.Add(New AdTreeNode With {.DisplayName = "Loading..."})
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
            Children.Sort()
            LoadFinished(True, Nothing, DirectCast(RootNodeObject, AdTreeNode), Children)
        Catch ex As Exception
            LoadFinished(False, "The following error was encountered whilst trying to load the domain objects: " & ex.Message, Nothing, Nothing)
        End Try
    End Sub

    Private Sub LoadFinished(ByVal Success As Boolean, ByVal Message As String, ByVal Node As AdTreeNode, ByVal NewChildren As List(Of AdTreeNode))
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of Boolean, String, AdTreeNode, List(Of AdTreeNode))(AddressOf LoadFinished), Success, Message, Node, NewChildren)
        Else
            If Not Me.IsDisposed Then
                Try
                    If Success Then
                        Node.Nodes.Clear()
                        For i As Integer = 0 To NewChildren.Count - 1
                            Node.Nodes.Add(NewChildren(i))
                        Next
                        OUTreeView.Nodes(0).Expand()

                    Else
                        MessageBox.Show(Message, "Error Encountered During Load", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error adding completed node to tree: " & ex.Message, "Error Encountered During Node Add", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    Dim TreeViewHeight As Integer = GetOpenedNodesRecursively(OUTreeView)
                    OUTreeView.Size = New Size(OUTreeView.Width, TreeViewHeight)
                    EnableForm()

                    Me.Visible = True
                End Try
            End If
        End If
    End Sub

#Region "Properties"

    Private _SelectedContainerPath As String = String.Empty
    Public ReadOnly Property SelectedContainerPath() As String
        Get
            Return _SelectedContainerPath
        End Get
    End Property

    Private _Username As String = String.Empty
    Public WriteOnly Property Username() As String
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property

    Private _Password As String = String.Empty
    Public WriteOnly Property Password() As String
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Private _DomainName As String = String.Empty
    Friend WithEvents TreeView As TreeView

    Public Property DomainName() As String
        Get
            Return _DomainName
        End Get
        Set(ByVal value As String)
            _DomainName = value
        End Set
    End Property

#End Region

    Private _DomainController As String = String.Empty

    Public Function GetOU()
        Return _SelectedContainerPath
    End Function

    Private Sub OUTreeView_AfterExpand(sender As Object, e As TreeViewEventArgs)
        Dim TreeViewHeight As Integer = GetOpenedNodesRecursively(OUTreeView)
        OUTreeView.Size = New Size(OUTreeView.Width, TreeViewHeight)
    End Sub

    Private Function GetOpenedNodesRecursively(ByVal aTreeView As TreeView)
        Dim Y As Integer = 0

        For Each n As TreeNode In aTreeView.Nodes
            Y += OUTreeView.ItemHeight
            If n.IsExpanded Then Y += RecursiveYIncrement(n)
        Next

        Return Y
    End Function

    Private Function RecursiveYIncrement(ByVal n As TreeNode)
        Dim Y As Integer = 0

        For Each aNode As TreeNode In n.Nodes
            Y += OUTreeView.ItemHeight
            If aNode.IsExpanded Then Y += RecursiveYIncrement(aNode)
        Next

        Return Y
    End Function

    Private Sub OUTreeView_AfterCollapse(sender As Object, e As TreeViewEventArgs)
        Dim TreeViewHeight As Integer = GetOpenedNodesRecursively(OUTreeView)

        OUTreeView.Size = New Size(OUTreeView.Width, TreeViewHeight)
    End Sub
End Class
