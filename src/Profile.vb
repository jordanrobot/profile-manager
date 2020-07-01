Imports System.Windows.Forms
Imports Inventor
Imports ProfileManager.Wrappers

<Serializable()>
Public Class Profile

    Public Name As String = New String("")

    Public _ccLibraries As CcLibraries = New CcLibraries()
    Public _ccOptions As CCOptions = New CCOptions()
    Public _DisplayOptions As Wrappers.DisplayOptions = New Wrappers.DisplayOptions()
    Public _DrawingOption As Wrappers.DrawingOptions = New Wrappers.DrawingOptions()
    Public _fileOpenOptions As Wrappers.FileOpenOptions = New Wrappers.FileOpenOptions()
    Public _FileOptions As Wrappers.FileOptions = New Wrappers.FileOptions()
    Public _GeneralOptions As Wrappers.GeneralOptions = New Wrappers.GeneralOptions()
    Public _gripSnapOptions As Wrappers.GripSnapOptions = New Wrappers.GripSnapOptions()
    Public _HardwareOptions As Wrappers.HardwareOptions = New Wrappers.HardwareOptions()
    Public _headsUpDisplayOptions As Wrappers.HeadsUpDisplayOptions = New Wrappers.HeadsUpDisplayOptions()
    Public _iFeatureOptions As Wrappers.iFeatureOptions = New Wrappers.iFeatureOptions()
    Public _notebookOptions As Wrappers.NotebookOptions = New Wrappers.NotebookOptions()
    Public _partOptions As Wrappers.PartOptions = New Wrappers.PartOptions()
    Public _SaveOptions As Wrappers.SaveOptions = New Wrappers.SaveOptions()
    Public _Sketch3DOptions As Wrappers.Sketch3DOptions = New Wrappers.Sketch3DOptions()
    Public _sketchConstraintSettings As Wrappers.SketchConstraintSettings = New Wrappers.SketchConstraintSettings()
    Public _SketchOptions As Wrappers.SketchOptions = New Wrappers.SketchOptions()

    'Private _IlogicPathSettings As iLogicPathSettingsWrapper
    'Private _ProjectOptions As ProjectOptionsWrapper

    Public Sub New(ByVal _name As String)

        Name = _name
        GetOptions()
        ' code here

    End Sub

    Public Sub New()
'        'Throw New NotImplementedException
        GetOptions()
        Name = DateTimeOffset.UtcNow.Ticks.ToString
    End Sub

    Public Sub GetOptions()
        Dim i As Inventor.Application
        'Try
            i = g_inventorApplication
        'Catch ex As SystemException
        '    MessageBox.Show("The inventor application object was not found.  Error in Profile.GetOptions subroutine.")
        'End Try
        'Try
            _ccLibraries.GetOptions(i.ContentCenterOptions)
            _ccOptions.GetOptions(i.ContentCenterOptions)
            _DisplayOptions.GetOptions(i.DisplayOptions)
            _DrawingOption.GetOptions(i.DrawingOptions)
            _fileOpenOptions.GetOptions(i.FileOptions.FileOpenOptions)
            _FileOptions.GetOptions(i.FileOptions)
            _GeneralOptions.GetOptions(i.GeneralOptions)
            _GeneralOptions.GetOptions2(i)
            _gripSnapOptions.GetOptions(i.GeneralOptions.GripSnapOptions)
            '_headsUpDisplayOptions.GetOptions(i.HeadsUpDisplayOptions)
            _iFeatureOptions.GetOptions(i.iFeatureOptions)
            _HardwareOptions.GetOptions(i.HardwareOptions)
            _notebookOptions.GetOptions(i.NotebookOptions)
            _partOptions.GetOptions(i.PartOptions)
            _SaveOptions.GetOptions(i.SaveOptions)
            _SketchOptions.GetOptions(i.SketchOptions)
            _sketchConstraintSettings.GetOptions(i.SketchOptions.SketchConstraintSettings)
            _Sketch3DOptions.GetOptions(i.Sketch3DOptions)
        'Catch ex As SystemException
        '    MessageBox.Show("The GetOptions routine was interrupted.  Not all options could be retreived.")
        'End Try
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
