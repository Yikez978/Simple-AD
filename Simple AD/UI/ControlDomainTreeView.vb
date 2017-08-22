Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class ControlDomainTreeView
    Inherits TreeView

    Private _DomainName As String
    Private _DomainController As String
    Private _SelectedOU As String

    Public Event SelectedOUChanged(ByVal Path As String)

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

    Public Sub New()
        WindowsApi.SetWindowTheme(Me.Handle, "explorer", Nothing)
        Me.Margin = New Padding(0, 0, 0, 0)
        Me.HotTracking = True
        Me.ShowLines = False
        Me.ItemHeight = 22
        Me.Dock = DockStyle.Fill
        Me.FullRowSelect = True
        Me.Font = SystemFonts.DefaultFont
        Me.HideSelection = False
        Me.Nodes.Clear()

        Try
            Dim AdImages As New ImageList()

            AdImages.Images.Add("OuImage", IconOU)
            AdImages.Images.Add("DomainImage", IconDomian)
            AdImages.Images.Add("ContainerImage", IconContainer)

            AdImages.ColorDepth = ColorDepth.Depth24Bit
            AdImages.ImageSize = New Size(16, 16)

            Me.ImageList = AdImages
        Catch ex As Exception
            MessageBox.Show("The following error was encountered whilst attempting to load domain/container/OU icons: " & ex.Message, "Error Loading Icons", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub InitialLoad()
        Try
            If String.IsNullOrEmpty(_DomainName) Then
                DomainName = GetLocalDomainName()
            End If
            If String.IsNullOrEmpty(_DomainController) Then
                _DomainController = GetSingleDomainController(LoginUsername, LoginPassword)
            End If

            Dim RootNode = New TreeNode
            Dim DomainObject As Domain = Domain.GetDomain(GetDomainContext(LoginUsername, LoginPassword))

            Using RootDirectoryEntry As DirectoryEntry = DomainObject.GetDirectoryEntry
                RootNode.ToolTipText = CStr(RootDirectoryEntry.Properties("distinguishedName").Value).Replace("/", "\/")
            End Using
            RootNode.Text = DomainName
            RootNode.Name = DomainName
            RootNode.Tag = ADNodeType.Domain
            RootNode.ImageKey = "DomainImage"
            RootNode.SelectedImageKey = "DomainImage"
            InitialLoadFinished(RootNode, Nothing)

        Catch ex As Exception
            InitialLoadFinished(Nothing, ex.Message)
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

            Dim RootDirectoryEntry As New DirectoryEntry(GetDirEntryPath() & ":389/" & RootNode.ToolTipText)

            Using RootDirectoryEntry

                RootDirectoryEntry.AuthenticationType = AuthenticationTypes.Secure

                RootDirectoryEntry.Username = LoginUsername
                RootDirectoryEntry.Password = LoginPassword

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
            Debug.WriteLine("[Error] Error Loading Nodes: " & Ex.Message)
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
                    ResumeLayout()
                End Try
            End If
        End If
    End Sub

    Private Sub ControlDomainTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Me.AfterSelect
        If Not (SelectedNode Is Nothing) Then
            GlobalVariables.SelectedOU = SelectedNode.ToolTipText
            RaiseEvent SelectedOUChanged(e.Node.ToolTipText)
            FormMain.ToolStripStatusLabelStatus.Text = GlobalVariables.SelectedOU
        End If
    End Sub

    Private Sub ControlDomainTreeView_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles Me.BeforeExpand
        Try
            Dim ExpandedNode As TreeNode = e.Node
            If ExpandedNode.Nodes.Count > 0 Then
                Dim bgThread As New Threading.Thread(AddressOf LoadAdNodes)
                bgThread.Start(ExpandedNode)
            End If
        Catch ex As Exception
            Debug.WriteLine("[Error] Internal Error - Failed to get required information from expanded container node: " & ex.Message, "Container Expand Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
