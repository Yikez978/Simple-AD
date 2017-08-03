Public Class TabSpinner
    Inherits UserControl

    Private _ParentContainer As Control

    Public Sub New(ByVal DisplayText As String, ByVal Container As Control)
        InitializeComponent()

        Me.MainLb.Text = DisplayText
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

    Private Sub Center()
        Me.Top = (MainApplicationForm.GetMainTabCtrl.ClientSize.Height / 2) - (Me.Height / 2)
        Me.Left = (MainApplicationForm.GetMainTabCtrl.Parent.ClientSize.Width / 2) - (Me.Width / 2)

        Me.Anchor = AnchorStyles.Top And AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right

    End Sub

    Public Property Tooltiptext
        Set(value)
            Me.SpinnerTooltip.SetToolTip(Me.MainLb, value)
        End Set
        Get
            Return Me.SpinnerTooltip.GetToolTip(Me.MainLb)
        End Get
    End Property

    Private Sub TabSpinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center()
    End Sub

End Class
