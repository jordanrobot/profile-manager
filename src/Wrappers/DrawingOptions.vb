Namespace Wrappers
    <Serializable()>
    Public Class DrawingOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"ArcDimensionType",
                                         "CenterDimensionText",
                                         "CircleDimensionType",
                                         "DefaultDrawingFileType",
                                         "DefaultLayerStyle",
                                         "DefaultNonInventorDWGFileOpenBehavior",
                                         "DefaultObjectStyle",
                                         "DisplayLineWeights",
                                         "EditDimensionWhenCreated",
                                         "EnableBackgroundUpdates",
                                         "EnableOrdinateDimGeomSelection",
                                         "EnablePartModificationFromDrawing",
                                         "GetModelDimensions",
                                         "InventorDWGFileVersion",
                                         "LinearDimensionType",
                                         "LineWeightType",
                                         "ShowUncutSectionViewPreview",
                                         "StandardPartsSectionBehavior",
                                         "TitleBlockAlignment",
                                         "UpperLimitForFirstRangeOfLineWeights",
                                         "UpperLimitForSecondRangeOfLineWeights",
                                         "UpperLimitForThirdRangeOfLineWeights",
                                         "ViewBlockInsertionPoint",
                                         "ViewJustification",
                                         "ViewPreview"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace