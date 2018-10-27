Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim user, password As String
        user = Trim(txtUsername.Text())
        password = Trim(txtPassword.Text())

        Dim usuario As New Empleado()

        'Que los campos no esten vacíos
        If user = "" Then
            MsgBox("Debes ingresar un usuario", MsgBoxStyle.Exclamation, "Error")
        ElseIf password = "" Then
            MsgBox("Debes ingresar la contraseña", MsgBoxStyle.Exclamation, "Error")
        ElseIf Not usuario.login(user, password) Then
            'Que el usuario y la password sean válidos
            MsgBox("User y/o contraseña incorreta", MsgBoxStyle.Exclamation, "Error")
        Else
            MsgBox("Bienvenide " + usuario.Nombre_completo)
            'frmPrincipal.lbluser_id.Text = id
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
