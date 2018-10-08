Imports System.Data.SqlClient

Public Class Perro
    Inherits Generica

    Private _id_cliente As Integer
    Private _id_perro As Integer
    Private _nombre As String
    Private _edad As Double
    Private _raza As String
    Private _peso As Double
    Private _id_caseta As Integer

    Public Property Id_cliente As Integer
        Get
            Return _id_cliente
        End Get
        Set(value As Integer)
            _id_cliente = value
        End Set
    End Property

    Public Property Id_perro As Integer
        Get
            Return _id_perro
        End Get
        Set(value As Integer)
            _id_perro = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Edad As Double
        Get
            Return _edad
        End Get
        Set(value As Double)
            _edad = value
        End Set
    End Property

    Public Property Raza As String
        Get
            Return _raza
        End Get
        Set(value As String)
            _raza = value
        End Set
    End Property

    Public Property Peso As Double
        Get
            Return _peso
        End Get
        Set(value As Double)
            _peso = value
        End Set
    End Property

    Public Property Id_caseta As Integer
        Get
            Return _id_caseta
        End Get
        Set(value As Integer)
            _id_caseta = value
        End Set
    End Property

    Public Sub New(id_cliente As Integer, id_caseta As Integer)
        _nombre_tabla = "perros"
        _atributos_insert = {"Id_cliente", "id_caseta", "Id_perro", "Nombre", "Edad", "Raza", "Peso"}

        Me.Id_cliente = id_cliente
        Me.id_caseta = id_caseta
        Me.Id_perro = getNewId(id_cliente)
        Me.Nombre = "nombre"
        Me.Edad = 0.0
        Me.Raza = "raza"
        Me.Peso = 1.0
    End Sub

    Public Sub New(id_caseta As Integer)
        _nombre_tabla = "perros"
        _atributos_insert = {"Id_caseta"}

        Me.id_caseta = id_caseta
    End Sub

    Private Function getNewId(id_cliente As Integer) As Integer
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT TOP 1 id_perro FROM perros WHERE id_cliente = " & id_cliente & " ORDER BY id_perro DESC"
        Dim sqlResult As SqlDataReader = conn.SelectStatement(consulta)
        While sqlResult.Read
            Dim id As Integer = sqlResult("id")
            sqlResult.Close()
            Return id + 1
        End While
        sqlResult.Close()
        Return 1
    End Function

    Public Function guardarEdiciones(id_perro As String, id_cliente As String) As Integer
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

        consulta_update += update_string & " WHERE id_perro = " & id_perro & "AND id_cliente = " & id_cliente
        Dim insert As New SqlCommand(consulta_update)

        For Each atributo In _atributos_insert
            Dim pInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(atributo)
            insert.Parameters.AddWithValue("@" & atributo, pInfo.GetValue(Me, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing))
        Next

        Return conn.AMDStatement(insert)
    End Function
End Class
