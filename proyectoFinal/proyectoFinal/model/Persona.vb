Imports System.Data.SqlClient

Public Class Persona
    Inherits Generica

    Private _id As Integer
    Protected _cedula As Integer
    Protected _nombre_completo As String
    Protected _username As String
    Protected _password As String
    Protected _email As String
    Protected _numero_cuenta_bancaria As String
    Protected _direccion As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property cedula() As Integer
        Get
            Return _cedula
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property

    Public Property nombre_completo() As String
        Get
            Return _nombre_completo
        End Get
        Set(ByVal value As String)
            _nombre_completo = value
        End Set
    End Property

    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property numero_cuenta_bancaria() As String
        Get
            Return _numero_cuenta_bancaria
        End Get
        Set(ByVal value As String)
            _numero_cuenta_bancaria = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "personas"
    End Sub

    Public Sub New(id As Integer, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        _nombre_tabla = "personas"

        _id = id
        _cedula = cedula
        _nombre_completo = nombre_completo
        _username = username
        _password = password
        _email = email
        _numero_cuenta_bancaria = numero_cuenta_bancaria
        _direccion = direccion
    End Sub

    Public Function login(username As String, password As String) As Boolean
        Dim conn As DBConn = DBConn.Instance

        Dim reader As SqlDataReader = conn.SelectStatement("SELECT * FROM personas P JOIN empleados E ON P.id = E.id WHERE username = '" + username + "' AND password ='" + password + "'")
        If reader.HasRows Then
            Return True
        End If

        reader.Close()
        Return False
    End Function
End Class
