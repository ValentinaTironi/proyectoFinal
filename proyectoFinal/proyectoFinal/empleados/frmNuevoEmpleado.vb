Public Class frmNuevoEmpleado
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmEmpleados)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckEmptyTextBox(Me) Then
            MsgBox("hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea agregar este empleado?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim nombre_completo, cedula, username, password, email, numero_cuenta, direccion As String
                Dim admin As Boolean
                Dim id_rol As Integer

                nombre_completo = Trim(txtnombre_completo.Text)
                cedula = Trim(txtcedula.Text)
                username = Trim(txtusername.Text)
                password = Trim(txtpassword.Text)
                email = Trim(txtemail.Text)
                numero_cuenta = Trim(txtnumero_cuenta_bancaria.Text)
                direccion = Trim(txtdireccion.Text)
                id_rol = Trim(txtroles.SelectedValue)
                admin = txtadmin.Checked

                Dim empleado As New Empleado(admin, cedula, nombre_completo, username, password, email, numero_cuenta, direccion)

                If empleado.insertar() > 0 Then
                    MsgBox("Se guardó el empleado " & empleado.Nombre_completo & " con éxito")
                    Dim rol_empleado As New RolEmpleado(empleado.getLastId(), id_rol)
                    rol_empleado.insertar()
                    empleado.ver(empleado.Id, frmCliente)
                Else
                    MsgBox("No se pudo guardar el cliente " & nombre_completo, MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub frmNuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Empleado
        empleado.getDataSource(txtroles, "roles", "nombre", "id")
    End Sub
End Class