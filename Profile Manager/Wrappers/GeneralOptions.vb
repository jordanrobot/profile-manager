Namespace Wrappers
    Public Class GeneralOptions
        Inherits Wrappers.OptionWrapper

        Private _names = ({"AnnotationScale",
                           "EnableLegacyProjectCreation",
                           "EnableOptimizedSelection",
                           "iMateVisibility",
                           "SecondLevelTooltipDelay",
                           "SelectOtherDelay",
                           "ShowAutocompleteForCommandAlias",
                           "ShowCommandAliasInputDialog",
                           "ShowCommandPromptTooltips",
                           "ShowDocumentTabTooltips",
                           "ShowSecondLevelTooltips",
                           "ShowTooltips",
                           "StartupActionType",
                           "StartupProjectFileName",
                           "TextAppearance",
                           "TextSize",
                           "ToleranceValue",
                           "TooltipDelay",
                           "UndoFileSize",
                           "UpdatePropertiesOnSaveForFileType",
                           "UseAutodeskOnlineHelp",
                           "UseNegativeIntegralForInertialProperties",
                           "UserName"})

        Public Sub GetOptions2(ByRef i As Object)
            If i.StartupActionType = Inventor.StartupActionTypeEnum.kNewFileFromTemplateStartupAction Then
                Me.options.Add("StartupNewFileTemplateName", i.StartupNewFileTemplateName)
            End If
                               
        End Sub

    End Class
End NameSpace