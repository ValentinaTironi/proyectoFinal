Imports System.Data.SqlClient

Public Class Generica
    ' Public: acceso desde cualquier lugar 
    ' Protected: acceso en clase e hijas
    ' Private: solo acceso en la clase 
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

        Dim clase As Type = Me.GetType()

        For Each atributo In _atributos_insert
            insert.Parameters.AddWithValue("@" & atributo, clase.GetProperty(atributo))
        Next

        'TODO: usar atributos para hacer la consulta
        'arrays tiene funcion para juntar en uns string con un caracter (String.join(",", atributosInsert))
        Return conn.InsertStatement(insert)
    End Function

End Class
