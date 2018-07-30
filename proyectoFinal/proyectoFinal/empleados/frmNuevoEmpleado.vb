Public Class frmNuevoEmpleado
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmEmpleados)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox("Se ha agregado un nuevo empleado!", MsgBoxStyle.Information)
    End Sub
End Class