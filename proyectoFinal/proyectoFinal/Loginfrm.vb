Public Class Loginfrm

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim user, password As String
        user = Trim(txtUsername.Text())
        password = Trim(txtPassword.Text())

        'Que los campos no esten vac�os
        If user = "" Then
            MsgBox("Debes ingresar un usuario", MsgBoxStyle.Exclamation, "Error")
        ElseIf password = "" Then
            MsgBox("Debes ingresar la contrase�a", MsgBoxStyle.Exclamation, "Error")
        ElseIf Not Login(user, password) Then
            'Que el usuario y la password sean v�lidos
            MsgBox("User y/o contrase�a incorreta", MsgBoxStyle.Exclamation, "Error")
        Else
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function Login(user As String, password As String) As Boolean
        Return user = "valentina" And password = "password"
    End Function
End Class
