Public Class frmFormCliente
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmClientes)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox("Se ha agregado un nuevo cliente!", MsgBoxStyle.Information)
    End Sub
End Class