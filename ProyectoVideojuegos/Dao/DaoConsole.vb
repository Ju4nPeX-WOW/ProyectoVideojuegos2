Public Class DaoConsole

    Dim Instrucciones As New Instrucciones
    Dim tabla As String = "Console"

    Public Function obtenerConsolas()
        Return Instrucciones.Seleccionar("Console", "*", "")
    End Function

    Public Sub AgregarConsola(columnas, valores)
        Instrucciones.Insertar(tabla, columnas, valores)
    End Sub

    Public Sub ModificarConsola(colvalor, id)
        Instrucciones.Modificar(tabla, colvalor, id)
    End Sub

    Public Sub EliminarConsola(condicion)
        Instrucciones.Eliminar(tabla, condicion)
    End Sub
End Class
