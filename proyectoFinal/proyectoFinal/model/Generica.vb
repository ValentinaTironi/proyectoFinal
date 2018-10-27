Imports System.Data.SqlClient
Imports System.Reflection

Public Class Generica
    Protected _nombre_tabla As String
    Protected _atributos_insert() As String
    Public _id As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

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

    Public Overridable Sub editar(pk As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT * FROM " & _nombre_tabla & " WHERE id = " & pk

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)
        llenarTextbox(sqlResult, form)
    End Sub

    Public Overridable Function guardarEdicion(pk As String) As Integer
        Dim conn As DBConn = DBConn.Instance()

        Dim consulta_update As String = "UPDATE " & _nombre_tabla & " SET "
        Dim update_string As String = ""

        For index = 0 To _atributos_insert.Length - 1
            Dim atributo As String = _atributos_insert(index)
            update_string += atributo & " = " & "@" & atributo
            If Not atributo = _atributos_insert.Last Then
                update_string += ", "
            End If
        Next

        consulta_update += update_string & " WHERE id = " & pk
        Dim insert As New SqlCommand(consulta_update)

        For Each atributo In _atributos_insert
            Dim pInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(atributo)
            insert.Parameters.AddWithValue("@" & atributo, pInfo.GetValue(Me, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing))
        Next

        Return conn.AMDStatement(insert)
    End Function

    Public Overridable Overloads Sub ver(id As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT * FROM " & _nombre_tabla & " WHERE id = " & id

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)

        llenarLabels(sqlResult, form)
    End Sub

    Public Overridable Function borrar(id As String) As Integer
        Dim conn As DBConn = DBConn.Instance()

        Dim consulta As String = "DELETE FROM " & _nombre_tabla & " WHERE id = " & id

        Dim delete As New SqlCommand(consulta)
        Return conn.AMDStatement(delete)
    End Function

    Public Function getLastId() As Integer
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT TOP 1 id FROM " & _nombre_tabla & " ORDER BY id DESC"
        Dim sqlResult As SqlDataReader = conn.SelectStatement(consulta)
        While sqlResult.Read
            Dim id As Integer = sqlResult("id")
            sqlResult.Close()
            Return id
        End While
        Return 0
    End Function

    Public Sub getDataSource(combobox As ComboBox, tabla_referencia As String, nombre_atributo As String, value As String)
        Dim conn As DBConn = DBConn.Instance()
        Dim data As New SqlCommand("SELECT * FROM " & tabla_referencia)
        combobox.DataSource = conn.SetDataSource(data)
        combobox.DisplayMember = nombre_atributo
        combobox.ValueMember = value
    End Sub

    Protected Sub llenarTextbox(sqlResult As SqlDataReader, form As Form)
        If sqlResult.HasRows() Then
            While sqlResult.Read
                For Each ctrl In form.Controls
                    If (ctrl.GetType() Is GetType(TextBox)) Then
                        Dim txtbox As TextBox = CType(ctrl, TextBox)
                        If txtbox.Name.StartsWith("txt") Then
                            Dim name_atribute = Replace(txtbox.Name, "txt", "")
                            Dim atribute_value As String = sqlResult(name_atribute)
                            txtbox.Text = atribute_value
                        End If
                    End If
                Next
            End While
        End If
        sqlResult.Close()
    End Sub

    Protected Sub llenarLabels(sqlResult As SqlDataReader, form As Form)
        If sqlResult.HasRows() Then
            While sqlResult.Read
                For Each ctrl In form.Controls
                    If (ctrl.GetType() Is GetType(Panel)) Then
                        ' si el control es un panel, entonces debemos iterar dentro de sus elementos
                        For Each control In ctrl.Controls
                            siLabelLlenarla(control, sqlResult)
                        Next
                    Else
                        ' si el control no es un panel se hace la pregunta nomás
                        siLabelLlenarla(ctrl, sqlResult)
                    End If

                Next
            End While
        End If
        sqlResult.Close()
    End Sub

    Private Sub siLabelLlenarla(ctrl As Control, sqlResult As SqlDataReader)
        If (ctrl.GetType() Is GetType(Label)) Then
            Dim label As Label = CType(ctrl, Label)
            If label.Name.StartsWith("lbl") Then
                Dim name_atribute = Replace(label.Name, "lbl", "")
                Dim atribute_value As String = sqlResult(name_atribute).ToString
                label.Text = atribute_value
            End If
        End If
    End Sub
End Class
