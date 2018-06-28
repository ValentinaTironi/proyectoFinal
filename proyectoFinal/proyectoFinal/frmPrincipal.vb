Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hace un click a el boton de Dashboard al cargar el form principal
        mnuItemDashboard.PerformClick()
    End Sub

    Private Sub btnMiCuenta_Click(sender As Object, e As EventArgs) Handles btnMiCuenta.Click
        frmMiCuenta.MdiParent = Me

        closeForms()
        frmMiCuenta.Dock = DockStyle.Fill
        frmMiCuenta.Show()
    End Sub

    Private Sub mnuItemDashboard_Click(sender As Object, e As EventArgs) Handles mnuItemDashboard.Click
        frmDashboard.MdiParent = Me

        closeForms()
        frmDashboard.Dock = DockStyle.Fill
        frmDashboard.Show()
    End Sub

    'Funciones propias
    Private Function closeForms()
        'Cierra todos las ventanas abiertas expecto el actual
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
    End Function

End Class
