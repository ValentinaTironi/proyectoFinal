Public Class frmNuevoServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckEmptyTextBox() Then
            MsgBox("Hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea agregar este servicio?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs()
            ElseIf result = DialogResult.Yes Then
                Dim nombre, descripcion As String
                Dim num_casetas As Integer
                Dim precio As Double

                nombre = Trim(txtNombre.Text)
                precio = Convert.ToDouble(txtPrecio.Text)
                descripcion = Trim(txtDescripcion.Text)
                num_casetas = Convert.ToInt16(txtNumCasetas.Text)

                Dim servicio As New Servicio(nombre, num_casetas, precio, descripcion)

                If servicio.Guardar() Then
                    MsgBox("Se guardó el servicio '" & servicio.Nombre & "' con éxito")
                    ClearInputs()
                Else
                    MsgBox("Hubo un error al guardar el servicio, inténtelo de nuevo")
                End If
            End If
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmServicios)
    End Sub

    Private Sub ClearInputs()
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Clear()
            End If
        Next
    End Sub

    Private Function CheckEmptyTextBox() As Boolean
        Dim ctrl As Control
        Dim empty As Boolean = False
        For Each ctrl In Me.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If txt.Text = "" Then
                    txt.BackColor = Color.LightGray
                    empty = True
                End If
            End If
        Next
        Return empty
    End Function
End Class