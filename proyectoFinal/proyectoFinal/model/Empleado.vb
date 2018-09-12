Imports System.Data.SqlClient

Public Class Empleado
    Inherits Persona

    Private _id As Integer
    Private _admin As Boolean

    Public Sub New()
        _nombre_tabla = "empleados"
    End Sub

    Public Sub New(id As Integer, admin As Boolean, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        _nombre_tabla = "empleados"

        _id = id
        _admin = admin
        _cedula = cedula
        _nombre_completo = nombre_completo
        _username = username
        _password = password
        _email = email
        _numero_cuenta_bancaria = numero_cuenta_bancaria
        _direccion = direccion
    End Sub

    Public Overrides Function obtenerListado() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM personas P INNER JOIN empleados E ON P.id = E.id")
    End Function
End Class
