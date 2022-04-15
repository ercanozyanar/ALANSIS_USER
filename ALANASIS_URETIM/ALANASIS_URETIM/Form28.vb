Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form28

    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT USR FROM EO_ALANSIS_USER group by USR;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("USR"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        cnn1.Open()
        Dim mySelectQuery2 As String = "SELECT AD FROM EO_ALANSIS_MODUL group by AD;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, cnn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            ComboBox1.Items.Add(reader2("AD"))
        End While
        reader2.Close()
        cnn1.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim yetki, kontrol
        yetki = ""
        '------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery2 As String = "SELECT USR FROM EO_ALANSIS_USER_YETKI WHERE USR='" & ComboBox2.Text & "' AND YETKI='" & TextBox1.Text & "';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            kontrol = reader2("USR")
        End While
        reader2.Close()
        conn1.Close()
        If kontrol = "" Then
            '---------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_USER_YETKI (USR,YETKI,AD,EH) VALUES ( '" & ComboBox2.Text & "','" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox3.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd2.Connection = conn1
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "SELECT USR,AD,EH FROM EO_ALANSIS_USER_YETKI"
            da.SelectCommand = cmd2
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            conn1.Close()
            Exit Sub
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Yetki Daha önce tanımlanmış...")

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Satın Alma Talep Kayıt" Then
            TextBox1.Text = "BarButtonItem1"
        End If
        If ComboBox1.Text = "Satın Alma Talep (Onay Bekleyenler)" Then
            TextBox1.Text = "BarButtonItem2"
        End If
        If ComboBox1.Text = "Satın Alma Talep (Onaylananlar)" Then
            TextBox1.Text = "BarButtonItem3"
        End If
        If ComboBox1.Text = "Satın Alma Talep (Red Edilenler)" Then
            TextBox1.Text = "BarButtonItem4"
        End If
        If ComboBox1.Text = "Satıcı Sipariş Kayıt" Then
            TextBox1.Text = "BarButtonItem6"
        End If
        If ComboBox1.Text = "Satış Giriş Modulu" Then
            TextBox1.Text = "BarButtonItem8"
        End If
        If ComboBox1.Text = "Satış Veri Analiz" Then
            TextBox1.Text = "BarButtonItem9"
        End If
        If ComboBox1.Text = "Satış Claim Giriş" Then
            TextBox1.Text = "BarButtonItem10"
        End If
        If ComboBox1.Text = "Satış Döviz Giriş Parite" Then
            TextBox1.Text = "BarButtonItem11"
        End If
        If ComboBox1.Text = "Talep-Sipariş Takip" Then
            TextBox1.Text = "BarButtonItem12"
        End If
        If ComboBox1.Text = "Depo Mal Kabul İzleme ve Rapor" Then
            TextBox1.Text = "BarButtonItem13"
        End If
        If ComboBox1.Text = "KIVI Depo İzleme ve Rapor" Then
            TextBox1.Text = "BarButtonItem14"
        End If
        If ComboBox1.Text = "Depo Hammadde Mal Kabul ve Fire Rapor" Then
            TextBox1.Text = "BarButtonItem15"
        End If
        If ComboBox1.Text = "Üretim Sarf Stok İzleme ve Rapor" Then
            TextBox1.Text = "BarButtonItem16"
        End If
        If ComboBox1.Text = "Depo Sarf Stok İzleme ve Rapor" Then
            TextBox1.Text = "BarButtonItem17"
        End If
        If ComboBox1.Text = "Depo Sarf Stok Bakiye Rapor" Then
            TextBox1.Text = "BarButtonItem18"
        End If
        If ComboBox1.Text = "KIVI Üretim Sarf Rapor" Then
            TextBox1.Text = "BarButtonItem19"
        End If
        If ComboBox1.Text = "KIVI Üretim Sarf Fire Rapor" Then
            TextBox1.Text = "BarButtonItem20"
        End If
        If ComboBox1.Text = "NAR Üretim Sarf Rapor" Then
            TextBox1.Text = "BarButtonItem21"
        End If
        If ComboBox1.Text = "Kalite Claim Giriş" Then
            TextBox1.Text = "BarButtonItem100"
        End If
        If ComboBox1.Text = "GGN Modulu" Then
            TextBox1.Text = "BarButtonItem101"
        End If
        If ComboBox1.Text = "NAR Hammadde" Then
            TextBox1.Text = "BarSubItem1"
        End If
        If ComboBox1.Text = "NAR Mamul" Then
            TextBox1.Text = "BarSubItem5"
        End If
        If ComboBox1.Text = "KIVI Hammadde" Then
            TextBox1.Text = "BarSubItem6"
        End If
        If ComboBox1.Text = "KIVI Mamul" Then
            TextBox1.Text = "BarSubItem7"
        End If
        If ComboBox1.Text = "KİRAZ Hammadde" Then
            TextBox1.Text = "BarSubItem8"
        End If
        If ComboBox1.Text = "KİRAZ Mamul" Then
            TextBox1.Text = "BarSubItem9"
        End If
        If ComboBox1.Text = "NAR Paketleme" Then
            TextBox1.Text = "BarSubItem10"
        End If
        If ComboBox1.Text = "KİRAZ Paketleme" Then
            TextBox1.Text = "BarSubItem11"
        End If
        If ComboBox1.Text = "NAR Grafik Raporu" Then
            TextBox1.Text = "BarSubItem12"
        End If
        If ComboBox1.Text = "KİRAZ Grafik Raporu" Then
            TextBox1.Text = "BarSubItem13"
        End If
        If ComboBox1.Text = "NAR Parametre" Then
            TextBox1.Text = "BarSubItem14"
        End If
        If ComboBox1.Text = "KİRAZ Parametre" Then
            TextBox1.Text = "BarSubItem15"
        End If
        If ComboBox1.Text = "KIVI Parametre" Then
            TextBox1.Text = "BarSubItem16"
        End If
        If ComboBox1.Text = "KİVİ Operasyonlar" Then
            TextBox1.Text = "BarSubItem17"
        End If
        If ComboBox1.Text = "NAR Parametre" Then
            TextBox1.Text = "BarSubItem18"
        End If
        If ComboBox1.Text = "KİRAZ Parametre" Then
            TextBox1.Text = "BarSubItem19"
        End If
        If ComboBox1.Text = "KIVI Parametre" Then
            TextBox1.Text = "BarSubItem20"
        End If
        If ComboBox1.Text = "Şifre Değiştirme" Then
            TextBox1.Text = "BarButtonItem91"
        End If

        If ComboBox1.Text = "Şifre Değiştirme" Then
            TextBox1.Text = "BarButtonItem93"
        End If
        If ComboBox1.Text = "Tasarım" Then
            TextBox1.Text = "BarButtonItem94"
        End If
        If ComboBox1.Text = "Rapor Aç" Then
            TextBox1.Text = "BarButtonItem95"
        End If
        If ComboBox1.Text = "Satış Analiz Rapor" Then
            TextBox1.Text = "BarButtonItem96"
        End If
        If ComboBox1.Text = "Sarf Tüketim Rapor" Then
            TextBox1.Text = "BarButtonItem97"
        End If
        If ComboBox1.Text = "Satın Alma Rapor" Then
            TextBox1.Text = "BarButtonItem98"
        End If
        If ComboBox1.Text = "Yetki Atama" Then
            TextBox1.Text = "BarButtonItem92"
        End If
        If ComboBox1.Text = "Onaylanacak Siparişler" Then
            TextBox1.Text = "BarButtonItem116"
        End If

        If ComboBox1.Text = "Son Onay Siparişler" Then
            TextBox1.Text = "BarButtonItem123"
        End If
        If ComboBox1.Text = "Onaylanmış Siparişler" Then
            TextBox1.Text = "BarButtonItem117"
        End If
        If ComboBox1.Text = "RED Edilen Siparişler" Then
            TextBox1.Text = "BarButtonItem118"
        End If
        If ComboBox1.Text = "Üretim Depo Hammadde Seçim" Then
            TextBox1.Text = "BarButtonItem120"
        End If
        If ComboBox1.Text = "Üretici GGN Tanımlama" Then
            TextBox1.Text = "BarButtonItem127"
        End If
        If ComboBox1.Text = "Kiraz Girdi Kontrol" Then
            TextBox1.Text = "BarButtonItem124"
        End If
        If ComboBox1.Text = "Kiraz Paketleme Kontrol" Then
            TextBox1.Text = "BarButtonItem125"
        End If
        If ComboBox1.Text = "Kiraz Fumigasyon Kontrol" Then
            TextBox1.Text = "BarButtonItem126"
        End If

        If ComboBox1.Text = "Karayolu Lojistik Giriş" Then
            TextBox1.Text = "BarButtonItem102"
        End If
        If ComboBox1.Text = "Lojistik Özet Liste" Then
            TextBox1.Text = "BarButtonItem103"
        End If
        If ComboBox1.Text = "Lojistik Güncel Durum" Then
            TextBox1.Text = "BarButtonItem104"
        End If
        If ComboBox1.Text = "Lojistik Yükleme Durumları" Then
            TextBox1.Text = "BarButtonItem105"
        End If
        If ComboBox1.Text = "Teslim - Fark Durum" Then
            TextBox1.Text = "BarButtonItem106"
        End If
        If ComboBox1.Text = "Transit Süre Durum" Then
            TextBox1.Text = "BarButtonItem107"
        End If
        If ComboBox1.Text = "Nakliye Durum" Then
            TextBox1.Text = "BarButtonItem108"
        End If
        If ComboBox1.Text = "Lojistik Detay" Then
            TextBox1.Text = "BarButtonItem109"
        End If


        If ComboBox1.Text = "Havayolu Lojistik Giriş" Then
            TextBox1.Text = "BarButtonItem110"
        End If
        If ComboBox1.Text = "Havayolu Navlun Giriş" Then
            TextBox1.Text = "BarButtonItem111"
        End If
        If ComboBox1.Text = "Denizyolu Lojistik Giriş" Then
            TextBox1.Text = "BarButtonItem112"
        End If
        If ComboBox1.Text = "Denizyolu Navlun Giriş" Then
            TextBox1.Text = "BarButtonItem115"
        End If
        If ComboBox1.Text = "Hammadde Stok Hareket İzleme" Then
            TextBox1.Text = "BarButtonItem121"
        End If
        If ComboBox1.Text = "Hammadde Stok Hücre Bakiye İzleme" Then
            TextBox1.Text = "BarButtonItem122"
        End If



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim conn1 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        '------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT USR,AD,EH FROM EO_ALANSIS_USER_YETKI WHERE USR= '" & ComboBox2.Text & "'"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()

    End Sub
End Class