Namespace Wrappers
    <Serializable()>
    Public Class FileOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
            New List(Of String)({"ContentCenterPath",
                                 "DefaultTemplateDrawingStandard",
                                 "DefaultTemplateUnitsAreInches",
                                 "DefaultVBAProjectFileFullFilename",
                                 "DesignDataPath",
                                 "ProjectsPath",
                                 "SymbolLibraryPath",
                                 "TeamWebFullFilename",
                                 "TemplatesPath",
                                 "TexturePath",
                                 "UndoPath"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace