Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form136
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        If ComboBoxEdit1.Text = "HAMMADDE KIRAZ" Then
            TextBox1.Text = "HMD01-02-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE INCIR" Then
            TextBox1.Text = "HMD01-02-0002"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE KAYISI" Then
            TextBox1.Text = "HMD01-03-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE MALATYA KAYISI" Then
            TextBox1.Text = "HMD01-03-0002"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE NAR" Then
            TextBox1.Text = "HMD01-05-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE ERIK" Then
            TextBox1.Text = "HMD01-08-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE ARMUT" Then
            TextBox1.Text = "HMD01-09-0001"
        End If

        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT STOK_KODU,(SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND HARAKET_KODU='G' AND DEPO_KODU='10') AS GIRIS_BAKIYE FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND DEPO_KODU='10' GROUP BY STOK_KODU;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit1.Text = reader1("GIRIS_BAKIYE").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT STOK_KODU,(SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND HARAKET_KODU='C' AND DEPO_KODU='10') AS CIKIS_BAKIYE FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND DEPO_KODU='10' GROUP BY STOK_KODU;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit2.Text = reader2("CIKIS_BAKIYE").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT STOK_KODU,((SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND HARAKET_KODU='G' AND DEPO_KODU='10') -(SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND HARAKET_KODU='C' AND DEPO_KODU='10')) AS MIKTARX FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND DEPO_KODU='10' GROUP BY STOK_KODU"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextEdit3.Text = reader3("MIKTARX").ToString()
        End While
        reader3.Close()
        SqlConn.Close()
        '=====================================================================================================
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,STOK_KODU,STOK_ADI,BELGENO,HARAKET_TIPI,CASE HARAKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END AS HARAKET_TIPI,MIKTAR,GELDIGI_YER,RENK,DEPO_KODU FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND DEPO_KODU='10'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------

    End Sub
    Private Sub Form136_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,STOK_KODU,STOK_ADI,BELGENO,HARAKET_TIPI,CASE HARAKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END AS HARAKET_TIPI,MIKTAR,GELDIGI_YER,RENK,DEPO_KODU FROM EO_ALANSIS_HAMHAR WHERE STOK_KODU='" & TextBox1.Text & "' AND DEPO_KODU='10'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Form137.Show()
    End Sub

    Private Sub SeriİzlemeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Form141.TextBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Form141.Show()
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class