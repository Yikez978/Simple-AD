Imports System.IO

Public Class ConsoleHandler

    Private MyWriter As TextWriterTraceListener
    Private ConsoleHandle As IntPtr

    Public ObjStream As FileStream

    Sub New()
        'ObjStream = New FileStream(appData & "\AppConsoleTrace.Log", FileMode.OpenOrCreate)

        'MyWriter = New TextWriterTraceListener(ObjStream)
        'Debug.Listeners.Add(MyWriter)

        'ObjStream.Close()
        'MyWriter.Close()
    End Sub

End Class

