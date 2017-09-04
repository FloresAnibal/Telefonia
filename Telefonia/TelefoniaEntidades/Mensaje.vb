Public Class Mensaje
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
    Public Overrides Function disponible() As String
        Return Credito - _consumo & " Mensaje/s"
    End Function
    'sobrescribir ToString
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
