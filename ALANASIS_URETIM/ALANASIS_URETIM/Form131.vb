Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Imports DevExpress.XtraEditors.Controls
Public Class Form131
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Sub New()
        InitializeComponent()
        EO_ALANSIS_GGNTableAdapter1.Fill(AlansısDataSet141.EO_ALANSIS_GGN)
    End Sub
    Private Sub Form131_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TBLSTSABITTableAdapter.Fill(Me.ALANAR2021DataSet3.TBLSTSABIT)
        Me.EO_ALANSIS_KUTUTIPIDEPOTableAdapter.Fill(Me.ALANSISDataSet3.EO_ALANSIS_KUTUTIPIDEPO)
        Me.EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter.Fill(Me.ALANSISDataSet3.EO_ALANSIS_KUTUETIKETTIPIDEPO)
        '=============================================================================================================================
        Dim grupkontrol As String
        grupkontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        '=============================================================================================================================
        If TextBox1.Text = "1" Then
            TextEdit16.Visible = True
            TextEdit17.Visible = True
            TextEdit18.Visible = False
            TextEdit19.Visible = False
            TextEdit20.Visible = False
            ComboBoxEdit10.Visible = True
            ComboBoxEdit11.Visible = True
            DateTimeOffsetEdit1.Visible = True
            DateTimeOffsetEdit2.Visible = True
            DateTimeOffsetEdit1.Enabled = False
            DateTimeOffsetEdit2.Enabled = False
            ComboBoxEdit7.Enabled = False
            ComboBoxEdit9.Enabled = False
            TextEdit13.Visible = False
            TextEdit15.Visible = False
        End If
        '************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
        If TextBox1.Text = "2" Then
            If grupkontrol = "SATIS" Then
                TextEdit16.Visible = True
                TextEdit17.Visible = True
                TextEdit18.Visible = False
                TextEdit19.Visible = True
                TextEdit20.Visible = True
                ComboBoxEdit10.Visible = False
                TextEdit15.Visible = True
                ComboBoxEdit11.Visible = True
                DateTimeOffsetEdit1.Visible = False
                DateTimeOffsetEdit2.Visible = False
                DateTimeOffsetEdit1.Enabled = False
                DateTimeOffsetEdit2.Enabled = False
                ComboBoxEdit7.Enabled = False
            End If
            If grupkontrol = "URETIM" Then
                TextEdit16.Visible = True
                TextEdit17.Visible = True
                TextEdit18.Visible = True
                TextEdit19.Visible = True
                TextEdit20.Visible = True
                ComboBoxEdit10.Visible = False
                TextEdit15.Visible = True
                TextEdit15.Enabled = False
                ComboBoxEdit11.Visible = False
                DateTimeOffsetEdit1.Visible = False
                DateTimeOffsetEdit2.Visible = False
            End If
        End If
        '=============================================================================================================================
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI FROM EO_ALANSIS_SATIS"
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
    Private Sub TextEdit5_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit5.EditValueChanged
        On Error Resume Next
        Dim plt, kutu, sonuc As Decimal
        plt = CDec(TextEdit5.Text)
        kutu = CDec(TextEdit9.Text)
        sonuc = plt * kutu
        TextEdit7.Text = sonuc
    End Sub
    Private Sub TextEdit6_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit6.EditValueChanged
        On Error Resume Next
        Dim plt1, kutu1, sonuc1 As Decimal
        plt1 = CDec(TextEdit6.Text)
        kutu1 = CDec(TextEdit7.Text)
        sonuc1 = plt1 * kutu1
        TextEdit8.Text = sonuc1
    End Sub
    Private Sub TextEdit7_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit7.EditValueChanged
        On Error Resume Next
        Dim plt1, kutu1, sonuc1 As Decimal
        plt1 = CDec(TextEdit6.Text)
        kutu1 = CDec(TextEdit7.Text)
        sonuc1 = plt1 * kutu1
        TextEdit8.Text = sonuc1
    End Sub
    Private Sub TextEdit9_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit9.EditValueChanged
        On Error Resume Next
        Dim plt, kutu, sonuc As Decimal
        plt = CDec(TextEdit5.Text)
        kutu = CDec(TextEdit9.Text)
        sonuc = plt * kutu
        TextEdit7.Text = sonuc
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim kontrol, grupkontrol, user, id As String
        Dim x1, x2, x3, x4, x5, ggnkontrol, partikontrol As Decimal
        x1 = 0
        x2 = 0
        x3 = 0
        x4 = 0
        x5 = 0
        user = ""
        id = ""
        user = Trim(Mid(Form2.Text, 15, 50))
        ggnkontrol = 0
        partikontrol = TextEdit8.Text
        x1 = TextEdit5.Text
        x2 = TextEdit6.Text
        x3 = TextEdit7.Text
        x4 = TextEdit8.Text
        x5 = TextEdit9.Text
        grupkontrol = ""
        kontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        If TextBox1.Text = "1" Then
            TextEdit16.Visible = True
            TextEdit17.Visible = True
            TextEdit18.Visible = False
            TextEdit19.Visible = False
            TextEdit20.Visible = False
            ComboBoxEdit11.Visible = True
            DateTimeOffsetEdit1.Visible = True
            DateTimeOffsetEdit2.Visible = True
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT PARTI FROM EO_ALANSIS_SATIS WHERE PARTI='" & TextEdit1.Text & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                kontrol = reader1("PARTI").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            If kontrol = "" Then
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "INSERT INTO EO_ALANSIS_SATIS (DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI,RENK,STOK_KODU,SATIS_ONAY,GGN,URUN) VALUES ( '" & ComboBoxEdit1.Text & "','" & ComboBoxEdit2.Text & "','" & ComboBoxEdit3.Text & "','" & ComboBoxEdit4.Text & "','" & TextEdit1.Text & "','" & TextEdit2.Text & "','" & DateTimeOffsetEdit1.Text & "','" & DateTimeOffsetEdit2.Text & "','" & TextEdit17.Text & "','" & TextEdit14.Text & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "', '" & x1 & "','" & x2 & "','" & x3 & "','" & x4 & "','" & x5 & "','" & TextEdit10.Text & "','" & TextEdit11.Text & "','" & TextEdit16.Text & "','" & TextEdit12.Text & "','" & ComboBoxEdit9.Text & "','" & TextEdit13.Text & "','" & ComboBoxEdit10.Text & "','" & ComboBoxEdit11.Text & "','" & ComboBoxEdit18.Text & "','" & ComboBoxEdit7.Text & "','" & ComboBoxEdit5.Text & "')"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '---------------------------------------------------------------------------------------------------------------
                SqlConn.Open()
                Dim mySelectQuery11 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_SATIS ORDER BY ID DESC;"
                Dim SqlComm11 As New System.Data.SqlClient.SqlCommand(mySelectQuery11, SqlConn)
                Dim reader11 As System.Data.SqlClient.SqlDataReader
                reader11 = SqlComm11.ExecuteReader()
                While reader11.Read()
                    id = reader11("ID").ToString()
                End While
                reader11.Close()
                SqlConn.Close()
                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                SMTP.Timeout = 5
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
                SMTP.Port = "587"
                Mail.Subject = "Parti No: " & TextEdit1.Text & " Satış Onay"
                'Mail.To.Add("ercanozyanar@gmail.com,saadet.atalay@alanar.com.tr,umut.yenmis@alanar.com.tr,ibrahim.erturk@alanar.com.tr,ridvan.akman@alanar.com.tr")
                Mail.To.Add("yigit.gokyigit@alanar.com.tr,tahir.gunsen@alanar.com.tr,tugba.okyay@alanar.com.tr,bakit.akmatov@alanar.com.tr,fatih.bakici@alanar.com.tr,canan.bulut@alanar.com.tr,kalite.saha@alanar.com.tr,uretim.saha@alanar.com.tr,atakan.cetinbilek@alanar.com.tr,beykan.esgicioglu@alanar.com.tr,gulbahar.arikan@alanar.com.tr,esra.kundakci@alanar.com.tr,ercanozyanar@gmail.com,ridvan.akman@alanar.com.tr")
                Mail.From = New MailAddress("alansis.bilgi@gmail.com")
                Mail.IsBodyHtml = True
                Mail.Body = "<p><span>Parti No:" & TextEdit1.Text & " Satış Onay işlemi " & DateTime.Now & " zamanında " & user & " tarafından onaylanmıştır....</span></p><p><strong>Onay Vermek icin lutfen aşağıdaki butonu tıklayınız...</strong></p> <p><strong>&nbsp;<span class= 'redButton' >▼ <a href=http://10.3.11.61/ALANSIS_WB/Onay/Onay/" + id & " > ONAYLA</a></span></strong></p>"
                SMTP.Send(Mail)
                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                ComboBoxEdit1.Text = ""
                ComboBoxEdit2.Text = ""
                ComboBoxEdit3.Text = ""
                ComboBoxEdit4.Text = ""
                TextEdit1.Text = ""
                TextEdit2.Text = ""
                TextEdit19.Text = ""
                TextEdit20.Text = ""
                TextEdit17.Text = ""
                TextEdit14.Text = ""
                TextEdit3.Text = ""
                TextEdit4.Text = ""
                TextEdit6.Text = ""
                TextEdit5.Text = ""
                TextEdit7.Text = ""
                TextEdit8.Text = ""
                TextEdit9.Text = ""
                TextEdit10.Text = ""
                TextEdit11.Text = ""
                TextEdit16.Text = ""
                TextEdit2.Text = ""
                TextEdit12.Text = ""
                ComboBoxEdit9.Text = ""
                TextEdit13.Text = ""
                ComboBoxEdit10.Text = ""
                TextEdit18.Text = ""
                ComboBoxEdit18.Text = ""
                ComboBoxEdit16.Text = ""
                ComboBoxEdit7.Text = ""
                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Me.Hide()
                DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                conn1.Open()
                cmd2.Connection = conn1
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "SELECT DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI FROM EO_ALANSIS_SATIS ORDER BY ID DESC"
                da.SelectCommand = cmd2
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0).DefaultView
                conn1.Close()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("PARTI NO Daha önce sisteme kayıt edilmiştir.Lütfen Kontrol ediniz...")
                Exit Sub
            End If
        End If
        '************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
        If TextBox1.Text = "2" Then
            If grupkontrol = "SATIS" Then
                TextEdit16.Visible = True
                TextEdit17.Visible = True
                TextEdit18.Visible = True
                TextEdit19.Visible = True
                TextEdit20.Visible = True
                ComboBoxEdit11.Visible = False
                DateTimeOffsetEdit1.Visible = False
                DateTimeOffsetEdit2.Visible = False
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "UPDATE EO_ALANSIS_SATIS  SET DURUM='" & ComboBoxEdit1.Text & "',SIPARIS_TURU='" & ComboBoxEdit2.Text & "',SINIF='" & ComboBoxEdit3.Text & "',NAKLIYE='" & ComboBoxEdit4.Text & "',PARTI='" & TextEdit1.Text & "' ,MUSTERI='" & TextEdit2.Text & "',ETD='" & TextEdit19.Text & "',ETA='" & TextEdit20.Text & "',KUTU='" & TextEdit17.Text & "',AMBALAJ='" & TextEdit14.Text & "',EBAT='" & TextEdit3.Text & "',MIN_MEYVE_AGIRLIK='" & TextEdit4.Text & "',MIN_KUTU_AGIRLIK='" & TextEdit6.Text & "',PALET_ADET='" & TextEdit5.Text & "',KUTU_ADET='" & TextEdit7.Text & "',TONAJ_KG='" & TextEdit8.Text & "',PLT_KUTU='" & TextEdit9.Text & "',PALET_TIPI='" & TextEdit10.Text & "',ACIKLAMA='" & TextEdit11.Text & "',ETIKET='" & TextEdit16.Text & "',MUSTERI_REFERANS='" & TextEdit12.Text & "',TESLIM_SEKLI='" & ComboBoxEdit9.Text & "',TESLIM_YERI='" & TextEdit13.Text & "',RENK='" & ComboBoxEdit10.Text & "',STOK_KODU='" & TextEdit18.Text & "',SATIS_ONAY='" & ComboBoxEdit18.Text & "',GGN='" & ComboBoxEdit7.Text & "' WHERE PARTI='" & TextEdit1.Text & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                conn1.Open()
                cmd2.Connection = conn1
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "SELECT DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI FROM EO_ALANSIS_SATIS"
                da.SelectCommand = cmd2
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0).DefaultView
                conn1.Close()
                '---------------------------------------------------------------------------------------------------------------
                SqlConn.Open()
                Dim mySelectQuery12 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_SATIS ORDER BY ID DESC;"
                Dim SqlComm12 As New System.Data.SqlClient.SqlCommand(mySelectQuery12, SqlConn)
                Dim reader12 As System.Data.SqlClient.SqlDataReader
                reader12 = SqlComm12.ExecuteReader()
                While reader12.Read()
                    id = reader12("ID").ToString()
                End While
                reader12.Close()
                SqlConn.Close()
                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                SMTP.Timeout = 5
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
                SMTP.Port = "587"
                Mail.Subject = "Parti No: " & TextEdit1.Text & " Satış Onay"
                'Mail.To.Add("ercanozyanar@gmail.com,saadet.atalay@alanar.com.tr,umut.yenmis@alanar.com.tr,ibrahim.erturk@alanar.com.tr,ridvan.akman@alanar.com.tr")
                Mail.To.Add("yigit.gokyigit@alanar.com.tr,tahir.gunsen@alanar.com.tr,tugba.okyay@alanar.com.tr,bakit.akmatov@alanar.com.tr,fatih.bakici@alanar.com.tr,canan.bulut@alanar.com.tr,kalite.saha@alanar.com.tr,uretim.saha@alanar.com.tr,atakan.cetinbilek@alanar.com.tr,beykan.esgicioglu@alanar.com.tr,gulbahar.arikan@alanar.com.tr,esra.kundakci@alanar.com.tr,ercanozyanar@gmail.com,ridvan.akman@alanar.com.tr")
                Mail.From = New MailAddress("alansis.bilgi@gmail.com")
                Mail.IsBodyHtml = True
                Mail.Body = "<p><span>Parti No:" & TextEdit1.Text & " Satış Onay işlemi " & DateTime.Now & " zamanında " & user & " tarafından onaylanmıştır....</span></p><p><strong>Onay Vermek icin lutfen aşağıdaki butonu tıklayınız...</strong></p> <p><strong>&nbsp;<span class= 'redButton' >▼ <a href=http://10.3.11.61/ALANSIS_WB/Onay/Onay/" + id & " > ONAYLA</a></span></strong></p>"
                SMTP.Send(Mail)
                DevExpress.XtraEditors.XtraMessageBox.Show("Onay İşlemi Tamamlanmiştir...")
                Me.Hide()
            End If
            If grupkontrol = "URETIM" Then
                TextEdit16.Visible = True
                TextEdit17.Visible = True
                TextEdit18.Visible = True
                TextEdit19.Visible = True
                TextEdit20.Visible = True
                ComboBoxEdit11.Visible = False
                DateTimeOffsetEdit1.Visible = False
                DateTimeOffsetEdit2.Visible = False
                If ComboBoxEdit18.Text <> "" Then
                    conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                    conn1.Open()
                    cmd1.Connection = conn1
                    cmd1.CommandText = "UPDATE EO_ALANSIS_SATIS  SET ACIKLAMA='" & TextEdit11.Text & "',URETIM_ONAY='" & ComboBoxEdit16.Text & "' WHERE PARTI='" & TextEdit1.Text & "'"
                    cmd1.ExecuteNonQuery()
                    conn1.Close()
                    conn1.Open()
                    cmd2.Connection = conn1
                    cmd2.CommandType = CommandType.Text
                    cmd2.CommandText = "SELECT DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI FROM EO_ALANSIS_SATIS"
                    da.SelectCommand = cmd2
                    da.Fill(ds)
                    DataGridView1.DataSource = ds.Tables(0).DefaultView
                    conn1.Close()
                    SMTP.Timeout = 5
                    SMTP.EnableSsl = True
                    SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
                    SMTP.Port = "587"
                    Mail.Subject = "Parti No: " & TextEdit1.Text & " Üretim Onay"
                    'Mail.To.Add("ercanozyanar@gmail.com,husamettin.ilgez@alanar.com.tr,alper.sener@alanar.com.tr,burak.sacin@alanar.com.tr,ridvan.akman@alanar.com.tr")
                    Mail.To.Add("yigit.gokyigit@alanar.com.tr,tahir.gunsen@alanar.com.tr,tugba.okyay@alanar.com.tr,bakit.akmatov@alanar.com.tr,fatih.bakici@alanar.com.tr,canan.bulut@alanar.com.tr,kalite.saha@alanar.com.tr,uretim.saha@alanar.com.tr,atakan.cetinbilek@alanar.com.tr,beykan.esgicioglu@alanar.com.tr,gulbahar.arikan@alanar.com.tr,esra.kundakci@alanar.com.tr,ercanozyanar@gmail.com,ridvan.akman@alanar.com.tr")
                    Mail.From = New MailAddress("alansis.bilgi@gmail.com")
                    Mail.Body = "Parti No: " & TextEdit1.Text & " Üretim Onay işlemi " & DateTime.Now & " zamanında " & user & " tarafından onaylanmıştır..."
                    SMTP.Send(Mail)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Onay İşlemi Tamamlanmiştir...")
                    Me.Close()
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Satış Onayı Eksik,Onay veremezsiniz...")
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim silid
        silid = ""
        silid = DataGridView1.CurrentRow.Cells(4).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From EO_ALANSIS_SATIS Where PARTI='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit Silinmiştir...")
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI  FROM EO_ALANSIS_SATIS"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        '______________________________________________________________________________________________________________________________
        Exit Sub
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Form94.TextBox30.Text = TextEdit1.Text
        Form94.MdiParent = Form2
        Form94.Show()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If TextEdit1.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("PARTI NO Boş geçilemez, Lütfen kontrol ediniz...")
            Exit Sub
        End If
        If ComboBoxEdit10.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("RENK KODU Boş geçilemez, Lütfen kontrol ediniz...")
            Exit Sub
        End If
        Form118.TextEdit21.Text = TextEdit1.Text
        Form118.TextEdit22.Text = ComboBoxEdit11.Text
        If ComboBoxEdit11.Text = "" Then
            Form118.TextEdit22.Text = TextEdit18.Text
        End If
        Form118.TextEdit23.Text = ComboBoxEdit2.Text
        Form118.TextBox1.Text = ComboBoxEdit10.Text
        If ComboBoxEdit10.Text = "" Then
            Form118.TextEdit1.Text = TextEdit15.Text
        End If
        Form118.MdiParent = Form2
        Form118.Show()
    End Sub
    Private Sub ComboBoxEdit18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit18.SelectedIndexChanged
        If ComboBoxEdit18.Text = "NOK" Then
            Form140.TextEdit1.Text = TextEdit1.Text
            Form140.TextEdit2.Text = "SATIS"
            Form140.Show()
        End If
    End Sub
    Private Sub ComboBoxEdit16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit16.SelectedIndexChanged
        If ComboBoxEdit16.Text = "NOK" Then
            Form140.TextEdit1.Text = TextEdit1.Text
            Form140.TextEdit2.Text = "URETIM"
            Form140.Show()
        End If
    End Sub
    Private Sub ComboBoxEdit7_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit7.TextChanged
        On Error Resume Next
        Dim kontrol, partimiktar As Decimal
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        kontrol = 0
        partimiktar = TextEdit8.Text
        '------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_GGN WHERE GGN_NO='" & ComboBoxEdit7.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            kontrol = reader1("PARTI_KAPASITE")
        End While
        reader1.Close()
        conn1.Close()
        '------------------------------------------------------------------------------------------------------------------------------
        If kontrol > partimiktar Then
            DevExpress.XtraEditors.XtraMessageBox.Show("GGN Kapasite miktar aşılmaktadır, Lütfen kontrol ediniz...")
            ComboBoxEdit7.Text = ""
            Exit Sub
        End If

    End Sub
    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        Form163.TextEdit2.Text = TextEdit1.Text
        Form163.TextEdit3.Text = TextEdit18.Text
        Form163.TextEdit4.Text = TextEdit8.Text
        Form163.TextBox1.Text = TextEdit6.Text
        Form163.TextBox2.Text = TextEdit9.Text
        Form163.TextBox3.Text = TextEdit5.Text
        Form163.MdiParent = Form2
        Form163.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class