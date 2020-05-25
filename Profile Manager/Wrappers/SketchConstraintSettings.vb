Namespace Wrappers
    <Serializable()>
    Public Class SketchConstraintSettings
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
            New List(Of String)({"ConstraintInferencePriority",
                                 "CreateDimensionsOnValueInput",
                                 "DisplayCoincidentConstraintsInSketch",
                                 "DisplayConstraintsOnCreation",
                                 "EditDimensionsWhenCreated",
                                 "EnableInferConstraints",
                                 "EnablePersistConstraints",
                                 "EnableRelaxMode",
                                 "GeometricConstraintsToRemoveInRelaxMode",
                                 "KeepDimensionsWithEquationInRelaxMode",
                                 "OverConstrainedDimensionBehavior",
                                 "SelectionForGeometricConstraintsInference",
                                 "ShowConstraintsForSelectedObjects"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace