Public Class Juego
    Protected _nombre As String
    Protected _descripcion As String
    Protected _precio As Integer
    Protected _idCategoria As Integer

    Public Sub New(nombre As String, descripcion As String, precio As Integer, idCategoria As Integer)
        MyBase.New()
        _nombre = nombre
        _descripcion = descripcion
        _precio = precio
        _idCategoria = idCategoria
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = Nombre
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = Descripcion
        End Set
    End Property
    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = Precio
        End Set
    End Property
    Public Property IdCategoria As Integer
        Get
            Return _idCategoria
        End Get
        Set(value As Integer)
            _idCategoria = IdCategoria
        End Set
    End Property
End Class
