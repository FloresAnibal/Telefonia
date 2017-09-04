Public Class Empresa
    Inherits Cliente
    'campos
    Private _razonSocial As String
    Private _cuit As String

    'constructor
    Sub New()
        MyBase.New()
        _razonSocial = ""
        _cuit = ""
    End Sub

    'constructor sbrecargado
    Sub New(razonSocial As String, cuit As String)
        Me.New()
        Me.RazonSocial = razonSocial
        Me.Cuit = cuit
    End Sub

    'propiedades
    Public Property RazonSocial() As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If ValidarCadena(value, 80) Then _razonSocial = value
        End Set
    End Property

    Public Property Cuit() As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If ValidarCadena(value, 13) Then _cuit = value
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
