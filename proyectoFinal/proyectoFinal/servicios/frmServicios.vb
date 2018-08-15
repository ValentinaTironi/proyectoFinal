Public Class frmServicios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevoServicio)
    End Sub

    Private Sub lvwAdministradores_DoubleClick(sender As Object, e As EventArgs) Handles lvwAdministradores.DoubleClick
        openForm(frmServicio)
    End Sub
End Class