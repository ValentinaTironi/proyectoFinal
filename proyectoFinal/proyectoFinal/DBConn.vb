Imports System.Data.SqlClient

Public NotInheritable Class DBConn

    Private Shared ReadOnly _instance As New Lazy(Of DBConn) _
        (Function() New DBConn(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private myConn As SqlConnection
    Private myCmd As SqlCommand

    Private Sub New()
        myConn = New SqlConnection("Server=valen-tiron-tic\SQLEXPRESS;Database=clifford;Trusted_Connection=True;")
    End Sub

    Public Shared ReadOnly Property Instance() As DBConn
        Get
            Return _instance.Value
        End Get

    End Property

    Public Function SelectStatement(sSql As String) As SqlDataReader

        myCmd = myConn.CreateCommand

        myCmd.CommandText = sSql

        If Not (myConn.State = ConnectionState.Open) Then
            myConn.Open()
        End If

        Return myCmd.ExecuteReader()
    End Function

End Class

