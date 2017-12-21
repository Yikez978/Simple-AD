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

End Module
