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
                Return GetLocalImageSmall(type)
            End If
        Else
            Return GetLocalImageSmall(type)
        End If
    End Function

    Public Function GetLargeImage(ByVal type As ActiveDirectoryIconType) As Image
        If My.Settings.UseSystemIcons = True Then
            If IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "dsuiext.dll")) Then
                Return ActiveDirectoryIcon.GetIcon(type).ToBitmap
            Else
                Return New Bitmap(GetLocalImageLarge(type), New Size(64, 64))
            End If
        Else
            Return New Bitmap(GetLocalImageLarge(type), New Size(64, 64))
        End If
    End Function

    Public Function GetLocalImageSmall(ByVal Type As ActiveDirectoryIconType)
        Select Case Type
            Case ActiveDirectoryIconType.OU
                Return My.Resources.Ou
            Case ActiveDirectoryIconType.Computer
                Return My.Resources.Computer
            Case ActiveDirectoryIconType.User
                Return My.Resources.User
            Case ActiveDirectoryIconType.DisabledUser
                Return My.Resources.UserDisabled
            Case ActiveDirectoryIconType.Contact
                Return My.Resources.Contact
            Case ActiveDirectoryIconType.Container
                Return My.Resources.container
            Case ActiveDirectoryIconType.Domain
                Return My.Resources.Domain
            Case ActiveDirectoryIconType.Group
                Return My.Resources.Group
            Case ActiveDirectoryIconType.Unknown
                Return My.Resources.UnknownFlat
            Case ActiveDirectoryIconType.Search
                Return My.Resources.Search
            Case ActiveDirectoryIconType.UserError
                Return My.Resources.UserError
            Case ActiveDirectoryIconType.UserSuccess
                Return My.Resources.UserSuccess
            Case ActiveDirectoryIconType.UserFailed
                Return My.Resources.UserFailed
            Case ActiveDirectoryIconType.UserPending
                Return My.Resources.UserPending
        End Select
        Return Nothing
    End Function

    Public Function GetLocalImageLarge(ByVal Type As ActiveDirectoryIconType) As Image
        Select Case Type
            Case ActiveDirectoryIconType.OU
                Return My.Resources.OuFlatLarge
            Case ActiveDirectoryIconType.Computer
                Return My.Resources.ComputerLarge
            Case ActiveDirectoryIconType.User
                Return My.Resources.UserLarge
            Case ActiveDirectoryIconType.DisabledUser
                Return My.Resources.UserDisabledLarge
            Case ActiveDirectoryIconType.Contact
                Return My.Resources.ContactLarge
            Case ActiveDirectoryIconType.Container
                Return My.Resources.containerFlatLarge
            Case ActiveDirectoryIconType.Domain
                Return My.Resources.DomainLarge
            Case ActiveDirectoryIconType.Group
                Return My.Resources.GroupLarge
            Case ActiveDirectoryIconType.Unknown
                Return My.Resources.UnkownLarge
            Case ActiveDirectoryIconType.Search
                Return My.Resources.Search
            Case ActiveDirectoryIconType.UserError
                Return My.Resources.UserError
            Case ActiveDirectoryIconType.UserSuccess
                Return My.Resources.UserSuccess
            Case ActiveDirectoryIconType.UserFailed
                Return My.Resources.UserFailed
        End Select
        Return Nothing
    End Function

End Module
