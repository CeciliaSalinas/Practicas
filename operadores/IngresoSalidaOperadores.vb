Module IngresoSalidaOperadores
    Sub Main()
        'Realizar un programa que muestre por consola si un estudiante con el dinero que tiene ahorrado
        'puede pagar la universidad y estudiar. el semestre tiene un valor de 60000

        Dim estudia As Boolean = False

        Console.Write("Ingrese el importe de su dinero ->")
        Dim dineroAhorrado As Double = Console.ReadLine()

        If dineroAhorrado >= 60000 Then
            estudia = True
        End If

        If estudia = True Then
            Console.WriteLine("Con tus ahorros podes pagar el semestre!")
        Else
            Console.WriteLine("Deberás ahorrar un poco mas!")
        End If

    End Sub
End Module
