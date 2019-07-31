Public Class FrmEliminarConsola

    Dim dataset As New DataSet
    Dim BsnConsole As New BsnConsole
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmEliminarConsola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataset = BsnConsole.obtenerConsolas
        If (dataset.Tables(0).Rows.Count > 0) Then
            dgvConsolas.DataSource = dataset.Tables(0).DefaultView
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvConsolas.CurrentRow.Index > -1 Then

            Dim response = MsgBox("¿Esta seguro de eliminar?", vbYesNo, "Eliminando " & dgvConsolas.CurrentRow.Cells(1).Value)
            If response = 6 Then
                Dim Consola As New Consola()
                Consola.Id = dgvConsolas.CurrentRow.Cells(0).Value
                BsnConsole.EliminarConsola(Consola)

                'F5 de dgv
                MsgBox("Consola Eliminada", vbInformation, "Realizado correctamente")
                dataset = BsnConsole.obtenerConsolas
                If (dataset.Tables(0).Rows.Count > 0) Then
                    dgvConsolas.DataSource = dataset.Tables(0).DefaultView
                End If
            End If
        End If
    End Sub
End Class