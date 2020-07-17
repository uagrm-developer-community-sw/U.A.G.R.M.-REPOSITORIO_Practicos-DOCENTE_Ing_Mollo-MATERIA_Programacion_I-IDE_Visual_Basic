Public Class NEnteros
    Dim n As Integer
    Public Sub NEnteros()
        n = 0  
    End Sub
    Public Sub cargar(ByVal num As Integer)
        n = num
    End Sub
    Public Function descargar()
        Return n
    End Function

    '------------------------------------------------------------------------------------------
    'HERRAMIENTAS

    'VERIFICAR SI ES FIBONACCI
    Public Function verif_fibonacci(num As Integer) As Boolean
        Dim a, b, c, m As Integer
        Dim b1 As Boolean
        m = num
        a = -1
        b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until (c >= m)
        If c = m Then
            b1 = True
        Else
            b1 = False
        End If
        Return b1
    End Function

    'FILTRAR DIGITOS FIBONACCI
    Public Function filtrar_digitos_fibo(num As Integer) As Integer
        Dim a, f As Integer
        f = 0
        While num > 0
            a = num Mod 10 : num = num \ 10
            If verif_fibonacci(a) = True Then
                f = f * 10 + a
            End If
        End While
        Return f
    End Function

    'CONTAR DIGITOS
    Public Function contar_digitos(ByVal num As Integer) As Integer
        Dim c, aux As Integer
        c = 0 : aux = num
        While aux > 0
            c += 1 : aux = aux \ 10
        End While
        Return c
    End Function

    'FILTRAR DIGITOS PARES
    Public Function filtrar_digito_par(ByVal num As Integer)
        Dim e, d, aux As Integer
        Dim f As Integer
        f = 0 : aux = num
        While aux > 0
            d = aux Mod 10 : aux = aux \ 10
            e = d Mod 2
            If e = 0 Then
                f = f * 10 + d
            End If
        End While
        Return f
    End Function

    'FILTRAR DIGITOS IMPARES
    Public Function filtrar_digito_inpar(ByVal num As Integer)
        Dim d, e, aux As Integer
        Dim f As Integer
        f = 0 : aux = num
        While aux > 0
            d = aux Mod 10 : aux = aux \ 10
            e = d Mod 2
            If e = 0 Then
            Else
                f = f * 10 + d
            End If
        End While
        Return f
    End Function

    'VERIFICAR SI ES DIGITO PAR
    Public Function verificar_digito_par(num As Integer) As Boolean
        Dim b As Boolean
        If num Mod 2 = 0 Then
            b = True
        Else
            b = False
        End If
        Return b
    End Function

    'VERIFICAR SI ES DIGITO IMPAR
    Public Function verificar_digito_impar(num As Integer) As Boolean
        Dim b As Boolean
        If num Mod 2 = 1 Then
            b = True
        Else
            b = False
        End If
        Return b
    End Function

    'INVERTIR DIGITOS
    Public Function invertir_digitos(ByVal num As Integer)
        Dim d, aux As Integer
        Dim f As Integer
        f = 0 : aux = num
        While aux > 0
            d = aux Mod 10 : aux = aux \ 10
            f = f * 10 + d
        End While
        Return f
    End Function

    'INSERTAR COMA DEACUERDO A LA POSICION
    Public Function insertar_coma_numero_digitos(ByVal num As Integer, ByVal nd As Integer) As String
        Dim aux, A, S, c As Integer
        Dim str As String
        Dim d As Integer
        str = " "
        aux = num : c = 0 : S = 0
        aux = invertir_digitos(aux)
        If (nd > 0) And (nd <= contar_digitos(aux)) Then
            While aux > 0
                d = aux Mod 10
                c = c + 1
                If c <= nd Then
                    S = (S * 10) + d
                    aux = aux \ 10
                Else
                    str = str + CStr(S) + ","
                    S = 0
                    c = 0
                End If
            End While
            If S > 0 Then
                str = str + CStr(S)
            End If
            Return str
        Else
            Console.WriteLine("La cantidad de Digitos tiene que mayor ND")
        End If
    End Function

    'FILTRAR POR MEDIO POSICION EN LOS NUMEROS PRIMOS
    Public Function filtrar_nd_primos(ByVal num As Integer, ByVal nd As Integer) As Integer
        Dim aux, A, S, c, f As Integer
        Dim d As Integer
        aux = num : c = 0 : S = 0 : f = 0 : A = 1
        If (nd > 0) And (nd <= contar_digitos(aux)) Then
            While aux > 0
                d = aux Mod 10
                c = c + 1
                If c <= nd Then
                    S = (S * 10) + d
                    A = A * 10
                    aux = aux \ 10
                Else
                    S = invertir_digitos(S)
                    If verificar_digito_primo(S) = True Then
                        f = S + (f * A)
                    End If
                    S = 0
                    c = 0
                    A = 1
                End If
            End While
            If contar_digitos(S) = nd And verificar_digito_primo(S) = True Then
                f = S + (f * A)
            End If
            Return f
        Else
            Console.WriteLine("La cantidad de Digitos tiene que mayor ND")
        End If
    End Function

    'FILTRAR ND POR MEDIO DE LA POSICION EN LOS DIGITOS IMPARES
    Public Function filtrar_nd_impar(ByVal num As Integer, ByVal nd As Integer) As Integer
        Dim aux, A, S, c, f As Integer
        Dim d As Integer
        aux = num : c = 0 : S = 0 : f = 0 : A = 1
        If (nd > 0) And (nd <= contar_digitos(aux)) Then
            While aux > 0
                d = aux Mod 10
                c = c + 1
                If c <= nd Then
                    S = (S * 10) + d
                    A = A * 10
                    aux = aux \ 10
                Else
                    S = invertir_digitos(S)
                    If verificar_digito_impar(S) = True Then
                        f = S + (f * A)
                    End If
                    S = 0
                    c = 0
                    A = 1
                End If
            End While
            If contar_digitos(S) = nd And verificar_digito_impar(S) = True Then
                f = S + (f * A)
            End If
            Return f
        Else
            Console.WriteLine("La cantidad de Digitos tiene que mayor ND")
        End If
    End Function

    'VERIFICAR SI ES DIGITO PRIMO
    Public Function verificar_digito_primo(ByVal n1 As Integer) As Boolean
        Dim a As Integer = 0
        Dim num As Integer
        Dim b As Boolean
        num = n1
        For i As Integer = 1 To num + 1
            If (num Mod i = 0) Then
                a = a + 1
            End If
        Next i
        If (a <> 2) Then
            b = False
        Else
            b = True
        End If
        Return b
    End Function

    'FILTRAR DIGITOS PRIMOS
    Public Function filtrar_digitos_primos(ByVal num As Integer) As Integer
        Dim n1, m, d As Integer
        n1 = num
        m = 0
        While n1 > 0
            d = n1 Mod 10
            n1 = n1 \ 10
            If verificar_digito_primo(d) = True Then
                m = (m * 10) + d
            End If
        End While
        Return m
    End Function

    'ACUMULAR DIGITOS FIBONACCI
    Public Function acumular_digitos_fibo(num As Integer) As String
        Dim a, b As Integer
        Dim s As String
        Dim ba As Boolean = True
        s = " "
        a = filtrar_digitos_fibo(num)
        a = invertir_digitos(a)
        While a > 0
            b = a Mod 10 : a = a \ 10
            If ba = True Then
                s = s + "1/" + CStr(b) + "!" + "-"
                ba = False
            Else
                s = s + "1/" + CStr(b) + "!" + "+"
                ba = True
            End If
        End While
        Return s
    End Function

    'DIGITOS PRIMOS ACUMULATIVOS CON ND EN RAIZ
    Public Function digitos_primos_nd_acumular(ByVal num As Integer, ByVal nd As Integer) As String
        Dim aux, S, c, t As Integer
        Dim str As String
        Dim d As Integer
        str = " "
        aux = num : c = 0 : S = 0 : t = 1
        'aux = invertir_digitos(aux)
        If (nd > 0) And (nd <= contar_digitos(aux)) Then
            While aux > 0
                d = aux Mod 10
                c = c + 1
                If c <= nd Then
                    S = (S * 10) + d
                    aux = aux \ 10
                Else
                    S = invertir_digitos(S)
                    If verificar_digito_primo(S) = True Then
                        t = t * 2
                        str = str + CStr(t) + "√" + CStr(S) + " + "
                    End If
                    S = 0
                    c = 0
                End If
            End While
            S = invertir_digitos(S)
            If S > 0 And verificar_digito_primo(S) = True Then
                t = t * 2
                str = str + CStr(t) + "√" + CStr(S)
            End If
            Return str
        Else
            Console.WriteLine("La cantidad de Digitos tiene que mayor ND")
        End If
    End Function

    'OBTENER_DIGITO_MAYOR POR MEDIO ND'
    Public Function obtener_el_digito_mayor_nd(ByVal num As Integer, ByVal nd As Integer) As Integer
        Dim aux, e, c, mult As Integer
        Dim d As Integer
        aux = num : c = 1 : mult = 1
        While c <= nd
            mult = mult * 10
            c = c + 1
        End While
        d = aux Mod mult : aux = aux \ mult
        While aux > 0
            e = aux Mod mult : aux = aux \ mult
            If e > d Then
                d = e
            End If
        End While
        Return d
    End Function

    'ENCONTRAR LA FRECUENCIA DE UN DIGITO DE FORMA ND
    Public Function encontrar_la_frecuencia_digito_forma_nd(ByVal num As Integer, ByVal nd As Integer, dig As Integer) As Integer
        Dim aux, c, p, mult As Integer
        Dim d As Integer
        aux = num : c = 0 : mult = 1 : p = 1
        While p <= nd
            mult = mult * 10
            p = p + 1
        End While
        While aux > 0
            d = aux Mod mult : aux = aux \ mult
            If d = dig Then
                c += 1
            End If
        End While
        Return c
    End Function

    'CONVERSION DE DECIMAL A CUALQUIER BASE DE 2 .. 9
    Public Function DecToBase9(ByVal DecNum As Integer, ByVal b As Integer) As String
        Dim num, d, e, f As Integer
        num = DecNum
        f = 0
        e = num
        If num >= b And b >= 2 And b <= 9 Then
            While e >= b
                d = num Mod b : e = num \ b
                num = e
                f = f * 10 + d
            End While
            If e > 0 Then
                f = f * 10 + e
            End If
            f = invertir_digitos(f)
        Else
            f = CStr(0)
        End If
        Return CStr(f)
    End Function

    'SERIE REGULAR
    Public Function Serie_Regular(num As Integer, vi As Integer, r As Integer) As Boolean
        Dim t, i, c, max As Integer
        Dim b As Boolean
        i = 1
        max = num
        b = False
        While i <= max
            t = vi + (i - 1) * r
            max = t
            i = i + 1
            If t = num Then
                b = True
                i = max + 1
            End If
        End While
        Return b
    End Function

    '------------------------------------------------------------------------------------------
    'PRACTICOS

    '1. Verificar si un NE pertenece a la serie de Fibonacci.
    '    Ejemplo: N=13 => true o N=15=> false Fibonacci: 0,1,1,2,3,5,8,13,21,34,…
    Public Function ejercicio1() As Boolean
        Dim num As Integer
        Dim b As Boolean
        num = n
        b = verif_fibonacci(num)
        Return b
    End Function
    '---------------------------------------------------------------------------------------------
    '2. Verificar si un NE. Pertenece a la sucesión regular (Serie regular)
    'Vi=7, r=3 Serie: 7,10,13,16,19,…. La Fórmula de la serie regular: t=vi+(i-1)*r
    'Dónde: Vi:Valor inicial; r:Razon; i:sucesión progresiva estándar 1,2,3,4,5… y t:termino.
    'Ejemplo: N=16 y Vi=7, r=3 => true N=15 y Vi=7;r=3 =>false
    Public Function ejercicio2(vi As Integer, r As Integer) As Boolean
        Dim num As Integer
        Dim b As Boolean
        num = n
        b = Serie_Regular(num, vi, r)
        Return b
    End Function
    '---------------------------------------------------------------------------------------------
    '3. Accesar dígitos (de nd: # de dígitos) en sentido izquierda a derecha en una cadena/string.
    'Ejemplos: N=123456 y ND=1 => S=”1,2,3,4,5,6,”
    'N=123456 y ND=2 => S=”12,34,56”
    Public Function ejercicio3(ByVal nd As Integer) As String
        Dim num As String
        Dim s As String
        num = n
        s = insertar_coma_numero_digitos(num, nd)
        Return s
    End Function
    '---------------------------------------------------------------------------------------------
    '4. Filtrar (dejar pasar) dígitos impares de un NE de a nd dígitos, el resultado en un string.
    Public Function ejercicio4(ByVal nd As Integer) As String
        Dim num, f As String
        Dim s As String
        num = n
        f = filtrar_nd_impar(num, nd)
        s = insertar_coma_numero_digitos(f, nd)
        Return s
    End Function
    '---------------------------------------------------------------------------------------------
    '5. Filtrar (dejar pasar) dígitos primos de un NE de a nd dígitos, el resultado en un string:
    'Ejemplos: N=113417 y ND=2 => s=”17,11,”
    Public Function ejercicio5(ByVal nd As Integer) As String
        Dim num, f As String
        Dim s As String
        num = n
        f = filtrar_nd_primos(num, nd)
        s = insertar_coma_numero_digitos(f, nd)
        Return s
    End Function
    '---------------------------------------------------------------------------------------------
    '6. Acumular con dígitos de Fibonacci:
    'Ejemplo N = 1234567 >= F = 1 / 5.0! – 1/3! + 1/2! - 1/1!
    Public Function ejercicio6() As String
        Dim s As String
        Dim num As Integer
        num = n
        s = acumular_digitos_fibo(num)
        Return s
    End Function
    '---------------------------------------------------------------------------------------------
    '7. Convertir un NE ( se supone en base 10) a base B. (2<=B>=9).
    'Ejemplo: N=21 a B=2 => R=10101
    'Ejemplo: N=36 a B=7 => R=51
    'Aplicar la procedimiento de conversión.
    Public Function ejercicio7(b As Integer) As String
        Dim f As String
        Dim num As Integer
        num = n
        f = DecToBase9(num, b)
        Return f
    End Function
    '---------------------------------------------------------------------------------------------
    '8. Con dígitos primos de nd dígitos, acumular: (Ver el ejercicio N° 4 como ayuda)
    'Ejemplos: N=1234567 y ND=1 => F=√72+ √54+ √36
    'N=132217 y ND=2 => F=√172+ √13
    Public Function ejercicio8(nd As Integer) As String
        Dim num As Integer
        Dim s As String
        num = n
        s = digitos_primos_nd_acumular(num, nd)
        Return s
    End Function
    '---------------------------------------------------------------------------------------------
    '9. Encontrar el digito mayor de ND dígitos
    'Ejemplo: N=28371 y ND=1 => R=8
    'N=125423 y ND=2 => R=54
    Public Function ejercicio9(nd As Integer) As Integer
        Dim f, num As Integer
        num = n
        f = obtener_el_digito_mayor_nd(num, nd)
        Return f
    End Function
    '---------------------------------------------------------------------------------------------
    '10. Encontrar la frecuencia de DIG de a nd dígitos de un NE.
    'Ejemplo. N=2462482 y nd=1 y DIG=2 => r=3
    'Ejemplo N = 335733 y nd=2 y DIG 33 => r=2
    Public Function ejercicio10(nd As Integer, dig As Integer) As Integer
        Dim f, num As Integer
        num = n
        f = encontrar_la_frecuencia_digito_forma_nd(num, nd, dig)
        Return f
    End Function
End Class
