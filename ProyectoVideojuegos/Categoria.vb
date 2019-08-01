Public Class Categoria
    Protected _nombre As String

    Public Sub New(nombre As String)
        MyBase.New()
        _nombre = nombre
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = Nombre
        End Set
    End Property
End Class
