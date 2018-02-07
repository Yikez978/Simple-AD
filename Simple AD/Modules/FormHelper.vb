Imports System.Drawing
Imports System.Windows.Forms

Public Module FormHelper

    Public Function GetDialogLocation(ByVal FormObject As Form) As Point
        Dim Location As Point = Cursor.Position
        Location.Offset(-Convert.ToInt32(FormObject.Width / 2), -Convert.ToInt32(FormObject.Height / 2))
        Return Location
    End Function

End Module
