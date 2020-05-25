Namespace Wrappers
    <Serializable()>
    Public Class DisplayOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
            New List(Of String)({"AreTexturesOn",
                                 "DefaultOrbitType",
                                 "DepthDimming",
                                 "DisplayQuality",
                                 "DisplaySilhouettes",
                                 "EdgeColor",
                                 "HiddenLineDimmingPercent",
                                 "InactiveComponentsEdgeColor",
                                 "InactiveComponentsEdgeDisplay",
                                 "InactiveComponentsShaded",
                                 "InactiveComponentsShadeOpacity",
                                 "MinimumFrameRate",
                                 "NewWindowDisplayMode",
                                 "NewWindowProjectionType",
                                 "NewWindowShowAmbientShadows",
                                 "NewWindowShowGroundPlane",
                                 "NewWindowShowGroundReflections",
                                 "NewWindowShowGroundShadows",
                                 "RayTracingQuality",
                                 "ReverseZoomDirection",
                                 "Show3DIndicator",
                                 "ShowXYZAxisLabels",
                                 "SolidLinesForHiddenEdges",
                                 "UseDocumentDisplaySettings",
                                 "UseRayTracingForRealisticDisplay",
                                 "ViewTransitionTime",
                                 "ZoomToCursor"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace