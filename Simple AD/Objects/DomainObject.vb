Imports System.ComponentModel

Public Class DomainObject
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

    Private NameValue As String
    Public Property Name As String
        Get
            Return NameValue
        End Get
        Set(ByVal value As String)
            NameValue = value
            OnPropertyChanged("Name")
        End Set
    End Property

    Private DescriptionValue As String
    Public Property Description As String
        Get
            Return DescriptionValue
        End Get
        Set(ByVal value As String)
            DescriptionValue = value
            OnPropertyChanged("Description")
        End Set
    End Property

    Private TypeValue As String
    Public Property Type As String
        Get
            Return TypeValue
        End Get
        Set(ByVal value As String)
            TypeValue = value
            OnPropertyChanged("Type")
        End Set
    End Property

    Private TypeFullValue As String
    Public Property TypeFull As String
        Get
            Return TypeFullValue
        End Get
        Set(ByVal value As String)
            TypeFullValue = value
            OnPropertyChanged("TypeFull")
        End Set
    End Property

    Private TypeFriendlyValue As String
    Public Property TypeFriendly As String
        Get
            Return TypeFriendlyValue
        End Get
        Set(ByVal value As String)
            TypeFriendlyValue = value
            OnPropertyChanged("TypeFriendly")
        End Set
    End Property

    Private DistinguishedNameValue As String
    Public Property DistinguishedName As String
        Get
            Return DistinguishedNameValue
        End Get
        Set(ByVal value As String)
            DistinguishedNameValue = value
            OnPropertyChanged("DistinguishedName")
        End Set
    End Property

    Private SAMAccountNameValue As String
    Public Property SAMAccountName As String
        Get
            Return SAMAccountNameValue
        End Get
        Set(ByVal value As String)
            SAMAccountNameValue = value
            OnPropertyChanged("SAMAccountName")
        End Set
    End Property

    Private UserAccountControlValue As String
    Public Property UserAccountControl As String
        Get
            Return UserAccountControlValue
        End Get
        Set(ByVal value As String)
            UserAccountControlValue = value
            OnPropertyChanged("UserAccountControl")
        End Set
    End Property

End Class
