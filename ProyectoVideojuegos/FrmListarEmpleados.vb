Public Class FrmListarEmpleados
    Private Sub FrmListarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerLargo()
        Bloquear()
        ''cargar dvg
        Dim bsn As New BsnEmpleado
        Dim dataset As New DataSet
        dataset = bsn.GetEmpleados
        DgvEmpleados.DataSource = dataset.Tables(0)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    '' BLOQUEAR Y DESBLOQUEAR
    Private Sub Bloquear()
        Label1.Enabled = False
        LblRut.Enabled = False
        LblNombre.Enabled = False
        LblApellidos.Enabled = False
        LblEmail.Enabled = False
        TxtRut.Enabled = False
        TxtNombre.Enabled = False
        TxtApellidos.Enabled = False
        TxtCorreo.Enabled = False
        TxtDV.Enabled = False
        BtnAceptar.Enabled = False

    End Sub
    Private Sub Desbloquear()
        Label1.Enabled = False
        LblRut.Enabled = True
        LblNombre.Enabled = True
        LblApellidos.Enabled = True
        LblEmail.Enabled = True
        TxtRut.Enabled = True
        TxtNombre.Enabled = True
        TxtApellidos.Enabled = True
        TxtCorreo.Enabled = True
        TxtDV.Enabled = True
        BtnAceptar.Enabled = True


    End Sub

    ''LIMPIAR 
    Private Sub Limpiar()
        TxtRut.ResetText()
        TxtNombre.ResetText()
        TxtApellidos.ResetText()
        TxtCorreo.ResetText()
        TxtDV.ResetText()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Desbloquear()
    End Sub



    Private Sub DgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleados.CellClick
        LblID.Text = DgvEmpleados.CurrentRow.Cells.Item(0).Value.ToString
        TxtNombre.Text = DgvEmpleados.CurrentRow.Cells.Item(1).Value.ToString
        TxtApellidos.Text = DgvEmpleados.CurrentRow.Cells.Item(2).Value.ToString
        TxtRut.Text = DgvEmpleados.CurrentRow.Cells.Item(3).Value.ToString
        Dim em As New Empleado()
        TxtDV.Text = em.GetDV(TxtRut.Text)
        TxtCorreo.Text = DgvEmpleados.CurrentRow.Cells.Item(4).Value.ToString
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ''Tengo que validar
        'Que no hayan vacios
        If TxtNombre.TextLength <> 0 And TxtApellidos.TextLength <> 0 And TxtRut.TextLength <> 0 And TxtDV.TextLength <> 0 And TxtCorreo.TextLength <> 0 Then
            ''Objeto
            Dim empleado As New Empleado
            'Validar Rut
            If empleado.ValidarRut(TxtRut.Text, TxtDV.Text) Then
                empleado.ID = LblID.Text
                empleado.Nombre = TxtNombre.Text
                empleado.Apellidos = TxtApellidos.Text
                empleado.Rut = TxtRut.Text
                empleado.Email = TxtCorreo.Text
                ''Modificar
                Dim bsn As New BsnEmpleado
                bsn.UpdateEmpleados(empleado)
                'Limpiar
                Limpiar()
                Bloquear()
                'actualizar dgv
                ''cargar dvg
                Dim dataset As New DataSet
                dataset = bsn.GetEmpleados
                DgvEmpleados.DataSource = dataset.Tables(0)



            Else
                MsgBox("El rut ingresado no es correcto")
            End If




        Else
            MsgBox("Complete todos los campos")
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim id = DgvEmpleados.CurrentRow.Cells.Item(0).Value

        Dim button As String = MsgBox("¿Esta seguro de eliminar?", 4)
        If button = 6 Then
            ''eliminar
            Dim bsn As New BsnEmpleado
            bsn.DeleteEmpleado(id)
            ''cargar dvg
            Dim dataset As New DataSet
            dataset = bsn.GetEmpleados
            DgvEmpleados.DataSource = dataset.Tables(0)

        End If
        Bloquear()

    End Sub
    Private Sub EstablecerLargo()
        TxtNombre.MaxLength = 30
        TxtApellidos.MaxLength = 30
        TxtRut.MaxLength = 8
        TxtDV.MaxLength = 1
        TxtCorreo.MaxLength = 20
    End Sub
    Private Sub TxtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRut.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar)
    End Sub

End Class