Module IngresoSalidaDatos

    Sub Main()

        Console.Write("Ingrese su nombre ->")
        'Dim miNombre As String = "Antonia"

        'readLine permite entrada de datos x teclado o asignar un valor a una variable en tiempo de ejecución
        Dim miNombre As String = Console.ReadLine()

        'salida
        Console.WriteLine("Bienvenida al sistema : " & miNombre)
    End Sub

End Module
