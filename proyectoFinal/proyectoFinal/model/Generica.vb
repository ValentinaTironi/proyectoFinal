Imports System.Data.SqlClient

Public Class Generica
    ' Public: acceso desde cualquier lugar 
    ' Protected: acceso en clase e hijas
    ' Private: solo acceso en la clase 
    Protected _nombre_tabla As String


    Public Overridable Function obtenerListado() As SqlDataReader
        Return DBConn.Instance().SelectStatement("SELECT * FROM " + _nombre_tabla)
    End Function

    Public Sub listarElementos(sqlResult As SqlDataReader, elements As List(Of String), lvw As ListView)
        If sqlResult.HasRows() Then
            lvw.Items.Clear()

            While sqlResult.Read
                Dim lvItem As ListViewItem = lvw.Items.Add(sqlResult(elements(0)).ToString)

                lvItem.SubItems.Add(sqlResult(elements(1)).ToString)
                lvItem.SubItems.Add(sqlResult(elements(2)).ToString)
                lvItem.SubItems.Add(sqlResult(elements(3)).ToString)
                lvItem.SubItems.Add(sqlResult(elements(4)).ToString)
            End While
        End If

        sqlResult.Close()
    End Sub
End Class
