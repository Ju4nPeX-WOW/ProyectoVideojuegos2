
Imports System.Data.OleDb
Public Class daoJuego
    Dim instrucciones As New Instrucciones
    Dim tabla As String = "Juego"
    Public Function CargarJuegos()
        Return instrucciones.Seleccionar(tabla, "*", "")
    End Function
    Public Function GetCategorias()
        Return instrucciones.Seleccionar("Categoria", "*", "")
    End Function
    Public Sub AgregarJuegos(columnas, valores)
        instrucciones.Insertar(tabla, columnas, valores)
    End Sub
    Public Sub EliminarJuegos(condicion As String)
        instrucciones.Eliminar(tabla, condicion)
    End Sub
    Public Sub EditarJuegos(colvalor, condicion)
        instrucciones.Modificar(tabla, colvalor, condicion)
    End Sub
    Public Function ObtenerJuego(id As String)
        Return instrucciones.Seleccionar("Juego", "*", "WHERE Id_juego = " & id)
    End Function
End Class
