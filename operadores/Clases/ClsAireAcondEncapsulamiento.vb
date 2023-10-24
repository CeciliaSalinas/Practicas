Public Class ClsAireAcondEncapsulamiento


    'ENCAPSULAMIENTO CON MODIFICADOR DE ACCESO PRIVATE
    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As Integer
    Private valor As Integer
    Private temperatura As Integer

    'METODOS DE LA CLASE
    Public Sub subirTemperatura()
        temperatura += 1
    End Sub

    Public Sub bajarTemperatura()
        temperatura -= 1
    End Sub

    Public Sub setMarca(mar As String)
        marca = mar
    End Sub

    Public Function getMarca() As String
        Return marca
    End Function

    Public Sub setModelo(mo As String)
        modelo = mo
    End Sub

    Public Function getModelo() As String
        Return modelo
    End Function

    Public Sub setColor(col As String)
        color = col
    End Sub

    Public Function getColor() As String
        Return color
    End Function

    Public Sub setVoltaje(vol As Integer)
        voltaje = vol
    End Sub

    Public Function getVoltaje() As Integer
        Return voltaje
    End Function


    Public Sub setValor(val As Integer)
        valor = val
    End Sub

    Public Function getValor() As Integer
        Return valor
    End Function

    Public Sub setTemperatura(temp As Integer)
        temperatura = temp
    End Sub

    Public Function getTemperatura() As Integer
        Return temperatura
    End Function
End Class
