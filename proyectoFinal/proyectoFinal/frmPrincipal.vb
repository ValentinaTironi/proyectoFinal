Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hace un click a el boton de Dashboard al cargar el form principal
        mnuItemDashboard.PerformClick()
    End Sub

    Private Sub mnuItemMiCuenta_Click(sender As Object, e As EventArgs) Handles mnuItemMiCuenta.Click
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

    Private Sub mnuItemCerrarSesion_Click(sender As Object, e As EventArgs) Handles mnuItemCerrarSesion.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub mnuItemServicios_Click(sender As Object, e As EventArgs) Handles mnuItemServicios.Click
        openForm(frmServicios)
    End Sub

    Private Sub mnuItemHistorialCasetas_Click(sender As Object, e As EventArgs)
        openForm(frmHistorialCasetas)
    End Sub
End Class
