Public Module PaintHelper

    Public Sub DrawString(ByVal Graphics As Graphics, ByVal Text As String, ByVal Font As Font, Color As Color, ByVal X As Integer, ByVal Y As Integer)

        Dim DrawBrush As New SolidBrush(Color)
        Dim DrawFormat As New StringFormat

        Graphics.DrawString(Text, Font, DrawBrush, X, Y, DrawFormat)
        Font.Dispose()
        DrawBrush.Dispose()
        Graphics.Dispose()
    End Sub

End Module
