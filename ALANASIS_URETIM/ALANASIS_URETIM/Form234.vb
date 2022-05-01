Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail

Public Class Form234
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form234_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim id As String
        id = ""

        If TextBox1.Text = "1" Then

            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_FATONAY  SET ONAY ='" & TextEdit3.Text & "', ONAY_TARIHI='" & DateEdit2.Text & "' WHERE ID= '" & TextEdit3.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()



        End If

        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_FATONAY (TARIH,FATNO,FATDOSYA,ACIKLAMA,ONAY,ONAY_TARIHI) VALUES ('" & DateEdit1.Text & "','" & TextEdit2.Text & "','" & ButtonEdit1.Text & "','" & MemoEdit1.Text & "','" & TextEdit3.Text & "','" & DateEdit2.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Me.Hide()
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery11 As String = "SELECT TOP 1 ID AS ID  FROM EO_ALANSIS_FATONAY ORDER BY ID DESC;"
        Dim SqlComm11 As New System.Data.SqlClient.SqlCommand(mySelectQuery11, SqlConn)
        Dim reader11 As System.Data.SqlClient.SqlDataReader
        reader11 = SqlComm11.ExecuteReader()
        While reader11.Read()
            id = reader11("ID").ToString()
        End While
        reader11.Close()
        SqlConn.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SMTP.Timeout = 5
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
        SMTP.Port = "587"
        Mail.Subject = "Fatura No: " & TextEdit2.Text & ""
        'Mail.To.Add("ercanozyanar@gmail.com,saadet.atalay@alanar.com.tr,umut.yenmis@alanar.com.tr,ibrahim.erturk@alanar.com.tr,ridvan.akman@alanar.com.tr")
        Mail.To.Add("ridvan.akman@alanar.com.tr")
        Mail.From = New MailAddress("alansis.bilgi@gmail.com")
        Mail.IsBodyHtml = True
        '------------------------------------------------------------------
        Dim fileTXT As String = ButtonEdit1.Text
        Dim data As Net.Mail.Attachment = New Net.Mail.Attachment(fileTXT)
        Mail.Attachments.Add(data)
        '------------------------------------------------------------------
        Mail.Body = "<p><span>Fatura Numarası: " & TextEdit2.Text & "   " & DateTime.Now & " zamanında onaylanmak üzere tarafınıza iletilmiştir.....</span></p><p><strong>Onay Vermek icin lutfen aşağıdaki butonu tıklayınız...</strong></p> <p><strong>&nbsp;<span class= 'redButton' >▼ <a href=http://10.3.11.61/ALANSIS_WB/FATOnay/FATOnay/" + id & " > ONAYLA</a></span></strong></p>"
        SMTP.Send(Mail)
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        TextEdit2.Text = ""
        MemoEdit1.Text = ""
        ComboBoxEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        DateEdit1.Text = ""
        DateEdit2.Text = ""


    End Sub


    Private Sub ButtonEdit1_Click(sender As Object, e As EventArgs) Handles ButtonEdit1.Click
        On Error Resume Next
        Dim XtraOpenFileDialog1 As New OpenFileDialog()
        Dim yol, dosya As String
        XtraOpenFileDialog1.Filter = "All Files (*.*)|*.*"
        XtraOpenFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 2
        XtraOpenFileDialog1.RestoreDirectory = True

        XtraOpenFileDialog1.ShowDialog()
        If XtraOpenFileDialog1.FileName = "" Then Exit Sub
        ButtonEdit1.Text = XtraOpenFileDialog1.FileName

    End Sub

    Private Sub ButtonEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit1.EditValueChanged

    End Sub
End Class