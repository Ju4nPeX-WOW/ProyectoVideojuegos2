Public Class DaoVenta
    Public Function GetConsolas()
        Dim instruccion As New Instrucciones
        Return instruccion.Seleccionar("Console", "Id,Consola,Precio,Stock,Descripcion", "")
    End Function

    Public Function GetJuegos()
        Dim instruccion As New Instrucciones
        Return instruccion.Seleccionar("Juego", "Id_juego as Id,Nombre,Precio,Stock,Descripcion", "")
    End Function
    Public Function GetVentas()
        Dim instruccion As New Instrucciones
        Dim t = "Venta INNER Join Empleado On Venta.Empleado_Id = Empleado.Id "
        Return instruccion.Seleccionar(t, "Venta.Id,Empleado.Nombre as Empleado,Venta.Fecha,Venta.Total", "")
        'Return instruccion.Seleccionar("Venta", "Id,Empleado_Id as Empleado,Fecha,Total", "")
    End Function

    'Public Function GetDetalles()
    'Dim instruccion As New Instrucciones
    'Return instruccion.Seleccionar("DetalleVenta", "Id_juego as Id,Nombre,Precio,Stock,Descripcion", "")
    'End Function


    Public Sub InsertVenta(v As Venta)
        Dim instruccion As New Instrucciones
        Dim columnas = "Empleado_Id, Fecha, Total"
        Dim valores As String = v.EmpleadoId & ",'" & v.Fecha & "'," & v.Total
        If instruccion.Insertar("Venta", columnas, valores) Then
            MsgBox("Venta Ingresado Correctamente")
        End If
    End Sub

    Public Function ObtenerUltimoId()
        Dim instruccion As New Instrucciones
        Dim dataset As New DataSet
        dataset = instruccion.Seleccionar("Venta", "MAX(Id)", "")
        Return dataset.Tables(0)(0)(0)
    End Function
    Public Sub InsertDetalle(d As DetalleVenta)
        Dim instruccion As New Instrucciones
        Dim columnas = "Venta_Id,Producto_Id,Precio,Cantidad,Total,Tipo"
        Dim valores As String = d.VentaId & "," & d.ProductoId & "," & d.Precio & "," & d.Cantidad & "," & d.Total & "," & d.Tipo
        If Not instruccion.Insertar("DetalleVenta", columnas, valores) Then
            MsgBox("No fue posible guardar el detalle de la venta")
        End If
    End Sub

    Public Sub ReducirStock(d As DetalleVenta, oldStock As Integer)
        Dim instruccion As New Instrucciones
        Dim newStock = oldStock - d.Cantidad
        If d.Tipo = 0 Then
            '' en consolas
            If Not instruccion.Modificar("Console", "Stock = " & newStock, "WHERE Id = " & d.ProductoId) Then
                MsgBox("No fue posible  actualizar stock")
            End If

        ElseIf d.Tipo = 1 Then
            ''en juegos
            If Not instruccion.Modificar("Juego", "Stock = " & newStock, "WHERE Id_juego = " & d.ProductoId) Then
                MsgBox("No fue posible stock")
            End If

        End If

    End Sub
End Class
