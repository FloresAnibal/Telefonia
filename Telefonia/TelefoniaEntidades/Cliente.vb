Public Class Cliente
    'campos
    Private _id As Integer

    'constructor
    Sub New()
        _id = 0
    End Sub

    'propiedades
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    'metodos

End Class
