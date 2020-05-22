Namespace Wrappers
    Public Class OptionWrapper
        
        Public Options As New Dictionary(Of String, Object)
        Private _names As List(Of String)

        Public Sub GetOptions(ByRef i As Object)
            For Each name As String In _names
                options.Add(name, CallByName (i, name, vbGet))
            Next
        End Sub

        Public Sub SetOptions(ByRef i As Object)
            For Each k In options.Keys
                CallByName(i, k, CallType.Let, options(k))
            Next
        End Sub
    End Class

End Namespace