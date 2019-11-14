Public Class ProfileObject

    Public Name As String

    Private _CCOptionsWrapper As CCOptionsWrapper
    Private _GeneralOptionsWrapper As GeneralOptionsWrapper
    Private _DisplayOptions As DisplayOptionsWrapper
    Private _DrawingOption As DrawingOptionsWrapper
    Private _FileOptions As FileOptionsWrapper
    'Private _FilesOptions As FileOptions
    'Private _HardwareOptions As HardwareOptions
    'Private _iFeatureOptions As iFeatureOptions
    'Private _NotebookOptions As NotebookOptions
    'Private _PartOptions As PartOptions
    'Private _SaveOptions As SaveOptions
    'Private _Sketch3DOptions As Sketch3DOptions
    'Private _SketchOptions As SketchOptions
    'Private _IlogicPathSettings As iLogicPathSettings
    'Private _ProjectOptions As ProjectOptions

    Public Sub New(ByVal Name As String)

        Me.GetOptions()
        ' code here

    End Sub

    Public Sub GetOptions()
        _CCOptionsWrapper.GetOptions(g_inventorApplication)
        _GeneralOptionsWrapper.GetOptions(g_inventorApplication)
        _DisplayOptions.GetOptions(g_inventorApplication)
        _DrawingOption.GetOptions(g_inventorApplication)
        _FileOptions.GetOptions(g_inventorApplication)

    End Sub

    Public Sub SetOptions()

    End Sub

    Public Function IsDirty() As Boolean

        Return False
    End Function

End Class
