Public Class Linea
    'campos
    Private _codigoArea As UShort
    Private _numero As UInt32
    Private _estadoLinea As Boolean

    'constructor
    Sub New()
        _codigoArea = 0
        _numero = 0
        _estadoLinea = False
    End Sub

    'constructor sobrecargado
    Sub New(codigoArea As UShort, Numero As UInt32)
        Me.New()
        Me.CodiogoArea = codigoArea
        Me.Numero = Numero
    End Sub

    'propiedades
    Public Property CodiogoArea() As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If ValidarNumero(value, 100, 9999) Then _codigoArea = value
        End Set
    End Property

    Public Property Numero() As UInt32
        Get
            Return _numero
        End Get
        Set(value As UInt32)
            If ValidarNumero(value, 100000, 9999999) Then _numero = value
        End Set
    End Property

    Public ReadOnly Property Estado() As String
        Get
            Return If(_estadoLinea, "Activa", "Suspendida")
        End Get
    End Property

    'metodos
    Public Sub Suspender()
        _estadoLinea = False
    End Sub

    Public Sub Reactivar()
        _estadoLinea = True
    End Sub

    'valida el rango maximo y minimo de un entero
    Private Function ValidarNumero(valor As Integer, minimo As Integer, maximo As Integer) As Boolean
        If valor >= minimo And valor <= maximo Then Return True
        Return False
    End Function

End Class
