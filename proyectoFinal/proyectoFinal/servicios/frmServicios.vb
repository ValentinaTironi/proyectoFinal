Imports System.Data.SqlClient

Public Class frmServicios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevoServicio)
    End Sub

    Private Sub lvwAdministradores_DoubleClick(sender As Object, e As EventArgs) Handles lvwServicios.DoubleClick
        openForm(frmServicio)
    End Sub

    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oServicio As New Servicio()

        Dim elements As New List(Of String) From {"id", "nombre", "cantidad_casetas", "precio"}

        oServicio.listarElementos(oServicio.allElements(), elements, lvwServicios)

        oServicio.allElements().Close()
    End Sub
End Class