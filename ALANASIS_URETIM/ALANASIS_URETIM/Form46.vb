Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports iTextSharp.text
Imports iTextSharp.text.html
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf.PdfPTable
Imports System.IO
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form46

    Private Sub Form46_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery2 As String = "SELECT KIMLIK FROM EO_ALANSIS_LOG group by KIMLIK ;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, cnn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            ComboBox1.Items.Add(reader2("KIMLIK"))
        End While
        reader2.Close()
        cnn1.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,KIMLIK AS KULLANICI,MODUL AS ICERIK,DETAY AS ISLEM FROM EO_ALANSIS_LOG WHERE KIMLIK='" & ComboBox1.Text & "' ORDER BY ID DESC"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 220
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 500
            DataGridView1.Columns(3).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
    End Sub
End Class