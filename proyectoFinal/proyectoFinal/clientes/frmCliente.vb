Public Class frmCliente
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmClientes)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        openForm(frmEditarCliente)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MsgBox("¿Está usted seguro que desea borrar a este cliente?", MsgBoxStyle.OkCancel)
    End Sub
End Class