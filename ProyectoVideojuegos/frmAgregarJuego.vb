Public Class frmAgregarJuego
    Dim bsnJuego As New bsnJuego
    Private Sub FrmAgregarJuegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New DataSet()
        dataset = bsnJuego.GetCategorias()
        cbCategoria.DisplayMember = dataset.Tables(0).Columns(1).ToString()
        cbCategoria.ValueMember = dataset.Tables(0).Columns(0).ToString()
        cbCategoria.DataSource = dataset.Tables(0)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Or txtDescripcion.Text = "" Or txtPrecio.Text = "" Or stockAddDel.Value = 0 Or Not (IsNumeric(txtPrecio.Text)) Then
            MsgBox("Campos en blanco", MsgBoxStyle.Information, "Error")
        Else
            Dim juego As New Juego

            juego.Nombre = txtNombre.Text
            juego.Descripcion = txtDescripcion.Text
            juego.Precio = txtPrecio.Text
            juego.IdCategoria = cbCategoria.SelectedValue
            juego.Stock = stockAddDel.Value

            bsnJuego.AgregarJuegos(juego)
            MsgBox("Juego ingresado satisfactoriamente", MsgBoxStyle.Information, "Información")

            txtNombre.Text = ""
            txtDescripcion.Text = ""
            txtPrecio.Text = ""
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub
End Class