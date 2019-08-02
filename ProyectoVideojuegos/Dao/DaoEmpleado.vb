Public Class DaoEmpleado
    Private tabla As String = "Empleado"

    Public Function GetEmpleados()
        Dim instruccion As New Instrucciones
        Dim dataset As New DataSet
        dataset = instruccion.Seleccionar(tabla, "*", "")
        Return dataset
    End Function

    Public Sub UpdateEmpleados(ob As Empleado)
        ''Es posible que no inserte por  motivo de rut duplicado
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
        If BuscarEmpleado(ob.Rut) Then
            MsgBox("El empleado ya existe,no es posible volver a agregarlo")
        Else
            Dim instruccion As New Instrucciones
            Dim columnas = "Nombre,Apellidos,Rut,Email"
            Dim valores As String = "'" & ob.Nombre & "','" & ob.Apellidos & "'," & ob.Rut & ",'" & ob.Email & "'"
            If instruccion.Insertar(tabla, columnas, valores) Then
                MsgBox("Empleado Ingresado Correctamente")
            End If
        End If
    End Sub


    Private Function BuscarEmpleado(rut As String)
        Dim instruccion As New Instrucciones
        Dim dataset As New DataSet
        dataset = instruccion.Seleccionar(tabla, "*", " WHERE Rut =" & rut)
        Dim encontrado = False
        Try
            If dataset.Tables(0).Rows.Count <> 0 Then
                encontrado = True
            End If
        Catch ex As Exception
            encontrado = False

        End Try
        Return encontrado
    End Function
End Class
