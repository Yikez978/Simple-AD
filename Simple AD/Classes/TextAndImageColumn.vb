Public Class TextAndImageColumn

    Inherits DataGridViewTextBoxColumn

    Private imageValue As Image
    Private m_imageSize As Size
    Public Property columnName As String

    Public Sub New()
        Me.CellTemplate = New TextAndImageCell
    End Sub

    Public Overloads Overrides Function Clone() As Object
        Dim c As TextAndImageColumn = TryCast(MyBase.Clone, TextAndImageColumn)
        c.imageValue = Me.imageValue
        c.m_imageSize = Me.m_imageSize
        Return c
    End Function

    Public Property Image() As Image
        Get
            Return Me.imageValue
        End Get
        Set(ByVal value As Image)
            If Not value Is Nothing Then
                Me.imageValue = value
                Me.m_imageSize = value.Size
                Dim inheritedPadding As Padding = Me.DefaultCellStyle.Padding
                Me.DefaultCellStyle.Padding = New Padding(ImageSize.Width + (ImageSize.Width / 4), inheritedPadding.Top, inheritedPadding.Right, inheritedPadding.Bottom)
            End If
        End Set

    End Property

    Private ReadOnly Property TextAndImageCellTemplate() As TextAndImageCell
        Get
            Return TryCast(Me.CellTemplate, TextAndImageCell)
        End Get
    End Property

    Friend ReadOnly Property ImageSize() As Size
        Get
            Return m_imageSize
        End Get
    End Property
End Class




Public Class TextAndImageCell

    Inherits DataGridViewTextBoxCell

    Private imageValue As Image
    Private imageSize As Size

    Public Overloads Overrides Function Clone() As Object
        Dim c As TextAndImageCell = TryCast(MyBase.Clone, TextAndImageCell)
        c.imageValue = Me.imageValue
        c.imageSize = Me.imageSize
        Return c
    End Function

    Public Property Image() As Image
        Get
            If Me.OwningColumn Is Nothing OrElse Me.OwningTextAndImageColumn Is Nothing Then
                Return imageValue
            Else
                If Not (Me.imageValue Is Nothing) Then
                    Return Me.imageValue
                Else
                    Return Me.OwningTextAndImageColumn.Image
                End If
            End If
        End Get
        Set(ByVal value As Image)
            If Not value Is Nothing Then
                Me.imageValue = value
                Me.imageSize = value.Size
                Dim inheritedPadding As Padding = Me.InheritedStyle.Padding
                Me.Style.Padding = New Padding(imageSize.Width, inheritedPadding.Top, inheritedPadding.Right, inheritedPadding.Bottom)
            End If
        End Set
    End Property

    Protected Overloads Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle,
                                            rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, formattedValue As Object,
                                            errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle,
                                            paintParts As DataGridViewPaintParts)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        If Not (Me.Image Is Nothing) Then
            Dim container As Drawing2D.GraphicsContainer = graphics.BeginContainer

            Dim Xpos = cellBounds.Location.X + (Image.Width / 8)
            Dim ypos = cellBounds.Location.Y + ((cellBounds.Height - Image.Height) / 2)

            graphics.SetClip(cellBounds)
            'graphics.DrawImageUnscaled(Me.Image, New Point(cellBounds.Location.X, cellBounds.Location.Y - cellBounds.Height + 22))
            graphics.DrawImageUnscaled(Me.Image, New Point(Xpos, ypos))
            graphics.EndContainer(container)
        End If
    End Sub

    Private ReadOnly Property OwningTextAndImageColumn() As TextAndImageColumn
        Get
            Return TryCast(Me.OwningColumn, TextAndImageColumn)
        End Get
    End Property

End Class