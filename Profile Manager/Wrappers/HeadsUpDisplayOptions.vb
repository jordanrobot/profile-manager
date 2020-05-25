Namespace Wrappers
    <Serializable()>
    Public Class HeadsUpDisplayOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"DimensionInputEnabled",
                                         "Enabled",
                                         "PointerInputEnabled",
                                         "PointerInputInCartesianCoordinates"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace