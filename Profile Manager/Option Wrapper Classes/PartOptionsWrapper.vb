Public Class PartOptionsWrapper

    Private options As New Hashtable

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Inventor.PartOptions)
        options.Clear()

        Me.options.Add("AutoConsumeWorkAndSurfaceFeatures", i.AutoConsumeWorkAndSurfaceFeatures)
        Me.options.Add("AutoHideInLineWorkFeatures", i.AutoHideInLineWorkFeatures)
        Me.options.Add("DefaultDesignView", i.DefaultDesignView)
        Me.options.Add("DefaultDesignViewIsAssociative", i.DefaultDesignViewIsAssociative)
        Me.options.Add("DerivedPartColorOverride", i.DerivedPartColorOverride)
        Me.options.Add("DimensionConstraintsRelaxation", i.DimensionConstraintsRelaxation)
        Me.options.Add("DisplayExtendedName", i.DisplayExtendedName)
        Me.options.Add("DisplayGripsOnSelection", i.DisplayGripsOnSelection)
        'Me.options.Add("EditBaseSolidsUsingFusion", i.EditBaseSolidsUsingFusion)
        Me.options.Add("Enable3DGrips", i.Enable3DGrips)
        Me.options.Add("EnableConstructionEnvironment", i.EnableConstructionEnvironment)
        Me.options.Add("GeometricConstraintsBreakage", i.GeometricConstraintsBreakage)
        Me.options.Add("OpaqueConstructionSurfaces", i.OpaqueConstructionSurfaces)
        Me.options.Add("SketchCreationOnNewPart", i.SketchCreationOnNewPart)

    End Sub


    Public Sub SetOptions(ByRef i As Inventor.PartOptions)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

    End Sub

End Class
