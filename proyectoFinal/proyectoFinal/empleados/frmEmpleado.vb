Public Class frmEmpleado
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmEmpleados)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        openForm(frmNuevoEmpleado)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MsgBox("¿Está usted seguro que desea borrar a este empleado?", MsgBoxStyle.OkCancel)
    End Sub
End Class