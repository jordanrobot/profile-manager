Public Class CCOptionsWrapper

    Private options As New Hashtable
    Private accessOption As Inventor.ContentCenterAccessOptionEnum
    Private librariesLocation As String

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Inventor.ContentCenterOptions)
        options.Clear()

        Me.options.Add("CheckFamiliesUpdates", i.CheckFamiliesUpdates)
        Me.options.Add("CustomFamilyAsStandard", i.CustomFamilyAsStandard)
        Me.options.Add("RefreshOutOfDateStandardParts", i.RefreshOutOfDateStandardParts)

        'Retreive Access Options
        i.GetAccessOption(accessOption, librariesLocation)
        If String.IsNullOrEmpty(librariesLocation) Then librariesLocation = ""

    End Sub


    Public Sub SaveOptions(ByRef i As Inventor.ContentCenterOptions)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

        'Save Access Options
        i.SetAccessOption(accessOption, librariesLocation)

    End Sub

End Class
