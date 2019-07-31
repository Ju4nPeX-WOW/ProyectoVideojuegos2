Public Class BsnUser
    Dim DaoUser As New DaoUser()

    Dim columnas As String
    Dim condicion As String
    Public Function obtenerUsuario(User As User)
        columnas = "user,password"
        condicion = " WHERE User= '" & User.UserName & "' AND Password='" & User.Password & "'"
        Return DaoUser.obtenerUsuario(columnas, condicion)
    End Function




End Class
