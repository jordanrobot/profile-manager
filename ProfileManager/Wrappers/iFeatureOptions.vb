Namespace Wrappers
    <Serializable()>
    Public Class iFeatureOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"RootPath",
                                         "SheetMetalPunchesRootPath",
                                         "UseKey1AsBrowserNameColumn",
                                         "UserRootPath",
                                         "Viewer",
                                         "ViewerArguments"})
        
        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace