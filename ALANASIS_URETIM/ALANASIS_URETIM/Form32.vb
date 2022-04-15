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
Public Class Form32
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim da1 As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Try

            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM dbo.EO_NARMAMUL_TOPLAMK WHERE TARIH='" & DateTimePicker4.Text & "';"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-----------------------------------------------------------------------------------------
        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT VIYOL,SUM(NET)AS NET,SUM(YUZDE) AS YUZDE FROM dbo.EO_NARMAMUL_YUZDE WHERE TARIH='" & DateTimePicker4.Text & "' group by VIYOL;"
            da1.SelectCommand = cmd
            da1.Fill(ds1)
            DataGridView2.DataSource = ds1.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-----------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery2 As String = "SELECT GUNLUK_TOPLAM FROM EO_NARMAMUK_TOPLAMGT WHERE TARIH='" & DateTimePicker4.Text & "' ;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, cnn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextBox28.Text = (reader2("GUNLUK_TOPLAM"))
        End While
        reader2.Close()
        cnn.Close()
        '-----------------------------------------------------------------------------------------
        ComboBox2.Items.Clear()
        cnn.Open()
        Dim mySelectQuery1 As String = "SELECT BOLGE FROM EO_NARMAMUL_BOLGEYUZDE WHERE TARIH='" & DateTimePicker4.Text & "' GROUP BY BOLGE;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("BOLGE"))
        End While
        reader1.Close()
        cnn.Close()
        '-----------------------------------------------------------------------------------------




    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        On Error Resume Next
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim da1 As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        TextBox1.Text = "0"
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"


        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT VIYOL,NET,YUZDE FROM dbo.EO_NARMAMUL_BOLGEYUZDE WHERE TARIH='" & DateTimePicker4.Text & "' AND BOLGE='" & ComboBox2.Text & "';"
        da.SelectCommand = cmd
        da.Fill(ds)
        DataGridView3.DataSource = ds.Tables(0).DefaultView
        cnn.Close()
        '-----------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery2 As String = "SELECT SUM(NET) AS NET FROM EO_NARMAMUL_BOLGEYUZDE WHERE TARIH='" & DateTimePicker4.Text & "' AND BOLGE='" & ComboBox2.Text & "';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, cnn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextBox1.Text = IIf((reader2("NET")), reader2("NET"), 0)
        End While
        reader2.Close()
        cnn.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        '====================================================
        SaveFileDialog1.Filter = "XLS Files (*.xls*)|*.xls"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox2.Text, True)
            TextBox2.Text = SaveFileDialog1.FileName
        End If
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim xlWorkSheet1 As Microsoft.Office.Interop.Excel.Worksheet
        Dim xlWorkSheet2 As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i, b, c, d, f, g, h, l, m, n As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet1 = xlWorkBook.Sheets.Add("Sayfa2")
        xlWorkSheet2 = xlWorkBook.Sheets.Add("Sayfa3")
        xlWorkSheet = xlWorkBook.Sheets("Sayfa1")
        xlWorkSheet1 = xlWorkBook.Sheets("Sayfa2")
        xlWorkSheet2 = xlWorkBook.Sheets("Sayfa3")



        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(2, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 3, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next


        For i = 0 To DataGridView2.RowCount - 2
            For j = 0 To DataGridView2.ColumnCount - 1
                For k As Integer = 1 To DataGridView2.Columns.Count
                    xlWorkSheet1.Cells(2, k) = DataGridView2.Columns(k - 1).HeaderText
                    xlWorkSheet1.Cells(i + 3, j + 1) = DataGridView2(j, i).Value.ToString()
                Next
            Next
        Next


        For i = 0 To DataGridView3.RowCount - 2
            For j = 0 To DataGridView3.ColumnCount - 1
                For k As Integer = 1 To DataGridView3.Columns.Count
                    xlWorkSheet2.Cells(2, k) = DataGridView3.Columns(k - 1).HeaderText
                    xlWorkSheet2.Cells(i + 3, j + 1) = DataGridView3(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.Range("A1").RowHeight = 30
        xlWorkSheet.Range("A1:W1").MergeCells = True
        xlWorkSheet.Range("A1").Font.Bold = True
        xlWorkSheet.Range("A1").Font.Size = 15
        xlWorkSheet.Range("A1").Value = "TARIH :" + DateTimePicker4.Text + " URETIM PAKETLEME RAPORU"
        xlWorkSheet.Range("A1").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A1").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A2:A9999").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A2:A9999").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B2:B9999").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B2:B9999").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Shapes.ADDP()
        xlWorkSheet.Range("A2:W2").Interior.ColorIndex = 23
        xlWorkSheet.Range("A2").ColumnWidth = 15
        xlWorkSheet.Range("B2").ColumnWidth = 15
        xlWorkSheet.Range("C2").ColumnWidth = 15
        xlWorkSheet.Range("D2").ColumnWidth = 20
        xlWorkSheet.Range("E2").ColumnWidth = 30
        xlWorkSheet.Range("F2").ColumnWidth = 15
        xlWorkSheet.Range("G2").ColumnWidth = 15
        xlWorkSheet.Range("H2").ColumnWidth = 15
        xlWorkSheet.Range("I2").ColumnWidth = 20
        xlWorkSheet.Range("J2").ColumnWidth = 30
        xlWorkSheet.Range("K2").ColumnWidth = 15
        xlWorkSheet.Range("L2").ColumnWidth = 15
        xlWorkSheet.Range("M2").ColumnWidth = 15
        xlWorkSheet.Range("N2").ColumnWidth = 20
        xlWorkSheet.Range("O2").ColumnWidth = 30
        xlWorkSheet.Range("P2").ColumnWidth = 15
        xlWorkSheet.Range("Q2").ColumnWidth = 15
        xlWorkSheet.Range("R2").ColumnWidth = 15
        xlWorkSheet.Range("S2").ColumnWidth = 20
        xlWorkSheet.Range("T2").ColumnWidth = 30
        xlWorkSheet.Range("U2").ColumnWidth = 30
        xlWorkSheet.Range("V2").ColumnWidth = 15
        xlWorkSheet.Range("W2").ColumnWidth = 15
       

        xlWorkSheet.Range("A2:W2").Font.Bold = True
        '==========================================================================================================
        xlWorkSheet.SaveAs(TextBox2.Text)
        xlWorkSheet1.SaveAs(TextBox2.Text)
        xlWorkSheet2.SaveAs(TextBox2.Text)
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        '==========================================================================================================

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

    Private Sub Form32_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class