Imports System.IO

Public Class FormConsole

    Private Sub FormConsole_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using LogReader As New StreamReader(appData & "\AppConsoleTrace.Log")
            While Not LogReader.EndOfStream
                RichTextBox.AppendText(LogReader.ReadLine)
            End While
        End Using
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged
        RichTextBox.SelectionStart = RichTextBox.Text.Length
        RichTextBox.ScrollToCaret()
    End Sub


End Class


