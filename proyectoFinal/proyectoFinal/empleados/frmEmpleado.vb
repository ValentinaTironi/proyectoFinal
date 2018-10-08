Public Class frmEmpleado
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmEmpleados)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim empleado As New Empleado()

        Dim id As String = lblid.Text
        frmEditarEmpleado.lblid.Text = id
        empleado.editar(id, frmEditarEmpleado)
        openForm(frmEditarEmpleado)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer = MsgBox("¿Estas seguro que desea borrar este empleado?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Dim empleado As New Empleado
            Dim rol_empleado As New RolEmpleado
            Dim id_empleado As String = lblid.Text

            rol_empleado.borrar(id_empleado)
            empleado.borrar(id_empleado)
            openForm(frmEmpleados)
        End If
    End Sub
End Class