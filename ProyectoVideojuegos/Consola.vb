Public Class Consola
    Private _id As String
    Private _console As String
    Private _categoria As String
    Private _descripcion As String
    Private _precio As Integer
    Private _stock As Integer
    Public Property Precio() As Integer
        Get
            Return _precio
        End Get
        Set(ByVal value As Integer)
            _precio = value
        End Set
    End Property
    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Public Property Categoria() As String
        Get
            Return _categoria
        End Get
        Set(ByVal value As String)
            _categoria = value
        End Set
    End Property
    Public Property NameConsole() As String
        Get
            Return _console
        End Get
        Set(ByVal value As String)
            _console = value
        End Set
    End Property
End Class
