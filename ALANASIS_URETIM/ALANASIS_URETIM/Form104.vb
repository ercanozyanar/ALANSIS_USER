Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Mail
Imports System.ComponentModel

Public Class Form104
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    Private Sub Form104_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaskedTextBox1.Text = Date.Now
        MaskedTextBox2.Text = Date.Now
        MaskedTextBox3.Text = Date.Now
        MaskedTextBox4.Text = Date.Now
        ComboBox2.Enabled = False
        TextBox3.Enabled = False
    End Sub
    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs)
        On Error Resume Next
        '-------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT CARI_KOD,dbo.trkis(CARI_ISIM)AS CARI_ISIM,dbo.trkis(CARI_IL) AS CARI_IL,dbo.trkis(CARI_ILCE) AS CARI_ILCE,DBO.TRKIS(CARI_ADRES) AS CARI_ADRES FROM TBLCASABIT WHERE CARI_KOD='" & TextBox2.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextBox11.Text = reader1("CARI_ISIM").ToString()
            TextBox9.Text = reader1("CARI_ADRES").ToString()
            TextBox8.Text = reader1("CARI_IL").ToString()
            TextBox10.Text = reader1("CARI_ILCE").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        TextBox12.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TextBox13.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        TextBox27.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        TextBox14.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        TextBox17.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        TextBox15.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        TextBox23.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        TextBox18.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        TextBox22.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
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
        cmd2.Connection = conn1
        cmd1.CommandText = "Delete From EO_ALANSIS_TEKLIFTRA Where TEKLIFMASNO='" & TextBox1.Text & "'"
        cmd2.CommandText = "Delete From EO_ALANSIS_TEKLIFMAS Where TALEP_NO='" & TextBox1.Text & "'"
        cmd1.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Talep Silinmiştir...")
        ComboBox7.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox3.Text = ""
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
    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
    '    Form107.Show()
    ' End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Form105.TextBox3.Text = "1"
        Form105.Show()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        On Error Resume Next
        If TextBox4.Text = "" Then
            Dim destinationFile, data As String
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox4.Text, True)
                TextBox4.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox4.Text, destinationFile)
                TextBox4.Text = destinationFile
            End If
        Else
            Process.Start(TextBox4.Text)
        End If
    End Sub
    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        On Error Resume Next
        If TextBox5.Text = "" Then
            Dim destinationFile, data As String
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox5.Text, True)
                TextBox5.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox5.Text, destinationFile)
                TextBox5.Text = destinationFile
            End If
        Else
            Process.Start(TextBox5.Text)
            Exit Sub
        End If
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        On Error Resume Next
        If TextBox6.Text = "" Then
            Dim destinationFile, data As String
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox6.Text, True)
                TextBox6.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox6.Text, destinationFile)
                TextBox6.Text = destinationFile
            End If
        Else
            Process.Start(TextBox6.Text)
            Exit Sub
        End If
    End Sub
    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Form106.TextBox3.Text = "1"
        Form106.Show()
    End Sub
    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        If ComboBox3.Text = "" Or ComboBox1.Text = "" Or ComboBox7.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or MaskedTextBox1.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Boş geçilemez sahalar mevcut.Lütfen kontrol ediniz...")
            XtraTabPage1.Select()
            Exit Sub
        Else
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_TEKLIFTRA (TEKLIFMASNO,TEKLIFTRANO,STOK_KODU,STOK_ADI,DEPO_KOD,MIKTAR,FIYAT,TUTAR,ACIK1,ACIK2,ACIK3,EK1,EK2,EK3,TEKLIF_INDEX) VALUES ( '" & TextBox1.Text & "','" & TextBox1.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox27.Text & "','" & Replace(TextBox14.Text, ",", ".") & "','" & Replace(TextBox17.Text, ",", ".") & "','" & Replace(TextBox15.Text, ",", ".") & "','" & TextBox23.Text & "','" & TextBox18.Text & "','" & TextBox22.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','0')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
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
            TextBox16.Text = "1"
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox17.Text = ""
            TextBox27.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox18.Text = ""
            TextBox22.Text = ""
            TextBox23.Text = ""
            Exit Sub
