Public Class ClsAireAcondicionado

    'ATRIBUTOS/valores DE LA CLASE (los atributos son las variables)
    Public marca As String
    Public modelo As String
    Public color As String
    Public voltaje As Integer
    Public valor As Integer
    Public temperatura As Integer


    'METODOS DE LA CLASE
    Public Sub subirTemperatura()
        temperatura += 1
    End Sub

    Public Sub bajarTemperatura()
        temperatura -= 1
    End Sub

    Public Function darTemperatura() As Integer
        Return temperatura
    End Function

End Class
