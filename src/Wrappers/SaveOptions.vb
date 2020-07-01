Namespace Wrappers
    <Serializable()>
    Public Class SaveOptions
        Inherits Wrappers.OptionWrapper

        '2021
        Private _names As List(Of String) = _
                    New List(Of String)({"ListReferencedFilesInSaveDialog",
                                         "PromptSaveForMigration",
                                         "PromptSaveForRecomputableChanges",
                                         "SaveFilesInLibraryFolders",
                                         "SaveReminderTimer",
                                         "ShowSaveReminder",
                                         "TranslatorReportLocation",
                                         "DefaultToSaveForAPIChanges",
                                         "DefaultToSaveForFileResolutionChange",
                                         "DefaultToSaveForImplicitUpdate",
                                         "DefaultToSaveForManualUpdates",
                                         "DefaultToSaveForMassPropertyUpdate",
                                         "DefaultToSaveForMigration",
                                         "DefaultToSaveForUserEdits",
                                         "PromptSaveForAPIChanges",
                                         "PromptSaveForFileResolutionChange",
                                         "PromptSaveForImplicitUpdate",
                                         "PromptSaveForManualUpdates",
                                         "PromptSaveForMassPropertyUpdate",
                                         "PromptSaveForUserEdits"})
        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace