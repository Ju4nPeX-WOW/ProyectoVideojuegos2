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
        'Que no hayan vacios
        If TxtNombre.TextLength <> 0 And TxtApellidos.TextLength <> 0 And TxtRut.TextLength <> 0 And TxtDV.TextLength <> 0 And TxtCorreo.TextLength <> 0 Then
            ''Objeto
            Dim empleado As New Empleado
            'Validar Rut
            If empleado.ValidarRut(TxtRut.Text, TxtDV.Text) Then
                empleado.Nombre = TxtNombre.Text
                empleado.Apellidos = TxtApellidos.Text
                empleado.Rut = TxtRut.Text
                empleado.Email = TxtCorreo.Text
                ''Modificar
                Dim bsn As New BsnEmpleado
                bsn.AgregarEmpleado(empleado)
                'Limpiar
                Limpiar()

            Else
                MsgBox("El rut ingresado no es correcto")
            End If




        Else
            MsgBox("Complete todos los campos")
        End If


    End Sub


    Private Sub EstablecerLargo()
        TxtNombre.MaxLength = 30
        TxtApellidos.MaxLength = 30
        TxtRut.MaxLength = 8
        TxtDV.MaxLength = 1
        TxtCorreo.MaxLength = 20
    End Sub

    Private Sub FrmAgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerLargo()
    End Sub



    Private Sub TxtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRut.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar)
    End Sub
End Class