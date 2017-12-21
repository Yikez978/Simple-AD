Public Module HTML

    Public Function StyleHTMLExport(ByVal Data As String) As String

        Return Styling + Environment.NewLine + Data

    End Function

    Dim Styling As String =
"<style>

    th, td{
        border-bottom: 1px solid #ddd;
        padding: 4px;
        font: menu;
    }

    th{
	    height: 48px;
	    font-weight: bold;
    }

    tr:nth-child(even) {
	    background-color: #FBF8FA
    }

    tr:hover {
	    background-color: #f5f5f5
    }

</Style>"

End Module
