Public Class Empleado
    Protected _id As Short
    Protected _nombre As String
    Protected _apellidos As String
    Protected _rut As Integer
    Protected _email As String

    Public Property ID()
        Get
            Return _id
        End Get
        Set(value)
            _id = value
        End Set
    End Property

    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property
    Public Property Apellidos()
        Get
            Return _apellidos
        End Get
        Set(value)
            _apellidos = value
        End Set
    End Property
    Public Property Rut()
        Get
            Return _rut
        End Get
        Set(value)
            _rut = value
        End Set
    End Property
    Public Property Email()
        Get
            Return _email
        End Get
        Set(value)
            _email = value
        End Set
    End Property

End Class
