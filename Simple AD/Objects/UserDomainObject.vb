Public Class UserDomainObject
    Inherits DomainObject

    Private _GivenName
    Public Property GivenName As String
        Set(value As String)
            _GivenName = value
        End Set
        Get
            Return _GivenName
            OnPropertyChanged("GivenName")
        End Get
    End Property

    Private _Password
    Public Property Password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
            OnPropertyChanged("Password")
        End Get
    End Property

    Private _DisplayName
    Public Property DisplayName As String
        Set(value As String)
            _DisplayName = value
        End Set
        Get
            Return _DisplayName
            OnPropertyChanged("DisplayName")
        End Get
    End Property

    Private _Sn
    Public Property Sn As String
        Set(value As String)
            _Sn = value
        End Set
        Get
            Return _Sn
            OnPropertyChanged("Sn")
        End Get
    End Property

    Private _HomeDirectory
    Public Property HomeDirectory As String
        Set(value As String)
            _HomeDirectory = value
        End Set
        Get
            Return _HomeDirectory
            OnPropertyChanged("HomeDirectory")
        End Get
    End Property

    Private _HomeDrive
    Public Property HomeDrive As String
        Set(value As String)
            _HomeDrive = value
        End Set
        Get
            Return _HomeDrive
            OnPropertyChanged("HomeDrive")
        End Get
    End Property

    Private _Pager
    Public Property Pager As String
        Set(value As String)
            _Pager = value
        End Set
        Get
            Return _Pager
            OnPropertyChanged("Pager")
        End Get
    End Property

    Private _TsProfilePath
    Public Property TsProfilePath As String
        Set(value As String)
            _TsProfilePath = value
        End Set
        Get
            Return _TsProfilePath
            OnPropertyChanged("TsProfilePath")
        End Get
    End Property

    Private _ScriptPath
    Public Property ScriptPath As String
        Set(value As String)
            _ScriptPath = value
        End Set
        Get
            Return _ScriptPath
            OnPropertyChanged("ScriptPath")
        End Get
    End Property

End Class
