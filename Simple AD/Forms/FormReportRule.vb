Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports SimpleLib

Public Class FormReportRule

    Public Property BaseObject As SimpleLib.ReportBaseObject

    Private Property StringOperators As String() = {"Contains", "Begins With", "Ends With", "Is", "Is Not", "Does Not Contain"}
    Private Property DateOperators As String() = {"Before", "After", "Is", "Is Not"}
    Private Property BooleanOperators As String() = {"Is", "Is Not"}
    Private Property ArithmeticOperators As String() = {"Is Equal To", "More Than", "Less Than"}

    Public Sub New(ReportBaseObject As SimpleLib.ReportBaseObject)
        InitializeComponent()

        BaseObject = ReportBaseObject

        LoadRules()
        LoadLogicOperators()

    End Sub

    Private Sub LoadRules()

        RuleCombo.Items.Clear()

        For Each KeyValPair As KeyValuePair(Of String, ReportAttribute) In Attributes
            Dim Attr As ReportAttribute = KeyValPair.Value

            For i As Integer = 0 To Attr.ApplicableTypes.Length - 1
                If Attr.ApplicableTypes(i) = BaseObject Then
                    RuleCombo.Items.Add(KeyValPair.Key)
                End If
            Next

        Next

        If RuleCombo.Items.Count > 0 Then
            RuleCombo.SelectedIndex = 0
        End If

    End Sub

    Public Sub LoadLogicOperators()

        If String.IsNullOrEmpty(RuleCombo.Text) Then
            Exit Sub
        End If

        LogicCombo.Items.Clear()

        Dim Attr As String = RuleCombo.Text

        Select Case Attributes.Item(Attr).MatchKey
            Case MatchType.Alphabetic
                LogicCombo.Items.AddRange(StringOperators)
                LoadValueInput(MatchType.Alphabetic)
            Case MatchType.Time
                LogicCombo.Items.AddRange(DateOperators)
                LoadValueInput(MatchType.Time)
            Case MatchType.Numeric
                LogicCombo.Items.AddRange(ArithmeticOperators)
                LoadValueInput(MatchType.Numeric)
            Case MatchType.Bool
                LogicCombo.Items.AddRange(BooleanOperators)
                LoadValueInput(MatchType.Bool)
        End Select

        If LogicCombo.Items.Count > 0 Then
            LogicCombo.SelectedIndex = 0
        End If

    End Sub

    Private Sub LoadValueInput(ByVal Type As MatchType)

        ValuePl.Controls.Clear()

        Select Case Type
            Case MatchType.Alphabetic
                ValuePl.Controls.Add(New TextBox With {.Width = 150})
            Case MatchType.Numeric
                ValuePl.Controls.Add(New TextBox With {.Width = 150})
            Case MatchType.Time
                ValuePl.Controls.Add(New DateTimePicker With {.Width = 150})
            Case MatchType.Bool
                Dim BoolPicker = New ComboBox
                BoolPicker.Items.AddRange({"True", "False"})
                BoolPicker.DropDownStyle = ComboBoxStyle.DropDownList
                BoolPicker.Width = 150

                ValuePl.Controls.Add(BoolPicker)
        End Select

    End Sub

    Private Sub RuleCombo_SelectedValueChanged(sender As Object, e As EventArgs) Handles RuleCombo.SelectedValueChanged
        LoadLogicOperators()
    End Sub

End Class