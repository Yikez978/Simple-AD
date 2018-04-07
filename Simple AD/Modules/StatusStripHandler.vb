Imports System.Drawing
Imports SimpleLib

Public Module StatusStripHandler

    Public WriteOnly Property WorkInProgress As Boolean
        Set(value As Boolean)
            Select Case value
                Case True
                    FormMain.StatusStrip.BackColor = Color.FromArgb(202, 81, 0)
                Case False
                    FormMain.StatusStrip.BackColor = Color.FromArgb(124, 65, 153)
            End Select
        End Set
    End Property

    Public Sub UpdateStatusStripText(ByVal Text As String)

        Dim StringToWrite As String = String.Empty

        If String.IsNullOrEmpty(FormMain.ToolStripStatusLabelContext.Text) Then
            StringToWrite = Text
        Else
            StringToWrite = "|  " & Text
        End If

        FormMain.Invoke(Sub() FormMain.ToolStripStatusLabelStatus.Text = StringToWrite)
    End Sub

    Public Sub UpdateConnectionText(ByVal Text As String)

        FormMain.Invoke(Sub()
                            FormMain.ConnectionToolStripStatusLabel.Image = New Icon(My.Resources.SystemTask, 16, 16).ToBitmap
                            FormMain.ConnectionToolStripStatusLabel.Text = "  Connected to " & GetDomainNetBiosName()
                        End Sub)
    End Sub

    Public Sub UpdateContextStripText(ByVal Text As String)
        FormMain.Invoke(Sub()
                            ClearStatus()
                            FormMain.ToolStripStatusLabelContext.Text = Text
                            FormMain.ToolStripStatusLabelContext.Image = New Icon(My.Resources.Selected, 16, 16).ToBitmap
                        End Sub)
    End Sub

    Public Sub ClearStatus()
        FormMain.Invoke(Sub()
                            FormMain.ToolStripStatusLabelStatus.Text = Nothing
                            FormMain.ToolStripStatusLabelStatus.Image = Nothing
                        End Sub)
    End Sub

    Public Sub ClearContext()
        FormMain.Invoke(Sub()
                            FormMain.ToolStripStatusLabelContext.Text = Nothing
                            FormMain.ToolStripStatusLabelContext.Image = Nothing
                        End Sub)
    End Sub

    Public Sub UpdateQueryTimeText(ByVal Text As String)
        FormMain.Invoke(Sub()
                            FormMain.QueryToolStripLabel.Text = "  " & Text & "  "
                            FormMain.QueryToolStripLabel.Image = New Icon(My.Resources.Timer, 16, 16).ToBitmap

                            If String.IsNullOrEmpty(FormMain.QueryToolStripLabel.ToolTipText) Then
                                FormMain.QueryToolStripLabel.ToolTipText = "Query Time" & Environment.NewLine & Environment.NewLine & "Displays the time spent on the last domain query, " & Environment.NewLine & "including time taken to parse the results the rebuild the list."
                            End If

                        End Sub)
    End Sub

    Public Sub ContainerUpdated(ByVal Path As String, ByVal FormatPath As Boolean)

        If Not String.IsNullOrEmpty(Path) Then

            If Not FormatPath Then
                FormMain.Invoke(Sub()
                                    FormMain.ContainerToolStripStatusLabel.Text = Path
                                    FormMain.ContainerToolStripStatusLabel.Image = New Icon(My.Resources.Repository, 16, 16).ToBitmap
                                End Sub)
                Exit Sub
            End If


            Dim sDelimStart As String = "="
            Dim sDelimEnd As String = ","
            Dim nIndexStart As Integer = Path.IndexOf(sDelimStart)
            Dim nIndexEnd As Integer = Path.IndexOf(sDelimEnd)

            Dim result As String = Mid(Path, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length)

            FormMain.Invoke(Sub()
                                FormMain.ContainerToolStripStatusLabel.Text = result
                                FormMain.ContainerToolStripStatusLabel.Image = New Icon(My.Resources.Repository, 16, 16).ToBitmap
                            End Sub)

        Else
            FormMain.Invoke(Sub()
                                FormMain.ContainerToolStripStatusLabel.Text = String.Empty
                                FormMain.ContainerToolStripStatusLabel.Image = Nothing
                            End Sub)
        End If

    End Sub

End Module
