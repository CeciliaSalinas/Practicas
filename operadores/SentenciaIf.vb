Module SentenciaIf
    Sub Main()

        'Crear un programa que ingresando el valor total de la compra que realice un descuento si:
        'el valor de la compra es de 5000-10000 el descuento es el 5%
        'el valor es entre 10001-15000 descuento 10%
        'mayor a 15000 descuento del 15%
        'muestra: total compra, total de la compra con descuento y el descuento.

        Console.Write("Ingrese el valor de la compra")
        Dim importeCompra As Double = Console.ReadLine()

        'creo variable para guaradar descuento e inicializo en 0
        Dim descuento As Double = 0

        If importeCompra >= 5000 And importeCompra <= 10000 Then

            descuento = importeCompra * 0.05

        ElseIf importeCompra > 10000 And importeCompra <= 15000 Then
            descuento = importeCompra * 0.1

        ElseIf importeCompra > 15000 Then
            descuento = importeCompra * 0.15
        End If

        Console.WriteLine("El valor total de la compra es : " & importeCompra)
        Console.WriteLine("El valor total de la compra con descuento es : " & importeCompra - descuento)
        Console.WriteLine("El valor descontado en la compra es : " & descuento)
    End Sub
End Module
