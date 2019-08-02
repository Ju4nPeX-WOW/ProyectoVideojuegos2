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

    Private Sub ListarJuegosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarJuegosToolStripMenuItem.Click
        Me.Hide()
        frmPrincipalJuego.Show()
    End Sub

    Private Sub AgregarJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarJuegoToolStripMenuItem.Click
        Me.Hide()
        frmAgregarJuego.Show()
    End Sub

    Private Sub ListarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarCategoriaToolStripMenuItem.Click
        Me.Hide()
        frmPrincipalCategorias.Show()
    End Sub

    Private Sub AgregarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCategoriaToolStripMenuItem.Click
        Me.Hide()
        frmAgregarCategoria.Show()
    End Sub

    Private Sub HacerVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HacerVentaToolStripMenuItem.Click
        Dim form As New FrmVenta
        form.ShowDialog()
    End Sub

    Private Sub ListarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVentasToolStripMenuItem.Click
        Dim form As New FrmListarVenta
        form.ShowDialog()
    End Sub
End Class