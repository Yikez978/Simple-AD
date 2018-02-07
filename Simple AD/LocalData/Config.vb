Imports Nini.Config

Namespace LocalData

    Public Module Config

        Public Sub Init()

        End Sub

        Public Sub CreateDefaultConfig()

            Dim Source As IniConfigSource = New IniConfigSource()

            Dim Config As IConfig = Source.AddConfig("Authentication")
            Config.Set("Username", "")
            Config.Set("Password", "")
            Config.Set("AutoLogin", "false")
            Config.Set("ForceLogin", "false")
            Config.Set("ManualLogin", "false")

            Config = Source.AddConfig("Office 365")
            Config.Set("OfficeURI", "https://ps.outlook.com/PowerShell-LiveID?PSVersion=2.0")
            Config.Set("OfficeShellURI", "http://schemas.microsoft.com/powershell/Microsoft.Exchange")

            Config = Source.AddConfig("Updates")
            Config.Set("CheckForUpdatesOnStart", "true")
            Config.Set("UseProxy", "true")

            Config = Source.AddConfig("Window")
            Config.Set("FormWindowState", "2")
            Config.Set("FormWidth", "1280")
            Config.Set("FormHeight", "720")
            Config.Set("FormX", "0")
            Config.Set("FormY", "0")

            Config = Source.AddConfig("Export")
            Config.Set("AutoOpenExports", "true")

            Config = Source.AddConfig("LDAP")
            Config.Set("UsePaging", "true")

            Source.Save(AppData & "\SimpleADConfig.ini")

        End Sub

    End Module

End Namespace