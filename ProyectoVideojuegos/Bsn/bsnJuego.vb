Public Class bsnJuego

    Dim columnas As String
    Dim valores As String
    Dim colvalor As String
    Dim condicion As String

    Dim daoJuego As New daoJuego
    Public Function CargarJuegos()
        Return daoJuego.CargarJuegos()
    End Function
    Public Function GetCategorias()
        Return daoJuego.GetCategorias()
    End Function
    Public Sub AgregarJuegos(juego As Juego)
        columnas = "Nombre,Descripcion,Precio,Categoria_id,Stock"
        valores = "'" & juego.Nombre & "','" & juego.Descripcion & "'," & juego.Precio & "," & juego.IdCategoria & "," & juego.Stock
        daoJuego.AgregarJuegos(columnas, valores)
    End Sub
    Public Sub EliminarJuegos(juego As Juego)
        condicion = " Id_juego=" & juego.ID
        daoJuego.EliminarJuegos(condicion)
    End Sub
    Public Sub EditarJuegos(juego As Juego)
        condicion = "Id_juego=" & juego.ID
        colvalor = "Nombre='" & juego.Nombre & "', Descripcion= '" & juego.Descripcion & "',Precio=" & juego.Precio & ",Categoria_id=" & juego.IdCategoria & ",Stock=" & juego.Stock
        daoJuego.EditarJuegos(colvalor, condicion)
    End Sub

End Class
