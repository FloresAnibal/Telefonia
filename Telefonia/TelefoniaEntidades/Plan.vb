Public MustInherit Class Plan
    'campos
    Private _credito As UInt32
    Private _nombre As String
    Private _precio As Single
    Protected _consumo As UInt32

    'constructor
    Sub New()
        _credito = 0
        _nombre = ""
        _precio = 0.0
        _consumo = 0
    End Sub

    Sub New(credito As UInt32, nombre As String, precio As Single)
        Me.New()
        Me.Credito = credito
        Me.Nombre = nombre
        Me.Precio = precio
    End Sub
    'propiedades
    Public Property Credito As UInt32
        Get
            Return _credito
        End Get
        Set(value As UInt32)
            _credito = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value) Then _nombre = value
        End Set
    End Property

    Public Property Precio As Single
        Get
            Return _precio
        End Get
        Set(value As Single)
            _precio = value
        End Set
    End Property

    'metodos
    Public MustOverride Function disponible() As String

    Public Overridable Sub addConsumo(valor As UInt32)
        If _consumo + valor <= Credito Then _consumo += valor
    End Sub

    'valida la longitud minima de un string
    Private Function ValidarCadena(cadena As String) As Boolean
        If cadena.Length > 0 Then 'en el diseño no se especifica un maximo
            Return True
        End If
        Return False
    End Function
End Class
