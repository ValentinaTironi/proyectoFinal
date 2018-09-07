Imports System.Data.SqlClient

Public Class Usuario

    Private _id As Integer
    Private _cedula As Integer
    Private _nombre_completo As String
    Private _username As String
    Private _password As String
    Private _email As String
    Private _numero_cuenta_bancaria As String
    Private _direccion As String

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

    End Sub

    Public Sub New(id As Integer, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        Me._id = id
        Me._cedula = cedula
        Me._nombre_completo = nombre_completo
        Me._username = username
        Me._password = password
        Me._email = email
        Me._numero_cuenta_bancaria = numero_cuenta_bancaria
        Me._direccion = direccion
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
