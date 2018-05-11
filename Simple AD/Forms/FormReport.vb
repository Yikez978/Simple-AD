

Imports System

Public Class FormReport

    Public Property ReportTask As TaskReport

    Public Sub New(ByVal BaseTask As TaskReport)

        ReportTask = BaseTask

        InitializeComponent()

        AddHandler AddRuleBn.Click, AddressOf ReportTask.AddRule

        TypeCombo.SelectedIndex = 0
        MainTabControl.InitializeTabControl()

    End Sub

    Private Sub TypeCombo_SelectedValueChanged(sender As Object, e As EventArgs) Handles TypeCombo.SelectedValueChanged

        Select Case TypeCombo.SelectedIndex
            Case 0
                ReportTask.ReportType = SimpleLib.ReportBaseObject.user
            Case 1
                ReportTask.ReportType = SimpleLib.ReportBaseObject.group
            Case 2
                ReportTask.ReportType = SimpleLib.ReportBaseObject.computer
            Case 3
                ReportTask.ReportType = SimpleLib.ReportBaseObject.contact
        End Select

    End Sub

End Class

Public Class ProprtyRuleListItem

    Property Name As String
    Property Description As String

End Class