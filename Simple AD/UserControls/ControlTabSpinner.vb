Public Class ControlTabSpinner
    Inherits UserControl

    Private _ParentContainer As Control

    Public Sub New(ByVal DisplayText As String, ByVal Container As Control)
        InitializeComponent()

        Me.MainLb.Text = DisplayText
        Me.Dock = DockStyle.Fill
        _ParentContainer = Container

    End Sub

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

End Class
