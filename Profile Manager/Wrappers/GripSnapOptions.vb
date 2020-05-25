Namespace Wrappers
    <Serializable()>
    Public Class GripSnapOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"SelectGroundedComponentsAndWorkGeometry",
                                         "DisplayObjectInOriginalLocation",
                                         "ShowDegreesOfFreedom",
                                         "UseFreeDrag",
                                         "UseTemporaryConstraints"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace