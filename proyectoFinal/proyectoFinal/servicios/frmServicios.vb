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

        Dim sqlResult As SqlDataReader = oServicio.obtenerListado()

        If sqlResult.HasRows() Then
            lvwServicios.Items.Clear()

            While sqlResult.Read
                Dim lvItem As ListViewItem = lvwServicios.Items.Add(sqlResult("id").ToString)

                lvItem.SubItems.Add(sqlResult("nombre").ToString)
                lvItem.SubItems.Add(sqlResult("cantidad_casetas").ToString)
                lvItem.SubItems.Add(sqlResult("precio").ToString)
            End While
        End If
        sqlResult.Close()
    End Sub
End Class