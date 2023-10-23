Module CreacionObjeto

    Sub Main()
        'creamos objeto que va a perteneracer a la clase a.acondiconado
        Dim sams As ClsAireAcondicionado = New ClsAireAcondicionado()

        'asignamos valores a los atributos con el . (punto)
        sams.marca = "sams"
        sams.modelo = "sams25"
        sams.color = " black"
        sams.voltaje = 220
        sams.valor = 400.0
        sams.temperatura = 0

        Console.WriteLine(sams.marca)
        Console.WriteLine(sams.modelo)
        Console.WriteLine(sams.color)
        Console.WriteLine(sams.voltaje)
        Console.WriteLine(sams.valor)
        Console.WriteLine(sams.temperatura)
    End Sub
End Module
