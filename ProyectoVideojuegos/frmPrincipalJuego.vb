Public Class frmPrincipalJuego
    Dim bsnJuego As New bsnJuego
    Dim bsnCategorias As New bsnCategoria

    Private Sub FrmPrincipalJuegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset1 As New DataSet()
        dataset1 = bsnJuego.CargarJuegos()
        dgvJuegos.DataSource = dataset1.Tables(0).DefaultView

        Dim dataset2 As New DataSet()
        dataset2 = bsnJuego.GetCategorias
        cbCategoria.DataSource = dataset2.Tables(0)
        cbCategoria.DisplayMember = "Nombre"
        cbCategoria.ValueMember = "Id_categoria"

    End Sub

    Private Sub DgvJuegos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJuegos.CellClick
        Dim numero As Integer
        numero = e.RowIndex
        If numero >= 0 Then
            Dim filaSeleccionada As DataGridViewRow
            filaSeleccionada = dgvJuegos.Rows(numero)
            lblId.Text = filaSeleccionada.Cells(0).Value.ToString()
            txtNombre.Text = filaSeleccionada.Cells(1).Value.ToString()
            txtDescripcion.Text = filaSeleccionada.Cells(2).Value.ToString()
            txtPrecio.Text = filaSeleccionada.Cells(3).Value.ToString()
            stockAddDel.Value = filaSeleccionada.Cells(5).Value.ToString
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        If lblId.Text = " " Or lblId.Text = "" Then
            MsgBox("No se ha seleccionado ningun Juego", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        Else
            id = lblId.Text
        End If
        If MessageBox.Show("¿ Está seguro de Eliminar este juego ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim juego As New Juego
            juego.ID = lblId.Text
            bsnJuego.EliminarJuegos(juego)
            MsgBox("Juego eliminado correctamente", MsgBoxStyle.Information, "Alerta")
            Dim dataset1 As New DataSet()
            dataset1 = bsnJuego.CargarJuegos()
            dgvJuegos.DataSource = dataset1.Tables(0).DefaultView
        End If
    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs)
        If lblId.Text = " " Or lblId.Text = "" Then
            txtNombre.Enabled = False
            txtPrecio.Enabled = False
            txtDescripcion.Enabled = False
            cbCategoria.Enabled = False
        Else
            txtNombre.Enabled = True
            txtPrecio.Enabled = True
            txtDescripcion.Enabled = True
            cbCategoria.Enabled = True
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If lblId.Text = " " Or lblId.Text = "" Then
            MsgBox("No se ha seleccionado ningun juego", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        End If
        If txtNombre.Text = "" Or txtDescripcion.Text = "" Or txtPrecio.Text = "" Then
            MsgBox("Campos no validos", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        End If

        Dim juego As New Juego
        juego.ID = lblId.Text
        juego.Nombre = txtNombre.Text
        juego.Descripcion = txtDescripcion.Text
        juego.Precio = txtPrecio.Text
        juego.IdCategoria = cbCategoria.SelectedValue
        juego.Stock = stockAddDel.Value
        bsnJuego.EditarJuegos(juego)

        MsgBox("Juego actualizado correctamente", MsgBoxStyle.Information, "Alerta")

        Dim dataset1 As New DataSet()
        dataset1 = bsnJuego.CargarJuegos()
        dgvJuegos.DataSource = dataset1.Tables(0).DefaultView
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub

End Class