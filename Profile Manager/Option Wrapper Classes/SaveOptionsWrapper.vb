Imports Inventor

Public Class SaveOptionsWrapper

    Public options As New Hashtable

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Object)
        options.Clear()

        Me.options.Add("ListReferencedFilesInSaveDialog", i.ListReferencedFilesInSaveDialog)
        Me.options.Add("PromptSaveForMigration", i.PromptSaveForMigration)
        Me.options.Add("PromptSaveForRecomputableChanges", i.PromptSaveForRecomputableChanges)
        Me.options.Add("SaveReminderTimer", i.SaveReminderTimer)
        Me.options.Add("ShowSaveReminder", i.ShowSaveReminder)
        Me.options.Add("TranslatorReportLocation", i.TranslatorReportLocation)

    End Sub


    Public Sub SetOptions(ByRef i As Object)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

    End Sub

End Class
