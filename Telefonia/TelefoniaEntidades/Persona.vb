Public Class Persona
    'campos
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInt32

    'constructor
    Sub New()
        _apellido = ""
        _nombre = ""
        _documento = 0
    End Sub

    'constructor sobrecargado
    Sub New(apellido As String, nombre As String, documento As UInt32)
        Me.New()
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento
    End Sub

    'propiedades
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If ValidarCadena(value, 30) Then _apellido = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value, 50) Then _nombre = value
        End Set
    End Property

    Public Property Documento() As UInt32
        Get
            Return _documento
        End Get
        Set(value As UInt32)
            _documento = value
        End Set
    End Property

    'metodos



    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort) As Boolean
        If cadena.Length >= 1 And cadena.Length <= maximo Then
            Return True
        End If
        Return False
    End Function

End Class
