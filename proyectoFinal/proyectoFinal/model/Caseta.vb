Imports System.Data.SqlClient

Public Class Caseta
    Inherits Generica

    Private _id As Integer
    Private _tamanio_tarro As String
    Private _hora_diaria As String 'preguntar a paula
    Private _automatico As Boolean
    Private _id_raspberry As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property TamanioTarro As String
        Get
            Return _tamanio_tarro
        End Get
        Set(value As String)
            _tamanio_tarro = value
        End Set
    End Property

    Public Property HoraDiaria As String
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

    Public Property IdRaspberry As Integer
        Get
            Return _id_raspberry
        End Get
        Set(value As Integer)
            _id_raspberry = value
        End Set
    End Property

    Public Sub New()
        _nombre_tabla = "casetas"
    End Sub

    Public Sub New(id As Integer, tamanio_tarro As String, hora_diaria As String, automatico As Boolean, id_raspberry As Integer)
        _nombre_tabla = "casetas"

        Me.Id = id
        Me.TamanioTarro = tamanio_tarro
        Me.HoraDiaria = hora_diaria
        Me.Automatico = automatico
        Me.IdRaspberry = id_raspberry
    End Sub

    Public Overrides Function allElements() As SqlDataReader
        Return DBConn.Instance().SelectStatement("SELECT C.id, PP.nombre_completo,  R.nombre 'nombre_raspberry', R.estado 'estado', C.automatico 'automatico'
        FROM casetas C
        JOIN raspberrys R ON C.id_raspberrypi = R.id
        JOIN perros P ON C.id = P.id_casetas
        JOIN personas PP ON P.id_cliente = PP.id")
    End Function
End Class
