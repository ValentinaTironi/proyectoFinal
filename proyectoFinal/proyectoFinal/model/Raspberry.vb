Public Class Raspberry
    Inherits Generica

    Private _estado As String
    Private _nombre As String
    Private _mac As String

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Mac As String
        Get
            Return _mac
        End Get
        Set(value As String)
            _mac = value
        End Set
    End Property

    Public Sub New(id As Integer, estado As String, nombre As String, mac As String)
        _nombre_tabla = "raspberries"
        _atributos_insert = {"Id", "Estado", "Nombre", "Mac"}

        Me.Id = id
        Me.Estado = estado
        Me.Nombre = nombre
        Me.Mac = mac
    End Sub
End Class
