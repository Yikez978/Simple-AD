Imports System.ComponentModel

Public Class DomainObject

    Private StatusValue
    Public Overridable Property Status As String
        Set(value As String)
            StatusValue = value
        End Set
        Get
            Return StatusValue
        End Get
    End Property

    Private NameValue As String
    Public Property Name As String
        Get
            Return NameValue
        End Get
        Set(ByVal value As String)
            NameValue = value
        End Set
    End Property

    Private DescriptionValue As String
    Public Property Description As String
        Get
            Return DescriptionValue
        End Get
        Set(ByVal value As String)
            DescriptionValue = value
        End Set
    End Property

    Private TypeValue As String
    Public Property Type As String
        Get
            Return TypeValue
        End Get
        Set(ByVal value As String)
            TypeValue = value
        End Set
    End Property

    Private TypeFullValue As String
    Public Property TypeFull As String
        Get
            Return TypeFullValue
        End Get
        Set(ByVal value As String)
            TypeFullValue = value
        End Set
    End Property

    Private TypeFriendlyValue As String
    Public Property TypeFriendly As String
        Get
            Return TypeFriendlyValue
        End Get
        Set(ByVal value As String)
            TypeFriendlyValue = value
        End Set
    End Property

    Private DistinguishedNameValue As String
    Public Property DistinguishedName As String
        Get
            Return DistinguishedNameValue
        End Get
        Set(ByVal value As String)
            DistinguishedNameValue = value
        End Set
    End Property

    Private SAMAccountNameValue As String
    Public Property SAMAccountName As String
        Get
            Return SAMAccountNameValue
        End Get
        Set(ByVal value As String)
            SAMAccountNameValue = value
        End Set
    End Property

    Private UserAccountControlValue As String
    Public Property UserAccountControl As String
        Get
            Return UserAccountControlValue
        End Get
        Set(ByVal value As String)
            UserAccountControlValue = value
        End Set
    End Property

    Private IsCriticalSystemObjectValue As Boolean
    Public Property IsCriticalSystemObject As Boolean
        Get
            Return IsCriticalSystemObjectValue
        End Get
        Set(ByVal value As Boolean)
            IsCriticalSystemObjectValue = value
        End Set
    End Property

    Private ShowInAdvancedViewOnlyValue As Boolean
    Public Property ShowInAdvancedViewOnly As Boolean
        Get
            Return ShowInAdvancedViewOnlyValue
        End Get
        Set(ByVal value As Boolean)
            ShowInAdvancedViewOnlyValue = value
        End Set
    End Property
End Class
