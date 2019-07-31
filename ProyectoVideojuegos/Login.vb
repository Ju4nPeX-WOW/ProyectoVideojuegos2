Public Class Login
    Dim BsnUser As New BsnUser()
    Dim dataset As New DataSet()
    Dim User As New User()
    Dim conexion As New Conexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User.UserName = TextBox1.Text
        User.Password = TextBox2.Text

        dataset = BsnUser.obtenerUsuario(User)

        If Not (dataset.Tables(0).Rows.Count > 0) Then
            MsgBox("Usuario no registrado o no existe")
        Else
            MsgBox("adelante")
            Me.Hide()
            FrmMenu.Show()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
