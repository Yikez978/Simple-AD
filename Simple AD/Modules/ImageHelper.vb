Module ImageHelper

    Public Function ConvertToGrayScale(ByVal Image As Image) As Image
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
            {
                New Single() {0.299, 0.299, 0.299, 0, 0},
                New Single() {0.587, 0.587, 0.587, 0, 0},
                New Single() {0.114, 0.114, 0.114, 0, 0},
                New Single() {0, 0, 0, 1, 0},
                New Single() {0, 0, 0, 0, 1}
            })

        Dim bmp As New Bitmap(Image)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height),
                        0, 0, bmp.Width, bmp.Height,
                        GraphicsUnit.Pixel, imgattr)
        End Using
        Return bmp
    End Function

    Public Function GetImage(ByVal type As ActiveDirectoryIconType) As Image
        If My.Settings.UseSystemIcons = True Then
            If IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "dsuiext.dll")) Then
                Return ActiveDirectoryIcon.GetIcon(type).ToBitmap
            Else
                Return GetLocalImage(type)
            End If
        Else
            Return GetLocalImage(type)
        End If
    End Function

    Public Function GetLocalImage(ByVal Type As ActiveDirectoryIconType)
        Select Case Type
            Case ActiveDirectoryIconType.OU
                Return My.Resources.OuFlat
            Case ActiveDirectoryIconType.Computer
                Return My.Resources.Computer
            Case ActiveDirectoryIconType.User
                Return My.Resources.UserFlat
            Case ActiveDirectoryIconType.DisabledUser
                Return My.Resources.DisabledUser
            Case ActiveDirectoryIconType.Contact
                Return My.Resources.Contact
            Case ActiveDirectoryIconType.Container
                Return My.Resources.containerFlat
            Case ActiveDirectoryIconType.Domain
                Return My.Resources.Domain
            Case ActiveDirectoryIconType.Group
                Return My.Resources.Group
            Case ActiveDirectoryIconType.Unknown
                Return My.Resources.UnknownFlat
            Case ActiveDirectoryIconType.Search
                Return My.Resources.Search
        End Select
        Return Nothing
    End Function

End Module
