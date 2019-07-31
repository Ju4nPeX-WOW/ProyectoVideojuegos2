Public Class BsnEmpleado

    Public Function GetEmpleados()
        Dim dao As New DaoEmpleado
        Dim dataset As New DataSet
        dataset = dao.GetEmpleados()
        Return dataset
    End Function

    Public Sub UpdateEmpleados(ob As Empleado)
        Dim dao As New DaoEmpleado
        dao.UpdateEmpleados(ob)
    End Sub

    Public Sub DeleteEmpleado(id As Short)
        Dim dao As New DaoEmpleado
        dao.DeleteEmpleado(id)
    End Sub

    Public Sub AgregarEmpleado(ob As Empleado)
        Dim dao As New DaoEmpleado
        dao.InsertEmpleado(ob)
    End Sub




End Class
