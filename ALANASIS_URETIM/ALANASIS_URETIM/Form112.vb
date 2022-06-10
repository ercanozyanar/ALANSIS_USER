Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Mail
Public Class Form112
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "SELECT* FROM EO_ALANSIS_TALEPONAYLIST WHERE TALEP_ONAY='" & ComboBox3.Text & "' AND TALEP_INDEX='1';"
        da.SelectCommand = cmd1
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "SELECT* FROM EO_ALANSIS_TALEPONAYLIST WHERE TALEP_ONAY='" & ComboBox3.Text & "' AND TALEP_INDEX='2';"
        da.SelectCommand = cmd1
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "SELECT* FROM EO_ALANSIS_TALSIP WHERE TALEP_ONAY='" & ComboBox3.Text & "';"
        da.SelectCommand = cmd1
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        On Error Resume Next
        Dim conn2 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        DataGridView2.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn2.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn2.Open()
        cmd2.Connection = conn2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SATSIPTAKIP WHERE SIPARIS_NO LIKE '%" & TextBox2.Text & "%';"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0).DefaultView
        conn2.Close()
        DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView2.Rows.Count - 1 Step 2
            DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub

    Private Sub Form112_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class