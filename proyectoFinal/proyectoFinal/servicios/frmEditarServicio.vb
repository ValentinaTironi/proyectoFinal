Public Class frmEditarServicio
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox("¿Estas seguro que quieres guardar estos cambios?")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim id As String = lblid.Text
        'openForm(frmServicio)
        Dim servicio As New Servicio
        servicio.ver(id, frmServicio)
        openForm(frmServicio)
    End Sub

End Class