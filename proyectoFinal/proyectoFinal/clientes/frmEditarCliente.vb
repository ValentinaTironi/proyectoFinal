Public Class frmEditarCliente
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If CheckEmptyTextBox(Me) Then
            MsgBox("hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿estas seguro que desea guardar este cliente?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim nombre_completo, cedula, email, numero_cuenta, direccion, id_servicio, id_caseta As String
                Dim id As Integer = Convert.ToInt32(lblid.Text)

                nombre_completo = Trim(txtnombre_completo.Text)
                cedula = Trim(txtcedula.Text)
                email = Trim(txtemail.Text)
                numero_cuenta = Trim(txtnumero_cuenta_bancaria.Text)
                direccion = Trim(txtdireccion.Text)
                id_servicio = Trim(txtid_servicio.Text)
                id_caseta = Trim(txtid_caseta.Text)

                Dim cliente As New Cliente(id, "true", "1", "9-10-2018", cedula, nombre_completo, email, numero_cuenta, direccion)

                If cliente.guardarEdicion(cliente.Id) > 0 Then
                    MsgBox("se guardó el cliente '" & cliente.Nombre_completo & "' con éxito")
                    cliente.ver(cliente.Id, frmCliente)
                Else
                    MsgBox("no se pudo guardar el cliente " & nombre_completo, MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim id As String = lblid.Text
        Dim cliente As New Cliente
        cliente.ver(id, frmCliente)
        openForm(frmCliente)
    End Sub
End Class