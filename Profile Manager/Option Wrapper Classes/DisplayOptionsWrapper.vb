Public Class DisplayOptionsWrapper

    Private options As New Hashtable

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Inventor.DisplayOptions)
        options.Clear()

        Me.options.Add("AreTexturesOn", i.AreTexturesOn)
        Me.options.Add("DefaultOrbitType", i.DefaultOrbitType)
        Me.options.Add("DepthDimming", i.DepthDimming)
        Me.options.Add("DisplayQuality", i.DisplayQuality)
        Me.options.Add("DisplaySilhouettes", i.DisplaySilhouettes)
        Me.options.Add("EdgeColor", i.EdgeColor)
        Me.options.Add("HiddenLineDimmingPercent", i.HiddenLineDimmingPercent)
        Me.options.Add("InactiveComponentsEdgeColor", i.InactiveComponentsEdgeColor)
        Me.options.Add("InactiveComponentsEdgeDisplay", i.InactiveComponentsEdgeDisplay)
        Me.options.Add("InactiveComponentsShaded", i.InactiveComponentsShaded)
        Me.options.Add("InactiveComponentsShadeOpacity", i.InactiveComponentsShadeOpacity)
        Me.options.Add("MinimumFrameRate", i.MinimumFrameRate)
        Me.options.Add("NewWindowDisplayMode", i.NewWindowDisplayMode)
        Me.options.Add("NewWindowProjectionType", i.NewWindowProjectionType)
        Me.options.Add("NewWindowShowAmbientShadows", i.NewWindowShowAmbientShadows)
        Me.options.Add("NewWindowShowGroundPlane", i.NewWindowShowGroundPlane)
        Me.options.Add("NewWindowShowGroundReflections", i.NewWindowShowGroundReflections)
        Me.options.Add("NewWindowShowGroundShadows", i.NewWindowShowGroundShadows)
        Me.options.Add("RayTracingQuality", i.RayTracingQuality)
        Me.options.Add("ReverseZoomDirection", i.ReverseZoomDirection)
        Me.options.Add("Show3DIndicator", i.Show3DIndicator)
        Me.options.Add("ShowXYZAxisLabels", i.ShowXYZAxisLabels)
        Me.options.Add("SolidLinesForHiddenEdges", i.SolidLinesForHiddenEdges)
        Me.options.Add("UseDocumentDisplaySettings", i.UseDocumentDisplaySettings)
        Me.options.Add("UseRayTracingForRealisticDisplay", i.UseRayTracingForRealisticDisplay)
        Me.options.Add("ViewTransitionTime", i.ViewTransitionTime)
        Me.options.Add("ZoomToCursor", i.ZoomToCursor)

    End Sub


    Public Sub SetOptions(ByRef i As Inventor.DisplayOptions)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

    End Sub

End Class
