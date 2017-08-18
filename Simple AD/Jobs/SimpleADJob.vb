Public Class SimpleADJob

    Public Function GenerateJobID() As Integer
        Dim random As Random = New Random()
        Dim randNumber As Byte = random.Next(255)
        Return CInt(randNumber)
    End Function

End Class
