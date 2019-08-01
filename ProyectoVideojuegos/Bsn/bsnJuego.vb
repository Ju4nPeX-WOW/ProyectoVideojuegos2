Public Class bsnJuego
    Dim daoJuego As New daoJuego
    Public Function CargarJuegos()
        Return daoJuego.CargarJuegos()
    End Function
    Public Function AgregarJuegos(juego As Juego)
        Return daoJuego.AgregarJuegos(juego)
    End Function
    Public Function EliminarJuegos(id As Integer)
        Return daoJuego.EliminarJuegos(id)
    End Function
    Public Function GetCategorias()
        Return daoJuego.GetCategorias()
    End Function
    Public Function EditarJuegos(id As Integer, juego As Juego)
        Return daoJuego.EditarJuegos(id, juego)
    End Function
End Class
