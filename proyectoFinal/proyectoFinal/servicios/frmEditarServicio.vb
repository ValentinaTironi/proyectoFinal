Public Class frmEditarServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox("¿Estas seguro que quieres guardar estos cambios?")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmServicio)
    End Sub
End Class