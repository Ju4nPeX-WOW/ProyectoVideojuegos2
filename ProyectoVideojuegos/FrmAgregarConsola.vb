Public Class FrmAgregarConsola
    Dim BsnConsole As New BsnConsole
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
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
            'Insertar en BD
            Dim Consola As New Consola()
            Consola.NameConsole = TextBox1.Text
            Consola.Marca = TextBox2.Text
            Consola.Descripcion = TextBox3.Text

            BsnConsole.AgregarConsola(Consola)

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If

    End Sub
End Class