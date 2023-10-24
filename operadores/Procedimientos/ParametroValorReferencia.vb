Module ParametroValorReferencia

    'Parámetro por valor : usamos ByVal ( que es igual si en un procedimiento ponemos como parámetro
    'una declaracion de variable con su tipo
    'Parámetro por referencia : usamos ByRef

    'CAMBIAR VALOR INICIAL DE UNA VARIABLE DESDE UNA FUNCION
    ' EN LA FUNCION ESTABLECEMOS EL PARÁMETRO para modificar el valor de la variable

    'parametro por valor: (num as Integer) = (ByVal )

    Sub main()
        Dim numero As Integer = 5
        'este 5 se almacena en el parametro/variable num del procedimiento cambiarNumeroVariable 
        cambiarNumeroVariable(numero) 'numero aca es el argumento
        Console.WriteLine(numero)
    End Sub

    Sub cambiarNumeroVariable(ByRef num As Integer)
        ' si le saco el byRef solo muestra el argumento (5)
        'al establecer un ByRef(paramtro por referencia) creamos un vínculo con
        num = 40
    End Sub
End Module
