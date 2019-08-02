Public Class BsnConsole

    Dim DaoConsole As New DaoConsole()
    Dim columnas As String
    Dim valores As String
    Dim colvalor As String
    Dim condicion As String

    Public Function obtenerConsolas()
        Return DaoConsole.obtenerConsolas()
    End Function

    Public Sub AgregarConsola(Console As Consola)
        columnas = "Consola,Categoria_Id,Descripcion,Precio"
        valores = "'" & Console.NameConsole & "'," & Console.Categoria & ",'" & Console.Descripcion & "'," & Console.Precio
        DaoConsole.AgregarConsola(columnas, valores)
    End Sub

    Public Sub ModificarConsola(Console As Consola)
        condicion = "Id=" & Console.Id
        colvalor = " Consola='" & Console.NameConsole & "', Categoria_Id=" & Console.Categoria & ", Descripcion='" & Console.Descripcion & "',Precio=" & Console.Precio
        DaoConsole.ModificarConsola(colvalor, condicion)
    End Sub

    Public Sub EliminarConsola(Console As Consola)
        condicion = " Id=" & Console.Id
        DaoConsole.EliminarConsola(condicion)
    End Sub


End Class
