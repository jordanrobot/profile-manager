Namespace Wrappers
    <Serializable()>
    Public Class SketchOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"AutomaticReferenceEdges",
                                         "AutoProjectEdges",
                                         "AutoProjectPartOrigin",
                                         "AutoScaleSketchGeometriesOnInitialDimension",
                                         "ConstraintToolbarScale",
                                         "DisplayAxes",
                                         "DisplayCoordinateSystemIndicator",
                                         "DisplayGridLines",
                                         "DisplayMinorGridLines",
                                         "ImageInsertionLINKOptionCheckedAsDefault",
                                         "ParallelViewOnSketchCreationInAssembly",
                                         "ParallelViewOnSketchCreationInPart",
                                         "PointAlignment",
                                         "ProjectObjectsAsConstructionGeometry",
                                         "SnapToGrid",
                                         "SplineDefaultTension",
                                         "SplineFitMethod"})
    
        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace