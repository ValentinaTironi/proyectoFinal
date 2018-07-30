Public Class frmEmpleados
    Private Sub lvwEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles lvwEmpleados.DoubleClick
        openForm(frmEmpleado)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevoEmpleado)
    End Sub
End Class