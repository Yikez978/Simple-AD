Imports System.ComponentModel

Public Class UserDomainObject
    Inherits DomainObject

    Private _Status
    Public Overrides Property Status As String
        Set(value As String)
            _Status = value
        End Set
        Get
            Return _Status
        End Get
    End Property

    Private _GivenName
    Public Property GivenName As String
        Set(value As String)
            _GivenName = value
        End Set
        Get
            Return _GivenName
        End Get
    End Property

    Private _Password
    Public Property Password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property

    Private _DisplayName
    Public Property DisplayName As String
        Set(value As String)
            _DisplayName = value
        End Set
        Get
            Return _DisplayName
        End Get
    End Property

    Private _Sn
    Public Property Sn As String
        Set(value As String)
            _Sn = value
        End Set
        Get
            Return _Sn
        End Get
    End Property

    Private _HomeDirectory
    Public Property HomeDirectory As String
        Set(value As String)
            _HomeDirectory = value
        End Set
        Get
            Return _HomeDirectory
        End Get
    End Property

    Private _HomeDrive
    Public Property HomeDrive As String
        Set(value As String)
            _HomeDrive = value
        End Set
        Get
            Return _HomeDrive
        End Get
    End Property

    Private _Pager
    Public Property Pager As String
        Set(value As String)
            _Pager = value
        End Set
        Get
            Return _Pager
        End Get
    End Property

    Private _TsProfilePath
    Public Property TsProfilePath As String
        Set(value As String)
            _TsProfilePath = value
        End Set
        Get
            Return _TsProfilePath
        End Get
    End Property

    Private _ScriptPath
    Public Property ScriptPath As String
        Set(value As String)
            _ScriptPath = value
        End Set
        Get
            Return _ScriptPath
        End Get
    End Property

    Private _Mail
    Public Property Mail As String
        Set(value As String)
            _Mail = value
        End Set
        Get
            Return _Mail
        End Get
    End Property

    Private _ProfilePath
    Public Property ProfilePath As String
        Set(value As String)
            _ProfilePath = value
        End Set
        Get
            Return _ProfilePath
        End Get
    End Property

    Private _Office
    Public Property Office As String
        Set(value As String)
            _Office = value
        End Set
        Get
            Return _Office
        End Get
    End Property

    Private _Department
    Public Property Department As String
        Set(value As String)
            _Department = value
        End Set
        Get
            Return _Department
        End Get
    End Property

    Private _Company
    Public Property Company As String
        Set(value As String)
            _Company = value
        End Set
        Get
            Return _Company
        End Get
    End Property

    Private _Manager
    Public Property Manager As String
        Set(value As String)
            _Manager = value
        End Set
        Get
            Return _Manager
        End Get
    End Property

    Private _Title
    Public Property Title As String
        Set(value As String)
            _Title = value
        End Set
        Get
            Return _Title
        End Get
    End Property

    Private _TelephoneNumber
    Public Property TelephoneNumber As String
        Set(value As String)
            _TelephoneNumber = value
        End Set
        Get
            Return _TelephoneNumber
        End Get
    End Property

    Private _wWWHomePage
    Public Property WWWHomePage As String
        Set(value As String)
            _wWWHomePage = value
        End Set
        Get
            Return _wWWHomePage
        End Get
    End Property

End Class
