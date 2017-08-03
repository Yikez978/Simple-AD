Public Class FormUpdate

    Public Enum UpdateType
        Available = 0
        UpdateError = 1
        NoUpdates = 2
    End Enum

    Public Sub New(ByVal Type As UpdateType)

        InitializeComponent()

        Select Case Type
            Case 0
                Me.Text = "Update Availalbe"
            Case 1
                Me.Text = "Unable to contact Update Server"
            Case 2
                Me.Text = "You're on the latest version"
        End Select

    End Sub

End Class