Module ProcedimientoFunction
    'EJEMPLO
    'procedimiento que retorne la suma entre 2 numeros enteros
    'Sub main()
    '    Console.WriteLine(sumar(8, 9))
    'End Sub

    'Function sumar(num1 As Integer, num2 As Integer) As Integer
    '    Dim resultado As Integer = num1 + num2
    '    Return resultado
    'End Function

    'EJEMPLO
    'procedimiento que permita buscar un número dentro de un array
    'retornar la posición donde se encontró el elemento buscado.


    Sub main()
        Dim numeros = New Integer() {25, 48, 10, 58, 99}
        Console.WriteLine(buscarNumArray(48, numeros))
    End Sub
    Function buscarNumArray(numBuscar As Integer, vectorArray() As Integer) As Integer
        Dim posicion As Integer = -1
        Dim encontrado As Boolean = False
        For i = 0 To vectorArray.Length - 1 And encontrado = False Step 1
            If vectorArray(i) = numBuscar Then
                posicion = i
                encontrado = True
            End If
        Next
        Return posicion
    End Function
End Module
