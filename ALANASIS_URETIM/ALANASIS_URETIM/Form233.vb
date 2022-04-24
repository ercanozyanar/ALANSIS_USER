Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form233
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub Form233_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '=============================================================================================================================================================
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KIMYO_TAKIP WHERE KIMYO_ONAY IS NULL"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '=============================================================================================================================================================
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim karar, id, partino, seri, monay, zonay As String
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        monay = ""
        zonay = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        Dim conn1 As New SqlConnection
        partino = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_KIMYO_TAKIP WHERE TAKIP_NO='" & partino & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            Form231.TextEdit6.Text = reader1("TAKIP_NO")
            Form231.TextEdit1.Text = reader1("PROJE_ADI")
            Form231.MemoEdit1.Text = reader1("PROJE_ACIKLAMASI")
            Form231.ComboBoxEdit1.Text = reader1("TALEP_EDILEN_MEYVE")
            Form231.TextEdit12.Text = reader1("CESIT")
            Form231.TextEdit2.Text = reader1("EBAT")
            Form231.TextEdit3.Text = reader1("MIKTAR")
            Form231.TextEdit7.Text = reader1("TOPLAM_TUTAR")
            Form231.DateEdit1.Text = reader1("ETKINLIK_TARIHI")
            Form231.DateEdit2.Text = reader1("TESLIM_TARIHI")
            Form231.TextEdit8.Text = reader1("TESLIM_KISI")
            Form231.MemoEdit2.Text = reader1("TESLIM_ADRES")
            Form231.MemoEdit3.Text = reader1("GONDERIM_NOT")
            Form231.TextEdit9.Text = reader1("TALEP_SAHIBI")
            Form231.ComboBoxEdit2.Text = reader1("KIMYO_ONAY")
        End While
        reader1.Close()
        conn1.Close()
        Form231.ComboBoxEdit2.Enabled = True
        Form231.MdiParent = Form2
        Form231.Show()

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '=============================================================================================================================================================
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KIMYO_TAKIP WHERE PROJE_ADI LIKE '%" & TextEdit1.Text & "%' AND ( KIMYO_ONAY IS NULL)"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '=============================================================================================================================================================
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------

    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '=============================================================================================================================================================
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KIMYO_TAKIP WHERE PROJE_ACIKLAMASI LIKE '%" & TextEdit3.Text & "%' AND ( KIMYO_ONAY IS NULL)"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '=============================================================================================================================================================
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------

    End Sub
End Class