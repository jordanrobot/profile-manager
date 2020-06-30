Imports ProfileManager

Public Class ProfileCollection
    Implements System.Collections.Generic.IDictionary(Of String, Profile)

    Private _profiles As Dictionary(Of String, Profile) = New Dictionary(Of String,Profile)()
    Public CurrentProfile As Profile

    Public Function DefaultName As String
        'get the next available profile name
        Dim _nameRoot As String = "Profile"

        If _profiles.ContainsKey(_nameRoot) = False Then
            Return _nameRoot
        End If

        Dim i As Integer
        For i = 0 to 20
            If _profiles.ContainsKey(_nameRoot & i) = False Then
                Return _nameRoot & i
            End If
        Next

    End Function

    Public Sub Add(name As String, item As Profile) Implements IDictionary(Of String, Profile).Add
        _profiles.Add(name, item)
    End Sub

    Public ReadOnly Property Count As Integer Implements IDictionary(Of String, Profile).Count
        Get
            'Throw New NotImplementedException()
            Count = _profiles.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements IDictionary(Of String, Profile).IsReadOnly
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Default Public Property Item(key As String) As Profile Implements IDictionary(Of String, Profile).Item
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Profile)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property Keys As ICollection(Of String) Implements IDictionary(Of String, Profile).Keys
        Get
            Return _profiles.Keys
            'Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Values As ICollection(Of Profile) Implements IDictionary(Of String, Profile).Values
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub Clear() Implements IDictionary(Of String, Profile).Clear
        _profiles.Clear()
        Throw New NotImplementedException()
    End Sub

    Public Function ContainsKey(key As String) As Boolean Implements IDictionary(Of String, Profile).ContainsKey
        Throw New NotImplementedException()
    End Function

    Public Function Remove(key As String) As Boolean Implements IDictionary(Of String, Profile).Remove
        Throw New NotImplementedException()
    End Function

    Public Function TryGetValue(key As String, ByRef value As Profile) As Boolean Implements IDictionary(Of String, Profile).TryGetValue
        Throw New NotImplementedException()
    End Function

    Public Sub Add(item As KeyValuePair(Of String, Profile)) Implements ICollection(Of KeyValuePair(Of String, Profile)).Add
        Throw New NotImplementedException()
    End Sub

    Public Function Contains(item As KeyValuePair(Of String, Profile)) As Boolean Implements ICollection(Of KeyValuePair(Of String, Profile)).Contains
        Throw New NotImplementedException()
    End Function

    Public Sub CopyTo(array() As KeyValuePair(Of String, Profile), arrayIndex As Integer) Implements ICollection(Of KeyValuePair(Of String, Profile)).CopyTo
        Throw New NotImplementedException()
    End Sub

    Public Function Remove(item As KeyValuePair(Of String, Profile)) As Boolean Implements ICollection(Of KeyValuePair(Of String, Profile)).Remove
        Throw New NotImplementedException()
    End Function

    Public Function GetEnumerator() As IEnumerator(Of KeyValuePair(Of String, Profile)) Implements IEnumerable(Of KeyValuePair(Of String, Profile)).GetEnumerator
        Throw New NotImplementedException()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function

End Class
