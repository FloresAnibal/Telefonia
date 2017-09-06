Public Class MegaByte
    Inherits Plan
    'campos
    Private _sumaBytes As UInt64

    'Constructor
    Sub New()
        Me.New(0, "", 0.0)
    End Sub

    Sub New(credito As UInt32, nombre As String, precio As Single)
        MyBase.New(credito, nombre, precio)
        _sumaBytes = 0
    End Sub

    'propiedades


    'metodos
    Public Overrides Sub addConsumo(valor As UInt32)
        valor += _sumaBytes 'acumulo el valor en byte recibido mas lo ya consumido anteriormente
        CalcularBytes(valor) 'envio el total de bytes consumidos a la funcion

        If CalcularBytes(valor) + _consumo <= Credito Then _consumo += CalcularBytes(valor)

    End Sub

    Public Overrides Function disponible() As String
        Return Credito - _consumo & " MB"
    End Function

    Private Function CalcularBytes(dividendo As Integer) As UInt32
        '1048576 bytes = 1 MB
        Const divisor As Integer = 1048576
        Dim resto As Integer = 0
        Dim cociente As Integer = Math.DivRem(dividendo, divisor, resto)
        'Math.DivRem = Calcula el cociente de dos números (enteros de 32 o 64 bit, con signo)
        'y devuelve también el resto de la división como parámetro de salida.

        _sumaBytes = resto 'resto tendrá el mismo valor que recibio la funcion si éste es menor a 1MB
        'o tendrá lo que haya sobrado despues de restar (al total recibido) los Megas posibles.

        Return cociente 'si el valor recibido es mayor a la constante, cociente devuelve un entero
        'mayor a cero de lo contrario devuelve cero.

    End Function

    'sobrescribir ToString
    Public Overrides Function ToString() As String
        Return "MegaByte"
    End Function

End Class
