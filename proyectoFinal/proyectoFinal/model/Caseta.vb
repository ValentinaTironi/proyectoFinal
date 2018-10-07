Imports System.Data.SqlClient

Public Class Caseta
    Inherits Generica

    Shadows _id As Integer
    Private _tamanio_tarro As String
    Private _hora_diaria As String 'preguntar a paula
    Private _automatico As Boolean
    Private _id_raspberrypi As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Tamanio_tarro As String
        Get
            Return _tamanio_tarro
        End Get
        Set(value As String)
            _tamanio_tarro = value
        End Set
    End Property

    Public Property Hora_diaria As String
        Get
            Return _hora_diaria
        End Get
        Set(value As String)
            _hora_diaria = value
        End Set
    End Property

    Public Property Automatico As Boolean
        Get
            Return _automatico
        End Get
        Set(value As Boolean)
            _automatico = value
        End Set
    End Property

    Public Property Id_Raspberrypi As Integer
        Get
            Return _id_raspberrypi
        End Get
        Set(value As Integer)
            _id_raspberrypi = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "casetas"
        _atributos_insert = {"Tamanio_tarro", "Id_Raspberrypi"}
    End Sub

    Public Sub New(tamanio_tarro As String, hora_diaria As String, automatico As Boolean, id_raspberry As Integer)
        _nombre_tabla = "casetas"
        _atributos_insert = {"TamanioTarro", "HoraDiaria", "Automatico", "IdRaspberry"}

        Me.Tamanio_tarro = tamanio_tarro
        Me.Hora_diaria = hora_diaria
        Me.Automatico = automatico
        Me.Id_Raspberrypi = id_raspberry
    End Sub

    Public Sub New(tamanio_tarro As String, id_raspberry As Integer)
        _nombre_tabla = "casetas"
        _atributos_insert = {"Tamanio_tarro", "Id_Raspberrypi"}

        Me.Tamanio_tarro = tamanio_tarro
        Me.Id_Raspberrypi = id_raspberry
    End Sub

    Public Overrides Function allElements() As SqlDataReader
        Dim sentence As String = "SELECT C.id, PP.nombre_completo,  R.nombre 'nombre_raspberry', R.estado 'estado', C.automatico 'automatico'
            FROM casetas C
            JOIN raspberrys R ON C.id_raspberrypi = R.id
            JOIN perros P ON C.id = P.id_casetas
            JOIN personas PP ON P.id_cliente = PP.id"
        Return DBConn.Instance().SelectStatement(sentence)
    End Function

    Public Function historial() As SqlDataReader
        Dim sentence As String = "SELECT C.id, A.descripcion, P.nombre_completo 'nombre_persona', L.fecha_hora FROM log_casetas L
         JOIN accion A ON A.id = L.id_accion
         JOIN casetas C ON C.id = L.id_caseta
         JOIN personas P ON P.id = L.id_persona"
        Return DBConn.Instance().SelectStatement(sentence)
    End Function

    Public Overrides Sub ver(id As String, form As Form)
        Dim conn As DBConn = DBConn.Instance()
        Dim consulta As String = "SELECT C.id, PP.nombre_completo, R.estado, C.automatico , C.hora_diaria FROM casetas C JOIN raspberrys R ON C.id_raspberrypi = R.id JOIN perros P ON C.id = P.id_casetas JOIN personas PP ON P.id_cliente = PP.id WHERE C.id = " & id

        Dim read As New SqlCommand(consulta)

        Dim sqlResult As SqlDataReader = conn.SelectRecord(read)

        llenarLabels(sqlResult, form)
    End Sub
End Class
