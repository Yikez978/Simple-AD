Imports System.Drawing
Imports System.Windows.Forms

Public Class ControlToolStrip

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub LoadToolStrip(ByVal Handler As UIHandler)
        If Parent.InvokeRequired Then
            Parent.Invoke(New Action(Of UIHandler)(AddressOf LoadToolStrip), Handler)
        Else
            For Each ToolStripGroup As ControlToolStripGroup In LoadToolStripItems(Handler)
                Me.Controls.Add(ToolStripGroup)
            Next
        End If

    End Sub

    Private Sub ControlToolStripGroup_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        Width = Width + e.Control.Width + 3
        AddHandler e.Control.VisibleChanged, AddressOf SubControlVisiblityChanged
    End Sub

    Public Sub SubControlVisiblityChanged(sender As Object, e As EventArgs)
        Invalidate()
    End Sub


    Private Sub ControlToolStrip_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As ControlToolStrip = Me
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(213, 213, 213))
            e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)

            For Each Subcontrol As Control In Controls
                If Subcontrol.Visible = True Then
                    Dim X As Integer = (Subcontrol.Location.X + Subcontrol.Width)
                    e.Graphics.DrawLine(Pen, X, 8, X, s.Height - 8)
                End If
            Next

            Pen.Dispose()

        End If
    End Sub

End Class
