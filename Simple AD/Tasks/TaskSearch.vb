Imports System.DirectoryServices
Imports SimpleLib.Enums
Imports SimpleLib
Imports System.Threading.Tasks
Imports System.Threading
Imports BrightIdeasSoftware
Imports System.Collections.Generic
Imports System

Public Class TaskSearch
    Inherits TaskBase

    Private _SearchTerm As String
    Private _ListView As ObjectListView

    Private _SearchTask As Task

    Private _Cts As CancellationTokenSource
    Private _LastCts As CancellationTokenSource

    Private AttributeParser As New AttributeParser

    Private Delegate Sub Delegate_AfterGetResults(ByVal DomainObjectList As List(Of Object))

    Public Sub New(ByVal ListView As ObjectListView, ByVal Query As String)
        MyBase.New

        TaskType = ActiveTaskType.Search
        TaskName = "Search"

        _SearchTerm = Query
        _ListView = ListView

    End Sub

    Public Sub RunSearch()

        _Cts = New CancellationTokenSource()

        If (_SearchTask IsNot Nothing) AndAlso (_SearchTask.IsCompleted = False OrElse
            _SearchTask.Status = Threading.Tasks.TaskStatus.Running OrElse
            _SearchTask.Status = Threading.Tasks.TaskStatus.WaitingToRun OrElse
            _SearchTask.Status = Threading.Tasks.TaskStatus.WaitingForActivation) Then

            _LastCts.Cancel()

        Else

            _SearchTask = Task.Run(Sub() GetResults(_Cts.Token))

        End If

        _LastCts = _Cts

    End Sub

    Private Sub GetResults(ByVal CT As CancellationToken)

        Dim NewDomainObjectList As List(Of Object) = New List(Of Object)

        Try

            Dim Entry As DirectoryEntry = GetDirEntry(Nothing)
            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = String.Format("(&(|(&(objectCategory=person)(objectClass=user))(objectClass=group)(objectClass=computer))(|(name=*{0}*)(givenName=*{0}*)(sn=*{0}*)(samaccountname=*{0}*)(displayName=*{0}*)(description=*{0}*)))", _SearchTerm)
                .PageSize = 100
                .SearchScope = CType(Protocols.SearchScope.Subtree, DirectoryServices.SearchScope)
            End With

            DirSearcher.PropertiesToLoad.AddRange(LDAPPropsShort)

            Dim results As SearchResultCollection = DirSearcher.FindAll()

            For Each result As SearchResult In results

                Dim NewObject As Object = Nothing

                NewObject = AttributeParser.GetObjectAttributesFromResult(result, Nothing)

                If NewObject IsNot Nothing Then
                    NewDomainObjectList.Add(NewObject)
                End If
            Next

        Catch ArgEx As ArgumentException

            Logger.Log("[Error] " & ArgEx.GetBaseException.ToString & ArgEx.Message)
        Catch Ex As Exception

            Logger.Log("[Error] " & Ex.GetBaseException.ToString & Ex.Message)
        Finally

            If Not CT.IsCancellationRequested Then
                _ListView.Invoke(New Delegate_AfterGetResults(AddressOf AfterGetResults), NewDomainObjectList)
            End If

        End Try

    End Sub

    Private Sub AfterGetResults(Optional DomainObjectList As List(Of Object) = Nothing)

        If DomainObjectList IsNot Nothing Then

            ColumnRebuildRequired = False

            _ListView.SetObjects(DomainObjectList)
            TaskStatus = ActiveTaskStatus.Completed

        End If

        _ListView.EndUpdate()

    End Sub

End Class
