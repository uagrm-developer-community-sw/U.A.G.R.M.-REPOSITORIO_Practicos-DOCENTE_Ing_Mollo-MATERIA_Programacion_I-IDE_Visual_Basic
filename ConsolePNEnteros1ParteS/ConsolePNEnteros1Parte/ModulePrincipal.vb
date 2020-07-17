
Module ModulePrincipal
    Dim instacia As NEnteros = New NEnteros


    Sub Main()

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("=============================================")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("                 U.A.G.R.M.")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("               PROGRAMACION I")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("        PRACTICO DE NUMEROS ENTEROS")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                 1RA PARTE")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" =============================================")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine(" DOCENTE: Ing. Mollo")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("")
        Console.WriteLine(" REALIZAR OPERACIONES PARA LA CLASE NUMEROS ENTEROS:")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("---------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine(" ELIJA LA OPCION:")
        Console.WriteLine("")

        Console.WriteLine(" [1] - Verificar si un NE pertenece a la serie de Fibonacci")
        Console.WriteLine(" [2] - Verificar si un NE. Pertenece a la sucesión regular (Serie regular)")
        Console.WriteLine(" [3] - Accesar dígitos (de nd: # de dígitos) en sentido izquierda a derecha en una cadena/string")
        Console.WriteLine(" [4] - Filtrar (dejar pasar) dígitos impares de un NE de a nd dígitos, el resultado en un string")
        Console.WriteLine(" [5] - Filtrar (dejar pasar) dígitos primos de un NE de a nd dígitos, el resultado en un string")
        Console.WriteLine(" [6] - Acumular con dígitos de Fibonacci")
        Console.WriteLine(" [7] - Convertir un NE ( se supone en base 10) a base B (2<=B>=9)")
        Console.WriteLine(" [8] - Con dígitos primos de nd dígitos, acumular: (Ver el ejercicio N° 4 como ayuda)")
        Console.WriteLine(" [9] - Encontrar el digito mayor de ND dígitos")
        Console.WriteLine(" [10] - Encontrar la frecuencia de DIG de a nd dígitos de un NE")
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("")

        Dim opcion As String
        Console.Write("INGRESE LA OPCION: ")
        opcion = Console.ReadLine()
        Console.ResetColor()
        Console.WriteLine("")

        Dim n, nd, entero, dig, bp, vi, r As Integer
        Dim s As String

        Select Case opcion
            Case "1"
                Dim m, p As Integer
                Dim b As Boolean
                Console.WriteLine("acceso 1")
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.Write("INGRESE EL VALOR: ")

                Console.Write("")
                n = Console.Readline()
                instacia.cargar(n)
                Console.WriteLine("")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("---------------------------------------------------")
                Console.ForegroundColor = ConsoleColor.Magenta
                If (b = instacia.ejercicio1() = True) Then
                    Console.WriteLine("RESULTADO ES: -> TRUE")
                Else
                    Console.WriteLine("RESULTADO ES: -> FALSE")
                End If
            Case "2"
                Console.WriteLine("acceso 2")
                Console.Write("INGRESE EL VALOR N: ")
                n = Console.ReadLine()
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR VI: ")
                vi = CInt(Console.ReadLine())
                Console.Write("INGRESE EL VALOR R: ")
                r = CInt(Console.ReadLine())
                Console.WriteLine("")
                Console.ForegroundColor = ConsoleColor.Magenta
                If (instacia.ejercicio2(vi, r) = True) Then
                    Console.WriteLine("RESULTADO ES: -> TRUE")
                Else
                    Console.WriteLine("RESULTADO ES: -> FALSE")
                End If
            Case "3"
                Console.WriteLine("acceso 3")
                Console.Write("INGRESE EL VALOR N: ")
                n = CInt(Console.ReadLine())
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR ND: ")
                nd = CInt(Console.ReadLine())
                s = instacia.ejercicio3(nd)
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + s)
            Case "4"
                Console.WriteLine("acceso 4")
                s = " "
                Console.Write("INGRESE EL VALOR N: ")
                n = CInt(Console.ReadLine())
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR ND: ")
                nd = CInt(Console.ReadLine())
                s = instacia.ejercicio4(nd)
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + s)
            Case "5"
                Console.WriteLine("acceso 5")
                s = " "
                Console.Write("INGRESE EL VALOR N: ")
                n = CInt(Console.ReadLine())
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR ND: ")
                nd = CInt(Console.ReadLine())
                s = instacia.ejercicio5(nd)
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + s)
            Case "6"
                Console.WriteLine("acceso 6")
                n = Console.ReadLine()
                instacia.cargar(n)
                s = instacia.ejercicio6()
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + s)
            Case "7"
                Console.WriteLine("acceso 7")
                Console.Write("INGRESE EL VALOR N: ")
                n = Console.ReadLine()
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR EN BASE B: ")
                bp = Console.ReadLine()

                If (instacia.ejercicio7(bp) <> "0") Then
                    Console.WriteLine("")
                    s = instacia.ejercicio7(bp)
                    Console.WriteLine("RESULTADO: -> " + s)
                Else
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("---------------------------------------------------")
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine("")
                    Console.Write("El Numero ingresado tiene que ser mayor o igual a la Base y la Base mayor igual a 2 y menor igual 9")
                    Console.WriteLine("")
                End If
            Case "8"
                Console.WriteLine("acceso 8")
                Console.Write("INGRESE EL VALOR N: ")
                n = Console.ReadLine()
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR ND: ")
                nd = CInt(Console.ReadLine())
                s = instacia.ejercicio8(nd)
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + s)
            Case "9"
                Console.WriteLine("acceso 9")
                Console.Write("INGRESE EL VALOR N: ")
                n = Console.ReadLine()
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR ND: ")
                nd = CInt(Console.ReadLine())
                entero = instacia.ejercicio9(nd)
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + CStr(entero))
            Case "10"
                Console.WriteLine("acceso 10")
                Console.Write("INGRESE EL VALOR N: ")
                n = Console.ReadLine()
                instacia.cargar(n)
                Console.Write("INGRESE EL VALOR ND: ")
                nd = CInt(Console.ReadLine())
                Console.Write("INGRESE EL VALOR DIG: ")
                dig = CInt(Console.ReadLine())
                entero = instacia.ejercicio10(nd, dig)
                Console.WriteLine("")
                Console.WriteLine("RESULTADO: -> " + CStr(entero))
            Case Else
                Console.WriteLine("POR FAVOR ELIJA LA OPCION CORRECTA!!")
        End Select
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("")
        Console.Write("PRESIONE ENTER DOS VECES PARA SALIR..!")
        Console.ReadLine()
    End Sub

End Module
