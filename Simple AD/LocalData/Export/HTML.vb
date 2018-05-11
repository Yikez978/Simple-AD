Imports System

Namespace LocalData.Export

    Public Module HTML

        Public Function StyleHTMLExport(ByVal Data As String) As String

            Return Styling + Environment.NewLine + Environment.NewLine + Data

        End Function

        Dim Styling As String =
    "<Style>

@media 
only screen and (max-width: 760px),
(min-device-width: 768px) and (max-device-width: 1024px)  {

	table { 
	  	width: 96%; 
	}

	/* Force table to not be like tables anymore */
	table, tbody, th, td, tr { 
		display: block; 
	}
	
	/* Hide table headers (but not display: none;, for accessibility) */
	tr:first-of-type > td { 
		position: absolute;
		top: -9999px;
		left: -9999px;
	}
	
	tr { 
		border: 1px solid #ccc; 
	}
	
  tr > td:first-child  {      
		font-weight: Bold;
		color: #522B66;
	}
    
	td { 
		/* Behave  like a row */
		border: none;
		border-bottom: 1px solid #eee; 
		position: relative;
		padding-left: 50%; 
	}

	td:before { 
		/* Now like a table header */
		position: absolute;
		/* Top/left values mimic padding */
		top: 6px;
		left: 6px;
		width: 45%; 
		padding-right: 10px; 
		white-space: nowrap;
		/* Label the data */
		content: attr(data-column);

		color: #000;
		font-weight: bold;
	}

}

header {
    font: menu;
    font-size: 32px;
}

table {
    margin-left: auto;
    margin-right: auto;
    margin-top: 32px;
    margin-bottom: 32px;
    border: 1px solid #ddd;
    border-collapse: separate;
    border-spacing: 0;
    box-shadow: 0px 0px 28px -13px rgba(163,163,163,1);
	  table-layout: fixed;    
    width: 96% !important;
}

th, td{
    border-bottom: 1px solid #ddd;
    padding: 8px;
    font: menu;
    font-size: 14px;
    text-overflow: ellipsis;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap;
}

th{
    height: 48px;
    font-weight: bold;
}

tr:nth-child(even) {
    background-color: #FBFBFB
}

tr:first-of-type > td {
    font-weight: Bold;
    color: #522B66;
}

tr:hover {
    background-color: #f5f5f5
}

</Style>"

    End Module
End Namespace
