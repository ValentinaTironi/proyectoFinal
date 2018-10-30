Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oCliente As New Cliente()

        Dim elements As New List(Of String) From {"id", "nombre_completo", "email", "username", "cedula"}

        oCliente.listarElementos(oCliente.ultimosCincoClientes(), elements, lvwUltimosClientes)

        oCliente.ultimosCincoClientes().Close()
    End Sub
End Class