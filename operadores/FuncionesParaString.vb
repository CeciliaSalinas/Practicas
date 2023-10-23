Module FuncionesParaString
    Sub main()
        Dim cadenaA As String = "Practicando las funciones para los string"
        Dim cadenaB As String = "Practicando las funciones para los string"
        Dim cadenaC As String = "Practicando las funciones"


        Console.WriteLine(cadenaA.ToUpper())
        Console.WriteLine(cadenaB.ToLower())
        Console.WriteLine(cadenaA.Substring(0, cadenaC.Length()))
        Console.WriteLine(cadenaC.Length())
        Console.WriteLine(cadenaA.Equals(cadenaB))

    End Sub

End Module
