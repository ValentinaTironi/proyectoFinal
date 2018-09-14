Public Class frmEmpleados
    Private Sub lvwEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles lvwEmpleados.DoubleClick
        openForm(frmEmpleado)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevoEmpleado)
    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEmpleado As Empleado = New Empleado

        Dim elements As New List(Of String) From {"id", "nombre_completo", "email", "username", "admin"}

        oEmpleado.listarElementos(oEmpleado.allElements(), elements, lvwEmpleados)

        oEmpleado.allElements().Close()
    End Sub
End Class