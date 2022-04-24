Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form132
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form132_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cmd.CommandText = "SELECT DURUM,SIPARIS_TURU,PARTI,MUSTERI,SATIS_ONAY,URETIM_ONAY FROM EO_ALANSIS_SATIS WHERE URETIM_ONAY IS NULL"
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
        partino = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_SATIS WHERE PARTI='" & partino & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            Form131.ComboBoxEdit1.Text = reader1("DURUM")
            Form131.ComboBoxEdit2.Text = reader1("SIPARIS_TURU")
            Form131.ComboBoxEdit3.Text = reader1("SINIF")
            Form131.ComboBoxEdit4.Text = reader1("NAKLIYE")
            Form131.TextEdit1.Text = reader1("PARTI")
            Form131.TextEdit2.Text = reader1("MUSTERI")
            Form131.TextEdit19.Text = reader1("ETD")
            Form131.TextEdit20.Text = reader1("ETA")
            Form131.TextEdit17.Text = reader1("KUTU")
            Form131.TextEdit14.Text = reader1("AMBALAJ")
            Form131.TextEdit3.Text = reader1("EBAT")
            Form131.TextEdit4.Text = reader1("MIN_MEYVE_AGIRLIK")
            Form131.TextEdit6.Text = reader1("MIN_KUTU_AGIRLIK")
            Form131.TextEdit5.Text = reader1("PALET_ADET")
            Form131.TextEdit7.Text = reader1("KUTU_ADET")
            Form131.TextEdit8.Text = reader1("TONAJ_KG")
            Form131.TextEdit9.Text = reader1("PLT_KUTU")
            Form131.TextEdit10.Text = reader1("PALET_TIPI")
            Form131.TextEdit11.Text = reader1("ACIKLAMA")
            Form131.TextEdit16.Text = reader1("ETIKET")
            Form131.TextEdit2.Text = reader1("MUSTERI")
            Form131.TextEdit12.Text = reader1("MUSTERI_REFERANS")
            Form131.ComboBoxEdit9.Text = reader1("TESLIM_SEKLI")
            Form131.TextEdit13.Text = reader1("TESLIM_YERI")
            Form131.ComboBoxEdit10.Text = reader1("RENK")
            Form131.TextEdit18.Text = reader1("STOK_KODU")
            Form131.ComboBoxEdit5.Text = reader1("URUN")
            Form131.ComboBoxEdit18.Text = reader1("SATIS_ONAY")
            Form131.ComboBoxEdit16.Text = reader1("URETIM_ONAY")
            Form131.ComboBoxEdit7.Text = reader1("GGN")
            Form131.TextEdit15.Text = reader1("RENK")
        End While
        reader1.Close()
        conn1.Close()
        If grupkontrol = "URETIM" Then
            Form131.ComboBoxEdit18.Enabled = False 'SATIS_ONAY
            Form131.ComboBoxEdit16.Enabled = True 'URETIM_ONAY
            Form131.SimpleButton5.Enabled = False
            Form131.SimpleButton4.Enabled = False
            Form131.TextBox1.Text = "2"
            '==========================================
            Form131.ComboBoxEdit1.Enabled = False
            Form131.ComboBoxEdit2.Enabled = False
            Form131.ComboBoxEdit3.Enabled = False
            Form131.ComboBoxEdit4.Enabled = False
            Form131.TextEdit1.Enabled = False
            Form131.TextEdit2.Enabled = False
            Form131.TextEdit19.Enabled = False
            Form131.TextEdit20.Enabled = False
            Form131.TextEdit17.Enabled = False
            Form131.TextEdit15.Enabled = False
            Form131.TextEdit14.Enabled = False
            Form131.TextEdit3.Enabled = False
            Form131.TextEdit4.Enabled = False
            Form131.TextEdit6.Enabled = False
            Form131.TextEdit5.Enabled = False
            Form131.TextEdit7.Enabled = False
            Form131.TextEdit8.Enabled = False
            Form131.TextEdit9.Enabled = False
            Form131.TextEdit10.Enabled = False
            Form131.TextEdit11.Enabled = True
            Form131.TextEdit16.Enabled = False
            Form131.TextEdit2.Enabled = False
            Form131.TextEdit12.Enabled = False
            Form131.ComboBoxEdit9.Enabled = False
            Form131.TextEdit13.Enabled = False
            Form131.ComboBoxEdit10.Enabled = False
            Form131.TextEdit18.Enabled = False
            Form131.ComboBoxEdit5.Enabled = False
            Form131.ComboBoxEdit18.Enabled = False
            Form131.ComboBoxEdit16.Enabled = True
            Form131.ComboBoxEdit7.Enabled = False
            '=============================================================================================================================
            Form131.MdiParent = Form2
            Form131.Show()
        End If
        If grupkontrol = "SATIS" Then
            Form131.ComboBoxEdit18.Enabled = True 'SATIS_ONAY
            Form131.ComboBoxEdit16.Enabled = False 'URETIM_ONAY
            Form131.TextBox1.Text = "2"
            Form131.SimpleButton5.Enabled = True
            Form131.SimpleButton4.Enabled = True
            '=============================================================================================================================
            Form131.MdiParent = Form2
            Form131.Show()
        End If
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
            cmd.CommandText = "SELECT DURUM,SIPARIS_TURU,PARTI,MUSTERI,SATIS_ONAY,LOJISTIK_ONAY,URETIM_ONAY,KALITE_ONAY,MEYVE_ONAY,ZIRAI_ONAY,SON_ONAY FROM EO_ALANSIS_SATIS WHERE SON_ONAY IS NULL"
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
            If grupkontrol = "URETIM" Then
                cmd.CommandText = "SELECT DURUM,SIPARIS_TURU,PARTI,MUSTERI,SATIS_ONAY,URETIM_ONAY FROM EO_ALANSIS_SATIS WHERE MUSTERI LIKE '%" & TextEdit3.Text & "%' AND  (SATIS_ONAY='OK' AND URETIM_ONAY IS NULL)"
            End If
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
            cmd.CommandText = "SELECT DURUM,SIPARIS_TURU,PARTI,MUSTERI,SATIS_ONAY,URETIM_ONAY FROM EO_ALANSIS_SATIS WHERE URETIM_ONAY IS NULL"
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

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class