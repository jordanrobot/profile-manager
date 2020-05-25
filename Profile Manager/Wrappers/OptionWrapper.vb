Namespace Wrappers
    <Serializable()>
    Public Class OptionWrapper
        
        Public Options As New Dictionary(Of String, Object)
        Public Property Names As List(Of String)

        Public Sub New()
        End Sub

        Public Sub GetOptions(ByRef i As Object)
            For Each name As String In Names
                Try
                    Options.Add(name, CallByName (i, name, vbGet))
                Catch
                End Try
            Next
        End Sub

        Public Sub SetOptions(ByRef i As Object)
            For Each k In options.Keys
                Try
                    CallByName(i, k, CallType.Let, options(k))
                Catch
                End Try
            Next
        End Sub
    End Class

End Namespace