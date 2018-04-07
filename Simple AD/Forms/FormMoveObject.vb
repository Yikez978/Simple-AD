Imports System.Windows.Forms
Imports SimpleLib

Public Class FormMoveObject

    Public Property SelecetdOU As String

    Private WithEvents DomainTree As ControlDomainTreeView

    Public Sub New()
        InitializeComponent()

        DomainTree = New ControlDomainTreeView
        DomainTree.BorderStyle = BorderStyle.FixedSingle
        DomainTree.Dock = DockStyle.Fill
        DomainTree.BringToFront()
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

    Private Sub SelecetdItemChanged(SelectedItem As String) Handles DomainTree.SelectedItemChanged
        SelectedOU = SelectedItem
    End Sub

End Class