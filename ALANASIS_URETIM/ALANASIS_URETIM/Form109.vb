Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form109
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form109_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_TEKLIFMAS WHERE TALEP_INDEX='1'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
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

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_TEKLIFMAS WHERE TALEP_ONAY='" & ComboBox3.Text & "' AND TALEP_INDEX='1'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
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
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim talepno
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        talepno = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Form111.TextBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        '-------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT * FROM EO_ALANSIS_TEKLIFMAS WHERE TALEP_NO='" & talepno & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            Form111.ComboBox7.Text = reader1("SUBE").ToString()
            Form111.TextBox2.Text = reader1("CARI_KODU").ToString()
            Form111.MaskedTextBox1.Text = reader1("TARIH").ToString()
            Form111.MaskedTextBox2.Text = reader1("TESLIM_TARIHI").ToString()
            Form111.MaskedTextBox3.Text = reader1("IST_TES_TARIHI").ToString()
            Form111.MaskedTextBox4.Text = reader1("DOV_BAZ_TARIH").ToString()
            Form111.ComboBox1.Text = reader1("TIPI").ToString()
            Form111.ComboBox2.Text = reader1("IHR_TIPI").ToString()
            Form111.TextBox3.Text = reader1("EXP_REF_NO").ToString()
            Form111.ComboBox3.Text = reader1("TALEP_ONAY").ToString()
            Form111.Label11.Text = reader1("TALEP_DURUMU").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------
        Me.Close()
        '---------------------------------------------------------------------------------------------
        Form111.ComboBox7.Enabled = False
        Form111.TextBox2.Enabled = False
        Form111.ComboBox5.Enabled = False
        Form111.TextBox1.Enabled = False
        Form111.MaskedTextBox1.Enabled = False
        Form111.MaskedTextBox2.Enabled = False
        Form111.MaskedTextBox3.Enabled = False
        Form111.MaskedTextBox4.Enabled = False
        Form111.ComboBox1.Enabled = False
        Form111.ComboBox2.Enabled = False
        Form111.TextBox3.Enabled = False
        Form111.ComboBox3.Enabled = False
        Form111.Label11.Enabled = False
        Form111.SimpleButton2.Visible = False
        Form111.TextBox7.Text = "1"
        Form111.ComboBox5.Visible = False
        Form111.Label19.Visible = False
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_TEKLIFTRA WHERE TEKLIFTRANO='" & talepno & "' AND TEKLIF_INDEX='1'"
        da.SelectCommand = cmd2
        da.Fill(ds)
        Form111.DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        Form111.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            Form111.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Form111.Show()
        Form111.Text = "ALANSIS - SATIN ALMA TALEP SIPARISLESTIRME"
    End Sub
End Class