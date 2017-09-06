Public Class Minuto
    Inherits Plan
    'campos


    'Constructor
    Sub New()
        Me.New(0, "", 0.0)
    End Sub

    Sub New(credito As UInt32, nombre As String, precio As Single)
        MyBase.New(credito, nombre, precio)
    End Sub

    'propiedades


    'metodos
    Public Overrides Function disponible() As String
        Return Credito - _consumo & " Minuto/s"
    End Function

    'sobrescribir ToString
    Public Overrides Function ToString() As String
        Return "Minuto"
    End Function

End Class
