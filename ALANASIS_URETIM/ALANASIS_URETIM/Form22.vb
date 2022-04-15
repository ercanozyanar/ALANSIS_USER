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

Public Class Form22
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery2 As String = "SELECT [no] FROM EO_ALANSIS_SHAR_BAK WHERE sarf_adi='" & ComboBox1.Text & "' group by [no] ;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, cnn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            ComboBox2.Items.Add(reader2("no"))
        End While
        reader2.Close()
        cnn1.Close()

    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SHAR_BAK group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        cnn1.Open()
        Dim mySelectQuery2 As String = "SELECT [no] FROM EO_ALANSIS_SHAR_BAK WHERE sarf_adi='" & ComboBox1.Text & "' group by [no] ;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, cnn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            ComboBox2.Items.Add(reader2("sarf_adi"))
        End While
        reader2.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------


    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        '-----------------------------------------------------------------------------------------
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND [NO]='" & ComboBox2.Text & "' ORDER BY ID ASC"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 500
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 170
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        cnn.Open()
        Dim mySelectQuery8 As String = "SELECT* FROM EO_ALANSIS_SHAR_BAK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND [NO]='" & ComboBox2.Text & "';"
        Dim SqlComm8 As New System.Data.SqlClient.SqlCommand(mySelectQuery8, cnn)
        Dim reader8 = SqlComm8.ExecuteReader()
        While reader8.Read()
            TextBox3.Text = reader8("BAKIYE").ToString()
        End While
        reader8.Close()
        cnn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        '====================================================
        SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
            TextBox1.Text = SaveFileDialog1.FileName
        End If
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1


        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.Color(240, 240, 240)
            pdfTable.AddCell(cell)
        Next


        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next


        Dim folderPath As String = TextBox1.Text
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using stream As New FileStream(folderPath, FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
        MsgBox("Dosya Aktarılmıştır...")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        '====================================================
        SaveFileDialog1.Filter = "XLS Files (*.xls*)|*.xls"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
            TextBox1.Text = SaveFileDialog1.FileName
        End If
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sayfa1")


        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(2, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 3, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.Range("A1:F1").MergeCells = True
        xlWorkSheet.Range("A1").Font.Bold = True
        xlWorkSheet.Range("A1").Font.Size = 20
        xlWorkSheet.Range("A1").RowHeight = 30
        xlWorkSheet.Range("A1").Value = "URETIM SARF STOK RAPORU"
        xlWorkSheet.Range("A1").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A1").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B2:B9999").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B2:B9999").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("D2:D9999").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("D2:D9999").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("E2:E9999").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("E2:E9999").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A2:F2").Interior.ColorIndex = 23
        xlWorkSheet.Range("A2:F2").Font.Bold = True
        xlWorkSheet.Range("A2").ColumnWidth = 16
        xlWorkSheet.Range("B2").ColumnWidth = 20
        xlWorkSheet.Range("C2").ColumnWidth = 50
        xlWorkSheet.Range("D2").ColumnWidth = 13
        xlWorkSheet.Range("E2").ColumnWidth = 10
        xlWorkSheet.Range("F2").ColumnWidth = 35

        xlWorkSheet.SaveAs(TextBox1.Text)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Dosya aktarılmıstır...")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class