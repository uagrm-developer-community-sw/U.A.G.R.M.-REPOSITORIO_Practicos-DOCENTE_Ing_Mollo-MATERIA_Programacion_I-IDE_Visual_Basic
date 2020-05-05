
Module ModulePrincipal

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
        Console.Write(" INGRESE LA OPCION: ")
        opcion = Console.ReadLine()
        Console.ResetColor()

        Select Case opcion
            Case "1"
                Console.WriteLine("acceso 1")
            Case "2"
                Console.WriteLine("acceso 2")
            Case "3"
                Console.WriteLine("acceso 3")
            Case "4"
                Console.WriteLine("acceso 4")
            Case "5"
                Console.WriteLine("acceso 5")
            Case "6"
                Console.WriteLine("acceso 6")
            Case "7"
                Console.WriteLine("acceso 7")
            Case "8"
                Console.WriteLine("acceso 8")
            Case "9"
                Console.WriteLine("acceso 9")
            Case "10"
                Console.WriteLine("acceso 10")
            Case Else
                Console.WriteLine("acceso fail")

        End Select
        Console.ReadLine()
    End Sub

End Module
