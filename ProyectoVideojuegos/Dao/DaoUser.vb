Public Class DaoUser
    Dim Instrucciones As New Instrucciones

    Dim tabla = "Users"

    Public Function obtenerUsuario(columnas As String, condicion As String)
        Return Instrucciones.Seleccionar(tabla, columnas, condicion)
    End Function




End Class
