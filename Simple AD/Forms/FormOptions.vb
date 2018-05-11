Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports SimpleAD.FormOptions
Imports SimpleLib.SystemHelper

Public Class FormOptions

    Private AdvSettingsList As New List(Of AdvancedOption)

    Public Property AdvacedSettings As New Dictionary(Of String, AdvancedOption)
    Public Property AdvacedSettingDictionary As New Dictionary(Of String, String())

    Public Enum AdvSettingGroup
        Display
        Exporting
        LDAP
    End Enum

    Public Sub New()

        InitializeComponent()

        AdvacedSettingDictionary.Add("AdvEvaluateProtection",
                                     {"Show Lock icon on protected containers", "Display"})

        AdvacedSettingDictionary.Add("AdvEvaluateSystemObjects",
                                     {"Show Cog icon on critical system objects", "Display"})

        AdvacedSettingDictionary.Add("AdvEnableListHighlighting",
                                     {"Show higlighting in mainlist", "Display"})

        AdvacedSettingDictionary.Add("AdvUsePaging",
                                     {"Use Result Paging for AD Queries", "LDAP"})

        AdvacedSettingDictionary.Add("AdvOpenExports",
                                     {"Automatically open exported files", "Exporting"})

        AdvacedSettingDictionary.Add("AdvIncludeHiddenColExports",
                                     {"Include hidden collumns in exports", "Exporting"})

        AdvacedSettingDictionary.Add("AdvEnableResultCaching",
                                     {"Enable result caching", "LDAP"})

        For Each Setting As SettingsProperty In My.Settings.Properties

            If Setting.Name.Contains("Adv") AndAlso Setting.PropertyType Is GetType(Boolean) Then

                Try

                    Dim Item As New AdvancedOption

                    With Item
                        .Settings = My.Settings.Properties(Setting.Name)
                        .DisplayName = AdvacedSettingDictionary(Setting.Name)(0)
                        .Group = DirectCast([Enum].Parse(GetType(AdvSettingGroup), AdvacedSettingDictionary(Setting.Name)(1).ToString), AdvSettingGroup)
                        .Value = CBool(My.Settings.PropertyValues(Setting.Name).PropertyValue)
                    End With

                    AdvacedSettings.Add(Setting.Name, Item)

                Catch
                End Try

            End If

        Next

        NameCol.GroupKeyGetter = Function(rowObject As Object) DirectCast(rowObject, AdvancedOption).Group

        AdvancedListView.SetListStyle()

        AdvancedListView.BorderStyle = Windows.Forms.BorderStyle.None

    End Sub

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpCb.Checked = My.Settings.AdvUsePaging
        ProxyToggle.Checked = My.Settings.UseProxy
        AutoLoginToggle.Checked = My.Settings.AutoLogin

        If My.Settings.ManualLogin = False Then
            ManualRadioBn.Checked = False
            UsernameTb.Enabled = False
            PasswordTb.Enabled = False
        Else
            ManualRadioBn.Checked = True
            UsernameTb.Enabled = True
            PasswordTb.Enabled = True
        End If

        If SimpleLib.LoginUsername IsNot Nothing Then
            UsernameTb.Text = DataProtection.Unprotect(My.Settings.Username, "Letme1n$")
        End If
        If SimpleLib.LoginPassword IsNot Nothing Then
            PasswordTb.Text = SimpleLib.LoginPassword
        End If

        AutoRadioBn.Checked = Not ManualRadioBn.Checked

        MainTabControl.SelectedTab = MainTabControl.TabPages.Item(0)

    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click

        If ManualRadioBn.Checked = True Then
            If Not String.IsNullOrEmpty(UsernameTb.Text) And Not String.IsNullOrEmpty(PasswordTb.Text) Then

                My.Settings.Username = DataProtection.Protect(UsernameTb.Text, "Letme1n$")
                My.Settings.Password = DataProtection.Protect(PasswordTb.Text, "Letme1n$")

                My.Settings.ManualLogin = True

            End If
        End If

        My.Settings.AdvUsePaging = UpCb.Checked

        If AdvSettingsList.Count > 0 Then
            For i As Integer = 0 To AdvSettingsList.Count - 1
                Dim SettingItem As AdvancedOption = AdvSettingsList(i)

                My.Settings.Item(SettingItem.Settings.Name) = SettingItem.Value

            Next
        End If

        My.Settings.Save()
        Close()

    End Sub

    Private Sub CnBt_Click(sender As Object, e As EventArgs) Handles CnBt.Click
        Close()
    End Sub

    Private Sub ProxyToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ProxyToggle.CheckedChanged
        My.Settings.UseProxy = ProxyToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub AutoLoginToggle_CheckedChanged(sender As Object, e As EventArgs) Handles AutoLoginToggle.CheckedChanged
        My.Settings.AutoLogin = AutoLoginToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub ManualRadioBn_CheckedChanged(sender As Object, e As EventArgs) Handles ManualRadioBn.CheckedChanged
        UsernameTb.Enabled = Not UsernameTb.Enabled
        PasswordTb.Enabled = Not PasswordTb.Enabled
    End Sub

    Private Sub MainTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainTabControl.SelectedIndexChanged
        If MainTabControl.SelectedTab Is AdvancedTab Then
            LoadAdvancedSettings()
        End If
    End Sub

    Private Sub LoadAdvancedSettings()

        AdvSettingsList.Clear()

        For Each KeyValPair As KeyValuePair(Of String, AdvancedOption) In AdvacedSettings
            Dim Item As AdvancedOption = KeyValPair.Value
            AdvSettingsList.Add(Item)
        Next

        AdvancedListView.SetObjects(AdvSettingsList)

    End Sub

End Class

Public Class AdvancedOption
    Property DisplayName As String
    Property Settings As SettingsProperty
    Property Value As Boolean
    Property Group As AdvSettingGroup
End Class