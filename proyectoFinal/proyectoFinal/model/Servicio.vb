Public Class Servicio
    Inherits Generica

    Private _id As Integer
    Private _nombre As String
    Private _cantidad_casetas As Integer
    Private _precio As Double
    Private _descripcion As String

    Public Sub New()
        _nombre_tabla = "servicios"
    End Sub
End Class
