Imports System.Globalization
Imports System.Text.RegularExpressions

Public Module StringHelper
    Public Function GetFileNameShort(ByVal Filename As String) As String
        Dim StringArryay = Filename.Split(New Char() {"\"})
        Return StringArryay(StringArryay.Count - 1)
    End Function

    Public Function GetProperName(ByVal Name As String) As String
        Return StrConv(Name, VbStrConv.ProperCase)
    End Function

    Public Function GetFriendlyTypeName(ByVal Type As String) As String
        Select Case Type
            Case "user"
                Return "User"
            Case "computer"
                Return "Computer"
            Case "group"
                Return "Group"
            Case "container"
                Return "Container"
            Case "contact"
                Return "Contact"
            Case "organizationalUnit"
                Return "Organizational Unit"
            Case Else
                'Dim TextInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
                'Return TextInfo.ToTitleCase(Type)
                Return GetProperFromCamelCase(Type)
        End Select

    End Function

    Public Function GetProperFromCamelCase(ByVal Input As String) As String
        Dim UpperInput As String = FirstCharToUpper(Input)
        Dim r = New Regex(vbCr & vbLf & "                
                (?<=[A-Z])(?=[A-Z][a-z]) |" & vbCr & vbLf & "                 
                (?<=[^A-Z])(?=[A-Z]) |" & vbCr & vbLf & "                 
                (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace)
        Return r.Replace(UpperInput, " ")
    End Function

    Public Function FirstCharToUpper(ByVal Input As String) As String
        If String.IsNullOrEmpty(Input) Then
            Throw New ArgumentException("ARGH!")
        End If
        Return Input.First().ToString().ToUpper() + Input.Substring(1)
    End Function

End Module
