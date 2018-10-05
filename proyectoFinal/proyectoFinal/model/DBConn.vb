Imports System.Data.SqlClient

Public NotInheritable Class DBConn

    Private Shared ReadOnly _instance As New Lazy(Of DBConn) _
        (Function() New DBConn(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private _myConn As SqlConnection
    Private _myCmd As SqlCommand

    Public Property MyConn As SqlConnection
        Get
            Return _myConn
        End Get
        Set(value As SqlConnection)
            _myConn = value
        End Set
    End Property

    Public Property MyCmd As SqlCommand
        Get
            Return _myCmd
        End Get
        Set(value As SqlCommand)
            _myCmd = value
        End Set
    End Property

    Private Sub New()
        MyConn = New SqlConnection("Server=valen-tiron-tic\SQLEXPRESS;Database=clifford;Trusted_Connection=True;")
    End Sub

    Public Shared ReadOnly Property Instance() As DBConn
        Get
            Return _instance.Value
        End Get

    End Property

    Public Function AbrirConexion() As SqlConnection
        If Not (MyConn.State = ConnectionState.Open) Then
            MyConn.Open()
        End If
        Return MyConn
    End Function

    Public Function SelectStatement(sSql As String) As SqlDataReader
        MyCmd = AbrirConexion().CreateCommand

        MyCmd.CommandText = sSql

        Dim sqlResult As SqlDataReader = MyCmd.ExecuteReader()

        MyCmd = Nothing

        Return sqlResult
    End Function

    Public Function InsertStatement(sqlCmd As SqlCommand) As Integer
        MyConn = AbrirConexion()
        sqlCmd.Connection = MyConn
        Return sqlCmd.ExecuteNonQuery()
    End Function

End Class

