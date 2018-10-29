Public Class frmEditarServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckEmptyTextBox(Me) Then
            MsgBox("Hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea agregar este servicio?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim nombre, descripcion, id As String
                Dim num_casetas As Integer
                Dim precio As Double

                id = Trim(lblid.Text)
                nombre = Trim(txtnombre.Text)
                precio = Convert.ToDouble(txtprecio.Text)
                descripcion = Trim(txtdescripcion.Text)
                num_casetas = Convert.ToInt32(txtcantidad_casetas.Text)

                Dim servicio As New Servicio(nombre, num_casetas, precio, descripcion)

                If servicio.guardarEdicion(id) > 0 Then
                    MsgBox("Se editó el servicio '" & servicio.Nombre & "' con éxito")
                    servicio.ver(id, frmServicio)
                Else
                    MsgBox("No se pudo guardar el servicio " & nombre, MsgBoxStyle.OkOnly)
                End If
                servicio.ver(id, frmServicio)
                openForm(frmServicio)
            End If
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim id As String = lblid.Text
        Dim servicio As New Servicio
        servicio.ver(id, frmServicio)
        openForm(frmServicio)
    End Sub

End Class