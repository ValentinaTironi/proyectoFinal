Imports System.Data.SqlClient

Public Class Empleado
    Inherits Persona

    Private _admin As Boolean

    Public Property Admin As Boolean
        Get
            Return _admin
        End Get
        Set(value As Boolean)
            _admin = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "empleados"
        _atributos_insert = {"Id", "Admin"}
    End Sub

    Public Sub New(admin As Boolean, cedula As String, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        Dim persona As New Persona(cedula, nombre_completo, username, password, email, numero_cuenta_bancaria, direccion)
        persona.insertar()

        _nombre_tabla = "empleados"
        _atributos_insert = {"Id", "Admin"}

        Me.Id = persona.getLastId()
        Me.Admin = admin
    End Sub

    Public Sub New(id As Integer, admin As Boolean, cedula As String, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String)
        MyBase.New(id, cedula, nombre_completo, username, password, email, numero_cuenta_bancaria, direccion)
        MyBase.guardarEdicion(id)

        _nombre_tabla = "empleados"
        _atributos_insert = {"Id", "Admin"}

        Me.Id = id
        Me.Admin = admin
    End Sub

    Public Overrides Function allElements() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM personas P INNER JOIN empleados E ON P.id = E.id")
    End Function

    Public Function login(username As String, password As String) As Boolean
        Dim conn As DBConn = DBConn.Instance

        Dim reader As SqlDataReader = conn.SelectStatement("SELECT P.id 'id_usuario' FROM personas P JOIN empleados E ON P.id = E.id WHERE username = '" & username & "' AND password ='" & password & "'")
        If reader.HasRows Then
            While reader.Read
                frmMiCuenta.lblid.Text = reader("id_usuario").ToString
            End While
            reader.Close()
            Return True
        End If

        reader.Close()
        Return False
    End Function

    Public Overloads Overrides Sub ver(id As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT E.id, PP.nombre_completo, PP.username, PP.email, PP.direccion, PP.cedula, PP.fecha_nacimiento, R.nombre 'rol' FROM empleados E INNER JOIN personas PP ON E.id = PP.id INNER JOIN rol_empleado RE ON RE.id_empleado = E.id INNER JOIN roles R ON RE.id_rol = R.id  WHERE E.id = " & id

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)
        llenarLabels(sqlResult, form)
    End Sub

    Public Overrides Sub editar(id As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT E.id, PP.nombre_completo, PP.username, PP.password, PP.email, PP.direccion, PP.cedula, PP.numero_cuenta_bancaria, R.nombre 'rol' FROM empleados E INNER JOIN personas PP ON E.id = PP.id INNER JOIN rol_empleado RE ON RE.id_empleado = E.id INNER JOIN roles R ON RE.id_rol = R.id  WHERE E.id = " & id

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)
        llenarTextbox(sqlResult, form)
    End Sub
End Class
