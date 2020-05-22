Imports ProfileManager.Wrappers

Public Class ProfileObject

    Public Name As String

    Private _CCOptions As CCOptions
    Private _GeneralOptions As GeneralOptions
    Private _DisplayOptions As DisplayOptions
    Private _DrawingOption As DrawingOptions
    Private _FileOptions As FileOptions
    Private _HardwareOptions As HardwareOptions
    Private _iFeatureOptions As iFeatureOptions
    Private _NotebookOptions As NotebookOptions
    Private _PartOptions As PartOptions
    Private _SaveOptions As SaveOptions
    Private _Sketch3DOptions As Sketch3DOptions
    Private _SketchOptions As SketchOptions
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
