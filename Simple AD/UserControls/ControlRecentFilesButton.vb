Imports System.Drawing
Imports System.Windows.Forms

Public Class ControlRecentFilesButton

    Private _Path As String

    Public Sub New(ByVal Path As String)

        InitializeComponent()

        _Path = Path

        Me.FileTitleLb.Text = _Path

        Dim FileNameShortArray As String() = _Path.Split(New Char() {"\"c})


        Me.FileNameLb.Text = FileNameShortArray(FileNameShortArray.Length - 1)
        Me.DateModifedLb.Text = "Modified: " & FileDateTime(_Path)
        Me.BringToFront()

        Dim ico As Icon = Icon.ExtractAssociatedIcon(Path)

        Me.PictureBox.Image = ico.ToBitmap

        For Each cntrl As Control In Me.Controls
            AddHandler cntrl.Click, AddressOf RecentFilesButton_Click

        Next

        AddHandler PictureBox.MouseEnter, AddressOf RecentFilesButton_MouseEnter
        AddHandler PictureBox.MouseLeave, AddressOf RecentFilesButton_MouseLeave

        AddHandler FileNameLb.MouseEnter, AddressOf RecentFilesButton_MouseEnter
        AddHandler FileNameLb.MouseLeave, AddressOf RecentFilesButton_MouseLeave

        AddHandler FileTitleLb.MouseEnter, AddressOf RecentFilesButton_MouseEnter
        AddHandler FileTitleLb.MouseLeave, AddressOf RecentFilesButton_MouseLeave

    End Sub

    Private Sub RecentFilesButton_MouseEnter(sender As Object, e As EventArgs)
        Me.FileNameLb.ForeColor = SystemColors.ControlLightLight
        Me.FileTitleLb.ForeColor = SystemColors.ControlLightLight
    End Sub

    Private Sub RecentFilesButton_MouseLeave(sender As Object, e As EventArgs)
        Me.BackColor = Color.Transparent
        Me.FileNameLb.ForeColor = SystemColors.ControlText
        Me.FileTitleLb.ForeColor = SystemColors.ControlDark
    End Sub

    Private Sub RecentFilesButton_Click(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        Dim RecentImportForm As FormImport = New FormImport(_Path)
        RecentImportForm.ShowDialog()
    End Sub

    Private Function GetMouseoverControl() As Boolean
        Dim cursorPoint As Point = PointToClient(Cursor.Position)
        Dim ctl As Control = Me.GetChildAtPoint(cursorPoint)
        If ctl Is Nothing Then

            If Not ClientRectangle.Contains(PointToClient(Cursor.Position)) Then
                Return True
            End If

        End If
        Return False
    End Function

End Class
