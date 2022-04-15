Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Imports iTextSharp.text
Imports iTextSharp.text.html
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf.PdfPTable
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Public Class Form114
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged
        On Error Resume Next
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_SATIS_DETAY WHERE PARTINO='" & TextBox30.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextBox1.Text = (reader1("HAFTA"))
            MaskedTextBox1.Text = (reader1("FATURA_TARIHI"))
            MaskedTextBox2.Text = (reader1("SEVK_TARIHI"))
            TextBox8.Text = (reader1("HESAP"))
            TextBox3.Text = (reader1("MUSTERI2"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        TextBox6.Text = Replace(TextBox6.Text, ",", ".")
        TextBox7.Text = Replace(TextBox7.Text, ",", ".")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_KALITE_CLAIM (PARTI,HAFTA,FATURA_TARIH,SEVK_TARIH,MUSTERI1,MUSTERI2,URUN,CLAIM,SEBEP,ACIKLAMA,DOVKOD,ALACAK,BORC,TIPI,CLAIM_ACIKLAMA) VALUES ( '" & TextBox30.Text & "','" & TextBox1.Text & "','" & MaskedTextBox1.Text & "','" & MaskedTextBox2.Text & "','" & TextBox8.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "', '" & ComboBox2.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox3.Text & "','" & TextBox9.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        TextBox1.Text = ""
        TextBox2.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        TextBox8.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox9.Text = ""
        TextBox7.Text = ""
        TextBox30.Text = ""
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Form115.Show()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "DELETE FROM EO_ALANSIS_KALITE_CLAIM WHERE ID='" & TextBox10.Text & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form99.TextBox2.Text = "2"
        Form99.Show()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form114_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class