Imports Inventor

Public Class FileOptionsWrapper

    Public options As New Hashtable
    Public fileOpenOptions As New Hashtable

    Public Sub New()

    End Sub

    Public Sub GetOptions(ByRef i As Object)
        options.Clear()
        fileOpenOptions.Clear()


        Me.options.Add("ContentCenterPath", i.ContentCenterPath)
        Me.options.Add("DefaultTemplateDrawingStandard", i.DefaultTemplateDrawingStandard)
        Me.options.Add("DefaultTemplateUnitsAreInches", i.DefaultTemplateUnitsAreInches)
        Me.options.Add("DefaultVBAProjectFileFullFilename", i.DefaultVBAProjectFileFullFilename)
        Me.options.Add("DesignDataPath", i.DesignDataPath)
        Me.options.Add("ProjectsPath", i.ProjectsPath)
        Me.options.Add("SymbolLibraryPath", i.SymbolLibraryPath)
        Me.options.Add("TeamWebFullFilename", i.TeamWebFullFilename)
        Me.options.Add("TemplatesPath", i.TemplatesPath)
        Me.options.Add("TexturePath", i.TexturePath)
        Me.options.Add("UndoPath", i.UndoPath)

        Me.fileOpenOptions.Add("DefaultDesignView", i.FileOpenOptions.DefaultDesignView)
        Me.fileOpenOptions.Add("DefaultDesignViewIsAssociative", i.FileOpenOptions.DefaultDesignViewIsAssociative)
        Me.fileOpenOptions.Add("DefaultLevelOfDetail", i.FileOpenOptions.DefaultLevelOfDetail)
        Me.fileOpenOptions.Add("SkipAllUnresolvedFilesInAssembly", i.FileOpenOptions.SkipAllUnresolvedFilesInAssembly)
        Me.fileOpenOptions.Add("SkipAllUnresolvedFilesInDrawing", i.FileOpenOptions.SkipAllUnresolvedFilesInDrawing)
        Me.fileOpenOptions.Add("SkipAllUnresolvedFilesInPart", i.FileOpenOptions.SkipAllUnresolvedFilesInPart)

    End Sub


    Public Sub SetOptions(ByRef i As Object)

        'General Options'
        For Each k In Me.options.Keys
            CallByName(i, k, CallType.Let, Me.options(k))
        Next

        'General Options'
        For Each k In Me.fileOpenOptions.Keys
            CallByName(i.FileOpenOptions, k, CallType.Let, Me.fileOpenOptions(k))
        Next

    End Sub

End Class
