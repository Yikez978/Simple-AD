Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class DomainTreeContainer

    Private _Container As Object

    Public Sub New(ByVal container As Object)
        InitializeComponent()

        _Container = container
        Me.Dock = DockStyle.Fill

        InitialLoad()

    End Sub

    Private Sub InitialLoad()

        Try
            If String.IsNullOrEmpty(_DomainName) Then
                DomainName = GetLocalDomainName()
            End If
            If String.IsNullOrEmpty(_DomainController) Then
                _DomainController = GetSingleDomainController(GetLocalDomainName, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)
            End If

            Dim RootNode = New DomainTreeContainerItem
            Dim DomainObject As Domain = Domain.GetDomain(GetDomainContext(Environment.UserDomainName, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword))

            Using RootDirectoryEntry As DirectoryEntry = DomainObject.GetDirectoryEntry
                RootNode.DistinguishedName = CStr(RootDirectoryEntry.Properties("distinguishedName").Value).Replace("/", "\/")
            End Using
            RootNode.Indent = 10 + 17
            RootNode.DisplayName = DomainName
            RootNode.DomainContainer = Me
            RootNode.ItemType = DomainTreeContainerItem.NodeType.Domain

            InitialLoadFinished(RootNode, Nothing)

        Catch ex As Exception
            InitialLoadFinished(Nothing, ex.Message)
        End Try
    End Sub

    Private Sub InitialLoadFinished(ByVal RootNode As DomainTreeContainerItem, ByVal ErrorMessage As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of DomainTreeContainerItem, String)(AddressOf InitialLoadFinished), RootNode, ErrorMessage)
        Else
            If Not Me.IsDisposed Then
                Try
                    If String.IsNullOrEmpty(ErrorMessage) Then

                        RootNode.Nodes.Add(New DomainTreeContainerItem With {.DomainContainer = Me, .DisplayName = "Loading..."})
                        Me.Controls.Add(RootNode)
                        LoadAdNodes(RootNode)
                        'Dim bgThread As New System.Threading.Thread(AddressOf LoadAdNodes)
                        'bgThread.Start(RootNode)
                    Else
                        MessageBox.Show("The domain tree load could not be completed due to the following error: " & ErrorMessage &
                                        vbNewLine & "Verify that the domain name specified is correct (and is a fully qualified DNS domain name) and the credentials used are valid.", "Error Encountered During Domain Tree Load", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Finally

                End Try
            End If
        End If
    End Sub

    Public Sub LoadAdNodes(ByVal RootNodeObject As Object)
        Dim RootNode As DomainTreeContainerItem = DirectCast(RootNodeObject, DomainTreeContainerItem)
        Dim Children As New List(Of DomainTreeContainerItem)

        'Try

        Dim RootDirectoryEntry As New DirectoryEntry(GetDirEntry() & ":389/" & RootNode.DistinguishedName)

        Using RootDirectoryEntry

            RootDirectoryEntry.AuthenticationType = AuthenticationTypes.Secure

            RootDirectoryEntry.Username = GlobalVariables.LoginUsername
            RootDirectoryEntry.Password = GlobalVariables.LoginPassword

            For Each ChildObject As DirectoryEntry In RootDirectoryEntry.Children
                Try

                    Dim ChildObjectType As String = ChildObject.SchemaClassName

                    If ChildObjectType = "organizationalUnit" OrElse ChildObjectType = "container" Then

                        Dim ChildNode As New DomainTreeContainerItem
                        ChildNode.DisplayName = CStr(ChildObject.Properties("name").Value)
                        If ChildObjectType = "organizationalUnit" Then
                            ChildNode.ItemType = DomainTreeContainerItem.NodeType.OU
                        ElseIf ChildObjectType = "container" Then
                            ChildNode.ItemType = DomainTreeContainerItem.NodeType.Container
                        Else
                            ChildNode.ItemType = DomainTreeContainerItem.NodeType.Unknown
                        End If

                        ChildNode.DomainContainer = Me
                        ChildNode.DistinguishedName = CStr(ChildObject.Properties("distinguishedName").Value).Replace("/", "\/")

                        For Each ChildChildObject As DirectoryEntry In ChildObject.Children
                            Try
                                If ChildChildObject.SchemaClassName = "organizationalUnit" OrElse ChildChildObject.SchemaClassName = "container" Then
                                    ChildNode.Nodes.Add(New DomainTreeContainerItem With {.DomainContainer = Me, .DisplayName = "Loading..."})
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
        'Catch ex As Exception
        'LoadFinished(False, "The following error was encountered whilst trying to load the domain objects: " & ex.Message, Nothing, Nothing)
        'End Try
    End Sub

    Private Sub LoadFinished(ByVal Success As Boolean, ByVal Message As String, ByVal Node As DomainTreeContainerItem, ByVal NewChildren As List(Of DomainTreeContainerItem))
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of Boolean, String, DomainTreeContainerItem, List(Of DomainTreeContainerItem))(AddressOf LoadFinished), Success, Message, Node, NewChildren)
        Else
            If Not Me.IsDisposed Then
                Try
                    If Success Then
                        Node.Nodes.Clear()
                        For i As Integer = 0 To NewChildren.Count - 1
                            Node.Nodes.Add(NewChildren(i))
                        Next

                    Else
                        MessageBox.Show(Message, "Error Encountered During Load", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error adding completed node to tree: " & ex.Message, "Error Encountered During Node Add", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
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

End Class
