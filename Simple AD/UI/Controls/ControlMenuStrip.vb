Imports System
Imports System.Windows.Forms
Imports SimpleLib

Public Class ControlMenuStrip
    Inherits MenuStrip

    Public Sub New()
        Dim style As Integer = NativeMethods.GetWindowLong(Me.Handle, NativeMethods.GWL_EXSTYLE)
        style = style Or NativeMethods.WS_EX_COMPOSITE
        NativeMethods.SetWindowLong(Me.Handle, NativeMethods.GWL_EXSTYLE, style)
        SetDoubleBuffered(Me)
    End Sub

    Public Shared Sub SetDoubleBuffered(ByVal c As Control)
        If SystemInformation.TerminalServerSession Then Return
        Dim aProp As Reflection.PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        aProp.SetValue(c, True, Nothing)
    End Sub

End Class
