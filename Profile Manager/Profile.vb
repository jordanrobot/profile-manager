Imports ProfileManager.Wrappers

Public Class ProfileObject

    Public Name As String

    Private _ccLibraries As CcLibraries = New CcLibraries()
    Private _ccOptions As CCOptions = New CCOptions()
    Private _DisplayOptions As DisplayOptions
    Private _DrawingOption As DrawingOptions
    Private _fileOpenOptions As FileOpenOptions
    Private _FileOptions As FileOptions
    Private _GeneralOptions As GeneralOptions
    Private _gripSnapOptions As GripSnapOptions
    Private _HardwareOptions As HardwareOptions
    Private _headsUpDisplayOptions As HeadsUpDisplayOptions
    Private _iFeatureOptions As iFeatureOptions
    Private _notebookOptions As NotebookOptions
    Private _partOptions As PartOptions
    Private _SaveOptions As SaveOptions
    Private _Sketch3DOptions As Sketch3DOptions
    Private _sketchConstraintSettings As SketchConstraintSettings
    Private _SketchOptions As SketchOptions

    'Private _IlogicPathSettings As iLogicPathSettingsWrapper
    'Private _ProjectOptions As ProjectOptionsWrapper

    Public Sub New(ByVal Name As String)

        Me.GetOptions()
        ' code here

    End Sub

    Public Sub GetOptions()
        Dim i As Inventor.Application = g_inventorApplication

        _ccLibraries.GetOptions(i)
        _ccOptions.GetOptions(i)
        _DisplayOptions.GetOptions(i)
        _DrawingOption.GetOptions(i)
        _fileOpenOptions.GetOptions(i)
        _FileOptions.GetOptions(i)
        _GeneralOptions.GetOptions(i)
        _GeneralOptions.GetOptions2(i)
        _gripSnapOptions.GetOptions(i)
        _headsUpDisplayOptions.GetOptions(i)
        _iFeatureOptions.GetOptions(i)
        _HardwareOptions.GetOptions(i)
        _notebookOptions.GetOptions(i)
        _partOptions.GetOptions(i)
        _SaveOptions.GetOptions(i)
        _SketchOptions.GetOptions(i)
        _sketchConstraintSettings.GetOptions(i)
        _Sketch3DOptions.GetOptions(i)
    End Sub

    Public Sub SetOptions()
        Dim i As Inventor.Application = g_inventorApplication

        _ccLibraries.SetOptions(i)
        _ccOptions.SetOptions(i)
        _DisplayOptions.SetOptions(i)
        _DrawingOption.SetOptions(i)
        _fileOpenOptions.SetOptions(i)
        _FileOptions.SetOptions(i)
        _GeneralOptions.SetOptions(i)
        _gripSnapOptions.SetOptions(i)
        _headsUpDisplayOptions.SetOptions(i)
        _iFeatureOptions.SetOptions(i)
        _HardwareOptions.SetOptions(i)
        _notebookOptions.SetOptions(i)
        _partOptions.SetOptions(i)
        _SaveOptions.SetOptions(i)
        _SketchOptions.SetOptions(i)
        _sketchConstraintSettings.SetOptions(i)
        _Sketch3DOptions.SetOptions(i)
    End Sub

    Public Function IsDirty() As Boolean

        Return False
    End Function

End Class
