Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Form140
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim grupkontrol As String = TextEdit2.Text
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "UPDATE EO_ALANSIS_SATIS SET NOK_BIRIM='" & ComboBoxEdit1.Text & "' WHERE PARTI='" & TextEdit1.Text & "'"
        cmd1.ExecuteNonQuery()
        '---------------------------------------------------------------------------------------------------
        If grupkontrol = "URETIM" Then
            SMTP.Timeout = 5
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
            SMTP.Port = "587"
            Mail.Subject = "Parti No: " & TextEdit1.Text & " Satış NOT OK Bildirim"
            Mail.To.Add("fatih.bakici@alanar.com.tr,uretim.saha@alanar.com.tr,sinan.aksit@alanar.com.tr,medine.ozdemir@alanar.com.tr,abdullah.kaya@alanar.com.tr,ridvan.akman@alanar.com.tr")
            Mail.From = New MailAddress("alansis.bilgi@gmail.com")
            Mail.Body = "Parti No: " & TextEdit1.Text & " Satış Onay işlemi" & DateTime.Now & " zamanında NOK OK verilmiştir.Duzeltme Beklenen Birim : " & ComboBoxEdit1.Text & "Açıklama : " & MemoEdit1.Text
            SMTP.Send(Mail)
        End If
        DevExpress.XtraEditors.XtraMessageBox.Show("Gönderim Tamamlanmıştır...")
        Me.Close()

    End Sub
End Class