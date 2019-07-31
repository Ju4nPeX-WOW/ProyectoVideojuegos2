Public Class Consola
    Private _id As String
    Private _console As String
    Private _marca As String
    Private _descripcion As String
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
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
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
