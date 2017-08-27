Public Class Equipo

    'campos
    Private _marca As String
    Private _modelo As String
    Private _serie As String
    Private _fechaVenta As Date

    'constructor
    Sub New()
        _marca = ""
        _modelo = ""
        _serie = ""
        _fechaVenta = Nothing
    End Sub

    'constructor sobrecargado
    Sub New(Marca As String, Modelo As String, Serie As String)
        Me.New()
        Me.Marca = Marca
        Me.Modelo = Modelo
        Me.Serie = Serie
    End Sub

    'propiedades
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(value As String)
            If ValidarCadena(value, 30) Then _marca = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            If ValidarCadena(value, 50) Then _modelo = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If ValidarCadena(value, 15) Then _serie = value
        End Set
    End Property

    Public ReadOnly Property FechaVenta() As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    'metodos
    Public Sub Vender(value As Date)
        _fechaVenta = value
    End Sub

    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort) As Boolean
        If cadena.Length >= 1 And cadena.Length <= maximo Then
            Return True
        End If
        Return False
    End Function

End Class
