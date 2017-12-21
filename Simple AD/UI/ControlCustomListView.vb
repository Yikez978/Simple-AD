Public Class ControlCustomListView
    Inherits ObjectListView

    Public Sub New()

        HotItemStyle = New HotItemStyle()
        HotItemStyle.BackColor = Color.FromArgb(210, 206, 225)

        SelectedBackColor = Color.FromArgb(100, 18, 99)

        HeaderUsesThemes = False

        Dim HeaderStyle As HeaderFormatStyle = New HeaderFormatStyle
        Dim HeaderFont As Font = New Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        With HeaderStyle
            .Hot.BackColor = SystemColors.Control
            .Normal.BackColor = SystemColors.Window
            .Pressed.BackColor = Color.FromArgb(210, 206, 225)

            .Hot.ForeColor = Color.FromArgb(49, 12, 66)
            .Normal.ForeColor = Color.FromArgb(49, 12, 66)
            .Pressed.ForeColor = Color.FromArgb(49, 12, 66)

            .Hot.FrameWidth = 0
            .Normal.FrameWidth = 0
            .Pressed.FrameWidth = 0

            .Hot.Font = HeaderFont
            .Normal.Font = HeaderFont
            .Pressed.Font = HeaderFont

        End With

        HeaderFormatStyle = HeaderStyle

    End Sub

End Class
