Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskReport
    Inherits TaskBase

    Private ReportForm As FormReport

    Public Property ReportType As ReportBaseObject

    Public PropertyRules As New List(Of ProprtyRuleListItem)

    Public Sub New()
        MyBase.New
        TaskType = ActiveTaskType.Report
        TaskName = "Report"

        ReportForm = New FormReport(Me)

        With ReportForm
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With

    End Sub

    Public Sub AddRule(sender As Object, e As EventArgs)

        Dim RuleForm As New FormReportRule(ReportType)
        RuleForm.ShowDialog()

    End Sub

End Class

