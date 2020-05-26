Namespace Wrappers
    <Serializable()>
    Public Class Sketch3DOptions
        Inherits Wrappers.OptionWrapper

        '2021
        Private _names As List(Of String) = _
                    New List(Of String)({"AutoBendWithLineCreation"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace