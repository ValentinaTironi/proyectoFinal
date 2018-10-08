Public Class frmNuevoCliente
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmClientes)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If CheckEmptyTextBox(Me) Then
            MsgBox("hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea agregar este cliente?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim nombre_completo, cedula, username, password, email, numero_cuenta, direccion, id_servicio, id_caseta As String

                nombre_completo = Trim(txtnombre_completo.Text)
                cedula = Trim(txtcedula.Text)
                username = Trim(txtusername.Text)
                password = Trim(txtpassword.Text)
                email = Trim(txtemail.Text)
                numero_cuenta = Trim(txtnumero_cuenta_bancaria.Text)
                direccion = Trim(txtdireccion.Text)
                id_servicio = Trim(txtid_servicio.SelectedValue)
                id_caseta = Trim(txtid_caseta.SelectedValue)

                Dim cliente As New Cliente("true", "1", "9-10-2018", cedula, nombre_completo, username, password, email, numero_cuenta, direccion)

                If cliente.insertar() > 0 Then
                    MsgBox("Se guardó el cliente " & cliente.Nombre_completo & " con éxito")
                    Dim contrato As New Contrato(cliente.getLastId(), id_servicio, "reglamentado", 3)
                    If contrato.insertar() > 0 Then
                        MsgBox("Se generó el contrato para el cliente " & cliente.Nombre_completo & " con éxito")
                        Dim perro As New Perro(cliente.getLastId(), id_caseta)
                        perro.insertar()
                    Else
                        MsgBox("No se pudo generar el contrato para el cliente " & nombre_completo, MsgBoxStyle.OkOnly)
                    End If
                    cliente.ver(cliente.getLastId(), frmCliente)
                Else
                    MsgBox("No se pudo guardar el cliente " & nombre_completo, MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente As New Cliente
        cliente.getDataSource(txtid_servicio, "servicios", "nombre", "id")
        cliente.getDataSource(txtid_caseta, "casetas", "id", "id")
    End Sub
End Class