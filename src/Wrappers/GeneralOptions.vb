Namespace Wrappers
    <Serializable()>
    Public Class GeneralOptions
        Inherits Wrappers.OptionWrapper

        '2021
        Private _names As List(Of String) = _
                    New List(Of String)({"_ShowHelpDialogOnStartup",
                                         "AnnotationScale",
                                         "EnableEnhancedHighlighting",
                                         "EnableLegacyProjectCreation",
                                         "EnableOptimizedSelection",
                                         "EnablePrehighlight",
                                         "iMateVisibility",
                                         "LoadVBAOnStartup",
                                         "SecondLevelTooltipDelay",
                                         "SelectOtherDelay",
                                         "Show3DIndicator",
                                         "ShowAutocompleteForCommandAlias",
                                         "ShowCommandAliasInputDialog",
                                         "ShowCommandPromptTooltips",
                                         "ShowDocumentTabTooltips",
                                         "ShowSecondLevelTooltips",
                                         "ShowStartupDialog",
                                         "ShowTooltips",
                                         "ShowVideoToolClips",
                                         "ShowXYZAxisLabels",
                                         "StartupActionType",
                                         "StartupProjectFileName",
                                         "StartupHelpFocusTopic",
                                         "TextAppearance",
                                         "TextSize",
                                         "ToleranceValue",
                                         "TooltipDelay",
                                         "UndoFileSize",
                                         "UpdatePropertiesOnSaveForFileType",
                                         "UseAutodeskOnlineHelp",
                                         "UseNegativeIntegralForInertialProperties",
                                         "UserName",
                                         "EnableSpellCheck",
                                         "ShowHomeBaseOnStartup"})

        Public Sub New()
            Names = _names
        End Sub

        Public Sub GetOptions2(ByRef i As Object)
            If i.GeneralOptions.StartupActionType = Inventor.StartupActionTypeEnum.kNewFileFromTemplateStartupAction Then
                Me.options.Add("StartupNewFileTemplateName", i.GeneralOptions.StartupNewFileTemplateName)
            End If
                               
        End Sub

    End Class
End NameSpace