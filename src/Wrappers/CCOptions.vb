Namespace Wrappers
    <Serializable()>
    Public Class CCOptions
        Inherits OptionWrapper
        
        '2019
        Public _names As List(Of String) = _
                    New List(Of String)({"CheckFamiliesUpdates",
                                         "CustomFamilyAsStandard",
                                         "RefreshOutOfDateStandardParts"})
        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace