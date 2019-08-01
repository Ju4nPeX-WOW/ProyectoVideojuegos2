Imports System.Data
Imports System.Data.OleDb
Public Class daoCategoria
    Protected conexion As New Conexion()
    Public Function CargarCategorias()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = Conexion.GetConexion()

        Conexion.AbrirConexion()

        command.CommandText = "select * from Categoria"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        Conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function
    Public Function AgregarCategorias(categoria As Categoria)
        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "Insert into Categoria (Nombre) values ('" & categoria.Nombre & "')"
        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return categoria
    End Function
    Public Function EliminarCategorias(id As Integer)
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "delete from Categoria where Id_categoria =" & id
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset
    End Function
    Public Function EditarCategorias(id As Integer, nombre As String)
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "update Categoria set nombre = '" & nombre & "' where Id_categoria =" & id
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset

    End Function
End Class
