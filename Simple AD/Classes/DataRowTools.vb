Imports System.Data
Imports System.Data.SqlClient
Module DataRowTools

    Sub Main()
        Dim ds As DataSet = New DataSet()
        Dim tblProducts As DataTable
        Dim tblProductsCopy As DataTable

        Dim tblProductsCount As Integer
        Dim tblProductsCopyCount As Integer
        Dim i As Integer

        'Change the connection string to your server.
        Dim conn As SqlConnection = New SqlConnection("Server=ServerName;database=Northwind;UID=<User ID>;PWD=<PassWord>")
        'Create the DataAdapter.
        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from products", conn)
        'Fill the DataSet with data.
        da.Fill(ds, "products")


        tblProducts = ds.Tables("products")
        tblProductsCount = tblProducts.Rows.Count
        'Write the number of rows in Products table to the screen.
        Console.WriteLine("Table tblProducts has " & tblProductsCount.ToString & " Rows")

        'Loop through the top five rows and write the first column to the screen.
        For i = 0 To 4
            Console.WriteLine("Row(" & i.ToString & ") = " & tblProducts.Rows(i)(1))
        Next

        'The Clone method makes a copy of the table structure (Schema).
        tblProductsCopy = tblProducts.Clone
        'Use ImportRow method to copy from Products table to its clone.
        For i = 0 To 4
            tblProductsCopy.ImportRow(tblProducts.Rows(i))
        Next

        tblProductsCopyCount = tblProductsCopy.Rows.Count
        'Write blank line.
        Console.WriteLine("")
        'Write the number of rows in tblProductsCopy table to the screen.
        Console.WriteLine("Table tblProductsCopy has " & tblProductsCopyCount.ToString & " Rows")

        'Loop through the top five rows and write the first column to the screen.
        For i = 0 To tblProductsCopyCount - 1
            Console.WriteLine("Row(" & i.ToString & ") = " & tblProductsCopy.Rows(i)(1))
        Next

    End Sub

End Module
