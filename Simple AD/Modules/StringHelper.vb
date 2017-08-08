Public Module StringHelper
    Public Function GetFileNameShort(ByVal Filename As String) As String
        Dim StringArryay = Filename.Split(New Char() {"\"})
        Return StringArryay(StringArryay.Count - 1)
    End Function

    Public Function GetProperName(ByVal Name As String) As String
        Return StrConv(Name, VbStrConv.ProperCase)
    End Function

End Module
