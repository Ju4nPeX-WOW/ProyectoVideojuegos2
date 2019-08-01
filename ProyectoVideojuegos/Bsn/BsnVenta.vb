Public Class BsnVenta
    Public Function GetConsolas()
        Dim dao As New DaoVenta
        Return dao.GetConsolas()
    End Function
    Public Function GetJuegos()
        Dim dao As New DaoVenta
        Return dao.GetJuegos()
    End Function

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
    End Sub
End Class
