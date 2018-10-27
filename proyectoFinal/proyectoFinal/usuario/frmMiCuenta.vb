Public Class frmMiCuenta
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim empleado As New Empleado()

        Dim id As String = lblid.Text
        frmEditarUsuario.lblid.Text = id
        empleado.editar(id, frmEditarUsuario)
        openForm(frmEditarUsuario)
    End Sub
End Class