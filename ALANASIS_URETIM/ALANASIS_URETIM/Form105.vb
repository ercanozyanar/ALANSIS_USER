Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form105
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form105_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT CARI_KOD,CARI_ISIM FROM TBLCASABIT"
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
            cmd.CommandText = "SELECT CARI_KOD,CARI_ISIM FROM TBLCASABIT WHERE CARI_KOD LIKE '%" & TextBox1.Text & "%'"
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
            cmd.CommandText = "SELECT CARI_KOD,dbo.trkis(CARI_ISIM) FROM TBLCASABIT WHERE CARI_ISIM LIKE '%" & TextBox2.Text & "%'"
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
        kod = DataGridView1.CurrentRow.Cells(0).Value.ToString
        If TextBox3.Text = "1" Then
            Form104.TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            '-------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT CARI_KOD,dbo.trkis(CARI_ISIM)AS CARI_ISIM,dbo.trkis(CARI_IL) AS CARI_IL,dbo.trkis(CARI_ILCE) AS CARI_ILCE,DBO.TRKIS(CARI_ADRES) AS CARI_ADRES FROM TBLCASABIT WHERE CARI_KOD='" & kod & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                Form104.TextBox11.Text = reader1("CARI_ISIM").ToString()
                Form104.TextBox9.Text = reader1("CARI_ADRES").ToString()
                Form104.TextBox8.Text = reader1("CARI_IL").ToString()
                Form104.TextBox10.Text = reader1("CARI_ILCE").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------
            Me.Close()
            Form104.Show()
        End If
        If TextBox3.Text = "2" Then
            Form111.TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            '-------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT CARI_KOD,dbo.trkis(CARI_ISIM)AS CARI_ISIM,dbo.trkis(CARI_IL) AS CARI_IL,dbo.trkis(CARI_ILCE) AS CARI_ILCE,DBO.TRKIS(CARI_ADRES) AS CARI_ADRES FROM TBLCASABIT WHERE CARI_KOD='" & kod & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                Form111.TextBox11.Text = reader1("CARI_ISIM").ToString()
                Form111.TextBox9.Text = reader1("CARI_ADRES").ToString()
                Form111.TextBox8.Text = reader1("CARI_IL").ToString()
                Form111.TextBox10.Text = reader1("CARI_ILCE").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------
            Me.Close()
            Form111.Show()
        End If
        If TextBox3.Text = "3" Then
            Form113.TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            '-------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT CARI_KOD,dbo.trkis(CARI_ISIM)AS CARI_ISIM,dbo.trkis(CARI_IL) AS CARI_IL,dbo.trkis(CARI_ILCE) AS CARI_ILCE,DBO.TRKIS(CARI_ADRES) AS CARI_ADRES FROM TBLCASABIT WHERE CARI_KOD='" & kod & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                Form113.TextBox11.Text = reader1("CARI_ISIM").ToString()
                Form113.TextBox9.Text = reader1("CARI_ADRES").ToString()
                Form113.TextBox8.Text = reader1("CARI_IL").ToString()
                Form113.TextBox10.Text = reader1("CARI_ILCE").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------
            Me.Close()
            Form113.Show()
        End If
    End Sub
End Class