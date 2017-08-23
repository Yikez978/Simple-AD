Imports System.Reflection

Module LDAPDataHelper

    Public Enum DataToLoadType
        Condensed = 0
        Full = 1
    End Enum

    Public Function GetLDAPProps() As String()
        Select Case My.Settings.LoadAdvLDAP
            Case False
                Return LDAPPropsShort
            Case True
                Return LDAPProps
        End Select
        Return Nothing
    End Function

    Public Function GetUserFromDataGridViewRow(ByVal Grid As DataGridView, ByVal Row As DataGridViewRow) As UserDomainObject

        Dim User As New UserDomainObject

        'Debug.WriteLine("[Info] New User request Started")

        Try
            For Each column As DataGridViewColumn In Grid.Columns
                Try

                    Dim Value As String = Row.Cells(column.Name).Value.ToString.Trim

                    If String.IsNullOrEmpty(Value) Then
                        Value = ""
                    End If

                    Select Case column.Name
                        Case "nameCol"
                            CallByName(User, "name", CallType.Set, Value.Trim)
                        Case Else
                            CallByName(User, column.Name, CallType.Set, Value.Trim)
                    End Select
                Catch Ex As Exception
                    'Debug.WriteLine("[Warning] Unable to set " & column.Name & " Property on user: " & Ex.Message)
                End Try
            Next

        Catch Ex As Exception
            'Debug.WriteLine("[Error] Unable to setup User Object: " & Ex.Message)
            Return Nothing
        End Try
        Return User
    End Function

End Module
