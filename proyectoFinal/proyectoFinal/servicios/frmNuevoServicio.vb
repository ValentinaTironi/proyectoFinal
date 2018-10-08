Public Class frmNuevoServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckEmptyTextBox(Me) Then
            MsgBox("Hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea agregar este servicio?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim nombre, descripcion As String
                Dim num_casetas As Integer
                Dim precio As Double

                nombre = Trim(txtNombre.Text)
                precio = Convert.ToDouble(txtPrecio.Text)
                descripcion = Trim(txtDescripcion.Text)
                num_casetas = Convert.ToInt32(txtNumCasetas.Text)

                Dim servicio As New Servicio(nombre, num_casetas, precio, descripcion)

                If servicio.insertar() > 0 Then
                    MsgBox("Se guardó el servicio '" & servicio.Nombre & "' con éxito")
                    servicio.ver(servicio.getLastId(), frmServicio)
                    openForm(frmServicio)
                Else
                    MsgBox("No se pudo guardar el servicio " & nombre, MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmServicios)
    End Sub

End Class