Imports System.IO
Imports Newtonsoft.Json

Public Class formMain

    private _profileCollection As ProfileCollection = New ProfileCollection()

    Public Sub New()
    
        ' This call is required by the designer.
        InitializeComponent()
    
        ' Add any initialization after the InitializeComponent() call.
        GetProfileCollectionFromDisk

    End Sub

    Private Sub GetProfileCollectionFromDisk()
    End Sub

    Private Sub GetLastSavedProfileFromDisk()
    End Sub

    Private Sub IsProfileDirty()
    End Sub


    Private Sub RefreshListBox()
        lboxProfiles.Items.Clear()
        lboxProfiles.Items.AddRange(_profileCollection.Keys.ToArray())
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newProfile As Profile = New Profile(_profileCollection.DefaultName)
        _profileCollection.Add(newProfile.Name, newProfile)
        _profileCollection.CurrentProfile = newProfile

        RefreshListBox
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click 
        SerializeToJSON(_profileCollection.CurrentProfile)
        'SerializeToXML(_profileCollection.CurrentProfile)
    End Sub

    Private Sub SerializeToXML(ByRef profile As Profile)
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(profile))  
        Dim file As New System.IO.StreamWriter(  
            "C:\Users\mjordan\Desktop\temp\SerializationTest.xml")  
        writer.Serialize(file, profile)  
        file.Close()
    End Sub
    
    Private Sub SerializeToJSON(ByRef profile As Profile)
        Dim serializer As JsonSerializer = new JsonSerializer()

        serializer.NullValueHandling = NullValueHandling.Ignore

        Dim sw As StreamWriter = New StreamWriter("C:\Users\mjordan\Desktop\temp\SerializationTest.Json")

        Dim writer As JsonWriter = New JsonTextWriter(sw)
        serializer.Serialize(writer, profile)
        writer.Close()
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        '_profileCollection(lboxProfiles.SelectedItem.ToString()).SetOptions()
    End Sub
End Class