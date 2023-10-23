Module CreacionObjeto

    Sub Main()
        'creamos objeto que va a perteneracer a la clase a.acondiconado
        Dim sams As ClsAireAcondicionado = New ClsAireAcondicionado()

        'asignamos valores a los atributos con el . (punto)************
        'sams.marca = "sams"
        'sams.modelo = "sams25"
        'sams.color = " black"
        'sams.voltaje = 220
        'sams.valor = 400.0
        'sams.temperatura = 30


        'ACCESO AL VALOR POR PRIVATE
        sams.setMarca("tyt")
        sams.setModelo("ghj76")
        sams.setColor("pink")
        sams.setVoltaje(220)
        sams.setValor(400000)
        sams.setTemperatura(17)

        'MUESTRO POR CONSOLA EL VALOR DE LOS ATRIBUTOS ***************
        'Console.WriteLine(sams.marca)
        'Console.WriteLine(sams.modelo)
        'Console.WriteLine(sams.color)
        'Console.WriteLine(sams.voltaje)
        'Console.WriteLine(sams.valor)
        'Console.WriteLine(sams.temperatura)


        'MUESTRO POR CONSOLA EL VALOR DE LOS ATRIBUTOS DE UN METODO PRIVADO
        Console.WriteLine(sams.getMarca())
        Console.WriteLine(sams.getModelo())
        Console.WriteLine(sams.getColor())
        Console.WriteLine(sams.getVoltaje())
        Console.WriteLine(sams.getValor())
        Console.WriteLine(sams.getTemperatura())

        'USAR UN MÉTODO DEL OBJETO
        'sams.subirTemperatura()

        'MUESTRA DATOS POR CONSOLA
        'Console.WriteLine(sams.temperatura)

    End Sub
End Module
