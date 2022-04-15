Imports System.Data.SqlClient
Imports System.Xml
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Mail
Public Class Form113
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        On Error Resume Next
        Dim numara, numara2
        Dim numara1 As Integer
        If ComboBox7.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Sube Kodu boş geçilemez...")
            Exit Sub
        Else
            If ComboBox7.Text = "0" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "1" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "2" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "3" Then
                Label20.Text = "KEMER BAHÇE"
            End If
            If ComboBox7.Text = "4" Then
                Label20.Text = "KÖPRÜBAŞI BAHÇE"
            End If
            If ComboBox7.Text = "5" Then
                Label20.Text = "ÇAYKÖY BAHÇE"
            End If
            If ComboBox7.Text = "6" Then
                Label20.Text = "ORAKLAR BAHÇE."
            End If
            If ComboBox7.Text = "7" Then
                Label20.Text = "MALATYA BALABAH BAHÇE"
            End If
            If ComboBox7.Text = "8" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "9" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "10" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "11" Then
                Label20.Text = "ANTALYA"
            End If
            If ComboBox7.Text = "12" Then
                Label20.Text = "BAYRAMİÇ"
            End If
            If ComboBox7.Text = "13" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            If ComboBox7.Text = "14" Then
                Label20.Text = "ALANAR MEYVE VE GIDA ÜRETİM PAZ.SAN.VE TİC.A.Ş."
            End If
            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            SqlConn.Open()
            Dim mySelectQuery As String = "SELECT NUMARA FROM TBLFATUNO WHERE TIP='7' AND ALTTIP IS NULL AND SUBE_KODU='" & ComboBox7.Text & "';"
            Dim SqlComm As New System.Data.SqlClient.SqlCommand(mySelectQuery, SqlConn)
            Dim reader As System.Data.SqlClient.SqlDataReader
            reader = SqlComm.ExecuteReader()
            While reader.Read()
                numara = reader("NUMARA").ToString()
            End While
            reader.Close()
            SqlConn.Close()
            numara1 = Mid(numara, 9, 7)
            numara2 = numara1 + 1
            TextBox16.Text = "00000000" & numara2
            '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Form105.TextBox3.Text = "3"
        Form105.Show()
    End Sub

    Private Sub Form113_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t1, t2, t3, t4
        t1 = Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year
        t2 = Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year
        t3 = Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year
        t4 = Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year
        TextBox27.Text = Date.Today.ToString("yyyy-MM-dd")
        TextBox28.Text = Date.Today.ToString("yyyy-MM-dd")
        TextBox29.Text = Date.Today.ToString("yyyy-MM-dd")
        TextBox30.Text = Date.Today.ToString("yyyy-MM-dd")
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        On Error Resume Next
        Dim NextTime As Date = TextBox27.Text
        TextBox24.Text = NextTime.AddDays(TextBox21.Text)
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Form106.TextBox3.Text = "3"
        Form106.Show()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        On Error Resume Next
        Dim fiyat, miktar As Decimal
        fiyat = CDec(TextBox17.Text)
        miktar = CDec(TextBox14.Text)
        TextBox15.Text = fiyat * miktar
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Dim rdr As XmlTextReader = New XmlTextReader(" http://www.tcmb.gov.tr/kurlar/today.xml")
        Dim ds As DataSet = New DataSet()
        ds.ReadXml(rdr)
        DataGridView2.DataSource = ds.Tables("Currency")
        If ComboBox6.Text = "USD" Then
            TextBox25.Text = "1"
            For x = 0 To DataGridView2.Rows.Count - 1
                If Not String.IsNullOrEmpty(DataGridView2.Rows(x).Cells(10).Value) Then
                    If DataGridView2.Rows(x).Cells(10).Value.ToString().Contains("USD") Then
                        TextBox20.Text = Replace(DataGridView2.Rows(x).Cells(4).Value.ToString(), ".", ",")
                        Exit For
                    End If
                End If
            Next
        End If
        If ComboBox6.Text = "EUR" Then
            TextBox25.Text = "2"
            For x = 0 To DataGridView2.Rows.Count - 1
                If Not String.IsNullOrEmpty(DataGridView2.Rows(x).Cells(10).Value) Then
                    If DataGridView2.Rows(x).Cells(10).Value.ToString().Contains("EUR") Then
                        TextBox20.Text = Replace(DataGridView2.Rows(x).Cells(4).Value.ToString(), ".", ",")
                        Exit For
                    End If
                End If
            Next
        End If
        If ComboBox6.Text = "GBP" Then
            TextBox25.Text = "3"
            For x = 0 To DataGridView2.Rows.Count - 1
                If Not String.IsNullOrEmpty(DataGridView2.Rows(x).Cells(10).Value) Then
                    If DataGridView2.Rows(x).Cells(10).Value.ToString().Contains("GBP") Then
                        TextBox20.Text = Replace(DataGridView2.Rows(x).Cells(4).Value.ToString(), ".", ",")
                        Exit For
                    End If
                End If
            Next
        End If
        If ComboBox6.Text = "TL" Then
            TextBox19.Text = "0"
            TextBox20.Text = "0"
        End If
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        On Error Resume Next
        If TextBox25.Text = "1" Or TextBox25.Text = "2" Or TextBox25.Text = "3" Then
            Dim dovkur, dovfiyat As Decimal
            dovkur = CDec(TextBox20.Text)
            dovfiyat = CDec(TextBox19.Text)
            TextBox17.Text = dovkur * dovfiyat
        End If
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        On Error Resume Next
        If TextBox25.Text = "1" Or TextBox25.Text = "2" Or TextBox25.Text = "3" Then
            Dim dovkur, dovfiyat As Decimal
            dovkur = CDec(TextBox20.Text)
            dovfiyat = CDec(TextBox19.Text)
            TextBox17.Text = dovkur * dovfiyat
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        On Error Resume Next
        Dim fiyat, miktar As Decimal
        fiyat = CDec(TextBox17.Text)
        miktar = CDec(TextBox14.Text)
        TextBox15.Text = fiyat * miktar
    End Sub
    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2, cmd3, cmd4, cmd5 As New SqlCommand
        Dim t1, t2, t3, t4 As String
        Dim da, da1 As New SqlDataAdapter()
        Dim ds, ds1 As New DataSet
        Dim kontrol, sipkontrol
        kontrol = ""
        sipkontrol = ""
        conn1.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
        TextBox4.Text = Val(TextBox4.Text) + 1
        t1 = TextBox27.Text
        t2 = TextBox28.Text
        t3 = TextBox29.Text
        t4 = TextBox30.Text
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd3.Connection = conn1
        cmd3.CommandText = "INSERT INTO TBLSIPATRA(STOK_KODU,FISNO,STHAR_GCMIK,STHAR_GCMIK2,CEVRIM,STHAR_GCKOD,STHAR_TARIH,STHAR_NF,STHAR_BF,STHAR_IAF,STHAR_KDV,DEPO_KODU,STHAR_ACIKLAMA,STHAR_SATISK,STHAR_MALFISK,STHAR_FTIRSIP,STHAR_SATISK2,LISTE_FIAT,STHAR_HTUR,STHAR_DOVTIP,PROMASYON_KODU,STHAR_DOVFIAT,STHAR_ODEGUN,STRA_SATISK3,STRA_SATISK4,STRA_SATISK5,STRA_SATISK6,STHAR_BGTIP,STHAR_KOD2,STHAR_CARIKOD,PLASIYER_KODU,REDMIK,REDNEDEN,SIRA,STRA_SIPKONT,IRSALIYE_TARIH,ECZA_FAT_TIP,STHAR_TESTAR,OLCUBR,BAGLANTI_NO,SUBE_KODU,S_YEDEK1,ONAYTIPI,ONAYNUM) VALUES  ('" & TextBox12.Text & "','" & TextBox16.Text & "','" & Replace(TextBox14.Text, ",", ".") & "','0.00000000','0.00000000','G','" & t1 & "','" & Replace(TextBox17.Text, ",", ".") & "','" & Replace(TextBox17.Text, ",", ".") & "','0.00000000','0.00','" & TextBox5.Text & "','" & TextBox2.Text & "','0.00000000','0.00000','7','0.00000000','1','H','" & TextBox25.Text & "','0','0.000000000000000','0','0.00000000','0.00000000','0.00000000','0.00000000','I','S','" & TextBox2.Text & "','00','0.00000','00','" & TextBox4.Text & "','" & TextBox4.Text & "','" & t1 & "','0','" & t1 & "','1','0','" & ComboBox7.Text & "','018','A','0');"
        cmd3.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------
        conn1.Open()
        cmd4.Connection = conn1
        cmd4.CommandType = CommandType.Text
        cmd4.CommandText = "SELECT* FROM TBLSIPATRA WHERE FISNO='" & TextBox16.Text & "'"
        da.SelectCommand = cmd4
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 2
        Next
        DevExpress.XtraEditors.XtraMessageBox.Show("İşlem Tamam")
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox17.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox5.Text = ""
        ComboBox6.Text = ""
            TextBox4.Text = ""

        TextBox18.Text = ""
            TextBox22.Text = ""
            TextBox23.Text = ""
            Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        On Error GoTo hata
        Dim conn1, conn2 As New SqlConnection
        Dim cmd1, cmd2, cmd3 As New SqlCommand
        Dim t1, t2, t3, t4 As String
        Dim kontrol, kalem_adet, stok_kodu, miktar, depo, fiyat
        Dim tutar, dovtutar As Decimal
        Dim inc As Integer
        Dim ds As New DataSet
        kontrol = ""
        kalem_adet = ""
        tutar = 0
        dovtutar = 0
        t1 = TextBox27.Text
        t2 = TextBox28.Text
        t3 = TextBox29.Text
        t4 = TextBox30.Text
        't1 = Mid(TextBox27.Text, 6, 4) + "-" + Mid(TextBox27.Text, 4, 2) + "" + Mid(TextBox27.Text, 1, 2)
        't2 = Mid(TextBox28.Text, 6, 4) + "-" + Mid(TextBox28.Text, 4, 2) + "" + Mid(TextBox28.Text, 1, 2)
        't3 = Mid(TextBox29.Text, 6, 4) + "-" + Mid(TextBox29.Text, 4, 2) + "" + Mid(TextBox29.Text, 1, 2)
        't4 = Mid(TextBox30.Text, 6, 4) + "-" + Mid(TextBox30.Text, 4, 2) + "" + Mid(TextBox30.Text, 1, 2)
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'TALEP NO AIT KAÇ KALEM KAYIT VAR BULUR
        SqlConn1.Open()
        Dim mySelectQuery2 As String = "SELECT COUNT(STOK_KODU) AS KALEM FROM TBLSIPATRA WHERE FISNO='" & TextBox16.Text & "';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            kalem_adet = reader2("KALEM").ToString()
        End While
        reader2.Close()
        SqlConn1.Close()
        '---------------------------------------------------------------------------------------------------------------------
        'SIPARISE AIT BRUT TUTAR BULUR
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT SUM(STHAR_NF) AS TUTAR FROM TBLSIPATRA WHERE FISNO='" & TextBox16.Text & "';"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextBox26.Text = reader3("TUTAR").ToString()
        End While
        reader3.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------------------------------
        'SIPARISE INCKEY BULUR
        SqlConn.Open()
        Dim mySelectQuery4 As String = "SELECT MAX(INCKEYNO) AS INC FROM TBLSIPATRA;"
        Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        Dim reader4 As System.Data.SqlClient.SqlDataReader
        reader4 = SqlComm4.ExecuteReader()
        While reader4.Read()
            inc = reader4("INC").ToString()
        End While
        reader4.Close()
        SqlConn.Close()
        '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
        'NETSIS SATICI SIPARIS ANA EKRAN
        conn2.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
        conn2.Open()
        cmd2.Connection = conn2
        cmd2.CommandText = "INSERT INTO TBLSIPAMAS(SUBE_KODU,FTIRSIP,FATIRS_NO,CARI_KODU,TARIH,TIPI,BRUTTUTAR,SAT_ISKT,MFAZ_ISKT,GEN_ISK1T,GEN_ISK2T,GEN_ISK3T,GEN_ISK1O,GEN_ISK2O,GEN_ISK3O,KDV,FAT_ALTM1,FAT_ALTM2,ODEMEGUNU,ODEMETARIHI,KDV_DAHILMI,FATKALEM_ADEDI,SIPARIS_TEST,TOPLAM_MIK,TOPDEPO,SIRANO,GENELTOPLAM,PLA_KODU,DOVIZTIP,KS_KODU,BAG_TUTAR,F_YEDEK3,F_YEDEK4,F_YEDEK5,C_YEDEK6,B_YEDEK7,I_YEDEK8,L_YEDEK9,GELSUBE_KODU,ONAYTIPI,ONAYNUM,ISLETME_KODU,EBELGE,HALFAT) VALUES ( '" & ComboBox7.Text & "','7','" & TextBox16.Text & "','" & TextBox2.Text & "','" & t1 & "','2','" & Replace(TextBox26.Text, ",", ".") & "','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','" & TextBox21.Text & "','" & t4 & "','H','" & kalem_adet & "','" & t2 & "','0.00000','0','0','" & Replace(TextBox26.Text, ",", ".") & "','00','" & TextBox25.Text & "','00','0.00000000','0.00000000','1.00000000','0.00000000','X','0','0','0','0','A','0','1','0','0')"
        cmd2.ExecuteNonQuery()
        conn2.Close()
        '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
        conn2.Open()
        cmd3.Connection = conn2
        cmd3.CommandText = "UPDATE TBLFATUNO SET NUMARA='" & TextBox16.Text & "' WHERE SUBE_KODU= '" & ComboBox7.Text & "' AND TIP='7'"
        cmd3.ExecuteNonQuery()
        conn2.Close()
        '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        ComboBox7.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox3.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox17.Text = ""
        TextBox4.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox18.Text = ""
        TextBox16.Text = ""
        TextBox21.Text = ""
        TextBox24.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
        Label25.Text = ""
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Form117.TextBox3.Text = ComboBox7.Text
        Form117.TextBox1.Text = "3"
        Form117.Show()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class