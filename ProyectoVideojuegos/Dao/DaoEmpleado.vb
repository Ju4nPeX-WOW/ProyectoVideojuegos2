Public Class DaoEmpleado

    Public Function GetEmpleados()
        Dim instruccion As New Instrucciones
        Dim dataset As New DataSet
        dataset = instruccion.Seleccionar("Empleado", "*", "")
        Return dataset
    End Function

    Public Sub UpdateEmpleados(ob As Empleado)
        Dim instruccion As New Instrucciones
        Dim cv = "Nombre = '" & ob.Nombre & "', Apellidos = '" & ob.Apellidos & "', Rut = " & ob.Rut & ",Email = '" & ob.Email & "'"
        If instruccion.Modificar("Empleados", cv, "Id = " & ob.ID) Then
            MsgBox("Empleado Modificado Correctamente")
        End If
    End Sub

    Public Sub DeleteEmpleado(id As Short)
        Dim instruccion As New Instrucciones
        If instruccion.Eliminar("Empleados", "Id = " & id) Then
            MsgBox("Empleado Eliminado Correctamente")
        End If

    End Sub

    Public Sub InsertEmpleado(ob As Empleado)
        Dim instruccion As New Instrucciones
        Dim columnas = "Nombre,Apellidos,Rut,Email"
        Dim valores As String = "'" & ob.Nombre & "','" & ob.Apellidos & "'," & ob.Rut & ",'" & ob.Email & "'"
        If instruccion.Insertar("Empleados", columnas, valores) Then
            MsgBox("Empleado Ingresado Correctamente")
        End If
    End Sub

End Class
