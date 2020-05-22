Imports Inventor

Namespace Wrappers

    Public Class SketchOptions

        Public options As New Hashtable
        Public sketchConstraintOptions As New Hashtable
        Public hudOptions As New HashTable
        Public Sub New()

        End Sub

        Public Sub GetOptions(ByRef i As Object)
            options.Clear()
            sketchConstraintOptions.Clear()
            hudOptions.Clear()

            Me.options.Add("AutomaticReferenceEdges", i.AutomaticReferenceEdges)
            Me.options.Add("AutoProjectEdges", i.AutoProjectEdges)
            Me.options.Add("AutoProjectPartOrigin", i.AutoProjectPartOrigin)
            Me.options.Add("AutoScaleSketchGeometriesOnInitialDimension", i.AutoScaleSketchGeometriesOnInitialDimension)
            Me.options.Add("ConstraintToolbarScale", i.ConstraintToolbarScale)
            Me.options.Add("DisplayAxes", i.DisplayAxes)
            Me.options.Add("DisplayCoordinateSystemIndicator", i.DisplayCoordinateSystemIndicator)
            Me.options.Add("DisplayGridLines", i.DisplayGridLines)
            Me.options.Add("DisplayMinorGridLines", i.DisplayMinorGridLines)
            Me.options.Add("ImageInsertionLINKOptionCheckedAsDefault", i.ImageInsertionLINKOptionCheckedAsDefault)
            Me.options.Add("ParallelViewOnSketchCreationInAssembly", i.ParallelViewOnSketchCreationInAssembly)
            Me.options.Add("ParallelViewOnSketchCreationInPart", i.ParallelViewOnSketchCreationInPart)
            Me.options.Add("PointAlignment", i.PointAlignment)
            Me.options.Add("ProjectObjectsAsConstructionGeometry", i.ProjectObjectsAsConstructionGeometry)
            Me.options.Add("SnapToGrid", i.SnapToGrid)
            Me.options.Add("SplineDefaultTension", i.SplineDefaultTension)
            Me.options.Add("SplineFitMethod", i.SplineFitMethod)

            Me.sketchConstraintOptions.Add("ConstraintInferencePriority", i.SketchConstraintSettings.ConstraintInferencePriority)
            Me.sketchConstraintOptions.Add("CreateDimensionsOnValueInput", i.SketchConstraintSettings.CreateDimensionsOnValueInput)
            Me.sketchConstraintOptions.Add("DisplayCoincidentConstraintsInSketch", i.SketchConstraintSettings.DisplayCoincidentConstraintsInSketch)
            Me.sketchConstraintOptions.Add("DisplayConstraintsOnCreation", i.SketchConstraintSettings.DisplayConstraintsOnCreation)
            Me.sketchConstraintOptions.Add("EditDimensionsWhenCreated", i.SketchConstraintSettings.EditDimensionsWhenCreated)
            Me.sketchConstraintOptions.Add("EnableInferConstraints", i.SketchConstraintSettings.EnableInferConstraints)
            Me.sketchConstraintOptions.Add("EnablePersistConstraints", i.SketchConstraintSettings.EnablePersistConstraints)
            Me.sketchConstraintOptions.Add("EnableRelaxMode", i.SketchConstraintSettings.EnableRelaxMode)
            Me.sketchConstraintOptions.Add("GeometricConstraintsToRemoveInRelaxMode", i.SketchConstraintSettings.GeometricConstraintsToRemoveInRelaxMode)
            Me.sketchConstraintOptions.Add("KeepDimensionsWithEquationInRelaxMode", i.SketchConstraintSettings.KeepDimensionsWithEquationInRelaxMode)
            Me.sketchConstraintOptions.Add("OverConstrainedDimensionBehavior", i.SketchConstraintSettings.OverConstrainedDimensionBehavior)
            Me.sketchConstraintOptions.Add("SelectionForGeometricConstraintsInference", i.SketchConstraintSettings.SelectionForGeometricConstraintsInference)
            Me.sketchConstraintOptions.Add("ShowConstraintsForSelectedObjects", i.SketchConstraintSettings.ShowConstraintsForSelectedObjects)

            Me.hudOptions.Add("DimensionInputEnabled", i.HeadsUpDisplayOptions.DimensionInputEnabled)
            Me.hudOptions.Add("Enabled", i.HeadsUpDisplayOptions.Enabled)
            Me.hudOptions.Add("PointerInputEnabled", i.HeadsUpDisplayOptions.PointerInputEnabled)
            Me.hudOptions.Add("PointerInputInCartesianCoordinates", i.HeadsUpDisplayOptions.PointerInputInCartesianCoordinates)

        End Sub


        Public Sub SetOptions(ByRef i As Object)

            'General Options'
            For Each k In Me.options.Keys
                CallByName(i, k, CallType.Let, Me.options(k))
            Next

            'Sketch Constraint Settings'
            For Each k In Me.sketchConstraintOptions.Keys
                CallByName(i.SketchConstraintSettings, k, CallType.Let, Me.sketchConstraintOptions(k))
            Next

            'Sketch Constraint Settings'
            For Each k In Me.hudOptions.Keys
                CallByName(i.HeadsUpDisplayOptions, k, CallType.Let, Me.hudOptions(k))
            Next

        End Sub

    End Class
End NameSpace