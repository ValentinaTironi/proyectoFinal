Imports System.Data.SqlClient

Public Class RolEmpleado
    Inherits Generica

    Private _id_empleado As Integer
    Private _id_rol As Integer

    Public Property Id_empleado As Integer
        Get
            Return _id_empleado
        End Get
        Set(value As Integer)
            _id_empleado = value
        End Set
    End Property

    Public Property Id_rol As Integer
        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "rol_empleado"
        _atributos_insert = {"Id_empleado", "Id_rol"}
    End Sub

    Public Sub New(id_empleado As Integer, id_rol As Integer)
        _nombre_tabla = "rol_empleado"
        _atributos_insert = {"Id_empleado", "Id_rol"}

        Me.Id_empleado = id_empleado
        Me.Id_rol = id_rol
    End Sub

    Public Function guardarEdiciones() As Integer
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

        consulta_update += update_string & " WHERE id_rol = " & Id_rol & " AND id_empleado = " & Id_empleado
        Dim insert As New SqlCommand(consulta_update)

        For Each atributo In _atributos_insert
            Dim pInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(atributo)
            insert.Parameters.AddWithValue("@" & atributo, pInfo.GetValue(Me, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing))
        Next

        Return conn.AMDStatement(insert)
    End Function

    Public Overrides Function borrar(id_empleado As String) As Integer
        Dim conn As DBConn = DBConn.Instance()

        Dim consulta As String = "DELETE FROM " & _nombre_tabla & " WHERE id_empleado = " & id_empleado

        Dim delete As New SqlCommand(consulta)
        Return conn.AMDStatement(delete)
    End Function
End Class
