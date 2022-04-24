Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail

Public Class Form231
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
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_KIMYO_TAKIP (PROJE_ADI,PROJE_ACIKLAMASI,TALEP_EDILEN_MEYVE,CESIT,EBAT,MIKTAR,TOPLAM_TUTAR,ETKINLIK_TARIHI,TESLIM_TARIHI,TESLIM_KISI,TESLIM_ADRES,GONDERIM_NOT,TALEP_SAHIBI,KIMYO_ONAY) VALUES ('" & TextEdit1.Text & "','" & MemoEdit1.Text & "','" & ComboBoxEdit1.Text & "','" & TextEdit12.Text & "','" & TextEdit2.Text & "','" & TextEdit3.Text & "','" & Replace(TextEdit7.Text, ",", ".") & "','" & DateEdit1.Text & "','" & DateEdit2.Text & "','" & TextEdit8.Text & "','" & MemoEdit2.Text & "','" & MemoEdit3.Text & "','" & TextEdit9.Text & "','" & ComboBoxEdit2.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Me.Hide()
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        TextEdit1.Text = ""
        MemoEdit1.Text = ""
        ComboBoxEdit1.Text = ""
        TextEdit12.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        TextEdit7.Text = ""
        DateEdit1.Text = ""
        DateEdit2.Text = ""
        TextEdit8.Text = ""
        MemoEdit2.Text = ""
        MemoEdit3.Text = ""
        TextEdit9.Text = ""
        TextEdit11.Text = ""


    End Sub

    Private Sub Form231_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        On Error Resume Next
        Dim karar, id, partino, seri, monay, zonay As String
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        monay = ""
        zonay = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        Dim conn1 As New SqlConnection
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_KIMYO_TAKIP WHERE TAKIP_NO='" & TextEdit6.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit6.Text = reader1("TAKIP_NO")
            TextEdit1.Text = reader1("PROJE_ADI")
            MemoEdit1.Text = reader1("PROJE_ACIKLAMASI")
            ComboBoxEdit1.Text = reader1("TALEP_EDILEN_MEYVE")
            TextEdit12.Text = reader1("CESIT")
            TextEdit2.Text = reader1("EBAT")
            TextEdit3.Text = reader1("MIKTAR")
            TextEdit7.Text = reader1("TOPLAM_TUTAR")
            DateEdit1.Text = reader1("ETKINLIK_TARIHI")
            DateEdit2.Text = reader1("TESLIM_TARIHI")
            TextEdit8.Text = reader1("TESLIM_KISI")
            MemoEdit2.Text = reader1("TESLIM_ADRES")
            MemoEdit3.Text = reader1("GONDERIM_NOT")
            TextEdit9.Text = reader1("TALEP_SAHIBI")
            ComboBoxEdit2.Text = reader1("KIMYO_ONAY")
        End While
        reader1.Close()
        conn1.Close()

    End Sub
End Class