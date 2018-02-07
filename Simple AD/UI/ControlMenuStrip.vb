Imports System.Windows.Forms
Imports SimpleLib

Public Class ControlMenuStrip
    Inherits MenuStrip

    Public Sub New()
        Dim style As Integer = NativeWinAPI.GetWindowLong(Me.Handle, NativeWinAPI.GWL_EXSTYLE)
        style = style Or NativeWinAPI.WS_EX_COMPOSITE
        NativeWinAPI.SetWindowLong(Me.Handle, NativeWinAPI.GWL_EXSTYLE, style)
        SetDoubleBuffered(Me)
    End Sub

    Public Shared Sub SetDoubleBuffered(ByVal c As Control)
        If SystemInformation.TerminalServerSession Then Return
        Dim aProp As Reflection.PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        aProp.SetValue(c, True, Nothing)
    End Sub

End Class
