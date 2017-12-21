Public Module Delegates

    Public Function NameImageGetter(rowObject As Object) As Object
        Dim DomainObject As DomainObject = DirectCast(rowObject, DomainObject)
        Select Case DomainObject.Type
            Case "user"
                Dim UserAccountControl As Integer = DomainObject.UserAccountControl
                If UserAccountControl = 546 Or UserAccountControl = 514 Or UserAccountControl = 66082 Or UserAccountControl = 66050 Then
                    Return "DisabledUserImage"
                Else
                    Return "UserImage"
                End If
            Case "computer"
                Return "ComputerImage"
            Case "group"
                Return "GroupImage"
            Case "container"
                Return "ContainerImage"
            Case "organizationalUnit"
                Return "OuImage"
            Case "contact"
                Return "ContactImage"
            Case Else
                Return "UnknownImage"
        End Select
        Return Nothing
    End Function

    Function ResultsListImageGetter(rowObject As Object) As Object
        Dim UserObject As SimpleADBulkUserDomainObject = DirectCast(rowObject, SimpleADBulkUserDomainObject)
        Return UserObject.Status
    End Function

    Function SortByNameGroupKeyGetter(rowObject As Object) As Object
        Dim ListObject As DomainObject = DirectCast(rowObject, DomainObject)
        Return FirstCharToUpper(ListObject.Name.Substring(0, 1))
    End Function

    Function UserImportErrorAspectToString(rowObject As Object) As String
        Dim ErrorList As List(Of String) = DirectCast(rowObject, List(Of String))
        If ErrorList.Count > 1 Then
            If Not String.IsNullOrEmpty(ErrorList(1)) Then
                Return ErrorList(1).Trim
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

End Module
