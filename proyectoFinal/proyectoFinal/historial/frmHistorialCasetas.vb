Public Class frmHistorialCasetas
    Private Sub frmHistorialCasetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oCaseta As New Caseta()
        Dim elements As New List(Of String) From {"id", "descripcion", "nombre_persona", "fecha_hora"}
        oCaseta.listarElementos(oCaseta.historial(), elements, lvwHistorialCasetas)

        oCaseta.historial().Close()
    End Sub
End Class