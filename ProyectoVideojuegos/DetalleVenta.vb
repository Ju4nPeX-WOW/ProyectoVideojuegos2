Public Class DetalleVenta
    Private _VentaId As Integer
    Private _ProductoId As Integer
    Private _Precio As Integer
    Private _Cantidad As Integer
    Private _Total As Integer

    Public Property VentaId
        Get
            Return _VentaId
        End Get
        Set(value)
            _VentaId = value
        End Set
    End Property
    Public Property ProductoId
        Get
            Return _ProductoId
        End Get
        Set(value)
            _ProductoId = value
        End Set
    End Property

    Public Property Precio
        Get
            Return _Precio
        End Get
        Set(value)
            _Precio = value
        End Set
    End Property

    Public Property Cantidad
        Get
            Return _Cantidad
        End Get
        Set(value)
            _Cantidad = value
        End Set
    End Property
    Public Property Total
        Get
            Return _Total
        End Get
        Set(value)
            _Total = value
        End Set
    End Property

End Class
