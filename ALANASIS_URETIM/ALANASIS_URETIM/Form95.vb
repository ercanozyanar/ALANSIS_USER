Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form95
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form95_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim kontrol As String
        Dim x1, x2, x3 As Double
        x1 = CDbl(TextBox2.Text)
        x2 = CDbl(TextBox5.Text)
        x3 = CDbl(TextBox6.Text)
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        kontrol = ""
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT TARIH FROM EO_ALANSIS_SATIS_PARITE WHERE TARIH='" & MaskedTextBox1.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            kontrol = reader1("TARIH").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        If kontrol = "" Then
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO  EO_ALANSIS_SATIS_PARITE (TARIH,USD_EUR,USD_GBP,GBP_EUR) VALUES ( '" & MaskedTextBox1.Text & "','" & Replace(x1, ",", ".") & "','" & Replace(x2, ",", ".") & "','" & Replace(x3, ",", ".") & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            MsgBox("Kayit İşlemi Tamamlanmiştir...")
            MaskedTextBox1.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        Else
            MsgBox("Daha önceden tarihli kayıt mevcuttur.Kayıt edilemez...")
            Exit Sub
        End If
    End Sub
End Class