Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hace un click a el boton de Dashboard al cargar el form principal
        mnuItemDashboard.PerformClick()
    End Sub

    Private Sub btnMiCuenta_Click(sender As Object, e As EventArgs) Handles btnMiCuenta.Click
        openForm(frmMiCuenta)
    End Sub

    Private Sub mnuItemDashboard_Click(sender As Object, e As EventArgs) Handles mnuItemDashboard.Click
        openForm(frmDashboard)
    End Sub

    Private Sub mnuItemEmpleados_Click(sender As Object, e As EventArgs) Handles mnuItemEmpleados.Click
        openForm(frmEmpleados)
    End Sub

    Private Sub mnuItemClientes_Click(sender As Object, e As EventArgs) Handles mnuItemClientes.Click
        openForm(frmClientes)
    End Sub

    Private Sub mnuItemCasetas_Click(sender As Object, e As EventArgs) Handles mnuItemCasetas.Click
        openForm(frmCasetas)
    End Sub

    Private Sub mnuItemHistorialClientes_Click(sender As Object, e As EventArgs) Handles mnuItemHistorialClientes.Click
        openForm(frmHistorialClientes)
    End Sub

    Private Sub mnuItemHistorialCasetas_Click(sender As Object, e As EventArgs) Handles mnuItemHistorialCasetas.Click
        openForm(frmHistorialCasetas)
    End Sub
End Class
