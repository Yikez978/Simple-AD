Public Class LDAPAtrProp

    Public Property AttrLDAPName As String
    Public Property AttrDisplayName As String
    Public Property ADUCTab As String
    Public Property ADUCField As String
    Public Property PropertySet As String
    Public Property StaticPropertyMethod As String
    Public Property Syntax As String
    Public Property Indexed As String

    Public Sub New()
    End Sub
End Class

Public Module LDAPDictionary

    Public LDAPDictionary As New Dictionary(Of String, LDAPAtrProp)
    Public Matrix As FormLDAPMatrix

    Dim Table As New DataTable

    Public Sub BuildLdapAttributeMatrix()

        Dim firstLine As Boolean = True

        Using sr As New IO.StreamReader(".\LDAPAtrSheet.csv")
            While Not sr.EndOfStream
                If firstLine Then
                    firstLine = False
                    Dim cols() = sr.ReadLine.Split(",")

                    For Each col In cols
                        Table.Columns.Add(New DataColumn(col, GetType(String)))
                    Next

                Else
                    Dim data() As String = sr.ReadLine.Split(",")
                    Table.Rows.Add(data.ToArray)
                End If
            End While
        End Using

        Matrix = New FormLDAPMatrix(Table)
        BuildLDAPDictionary()

    End Sub

    Public Sub ShowMatrix()
        Matrix.Show()
    End Sub

    Private Sub BuildLDAPDictionary()

        For Each row As DataRow In Table.Rows
            LDAPDictionary.Add(row(0), New LDAPAtrProp With {.AttrLDAPName = row(0), .AttrDisplayName = row(1), .ADUCTab = row(2), .ADUCField = row(3), .PropertySet = row(4), .StaticPropertyMethod = row(5), .Syntax = row(6), .Indexed = row(7)})
        Next

    End Sub

    Public Function GetFriendlyLDAPName(ByVal Attr As String) As String

        If LDAPDictionary.ContainsKey(Attr) Then
            If Not String.IsNullOrEmpty(LDAPDictionary.Item(Attr).AttrDisplayName) Then
                Return LDAPDictionary.Item(Attr).AttrDisplayName
            Else
                Return GetProperFromCamelCase(Attr)
            End If
        Else
            Return GetProperFromCamelCase(Attr)
        End If
        Return Attr
    End Function

    Public Function GetFullLDAPName(ByVal Attr As String) As String

        If LDAPDictionary.ContainsKey(Attr) Then
            If Not String.IsNullOrEmpty(LDAPDictionary.Item(Attr).AttrLDAPName) Then
                Return LDAPDictionary.Item(Attr).AttrLDAPName
            End If
        End If
        Return Attr
    End Function

End Module

