Namespace Wrappers
    <Serializable()>
    Public Class NotebookOptions
        Inherits Wrappers.OptionWrapper
    
        '2019
        Private _names As List(Of String) = _
                    New List(Of String)({"ArrowColor",
                                         "DisplayNoteIcons",
                                         "DisplayNoteText",
                                         "KeepNotesOnDeletedObjects",
                                         "NoteHighlightColor",
                                         "TextBackgroundColor"})

        Public Sub New()
            Names = _names
        End Sub

    End Class
End NameSpace