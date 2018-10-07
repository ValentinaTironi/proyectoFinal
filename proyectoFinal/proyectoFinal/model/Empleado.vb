Imports System.Data.SqlClient

Public Class Empleado
    Inherits Persona

    Private _admin As Boolean

    Public Sub New()
        _nombre_tabla = "empleados"
    End Sub

    Public Sub New(cedula As String, admin As Boolean, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        MyBase.New(cedula, nombre_completo, username, password, email, numero_cuenta_bancaria, direccion)

        _nombre_tabla = "empleados"

        Me.Admin = admin
    End Sub

    Public Property Admin As Boolean
        Get
            Return _admin
        End Get
        Set(value As Boolean)
            _admin = value
        End Set
    End Property

    Public Overrides Function allElements() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM personas P INNER JOIN empleados E ON P.id = E.id")
    End Function

    Public Function login(username As String, password As String) As Boolean
        Dim conn As DBConn = DBConn.Instance

        Dim reader As SqlDataReader = conn.SelectStatement("SELECT * FROM personas P JOIN empleados E ON P.id = E.id WHERE username = '" & username & "' AND password ='" & password & "'")
        If reader.HasRows Then
            reader.Close()
            Return True
        End If

        reader.Close()
        Return False
    End Function
End Class
