Public Class Venta
    Private _id As Short
    Private _empleadoId As Short
    Private _fecha As Date
    Private _total As Integer

    Public Property Id
        Get
            Return _id
        End Get
        Set(value)
            _id = value
        End Set
    End Property

    Public Property EmpleadoId
        Get
            Return _empleadoId
        End Get
        Set(value)
            _empleadoId = value
        End Set
    End Property

    Public Property Fecha
        Get
            Return _fecha
        End Get
        Set(value)
            _fecha = value
        End Set
    End Property

    Public Property Total
        Get
            Return _total
        End Get
        Set(value)
            _total = value
        End Set
    End Property
End Class
