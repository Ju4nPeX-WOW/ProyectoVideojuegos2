Public Class DaoEmpleado
    Private tabla As String = "Empleado"

    Public Function GetEmpleados()
        Dim instruccion As New Instrucciones
        Dim dataset As New DataSet
        dataset = instruccion.Seleccionar(tabla, "*", "")
        Return dataset
    End Function

    Public Sub UpdateEmpleados(ob As Empleado)
        Dim instruccion As New Instrucciones
        Dim cv = "Nombre = '" & ob.Nombre & "', Apellidos = '" & ob.Apellidos & "', Rut = " & ob.Rut & ",Email = '" & ob.Email & "'"
        If instruccion.Modificar(tabla, cv, "Id = " & ob.ID) Then
            MsgBox("Empleado Modificado Correctamente")
        End If
    End Sub

    Public Sub DeleteEmpleado(id As Short)
        Dim instruccion As New Instrucciones
        If instruccion.Eliminar(tabla, "Id = " & id) Then
            MsgBox("Empleado Eliminado Correctamente")
        End If

    End Sub

    Public Sub InsertEmpleado(ob As Empleado)
        Dim instruccion As New Instrucciones
        Dim columnas = "Nombre,Apellidos,Rut,Email"
        Dim valores As String = "'" & ob.Nombre & "','" & ob.Apellidos & "'," & ob.Rut & ",'" & ob.Email & "'"
        If instruccion.Insertar(tabla, columnas, valores) Then
            MsgBox("Empleado Ingresado Correctamente")
        End If
    End Sub

End Class
