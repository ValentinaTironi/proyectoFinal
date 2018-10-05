Imports System.Data.SqlClient
Imports System.Reflection

Public Class Generica
    Protected _nombre_tabla As String
    Protected _atributos_insert() As String

    Public Overridable Function allElements() As SqlDataReader
        Return DBConn.Instance().SelectStatement("SELECT * FROM " + _nombre_tabla)
    End Function

    Public Sub listarElementos(sqlResult As SqlDataReader, elements As List(Of String), lvw As ListView)
        If sqlResult.HasRows() Then
            lvw.Items.Clear()

            Dim first_element As String = elements.First()
            While sqlResult.Read
                Dim lvItem As ListViewItem = lvw.Items.Add(sqlResult(first_element).ToString)
                For Each element In elements
                    If element IsNot first_element Then
                        lvItem.SubItems.Add(sqlResult(element).ToString)
                    End If
                Next
            End While
        End If
        sqlResult.Close()
    End Sub

    Public Function insertar() As Integer
        Dim conn As DBConn = DBConn.Instance()

        Dim consulta As String = "INSERT INTO " & _nombre_tabla & "(" & String.Join(",", _atributos_insert) & ") VALUES (@" & String.Join(", @", _atributos_insert) & ")"

        Dim insert As New SqlCommand(consulta)

        For Each atributo In _atributos_insert

            Dim pInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(atributo)
            insert.Parameters.AddWithValue("@" & atributo, pInfo.GetValue(Me, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing))
        Next
        Return conn.InsertStatement(insert)
    End Function

    Public Function editar(values() As Object) As Integer
        Dim conn As DBConn = DBConn.Instance()
        Dim update_string As String

        For index = 0 To _atributos_insert.Length
            update_string += _atributos_insert(index) & "=" & values(index)
        Next

        Dim consulta As String = "UPDATE '" & _nombre_tabla & "' SET '" & update_string
        Dim insert As New SqlCommand(consulta)

        Return conn.InsertStatement(insert)
    End Function
End Class
