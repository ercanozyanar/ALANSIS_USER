Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form146
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
        Dim x1, x2, x3, x4 As Decimal
        x1 = 0
        x2 = 0
        x3 = 0
        x4 = 0
        x1 = TextEdit16.Text
        x2 = TextEdit15.Text
        x3 = TextEdit14.Text
        x4 = TextEdit7.Text
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_KIRAZFUMIGASYON_KONTROL (FUMIGASYON_TARIHI,UBK,HASAT_TARIHI,URUN_CESIDI,MUSTERI_ADI,PARTINO,MEYVE_SICAKLIK,KONTEYNER_SICAKLIK,BAS_KONSANTRE,BIT_KONSANTRE,FUMIGASYON_SAAT,FUMIGASYON_SURE,FUMIGASYON_OPERATOR,ACIKLAMA) valueS ( '" & TextEdit1.Text & "','" & TextEdit2.Text & "','" & Date.Today & "','" & TextEdit3.Text & "','" & TextEdit6.Text & "','" & TextEdit9.Text & "','" & Replace(x1, ",", ".") & "','" & Replace(x2, ",", ".") & "','" & Replace(x3, ",", ".") & "','" & Replace(x4, ",", ".") & "','" & TextEdit8.Text & "','" & TextEdit10.Text & "','" & TextEdit17.Text & "','" & MemoEdit1.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        TextEdit4.Text = ""
        TextEdit5.Text = ""
        TextEdit6.Text = 0
        TextEdit7.Text = 0
        TextEdit8.Text = 0
        TextEdit9.Text = 0
        TextEdit10.Text = 0
        TextEdit14.Text = 0
        TextEdit15.Text = 0
        TextEdit16.Text = 0
        TextEdit17.Text = 0
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde hata, Lütfen kontrol ediniz......")
        Exit Sub
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Form147.TextBox1.Text = "1"
        Form147.Show()
    End Sub
End Class