Public Class UserObject

    Private _Username
    Private _Password
    Private _DisplayName
    Private _Firstname
    Private _Surname
    Private _HomeDrive
    Private _HomeDirectory
    Private _Pager
    Private _Description
    Private _MailDomain
    Private _TsProfilePath


    Public Sub New(Username As String, Password As String,
                   DisplayName As String, Firstname As String,
                   Surname As String, HomeDrive As String,
                   HomeDirectory As String, Pager As String,
                   Description As String, MailDomain As String,
                   TsProfilePath As String)

        _Username = Username
        _Password = Password
        _DisplayName = DisplayName
        _Firstname = Firstname
        _Surname = Surname
        _HomeDrive = HomeDrive
        _HomeDirectory = HomeDirectory
        _Pager = Pager
        _Description = Description
        _MailDomain = MailDomain
        _TsProfilePath = TsProfilePath

    End Sub

#Region "Properties"

    Public Property Username
        Set(value)
            _Username = value
        End Set
        Get
            Return _Username
        End Get
    End Property

    Public Property Firstname
        Set(value)
            _Firstname = value
        End Set
        Get
            Return _Firstname
        End Get
    End Property

    Public Property Password
        Set(value)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property

    Public Property DisplayName
        Set(value)
            _DisplayName = value
        End Set
        Get
            Return _DisplayName
        End Get
    End Property

    Public Property Surname
        Set(value)
            _Surname = value
        End Set
        Get
            Return _Surname
        End Get
    End Property

    Public Property HomeDirectory
        Set(value)
            _HomeDirectory = value
        End Set
        Get
            Return _HomeDirectory
        End Get
    End Property

    Public Property HomeDrive
        Set(value)
            _HomeDrive = value
        End Set
        Get
            Return _HomeDrive
        End Get
    End Property

    Public Property Pager
        Set(value)
            _Pager = value
        End Set
        Get
            Return _Pager
        End Get
    End Property

    Public Property Description
        Set(value)
            _Description = value
        End Set
        Get
            Return _Description
        End Get
    End Property

    Public Property MailDomain
        Set(value)
            _MailDomain = value
        End Set
        Get
            Return _MailDomain
        End Get
    End Property

    Public Property TsProfilePath
        Set(value)
            _TsProfilePath = value
        End Set
        Get
            Return _TsProfilePath
        End Get
    End Property

#End Region

End Class
