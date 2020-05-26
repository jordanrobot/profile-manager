Namespace Wrappers
    <Serializable()>
    Public Class CcLibraries

        Private _accessOption As Inventor.ContentCenterAccessOptionEnum
        Private _librariesLocation As String

        Public Sub GetOptions(ByRef i As Inventor.ContentCenterOptions)

            'Retrieve Access Options
            i.GetAccessOption(_accessOption, _librariesLocation)
            If String.IsNullOrEmpty(_librariesLocation) Then _librariesLocation = ""

        End Sub

        Public Sub SetOptions(ByRef i As Inventor.ContentCenterOptions)

            'Save Access Options
            i.SetAccessOption(_accessOption, _librariesLocation)

        End Sub

    End Class
End NameSpace