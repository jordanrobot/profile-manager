﻿Namespace Wrappers
    Public Class Sketch3DOptions

        Private options As New Hashtable

        Public Sub New()

        End Sub

        Public Sub GetOptions(ByRef i As Object)
            options.Clear()

            Me.options.Add("AutoBendWithLineCreation", i.AutoBendWithLineCreation)

        End Sub


        Public Sub SetOptions(ByRef i As Inventor.DisplayOptions)

            'iterate thru keys, set options
            For Each k In Me.options.Keys
                CallByName(i, k, CallType.Let, Me.options(k))
            Next

        End Sub

    End Class
End NameSpace