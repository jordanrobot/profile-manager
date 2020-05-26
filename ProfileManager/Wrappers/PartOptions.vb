Namespace Wrappers
    <Serializable()>
    Public Class PartOptions

        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"AutoConsumeWorkAndSurfaceFeatures",
                                         "AutoHideInLineWorkFeatures",
                                         "DefaultDesignView",
                                         "DefaultDesignViewIsAssociative",
                                         "DerivedPartColorOverride",
                                         "DimensionConstraintsRelaxation",
                                         "DisplayExtendedName",
                                         "DisplayGripsOnSelection",
                                         "Enable3DGrips",
                                         "EnableConstructionEnvironment",
                                         "GeometricConstraintsBreakage",
                                         "OpaqueConstructionSurfaces",
                                         "SketchCreationOnNewPart"})
        
        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace