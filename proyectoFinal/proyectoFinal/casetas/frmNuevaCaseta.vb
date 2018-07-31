Public Class frmNuevaCaseta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MsgBox("Se ha agregado la caseta con éxito!")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmCasetas)
    End Sub
End Class