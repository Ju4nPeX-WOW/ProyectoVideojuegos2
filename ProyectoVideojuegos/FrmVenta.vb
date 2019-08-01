Public Class FrmVenta
    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbTipo.SelectedIndex = 0
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        '' tengo que validar


        Dim id = DgvProductos.CurrentRow.Cells.Item(0).Value  'id del producto
        Dim tipo = CmbTipo.SelectedItem.ToString              'tipo producto
        Dim cantidad = NudCantidad.Value                      'cantidad a vender

        If cantidad <> 0 Then

            '' revisar si ya fue agregado anteriormente
            Dim encontrado = False
            For i = 0 To DgvProductosSeleccionados.RowCount - 2
                If DgvProductosSeleccionados.Rows(i).Cells.Item(1).Value = id And DgvProductosSeleccionados.Rows(i).Cells.Item(0).Value.ToString.Equals(tipo) Then
                    DgvProductosSeleccionados.Rows(i).Cells.Item(4).Value = DgvProductosSeleccionados.Rows(i).Cells.Item(4).Value + cantidad
                    encontrado = True
                End If
            Next

            If Not encontrado Then
                tipo = CmbTipo.SelectedItem
                Dim nombre = DgvProductos.CurrentRow.Cells.Item(1).Value.ToString
                Dim precio = DgvProductos.CurrentRow.Cells.Item(2).Value
                Dim total = cantidad * precio
                Dim list = {tipo, id, nombre, precio, cantidad, total}
                DgvProductosSeleccionados.Rows.Add(list)
            End If




            ''CALCULAR TOTAL
            CalcularTotal()
        End If


    End Sub
    Private Sub CalcularTotal()
        Dim total = 0
        For i = 0 To DgvProductosSeleccionados.RowCount - 1
            total = total + DgvProductosSeleccionados.Rows(i).Cells.Item(5).Value
        Next
        TxtTotal.Text = total


    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        '' aumentar en 1 el row seleccionado
        Dim nuevoValor = DgvProductosSeleccionados.CurrentRow.Cells.Item(4).Value + 1
        DgvProductosSeleccionados.CurrentRow.Cells.Item(4).Value = nuevoValor
        Dim cantidad = DgvProductosSeleccionados.CurrentRow.Cells.Item(4).Value
        ''ACTUALIZAMOS EL TOTAL 
        Dim precio = DgvProductosSeleccionados.CurrentRow.Cells.Item(3).Value
        DgvProductosSeleccionados.CurrentRow.Cells.Item(5).Value = cantidad * precio
        ''CALCULAR TOTAL
        CalcularTotal()
    End Sub

    Private Sub BtnDisminuir_Click(sender As Object, e As EventArgs) Handles BtnDisminuir.Click
        '' disminuir en 1 el row seleccionado
        Dim nuevoValor = DgvProductosSeleccionados.CurrentRow.Cells.Item(4).Value - 1
        DgvProductosSeleccionados.CurrentRow.Cells.Item(4).Value = nuevoValor
        Dim cantidad = DgvProductosSeleccionados.CurrentRow.Cells.Item(4).Value
        ''ACTUALIZAMOS EL TOTAL 
        Dim precio = DgvProductosSeleccionados.CurrentRow.Cells.Item(3).Value
        DgvProductosSeleccionados.CurrentRow.Cells.Item(5).Value = cantidad * precio
        If nuevoValor <= 0 Then
            DgvProductosSeleccionados.Rows.Remove(DgvProductosSeleccionados.CurrentRow)
        End If
        ''CALCULAR TOTAL
        CalcularTotal()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        DgvProductosSeleccionados.Rows.Remove(DgvProductosSeleccionados.CurrentRow)
        ''CALCULAR TOTAL
        CalcularTotal()
    End Sub

    Private Sub BtnRealizarVenta_Click(sender As Object, e As EventArgs) Handles BtnRealizarVenta.Click
        ''VALIDAR
        If Integer.Parse(TxtTotal.Text) <> 0 Then
            '' instaciar el objeto venta
            Dim venta As New Venta
            venta.EmpleadoId = 0
            venta.Fecha = DateTime.Now.ToString("dd-MM-yyyy")
            venta.Total = TxtTotal.Text
            ''bsn 
            Dim bsn As New BsnVenta
            bsn.HacerVenta(venta)
            'Detalle Venta
            Dim id = bsn.ObtenerUltimoId
            For i = 0 To DgvProductosSeleccionados.RowCount - 2
                Dim detalle As New DetalleVenta
                detalle.VentaId = id
                detalle.ProductoId = DgvProductosSeleccionados.Rows(i).Cells.Item(1).Value
                detalle.Precio = DgvProductosSeleccionados.Rows(i).Cells.Item(3).Value
                detalle.Cantidad = DgvProductosSeleccionados.Rows(i).Cells.Item(4).Value
                detalle.Total = DgvProductosSeleccionados.Rows(i).Cells.Item(5).Value
                Dim tipo = DgvProductosSeleccionados.Rows(i).Cells.Item(0).Value.ToString
                If tipo.Equals("Consolas") Then
                    detalle.Tipo = 0
                ElseIf tipo.Equals("VideoJuegos") Then
                    detalle.Tipo = 1
                End If
                bsn.InsertarDetalle(detalle)

            Next

        End If
    End Sub

    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged
        ''DATASET
        Dim bsn As New BsnVenta
        Dim dataset As New DataSet
        Dim tipo = CmbTipo.SelectedItem.ToString
        If tipo.Equals("Consolas") Then
            dataset = bsn.GetConsolas()
        ElseIf tipo.Equals("VideoJuegos") Then
            dataset = bsn.GetJuegos

        End If

        ''Cargar DGV
        DgvProductos.DataSource = dataset.Tables(0)

    End Sub
End Class