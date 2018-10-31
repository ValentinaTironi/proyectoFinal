Public Class frmEditarEmpleado
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If CheckEmptyTextBox(Me) Then
            MsgBox("Hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea guardar este empleado?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim nombre_completo, cedula, username, password, email, numero_cuenta, direccion, fecha_nacimiento As String
                Dim admin As Boolean
                Dim id_rol, id As Integer

                id = Convert.ToInt32(lblid.Text)
                nombre_completo = Trim(txtnombre_completo.Text)
                cedula = Trim(txtcedula.Text)
                username = Trim(txtusername.Text)
                password = Trim(txtpassword.Text)
                email = Trim(txtemail.Text)
                numero_cuenta = Trim(txtnumero_cuenta_bancaria.Text)
                direccion = Trim(txtdireccion.Text)
                id_rol = Trim(txtrol.SelectedValue)
                fecha_nacimiento = Trim(txtfecha_nacimiento.Text)
                admin = txtadmin.Checked

                Dim empleado As New Empleado(id, admin, cedula, nombre_completo, username, password, email, numero_cuenta, direccion, fecha_nacimiento)

                If empleado.guardarEdicion(id) > 0 Then
                    MsgBox("Se guardó el empleado " & empleado.Nombre_completo & " con éxito")
                    Dim rol_empleado As New RolEmpleado(id, id_rol)
                    rol_empleado.guardarEdiciones()
                    empleado.ver(id, frmEmpleado)
                    openForm(frmEmpleado)
                Else
                    MsgBox("No se pudo guardar el cliente " & nombre_completo, MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub frmEditarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Empleado
        empleado.getDataSource(txtrol, "roles", "nombre", "id", False, "", "")
    End Sub
End Class