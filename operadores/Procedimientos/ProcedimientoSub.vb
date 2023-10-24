Module ProcedimientoSub

    'sub : no debe retornar ningun dato , pueden tener o no argumentos
    Sub Main() ' usuamos main porque lo estamos ejecutando por consola

        Console.WriteLine("Mensaje del procedimiento Main .")
        mostrarMensaje() 'se situa en el procedimiento  Sub mostrarMensaje y ejecuta las intrucciones
        mostrarMensaje()
    End Sub

    Sub mostrarMensaje()

        Console.WriteLine("Estas en el procedimiento Sub")
    End Sub
End Module
