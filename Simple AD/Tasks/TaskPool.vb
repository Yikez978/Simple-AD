Imports SimpleLib

Public Module TaskPool

    Public Property Pool As List(Of ActiveTask)

    Public Sub InitiateJobPool()
        Pool = New List(Of ActiveTask)
    End Sub

End Module
