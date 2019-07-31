Public Class FrmAgregarEmpleado
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        TxtRut.ResetText()
        TxtNombre.ResetText()
        TxtApellidos.ResetText()
        TxtCorreo.ResetText()
        TxtDV.ResetText()

    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ''Tengo que validar
        '=>OK<=


        ''Objeto
        Dim empleado As New Empleado
        empleado.Nombre = TxtNombre.Text
        empleado.Apellidos = TxtApellidos.Text
        empleado.Rut = TxtRut.Text
        empleado.Email = TxtCorreo.Text
        ''Modificar
        Dim bsn As New BsnEmpleado
        bsn.AgregarEmpleado(empleado)
        'Limpiar
        Limpiar()
    End Sub
End Class