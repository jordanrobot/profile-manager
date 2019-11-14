Imports ProfileManager

Public Class ProfileCollection
    Implements System.Collections.Generic.ICollection(Of ProfileObject)

    Private _profileList As List(Of ProfileObject)

    Public ReadOnly Property Count As Integer Implements ICollection(Of ProfileObject).Count
        Get
            'Throw New NotImplementedException()
            Count = _profileList.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of ProfileObject).IsReadOnly
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub Add(item As ProfileObject) Implements ICollection(Of ProfileObject).Add
        'Throw New NotImplementedException()
        _profileList.Add(item)
    End Sub

    Public Sub Clear() Implements ICollection(Of ProfileObject).Clear
        '       _profileList.Clear()
        Throw New NotImplementedException()
    End Sub

    Public Sub CopyTo(array() As ProfileObject, arrayIndex As Integer) Implements ICollection(Of ProfileObject).CopyTo
        Throw New NotImplementedException()
    End Sub

    Public Function Contains(item As ProfileObject) As Boolean Implements ICollection(Of ProfileObject).Contains
        'Throw New NotImplementedException()
        Return _profileList.Contains(item)
    End Function

    Public Function Remove(item As ProfileObject) As Boolean Implements ICollection(Of ProfileObject).Remove
        'Throw New NotImplementedException()
        _profileList.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of ProfileObject) Implements IEnumerable(Of ProfileObject).GetEnumerator
        'Throw New NotImplementedException()
        _profileList.GetEnumerator()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function
End Class
