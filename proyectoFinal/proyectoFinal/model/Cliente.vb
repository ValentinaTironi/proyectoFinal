Imports System.Data.SqlClient

Public Class Cliente
    Inherits Persona

    Private _id As Integer
    Private _activo As Boolean
    Private _id_creador As Integer
    Private _fecha_creacion As Date

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property id_creador() As Integer
        Get
            Return _id_creador
        End Get
        Set(ByVal value As Integer)
            _id_creador = value
        End Set
    End Property

    Public Property fecha_creacion() As Date
        Get
            Return _fecha_creacion
        End Get
        Set(ByVal value As Date)
            _fecha_creacion = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "clientes"
    End Sub

    Public Sub New(id As Integer, activo As Boolean, id_creador As Integer, fecha_creacion As Date, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        _nombre_tabla = "clientes"

        _id = id
        _activo = activo
        _id_creador = id_creador
        _fecha_creacion = fecha_creacion
        _cedula = cedula
        _nombre_completo = nombre_completo
        _username = username
        _password = password
        _email = email
        _numero_cuenta_bancaria = numero_cuenta_bancaria
        _direccion = direccion
    End Sub

    Public Overrides Function obtenerListado() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM personas P INNER JOIN clientes C ON P.id = C.id")
    End Function
End Class
