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
    '------------------------------------------------------------
    '1. Verificar si un NE pertenece a la serie de Fibonacci.
    '    Ejemplo: N=13 => true o N=15=> false Fibonacci: 0,1,1,2,3,5,8,13,21,34,…
    Function ID_Fib()
        Dim c, a, b As Integer
        Dim be As Boolean
        c = 0
        a = -1
        b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until c = n Or c > n
        If c = n Then
            be = True
        Else
            be = False
        End If
        Return be
    End Function
    '-------------------------------------------------------------
    '2. Verificar si un NE. Pertenece a la sucesión regular (Serie regular)
    'Vi=7, r=3 Serie: 7,10,13,16,19,…. La Fórmula de la serie regular: t=vi+(i-1)*r
    'Dónde: Vi:Valor inicial; r:Razon; i:sucesión progresiva estándar 1,2,3,4,5… y t:termino.
    'Ejemplo: N=16 y Vi=7, r=3 => true N=15 y Vi=7;r=3 =>false

    '3. Accesar dígitos (de nd: # de dígitos) en sentido izquierda a derecha en una cadena/string.
    'Ejemplos: N=123456 y ND=1 => S=”1,2,3,4,5,6,”
    'N=123456 y ND=2 => S=”12,34,56”
End Class
