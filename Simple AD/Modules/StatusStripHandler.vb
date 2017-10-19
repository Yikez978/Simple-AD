Public Module StatusStripHandler

    Public WriteOnly Property WorkInProgress As Boolean
        Set(value As Boolean)
            Select Case value
                Case True
                    FormMain.StatusStrip.BackColor = Color.FromArgb(202, 81, 0)
                    FormMain.StatusStrip.ForeColor = Color.White
                Case False
                    FormMain.StatusStrip.BackColor = SystemColors.Window
                    FormMain.StatusStrip.ForeColor = Color.FromArgb(81, 80, 80)
            End Select
        End Set
    End Property

End Module
