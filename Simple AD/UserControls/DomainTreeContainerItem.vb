Imports System.DirectoryServices

Public Class DomainTreeContainerItem

    Enum NodeType
        Domain
        Container
        OU
        Unknown
    End Enum

    Private _DistinguishedName As String
    Private _Type As NodeType
    Private _DisplayName As String
    Private _Container As TableLayoutPanel
    Private _DomainContainer As DomainTreeContainer
    Private _Indent As Integer

    Public Property Indent As Integer
        Set(value As Integer)
            _Indent = value
            Me.MainLb.Location = New Point(_Indent, Me.Location.Y)
            Me.PictureBox.Location = New Point(_Indent - 22, Me.Location.Y)
        End Set
        Get
            Return _Indent
        End Get
    End Property

    Public Property DistinguishedName As String
        Set(value As String)
            _DistinguishedName = value
        End Set
        Get
            Return _DistinguishedName
        End Get
    End Property

    Public Property DisplayName As String
        Set(value As String)
            _DisplayName = value
            Me.MainLb.Text = value
        End Set
        Get
            Return _DisplayName
        End Get
    End Property

    Public Property BaseContainer As TableLayoutPanel
        Set(value As TableLayoutPanel)
            _Container = value
        End Set
        Get
            Return _Container
        End Get
    End Property

    Public Property DomainContainer As DomainTreeContainer
        Set(value As DomainTreeContainer)
            _DomainContainer = value
        End Set
        Get
            Return _DomainContainer
        End Get
    End Property

    Public Property ItemType As NodeType
        Set(value As NodeType)
            _Type = value
            Me.MainLb.Text = Me.MainLb.Text & " - " & value.ToString
        End Set
        Get
            Return _Type
        End Get
    End Property

    Public Property Nodes As New List(Of DomainTreeContainerItem)
    Public Property Expanded As Boolean

    Public Sub New()
        InitializeComponent()
        Me.Expanded = False
    End Sub

    Private Sub Expand()
        Me.Expanded = True
        Me.PictureBox.Image = My.Resources.Down

        LoadAdNodes(Me)

        For Each DomainTreeContainerItem As DomainTreeContainerItem In Me.Nodes
            Dim NewNode = New DomainTreeContainerItem With
                {.DisplayName = DomainTreeContainerItem.DisplayName,
                .BaseContainer = DomainTreeContainerItem.BaseContainer,
                .ItemType = DomainTreeContainerItem.ItemType,
                .DistinguishedName = DomainTreeContainerItem.DistinguishedName,
                .Indent = Me.Indent + 30
                }
            MainFl.Controls.Add(NewNode)
        Next
    End Sub

    Private Sub Collapse()
        Me.MainFl.Controls.Clear()
        Me.Expanded = False
        Me.PictureBox.Image = My.Resources.Right
    End Sub

    Private Sub DomainTreeContainerItem_Click(sender As Object, e As MouseEventArgs) Handles MainLb.Click
        If e.Button = MouseButtons.Left Then
            If Me.Nodes.Count > 0 Then
                If Me.Expanded = False Then
                    Me.Expand()
                Else
                    Collapse()
                End If
            Else
                Me.PictureBox.Image = Nothing
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

                        ChildNode.DomainContainer = Me.DomainContainer
                        ChildNode.DistinguishedName = CStr(ChildObject.Properties("distinguishedName").Value).Replace("/", "\/")
                        ChildNode.BaseContainer = Me.BaseContainer

                        For Each ChildChildObject As DirectoryEntry In ChildObject.Children
                            Try
                                If ChildChildObject.SchemaClassName = "organizationalUnit" OrElse ChildChildObject.SchemaClassName = "container" Then
                                    ChildNode.Nodes.Add(New DomainTreeContainerItem With {.DomainContainer = Me.DomainContainer, .BaseContainer = Me.BaseContainer, .DisplayName = "Loading..."})
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
End Class
