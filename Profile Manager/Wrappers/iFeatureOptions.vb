Imports Inventor

Namespace Wrappers

    Public Class iFeatureOptions

        Public options As New Hashtable

        Public Sub New()

        End Sub

        Public Sub GetOptions(ByRef i As Object)
            options.Clear()

            Me.options.Add("RootPath", i.RootPath)
            Me.options.Add("SheetMetalPunchesRootPath", i.SheetMetalPunchesRootPath)
            Me.options.Add("UseKey1AsBrowserNameColumn", i.UseKey1AsBrowserNameColumn)
            Me.options.Add("UserRootPath", i.UserRootPath)
            Me.options.Add("Viewer", i.Viewer)
            Me.options.Add("ViewerArguments", i.ViewerArguments)

        End Sub


        Public Sub SetOptions(ByRef i As Object)

            'General Options'
            For Each k In Me.options.Keys
                CallByName(i, k, CallType.Let, Me.options(k))
            Next

        End Sub

    End Class
End NameSpace