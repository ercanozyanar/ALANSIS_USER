Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Imports iTextSharp.text
Imports iTextSharp.text.html
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf.PdfPTable
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Public Class Form94
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)

    Private Sub Form94_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------------------------------------------------------------------
        ' SqlConn.Open()
        ' Dim mySelectQuery1 As String = "SELECT PARTI FROM EO_ALANSIS_SATIS GROUP BY PARTI;"
        'Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        'Dim reader1 As System.Data.SqlClient.SqlDataReader
        'reader1 = SqlComm1.ExecuteReader()
        'While reader1.Read()
        ' ComboBox3.Items.Add(reader1("PARTI"))
        ' End While
        ' reader1.Close()
        ' SqlConn.Close()
        '-----------------------------------------------------------------------------------------

    End Sub
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        'TextBox17.Text = DatePart("ww";MaskedTextBox1.)

    End Sub

    Private Sub MaskedTextBox1_BackgroundImageChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.BackgroundImageChanged

    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        On Error Resume Next
        Dim t As Date
        t = MaskedTextBox1.Text
        TextBox1.Text = DatePart("ww", t)
    End Sub
    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        On Error Resume Next
        Dim netmiktar, ciffiyat As Decimal
        netmiktar = TextBox16.Text
        ciffiyat = TextBox14.Text
        TextBox15.Text = netmiktar * ciffiyat

        Dim nettutar, market As Decimal
        Dim ratio As Double
        Dim result As String
        market = TextBox19.Text / 100
        result = Format(TextBox19.Text / 100, "Percent")
        Label45.Text = result
        nettutar = TextBox15.Text
        TextBox20.Text = nettutar - (nettutar * market)
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        On Error Resume Next
        Dim netmiktar, ciffiyat As Decimal
        netmiktar = TextBox16.Text
        ciffiyat = TextBox14.Text
        TextBox15.Text = netmiktar * ciffiyat
        Dim nettutar, market As Decimal
        Dim ratio As Double
        Dim result As String
        market = TextBox19.Text / 100
        result = Format(TextBox19.Text / 100, "Percent")
        Label45.Text = result
        nettutar = TextBox15.Text
        TextBox20.Text = nettutar - (nettutar * market)
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        On Error Resume Next
        Dim nettutar, market As Decimal
        Dim ratio As Double
        Dim result As String
        market = TextBox19.Text / 100
        result = Format(TextBox19.Text / 100, "Percent")
        Label45.Text = result
        nettutar = TextBox15.Text
        TextBox20.Text = nettutar - (nettutar * market)
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        On Error Resume Next
        Dim nettutar, market As Decimal
        Dim ratio As Double
        Dim result As String
        market = TextBox19.Text / 100
        result = Format(TextBox19.Text / 100, "Percent")
        Label45.Text = result
        nettutar = TextBox15.Text
        TextBox20.Text = nettutar - (nettutar * market)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "EUR" Then
            Dim x1, x2, x3, x4 As Decimal
            TextBox25.Text = TextBox26.Text

            TextBox18.Text = TextBox20.Text
            x1 = TextBox18.Text
            x2 = TextBox25.Text
            x3 = TextBox16.Text

            TextBox22.Text = Math.Round((x1 - x2), 2)
            TextBox31.Text = Math.Round((x1 - x2), 2)
            x4 = TextBox22.Text
            TextBox23.Text = Math.Round((x1 / x3), 2)
            TextBox24.Text = Math.Round((x4 / x3), 2)
        End If
        If ComboBox6.Text = "USD" Then
            Dim p1 As Double
            Dim x1, x2, x3, x4 As Decimal
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            p1 = 0
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT USD_EUR FROM EO_ALANSIS_SATIS_PARITE ORDER BY TARIH DESC;"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                p1 = reader1("USD_EUR").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            TextBox25.Text = Math.Round((CDbl(TextBox26.Text) / p1), 2)
            TextBox18.Text = Math.Round((CDbl(TextBox20.Text) / p1), 2)
            x1 = TextBox18.Text
            x2 = TextBox25.Text
            x3 = TextBox16.Text
            TextBox22.Text = Math.Round((x1 - x2), 2)
            TextBox31.Text = Math.Round((x1 - x2), 2)
            x4 = TextBox22.Text
            TextBox23.Text = Math.Round((x1 / x3), 2)
            TextBox24.Text = Math.Round((x4 / x3), 2)
        End If
        If ComboBox6.Text = "GBP" Then
            Dim p2 As Double
            Dim x1, x2, x3, x4 As Decimal
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            p2 = 0
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT GBP_EUR FROM EO_ALANSIS_SATIS_PARITE ORDER BY TARIH DESC;"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                p2 = reader1("GBP_EUR").ToString()
            End While
            reader1.Close()
            SqlConn.Close()
            TextBox25.Text = Math.Round((CDbl(TextBox26.Text) / p2), 2)
            TextBox18.Text = Math.Round((CDbl(TextBox20.Text) / p2), 2)
            x1 = TextBox18.Text
            x2 = TextBox25.Text
            x3 = TextBox16.Text
            TextBox22.Text = Math.Round((x1 - x2), 2)
            TextBox31.Text = Math.Round((x1 - x2), 2)
            x4 = TextBox22.Text
            TextBox23.Text = Math.Round((x1 / x3), 2)
            TextBox24.Text = Math.Round((x4 / x3), 2)
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ComboBox8.Text = "Peşin" Then
            MaskedTextBox3.Text = MaskedTextBox1.Text
        End If
        If ComboBox8.Text = "Vadeli" Then
            Dim originDate As Date = Date.Parse(MaskedTextBox1.Text)
            Dim daysToAdd As Integer = Integer.Parse(TextBox42.Text)
            Dim result As Date = originDate.AddDays(daysToAdd)
            MaskedTextBox3.Text = result
            'MaskedTextBox3.Text = MaskedTextBox1.Text + TextBox42.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox2.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox2.Text, True)
                TextBox2.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_FATURA\" + data
                My.Computer.FileSystem.CopyFile(TextBox2.Text, destinationFile)
                TextBox2.Text = destinationFile
                'End
            End If
        Else
            Shell(TextBox2.Text, 3)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox8.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox8.Text, True)
                TextBox8.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_PROFORMA\" + data
                My.Computer.FileSystem.CopyFile(TextBox8.Text, destinationFile)
                TextBox8.Text = destinationFile
                'End
            End If
        Else
            Shell(TextBox8.Text, 3)
        End If
    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged
        On Error Resume Next
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_SATIS WHERE PARTI='" & TextBox30.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextBox9.Text = (reader1("SINIF"))
            ComboBox4.Text = (reader1("NAKLIYE"))
            TextBox7.Text = (reader1("KUTU"))
            TextBox10.Text = (reader1("AMBALAJ"))
            TextBox11.Text = (reader1("EBAT"))
            TextBox12.Text = (reader1("PALET_ADET"))
            TextBox13.Text = (reader1("KUTU_ADET"))
            TextBox21.Text = (reader1("TESLIM_YERI"))
            TextBox17.Text = (reader1("TONAJ_KG"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        On Error Resume Next
        '---------------------------------------------------------------------------------------
        If TextBox30.Text <> "" Then
            SqlConn.Open()
            Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_SATIS_DETAY WHERE PARTINO='" & TextBox30.Text & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                TextBox1.Text = (reader1("HAFTA"))
                MaskedTextBox1.Text = (reader1("FATURA_TARIHI"))
                MaskedTextBox2.Text = (reader1("SEVK_TARIHI"))
                MaskedTextBox3.Text = (reader1("VADE_TARIH"))
                TextBox3.Text = (reader1("MUSTERI2"))
                TextBox4.Text = (reader1("ULKE"))
                TextBox5.Text = (reader1("BOLGE"))
                TextBox6.Text = (reader1("URUN"))
                TextBox7.Text = (reader1("KUTU"))
                TextBox9.Text = (reader1("SINIF"))
                TextBox10.Text = (reader1("AMBALAJ"))
                TextBox11.Text = (reader1("EBAT"))
                TextBox12.Text = (reader1("PALET_SAY"))
                TextBox13.Text = (reader1("KUTU_SAY"))
                TextBox14.Text = (reader1("CIF_FIYAT"))
                TextBox15.Text = (reader1("TUTAR"))
                TextBox16.Text = (reader1("NET_MIKTAR"))
                TextBox17.Text = (reader1("BRUT_TONAJ"))
                TextBox18.Text = (reader1("CIF_SATIS"))
                TextBox19.Text = (reader1("MARKET_KES_ORANI"))
                TextBox20.Text = (reader1("FATURA_TUTARI"))
                TextBox21.Text = (reader1("VARIS_YERI"))
                TextBox22.Text = (reader1("FOB_SATIS"))
                TextBox23.Text = (reader1("CIF_BIRIM"))
                TextBox24.Text = (reader1("FOB_BIRIM"))
                TextBox25.Text = (reader1("NAVLUN_EURO"))
                TextBox26.Text = (reader1("NAVLUN_KUR"))
                TextBox27.Text = (reader1("PLAKA_CONTAINER"))
                TextBox28.Text = (reader1("MUSTERI_REFERANS"))
                TextBox29.Text = (reader1("FAT_NO"))
                TextBox31.Text = (reader1("FOB_SAT_TUTARI"))
                TextBox32.Text = (reader1("CIF_SAT_TUTARI"))
                TextBox34.Text = (reader1("ACIKLAMA2"))
                TextBox39.Text = (reader1("ACIKLAMA"))
                TextBox42.Text = (reader1("VADE"))
                TextBox45.Text = (reader1("BORC"))
                TextBox46.Text = (reader1("ALACAK"))
                TextBox2.Text = (reader1("FATURA"))
                TextBox8.Text = (reader1("PROFORMA"))
                ComboBox1.Text = (reader1("HESAP"))
                ComboBox2.Text = (reader1("BIRIM"))
                ComboBox4.Text = (reader1("NAKLIYE"))
                ComboBox6.Text = (reader1("DOV_KOD"))
                ComboBox7.Text = (reader1("TIPI"))
                ComboBox8.Text = (reader1("ODEME_SARTI"))
                ComboBox9.Text = (reader1("ODEME_SEKLI"))
                ComboBox10.Text = (reader1("MUHASEBE_KAYIT"))
            End While
            reader1.Close()
            SqlConn.Close()
            '-----------------------------------------------------------------------------------------
        Else
            MsgBox("Lütfen Parti No Giriniz...")
            Exit Sub
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form98.TextBox30.Text = TextBox30.Text
        Form98.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim paletsay, kutusay, bruttonaj, netmiktar, ciffiyat, tutar, market, fattutar, navlunkur, navluneuro, cifsatis, fobsatis, cifbirim, fobbirim, alacak, borc, cifsatistutar, fobsatistutar As Decimal
        Dim vadegun As Integer
        Dim kontrol As String
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        paletsay = Replace(TextBox12.Text, ",", ".")
        kutusay = Replace(TextBox13.Text, ",", ".")
        bruttonaj = Replace(TextBox17.Text, ",", ".")
        netmiktar = Replace(TextBox16.Text, ",", ".")
        ciffiyat = Replace(TextBox14.Text, ",", ".")
        tutar = Replace(TextBox15.Text, ",", ".")
        market = Replace(TextBox19.Text, ",", ".")
        fattutar = Replace(TextBox20.Text, ",", ".")
        navlunkur = Replace(TextBox26.Text, ",", ".")
        navluneuro = Replace(TextBox25.Text, ",", ".")
        cifsatis = Replace(TextBox18.Text, ",", ".")
        fobsatis = Replace(TextBox22.Text, ",", ".")
        cifbirim = Replace(TextBox23.Text, ",", ".")
        fobbirim = Replace(TextBox24.Text, ",", ".")
        vadegun = Replace(TextBox42.Text, ",", ".")
        alacak = Replace(TextBox46.Text, ",", ".")
        borc = Replace(TextBox45.Text, ",", ".")
        cifsatistutar = Replace(TextBox32.Text, ",", ".")
        fobsatistutar = Replace(TextBox31.Text, ",", ".")
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        kontrol = ""
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT PARTINO FROM EO_ALANSIS_SATIS_DETAY WHERE PARTINO='" & TextBox30.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            kontrol = reader1("PARTINO").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        If kontrol = "" Then
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO  EO_ALANSIS_SATIS_DETAY (HAFTA,FATURA_TARIHI,SEVK_TARIHI,HESAP,MUSTERI2,URUN,PARTINO,ULKE,BOLGE,SINIF,KUTU,AMBALAJ,EBAT,PALET_SAY,KUTU_SAY,BRUT_TONAJ,NET_MIKTAR,CIF_FIYAT,BIRIM,TUTAR,MARKET_KES_ORANI,FATURA_TUTARI,NAKLIYE,VARIS_YERI,NAVLUN_KUR,NAVLUN_EURO,CIF_SATIS,FOB_SATIS,CIF_BIRIM,FOB_BIRIM,PLAKA_CONTAINER,MUSTERI_REFERANS,FAT_NO,ODEME_SARTI,VADE,VADE_TARIH,ODEME_SEKLI,ACIKLAMA,DOV_KOD,ALACAK,BORC,TIPI,ACIKLAMA2,MUHASEBE_KAYIT,CIF_SAT_TUTARI,FOB_SAT_TUTARI,FATURA,PROFORMA) VALUES ( '" & TextBox1.Text & "','" & MaskedTextBox1.Text & "','" & MaskedTextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox30.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox9.Text & "','" & TextBox7.Text & "','" & TextBox10.Text & "', '" & TextBox11.Text & "','" & kutusay & "','" & paletsay & "','" & bruttonaj & "','" & netmiktar & "','" & ciffiyat & "','" & ComboBox2.Text & "','" & tutar & "','" & market & "','" & fattutar & "','" & ComboBox4.Text & "','" & TextBox21.Text & "','" & navlunkur & "','" & navluneuro & "','" & cifsatis & "','" & fobsatis & "','" & cifbirim & "','" & fobbirim & "','" & TextBox27.Text & "','" & TextBox28.Text & "','" & TextBox29.Text & "','" & ComboBox8.Text & "','" & vadegun & "','" & MaskedTextBox3.Text & "','" & ComboBox9.Text & "','" & TextBox39.Text & "','" & ComboBox6.Text & "','" & alacak & "','" & borc & "','" & ComboBox7.Text & "','" & TextBox34.Text & "','" & ComboBox10.Text & "','" & cifsatistutar & "','" & fobsatistutar & "','" & TextBox2.Text & "','" & TextBox8.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            MsgBox("Kayit İşlemi Tamamlanmiştir...")
            TextBox1.Text = ""
            MaskedTextBox1.Text = ""
            MaskedTextBox2.Text = ""
            MaskedTextBox3.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = "0"
            TextBox15.Text = "0"
            TextBox16.Text = "0"
            TextBox17.Text = "0"
            TextBox18.Text = "0"
            TextBox19.Text = "0"
            TextBox20.Text = "0"
            TextBox21.Text = ""
            TextBox22.Text = "0"
            TextBox23.Text = "0"
            TextBox24.Text = "0"
            TextBox25.Text = "0"
            TextBox26.Text = "0"
            TextBox27.Text = ""
            TextBox28.Text = ""
            TextBox29.Text = ""
            TextBox31.Text = "0"
            TextBox32.Text = "0"
            TextBox34.Text = ""
            TextBox39.Text = ""
            TextBox42.Text = "0"
            TextBox45.Text = "0"
            TextBox46.Text = "0"
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox30.Text = ""
            ComboBox4.Text = ""
            ComboBox6.Text = ""
            ComboBox7.Text = ""
            ComboBox8.Text = ""
            ComboBox9.Text = ""
            ComboBox10.Text = ""
            '---------------------------------------------------------------------------------------------------
        Else
            MsgBox("Daha önce kayıt edilmiştir...")
            TextBox1.Text = ""
            MaskedTextBox1.Text = ""
            MaskedTextBox2.Text = ""
            MaskedTextBox3.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = "0"
            TextBox15.Text = "0"
            TextBox16.Text = "0"
            TextBox17.Text = "0"
            TextBox18.Text = "0"
            TextBox19.Text = "0"
            TextBox20.Text = "0"
            TextBox21.Text = ""
            TextBox22.Text = "0"
            TextBox23.Text = "0"
            TextBox24.Text = "0"
            TextBox25.Text = "0"
            TextBox26.Text = "0"
            TextBox27.Text = ""
            TextBox28.Text = ""
            TextBox29.Text = ""
            TextBox31.Text = "0"
            TextBox32.Text = "0"
            TextBox34.Text = ""
            TextBox39.Text = ""
            TextBox42.Text = "0"
            TextBox45.Text = "0"
            TextBox46.Text = "0"
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox30.Text = ""
            ComboBox4.Text = ""
            ComboBox6.Text = ""
            ComboBox7.Text = ""
            ComboBox8.Text = ""
            ComboBox9.Text = ""
            ComboBox10.Text = ""
        End If
    End Sub
End Class