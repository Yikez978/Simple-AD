Public Class UserObject

    Private _SamAccountName
    Private _Name
    Private _Password
    Private _DisplayName
    Private _GivenName
    Private _Sn
    Private _HomeDrive
    Private _HomeDirectory
    Private _Pager
    Private _Description
    Private _TsProfilePath
    Private _ScriptPath


    Public Sub New()

    End Sub

#Region "Properties"

    Public Property sAMAccountName As String
        Set(value As String)
            _SamAccountName = value
        End Set
        Get
            Return _SamAccountName
        End Get
    End Property

    Public Property name As String
        Set(value As String)
            _Name = value
        End Set
        Get
            Return _Name
        End Get
    End Property

    Public Property givenName As String
        Set(value As String)
            _GivenName = value
        End Set
        Get
            Return _GivenName
        End Get
    End Property

    Public Property password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property

    Public Property displayName As String
        Set(value As String)
            _DisplayName = value
        End Set
        Get
            Return _DisplayName
        End Get
    End Property

    Public Property sn As String
        Set(value As String)
            _Sn = value
        End Set
        Get
            Return _Sn
        End Get
    End Property

    Public Property homeDirectory As String
        Set(value As String)
            _HomeDirectory = value
        End Set
        Get
            Return _HomeDirectory
        End Get
    End Property

    Public Property homeDrive As String
        Set(value As String)
            _HomeDrive = value
        End Set
        Get
            Return _HomeDrive
        End Get
    End Property

    Public Property pager As String
        Set(value As String)
            _Pager = value
        End Set
        Get
            Return _Pager
        End Get
    End Property

    Public Property description As String
        Set(value As String)
            _Description = value
        End Set
        Get
            Return _Description
        End Get
    End Property

    Public Property tsProfilePath As String
        Set(value As String)
            _TsProfilePath = value
        End Set
        Get
            Return _TsProfilePath
        End Get
    End Property

    Public Property scriptPath As String
        Set(value As String)
            _ScriptPath = value
        End Set
        Get
            Return _ScriptPath
        End Get
    End Property

#End Region

End Class
