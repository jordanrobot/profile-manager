Imports Inventor

Public Class formMain

    'Public profileList As ProfileCollection = New ProfileCollection()

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim currentProfile As Profile = New Profile("test")

        WriteProfileToXML(currentProfile)

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

    End Sub

    Private Sub WriteProfileToXML(ByRef profile As Profile)
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Profile))  
        Dim file As New System.IO.StreamWriter(  
            "C:\Users\mjordan\Desktop\temp\SerializationTest.xml")  
        writer.Serialize(file, profile)  
        file.Close()
    End Sub

End Class
