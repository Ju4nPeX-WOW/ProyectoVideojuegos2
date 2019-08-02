Public Class frmPrincipalCategorias
    Dim bsnCategoria As New bsnCategoria
    Private Sub FrmPrincipalCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCategoria.DataSource = bsnCategoria.CargarCategorias()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        If txtId.Text = " " Or txtId.Text = "" Then
            MsgBox("No se ha seleccionado ninguna categoría", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        Else
            id = txtId.Text
        End If
        If MessageBox.Show("¿ Está seguro de Eliminar esta categoría ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            bsnCategoria.EliminarCategorias(id)
            MsgBox("Categoría eliminada correctamente", MsgBoxStyle.Information, "Alerta")
            dgvCategoria.DataSource = bsnCategoria.CargarCategorias()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtId.Text = " " Or txtId.Text = "" Then
            MsgBox("No se ha seleccionado ninguna categoría", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        End If
        If txtNombre.Text = "" Or txtNombre.Text = " " Then
            MsgBox("Ingrese un nombre valido", MsgBoxStyle.Information, "Alerta")
            Exit Sub
        End If
        bsnCategoria.EditarCategorias(txtId.Text, txtNombre.Text)
        MsgBox("Categoría actualizada correctamente", MsgBoxStyle.Information, "Alerta")
        dgvCategoria.DataSource = bsnCategoria.CargarCategorias()
    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        If txtId.Text = " " Or txtId.Text = "" Then
            txtNombre.Enabled = False
        Else
            txtNombre.Enabled = True
        End If
    End Sub
    Private Sub DgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoria.CellClick
        Dim numero As Integer
        numero = e.RowIndex
        If numero >= 0 Then
            Dim filaSeleccionada As DataGridViewRow
            filaSeleccionada = dgvCategoria.Rows(numero)
            txtId.Text = filaSeleccionada.Cells(0).Value.ToString()
            txtNombre.Text = filaSeleccionada.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub
End Class