Imports System.Data.SqlClient

Public Class Persona
    Inherits Generica

    Private _cedula As Integer
    Private _nombre_completo As String
    Private _username As String
    Private _password As String
    Private _email As String
    Private _numero_cuenta_bancaria As String
    Private _direccion As String
    Private _fecha_nacimiento As Date

    Public Property Cedula As Integer
        Get
            Return _cedula
        End Get
        Set(value As Integer)
            _cedula = value
        End Set
    End Property

    Public Property Nombre_completo As String
        Get
            Return _nombre_completo
        End Get
        Set(value As String)
            _nombre_completo = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Numero_cuenta_bancaria As String
        Get
            Return _numero_cuenta_bancaria
        End Get
        Set(value As String)
            _numero_cuenta_bancaria = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Fecha_nacimiento As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(value As Date)
            _fecha_nacimiento = value
        End Set
    End Property

    Protected Sub New()
        _nombre_tabla = "personas"
        _atributos_insert = {"Cedula", "Nombre_completo", "Username", "Password", "Email", "Numero_cuenta_bancaria", "Direccion", "Fecha_nacimiento"}
    End Sub

    Protected Sub New(cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String, fecha_nacimiento As String)
        _nombre_tabla = "personas"
        _atributos_insert = {"Cedula", "Nombre_completo", "Username", "Password", "Email", "Numero_cuenta_bancaria", "Direccion", "Fecha_nacimiento"}

        Me.Cedula = cedula
        Me.Nombre_completo = nombre_completo
        Me.Username = username
        Me.Password = password
        Me.Email = email
        Me.Numero_cuenta_bancaria = numero_cuenta_bancaria
        Me.Direccion = direccion
        Me.Fecha_nacimiento = fecha_nacimiento
    End Sub

    Protected Sub New(id As Integer, cedula As Integer, nombre_completo As String, email As String, numero_cuenta_bancaria As String, direccion As String, fecha_nacimiento As String)
        _nombre_tabla = "personas"
        _atributos_insert = {"Cedula", "Nombre_completo", "Email", "Numero_cuenta_bancaria", "Direccion", "Fecha_nacimiento"}

        Me.Cedula = cedula
        Me.Nombre_completo = nombre_completo
        Me.Email = email
        Me.Numero_cuenta_bancaria = numero_cuenta_bancaria
        Me.Direccion = direccion
        Me.Fecha_nacimiento = fecha_nacimiento
    End Sub

    Protected Sub New(id As Integer, cedula As Integer, nombre_completo As String, username As String, password As String, email As String, numero_cuenta_bancaria As String, direccion As String, fecha_nacimiento As String)
        _nombre_tabla = "personas"
        _atributos_insert = {"Cedula", "Nombre_completo", "Email", "Username", "Password", "Numero_cuenta_bancaria", "Direccion", "Fecha_nacimiento"}

        Me.Cedula = cedula
        Me.Nombre_completo = nombre_completo
        Me.Username = username
        Me.Password = password
        Me.Email = email
        Me.Numero_cuenta_bancaria = numero_cuenta_bancaria
        Me.Direccion = direccion
        Me.Fecha_nacimiento = fecha_nacimiento
    End Sub
End Class
