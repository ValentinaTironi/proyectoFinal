Public Class frmServicio
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmServicios)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim servicio As New Servicio
        Dim id As String = lblid.Text
        frmEditarServicio.lblid.Text = id
        servicio.editar(id, frmEditarServicio)
        openForm(frmEditarServicio)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer = MsgBox("¿Estas seguro que desea borrar este servicio?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Dim servicio As New Servicio
            Dim pk_value As String = lblid.Text

            servicio.borrar(pk_value)
            openForm(frmServicios)
        End If

    End Sub
End Class