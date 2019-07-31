Imports System.Data.OleDb

Public Class Conexion
    Protected conexion As New OleDbConnection
    Protected stringConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/VideojuegosDatabase.accdb"



    Public Sub AbrirConexion()
        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            Console.WriteLine("Conexion exitosa")
        Catch ex As Exception
            Console.WriteLine("conexion no exitosa")
        End Try


    End Sub

    Public Sub CerrarConexion()
        conexion.Close()

    End Sub

    Public Function GetConexion()
        conexion.ConnectionString = stringConexion
        Return conexion
    End Function





End Class


