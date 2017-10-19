Public Class ControlSplitConatiner
    Inherits SplitContainer

    Private ReadOnly Property HandleColor As Color
        Get
            If IsWindows7() Then
                Return Color.FromArgb(217, 217, 217)
            Else
                Return Color.FromArgb(247, 247, 247)
            End If
        End Get
    End Property


    Private Sub sSplitCont_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        DirectCast(sender, SplitContainer).IsSplitterFixed = True
    End Sub

    Private Sub SplitCont_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        DirectCast(sender, SplitContainer).IsSplitterFixed = False
    End Sub

    Private Sub SplitCont_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If DirectCast(sender, SplitContainer).IsSplitterFixed Then
            If e.Button.Equals(MouseButtons.Left) Then

                If DirectCast(sender, SplitContainer).Orientation.Equals(Orientation.Vertical) Then

                    If e.X > 0 AndAlso e.X < DirectCast(sender, SplitContainer).Width Then
                        DirectCast(sender, SplitContainer).SplitterDistance = e.X
                        DirectCast(sender, SplitContainer).Refresh()
                    End If
                Else

                    If e.Y > 0 AndAlso e.Y < DirectCast(sender, SplitContainer).Height Then

                        DirectCast(sender, SplitContainer).SplitterDistance = e.Y
                        DirectCast(sender, SplitContainer).Refresh()
                    End If
                End If
            Else

                DirectCast(sender, SplitContainer).IsSplitterFixed = False
            End If
        End If
    End Sub

    Private Sub ControlSplitConatiner_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As SplitContainer = Me
        If Not s Is Nothing Then
            Dim Top As Integer = 0 '5
            Dim Bottom As Integer = s.Height '- 5
            Dim Left As Integer = s.SplitterDistance
            Dim Right As Integer = Left + s.SplitterWidth - 1
            Dim Pen As New Pen(HandleColor)
            e.Graphics.DrawLine(Pen, Right, Top, Right, Bottom)
        End If

    End Sub

End Class
