Imports System.Data.SqlClient

Public Class Generica
    ' Public: acceso desde cualquier lugar 
    ' Protected: acceso en clase e hijas
    ' Private: solo acceso en la clase 
    Protected _nombre_tabla As String


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

    Public Function ChequearSiExiste(atributo As String, value As String) As Boolean
        Dim conn As DBConn = DBConn.Instance

        Dim check As SqlDataReader = conn.SelectStatement("SELECT * FROM servicios WHERE '" & atributo & "' = '" & value & "'")

        If check.HasRows Then
            check.Close()
            Return True
        End If

        check.Close()
        Return False
    End Function
    'Public Function Guardar(attributes As List(Of String), values As List(Of String), nombre_tabla As String) As Boolean
    '    Dim conn As DBConn = DBConn.Instance()

    '    Dim consulta As String = "INSERT INTO '" & nombre_tabla & "'("

    '    ConcatValues(attributes, consulta)
    '    consulta = consulta & "') VALUES ('"
    '    ConcatValues(values, consulta)

    '    Dim reader As SqlDataReader = conn.SelectStatement(consulta)

    '    If reader.HasRows Then
    '        reader.Close()
    '        Return True
    '    End If

    '    reader.Close()
    '    Return False
    'End Function

    'Private Sub ConcatValues(elements As List(Of String), consulta As String)
    '    For Each element In elements
    '        consulta = consulta & element
    '        If Not element = elements.Last() Then
    '            consulta = consulta & "',"
    '        End If
    '    Next
    'End Sub
End Class
