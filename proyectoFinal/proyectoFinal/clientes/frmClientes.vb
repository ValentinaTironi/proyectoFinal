Imports System.Data.SqlClient

Public Class frmClientes
    Private Sub lvwClientes_DoubleClick(sender As Object, e As EventArgs) Handles lvwClientes.DoubleClick
        openForm(frmCliente)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevoCliente)
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oCliente As New Cliente()

        Dim elements As New List(Of String) From {"id", "nombre_completo", "email", "username", "cedula"}

        oCliente.listarElementos(oCliente.allElements(), elements, lvwClientes)

        oCliente.allElements().Close()
    End Sub
End Class