Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form27
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sifre_user, sifre_pass
        Dim conn1, cnn As New SqlConnection
        Dim cmd1, cmd As New SqlCommand
        sifre_user = ""
        sifre_pass = ""
        sifre_user = Trim(Mid(Form2.Text, 15, 50))
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '---------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT * FROM EO_ALANSIS_USER WHERE USR= '" & sifre_user & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            sifre_pass = (reader1("PASSWORD"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        If sifre_pass = TextBox28.Text Then
            If TextBox1.Text = TextBox2.Text Then
                '---------------------------------------------------------------------------------------------------
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "UPDATE EO_ALANSIS_USER SET PASSWORD='" & TextBox1.Text & "' WHERE USR='" & sifre_user & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '---------------------------------------------------------------------------------------------------
                MsgBox("SIFRENIZ DEGISTIRILMISTIR...")
            Else
                MsgBox("YENI GIRILEN SIFRELER BIRBIRINDEN FARKLIDIR,LUTFEN KONTROL EDINIZ...")
                Exit Sub
            End If
        Else
            MsgBox("ESKI SIFRENIZ HATALIDIR,LUTFEN KONTROL EDINIZ...")
            Exit Sub
        End If
    End Sub
End Class