Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form237
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
        Dim id As String
        id = ""
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_SEVKDIGER (TARIH,FATNO,STOK_TIPI,STOK_ADI,SEVK_TIPI,SEVK_CARI,SEVK_ADRES,SEVK_IL,SEVK_ILCE,ARAC_PLAKA,SOFOR,BRUT,DARA,NET,KASA_TIPI,KASA_MIKTAR,PALET_TIPI,PALET_MIKTAR) VALUES ('" & DateEdit1.Text & "','" & TextEdit1.Text & "','" & ComboBoxEdit1.Text & "','" & ComboBoxEdit2.Text & "','" & ComboBoxEdit3.Text & "','" & TextEdit2.Text & "','" & MemoEdit1.Text & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "','" & TextEdit6.Text & "','" & TextEdit5.Text & "','" & Replace(TextEdit11.Text, ",", ".") & "','" & Replace(TextEdit12.Text, ",", ".") & "','" & Replace(TextEdit13.Text, ",", ".") & "','" & TextEdit8.Text & "','" & TextEdit14.Text & "','" & TextEdit10.Text & "','" & TextEdit9.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Me.Hide()
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        TextEdit2.Text = ""
        MemoEdit1.Text = ""
        ComboBoxEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        DateEdit1.Text = ""

    End Sub

    Private Sub TextEdit11_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit11.EditValueChanged
        On Error Resume Next
        Dim brut, dara, net As Decimal
        brut = 0
        dara = 0
        net = 0
        brut = CDec(TextEdit11.Text)
        dara = CDec(TextEdit12.Text)
        net = brut - dara
        TextEdit13.Text = net
    End Sub

    Private Sub TextEdit12_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit12.EditValueChanged
        On Error Resume Next
        Dim brut, dara, net As Decimal
        brut = 0
        dara = 0
        net = 0
        brut = CDec(TextEdit11.Text)
        dara = CDec(TextEdit12.Text)
        net = brut - dara
        TextEdit13.Text = net
    End Sub
End Class