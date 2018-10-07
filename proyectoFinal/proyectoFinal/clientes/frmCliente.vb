Public Class frmCliente
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmClientes)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer = MsgBox("¿Estas seguro que desea borrar este cliente?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Dim cliente As New Cliente
            Dim pk_value As String = lblid.Text

            cliente.borrar(pk_value)
            openForm(frmClientes)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cliente As New Cliente()

        Dim id As String = lblid.Text
        frmEditarCliente.lblid.Text = id
        cliente.editar(id, frmEditarCliente)
        openForm(frmEditarCliente)
    End Sub
End Class