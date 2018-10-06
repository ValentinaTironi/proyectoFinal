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
        Return conn.AMDStatement(insert)
    End Function

    Public Sub editar(pk As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT * FROM " & _nombre_tabla & " WHERE id = " & pk

        Dim read As New SqlCommand(consulta)

        Dim sqlResult_show As SqlDataReader = conn.SelectRecord(read)
        If sqlResult_show.HasRows() Then
            While sqlResult_show.Read
                For Each ctrl In form.Controls
                    If (ctrl.GetType() Is GetType(TextBox)) Then
                        Dim txtbox As TextBox = CType(ctrl, TextBox)
                        If txtbox.Name.StartsWith("txt") Then
                            Dim name_atribute = Replace(txtbox.Name, "txt", "")
                            Dim atribute_value As String = sqlResult_show(name_atribute)
                            txtbox.Text = atribute_value
                        End If
                    End If
                Next
            End While
        End If

        sqlResult_show.Close()
    End Sub

    Public Function guardarEdicion(pk As String) As Integer
        Dim conn As DBConn = DBConn.Instance()

        Dim consulta_update As String = "UPDATE " & _nombre_tabla & " SET "
        Dim update_string As String

        For index = 0 To _atributos_insert.Length - 1
            Dim atributo As String = _atributos_insert(index)
            update_string += atributo & " = " & "@" & atributo & ", "
        Next

        consulta_update += update_string & "WHERE id = " & pk
        Dim insert As New SqlCommand(consulta_update)

        For Each atributo In _atributos_insert
            Dim pInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(atributo)
            insert.Parameters.AddWithValue("@" & atributo, pInfo.GetValue(Me, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing))
        Next

        Return conn.AMDStatement(insert)
    End Function

    Public Function ver(id As String, form As Form) As Integer
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT * FROM " & _nombre_tabla & " WHERE id = " & id

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)
        If sqlResult.HasRows() Then
            While sqlResult.Read
                For Each ctrl In form.Controls
                    If (ctrl.GetType() Is GetType(Label)) Then
                        Dim label As Label = CType(ctrl, Label)
                        If label.Name.StartsWith("lbl") Then
                            Dim name_atribute = Replace(label.Name, "lbl", "")
                            Dim atribute_value As String = sqlResult(name_atribute)
                            label.Text = atribute_value
                        End If
                    End If
                Next
            End While
        End If
        sqlResult.Close()
    End Function

    Public Function borrar(id As String) As Integer
        Dim conn As DBConn = DBConn.Instance()

        Dim consulta As String = "DELETE FROM " & _nombre_tabla & " WHERE id = " & id

        Dim delete As New SqlCommand(consulta)
        Return conn.AMDStatement(delete)
    End Function

End Class
