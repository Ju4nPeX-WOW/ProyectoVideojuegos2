Public Class bsnCategoria
    Dim daoCategoria As New daoCategoria
    Public Function CargarCategorias()
        Return daoCategoria.CargarCategorias()
    End Function
    Public Function AgregarCategorias(categoria As Categoria)
        Return daoCategoria.AgregarCategorias(categoria)
    End Function
    Public Function EliminarCategorias(id As Integer)
        Return daoCategoria.EliminarCategorias(id)
    End Function
    Public Function EditarCategorias(id As Integer, nombre As String)
        Return daoCategoria.EditarCategorias(id, nombre)
    End Function
End Class
