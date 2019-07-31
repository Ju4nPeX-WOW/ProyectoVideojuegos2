Public Class FrmListarConsola

    Dim dataset As New DataSet()
    Dim BsnConsole As New BsnConsole()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmListarConsola_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataset = BsnConsole.obtenerConsolas
        If (dataset.Tables(0).Rows.Count > 0) Then
            dgvConsolas.DataSource = dataset.Tables(0).DefaultView
        End If

    End Sub
End Class