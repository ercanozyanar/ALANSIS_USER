Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Application.Exit()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim kim_kontrol, modul, yetki, grup
        kim_kontrol = ""
        grup = ""
        txtUserName.Text = txtUserName.Text.ToUpper
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_USER WHERE USR='" & txtUserName.Text & "' and PASSWORD='" & txtPassword.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            kim_kontrol = reader1("KIMLIK").ToString()
            grup = reader1("GRUP").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        If kim_kontrol <> "" Then
            Me.Hide()
            Form2.Text = "ALANSIS USER :" + txtUserName.Text
            Form2.BarStaticItem4.Caption = "GRUP KODU :" + grup.ToString
            Form2.Show()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz Parola, Tekrar deneyiniz!")
            txtPassword.Select()

        End If
    End Sub
End Class
