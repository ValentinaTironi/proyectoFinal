Public Class frmNuevoServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox("¿Estas seguro que desea agregar este servicio?", MsgBoxStyle.YesNo)

        Dim nombre, descripcion As String
        Dim num_casetas As Integer
        Dim precio As Double

        nombre = Trim(txtNombre.Text)
        precio = Convert.ToDouble(txtPrecio.Text)
        descripcion = Trim(txtDescripcion.Text)
        num_casetas = Convert.ToInt16(txtNumCasetas.Text)

        Dim servicio As New Servicio(nombre, num_casetas, precio, descripcion)

        servicio.Guardar()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmServicios)
    End Sub
End Class