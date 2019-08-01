Public Class FrmAgregarConsola
    Dim BsnConsole As New BsnConsole
    Dim BsnCategorias As New bsnCategoria
    Dim dt As New DataTable

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
        If TextBox3.Text = "" Then
            validado = False
            contador = contador + 1
            pal = pal & contador & "-Agregue una Descripcion" & vbCr
        End If
        If TextBox2.Text = "" Then
            validado = False
            contador = contador + 1
            pal = pal & contador & "-Agregue un precio" & vbCr
        End If



        'Validacion si existe algun campo vacio
        If Not (validado) Then
            MsgBox(pal, vbCritical, "Existen campos vacios")
        Else
            'Insertar en BD
            Dim Consola As New Consola()
            Consola.NameConsole = TextBox1.Text
            Consola.Categoria = ComboBox1.SelectedValue
            Consola.Descripcion = TextBox3.Text
            Consola.Precio = TextBox2.Text


            BsnConsole.AgregarConsola(Consola)
            MsgBox("Agregado correctamente")
            TextBox1.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub FrmAgregarConsola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = BsnCategorias.CargarCategorias()
        ComboBox1.DataSource = dt.DefaultView
        ComboBox1.ValueMember = "Id_categoria"
        ComboBox1.DisplayMember = "nombre"
    End Sub
End Class