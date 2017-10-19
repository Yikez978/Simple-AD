Imports System.IO

Public Class ConsoleHandler

    Private MyWriter As TextWriterTraceListener
    Private ConsoleHandle As IntPtr

    Sub New()
        Dim ObjStream As New FileStream(appData & "\AppConsoleTrace.Log", FileMode.OpenOrCreate)

        MyWriter = New TextWriterTraceListener(ObjStream)
        Debug.Listeners.Add(MyWriter)
    End Sub

End Class

