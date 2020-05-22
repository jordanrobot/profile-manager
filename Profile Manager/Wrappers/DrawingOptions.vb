Imports Inventor

Public Class DrawingOptions

    Public options As New Hashtable

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Object)
        options.Clear()

        Me.options.Add("ArcDimensionType", i.ArcDimensionType)
        Me.options.Add("CenterDimensionText", i.CenterDimensionText)
        Me.options.Add("CircleDimensionType", i.CircleDimensionType)
        Me.options.Add("DefaultDrawingFileType", i.DefaultDrawingFileType)
        Me.options.Add("DefaultLayerStyle", i.DefaultLayerStyle)
        Me.options.Add("DefaultNonInventorDWGFileOpenBehavior", i.DefaultNonInventorDWGFileOpenBehavior)
        Me.options.Add("DefaultObjectStyle", i.DefaultObjectStyle)
        Me.options.Add("DisplayLineWeights", i.DisplayLineWeights)
        Me.options.Add("EditDimensionWhenCreated", i.EditDimensionWhenCreated)
        Me.options.Add("EnableBackgroundUpdates", i.EnableBackgroundUpdates)
        Me.options.Add("EnableOrdinateDimGeomSelection", i.EnableOrdinateDimGeomSelection)
        Me.options.Add("EnablePartModificationFromDrawing", i.EnablePartModificationFromDrawing)
        Me.options.Add("GetModelDimensions", i.GetModelDimensions)
        Me.options.Add("InventorDWGFileVersion", i.InventorDWGFileVersion)
        Me.options.Add("LinearDimensionType", i.LinearDimensionType)
        Me.options.Add("LineWeightType", i.LineWeightType)
        Me.options.Add("ShowUncutSectionViewPreview", i.ShowUncutSectionViewPreview)
        Me.options.Add("StandardPartsSectionBehavior", i.StandardPartsSectionBehavior)
        Me.options.Add("TitleBlockAlignment", i.TitleBlockAlignment)
        Me.options.Add("UpperLimitForFirstRangeOfLineWeights", i.UpperLimitForFirstRangeOfLineWeights)
        Me.options.Add("UpperLimitForSecondRangeOfLineWeights", i.UpperLimitForSecondRangeOfLineWeights)
        Me.options.Add("UpperLimitForThirdRangeOfLineWeights", i.UpperLimitForThirdRangeOfLineWeights)
        Me.options.Add("ViewBlockInsertionPoint", i.ViewBlockInsertionPoint)
        Me.options.Add("ViewJustification", i.ViewJustification)
        Me.options.Add("ViewPreview", i.ViewPreview)

    End Sub


    Public Sub SetOptions(ByRef i As Object)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

    End Sub

End Class
