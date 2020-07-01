Namespace Wrappers
    <Serializable()>
    Public Class FileOpenOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"DefaultDesignView",
                                         "DefaultDesignViewIsAssociative",
                                         "DefaultLevelOfDetail",
                                         "SkipAllUnresolvedFilesInAssembly",
                                         "SkipAllUnresolvedFilesInDrawing",
                                         "SkipAllUnresolvedFilesInPart"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace