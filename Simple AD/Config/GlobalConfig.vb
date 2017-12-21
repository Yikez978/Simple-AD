﻿Imports System.Environment

Public Module GlobalConfig

    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Simple AD"

    Public UpdateURI As String = "http://storage.googleapis.com/simple-ad.appspot.com/SimpleAD/versioninfo.xml"

    Public Property Office365Username As String
    Public Property Office365Password As String

    Public OngoingBulkJobs As New List(Of BulkADWorker)
    Public ColumnRebuildRequired As Boolean

End Module