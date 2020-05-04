Public Class NEnteros
    Dim n As Integer
    Sub Enteros()
        n = 0
    End Sub
    Sub cargar(ByVal n1 As Integer)
        n = n1
    End Sub
    Function descargar()
        Return n
    End Function

End Class
