Public Class BsnVenta
    Public Function GetConsolas()
        Dim dao As New DaoVenta
        Return dao.GetConsolas()
    End Function
    Public Function GetJuegos()
        Dim dao As New DaoVenta
        Return dao.GetJuegos()
    End Function
    Public Function GetVentas()
        Dim dao As New DaoVenta
        Dim dataset As New DataSet
        dataset = dao.GetVentas()
        MsgBox(dataset.Tables(0).Rows.Count)
        Return dataset
    End Function
    'Public Function GetDetalles()
    'Dim dao As New DaoVenta
    'Return dao.GetDetalles()
    'End Function

    Public Sub HacerVenta(v As Venta)
        Dim dao As New DaoVenta
        dao.InsertVenta(v)
    End Sub
    Public Function ObtenerUltimoId()
        Dim dao As New DaoVenta
        Return dao.ObtenerUltimoId
    End Function
    Public Sub InsertarDetalle(d As DetalleVenta)
        Dim dao As New DaoVenta
        dao.InsertDetalle(d)
        ActualizarStock(d)
    End Sub
    Private Sub ActualizarStock(d As DetalleVenta)
        If d.Tipo = 0 Then
            Dim bsnc As New BsnConsole
            Dim c As Consola = bsnc.ObtenerConsola(d.ProductoId)
            c.Stock = c.Stock - d.Cantidad
            bsnc.ModificarConsola(c)
        ElseIf d.Tipo = 1 Then
            Dim bsnj As New bsnJuego
            Dim j As Juego = bsnj.ObtenerJuego(d.ProductoId)
            j.Stock = j.Stock - d.Cantidad
            bsnj.EditarJuegos(j)
        End If

    End Sub

End Class
