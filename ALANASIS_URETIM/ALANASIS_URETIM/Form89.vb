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

Public Class Form89
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)

    Private Sub Form89_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ODA, PARTINO,BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY ODA;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("ODA"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery11 As String = "SELECT PARTINO FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY PARTINO;"
        Dim SqlComm11 As New System.Data.SqlClient.SqlCommand(mySelectQuery11, SqlConn)
        Dim reader11 As System.Data.SqlClient.SqlDataReader
        reader11 = SqlComm11.ExecuteReader()
        While reader11.Read()
            ComboBox2.Items.Add(reader11("PARTINO"))
        End While
        reader11.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        TextBox15.Text = "0"
        TextBox16.Text = "0"
        TextBox17.Text = "0"
        TextBox18.Text = "0"
        TextBox19.Text = "0"
        TextBox20.Text = "0"
        TextBox21.Text = "0"
        TextBox22.Text = "0"
        TextBox23.Text = "0"
        TextBox24.Text = "0"
        TextBox25.Text = "0"
        TextBox26.Text = "0"
        TextBox27.Text = "0"
        TextBox28.Text = "0"
        TextBox29.Text = "0"
        TextBox30.Text = "0"


        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ODA, PARTINO, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-----------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA, PARTINO, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='HAMMADDE' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextBox27.Text = reader1("NET").ToString()
            TextBox28.Text = reader1("BRUT").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT ODA, PARTINO,  BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='YARIMAMUL' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextBox25.Text = reader2("NET").ToString()
            TextBox26.Text = reader2("BRUT").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT ODA, PARTINO, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='SULUK' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextBox23.Text = reader3("NET").ToString()
            TextBox24.Text = reader3("BRUT").ToString()
        End While
        reader3.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery4 As String = "SELECT ODA, PARTINO,BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='2.KALITE' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        Dim reader4 As System.Data.SqlClient.SqlDataReader
        reader4 = SqlComm4.ExecuteReader()
        While reader4.Read()
            TextBox21.Text = reader4("NET").ToString()
            TextBox22.Text = reader4("BRUT").ToString()
        End While
        reader4.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery5 As String = "SELECT ODA, PARTINO, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='COP' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm5 As New System.Data.SqlClient.SqlCommand(mySelectQuery5, SqlConn)
        Dim reader5 As System.Data.SqlClient.SqlDataReader
        reader5 = SqlComm5.ExecuteReader()
        While reader5.Read()
            TextBox19.Text = reader5("NET").ToString()
            TextBox20.Text = reader5("BRUT").ToString()
        End While
        reader5.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery6 As String = "SELECT ODA, PARTINO, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='STOK' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, SqlConn)
        Dim reader6 As System.Data.SqlClient.SqlDataReader
        reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            TextBox17.Text = reader6("NET").ToString()
            TextBox18.Text = reader6("BRUT").ToString()
        End While
        reader6.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery17 As String = "SELECT ODA, PARTINO, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='MAMUL' AND PARTINO='" & ComboBox2.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
        Dim SqlComm17 As New System.Data.SqlClient.SqlCommand(mySelectQuery17, SqlConn)
        Dim reader17 As System.Data.SqlClient.SqlDataReader
        reader17 = SqlComm17.ExecuteReader()
        While reader17.Read()
            TextBox30.Text = reader17("NET").ToString()
            TextBox29.Text = reader17("BRUT").ToString()
        End While
        reader17.Close()
        SqlConn.Close()

        TextBox15.Text = Val(TextBox18.Text) + Val(TextBox20.Text) + Val(TextBox22.Text) + Val(TextBox24.Text) + Val(TextBox26.Text) + Val(TextBox28.Text) + Val(TextBox30.Text)
        TextBox16.Text = Val(TextBox17.Text) + Val(TextBox19.Text) + Val(TextBox21.Text) + Val(TextBox23.Text) + Val(TextBox25.Text) + Val(TextBox27.Text) + Val(TextBox29.Text)


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ODA, PARTINO,  BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_KIVI_MAMULDEPO WHERE CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, TIP, PARTINO ORDER BY ODA DESC;"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY ODA;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("ODA"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery11 As String = "SELECT PARTINO FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY PARTINO;"
        Dim SqlComm11 As New System.Data.SqlClient.SqlCommand(mySelectQuery11, SqlConn)
        Dim reader11 As System.Data.SqlClient.SqlDataReader
        reader11 = SqlComm11.ExecuteReader()
        While reader11.Read()
            ComboBox2.Items.Add(reader11("PARTINO"))
        End While
        reader11.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        On Error Resume Next
        '====================================================
        SaveFileDialog1.Filter = "XLS Files (*.xlsx*)|*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox31.Text, True)
            TextBox31.Text = SaveFileDialog1.FileName
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
                    xlWorkSheet.Cells(11, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 12, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.Range("A1").RowHeight = 30
        xlWorkSheet.Range("A1:G1").MergeCells = True
        xlWorkSheet.Range("A1").Font.Bold = True
        xlWorkSheet.Range("A1").Font.Size = 15
        xlWorkSheet.Range("A1").Value = "(" + DateTimePicker4.Text + "--" + DateTimePicker3.Text + ") KIVI URETIM RAPORU (MAMUL)"
        xlWorkSheet.Range("A1").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A1").VerticalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Range("B2").Value = "BRUT KG"
        xlWorkSheet.Range("B2:B10").VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("C2").Value = "NET KG"
        xlWorkSheet.Range("C2:C10").VerticalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Range("A3").Value = "HAMMADDE"
        xlWorkSheet.Range("B3").Value = TextBox28.Text
        xlWorkSheet.Range("C3").Value = TextBox27.Text
        xlWorkSheet.Range("A3").Font.Bold = True
        xlWorkSheet.Range("B3").Font.Bold = True
        xlWorkSheet.Range("C3").Font.Bold = True

        xlWorkSheet.Range("A4").Value = "YARI MAMUL"
        xlWorkSheet.Range("B4").Value = TextBox26.Text
        xlWorkSheet.Range("C4").Value = TextBox25.Text
        xlWorkSheet.Range("A4").Font.Bold = True
        xlWorkSheet.Range("B4").Font.Bold = True
        xlWorkSheet.Range("C4").Font.Bold = True

        xlWorkSheet.Range("A5").Value = "SULUK"
        xlWorkSheet.Range("B5").Value = TextBox24.Text
        xlWorkSheet.Range("C5").Value = TextBox23.Text
        xlWorkSheet.Range("A5").Font.Bold = True
        xlWorkSheet.Range("B5").Font.Bold = True
        xlWorkSheet.Range("C5").Font.Bold = True

        xlWorkSheet.Range("A6").Value = "2.KALITE"
        xlWorkSheet.Range("B6").Value = TextBox22.Text
        xlWorkSheet.Range("C6").Value = TextBox21.Text
        xlWorkSheet.Range("A6").Font.Bold = True
        xlWorkSheet.Range("B6").Font.Bold = True
        xlWorkSheet.Range("C6").Font.Bold = True

        xlWorkSheet.Range("A7").Value = "COP"
        xlWorkSheet.Range("B7").Value = TextBox20.Text
        xlWorkSheet.Range("C7").Value = TextBox19.Text
        xlWorkSheet.Range("A7").Font.Bold = True
        xlWorkSheet.Range("B7").Font.Bold = True
        xlWorkSheet.Range("C7").Font.Bold = True

        xlWorkSheet.Range("A8").Value = "STOK"
        xlWorkSheet.Range("B8").Value = TextBox18.Text
        xlWorkSheet.Range("C8").Value = TextBox17.Text
        xlWorkSheet.Range("A8").Font.Bold = True
        xlWorkSheet.Range("B8").Font.Bold = True
        xlWorkSheet.Range("C8").Font.Bold = True

        xlWorkSheet.Range("A9").Value = "MAMUL"
        xlWorkSheet.Range("B9").Value = TextBox30.Text
        xlWorkSheet.Range("C9").Value = TextBox29.Text
        xlWorkSheet.Range("A9").Font.Bold = True
        xlWorkSheet.Range("B9").Font.Bold = True
        xlWorkSheet.Range("C9").Font.Bold = True

        xlWorkSheet.Range("A10").Value = "GENEL TOPLAM"
        xlWorkSheet.Range("B10").Value = TextBox15.Text
        xlWorkSheet.Range("C10").Value = TextBox16.Text
        xlWorkSheet.Range("A10").Font.Bold = True
        xlWorkSheet.Range("B10").Font.Bold = True
        xlWorkSheet.Range("C10").Font.Bold = True






        xlWorkSheet.Range("A11:G11").Interior.ColorIndex = 23
        xlWorkSheet.Range("A11:G11").ColumnWidth = 25
        xlWorkSheet.Range("A11:G11").Font.Bold = True


        xlWorkSheet.SaveAs(TextBox31.Text)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Dosya aktarılmıstır...")
    End Sub
End Class