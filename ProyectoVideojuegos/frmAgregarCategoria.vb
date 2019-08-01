Public Class frmAgregarCategoria
    Dim bsnCategoria As New bsnCategoria
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Then
            MsgBox("Campo en blanco", MsgBoxStyle.Information, "Error")
        Else
            Dim categoria As New Categoria(txtNombre.Text)
            bsnCategoria.AgregarCategorias(categoria)
            MsgBox("Categoria " & txtNombre.Text & " agregada satisfactoriamente", MsgBoxStyle.Information, "Información")
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub
End Class