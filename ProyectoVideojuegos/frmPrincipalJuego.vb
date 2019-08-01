Public Class frmPrincipalJuego
    Dim bsnJuego As New bsnJuego
    Private Sub FrmPrincipalJuegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvJuegos.DataSource = bsnJuego.CargarJuegos()
        Dim dataset As New DataSet()
        dataset = bsnJuego.GetCategorias()
        cbCategoria.DisplayMember = dataset.Tables(0).Columns(1).ToString()
        cbCategoria.ValueMember = dataset.Tables(0).Columns(0).ToString()
        cbCategoria.DataSource = dataset.Tables(0)
    End Sub

    Private Sub DgvJuegos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJuegos.CellClick
        Dim numero As Integer
        numero = e.RowIndex
        Dim filaSeleccionada As DataGridViewRow
        filaSeleccionada = dgvJuegos.Rows(numero)
        txtId.Text = filaSeleccionada.Cells(0).Value.ToString()
        txtNombre.Text = filaSeleccionada.Cells(1).Value.ToString()
        txtDescripcion.Text = filaSeleccionada.Cells(2).Value.ToString()
        txtPrecio.Text = filaSeleccionada.Cells(3).Value.ToString()
        If txtId.Text = "" Or txtId.Text = " " Then
            cbCategoria.SelectedValue = 1
        Else
            cbCategoria.SelectedValue = filaSeleccionada.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        If txtId.Text = " " Or txtId.Text = "" Then
            MsgBox("No se ha seleccionado ningun Juego", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        Else
            id = txtId.Text
        End If
        If MessageBox.Show("¿ Está seguro de Eliminar este juego ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            bsnJuego.EliminarJuegos(id)
            MsgBox("Juego eliminado correctamente", MsgBoxStyle.Information, "Alerta")
            dgvJuegos.DataSource = bsnJuego.CargarJuegos()
        End If
    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        If txtId.Text = " " Or txtId.Text = "" Then
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
        If txtId.Text = " " Or txtId.Text = "" Then
            MsgBox("No se ha seleccionado ningun juego", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        End If
        If txtNombre.Text = "" Or txtDescripcion.Text = "" Or txtPrecio.Text = "" Then
            MsgBox("Campos no validos", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        End If
        Dim juego As New Juego(txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, cbCategoria.SelectedValue)
        bsnJuego.EditarJuegos(txtId.Text, juego)
        MsgBox("Juego actualizado correctamente", MsgBoxStyle.Information, "Alerta")
        dgvJuegos.DataSource = bsnJuego.CargarJuegos()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Dispose()
        frmAgregarJuego.Show()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub
End Class