Public Class Login
    Dim BsnUser As New BsnUser()
    Dim dataset As New DataSet()
    Dim User As New User()
    Dim conexion As New Conexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User.UserName = TextBox1.Text          'Seteamos el objeto usuario>atributo username con el textbox1.text
        User.Password = TextBox2.Text          'Seteamos el objeto usuario>atributo password con el textbox2.text
        dataset = BsnUser.obtenerUsuario(User) 'Pasamos como parametro el objeto usuario

        If Not (dataset.Tables(0).Rows.Count > 0) Then
            MsgBox("Usuario no registrado o no existe", vbCritical, "Error")
        Else
            Me.Hide()
            FrmMenu.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
