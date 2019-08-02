Public Class FrmListarVenta
    Private Sub FrmListarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargar ventas
        Dim bsn As New BsnVenta
        Dim dataset As New DataSet
        dataset = bsn.GetVentas()
        DgvVentas.DataSource = dataset.Tables(0)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class