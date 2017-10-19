Imports System.ComponentModel

Public Class SimpleADBulkUserDomainObject
    Inherits UserDomainObject

    Private _Errors As List(Of String)
    Public Property Errors As List(Of String)
        Set(value As List(Of String))
            _Errors = value
        End Set
        Get
            Return _Errors
        End Get
    End Property
End Class
