Imports System.Reflection
Imports System.Runtime.CompilerServices

Module ExtendedMethods
    <Extension()>
    Public Sub DoubleBuffered(aDGV As DataGridView, Optional setting As Boolean = True)
        'usage: SomeDataGridView.DoubleBuffered(True)
        Dim dgvType As Type = aDGV.GetType
        Dim propInfo As Reflection.PropertyInfo
        propInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propInfo.SetValue(aDGV, setting, Nothing)
    End Sub

End Module