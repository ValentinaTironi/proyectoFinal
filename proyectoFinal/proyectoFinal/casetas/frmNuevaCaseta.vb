Public Class frmNuevaCaseta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MsgBox("Se ha agregado la caseta con éxito!")
        If CheckEmptyTextBox(Me) Then
            MsgBox("Hay campos vacios, por favor, completelos.")
        Else
            Dim result As Integer = MsgBox("¿Estas seguro que desea agregar esta caseta?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                ClearInputs(Me)
            ElseIf result = DialogResult.Yes Then
                Dim tamanio As String
                Dim raspberry As Integer
                raspberry = Convert.ToInt32(cbxRaspberry.SelectedValue)
                tamanio = Trim(txtTamanio.Text)

                Dim caseta As New Caseta(tamanio, raspberry)

                If caseta.insertar() > 0 Then
                    MsgBox("Se guardó la caseta con éxito")
                    caseta.ver(caseta.getLastId, frmCaseta)
                    openForm(frmCaseta)
                Else
                    MsgBox("No se pudo guardar la caseta", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmCasetas)
    End Sub

    Private Sub frmNuevaCaseta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caseta As New Caseta
        caseta.getDataSource(cbxRaspberry, "raspberries", "nombre", "id", True, "casetas", "id_raspberrypi")
    End Sub
End Class