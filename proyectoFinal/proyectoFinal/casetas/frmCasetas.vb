Public Class frmCasetas

    Private Sub lvwCasetas_DoubleClick(sender As Object, e As EventArgs) Handles lvwCasetas.DoubleClick
        openForm(frmCaseta)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevaCaseta)
    End Sub
End Class