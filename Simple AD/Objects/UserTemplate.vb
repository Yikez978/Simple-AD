Imports System.Runtime.Serialization
Imports System.Security.Permissions

<SerializableAttribute>
Public Class UserTemplate


    Public Property Name As String
    Public Property Description As String
    Public Property Author As String
    Public Property IconKey As String

    Public Property TemplateID As Guid

    '<SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    'Overridable Sub GetObjectData(info As SerializationInfo, context As StreamingContext) _
    '     Implements ISerializable.GetObjectData

    '    info.AddValue("TemplateID", TemplateID)
    '    info.AddValue("Name", Name)
    '    info.AddValue("Description", Description)
    '    info.AddValue("Author", Author)
    '    info.AddValue("IconKey", IconKey)
    'End Sub

    'Protected Sub New(info As SerializationInfo, context As StreamingContext)
    '    TemplateID = New Guid(info.GetString("TemplateID"))
    '    Try
    '        Name = info.GetString("Name")
    '        Description = info.GetString("Description")
    '        Author = info.GetString("Author")
    '        IconKey = info.GetString("IconKey")
    '    Catch Ex As Exception
    '        Debug.WriteLine("[Error] An error accoured while trying to load user templates: " & Ex.Message)
    '    End Try
    'End Sub

    Public Sub New(ByVal ID As Guid)
        Me.TemplateID = ID
    End Sub
End Class
