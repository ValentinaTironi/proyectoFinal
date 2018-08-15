Public Class frmEditarUsuario
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmMiCuenta)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MsgBox("¿Está seguro que quiere guardar los cambios?")
    End Sub
End Class