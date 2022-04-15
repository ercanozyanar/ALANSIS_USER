Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form107
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form107_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,TALEP_NO,CARI_KODU FROM EO_ALANSIS_TEKLIFMAS"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 400
            DataGridView1.Columns(2).Width = 400
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
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,TALEP_NO,CARI_KODU FROM EO_ALANSIS_TEKLIFMAS WHERE TALEP_NO LIKE '%" & TextBox1.Text & "%'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 400
            DataGridView1.Columns(2).Width = 400
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
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,TALEP_NO,CARI_KODU FROM EO_ALANSIS_TEKLIFMAS WHERE TARIH LIKE '%" & TextBox1.Text & "%'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 400
            DataGridView1.Columns(2).Width = 400
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
        Dim talepno
        talepno = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form104.TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        '-------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT * FROM EO_ALANSIS_TEKLIFMAS WHERE TALEP_NO='" & talepno & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            Form104.ComboBox7.Text = reader1("SUBE").ToString()
            Form104.TextBox2.Text = reader1("CARI_KODU").ToString()
            Form104.MaskedTextBox1.Text = reader1("TARIH").ToString()
            Form104.MaskedTextBox2.Text = reader1("TESLIM_TARIHI").ToString()
            Form104.MaskedTextBox3.Text = reader1("IST_TES_TARIHI").ToString()
            Form104.MaskedTextBox4.Text = reader1("DOV_BAZ_TARIH").ToString()
            Form104.ComboBox1.Text = reader1("TIPI").ToString()
            Form104.ComboBox2.Text = reader1("IHR_TIPI").ToString()
            Form104.TextBox3.Text = reader1("EXP_REF_NO").ToString()
            Form104.ComboBox3.Text = reader1("TALEP_ONAY").ToString()
            Form104.Label11.Text = reader1("TALEP_DURUMU").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------
        Me.Close()
        Form104.ComboBox3.Enabled = False
        Form104.Label11.Enabled = False
        Form104.Show()
    End Sub
End Class