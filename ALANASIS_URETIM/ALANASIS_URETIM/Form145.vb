Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form145
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form145_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT * FROM EO_ALANSIS_KIRAZBOLGE;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBoxEdit3.Properties.Items.Add(reader1("BOLGE"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT * FROM EO_ALANSIS_KIRAZCESIT;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            ComboBoxEdit4.Properties.Items.Add(reader2("CESIT"))
        End While
        reader2.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT PARTI FROM EO_ALANSIS_SATIS WHERE (SATIS_ONAY='OK' AND URETIM_ONAY='OK')"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            ComboBoxEdit5.Properties.Items.Add(reader3("PARTI"))
        End While
        reader3.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery4 As String = "SELECT AMBALAJ_TIPI FROM EO_ALANSIS_KIRAZAMBALAJ"
        Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        Dim reader4 As System.Data.SqlClient.SqlDataReader
        reader4 = SqlComm4.ExecuteReader()
        While reader4.Read()
            ComboBoxEdit6.Properties.Items.Add(reader4("AMBALAJ_TIPI"))
        End While
        reader4.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery5 As String = "SELECT ISLEM FROM EO_ALANSIS_KIRAZISLEM"
        Dim SqlComm5 As New System.Data.SqlClient.SqlCommand(mySelectQuery5, SqlConn)
        Dim reader5 As System.Data.SqlClient.SqlDataReader
        reader5 = SqlComm5.ExecuteReader()
        While reader5.Read()
            ComboBoxEdit11.Properties.Items.Add(reader5("ISLEM"))
        End While
        reader5.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim kontrol, grupkontrol As String
        Dim x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, toplamkusur As Decimal
        toplamkusur = 0
        x1 = 0
        x2 = 0
        x3 = 0
        x4 = 0
        x5 = 0
        x6 = 0
        x7 = 0
        x8 = 0
        x9 = 0
        x10 = 0
        x11 = 0
        x12 = 0
        x13 = 0
        x14 = 0
        x15 = 0
        x16 = 0
        x17 = 0
        x18 = 0
        x19 = 0
        x1 = TextEdit10.Text     'tonaj
        x2 = TextEdit11.Text     'alınan numuna
        x3 = TextEdit12.Text     'yabancı
        x4 = TextEdit13.Text     'kuf
        x5 = TextEdit14.Text    'dal
        x6 = TextEdit15.Text    'çürüme
        x7 = TextEdit16.Text    'aşırı
        x8 = TextEdit17.Text    'aşırı
        x9 = TextEdit18.Text    'içkurd
        x10 = TextEdit19.Text    'ikiz
        x11 = TextEdit20.Text   'ebat altı
        x12 = TextEdit21.Text   'çatlak
        x13 = TextEdit22.Text   'dolu

        x15 = TextEdit24.Text   '22
        x16 = TextEdit25.Text   '24
        x17 = TextEdit26.Text   '26
        x18 = TextEdit27.Text   '28
        x19 = TextEdit28.Text   'sapsız

        toplamkusur = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13
        x14 = toplamkusur   'toplam
        TextEdit23.Text = toplamkusur
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_KIRAZPAKET_KONTROL (HASAT_TARIH, PAKETLEME_TARIH, TESIS, URUN_ADI, VARDIYA, VARDIYA_BASLANGIC, UBT_KODU, URUN_CINSI, ISLEM, MUSTERI_ADI,IZLEMENO, AMBALAJTIPI, KALIBRE, YABANCI_MADDE, KUFLENME, DAL_SURTMESI, CURUME, YUMUSAK, ICKURD, IKIZMEYVE, EBAT_ALTI, HASAR, DOLU_ZARAR, SEKIL_BOZUK, PORSUME, TOPLAM_KUSUR, BRIX, BRUT_AGIRLIK, KUTU_AGIRLIK, POSET_AGIRLIK, SALE_AGIRLIK, NET_AGIRLIK, TAT, YAPI, KOKU, KALITE_PERSONEL) VALUES ( '" & TextEdit1.Text & "','" & Date.Today & "','" & TextEdit2.Text & "','" & TextEdit3.Text & "','" & ComboBoxEdit1.Text & "','" & ComboBoxEdit2.Text & "','" & ComboBoxEdit3.Text & "','" & ComboBoxEdit4.Text & "','" & ComboBoxEdit11.Text & "','" & ComboBoxEdit5.Text & "','" & TextEdit8.Text & "','" & ComboBoxEdit6.Text & "','" & ComboBoxEdit7.Text & "','" & Replace(x1, ",", ".") & "','" & Replace(x2, ",", ".") & "','" & Replace(x3, ",", ".") & "','" & Replace(x4, ",", ".") & "','" & Replace(x5, ",", ".") & "', '" & Replace(x6, ",", ".") & "','" & Replace(x7, ",", ".") & "','" & Replace(x8, ",", ".") & "','" & Replace(x9, ",", ".") & "','" & Replace(x10, ",", ".") & "','" & Replace(x11, ",", ".") & "','" & Replace(x13, ",", ".") & "','" & Replace(x14, ",", ".") & "','" & Replace(x12, ",", ".") & "','" & Replace(x18, ",", ".") & "','" & Replace(x15, ",", ".") & "','" & Replace(x16, ",", ".") & "','" & Replace(x17, ",", ".") & "','" & Replace(x19, ",", ".") & "','" & ComboBoxEdit8.Text & "','" & ComboBoxEdit9.Text & "','" & ComboBoxEdit10.Text & "','" & TextEdit32.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        ComboBoxEdit1.Text = ""
        ComboBoxEdit2.Text = ""
        ComboBoxEdit3.Text = ""
        TextEdit3.Text = ""

        TextEdit8.Text = ""      'yabancı

        TextEdit10.Text = 0    'dal
        TextEdit11.Text = 0     'çürüme
        TextEdit12.Text = 0    'aşırı
        TextEdit13.Text = 0    'içkurd
        TextEdit14.Text = 0    'ikiz
        TextEdit15.Text = 0    'ebat altı
        TextEdit16.Text = 0   'çatlak
        TextEdit17.Text = 0   'dol
        TextEdit18.Text = 0   'toplam
        TextEdit19.Text = 0   'brix
        TextEdit20.Text = 0   '22u
        TextEdit21.Text = 0    '24
        TextEdit22.Text = 0   '26
        TextEdit23.Text = 0   '28
        TextEdit24.Text = 0    'sapsız
        TextEdit25.Text = 0
        TextEdit26.Text = 0
        TextEdit27.Text = 0
        TextEdit28.Text = 0

        TextEdit32.Text = ""

        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde hata, Lütfen kontrol ediniz......")
        Exit Sub
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Form147.TextBox1.Text = "2"
        ' Form147.MdiParent = Me
        Form147.Show()
    End Sub

    Private Sub ComboBoxEdit9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit9.SelectedIndexChanged

    End Sub

    Private Sub TextEdit10_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit10.EditValueChanged
        Dim u = Len(TextEdit10.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit10.Text = TextEdit10.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit11_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit11.EditValueChanged
        Dim u = Len(TextEdit11.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit11.Text = TextEdit11.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit12_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit12.EditValueChanged
        Dim u = Len(TextEdit12.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit12.Text = TextEdit12.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit13_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit13.EditValueChanged
        Dim u = Len(TextEdit13.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit13.Text = TextEdit13.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit14_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit14.EditValueChanged
        Dim u = Len(TextEdit14.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit14.Text = TextEdit14.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit15_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit15.EditValueChanged
        Dim u = Len(TextEdit15.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit15.Text = TextEdit15.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit16_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit16.EditValueChanged
        Dim u = Len(TextEdit16.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit16.Text = TextEdit16.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit17_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit17.EditValueChanged
        Dim u = Len(TextEdit17.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit17.Text = TextEdit17.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit18_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit18.EditValueChanged
        Dim u = Len(TextEdit18.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit18.Text = TextEdit18.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit19_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit19.EditValueChanged
        Dim u = Len(TextEdit19.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit19.Text = TextEdit19.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub TextEdit20_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit20.EditValueChanged
        Dim u = Len(TextEdit20.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit20.Text = TextEdit20.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit21_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit21.EditValueChanged
        Dim u = Len(TextEdit21.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit21.Text = TextEdit21.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit22_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit22.EditValueChanged
        Dim u = Len(TextEdit22.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit22.Text = TextEdit22.Text.Substring(0, 5)
        End If
    End Sub
    Private Sub TextEdit24_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit24.EditValueChanged
        On Error Resume Next

        Dim BRUT, DARA, NET As Decimal
        DARA = 0
        BRUT = 0
        NET = 0
        DARA = CDec(TextEdit24.Text)
        BRUT = CDec(TextEdit27.Text)
        NET = BRUT - DARA
        TextEdit28.Text = NET

    End Sub
    Private Sub TextEdit27_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit27.EditValueChanged
        On Error Resume Next
        Dim BRUT, DARA, NET As Decimal
        DARA = 0
        BRUT = 0
        NET = 0
        DARA = CDec(TextEdit24.Text)
        BRUT = CDec(TextEdit27.Text)
        NET = BRUT - DARA
        TextEdit28.Text = NET
    End Sub

    Private Sub TextEdit25_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit25.EditValueChanged
        Dim u = Len(TextEdit25.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit25.Text = TextEdit25.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit26_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit26.EditValueChanged
        Dim u = Len(TextEdit26.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit26.Text = TextEdit26.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit28_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit28.EditValueChanged
        Dim u = Len(TextEdit28.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit28.Text = TextEdit28.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Form230.Show()
    End Sub
End Class