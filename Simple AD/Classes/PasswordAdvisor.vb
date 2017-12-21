
Imports System.Text.RegularExpressions


Public Enum PasswordScore
    Blank = 0
    TooShort = 1
    RequirementsNotMet = 2
    VeryWeak = 3
    Weak = 4
    Fair = 5
    Medium = 6
    Strong = 7
    VeryStrong = 8
End Enum

Public Class PasswordAdvisor

    Public Shared Function CheckStrength(ByVal password As String) As PasswordScore
        Dim score As Integer = 0
        Dim blnMinLengthRequirementMet As Boolean = False
        Dim blnRequirement1Met As Boolean = False
        Dim blnRequirement2Met As Boolean = False
        If password.Length < 1 Then Return PasswordScore.Blank
        If password.Length < 6 Then
            Return PasswordScore.TooShort
        Else
            score += 1
            blnMinLengthRequirementMet = True
        End If

        If password.Length >= 8 Then score += 1
        If password.Length >= 10 Then score += 1
        If Regex.IsMatch(password, "[\d]", RegexOptions.ECMAScript) Then
            score += 1
            blnRequirement1Met = True
        End If

        If Regex.IsMatch(password, "[a-z]", RegexOptions.ECMAScript) Then
            score += 1
            blnRequirement2Met = True
        End If

        If Regex.IsMatch(password, "[A-Z]", RegexOptions.ECMAScript) Then
            score += 1
            blnRequirement2Met = True
        End If

        If Regex.IsMatch(password, "[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript) Then score += 1
        Dim lstPass As List(Of Char) = password.ToList()
        If lstPass.Count >= 3 Then
            For i As Integer = 2 To lstPass.Count - 1
                Dim charCurrent As Char = lstPass(i)
                If charCurrent = lstPass(i - 1) AndAlso charCurrent = lstPass(i - 2) AndAlso score >= 4 Then
                    score += 1
                End If
            Next
        End If

        If Not blnMinLengthRequirementMet OrElse Not blnRequirement1Met OrElse Not blnRequirement2Met Then
            Return PasswordScore.RequirementsNotMet
        End If

        Return CType(score, PasswordScore)
    End Function

End Class

