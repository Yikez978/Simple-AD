Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class ControlDomainTreeContainer

    Private _Container As Object
    Private _DomainName As String
    Private _DomainController As String
    Private _isWorking As Boolean

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

    Property IsWorkinig As Boolean
        Set(value As Boolean)
            _isWorking = value
        End Set
        Get
            Return _isWorking
        End Get
    End Property

    Public Event Working(ByVal State As Boolean)

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
                _DomainController = GetSingleDomainController(LoginUsername, LoginPassword)
            End If

            Dim RootNode = New ControlDomainTreeContainerItem
            Dim DomainObject As Domain = Domain.GetDomain(GetDomainContext(LoginUsername, LoginPassword))

            Using RootDirectoryEntry As DirectoryEntry = DomainObject.GetDirectoryEntry
                RootNode.DistinguishedName = CStr(RootDirectoryEntry.Properties("distinguishedName").Value).Replace("/", "\/")
            End Using
            RootNode.Indent = 0
            RootNode.DisplayName = DomainName
            RootNode.DomainContainer = Me
            RootNode.ItemType = ControlDomainTreeContainerItem.NodeType.Domain

            InitialLoadFinished(RootNode, Nothing)

        Catch ex As Exception
            InitialLoadFinished(Nothing, ex.Message)
        End Try
    End Sub

    Private Sub InitialLoadFinished(ByVal RootNode As ControlDomainTreeContainerItem, ByVal ErrorMessage As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of ControlDomainTreeContainerItem, String)(AddressOf InitialLoadFinished), RootNode, ErrorMessage)
        Else
            If Not Me.IsDisposed Then
                Try
                    If String.IsNullOrEmpty(ErrorMessage) Then

                        RootNode.Nodes.Add(New ControlDomainTreeContainerItem With {.DomainContainer = Me, .DisplayName = "Loading..."})
                        Me.Controls.Add(RootNode)
                        RootNode.Dock = DockStyle.Top
                        RootNode.Expand()
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub ControlDomainTreeContainer_Working(ByVal State As Boolean) Handles Me.Working
        Me.IsWorkinig = State
    End Sub

    Public Sub RaiseWorkinigState(ByVal State As Boolean)
        RaiseEvent Working(State)
    End Sub
End Class
