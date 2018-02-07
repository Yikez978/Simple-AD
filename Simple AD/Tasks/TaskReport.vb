Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskReport
    Inherits ActiveTask

    Private ReportForm As FormReport

    Public Sub New()
        MyBase.New
        TaskType = ActiveTaskType.Report
        TaskName = "Report"

        ReportForm = New FormReport

        With ReportForm
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With

    End Sub


End Class

