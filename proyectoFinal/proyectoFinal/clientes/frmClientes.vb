Public Class frmClientes
    Private Sub lvwClientes_DoubleClick(sender As Object, e As EventArgs) Handles lvwClientes.DoubleClick
        openForm(frmCliente)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevoCliente)
    End Sub
End Class