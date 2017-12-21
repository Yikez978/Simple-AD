Public Class FormMoveObject

    Public Property SelecetdOU As String

    Private WithEvents DomainTree As ControlDomainTreeView

    Public Sub New()
        InitializeComponent()

        MainPb.Image = New Icon(My.Resources.JobMove, New Size(16, 16)).ToBitmap

        DomainTree = New ControlDomainTreeView
        DomainTree.BorderStyle = BorderStyle.None
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

    Private Sub SelecetdOuChanged(SelecetedOU As String) Handles DomainTree.SelectedOUChanged
        SelecetdOU = SelecetedOU
    End Sub

    Private Sub FooterPl_Paint(sender As Object, e As PaintEventArgs) Handles FooterPl.Paint
        Dim s As Panel = FooterPl
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, 0, s.Width, 0)
        End If
    End Sub
End Class