hata:
            DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
            Exit Sub
        End If
    End Sub
    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
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
    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim gunid
        gunid = ""
        gunid = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Update EO_ALANSIS_TEKLIFTRA SET STOK_KODU='" & TextBox12.Text & "',STOK_ADI='" & TextBox12.Text & "',DEPO_KOD='" & TextBox27.Text & "',MIKTAR='" & Replace(TextBox14.Text, ",", ".") & "',FIYAT='" & Replace(TextBox17.Text, ",", ".") & "',TUTAR='" & Replace(TextBox15.Text, ",", ".") & "',ACIK1='" & TextBox23.Text & "',ACIK2='" & TextBox18.Text & "',ACIK3='" & TextBox22.Text & "' Where ID='" & gunid & "'"
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
    End Sub
    Private Sub XtraTabControl2_Selecting(sender As Object, e As DevExpress.XtraTab.TabPageCancelEventArgs) Handles XtraTabControl1.Selecting
        Label17.Text = TextBox1.Text
        Label22.Text = MaskedTextBox1.Text
        Label18.Text = TextBox11.Text
        Label24.Text = TextBox2.Text

    End Sub
    Private Sub ComboBox7_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        On Error Resume Next
        Dim yenitalep
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
            SqlConn1.Open()
            Dim mySelectQuery1 As String = "SELECT MAX(TALEP_NO)+1 AS YENI_TALEP_NO FROM EO_ALANSIS_TEKLIFMAS;"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                TextBox1.Text = reader1("YENI_TALEP_NO").ToString()
            End While
            reader1.Close()
            SqlConn1.Close()
            '---------------------------------------------------------------------------------------------
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Yurt Dışı" Then
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
        Else
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub TextBox14_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        On Error Resume Next
        Dim miktar, fiyat As Decimal
        miktar = CDec(TextBox14.Text)
        fiyat = CDec(TextBox17.Text)
        TextBox15.Text = miktar * fiyat
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        On Error Resume Next
        Dim miktar, fiyat As Decimal
        miktar = CDec(TextBox14.Text)
        fiyat = CDec(TextBox17.Text)
        TextBox15.Text = miktar * fiyat
    End Sub
    Private Sub ComboBox5_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.Text = "OK" Then
            Label11.Text = "ONAYLANDI"
            Label11.BackColor = Color.Green
            TextBox7.Text = "1"
        End If
        If ComboBox5.Text = "NOK" Then
            Label11.Text = "ONAYLANMADI"
            Label11.BackColor = Color.Red
            TextBox7.Text = "2"

        End If
    End Sub
    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        On Error GoTo hata
        Dim conn1, conn2 As New SqlConnection
        Dim cmd1, cmd2, cmd3, cmd4, cmd5 As New SqlCommand
        Dim t1, t2, t3, t4 As String
        Dim kontrol, kalem_adet, stok_kodu, miktar, depo
        Dim ds As DataSet
        kontrol = ""
        kalem_adet = ""

        '----------------------------------------------------------------------------------------------------------------------------------------
        Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
        If TextBox7.Text = "0" Then
            '---------------------------------------------------------------------------------------------------------------------
            'TALEP NO KONTROL EDER
            SqlConn1.Open()
            Dim mySelectQuery1 As String = "SELECT TALEP_NO FROM EO_ALANSIS_TEKLIFMAS WHERE TALEP_NO='" & TextBox1.Text & "';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                kontrol = reader1("TALEP_NO").ToString()
            End While
            reader1.Close()
            SqlConn1.Close()
            '---------------------------------------------------------------------------------------------
            If kontrol = "" Then
                '----------------------------------------------------------------------------------------------------------------------------------------
                t1 = Mid(MaskedTextBox1.Text, 7, 4) + "-" + Mid(MaskedTextBox1.Text, 4, 2) + "-" + Mid(MaskedTextBox1.Text, 1, 2)
                t2 = Mid(MaskedTextBox2.Text, 7, 4) + "-" + Mid(MaskedTextBox2.Text, 4, 2) + "-" + Mid(MaskedTextBox2.Text, 1, 2)
                t3 = Mid(MaskedTextBox3.Text, 7, 4) + "-" + Mid(MaskedTextBox3.Text, 4, 2) + "-" + Mid(MaskedTextBox3.Text, 1, 2)
                t4 = Mid(MaskedTextBox4.Text, 7, 4) + "-" + Mid(MaskedTextBox4.Text, 4, 2) + "-" + Mid(MaskedTextBox4.Text, 1, 2)
                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "INSERT INTO EO_ALANSIS_TEKLIFMAS (SUBE,TALEP_NO,CARI_KODU,TARIH,TESLIM_TARIHI,IST_TES_TARIHI,DOV_BAZ_TARIH,TIPI,IHR_TIPI,EXP_REF_NO,TALEP_ONAY,TALEP_TARIHI,TALEP_DURUMU,TALEP_INDEX) VALUES ( '" & ComboBox7.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & t1 & "','" & t2 & "','" & t3 & "','" & t4 & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & ComboBox3.Text & "','" & CDate(Date.Now) & "','" & Label11.Text & "','0')"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
                TextBox16.Text = "2"
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
                ComboBox5.Text = ""
                Label20.Text = ""
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
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Talep daha önce kullanılmıştır...")
            End If
        End If
        If TextBox7.Text = "1" Then
            If ComboBox5.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Talep Onay veriniz...")
                Exit Sub
            Else

                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "UPDATE EO_ALANSIS_TEKLIFMAS SET TALEP_INDEX='1',TALEP_DURUMU='ONAYLANDI' WHERE TALEP_NO= '" & TextBox1.Text & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                conn1.Open()
                cmd4.Connection = conn1
                cmd4.CommandText = "UPDATE EO_ALANSIS_TEKLIFTRA SET TEKLIF_INDEX='1' WHERE TEKLIFMASNO= '" & TextBox1.Text & "'"
                cmd4.ExecuteNonQuery()
                conn1.Close()
                DevExpress.XtraEditors.XtraMessageBox.Show("Talep Onaylanmıştır...")
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
                ComboBox5.Text = ""
                Label20.Text = ""
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
                '--------------------------------------------------------------------------------------
                'Dim SMTP As New SmtpClient("smtp.gmail.com")
                'SMTP.Timeout = 5
                'SMTP.EnableSsl = True
                'SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alansis.123456")
                'SMTP.Port = "587"
                'Dim Mail As New MailMessage
                'Mail.Subject = "Talep No :" + TextBox7.Text + "Onaylandı"
                'Mail.To.Add("ercanozyanar@gmail.com")
                'Mail.From = New MailAddress("alansis.bilgi@gmail.com")
                'Mail.Body = "Talep No :" + TextBox7.Text + "Onaylandı.Sipariş Onayı bekleniyor"
                'SMTP.Send(Mail)
                '--------------------------------------------------------------------------------------
                Exit Sub
            End If
        End If
        If TextBox7.Text = "2" Then
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_TEKLIFMAS SET TALEP_INDEX='2',TALEP_DURUMU='ONAYLANMADI' WHERE TALEP_NO= '" & TextBox1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
            conn1.Open()
            cmd5.Connection = conn1
            cmd5.CommandText = "UPDATE EO_ALANSIS_TEKLIFTRA SET TEKLIF_INDEX='2' WHERE TEKLIFMASNO= '" & TextBox1.Text & "'"
            cmd5.ExecuteNonQuery()
            conn1.Close()
            DevExpress.XtraEditors.XtraMessageBox.Show("Talep Onaylanmamıştır...")
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
            ComboBox5.Text = ""
            Label20.Text = ""
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
            '--------------------------------------------------------------------------------------
            ' Dim SMTP As New SmtpClient("smtp.gmail.com")
            ' SMTP.Timeout = 5
            ' SMTP.EnableSsl = True
            ' SMTP.Credentials = New System.Net.NetworkCredential("ercanozyanar@gmail.com", "term.2202")
            ' SMTP.Port = "587"
            ' Dim Mail As New MailMessage
            ' Mail.Subject = "Talep No :" + TextBox7.Text + "Onaylanmadı"
            ' Mail.To.Add("ercanozyanar@gmail.com")
            ' Mail.From = New MailAddress("ercanozyanar@gmail.com")
            ' Mail.Body = "Talep No :" + TextBox7.Text + "Onaylanmadı."
            ' SMTP.Send(Mail)
            '--------------------------------------------------------------------------------------
            Exit Sub
        End If
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox7.Text = "0"
    End Sub
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox12.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TextBox13.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        TextBox27.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        TextBox14.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        TextBox17.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        TextBox15.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        TextBox23.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        TextBox18.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        TextBox22.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        TextBox5.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        TextBox6.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
    End Sub
    Private Sub Form104_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If TextBox16.Text = "1" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Kaydetmeden çıkamazsınız...")
            e.Cancel = True
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Form117.TextBox3.Text = ComboBox7.Text
        Form117.TextBox1.Text = "2"
        Form117.Show()
    End Sub

    Private Sub FluentDesignFormContainer1_Click(sender As Object, e As EventArgs) Handles FluentDesignFormContainer1.Click

    End Sub
End Class