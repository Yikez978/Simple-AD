Public Class FormMoveObject

    Public Property SelecetdOU As String

    Private WithEvents DomainTree As ControlDomainTreeView

    Public Sub New()
        InitializeComponent()
        DomainTree = New ControlDomainTreeView()
        DomainTree.BackColor = SystemColors.Window
        MainPl.Controls.Add(DomainTree)
        DomainTree.InitialLoad()
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SelecetdOuChanged(SelecetedOU As String)
        SelecetdOU = SelecetedOU
        OULb.Text = SelecetedOU
    End Sub

End Class