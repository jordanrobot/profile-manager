Imports System.Windows.Forms
Imports Inventor
Imports ProfileManager.Wrappers

<Serializable()>
Public Class Profile

    Public Name As String

    Private _ccLibraries As CcLibraries = New CcLibraries()
    Private _ccOptions As CCOptions = New CCOptions()
    Private _DisplayOptions As Wrappers.DisplayOptions = New Wrappers.DisplayOptions()
    Private _DrawingOption As Wrappers.DrawingOptions = New Wrappers.DrawingOptions()
    Private _fileOpenOptions As Wrappers.FileOpenOptions = New Wrappers.FileOpenOptions()
    Private _FileOptions As Wrappers.FileOptions = New Wrappers.FileOptions()
    Private _GeneralOptions As Wrappers.GeneralOptions = New Wrappers.GeneralOptions()
    Private _gripSnapOptions As Wrappers.GripSnapOptions = New Wrappers.GripSnapOptions()
    Private _HardwareOptions As Wrappers.HardwareOptions = New Wrappers.HardwareOptions()
    Private _headsUpDisplayOptions As Wrappers.HeadsUpDisplayOptions = New Wrappers.HeadsUpDisplayOptions()
    Private _iFeatureOptions As Wrappers.iFeatureOptions = New Wrappers.iFeatureOptions()
    Private _notebookOptions As Wrappers.NotebookOptions = New Wrappers.NotebookOptions()
    Private _partOptions As Wrappers.PartOptions = New Wrappers.PartOptions()
    Private _SaveOptions As Wrappers.SaveOptions = New Wrappers.SaveOptions()
    Private _Sketch3DOptions As Wrappers.Sketch3DOptions = New Wrappers.Sketch3DOptions()
    Private _sketchConstraintSettings As Wrappers.SketchConstraintSettings = New Wrappers.SketchConstraintSettings()
    Private _SketchOptions As Wrappers.SketchOptions = New Wrappers.SketchOptions()

    'Private _IlogicPathSettings As iLogicPathSettingsWrapper
    'Private _ProjectOptions As ProjectOptionsWrapper

    Public Sub New(ByVal Name As String)

        Me.GetOptions()
        ' code here

    End Sub

    Public Sub New()
'        'Throw New NotImplementedException
        GetOptions()
        Name = DateTimeOffset.UtcNow.Ticks
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
