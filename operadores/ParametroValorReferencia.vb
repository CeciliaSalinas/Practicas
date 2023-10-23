Module ParametroValorReferencia

    'Parámetro por valor : usamos ByVal ( que es igual si en un procedimiento ponemos como parámetro
    'una declaracion de variable con su tipo
    'Parámetro por referencia : usamos ByRef

    'CAMBIAR VALOR INICIAL DE UNA VARIABLE DESDE UNA FUNCION
    ' EN LA FUNCION ESTABLECEMOS EL PARÁMETRO

    Sub main()
        Dim numero As Integer = 5
        cambiarNumeroVariable(numero)
        Console.WriteLine(numero)
    End Sub

    Sub cambiarNumeroVariable(ByRef num As Integer)
        num = 24
    End Sub
End Module
