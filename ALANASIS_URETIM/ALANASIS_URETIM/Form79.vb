Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form79
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form79_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        On Error Resume Next
        Dim plt, kutu, sonuc As Decimal
        plt = CDec(TextBox10.Text)
        kutu = CDec(TextBox13.Text)
        sonuc = plt * kutu
        TextBox12.Text = sonuc

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        On Error Resume Next
        Dim plt, kutu, sonuc As Decimal
        plt = CDec(TextBox10.Text)
        kutu = CDec(TextBox13.Text)
        sonuc = plt * kutu
        TextBox12.Text = sonuc
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        On Error Resume Next
        Dim plt1, kutu1, sonuc1 As Decimal
        plt1 = CDec(TextBox11.Text)
        kutu1 = CDec(TextBox12.Text)
        sonuc1 = plt1 * kutu1
        TextBox7.Text = sonuc1
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        '====================================
        Dim plt1, kutu1, sonuc1 As Decimal
        plt1 = CDec(TextBox11.Text)
        kutu1 = CDec(TextBox12.Text)
        sonuc1 = plt1 * kutu1
        TextBox7.Text = sonuc1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form93.TextBox3.Text = "2"
        Form93.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form93.TextBox3.Text = "1"
        Form93.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form93.TextBox3.Text = "3"
        Form93.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form93.TextBox3.Text = "4"
        Form93.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form96.Show()
    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_SATIS WHERE PARTI='" & TextBox14.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Text = (reader1("DURUM"))
            ComboBox2.Text = (reader1("SIPARIS_TURU"))
            ComboBox3.Text = (reader1("SINIF"))
            ComboBox4.Text = (reader1("NAKLIYE"))
            ComboBox5.Text = (reader1("TESLIM_SEKLI"))
            TextBox1.Text = (reader1("PARTI"))
            TextBox2.Text = (reader1("MUSTERI"))
            TextBox3.Text = (reader1("KUTU"))
            TextBox4.Text = (reader1("AMBALAJ"))
            TextBox5.Text = (reader1("ACIKLAMA"))
            TextBox6.Text = (reader1("PALET_TIPI"))
            TextBox7.Text = (reader1("TONAJ_KG"))
            TextBox8.Text = (reader1("EBAT"))
            TextBox9.Text = (reader1("MIN_MEYVE_AGIRLIK"))
            TextBox10.Text = (reader1("PALET_ADET"))
            TextBox11.Text = (reader1("MIN_KUTU_AGIRLIK"))
            TextBox12.Text = (reader1("KUTU_ADET"))
            TextBox13.Text = (reader1("PLT_KUTU"))
            TextBox18.Text = (reader1("MUSTERI_REFERANS"))
            TextBox21.Text = (reader1("TESLIM_YERI"))
            TextBox22.Text = (reader1("ETIKET"))
            MaskedTextBox1.Text = (reader1("ETA"))
            MaskedTextBox2.Text = (reader1("ETD"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim kontrol As String
        Dim x1, x2, x3, x4, x5 As Decimal
        x1 = 0
        x2 = 0
        x3 = 0
        x4 = 0
        x5 = 0
        x1 = TextBox10.Text
        x2 = TextBox11.Text
        x3 = TextBox12.Text
        x4 = TextBox7.Text
        x5 = TextBox13.Text
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        kontrol = ""
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT PARTI FROM EO_ALANSIS_SATIS WHERE PARTI='" & TextBox1.Text & "';"
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
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_SATIS (DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI) VALUES ( '" & ComboBox4.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & MaskedTextBox1.Text & "','" & MaskedTextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "', '" & x1 & "','" & x2 & "','" & x3 & "','" & x4 & "','" & x5 & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox22.Text & "','" & TextBox18.Text & "','" & ComboBox5.Text & "','" & TextBox21.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            MsgBox("Kayit İşlemi Tamamlanmiştir...")
            '---------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd2.Connection = conn1
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "SELECT DURUM,SIPARIS_TURU,SINIF,NAKLIYE,PARTI,MUSTERI,ETD,ETA,KUTU,AMBALAJ,EBAT,MIN_MEYVE_AGIRLIK,MIN_KUTU_AGIRLIK,PALET_ADET,KUTU_ADET,TONAJ_KG,PLT_KUTU,PALET_TIPI,ACIKLAMA,ETIKET,MUSTERI_REFERANS,TESLIM_SEKLI,TESLIM_YERI FROM EO_ALANSIS_SATIS"
            da.SelectCommand = cmd2
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            conn1.Close()
        Else
            MsgBox("PARTI NO Daha önce sisteme kayıt edilmiştir.Lütfen Kontrol ediniz...")
            Exit Sub
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
        MsgBox("Kayit Silinmiştir...")
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

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim x1, x2, x3, x4, x5 As Decimal
        x1 = 0
        x2 = 0
        x3 = 0
        x4 = 0
        x5 = 0
        x1 = TextBox10.Text
        x2 = TextBox11.Text
        x3 = TextBox12.Text
        x4 = TextBox7.Text
        x5 = TextBox13.Text
        If TextBox14.Text <> "" Then
            '---------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_SATIS SET DURUM='" & ComboBox4.Text & "',SIPARIS_TURU='" & ComboBox1.Text & "',SINIF='" & ComboBox2.Text & "',NAKLIYE='" & ComboBox3.Text & "',PARTI='" & TextBox1.Text & "',MUSTERI='" & TextBox2.Text & "',ETD='" & MaskedTextBox1.Text & "',ETA='" & MaskedTextBox2.Text & "',KUTU='" & TextBox3.Text & "',AMBALAJ='" & TextBox4.Text & "',EBAT='" & TextBox8.Text & "',MIN_MEYVE_AGIRLIK='" & TextBox9.Text & "',MIN_KUTU_AGIRLIK='" & x1 & "',PALET_ADET='" & x2 & "',KUTU_ADET='" & x3 & "',TONAJ_KG='" & x4 & "',PLT_KUTU='" & x5 & "',PALET_TIPI='" & TextBox6.Text & "',ACIKLAMA='" & TextBox5.Text & "',ETIKET='" & TextBox22.Text & "',MUSTERI_REFERANS='" & TextBox18.Text & "',TESLIM_SEKLI='" & ComboBox5.Text & "',TESLIM_YERI='" & TextBox21.Text & "' WHERE PARTI='" & TextBox14.Text & "'"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            MsgBox("Güncelleme İşlemi Tamamlanmiştir...")
            '---------------------------------------------------------------------------------------------------
        Else
            MsgBox("Parti No boş olamaz, Lütfen kontrol ediniz...")
            Exit Sub
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Form94.TextBox30.Text = TextBox1.Text
        Form94.Show()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Form118.TextEdit21.Text = TextBox1.Text
        Form118.TextEdit22.Text = TextBox15.Text
        Form118.TextEdit23.Text = ComboBox1.Text
        Form118.TextBox1.Text = ComboBox6.Text
        Form118.Show()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class