Public Class StringHelper
    Public Shared Function GetFileNameShort(ByVal Filename As String) As String
        Dim StringArryay = Filename.Split(New Char() {"\"})
        Return StringArryay(StringArryay.Count - 1)
    End Function
End Class
