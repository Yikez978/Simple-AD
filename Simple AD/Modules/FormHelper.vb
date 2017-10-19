Public Module FormHelper

    Public Function GetDialogLocation(ByVal FormObject As Form) As Point
        Dim Location As Point = Cursor.Position
        Location.Offset(-(FormObject.Width / 2), -(FormObject.Height / 2))
        Return Location
    End Function

End Module
