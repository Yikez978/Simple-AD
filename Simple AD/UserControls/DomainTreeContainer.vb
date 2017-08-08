﻿Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class DomainTreeContainer

    Private _Container As Object
    Private _DomainName As String
    Private _DomainController As String

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
            RootNode.Indent = 0
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
                        RootNode.Dock = DockStyle.Top
                        RootNode.Expand()
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

End Class
