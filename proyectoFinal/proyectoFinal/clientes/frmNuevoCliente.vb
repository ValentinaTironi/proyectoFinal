Public Class frmNuevoCliente
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmClientes)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MsgBox("Se ha agregado un nuevo cliente!", MsgBoxStyle.Information)
    End Sub
End Class