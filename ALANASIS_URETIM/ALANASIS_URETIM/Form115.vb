Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form115
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form115_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KALITE_CLAIM"
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KALITE_CLAIM WHERE PARTI='" & TextBox1.Text & "'"
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KALITE_CLAIM WHERE HAFTA='" & TextBox2.Text & "'"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim kontrol
        Form114.TextBox10.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        kontrol = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '-------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT * FROM EO_ALANSIS_KALITE_CLAIM WHERE ID='" & kontrol & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            Form114.TextBox30.Text = reader1("PARTI").ToString()
            Form114.TextBox1.Text = reader1("HAFTA").ToString()
            Form114.MaskedTextBox1.Text = reader1("FATURA_TARIH").ToString()
            Form114.MaskedTextBox2.Text = reader1("SEVK_TARIH").ToString()
            Form114.TextBox8.Text = reader1("MUSTERI1").ToString()
            Form114.TextBox3.Text = reader1("MUSTERI2").ToString()
            Form114.ComboBox1.Text = reader1("URUN").ToString()
            Form114.TextBox2.Text = reader1("CLAIM").ToString()
            Form114.TextBox4.Text = reader1("SEBEP").ToString()
            Form114.TextBox5.Text = reader1("ACIKLAMA").ToString()
            Form114.ComboBox2.Text = reader1("DOVKOD").ToString()
            Form114.TextBox6.Text = reader1("ALACAK").ToString()
            Form114.TextBox7.Text = reader1("BORC").ToString()
            Form114.ComboBox2.Text = reader1("TIPI").ToString()
            Form114.TextBox9.Text = reader1("CLAIM_ACIKLAMA").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------
        Me.Close()
        '---------------------------------------------------------------------------------------------
    End Sub
End Class