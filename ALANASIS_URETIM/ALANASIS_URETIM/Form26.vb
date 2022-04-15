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

Public Class Form26
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM dbo.EO_DEPO_MALKABUL_GENEL WHERE TARIH BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "';"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        '====================================================
        SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
            TextBox1.Text = SaveFileDialog1.FileName
        End If
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 90
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        'xlWorkSheet.Shapes.AddPicture("C:\ANA.jpg", False, True, 0, 0, 45, 50)
        xlWorkSheet.Range("A1").RowHeight = 30
        xlWorkSheet.Range("A1:J1").MergeCells = True
        xlWorkSheet.Range("A1").Font.Bold = True
        xlWorkSheet.Range("A1").Font.Size = 15
        xlWorkSheet.Range("A1").Value = "DEPO MAL KABUL RAPORU"
        xlWorkSheet.Range("A1").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A1").VerticalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Shapes.ADDP()
        xlWorkSheet.Range("A2:J2").Interior.ColorIndex = 23
        xlWorkSheet.Range("A2").ColumnWidth = 17
        xlWorkSheet.Range("B2").ColumnWidth = 20
        xlWorkSheet.Range("C2").ColumnWidth = 30
        xlWorkSheet.Range("D2").ColumnWidth = 17
        xlWorkSheet.Range("E2").ColumnWidth = 30
        xlWorkSheet.Range("F2").ColumnWidth = 30

        xlWorkSheet.Range("G2").ColumnWidth = 30
        xlWorkSheet.Range("H2").ColumnWidth = 10
        xlWorkSheet.Range("I2").ColumnWidth = 30
        xlWorkSheet.Range("J2").ColumnWidth = 10
        xlWorkSheet.Range("A2:J2").Font.Bold = True
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
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

End Class