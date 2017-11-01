Imports System.Runtime.Serialization
Imports System.Security.Permissions

<SerializableAttribute>
Public Class UserTemplate

    Public Property Name As String
    Public Property Description As String
    Public Property Author As String
    Public Property IconKey As String

    Public Property TemplateID As Guid

    Public Sub New(ByVal ID As Guid)
        Me.TemplateID = ID
    End Sub
End Class
