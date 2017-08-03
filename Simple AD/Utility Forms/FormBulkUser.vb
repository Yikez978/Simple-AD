Imports System.Text
Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class FormBulkUser

    Private FNDefualtText As String = "Paste a list Of forenames here.."
    Private SNDefaultText As String = "Paste a list of Surnames here.."

    Private _SelectedInputBox As RichTextBox

    Private FolderBrowserDialog As CommonOpenFileDialog = New CommonOpenFileDialog

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub

    Private Sub BulkUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FnTb.WaterMark = FNDefualtText
        SnTb.WaterMark = SNDefaultText

        MainTabControl.SelectedTab = MainTabControl.TabPages.Item(0)

        FolderBrowserDialog.IsFolderPicker = True
    End Sub

    Private Sub ValidateInput()

        Dim FNNewText As New StringBuilder
        Dim SNNewText As New StringBuilder

        Dim FirstNamecon = New StringBuilder

        For Each Line As String In FnTb.Lines

            FirstNamecon.Clear()

            Line = Line.Trim

            Dim Names As String() = Line.Split(" "c)
            Dim NameList As List(Of String) = Names.ToList
            Static Iterator As Integer = Names.Length - 1


            For Each name As String In Names
                If String.IsNullOrWhiteSpace(name) Then
                    NameList.Remove(name)
                End If
            Next

            If NameList.Count > 0 Then

                For i As Integer = 0 To NameList.Count - 2
                    FirstNamecon.Append(NameList(i))
                    FirstNamecon.Append(" ")
                Next

                FNNewText.Append(FirstNamecon.ToString.TrimEnd)
                FNNewText.Append(Environment.NewLine)

                If NameList.Count > 1 Then
                    SNNewText.Append(NameList(NameList.Count - 1))
                    SNNewText.Append(Environment.NewLine)
                End If
            End If
        Next

        FnTb.Text = FNNewText.ToString
        SnTb.Text = SNNewText.ToString

        SnTb.ForeColor = SystemColors.ControlText

    End Sub

    Private Sub FnTb_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ValidateInput()
        End If
    End Sub

    Private Sub ValidateBn_Click(sender As Object, e As EventArgs) Handles ValidateBn.Click
        ValidateInput()
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click
        MainTabControl.SelectTab(MainTabControl.SelectedTab.TabIndex + 1)
    End Sub

    Private MouseIsDown As Boolean = False

    Private Sub DraggableTB_MouseDown(sender As Object, e As MouseEventArgs) Handles FnDragBn.MouseDown, Fn1DragBn.MouseDown, SnDragBn.MouseDown, Sn1DragBn.MouseDown, StringDragBn.MouseDown, NumberBn.MouseDown
        MouseIsDown = True
    End Sub

    Private Sub DraggableTB_MouseMove(sender As Object, e As MouseEventArgs) Handles FnDragBn.MouseMove, Fn1DragBn.MouseMove, SnDragBn.MouseMove, Sn1DragBn.MouseMove, StringDragBn.MouseMove, NumberBn.MouseMove
        If MouseIsDown Then
            ' Initiate dragging.
            sender.DoDragDrop(sender.Text, DragDropEffects.Copy)
        End If
        MouseIsDown = False
    End Sub

    Private Sub MainFlow_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles MainFlow.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TextBox2_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles MainFlow.DragDrop
        Dim NewConstructor = New ControlUsernameContructorChunk(e.Data.GetData(DataFormats.Text))

        MainFlow.Controls.Add(NewConstructor)
    End Sub

    Private Sub UpdateUsername()
        Dim PatternBuilder As New StringBuilder

        For Each button As ControlUsernameContructorChunk In MainFlow.Controls
            PatternBuilder.Append("\" & button.GetText)
        Next

        Dim Pattern = PatternBuilder.ToString

        MainUnPreview.Text = GetUsernameFromCon("John", "Smith", Pattern)
    End Sub

    Private Function GetUsernameFromCon(ByVal fn As String, ByVal sn As String, ByVal Pattern As String) As String
        Dim Username As String = ""

        Dim Firstname = fn
        Dim Surname = sn
        Dim Firstname1 = Firstname.Substring(0, 1)
        Dim Surname1 = Surname.Substring(0, 1)


        Dim PatternArray = Pattern.Split(New Char() {"\"})
        Dim UsernameBuilder As New StringBuilder

        For Each item In PatternArray
            If item = "FirstName" Then
                UsernameBuilder.Append(Firstname)
            ElseIf item = "Surname" Then
                UsernameBuilder.Append(Surname)
            ElseIf item = "First Initial" Then
                UsernameBuilder.Append(Firstname1)
            ElseIf item = "Last Initial" Then
                UsernameBuilder.Append(Surname1)
            Else
                UsernameBuilder.Append(item.ToString)
            End If
        Next

        Username = UsernameBuilder.ToString
        UsernameBuilder.Clear()

        Return Username
    End Function

    Private Sub MainFlow_ControlRemoved(sender As Object, e As ControlEventArgs) Handles MainFlow.ControlRemoved
        UpdateUsername()
    End Sub

    Private Sub MainFlow_ControlAdded(sender As Object, e As ControlEventArgs) Handles MainFlow.ControlAdded
        UpdateUsername()
    End Sub

    Private Sub StringDragTb_Click(sender As Object, e As EventArgs) Handles StringDragTb.TextChanged
        If String.IsNullOrEmpty(StringDragTb.Text) Then
            StringDragBn.Text = "String"
        Else
            StringDragBn.Text = StringDragTb.Text
        End If
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumberComboBox.SelectedIndexChanged
        NumberBn.Text = NumberComboBox.Text
    End Sub

    Private Sub HomeFolderBn_Click(sender As Object, e As EventArgs) Handles HomeFolderBn.Click
        FolderBrowserDialog.ShowDialog()
        Try
            HomeFolderTb.Text = FolderBrowserDialog.FileName
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
        End Try
    End Sub

    Private Sub ProfilePathBn_Click(sender As Object, e As EventArgs) Handles ProfilePathBn.Click
        FolderBrowserDialog.ShowDialog()
        Try
            ProfilePathTb.Text = FolderBrowserDialog.FileName
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
        End Try
    End Sub

    Private Sub GroupBn_Click(sender As Object, e As EventArgs) Handles GroupBn.Click
        FormGroupSelection.ShowDialog()
    End Sub
End Class