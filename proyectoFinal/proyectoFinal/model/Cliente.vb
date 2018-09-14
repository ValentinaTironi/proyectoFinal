Imports System.Data.SqlClient

Public Class Cliente
    Inherits Persona

    Private _id_creador As Integer
    Private _activo As Boolean
    Private _fecha_creacion As Date

    Public Property id_creador() As Integer
        Get
            Return _id_creador
        End Get
        Set(ByVal value As Integer)
            _id_creador = value
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property Fecha_creacion As Date
        Get
            Return _fecha_creacion
        End Get
        Set(value As Date)
            _fecha_creacion = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "clientes"
    End Sub

    Public Sub New(id As Integer, activo As Boolean, id_creador As Integer, fecha_creacion As Date, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        MyBase.New(id, cedula, nombre_completo, username, password, email, numero_cuenta_bancaria, direccion)

        _nombre_tabla = "clientes"

        Me.id = id
        Me.activo = activo
        Me.id_creador = id_creador
        Me.fecha_creacion = fecha_creacion

    End Sub

    Public Overrides Function allElements() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM personas P INNER JOIN clientes C ON P.id = C.id")
    End Function
End Class
