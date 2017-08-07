Public Class FormLDAPMatrix

    Public Sub New(ByVal DataSource As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        MainDataGrid.DataSource = DataSource

    End Sub

End Class