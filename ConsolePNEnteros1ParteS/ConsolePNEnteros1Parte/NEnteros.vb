﻿Public Class NEnteros
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
    '------------------------------------------------------------------------------------------
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
    '---------------------------------------------------------------------------------------------
    '2. Verificar si un NE. Pertenece a la sucesión regular (Serie regular)
    'Vi=7, r=3 Serie: 7,10,13,16,19,…. La Fórmula de la serie regular: t=vi+(i-1)*r
    'Dónde: Vi:Valor inicial; r:Razon; i:sucesión progresiva estándar 1,2,3,4,5… y t:termino.
    'Ejemplo: N=16 y Vi=7, r=3 => true N=15 y Vi=7;r=3 =>false
    '---------------------------------------------------------------------------------------------
    '3. Accesar dígitos (de nd: # de dígitos) en sentido izquierda a derecha en una cadena/string.
    'Ejemplos: N=123456 y ND=1 => S=”1,2,3,4,5,6,”
    'N=123456 y ND=2 => S=”12,34,56”
    '---------------------------------------------------------------------------------------------
    '4. Filtrar (dejar pasar) dígitos impares de un NE de a nd dígitos, el resultado en un string.
    '---------------------------------------------------------------------------------------------
    '5. Filtrar (dejar pasar) dígitos primos de un NE de a nd dígitos, el resultado en un string:
    'Ejemplos: N=113417 y ND=2 => s=”17,11,”
    '---------------------------------------------------------------------------------------------
    '6. Acumular con dígitos de Fibonacci:
    'Ejemplo N = 1234567 >= F = 1 / 5.0! – 1/3! + 1/2! - 1/1!
    '---------------------------------------------------------------------------------------------
    '7. Convertir un NE ( se supone en base 10) a base B. (2<=B>=9).
    'Ejemplo: N=21 a B=2 => R=10101
    'Ejemplo: N=36 a B=7 => R=51
    'Aplicar la procedimiento de conversión.

    '---------------------------------------------------------------------------------------------
    '    8. Con dígitos primos de nd dígitos, acumular: (Ver el ejercicio N° 4 como ayuda)
    'Ejemplos: N=1234567 y ND=1 => F=√72+ √54+ √36
    'N=132217 y ND=2 => F=√172+ √13
    '---------------------------------------------------------------------------------------------
    '9.    Encontrar el digito mayor de ND dígitos
    'Ejemplo: N=28371 y ND=1 => R=8
    'N=125423 y ND=2 => R=54

    '---------------------------------------------------------------------------------------------
    '    10. Encontrar la frecuencia de DIG de a nd dígitos de un NE.
    'Ejemplo. N=2462482 y nd=1 y DIG=2 => r=3
    'Ejemplo N = 335733 y nd=2 y DIG 33 => r=2

End Class
