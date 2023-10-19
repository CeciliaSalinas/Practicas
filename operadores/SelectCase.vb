Module SelectCase
    Sub Main()
        'programa con operacion matematica básica; entre 2 numeros teneiendo en cuenta la opción del usuario
        'si es 1.suma, 2.resta, 3.multiplica, 4.divide, 5.porcentaje

        Console.Write("Seleccione el número según la operación : 1.Suma, 2.Resta, 3.Multiplicar, 4.Dividir, 5.Porcentaje ")
        Dim numOperacion As Integer = Console.ReadLine()

        Dim numUno As Double
        Dim numDos As Double

        Select Case numOperacion
            Case 1 : Console.Write("Ingrese el primer número : ")
                numUno = Console.ReadLine()
                Console.Write("Ingrese el segundo número : ")
                numDos = Console.ReadLine()

                Console.WriteLine("La suma es : " & numUno + numDos)

            Case 2 : Console.Write("Ingrese el primer número : ")
                numUno = Console.ReadLine()
                Console.Write("Ingrese el segundo número : ")
                numDos = Console.ReadLine()

                Console.WriteLine("La resta es : " & numUno - numDos)

            Case 3 : Console.Write("Ingrese el primer número : ")
                numUno = Console.ReadLine()
                Console.Write("Ingrese el segundo número : ")
                numDos = Console.ReadLine()

                Console.WriteLine("La multiplicación es : " & numUno * numDos)

            Case 4 : Console.Write("Ingrese el primer número : ")
                numUno = Console.ReadLine()
                Console.Write("Ingrese el segundo número : ")
                numDos = Console.ReadLine()

                Console.WriteLine("La división es : " & numUno / numDos)

            Case 5 : Console.Write("Ingrese el primer número : ")
                numUno = Console.ReadLine()
                Console.Write("Ingrese el segundo número : ")
                numDos = Console.ReadLine()

                Console.WriteLine("El porcentaje es : " & numUno * numDos / 100)

            Case Else
                Console.WriteLine("Opción ingresada no válida")
        End Select

    End Sub
End Module
