Imports System.Data
Imports System.Data.OleDb
Public Class daoJuego
    Protected conexion As New Conexion()
    Public Function CargarJuegos()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "select * from Juego"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function
    Public Function AgregarJuegos(juego As Juego)
        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "Insert into Juego (nombre,descripción,precio,id_categoria) values ('" & juego.Nombre & "','" & juego.Descripcion & "'," & juego.Precio & "," & juego.IdCategoria & ")"
        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return juego
    End Function
    Public Function EliminarJuegos(id As Integer)
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "delete from Juego where Id_juego =" & id
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset
    End Function
    Public Function EditarJuegos(id As Integer, juego As Juego)
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "update Juego set nombre = '" & juego.Nombre & "', descripción = '" & juego.Descripcion & "', precio =" & juego.Precio & ", id_categoria =" & juego.IdCategoria & " where Id_juego =" & id
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset

    End Function
    Public Function GetCategorias()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "select * from Categoria"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset
    End Function
End Class
