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

    Public Function GetUserFromDataGridViewRow(ByVal Grid As DataGridView, ByVal Row As DataGridViewRow) As UserObject

        Dim User As New UserObject

        Debug.WriteLine("[Info] New User request Started - PropertyCount: " & User.GetType().GetProperties().Count)

        Try
            For Each Cell As DataGridViewCell In Row.Cells
                For Each Item As PropertyInfo In User.GetType().GetProperties()

                    Debug.WriteLine("[Info] Row Cell Count: " & Row.Cells.Count)

                    Dim ColumnName As String = GetFullLDAPName(Grid.Columns(Cell.ColumnIndex).Name)
                    Dim ItemName As String = GetFullLDAPName(Item.Name)

                    Debug.WriteLine(Grid.Rows.Item(Row.Index).Cells(ColumnName).Value)

                    If ItemName = ColumnName Then
                        Item.SetValue(User, Grid.Rows.Item(Row.Index).Cells(ColumnName).Value)
                    End If
                Next
            Next

            MsgBox("User.name" & User.name)
            Return User

        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to setup User Object: " & Ex.Message)
            Return Nothing
        End Try

    End Function

End Module
