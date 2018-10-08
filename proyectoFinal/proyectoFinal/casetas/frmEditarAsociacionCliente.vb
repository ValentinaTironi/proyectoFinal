Public Class frmEditarAsociacionCliente
    Private Sub EditarAsociacionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caseta As New Caseta
        caseta.getDataSource(cbxCasetas, "casetas", "id", "id")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As String = MsgBox("Se le asociará una nueva caseta al cliente y se borrará la anterior, ¿Es correcto?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Dim id_caseta As String = cbxCasetas.SelectedValue
            Dim id_cliente As String = lblid_cliente.Text
            Dim id_perro As String = lblid_perro.Text
            Dim id_caseta_vieja As String = lblcaseta_vieja.Text

            Dim perro As New Perro(id_caseta)
            perro.guardarEdiciones(id_perro, id_cliente)

            Dim caseta As New Caseta
            caseta.borrar(id_caseta_vieja)
        End If
        openForm(frmCasetas)
    End Sub
End Class