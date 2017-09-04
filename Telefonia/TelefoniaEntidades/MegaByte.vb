Public Class MegaByte
    Inherits Plan

    'campos


    'Constructor
    Sub New()
        MyBase.New()
    End Sub

    Sub New(credito As UInt32, nombre As String, precio As Single)
        Me.New()
        Me.Credito = credito
        Me.Nombre = nombre
        Me.Precio = precio
    End Sub

    'propiedades


    'metodos
    Public Overrides Sub addConsumo(valor As UInt32)
        '1048576 bytes = 1 MB
        If _consumo + valor / 1048576 <= Credito Then _consumo += valor / 1048576
    End Sub

    Public Overrides Function disponible() As String
        Return Credito - _consumo & " MB"
    End Function
    'sobrescribir ToString
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
