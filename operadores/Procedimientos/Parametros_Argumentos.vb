Module Parametros_Argumentos
    'crear procedimiento SUB que muestre saludo a x persona
    'el nombre debe ser pasado por parámetro
    Dim nombrePersona As String
    Sub Main()
        Console.Write("Ingrese su nombre: ")
        nombrePersona = Console.ReadLine()
        saludos()
    End Sub

    Sub saludos()
        Console.WriteLine("Hola " & nombrePersona)
    End Sub
End Module
