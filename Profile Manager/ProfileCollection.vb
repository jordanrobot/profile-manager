Imports ProfileManager

Public Class ProfileCollection
    Implements System.Collections.Generic.ICollection(Of Profile)

    Private _profileList As List(Of Profile)

    Public ReadOnly Property Count As Integer Implements ICollection(Of Profile).Count
        Get
            'Throw New NotImplementedException()
            Count = _profileList.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of Profile).IsReadOnly
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub Add(item As Profile) Implements ICollection(Of Profile).Add
        'Throw New NotImplementedException()
        _profileList.Add(item)
    End Sub

    Public Sub Clear() Implements ICollection(Of Profile).Clear
        '       _profileList.Clear()
        Throw New NotImplementedException()
    End Sub

    Public Sub CopyTo(array() As Profile, arrayIndex As Integer) Implements ICollection(Of Profile).CopyTo
        Throw New NotImplementedException()
    End Sub

    Public Function Contains(item As Profile) As Boolean Implements ICollection(Of Profile).Contains
        'Throw New NotImplementedException()
        Return _profileList.Contains(item)
    End Function

    Public Function Remove(item As Profile) As Boolean Implements ICollection(Of Profile).Remove
        'Throw New NotImplementedException()
        _profileList.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of Profile) Implements IEnumerable(Of Profile).GetEnumerator
        'Throw New NotImplementedException()
        _profileList.GetEnumerator()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function

End Class
