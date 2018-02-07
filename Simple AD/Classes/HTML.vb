Public Module HTML

    Public Function StyleHTMLExport(ByVal Data As String) As String

        Return Styling + Environment.NewLine + Data

    End Function

    Dim Styling As String =
"<style>

header {
    font: menu;
    font-size: 32px;
}

table {
    width: 80%;
    margin-left: auto;
    margin-right: auto;
    margin-top: 32px;
    margin-bottom: 32px;
    border: 1px solid #ddd;
    border-collapse: collapse;
    box-shadow: 0px 0px 28px -13px rgba(163,163,163,1);
}

th, td{
    border-bottom: 1px solid #ddd;
    padding: 8px;
    font: menu;
    font-size: 14px;
    text-overflow: ellipsis;
}

th{
    height: 48px;
    font-weight: bold;
}

tr:nth-child(even) {
    background-color: #FBFBFB
}

tr:hover {
    background-color: #f5f5f5
}

</Style>"

End Module
