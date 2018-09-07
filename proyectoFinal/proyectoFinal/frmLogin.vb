Public Class frmLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim user, password As String
        user = Trim(txtUsername.Text())
        password = Trim(txtPassword.Text())

        Dim usuario As New Usuario()

        'Que los campos no esten vacíos
        If user = "" Then
            MsgBox("Debes ingresar un usuario", MsgBoxStyle.Exclamation, "Error")
        ElseIf password = "" Then
            MsgBox("Debes ingresar la contraseña", MsgBoxStyle.Exclamation, "Error")
        ElseIf Not usuario.login(user, password) Then
            'Que el usuario y la password sean válidos
            MsgBox("User y/o contraseña incorreta", MsgBoxStyle.Exclamation, "Error")
        Else
            MsgBox("Bienvenide " + usuario.nombre_completo)
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
