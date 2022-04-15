Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form106
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form106_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT STOK_KODU,STOK_ADI FROM TBLSTSABIT"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 400
            DataGridView1.Columns(1).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT STOK_KODU,STOK_ADI FROM TBLSTSABIT WHERE STOK_KODU LIKE '%" & TextBox1.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT STOK_KODU,STOK_ADI FROM TBLSTSABIT WHERE STOK_ADI LIKE '%" & TextBox2.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim kod
        If TextBox3.Text = "1" Then
            kod = DataGridView1.CurrentRow.Cells(0).Value.ToString
            Form104.TextBox12.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            '-------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT STOK_KODU,dbo.trkis(STOK_ADI) AS STOK_ADI FROM TBLSTSABIT WHERE STOK_KODU='" & kod & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                Form104.TextBox13.Text = reader1("STOK_ADI").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------
            Me.Close()
            Form104.Show()
        End If
        If TextBox3.Text = "2" Then
            kod = DataGridView1.CurrentRow.Cells(0).Value.ToString
            Form111.TextBox12.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            '-------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT STOK_KODU,dbo.trkis(STOK_ADI) AS STOK_ADI FROM TBLSTSABIT WHERE STOK_KODU='" & kod & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                Form111.TextBox13.Text = reader1("STOK_ADI").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------
            Me.Close()
        End If
        If TextBox3.Text = "3" Then
            kod = DataGridView1.CurrentRow.Cells(0).Value.ToString
            Form113.TextBox12.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            '-------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT STOK_KODU,dbo.trkis(STOK_ADI) AS STOK_ADI FROM TBLSTSABIT WHERE STOK_KODU='" & kod & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                Form113.TextBox13.Text = reader1("STOK_ADI").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------
            Me.Close()

        End If
    End Sub
End Class