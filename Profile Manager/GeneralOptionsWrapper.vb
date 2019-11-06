Imports Inventor

Public Class GeneralOptionsWrapper

    Public options As New Hashtable
    Public gripSnapOptions As New Hashtable

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Object)
        options.Clear()
        gripSnapOptions.Clear()

        Me.options.Add("AnnotationScale", i.AnnotationScale)
        Me.options.Add("EnableLegacyProjectCreation", i.EnableLegacyProjectCreation)
        Me.options.Add("EnableOptimizedSelection", i.EnableOptimizedSelection)
        Me.options.Add("iMateVisibility", i.iMateVisibility)
        Me.options.Add("SecondLevelTooltipDelay", i.SecondLevelTooltipDelay)
        Me.options.Add("SelectOtherDelay", i.SelectOtherDelay)
        Me.options.Add("ShowAutocompleteForCommandAlias", i.ShowAutocompleteForCommandAlias)
        Me.options.Add("ShowCommandAliasInputDialog", i.ShowCommandAliasInputDialog)
        Me.options.Add("ShowCommandPromptTooltips", i.ShowCommandPromptTooltips)
        Me.options.Add("ShowDocumentTabTooltips", i.ShowDocumentTabTooltips)
        Me.options.Add("ShowSecondLevelTooltips", i.ShowSecondLevelTooltips)
        Me.options.Add("ShowTooltips", i.ShowTooltips)
        Me.options.Add("StartupActionType", i.StartupActionType)

        If i.StartupActionType = Inventor.StartupActionTypeEnum.kNewFileFromTemplateStartupAction Then
            Me.options.Add("StartupNewFileTemplateName", i.StartupNewFileTemplateName)
        End If
        Me.options.Add("StartupProjectFileName", i.StartupProjectFileName)
        Me.options.Add("TextAppearance", i.TextAppearance)
        Me.options.Add("TextSize", i.TextSize)
        Me.options.Add("ToleranceValue", i.ToleranceValue)
        Me.options.Add("TooltipDelay", i.TooltipDelay)
        Me.options.Add("UndoFileSize", i.UndoFileSize)
        Me.options.Add("UpdatePropertiesOnSaveForFileType", i.UpdatePropertiesOnSaveForFileType)
        Me.options.Add("UseAutodeskOnlineHelp", i.UseAutodeskOnlineHelp)
        Me.options.Add("UseNegativeIntegralForInertialProperties", i.UseNegativeIntegralForInertialProperties)
        Me.options.Add("UserName", i.UserName)

        Me.gripSnapOptions.Add("SelectGroundedComponentsAndWorkGeometry", i.GripSnapOptions.SelectGroundedComponentsAndWorkGeometry)
        Me.gripSnapOptions.Add("DisplayObjectInOriginalLocation", i.GripSnapOptions.DisplayObjectInOriginalLocation)
        Me.gripSnapOptions.Add("ShowDegreesOfFreedom", i.GripSnapOptions.ShowDegreesOfFreedom)
        Me.gripSnapOptions.Add("UseFreeDrag", i.GripSnapOptions.UseFreeDrag)
        Me.gripSnapOptions.Add("UseTemporaryConstraints", i.GripSnapOptions.UseTemporaryConstraints)
    End Sub


    Public Sub SaveOptions(ByRef i As Object)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

        'Grip Snap Options'
        For Each k In Me.gripSnapOptions.Keys
            CallByName(i.gripSnapOptions, k, CallType.Let, Me.gripSnapOptions(k))
        Next

    End Sub

End Class
