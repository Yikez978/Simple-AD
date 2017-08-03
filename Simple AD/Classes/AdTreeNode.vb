Friend Class AdTreeNode : Inherits TreeNode
    Implements IComparable(Of AdTreeNode)

    Private _DisplayName As String
    Public Property DisplayName() As String
        Get
            Return _DisplayName
        End Get
        Set(ByVal value As String)
            _DisplayName = value
            Me.Text = _DisplayName
        End Set
    End Property

    Private _DistinguishedName As String
    Public Property DistinguishedName() As String
        Get
            Return _DistinguishedName
        End Get
        Set(ByVal value As String)
            _DistinguishedName = value
        End Set
    End Property

    Private _Type As AdObjectType
    Public Property Type() As AdObjectType
        Get
            Return _Type
        End Get
        Set(ByVal value As AdObjectType)
            _Type = value
            Select Case _Type
                Case AdObjectType.Container
                    Me.ImageKey = "ContainerImage"
                    Me.SelectedImageKey = "ContainerImage"
                Case AdObjectType.Domain
                    Me.ImageKey = "DomainImage"
                    Me.SelectedImageKey = "DomainImage"
                Case AdObjectType.OU
                    Me.ImageKey = "OrgImage"
                    Me.SelectedImageKey = "OrgImage"
            End Select
        End Set
    End Property

    Private _Loaded As Boolean
    Public Property Loaded() As Boolean
        Get
            Return _Loaded
        End Get
        Set(ByVal value As Boolean)
            _Loaded = value
        End Set
    End Property

    Public Enum AdObjectType As Integer
        Unknown = 0
        Domain = 1
        Container = 2
        OU = 3
    End Enum

    Public Function CompareTo(ByVal other As AdTreeNode) As Integer Implements System.IComparable(Of AdTreeNode).CompareTo
        Return String.Compare(Me.DisplayName, other.DisplayName)
    End Function

End Class
