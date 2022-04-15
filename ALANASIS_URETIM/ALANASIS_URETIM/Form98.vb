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
Public Class Form98
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form98_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
            TextBox6.Text = (reader1("URUN"))
            TextBox4.Text = (reader1("ULKE"))
            TextBox5.Text = (reader1("BOLGE"))
            TextBox9.Text = (reader1("SINIF"))
            TextBox7.Text = (reader1("KUTU"))
            TextBox10.Text = (reader1("AMBALAJ"))
            TextBox11.Text = (reader1("EBAT"))
            TextBox12.Text = (reader1("PALET_SAY"))
            TextBox13.Text = (reader1("KUTU_SAY"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox14.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox14.Text, True)
                TextBox14.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox14.Text, destinationFile)
                TextBox14.Text = destinationFile
            End If
        Else
            Shell(TextBox14.Text, 3)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox15.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox15.Text, True)
                TextBox15.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox15.Text, destinationFile)
                TextBox15.Text = destinationFile
            End If
        Else
            Shell(TextBox15.Text, 3)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox16.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox16.Text, True)
                TextBox16.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox16.Text, destinationFile)
                TextBox16.Text = destinationFile
            End If
        Else
            Shell(TextBox16.Text, 3)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox17.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox17.Text, True)
                TextBox17.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox17.Text, destinationFile)
                TextBox17.Text = destinationFile
            End If
        Else
            Shell(TextBox17.Text, 3)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        Dim destinationFile, data As String
        If TextBox18.Text = "" Then
            '====================================================
            data = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, TextBox18.Text, True)
                TextBox18.Text = OpenFileDialog1.FileName
                data = IO.Path.GetFileName(OpenFileDialog1.FileName)
                destinationFile = "C:\ALANSIS_CLAIM\" + data
                My.Computer.FileSystem.CopyFile(TextBox18.Text, destinationFile)
                TextBox18.Text = destinationFile
            End If
        Else
            Shell(TextBox18.Text, 3)
        End If
    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox4.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox4_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox4.TextChanged
        On Error Resume Next
        Dim t As Date
        t = MaskedTextBox4.Text
        TextBox23.Text = DatePart("ww", t)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form99.TextBox2.Text = "1"
        Form99.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        TextBox2.Text = Replace(TextBox2.Text, ",", ".")
        TextBox46.Text = Replace(TextBox46.Text, ",", ".")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_SATIS_CLAIM (PARTI,HAFTA,TARIH,CLAIM_PALET,CLAIM_KG,CLAIM_ACIKLAMA,CLAIM_DOKUMAN1,CLAIM_DOKUMAN2,CLAIM_DOKUMAN3,CLAIM_DOKUMAN4,CLAIM_DOKUMAN5,DOV_KOD,FIYAT) VALUES ( '" & TextBox30.Text & "','" & TextBox23.Text & "','" & MaskedTextBox4.Text & "','" & TextBox22.Text & "','" & TextBox2.Text & "','" & TextBox19.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "', '" & TextBox18.Text & "','" & ComboBox6.Text & "','" & TextBox46.Text & "')"
        cmd1.ExecuteNonQuery()
        cmd2.Connection = conn1
        cmd2.CommandText = "INSERT INTO  EO_ALANSIS_SATIS_DETAY (HAFTA,FATURA_TARIHI,HESAP,MUSTERI2,URUN,PARTINO,ACIKLAMA,DOV_KOD,BORC,TIPI,MUHASEBE_KAYIT) VALUES ( '" & TextBox23.Text & "','" & MaskedTextBox4.Text & "','" & TextBox8.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox30.Text & "','FIYAT_DUZELTMESI','" & ComboBox6.Text & "','" & TextBox46.Text & "','SATIS_CLAIMI','ISLENDI')"
        cmd2.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        MsgBox("Kayit İşlemi Tamamlanmiştir...")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox46.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        TextBox8.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox9.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox30.Text = ""
        MaskedTextBox4.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox19.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        ComboBox6.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class