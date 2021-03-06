﻿Imports System
Imports System.Collections.Generic
Imports SimpleLib

Public Module ListViewDelegates

    Public Function NameImageGetter(rowObject As Object) As Object

        Dim DomainObject As DomainObject = DirectCast(rowObject, DomainObject)

        Select Case DomainObject.Type
            Case "user"
                If DomainObject.IsEnabled Then
                    Return "UserImage"
                Else
                    Return "DisabledUserImage"
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

    End Function

    Function ResultsListImageGetter(AspectObject As Object) As Object
        Dim UserObject As SimpleADBulkUserDomainObject = DirectCast(AspectObject, SimpleADBulkUserDomainObject)
        Return UserObject.Meta.Status.ToString
    End Function

    Function SortByNameGroupKeyGetter(rowObject As Object) As Object
        Dim ListObject As DomainObject = DirectCast(rowObject, DomainObject)
        Return FirstCharToUpper(ListObject.Name.Substring(0, 1))
    End Function

    Function UserImportErrorAspectToString(AspectObject As Object) As String
        If AspectObject IsNot Nothing Then
            Dim ErrorList As List(Of String) = DirectCast(AspectObject, List(Of String))
            If ErrorList.Count > 0 Then
                Return ErrorList(0)
            Else
                Return String.Empty
            End If
        Else
            Return String.Empty
        End If

    End Function

    Function ResultsListStatusColAspectToString(AspectObject As Object) As String
        Dim UserStatus As SimpleResult = DirectCast(AspectObject, SimpleResult)
        Return UserStatus.Status.ToString
    End Function

    Function SortByNameDynamicGroupKeyGetter(rowObject As Object, Attribute As String) As Object

        Dim ObjectVal As Object = CallByName(rowObject, FirstCharToUpper(Attribute), CallType.Get)

        If ObjectVal Is Nothing Then
            Return String.Empty
        Else
            Return CStr(ObjectVal).Substring(0, 1).ToUpper
        End If

    End Function

    Function SortByDateGroupKeyGetter(rowObject As Object, Attribute As String) As Object
        Dim ListObject As DomainObject = DirectCast(rowObject, DomainObject)

        Dim Value As Object = CallByName(ListObject, Attribute, CallType.Get, Nothing)

        Dim ObjectDate As DateTime

        If Value IsNot Nothing Then
            If DateTime.TryParse(Value.ToString, ObjectDate) Then

                Dim Month As Integer = ObjectDate.Month
                Dim Year As Integer = ObjectDate.Year

                Return New DateTime(Year, Month, 1)

            Else
                Return New DateTime(1694, 6, 13)
            End If
        Else
            Return New DateTime(1694, 6, 13)
        End If
    End Function

    Function SortByDateGroupKeyToTitle(groupKey As Object) As Object

        If groupKey.GetType = GetType(DateTime) Then
            Return DirectCast(groupKey, DateTime).ToString("MMMM yyyy")
        Else
            Return Nothing
        End If
    End Function

    Function DateToShortDelegate(Aspect As Object) As String

        Dim result As DateTime = Nothing

        If Aspect IsNot Nothing AndAlso TypeOf Aspect Is DateTime Then
            Return CType(Aspect, DateTime).ToLongDateString()
        Else
            Return "(Not Set)"
        End If

    End Function

End Module
