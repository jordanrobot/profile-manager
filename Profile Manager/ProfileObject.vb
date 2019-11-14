Public Class ProfileObject

    Public Name As String

    Private _CCOptions As CCOptionsWrapper
    Private _GeneralOptions As GeneralOptionsWrapper
    Private _DisplayOptions As DisplayOptionsWrapper
    Private _DrawingOption As DrawingOptionsWrapper
    Private _FileOptions As FileOptionsWrapper
    Private _HardwareOptions As HardwareOptionsWrapper
    Private _iFeatureOptions As iFeatureOptionsWrapper
    Private _NotebookOptions As NotebookOptionsWrapper
    Private _PartOptions As PartOptionsWrapper
    Private _SaveOptions As SaveOptionsWrapper
    Private _Sketch3DOptions As Sketch3DOptionsWrapper
    Private _SketchOptions As SketchOptionsWrapper
    'Private _IlogicPathSettings As iLogicPathSettingsWrapper
    'Private _ProjectOptions As ProjectOptionsWrapper

    Public Sub New(ByVal Name As String)

        Me.GetOptions()
        ' code here

    End Sub

    Public Sub GetOptions()
        _CCOptions.GetOptions(g_inventorApplication)
        _GeneralOptions.GetOptions(g_inventorApplication)
        _DisplayOptions.GetOptions(g_inventorApplication)
        _DrawingOption.GetOptions(g_inventorApplication)
        _FileOptions.GetOptions(g_inventorApplication)
        _iFeatureOptions.GetOptions(g_inventorApplication)
        _HardwareOptions.GetOptions(g_inventorApplication)
        _NotebookOptions.GetOptions(g_inventorApplication)
        _PartOptions.GetOptions(g_inventorApplication)
        _SaveOptions.GetOptions(g_inventorApplication)
        _SketchOptions.GetOptions(g_inventorApplication)
        _Sketch3DOptions.GetOptions(g_inventorApplication)

    End Sub

    Public Sub SetOptions()
        _CCOptions.SetOptions(g_inventorApplication)
        _GeneralOptions.SetOptions(g_inventorApplication)
        _DisplayOptions.SetOptions(g_inventorApplication)
        _DrawingOption.SetOptions(g_inventorApplication)
        _FileOptions.SetOptions(g_inventorApplication)
        _iFeatureOptions.SetOptions(g_inventorApplication)
        _HardwareOptions.SetOptions(g_inventorApplication)
        _NotebookOptions.SetOptions(g_inventorApplication)
        _PartOptions.SetOptions(g_inventorApplication)
        _SaveOptions.SetOptions(g_inventorApplication)
        _SketchOptions.SetOptions(g_inventorApplication)
        _Sketch3DOptions.SetOptions(g_inventorApplication)
    End Sub

    Public Function IsDirty() As Boolean

        Return False
    End Function

End Class
