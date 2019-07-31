Public Class FrmModificarConsola
    Dim dataset As New DataSet
    Dim BsnConsole As New BsnConsole
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



    Private Sub FrmModificarConsola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataset = BsnConsole.obtenerConsolas
        If (dataset.Tables(0).Rows.Count > 0) Then
            dgvConsolas.DataSource = dataset.Tables(0).DefaultView
        End If
    End Sub


    Private Sub dgvConsolas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvConsolas.SelectionChanged

        lblIdConsola.Text = dgvConsolas.CurrentRow.Cells(0).Value
        TextBox1.Text = dgvConsolas.CurrentRow.Cells(1).Value
        TextBox2.Text = dgvConsolas.CurrentRow.Cells(2).Value
        TextBox3.Text = dgvConsolas.CurrentRow.Cells(3).Value



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pal As String = ""
        Dim validado As Boolean = True
        Dim contador As Byte = 0

        If TextBox1.Text = "" Then
            validado = False
            contador = contador + 1
            pal = pal & contador & "-Agregue una Consola" & vbCr
        End If
        If TextBox2.Text = "" Then
            validado = False
            contador = contador + 1
            pal = pal & contador & "-Agregue una Marca" & vbCr
        End If
        If TextBox3.Text = "" Then
            validado = False
            contador = contador + 1
            pal = pal & contador & "-Agregue una Descripcion" & vbCr
        End If

        'Validacion si existe algun campo vacio
        If Not (validado) Then
            MsgBox(pal, vbCritical, "Existen campos vacios")
        Else
            'Modificar en BD
            Dim Consola As New Consola()
            Consola.Id = lblIdConsola.Text
            Consola.NameConsole = TextBox1.Text
            Consola.Marca = TextBox2.Text
            Consola.Descripcion = TextBox3.Text

            BsnConsole.ModificarConsola(Consola)
            MsgBox("Consola modificada", vbInformation, "Realizado correctamente")

            dataset = BsnConsole.obtenerConsolas
            If (dataset.Tables(0).Rows.Count > 0) Then
                dgvConsolas.DataSource = dataset.Tables(0).DefaultView
            End If
        End If
    End Sub
End Class