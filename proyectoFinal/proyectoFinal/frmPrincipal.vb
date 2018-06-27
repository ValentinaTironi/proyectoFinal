Public Class frmPrincipal
    Private Sub MiCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiCuentaToolStripMenuItem.Click
        frmMiCuenta.MdiParent = Me

        frmMiCuenta.Show()
    End Sub

    Private Sub btnMiCuenta_Click(sender As Object, e As EventArgs) Handles btnMiCuenta.Click
        Dim formularito As New frmMiCuenta()

        formularito.MdiParent = Me

        formularito.Show()
    End Sub
End Class
