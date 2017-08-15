Imports System.DirectoryServices

Public Class ControlDomainTreeContainerItem

    Enum NodeType
        Domain
        Container
        OU
        Unknown
    End Enum

    Private _DistinguishedName As String
    Private _Type As NodeType
    Private _DisplayName As String
    Private _DomainContainer As ControlDomainTreeContainer
    Private _Indent As Integer
    Private _Working As Boolean

    Public Property Indent As Integer
        Set(value As Integer)
            _Indent = value
            Me.MainPl.Location = New Point(_Indent, Me.Location.Y)
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

    Public Property DomainContainer As ControlDomainTreeContainer
        Set(value As ControlDomainTreeContainer)
            _DomainContainer = value
        End Set
        Get
            Return _DomainContainer
        End Get
    End Property

    Public Property Working As Boolean
        Set(value As Boolean)
            _Working = value
        End Set
        Get
            Return _Working
        End Get
    End Property

    Public Property ItemType As NodeType
        Set(value As NodeType)
            _Type = value

            Select Case _Type
                Case NodeType.Container
                    Me.IconBox.Image = IconContainer
                Case NodeType.OU
                    Me.IconBox.Image = IconOU
                Case NodeType.Domain
                    Me.IconBox.Image = IconDomian
                Case NodeType.Unknown
                    Me.IconBox.Image = IconContainer
            End Select

        End Set
        Get
            Return _Type
        End Get
    End Property

    Public Property Nodes As New List(Of ControlDomainTreeContainerItem)
    Public Property Expanded As Boolean

    Public Sub New()

        InitializeComponent()

        DomainItems.Add(Me)
        Me.Expanded = False
        Me.Working = False

        Dim X As Integer = Me.Location.X
        Dim Y As Integer = Me.Location.Y

        Me.Location = New Point(X, Y - 2)

        AddHandler MyBase.DoubleClick, AddressOf DomainTreeContainerItem_Click
        AddHandler MainLb.DoubleClick, AddressOf DomainTreeContainerItem_Click
        AddHandler MainPl.DoubleClick, AddressOf DomainTreeContainerItem_Click

        AddHandler MainLb.MouseEnter, AddressOf MouseHoverMe
        AddHandler MainPl.MouseEnter, AddressOf MouseHoverMe
        AddHandler IconBox.MouseEnter, AddressOf MouseHoverMe
        AddHandler PictureBox.MouseEnter, AddressOf MouseHoverMe

        AddHandler MainLb.Click, AddressOf Me_Click
        AddHandler MainPl.Click, AddressOf Me_Click
        AddHandler IconBox.Click, AddressOf Me_Click
    End Sub

    Public Sub Expand()
        If Not Me.DomainContainer.IsWorkinig Then
            Me.Expanded = True
            DomainContainer.RaiseWorkinigState(True)
            Dim LoadNodes As New Threading.Thread(AddressOf LoadAdNodes)
            LoadNodes.IsBackground = True
            LoadNodes.Start(Me)
        End If
    End Sub

    Public Sub Collapse()
        If Not Me.DomainContainer.IsWorkinig Then
            DomainContainer.RaiseWorkinigState(True)
            Me.SuspendLayout()
            Me.MainFl.Controls.Clear()
            Me.Expanded = False
            Me.PictureBox.Image = My.Resources.Right
            Me.ResumeLayout()
            DomainContainer.RaiseWorkinigState(False)
        End If
    End Sub

    Private Sub DomainTreeContainerItem_Click(sender As Object, e As MouseEventArgs) Handles PictureBox.Click

        ClearOtherContactsClick()

        If e.Button = MouseButtons.Left Then
            If Me.Expanded = False Then
                Me.Expand()
            Else
                Collapse()
            End If
        End If
    End Sub



    Public Sub LoadAdNodes(ByVal RootNodeObject As Object)
        Dim RootNode As ControlDomainTreeContainerItem = DirectCast(RootNodeObject, ControlDomainTreeContainerItem)
        Dim Children As New List(Of ControlDomainTreeContainerItem)

        Try

            Dim RootDirectoryEntry As New DirectoryEntry(GetDirEntryPath() & ":389/" & RootNode.DistinguishedName)

            Using RootDirectoryEntry

                RootDirectoryEntry.AuthenticationType = AuthenticationTypes.Secure

                RootDirectoryEntry.Username = LoginUsername
                RootDirectoryEntry.Password = LoginPassword

                For Each ChildObject As DirectoryEntry In RootDirectoryEntry.Children
                    Try

                        Dim ChildObjectType As String = ChildObject.SchemaClassName

                        If ChildObjectType = "organizationalUnit" OrElse ChildObjectType = "container" Then

                            Dim ChildNode As New ControlDomainTreeContainerItem
                            ChildNode.DisplayName = CStr(ChildObject.Properties("name").Value)
                            If ChildObjectType = "organizationalUnit" Then
                                ChildNode.ItemType = ControlDomainTreeContainerItem.NodeType.OU
                            ElseIf ChildObjectType = "container" Then
                                ChildNode.ItemType = ControlDomainTreeContainerItem.NodeType.Container
                            Else
                                ChildNode.ItemType = ControlDomainTreeContainerItem.NodeType.Unknown
                            End If

                            ChildNode.DomainContainer = Me.DomainContainer
                            ChildNode.DistinguishedName = CStr(ChildObject.Properties("distinguishedName").Value).Replace("/", "\/")

                            For Each ChildChildObject As DirectoryEntry In ChildObject.Children
                                Try
                                    If ChildChildObject.SchemaClassName = "organizationalUnit" OrElse ChildChildObject.SchemaClassName = "container" Then
                                        ChildNode.Nodes.Add(New ControlDomainTreeContainerItem With {.DomainContainer = Me.DomainContainer, .DisplayName = "Loading..."})
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

    Private Sub LoadFinished(ByVal Success As Boolean, ByVal Message As String, ByVal Node As ControlDomainTreeContainerItem, ByVal NewChildren As List(Of ControlDomainTreeContainerItem))
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of Boolean, String, ControlDomainTreeContainerItem, List(Of ControlDomainTreeContainerItem))(AddressOf LoadFinished), Success, Message, Node, NewChildren)
        Else
            If Not Me.IsDisposed Then
                Try
                    If Success Then
                        Node.Nodes.Clear()
                        For i As Integer = 0 To NewChildren.Count - 1
                            Node.Nodes.Add(NewChildren(i))
                        Next
                    Else
                        Debug.WriteLine("[Error] Error Encountered During Load")
                    End If
                Catch ex As Exception
                    Debug.WriteLine("[Error] Error adding completed node to tree: " & ex.Message)
                Finally

                    If Me.Nodes.Count > 0 Then

                        Me.PictureBox.Image = My.Resources.Down
                        Me.SuspendLayout()

                        For Each DomainTreeContainerItem As ControlDomainTreeContainerItem In Me.Nodes
                            Dim NewNode = New ControlDomainTreeContainerItem With
                            {.DisplayName = DomainTreeContainerItem.DisplayName,
                            .ItemType = DomainTreeContainerItem.ItemType,
                            .DomainContainer = DomainTreeContainerItem.DomainContainer,
                            .DistinguishedName = DomainTreeContainerItem.DistinguishedName,
                            .Indent = Me.Indent + 20
                            }
                            MainFl.Controls.Add(NewNode)
                        Next

                        Me.ResumeLayout()
                    Else
                        Me.PictureBox.Image = Nothing
                    End If
                End Try
            End If
            DomainContainer.RaiseWorkinigState(False)
        End If
    End Sub

    Private Sub MouseHoverMe(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If Not Me.ItemType = NodeType.Domain Then
            If Not Me.BackColor = Color.FromArgb(211, 191, 221) Then
                SuspendLayout()
                ClearOtherContactsHover()
                Me.BackColor = Color.FromArgb(240, 240, 240) '238, 238, 238)
                ResumeLayout()
            End If
        Else
            ClearOtherContactsHover()
        End If
    End Sub

    Private Sub ClearOtherContactsHover()
        SuspendLayout()
        For Each Node As ControlDomainTreeContainerItem In DomainItems
            If Not Node.BackColor = Color.FromArgb(211, 191, 221) Then
                Node.BackColor = Color.Transparent
            End If
        Next
        ResumeLayout()
    End Sub

    Private Sub ClearOtherContactsClick()
        For Each Node As ControlDomainTreeContainerItem In DomainItems
            Node.BackColor = Color.Transparent
        Next
    End Sub

    Private Sub Me_Click(sender As Object, e As EventArgs) Handles MainPl.Click
        If Not Me.ItemType = NodeType.Domain Then
            ClearOtherContactsClick()
            Me.BackColor = Color.FromArgb(211, 191, 221)

            SelectedOU = Me.DistinguishedName
            FormMain.ToolStripStatusLabelStatus.Text = SelectedOU
        End If
    End Sub
End Class
