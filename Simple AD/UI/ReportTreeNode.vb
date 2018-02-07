Imports System.Windows.Forms
Imports SimpleLib

Public Class ReportTreeNode
    Inherits TreeNode

    Public Property SimpleADReport As SimpleADReport

    Public Sub New(ByVal Text As String, ByVal ImageKey As String, ByVal SelecetedImageKey As String, ByVal Report As SimpleADReport)

        Me.Text = Text
        Me.ImageKey = ImageKey
        Me.SelectedImageKey = SelecetedImageKey
        Me.SimpleADReport = Report

    End Sub

End Class
