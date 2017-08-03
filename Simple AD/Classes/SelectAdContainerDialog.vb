''' <summary>
''' Provides a dialog window that allows the user to select a container from a specified Active Directory domain
''' </summary>
Public Class SelectAdContainerDialog : Implements IDisposable


#Region "Public Properties"

    Private _SelectedContainerPath As String = String.Empty
    ''' <summary>
    ''' Contains the full distinguished name for the container the user selected once the form has been shown
    ''' </summary>
    Public ReadOnly Property SelectedContainerPath() As String
        Get
            Return _SelectedContainerPath
        End Get
    End Property

    Private _Username As String = String.Empty
    ''' <summary>
    ''' The username to use for the connection to the domain
    ''' </summary>
    Public WriteOnly Property Username() As String
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property

    Private _Password As String = String.Empty
    ''' <summary>
    ''' The password to use for the connection to the domain
    ''' </summary>
    Public WriteOnly Property Password() As String
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Private _DomainName As String = String.Empty
    ''' <summary>
    ''' The full DNS name of the domain to show the container tree for. If this property is not set, the current user's domain will be used
    ''' </summary>
    Public Property DomainName() As String
        Get
            Return _DomainName
        End Get
        Set(ByVal value As String)
            _DomainName = value
        End Set
    End Property

    Private _Title As String = String.Empty
    ''' <summary>
    ''' A title or description to be shown at the top of the form
    ''' </summary>
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

#End Region

End Class
