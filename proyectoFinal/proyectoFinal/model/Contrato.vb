Public Class Contrato
    Inherits Generica

    Private _id_cliente As Integer
    Private _id_servicio As Integer
    Private _fecha As Date
    Private _duracion As String
    Private _fecha_pago As Integer

    Public Property Id_cliente As Integer
        Get
            Return _id_cliente
        End Get
        Set(value As Integer)
            _id_cliente = value
        End Set
    End Property

    Public Property Id_servicio As Integer
        Get
            Return _id_servicio
        End Get
        Set(value As Integer)
            _id_servicio = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Duracion As String
        Get
            Return _duracion
        End Get
        Set(value As String)
            _duracion = value
        End Set
    End Property

    Public Property Fecha_pago As Integer
        Get
            Return _fecha_pago
        End Get
        Set(value As Integer)
            _fecha_pago = value
        End Set
    End Property

    Public Sub New(id_cliente As Integer, id_servicio As Integer, duracion As String, fecha_pago As Integer)
        _nombre_tabla = "contrato"
        _atributos_insert = {"Id_cliente", "Id_servicio", "Duracion", "Fecha_pago"}

        Me.Id_cliente = id_cliente
        Me.Id_servicio = id_servicio
        Me.Duracion = duracion
        Me.Fecha_pago = fecha_pago
    End Sub

End Class
