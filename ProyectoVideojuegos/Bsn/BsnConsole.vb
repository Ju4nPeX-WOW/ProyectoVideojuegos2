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
        columnas = "Consola,Marca,Descripcion"
        valores = "'" & Console.NameConsole & "','" & Console.Marca & "','" & Console.Descripcion & "'"
        DaoConsole.AgregarConsola(columnas, valores)
    End Sub

    Public Sub ModificarConsola(Console As Consola)
        condicion = " Id=" & Console.Id
        colvalor = " Consola='" & Console.NameConsole & "', Marca='" & Console.Marca & "', Descripcion='" & Console.Descripcion & "'"
        DaoConsole.ModificarConsola(colvalor, condicion)
    End Sub

    Public Sub EliminarConsola(Console As Consola)
        condicion = " Id=" & Console.Id
        DaoConsole.EliminarConsola(condicion)
    End Sub


End Class
