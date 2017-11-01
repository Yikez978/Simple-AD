Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Module TaskManager

    Public Property TasksFile As String = ".\Tasks\" & "Tasks" & ".stsx"
    Public Property TaskList As New List(Of SimpleADJob)

    Public Sub NewTask(ByVal Task As SimpleADJob)
        RefreshTasks(Task)
    End Sub

    Public Sub SaveStatus()
        Dim SaveTasks As New List(Of Task)()
        SaveTasks.Add(Task.Run(AddressOf SaveTaskList))
    End Sub

    Public Async Sub RefreshTasks(ByVal T As SimpleADJob)

        BeginControlUpdate(GetTaskFlow)

        GetTaskFlow.Controls.Clear()
        GetContainerImport.ClearJobNodes()

        If Not Directory.Exists(".\Tasks") Then
            Directory.CreateDirectory(".\Tasks")
        End If

        TaskList.Clear()
        Await Task.Run(AddressOf LoadTaskList)
        TaskList.Add(DirectCast(T, SimpleADJob))
        Await Task.Run(AddressOf SaveTaskList)
        Await Task.Run(AddressOf LoadImportJobNodes)

        LoadTaskCards()

    End Sub

    Private Async Function SaveTaskList() As Task

        Dim SaveFormatter As IFormatter = New BinaryFormatter()

        Using WriteStream As Stream = New FileStream(TasksFile, FileMode.Create, FileAccess.Write, FileShare.None)
            SaveFormatter.Serialize(WriteStream, TaskList)
            WriteStream.Flush()
        End Using

        Await Task.CompletedTask

    End Function

    Private Async Function LoadTaskList() As Task

        If Directory.Exists(".\Tasks") Then
            If File.Exists(TasksFile) Then

                Dim LoadFormatter As IFormatter = New BinaryFormatter()

                Using ReadStream As Stream = New FileStream(TasksFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    TaskList = LoadFormatter.Deserialize(ReadStream)
                End Using

            End If
        End If

        Await Task.CompletedTask

    End Function

    Private Sub LoadTaskCards()

        Dim Iterater As Integer

        For i As Integer = 0 To TaskList.Count - 1
            Dim TaskView As ControlTaskCard
            Iterater = i
            FormMain.Invoke(New Action(Sub() TaskView = New ControlTaskCard(TaskList(Iterater))))
        Next

        SafeInvoke(GetTaskFlow.FindForm, New Action(Sub() EndControlUpdate(GetTaskFlow)), True)

    End Sub

    Private Sub LoadImportJobNodes()

        Dim Job As JobImport = Nothing

        For i As Integer = 0 To TaskList.Count - 1
            If TaskList.Item(i).GetType = GetType(JobImport) Then
                Job = TaskList.Item(i)
                GetContainerImport.Invoke(Sub() GetContainerImport.LoadJobNodes(Job))
            End If
        Next

        SafeInvoke(GetContainerImport.TreeViewPanel.FindForm, (Sub() FinishImportNodes(Job)), False)

    End Sub

    Private Sub FinishImportNodes(ByVal Job As JobImport)
        EndControlUpdate(GetContainerImport.TreeViewPanel)
        GetContainerImport.MainListView.EndUpdate()

        If Not Job Is Nothing Then
            Threading.ThreadPool.QueueUserWorkItem(Sub() GetContainerImport.MainListView.SetObjects(Job.Users))
        End If

    End Sub

End Module
