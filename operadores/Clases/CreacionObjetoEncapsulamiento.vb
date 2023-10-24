Public Class CreacionObjetoEncapsulamiento

    Sub main()
        Dim sams As ClsAireAcondEncapsulamiento = New ClsAireAcondEncapsulamiento()
        'ACCESO AL VALOR POR PRIVATE
        sams.setMarca("tyt")
        sams.setModelo("ghj76")
        sams.setColor("pink")
        sams.setVoltaje(220)
        sams.setValor(400000)
        sams.setTemperatura(17)


        'MUESTRO POR CONSOLA EL VALOR DE LOS ATRIBUTOS DE UN METODO PRIVADO
        Console.WriteLine(sams.getMarca())
        Console.WriteLine(sams.getModelo())
        Console.WriteLine(sams.getColor())
        Console.WriteLine(sams.getVoltaje())
        Console.WriteLine(sams.getValor())
        Console.WriteLine(sams.getTemperatura())
    End Sub
End Class
