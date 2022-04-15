Imports System.Data.SqlClient
Imports System.Xml
Public Class Form111
    '----------------------------------------------------------------------------------------------------------------------------------------
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    '----------------------------------------------------------------------------------------------------------------------------------------
    Dim SqlConnStr2 As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn2 As New System.Data.SqlClient.SqlConnection(SqlConnStr2)
    '---------------------------------------------------------------------------------------------------------------------
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox12.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TextBox13.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        TextBox27.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        TextBox14.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        TextBox17.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        TextBox15.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        TextBox23.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        TextBox18.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        TextBox22.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        TextBox5.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        TextBox6.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
    End Sub
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        On Error GoTo hata
        Process.Start(TextBox4.Text)
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Dosya mevcut değil...")
        Exit Sub
    End Sub
    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        On Error GoTo hata
        Process.Start(TextBox5.Text)
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Dosya mevcut değil...")
        Exit Sub
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        On Error GoTo hata
        Process.Start(TextBox6.Text)
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Dosya mevcut değil...")
        Exit Sub
    End Sub
    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        On Error GoTo hata
        Dim conn1, conn2 As New SqlConnection
        Dim cmd1, cmd2, cmd3 As New SqlCommand
        Dim t1, t2, t3, t4, t5 As String
        Dim kontrol, kalem_adet, stok_kodu, miktar, depo, fiyat
        Dim tutar, dovtutar As Decimal
        Dim inc As Integer
        Dim ds As New DataSet
        kontrol = ""
        kalem_adet = ""
        tutar = 0
        dovtutar = 0
        If TextBox21.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Vade Tarihi boş,lütfen kontrol ediniz...")
            Exit Sub
        Else
            '---------------------------------------------------------------------------------------------------------------------
            'TALEP NO AIT KAÇ KALEM KAYIT VAR BULUR
            SqlConn1.Open()
            Dim mySelectQuery2 As String = "SELECT COUNT(TEKLIFTRANO) AS KALEM FROM EO_ALANSIS_TEKLIFTRA WHERE TEKLIFTRANO='" & TextBox1.Text & "';"
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
            SqlConn1.Open()
            Dim mySelectQuery3 As String = "SELECT SUM(TUTAR) AS TUTAR FROM EO_ALANSIS_SIPATRA WHERE SIPARIS_NO='" & TextBox16.Text & "';"
            Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn1)
            Dim reader3 As System.Data.SqlClient.SqlDataReader
            reader3 = SqlComm3.ExecuteReader()
            While reader3.Read()
                TextBox26.Text = reader3("TUTAR").ToString()
            End While
            reader3.Close()
            SqlConn1.Close()
            '---------------------------------------------------------------------------------------------------------------------
            'SIPARISE INCKEY BULUR
            SqlConn2.Open()
            Dim mySelectQuery4 As String = "SELECT MAX(INCKEYNO) AS INC FROM TBLSIPATRA;"
            Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn2)
            Dim reader4 As System.Data.SqlClient.SqlDataReader
            reader4 = SqlComm4.ExecuteReader()
            While reader4.Read()
                inc = reader4("INC").ToString()
            End While
            reader4.Close()
            SqlConn2.Close()
            '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

            t1 = Mid(MaskedTextBox1.Text, 7, 4) + "-" + Mid(MaskedTextBox1.Text, 4, 2) + "-" + Mid(MaskedTextBox1.Text, 1, 2)
            t2 = Mid(MaskedTextBox2.Text, 7, 4) + "-" + Mid(MaskedTextBox2.Text, 4, 2) + "-" + Mid(MaskedTextBox2.Text, 1, 2)
            t3 = Mid(MaskedTextBox3.Text, 7, 4) + "-" + Mid(MaskedTextBox3.Text, 4, 2) + "-" + Mid(MaskedTextBox3.Text, 1, 2)
            t4 = Mid(MaskedTextBox4.Text, 7, 4) + "-" + Mid(MaskedTextBox4.Text, 4, 2) + "-" + Mid(MaskedTextBox4.Text, 1, 2)
            t5 = TextBox24.Text ' Mid(TextBox24.Text, 7, 4) + "-" + Mid(TextBox24.Text, 4, 2) + "-" + Mid(TextBox24.Text, 1, 2)
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_SIPMAS (SUBE,TALEP_NO,CARI_KODU,TARIH,TESLIM_TARIHI,IST_TES_TARIHI,DOV_BAZ_TARIH,TIPI,IHR_TIPI,EXP_REF_NO,TALEP_ONAY,TALEP_TARIHI,TALEP_DURUMU,TALEP_INDEX,SIPARISNO) VALUES ( '" & ComboBox7.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & t1 & "','" & t2 & "','" & t3 & "','" & t4 & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & ComboBox3.Text & "','" & CDate(Date.Now) & "','" & Label11.Text & "','0','" & TextBox16.Text & "')"
            cmd1.ExecuteNonQuery()
            conn1.Close()
            '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
            'NETSIS SATICI SIPARIS ANA EKRAN
            conn2.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
            conn2.Open()
            cmd2.Connection = conn2
            cmd2.CommandText = "INSERT INTO TBLSIPAMAS(SUBE_KODU,FTIRSIP,FATIRS_NO,CARI_KODU,TARIH,TIPI,BRUTTUTAR,SAT_ISKT,MFAZ_ISKT,GEN_ISK1T,GEN_ISK2T,GEN_ISK3T,GEN_ISK1O,GEN_ISK2O,GEN_ISK3O,KDV,FAT_ALTM1,FAT_ALTM2,ODEMEGUNU,ODEMETARIHI,KDV_DAHILMI,FATKALEM_ADEDI,SIPARIS_TEST,TOPLAM_MIK,TOPDEPO,SIRANO,GENELTOPLAM,PLA_KODU,DOVIZTIP,KS_KODU,BAG_TUTAR,F_YEDEK3,F_YEDEK4,F_YEDEK5,C_YEDEK6,B_YEDEK7,I_YEDEK8,L_YEDEK9,GELSUBE_KODU,ONAYTIPI,ONAYNUM,ISLETME_KODU,EBELGE,HALFAT) VALUES ( '" & ComboBox7.Text & "','7','" & TextBox16.Text & "','" & TextBox2.Text & "','" & t1 & "','2','" & Replace(TextBox26.Text, ",", ".") & "','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','0.00000000','" & TextBox21.Text & "','" & t5 & "','H','" & kalem_adet & "','" & t2 & "','0.00000','0','0','" & Replace(TextBox26.Text, ",", ".") & "','00','" & TextBox25.Text & "','100','0.00000000','0.00000000','1.00000000','0.00000000','X','0','0','0','0','A','0','1','0','0')"
            cmd2.ExecuteNonQuery()
            conn2.Close()
            '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
            'NETSIS SATIN ALMA TALEP KALEM EKRAN
            conn1.Open()
            Dim search As New SqlCommand("SELECT* FROM EO_ALANSIS_SIPATRA WHERE SIPARIS_NO='" & TextBox16.Text & "';", conn1)
            Dim o = search.ExecuteReader
            Dim i As Integer
            i = 0
            Do While o.Read
                i = 1 + 1
                inc = inc + 1
                stok_kodu = ""
                miktar = ""
                depo = ""
                fiyat = ""
                '---------------------------------------------------------------------------------------------------------------------
                stok_kodu = o("STOK_KODU").ToString()
                miktar = o("MIKTAR").ToString()
                depo = o("DEPO_KOD").ToString()
                fiyat = o("FIYAT").ToString()
                '---------------------------------------------------------------------------------------------
                conn2.Open()
                cmd3.Connection = conn2
                cmd3.CommandText = "INSERT INTO TBLSIPATRA(STOK_KODU,FISNO,STHAR_GCMIK,STHAR_GCMIK2,CEVRIM,STHAR_GCKOD,STHAR_TARIH,STHAR_NF,STHAR_BF,STHAR_IAF,STHAR_KDV,DEPO_KODU,STHAR_ACIKLAMA,STHAR_SATISK,STHAR_MALFISK,STHAR_FTIRSIP,STHAR_SATISK2,LISTE_FIAT,STHAR_HTUR,STHAR_DOVTIP,PROMASYON_KODU,STHAR_DOVFIAT,STHAR_ODEGUN,STRA_SATISK3,STRA_SATISK4,STRA_SATISK5,STRA_SATISK6,STHAR_BGTIP,STHAR_CARIKOD,PLASIYER_KODU,REDMIK,REDNEDEN,SIRA,STRA_SIPKONT,IRSALIYE_TARIH,ECZA_FAT_TIP,STHAR_TESTAR,OLCUBR,BAGLANTI_NO,SUBE_KODU,ONAYTIPI,ONAYNUM) VALUES  ('" & stok_kodu & "','" & TextBox16.Text & "','" & Replace(miktar, ",", ".") & "','0.00000000','0.00000000','G','" & t1 & "','" & Replace(fiyat, ",", ".") & "','" & Replace(fiyat, ",", ".") & "','0.00000000','8.00','" & depo & "','" & TextBox2.Text & "','0.00000000','0.00000','7','0.00000000','1','H','" & TextBox25.Text & "','0','0.000000000000000','0','0.00000000','0.00000000','0.00000000','0.00000000','I','" & TextBox2.Text & "','00','0.00000','00','" & i & "','" & i & "','" & t1 & "','0','" & t1 & "','1','0','" & ComboBox7.Text & "','A','0');"
                cmd3.ExecuteNonQuery()
                conn2.Close()
            Loop
            conn1.Close()
            '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
            conn2.Open()
            cmd3.Connection = conn2
            cmd3.CommandText = "UPDATE TBLFATUNO SET NUMARA='" & TextBox16.Text & "' WHERE SUBE_KODU= '" & ComboBox7.Text & "' AND TIP='7'"
            cmd3.ExecuteNonQuery()
            conn2.Close()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
            ComboBox7.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            MaskedTextBox1.Text = ""
            MaskedTextBox2.Text = ""
            MaskedTextBox3.Text = ""
            MaskedTextBox4.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
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
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox22.Text = ""
            TextBox23.Text = ""
            TextBox18.Text = ""
            Label11.Text = ""
            TextBox16.Text = ""
            TextBox21.Text = ""
            TextBox24.Text = ""
            TextBox7.Text = ""
            Label16.Text = ""
            Label17.Text = ""
            Label18.Text = ""
            Label22.Text = ""
            Label23.Text = ""
            Label24.Text = ""
            Label25.Text = ""
            DataGridView1.DataSource = Nothing
            DataGridView1.Refresh()
            Exit Sub
        End If
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
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
    Private Sub Form111_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Form105.TextBox3.Text = "2"
        Form105.Show()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2, cmd3, cmd4, cmd5 As New SqlCommand
        Dim da, da1 As New SqlDataAdapter()
        Dim ds, ds1 As New DataSet
        Dim kontrol, sipkontrol
        kontrol = ""
        sipkontrol = ""
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn1.Open()
        Dim mySelectQuery2 As String = "SELECT STOK_KODU FROM EO_ALANSIS_SIPATRA WHERE STOK_KODU='" & TextBox12.Text & "' AND SIPARIS_NO='" & TextBox16.Text & "';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            sipkontrol = reader2("STOK_KODU").ToString()
        End While
        reader2.Close()
        SqlConn1.Close()
        If sipkontrol = "" Then
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_SIPATRA (SIPARIS_NO,TEKLIFMASNO,TEKLIFTRANO,STOK_KODU,STOK_ADI,DEPO_KOD,MIKTAR,DOVTIP,DOVFIYAT,DOVTUTAR,FIYAT,TUTAR,ACIK1,ACIK2,ACIK3,EK1,EK2,EK3) VALUES ( '" & TextBox16.Text & "','" & TextBox1.Text & "','" & TextBox1.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox27.Text & "','" & Replace(TextBox14.Text, ",", ".") & "','" & ComboBox6.Text & "','" & Replace(TextBox19.Text, ",", ".") & "','" & Replace(TextBox20.Text, ",", ".") & "','" & Replace(TextBox17.Text, ",", ".") & "','" & Replace(TextBox15.Text, ",", ".") & "','" & TextBox23.Text & "','" & TextBox18.Text & "','" & TextBox22.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            cmd1.ExecuteNonQuery()
            conn1.Close()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd3.Connection = conn1
            cmd3.CommandText = "UPDATE EO_ALANSIS_TEKLIFTRA SET TEKLIF_INDEX='3' WHERE TEKLIFMASNO= '" & TextBox1.Text & "' AND STOK_KODU='" & TextBox12.Text & "'"
            cmd3.ExecuteNonQuery()
            conn1.Close()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd4.Connection = conn1
            cmd4.CommandType = CommandType.Text
            cmd4.CommandText = "SELECT* FROM EO_ALANSIS_TEKLIFTRA WHERE TEKLIFMASNO='" & TextBox1.Text & "'" ' AND TEKLIF_INDEX='1' "
            da.SelectCommand = cmd4
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            conn1.Close()
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
            For i = 0 To DataGridView1.Rows.Count - 2
                If DataGridView1.Rows(i).Cells(15).Value.ToString = "3         " Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                End If
            Next
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox17.Text = ""
            TextBox19.Text = ""
            TextBox20.Text = ""
            TextBox27.Text = ""
            ComboBox6.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox18.Text = ""
            TextBox22.Text = ""
            TextBox23.Text = ""
            Exit Sub
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Daha önce kayıt edilmiş, Lütfen Kontrol Ediniz...")
            Exit Sub
        End If
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        On Error Resume Next
        Dim fiyat, miktar As Decimal
        fiyat = CDec(TextBox17.Text)
        miktar = CDec(TextBox14.Text)
        TextBox15.Text = fiyat * miktar
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

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        On Error Resume Next
        Dim NextTime As Date = MaskedTextBox1.Text
        Dim yeni_date
        yeni_date = NextTime.AddDays(TextBox21.Text)
        TextBox24.Text = Mid(yeni_date, 7, 4) + "-" + Mid(yeni_date, 4, 2) + "-" + Mid(yeni_date, 1, 2)
    End Sub
    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim silid
        silid = ""
        silid = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From EO_ALANSIS_TEKLIFTRA Where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_TEKLIFTRA WHERE TEKLIFTRANO='" & TextBox1.Text & "'"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        '______________________________________________________________________________________________________________________________
        Exit Sub
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox17.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox18.Text = ""
    End Sub
    Private Sub SimpleButton8_Click_1(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Form106.TextBox3.Text = "2"
        Form106.Show()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Form117.TextBox3.Text = ComboBox7.Text
        Form117.TextBox1.Text = "1"
        Form117.Show()
    End Sub
    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        On Error Resume Next
        Dim numara, numara2
        Dim numara1 As Integer
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn2.Open()
        Dim mySelectQuery As String = "SELECT NUMARA FROM TBLFATUNO WHERE TIP='7' AND ALTTIP IS NULL AND SUBE_KODU='" & ComboBox7.Text & "';"
        Dim SqlComm As New System.Data.SqlClient.SqlCommand(mySelectQuery, SqlConn2)
        Dim reader As System.Data.SqlClient.SqlDataReader
        reader = SqlComm.ExecuteReader()
        While reader.Read()
            numara = reader("NUMARA").ToString()
        End While
        reader.Close()
        SqlConn2.Close()
        numara1 = Mid(numara, 9, 7)
        numara2 = numara1 + 1
        TextBox16.Text = "00000000" & numara2
    End Sub

    Private Sub Form111_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class