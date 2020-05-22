Imports ProfileManager
Imports Inventor

'Public Module test

    Public Sub Main()

        GetOptions(ThisApplication.DrawingOptions)

    End Sub


    Public Sub GetOptions(ByRef i As Object) 'DrawingOptions

        Dim names As List(Of String) = New List(Of String)({
        "ArcDimensionType",
        "CenterDimensionText",
        "CircleDimensionType",
        "DefaultDrawingFileType",
        "DefaultLayerStyle",
        "DefaultNonInventorDWGFileOpenBehavior",
        "DefaultObjectStyle",
        "DisplayLineWeights",
        "EditDimensionWhenCreated",
        "EnableBackgroundUpdates",
        "EnableOrdinateDimGeomSelection",
        "EnablePartModificationFromDrawing",
        "GetModelDimensions",
        "InventorDWGFileVersion",
        "LinearDimensionType",
        "LineWeightType",
        "ShowUncutSectionViewPreview",
        "StandardPartsSectionBehavior",
        "TitleBlockAlignment",
        "UpperLimitForFirstRangeOfLineWeights",
        "UpperLimitForSecondRangeOfLineWeights",
        "UpperLimitForThirdRangeOfLineWeights",
        "ViewBlockInsertionPoint",
        "ViewJustification",
        "ViewPreview"})

        Dim options As New Dictionary(of String, String)

        options.Clear()

        For Each name As String In names
            options.Add(name, CallByName (i, name, vbGet))
        Next

        msgbox(options("ViewPreview"))

    'Public Sub SetOptions(ByRef i As Inventor.ContentCenterOptions)


        For Each k In options.Keys
            CallByName(i, k, CallType.Let, options(k))
        Next


    End Sub

'End Module
