Imports System.Data.SqlClient

Public Class Cliente
    Inherits Persona

    Shadows _id As Integer
    Private _id_creador As Integer
    Private _activo As Boolean
    Private _fecha_creacion As Date

    Public Property Id_creador As Integer
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
        _atributos_insert = {"Id", "Activo", "Id_creador", "Fecha_creacion"}
    End Sub

    Public Sub New(activo As Boolean, id_creador As Integer, fecha_creacion As Date, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        Dim persona As New Persona(cedula, nombre_completo, username, password, email, numero_cuenta_bancaria, direccion)
        persona.insertar()

        _nombre_tabla = "clientes"
        _atributos_insert = {"Id", "Activo", "Id_creador"}

        Me.Id = persona.getLastId()
        Me.Activo = activo
        Me.Id_creador = id_creador
        Me.Fecha_creacion = fecha_creacion
    End Sub

    Public Sub New(id As Integer, activo As Boolean, id_creador As Integer, fecha_creacion As Date, cedula As Integer, nombre_completo As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        MyBase.New(id, cedula, nombre_completo, email, numero_cuenta_bancaria, direccion)
        MyBase.guardarEdicion(id)

        _nombre_tabla = "clientes"
        _atributos_insert = {"Id", "Activo", "Id_creador", "Fecha_creacion"}

        Me.Id = id
        Me.Activo = activo
        Me.Id_creador = id_creador
        Me.Fecha_creacion = fecha_creacion
    End Sub

    Public Sub New(id As Integer, activo As Boolean, id_creador As Integer, fecha_creacion As Date, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        MyBase.New(id, cedula, nombre_completo, username, password, email, numero_cuenta_bancaria, direccion)
        MyBase.guardarEdicion(id)

        _nombre_tabla = "clientes"
        _atributos_insert = {"Id", "Activo", "Id_creador", "Fecha_creacion"}

        Me.Id = id
        Me.Activo = activo
        Me.Id_creador = id_creador
        Me.Fecha_creacion = fecha_creacion
    End Sub

    Public Overrides Function allElements() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM personas P INNER JOIN clientes C ON P.id = C.id")
    End Function

    Public Function lastFiveClients() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT TOP 5 * FROM personas P INNER JOIN clientes C ON P.id = C.id")
    End Function

    Public Overloads Overrides Sub ver(id As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT C.id, PP.nombre_completo, PP.username, PP.email, C.fecha_creacion, PP.direccion, PP.cedula, S.nombre 'nombre_servicio', CC.fecha 'fecha_contrato', CC.fecha_pago 'fecha_pago_contrato', S.cantidad_casetas 'cantidad_casetas_servicio'  FROM clientes C INNER JOIN personas PP ON C.id = PP.id INNER JOIN contrato CC ON CC.id_cliente = C.id INNER JOIN servicios S ON S.id = CC.id_servicio WHERE C.id = " & id

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)
        llenarLabels(sqlResult, form)
    End Sub

    Public Overrides Sub editar(pk As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT C.id, PP.nombre_completo, PP.username, PP.numero_cuenta_bancaria, PP.email, PP.direccion, PP.cedula FROM clientes C INNER JOIN personas PP ON C.id = PP.id INNER JOIN contrato CC ON CC.id_cliente = C.id INNER JOIN servicios S ON S.id = CC.id_servicio WHERE C.id = " & pk

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)
        llenarTextbox(sqlResult, form)
    End Sub

End Class
