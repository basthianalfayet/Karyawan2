Imports System.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public dr As SqlDataReader
    Public cmd As SqlCommand
    Public dt As DataTable
    Public mydb As String

    Public Sub koneksi()
        mydb = "Data source=DESKTOP-F7IFKTC\SQLEXPRESS01;initial catalog=karyawan;integrated security=true"
        conn = New SqlConnection(mydb)
        If conn.StatisticsEnabled = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
