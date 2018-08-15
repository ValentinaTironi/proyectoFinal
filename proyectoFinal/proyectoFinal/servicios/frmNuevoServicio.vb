Public Class frmNuevoServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox("¿Estas seguro que desea agregar este servicio?", MsgBoxStyle.YesNo)
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmServicios)
    End Sub
End Class