Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Form2.Show()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call munculgrid()
    End Sub

    Sub kondisiawal()
        txtnama.Text = ""
        txtusia.Text = ""
        dt1.Text = ""
    End Sub

    Sub munculgrid()
        Call koneksi()
        da = New SqlDataAdapter("select * from Karyawan", conn)
        ds = New DataSet
        da.Fill(ds, "Karyawan")
        dgv.DataSource = ds.Tables("Karyawan")
        dgv.Columns(0).Width = 120
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 200
        dgv.Columns(3).Width = 200
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'Call koneksi()
        'cmd = New SqlCommand("sp_edituser", conn)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@", SqlDbType.NVarChar).Value = txtnama.Text.Trim
        'cmd.Parameters.AddWithValue("@namauser", SqlDbType.NVarChar).Value = txtusia.Text.Trim
        'cmd.Parameters.AddWithValue("@passworduser", SqlDbType.NVarChar).Value = dt1.Text.Trim
        'cmd.ExecuteNonQuery()
        'MsgBox("Data Berhasil Di Update!", vbInformation)
        'conn.Close()
        'Call munculgrid()
        'Call kondisiawal()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'Call koneksi()
        'cmd = New SqlCommand("sp_deleteuser", conn)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@iduser", SqlDbType.NVarChar).Value = txtnama.Text.Trim
        'cmd.ExecuteNonQuery()
        'MsgBox("Data Berhasil Di Hapus!", MessageBoxButtons.YesNo)
        'conn.Close()
        'Call munculgrid()
        'Call kondisiawal()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = dgv.CurrentRow.Index

        On Error Resume Next
        txtid.Text = dgv.Item(0, i).Value
        txtnama.Text = dgv.Item(1, i).Value
        txtusia.Text = dgv.Item(2, i).Value
        dt1.Value = dgv.Item(3, i).Value
    End Sub
End Class
