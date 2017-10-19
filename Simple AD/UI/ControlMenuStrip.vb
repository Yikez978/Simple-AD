Public Class ControlMenuStrip
    Inherits MenuStrip

    Public Sub New()
        Dim style As Integer = NativeWinAPI.GetWindowLong(Me.Handle, NativeWinAPI.GWL_EXSTYLE)
        style = style Or NativeWinAPI.WS_EX_COMPOSITE
        NativeWinAPI.SetWindowLong(Me.Handle, NativeWinAPI.GWL_EXSTYLE, style)
    End Sub
End Class
