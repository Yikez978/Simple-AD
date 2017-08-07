Public Class ControlTabSpinner
    Inherits UserControl

    Private _ParentContainer As Control

    Public Sub New(ByVal DisplayText As String, ByVal Container As Control, Optional Spinnercolor As Color = Nothing)
        InitializeComponent()

        Me.MainLb.Text = DisplayText
        Me.Dock = DockStyle.Fill
        _ParentContainer = Container

        If Not Spinnercolor.IsEmpty Then
            Me.MainSpinner.ForeColor = Spinnercolor
        End If

    End Sub

    Public Property ErrorBoxText As String
        Set(value As String)
            ErrorTb.Text = value
        End Set
        Get
            Return ErrorTb.Text
        End Get
    End Property

    Public Property SpinnerVisible As Boolean
        Set(ByVal value As Boolean)
            Me.Visible = value
            Me.MainSpinner.Spinning = value
        End Set
        Get
            Return Me.Visible
        End Get
    End Property

    Public Property DisplayText As String
        Set(value As String)
            Me.MainLb.Text = value
        End Set
        Get
            Return MainLb.Text
        End Get
    End Property

    Public Property Tooltiptext
        Set(value)
            Me.SpinnerTooltip.SetToolTip(Me.MainLb, value)
        End Set
        Get
            Return Me.SpinnerTooltip.GetToolTip(Me.MainLb)
        End Get
    End Property

    Public Property SpinnerColor As Color
        Set(value As Color)
            Me.MainSpinner.ForeColor = value
        End Set
        Get
            Return Me.MainSpinner.ForeColor
        End Get
    End Property

End Class
