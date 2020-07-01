' TODO: This module exists as a convenient location for the code that does the real
'       work when a command is executed.  If you're converting VBA macros into add-in 
'       commands you can copy the macros here, make changes to make them VB.NET compatible, 
'       and change any references to "ThisApplication" to "g_inventorApplication".  The example 
'       command in StandardAddInServer.vb demonstrates running the "SampleCommandFunction" below.

Public Module CommandFunctions
    ' Example function that's called when the sample command is executed.
    Public Sub startProfileManager()
        'Start up the form
        Dim formMain As New formMain
        formMain.Show()
    End Sub

End Module
