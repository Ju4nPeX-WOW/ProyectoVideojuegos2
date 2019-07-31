Public Class FrmMenu
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadosToolStripMenuItem.Click
        Dim form As New FrmAgregarEmpleado
        form.ShowDialog()
    End Sub

    Private Sub ListarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarEmpleadosToolStripMenuItem.Click
        Dim form As New FrmListarEmpleados
        form.ShowDialog()
    End Sub

    Private Sub AgregarConsolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarConsolToolStripMenuItem.Click
        FrmAgregarConsola.ShowDialog()
    End Sub

    Private Sub ModificarConsolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarConsolaToolStripMenuItem.Click
        FrmModificarConsola.ShowDialog()
    End Sub

    Private Sub ListarConsolasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarConsolasToolStripMenuItem.Click
        FrmListarConsola.ShowDialog()
    End Sub

    Private Sub EliminarConsolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarConsolaToolStripMenuItem.Click
        FrmEliminarConsola.ShowDialog()
    End Sub
End Class