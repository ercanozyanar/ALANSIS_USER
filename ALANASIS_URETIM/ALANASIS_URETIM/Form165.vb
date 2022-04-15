Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form165
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim indeks, girdikontrol
        girdikontrol = ""
        indeks = "0"
        indeks = DataGridView1.CurrentCell.ColumnIndex
        If indeks = "0" Then
            Form144.TextEdit1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            Form144.TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            Form144.TextEdit2.Text = "ALASEHIR "
            Form144.TextEdit3.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            'Form144.TextEdit5.Text = "KIRAZ"
            'Form144.TextEdit6.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
            Form144.MdiParent = Form2
            Form144.Show()
        End If
        If indeks = "1" Then
            girdikontrol = DataGridView1.CurrentRow.Cells(14).Value.ToString
            SqlConn.Open()
            Dim mySelectQuery21 As String = "Select* From EO_KIRAZGIRDI_KONTROL Where ID='" & girdikontrol & "';"
            Dim SqlComm21 As New System.Data.SqlClient.SqlCommand(mySelectQuery21, SqlConn)
            Dim reader21 As System.Data.SqlClient.SqlDataReader
            reader21 = SqlComm21.ExecuteReader()
            While reader21.Read()
                Form144.TextEdit1.Text = reader21("HASAT_TARIH").ToString()
                Form144.TextEdit30.Text = reader21("ANALIZ_TARIH").ToString()
                Form144.ComboBoxEdit1.Text = reader21("VARDIYA").ToString()
                Form144.TextEdit2.Text = reader21("TESIS").ToString()
                Form144.TextEdit3.Text = reader21("UBT_KODU").ToString()
                Form144.TextEdit4.Text = reader21("ARAC_PLAKA").ToString()
                'Form144.TextEdit5.Text = reader21("CESIT_ADI").ToString()
                'Form144.TextEdit6.Text = reader21("TOPLAM_TONAJ").ToString()
                Form144.TextEdit7.Text = reader21("NUMUNE_MIKTARI").ToString()
                Form144.TextEdit8.Text = reader21("YABANCI_MADDE").ToString()
                Form144.TextEdit9.Text = reader21("KUFLENME").ToString()
                Form144.TextEdit10.Text = reader21("DAL_SURTMESI").ToString()
                Form144.TextEdit11.Text = reader21("CURUME").ToString()
                Form144.TextEdit12.Text = reader21("YUMUSAK").ToString()
                Form144.TextEdit13.Text = reader21("ICKURD").ToString()
                Form144.TextEdit14.Text = reader21("IKIZMEYVE").ToString()
                Form144.TextEdit15.Text = reader21("EBAT_ALTI").ToString()
                Form144.TextEdit16.Text = reader21("HASAR").ToString()
                Form144.TextEdit17.Text = reader21("DOLU_ZARAR").ToString()
                Form144.TextEdit18.Text = reader21("TOPLAM_KUSUR").ToString()
                Form144.TextEdit19.Text = reader21("BRIX").ToString()
                Form144.TextEdit20.Text = reader21("K22").ToString()
                Form144.TextEdit21.Text = reader21("K24").ToString()
                Form144.TextEdit22.Text = reader21("K26").ToString()
                Form144.TextEdit23.Text = reader21("K28").ToString()
                Form144.TextEdit24.Text = reader21("SAPSIZ_MEYVE").ToString()
                Form144.ComboBoxEdit2.Text = reader21("PESTISIT").ToString()
                'Form144.TextEdit28.Text = reader21("TAT").ToString()
                'Form144.TextEdit27.Text = reader21("KOKU").ToString()
                'Form144.TextEdit26.Text = reader21("YAPI").ToString()
                Form144.TextEdit25.Text = reader21("SICAKLIK").ToString()
                Form144.ComboBoxEdit3.Text = reader21("ARAC_KONTROL").ToString()
                'Form144.ComboBoxEdit4.Text = reader21("KONTROL_SONUC").ToString()
                Form144.TextEdit29.Text = reader21("KALITE_PERSONEL").ToString()
                Form144.SimpleButton1.Enabled = False
                Form144.SimpleButton2.Enabled = False
            End While
            reader21.Close()
            SqlConn.Close()
            Form144.MdiParent = Form2
            Form144.Show()
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim rk As Integer
        rk = 0
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()

        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT CASE KLTINDEX WHEN '0' THEN 'MEYVE ALIM SAHASINDA' WHEN '1' THEN 'DEPODA MAL KABUL YAPILIYOR' WHEN '2' THEN 'MAL KABUL YAPILDI' WHEN '3' THEN 'KALITE KONTROL OK' END AS DURUM,TARIH,ID AS ALANSIS_MADSERI,URETICI_ADSOY,BOLGE,KANTARNO,KASA_SAYI,BRUT,NET,DARA,MADNO,KLTINDEX,GIRDIKONTROL FROM EO_ALANSIS_MAD"
        da.SelectCommand = cmd
        DataGridView1.ClearSelection()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        DataGridView1.Columns(0).Width = 400
        DataGridView1.Columns(1).Width = 100
        cnn.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1
            rk = DataGridView1.Rows(i).Cells(13).Value.ToString
            If rk = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
            End If
            If rk = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Cyan
            End If

            If rk = 2 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Green
            End If
            If rk = 3 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            End If
            '------------------------------------------------------------------------------
        Next
    End Sub

    Private Sub Form165_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim rk As Integer
        rk = 0
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()

        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT CASE KLTINDEX WHEN '0' THEN 'MEYVE ALIM SAHASINDA' WHEN '1' THEN 'DEPODA MAL KABUL YAPILIYOR' WHEN '2' THEN 'MAL KABUL YAPILDI' WHEN '3' THEN 'KALITE KONTROL OK' END AS DURUM,TARIH,ID AS ALANSIS_MADSERI,URETICI_ADSOY,BOLGE,KANTARNO,KASA_SAYI,BRUT,NET,DARA,MADNO,KLTINDEX FROM EO_ALANSIS_MAD"
        da.SelectCommand = cmd
        DataGridView1.ClearSelection()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        DataGridView1.Columns(0).Width = 400
        DataGridView1.Columns(1).Width = 100

        cnn.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    rk = DataGridView1.Rows(i).Cells(12).Value.ToString
        '    If rk = 0 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
        '    End If
        '    If rk = 1 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Cyan
        '    End If

        '    If rk = 2 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Green
        '    End If
        '    If rk = 3 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        '    End If

        '------------------------------------------------------------------------------
        ' Next
    End Sub
End Class