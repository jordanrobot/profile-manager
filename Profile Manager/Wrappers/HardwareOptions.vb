Namespace Wrappers
    <Serializable()>
    Public Class HardwareOptions
        Inherits Wrappers.OptionWrapper

        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"GraphicsSettingType",
                                         "UseSoftwareGraphics"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace