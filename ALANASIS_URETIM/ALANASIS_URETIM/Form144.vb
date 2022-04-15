Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form144
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2, cmd3 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim kontrol, grupkontrol, girdikontx, TARIHX, MADSERX, URETICIX As String
        Dim listkontrol As Integer
        Dim x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, toplamkusur, NETX As Decimal
        toplamkusur = 0
        listkontrol = 0
        girdikontx = ""
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
        URETICIX = ""
        TARIHX = ""
        MADSERX = ""
        NETX = 0
        x1 = "0"     'tonaj
        x2 = TextEdit7.Text     'alınan numuna
        x3 = TextEdit8.Text     'yabancı
        x4 = TextEdit9.Text     'kuf
        x5 = TextEdit10.Text    'dal
        x6 = TextEdit11.Text    'çürüme
        x7 = TextEdit12.Text    'aşırı
        x8 = TextEdit13.Text    'içkurd
        x9 = TextEdit14.Text    'ikiz
        x10 = TextEdit15.Text   'ebat altı
        x11 = TextEdit16.Text   'çatlak
        x12 = TextEdit17.Text   'dolu
        x14 = TextEdit19.Text   'brix
        x15 = TextEdit20.Text   '22
        x16 = TextEdit21.Text   '24
        x17 = TextEdit22.Text   '26
        x18 = TextEdit23.Text   '28
        x19 = TextEdit24.Text   'sapsız
        toplamkusur = x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x14 + x15 + x16 + x17 + x19
        x13 = TextEdit18.Text   'toplam
        listkontrol = ListBox1.Items.Count
        If listkontrol > 0 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1 And ListBox2.Items.Count - 1 And ListBox3.Items.Count - 1 And ListBox4.Items.Count - 1
                TextEdit1.Text = ListBox1.Items(i)
                TextBox1.Text = ListBox2.Items(i)
                TextEdit3.Text = ListBox3.Items(i)
                'TextEdit6.Text = ListBox4.Items(i)
                TextEdit2.Text = "ALASEHIR"
                'TextEdit5.Text = "KIRAZ"
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "INSERT INTO EO_KIRAZGIRDI_KONTROL (HASAT_TARIH,ANALIZ_TARIH,TESIS,VARDIYA,BAHCE,ARAC_PLAKA,CESIT_ADI,TOPLAM_TONAJ,NUMUNE_MIKTARI,YABANCI_MADDE,KUFLENME,DAL_SURTMESI,CURUME,YUMUSAK,ICKURD,IKIZMEYVE,EBAT_ALTI,HASAR,DOLU_ZARAR,TOPLAM_KUSUR,BRIX,K22,K24,K26,K28,SAPSIZ_MEYVE,PESTISIT,TAT,KOKU,YAPI,SICAKLIK,ARAC_KONTROL,KONTROL_SONUC,KALITE_PERSONEL,K30) VALUES ( '" & TextEdit1.Text & "','" & Date.Today & "','" & TextEdit2.Text & "','" & ComboBoxEdit1.Text & "','" & ComboBoxEdit6.Text & "','" & TextEdit4.Text & "','" & ComboBoxEdit5.Text & "','" & Replace(x1, ",", ".") & "','" & Replace(x2, ",", ".") & "','" & Replace(x3, ",", ".") & "','" & Replace(x4, ",", ".") & "','" & Replace(x5, ",", ".") & "', '" & Replace(x6, ",", ".") & "','" & Replace(x7, ",", ".") & "','" & Replace(x8, ",", ".") & "','" & Replace(x9, ",", ".") & "','" & Replace(x10, ",", ".") & "','" & Replace(x11, ",", ".") & "','" & Replace(x12, ",", ".") & "','" & Replace(x13, ",", ".") & "','" & Replace(x14, ",", ".") & "','" & Replace(x15, ",", ".") & "','" & Replace(x16, ",", ".") & "','" & Replace(x17, ",", ".") & "','" & Replace(x18, ",", ".") & "','" & Replace(x19, ",", ".") & "','" & ComboBoxEdit2.Text & "','" & ComboBoxEdit2.Text & "','" & ComboBoxEdit7.Text & "','" & ComboBoxEdit8.Text & "','" & TextEdit25.Text & "','" & ComboBoxEdit3.Text & "','" & TextEdit29.Text & "','" & TextEdit3.Text & "')"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '---------------------------------------------------------------------------------------------------------------
                SqlConn.Open()
                Dim mySelectQuery21 As String = "Select MAX(ID) AS ID From EO_KIRAZGIRDI_KONTROL;"
                Dim SqlComm21 As New System.Data.SqlClient.SqlCommand(mySelectQuery21, SqlConn)
                Dim reader21 As System.Data.SqlClient.SqlDataReader
                reader21 = SqlComm21.ExecuteReader()
                While reader21.Read()
                    girdikontx = reader21("ID").ToString()
                End While
                reader21.Close()
                SqlConn.Close()
                '---------------------------------------------------------------------------------------------------------------
                conn1.Open()
                cmd3.Connection = conn1
                cmd3.CommandText = "UPDATE EO_ALANSIS_MAD SET KLTINDEX='3',GIRDIKONTROL='" & girdikontx & "' WHERE ID='" & TextBox1.Text & "'"
                cmd3.ExecuteNonQuery()
                conn1.Close()
                '--------------------------------------------
            Next
            TextBox1.Text = ""
            TextEdit1.Text = ""
            TextEdit2.Text = ""
            ComboBoxEdit1.Text = ""
            ComboBoxEdit2.Text = ""
            ComboBoxEdit3.Text = ""
            ComboBoxEdit5.Text = ""
            ComboBoxEdit6.Text = ""
            TextEdit3.Text = ""
            TextEdit4.Text = ""
            TextEdit7.Text = 0    'alınan numuna
            TextEdit8.Text = 0      'yabancı
            TextEdit9.Text = 0     'kuf
            TextEdit10.Text = 0    'dal
            TextEdit11.Text = 0     'çürüme
            TextEdit12.Text = 0    'aşırı
            TextEdit13.Text = 0    'içkurd
            TextEdit14.Text = 0    'ikiz
            TextEdit15.Text = 0    'ebat altı
            TextEdit16.Text = 0   'çatlak
            TextEdit17.Text = 0   'dolu
            TextEdit18.Text = 0   'toplam
            TextEdit19.Text = 0   'brix
            TextEdit20.Text = 0   '22
            TextEdit21.Text = 0    '24
            TextEdit22.Text = 0   '26
            TextEdit23.Text = 0   '28
            TextEdit3.Text = 0   '30
            TextEdit24.Text = 0    'sapsız
            TextEdit25.Text = ""
            TextEdit29.Text = ""
            DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
            Exit Sub
            Me.Close()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Kayıt Seçiniz...")
        End If
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde hata, Lütfen kontrol ediniz......")
        Exit Sub
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Form147.TextBox1.Text = "3"

        Form147.Show()
    End Sub

    Private Sub Form144_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            ComboBoxEdit6.Properties.Items.Add("BOLGE")
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
            ComboBoxEdit5.Properties.Items.Add("CESIT")
        End While
        reader2.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub

    Private Sub TextEdit8_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit8.EditValueChanged
        Dim u = Len(TextEdit8.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit8.Text = TextEdit8.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit9_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit9.EditValueChanged
        Dim u = Len(TextEdit9.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit9.Text = TextEdit9.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit24_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit24.EditValueChanged
        Dim u = Len(TextEdit24.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit24.Text = TextEdit24.Text.Substring(0, 5)
        End If
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

    End Sub

    Private Sub TextEdit19_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit19.EditValueChanged
        Dim u = Len(TextEdit19.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit19.Text = TextEdit19.Text.Substring(0, 5)
        End If
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

    Private Sub TextEdit23_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit23.EditValueChanged
        Dim u = Len(TextEdit23.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit23.Text = TextEdit23.Text.Substring(0, 5)
        End If
    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged
        Dim u = Len(TextEdit24.Text)
        If u > 5 Then
            MessageBox.Show("Maksimum sınıra ulaştınız!")
            TextEdit24.Text = TextEdit24.Text.Substring(0, 5)
        End If
    End Sub
End Class