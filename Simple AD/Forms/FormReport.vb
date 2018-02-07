Public Class FormReport

    Public Property QueryObject As BaseObject

    Public Enum BaseObject
        User
        Group
        Computer
        Contact
    End Enum

    Public Sub New()

        InitializeComponent()

        TypeCombo.SelectedIndex = 0
        MainTabControl.InitializeTabControl()

    End Sub

End Class