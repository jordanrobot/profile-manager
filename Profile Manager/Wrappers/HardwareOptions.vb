Imports Inventor

Namespace Wrappers

    Public Class HardwareOptions

        Public options As New Hashtable

        Public Sub New()

        End Sub

        Public Sub GetOptions(ByRef i As Object)
            options.Clear()

            Me.options.Add("GraphicsSettingType", i.GraphicsSettingType)
            Me.options.Add("UseSoftwareGraphics", i.UseSoftwareGraphics)

        End Sub


        Public Sub SetOptions(ByRef i As Object)

            'General Options'
            For Each k In Me.options.Keys
                CallByName(i, k, CallType.Let, Me.options(k))
            Next

        End Sub

    End Class
End NameSpace