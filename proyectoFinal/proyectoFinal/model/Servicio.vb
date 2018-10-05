Imports System.Data.SqlClient

Public Class Servicio
    Inherits Generica

    Private _id As Integer
    Private _nombre As String
    Private _cantidad_casetas As Integer
    Private _precio As Double
    Private _descripcion As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Cantidad_casetas As Integer
        Get
            Return _cantidad_casetas
        End Get
        Set(value As Integer)
            _cantidad_casetas = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Sub New(nombre As String, cantidad_casetas As Integer, precio As Double, descripcion As String)
        _nombre_tabla = "servicios"
        _atributos_insert = {"Nombre", "Cantidad_casetas", "Precio", "Descripcion"}

        Me.Nombre = nombre
        Me.Cantidad_casetas = cantidad_casetas
        Me.Precio = precio
        Me.Descripcion = descripcion
    End Sub

    Public Sub New()
        _nombre_tabla = "servicios"
    End Sub
End Class
