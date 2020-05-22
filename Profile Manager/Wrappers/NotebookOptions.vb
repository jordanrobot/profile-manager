Imports Inventor

Namespace Wrappers

    Public Class NotebookOptions

        Public options As New Hashtable

        Public Sub New()

        End Sub

        Public Sub GetOptions(ByRef i As Object)
            options.Clear()

            Me.options.Add("ArrowColor", i.ArrowColor)
            Me.options.Add("DisplayNoteIcons", i.DisplayNoteIcons)
            Me.options.Add("DisplayNoteText", i.DisplayNoteText)
            Me.options.Add("KeepNotesOnDeletedObjects", i.KeepNotesOnDeletedObjects)
            Me.options.Add("NoteHighlightColor", i.NoteHighlightColor)
            Me.options.Add("TextBackgroundColor", i.TextBackgroundColor)

        End Sub


        Public Sub SetOptions(ByRef i As Object)

            'General Options'
            For Each k In Me.options.Keys
                CallByName(i, k, CallType.Let, Me.options(k))
            Next

        End Sub

    End Class
End NameSpace