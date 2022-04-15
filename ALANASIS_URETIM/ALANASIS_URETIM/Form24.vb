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
Public Class Form24
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            cmd.CommandText = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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
        '---------------------------------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
        Dim reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            TextBox5.Text = reader6("TGIRIS").ToString()
        End While
        If TextBox5.Text = "" Then
            TextBox5.Text = "0"
        End If
        reader6.Close()
        cnn.Close()
        '---------------------------------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
        Dim reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            TextBox2.Text = reader7("TCIKIS").ToString()
        End While
        If TextBox2.Text = "" Then
            TextBox2.Text = "0"
        End If
        reader7.Close()
        cnn.Close()
        '--------------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------
        TextBox3.Text = TextBox5.Text - TextBox2.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox4.Text = "ALASEHIR"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE= 'ALASEHIR' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox4.Text = "BURSA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE= 'BURSA' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox4.Text = "ADANA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE= 'ADANA' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        TextBox4.Text = "MALATYA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE= 'MALATYA' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        TextBox4.Text = "CANAKKALE"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE= 'CANAKKALE' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        TextBox4.Text = "KONYA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE= 'KONYA' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conn1, cnn As New SqlConnection
        Dim cmd1, cmd As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim result As DialogResult = MessageBox.Show("Sayım Girişi için emin misiniz...?", "Alansis Sayım Girişi", MessageBoxButtons.YesNo)
        Dim hareket_kodu, numara1
        Dim numara As Double
        Dim sayim, bakiye, deger As Integer
        sayim = 0
        bakiye = 0
        deger = 0
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            sayim = InputBox("Sayım Girişi")
            bakiye = TextBox3.Text
            deger = sayim - bakiye
            If deger < 0 Then
                hareket_kodu = "C"
            End If
            If deger > 0 Then
                hareket_kodu = "G"
            End If
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            '-----------------------------------------------------------------------------------------
            conn1.Open()
            Dim mySelectQuery1 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_DEPO_SARFHAR;"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                numara = reader1("ID")
            End While
            reader1.Close()
            conn1.Close()
            numara1 = "SAYIM"
            '---------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU,SUBE) VALUES ('" & DateTime.Now & "', '" & numara1 & "','" & ComboBox1.Text & "', 'SAYIM','" & deger & "'  ,'" & hareket_kodu & "','" & TextBox4.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
            Dim reader6 = SqlComm6.ExecuteReader()
            While reader6.Read()
                TextBox5.Text = reader6("TGIRIS").ToString()
            End While
            If TextBox5.Text = "" Then
                TextBox5.Text = "0"
            End If
            reader6.Close()
            cnn.Close()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
            Dim reader7 = SqlComm7.ExecuteReader()
            While reader7.Read()
                TextBox2.Text = reader7("TCIKIS").ToString()
            End While
            If TextBox2.Text = "" Then
                TextBox2.Text = "0"
            End If
            reader7.Close()
            cnn.Close()
            TextBox3.Text = TextBox5.Text - TextBox2.Text
            MsgBox("İslem Tamamlandı...")
        End If
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim numara, datnumara
        Dim dat_miktar As Integer
        Dim result As DialogResult = MessageBox.Show("DAT Girişi için emin misiniz...?", "Alansis DAT Girişi", MessageBoxButtons.YesNo)
        numara = ""
        datnumara = ""
        dat_miktar = 0
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            dat_miktar = InputBox("DAT Miktar Girişi")
            SqlConn.Open()
            Dim mySelectQuery9 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_DEPO_SARFHAR;"
            Dim SqlComm9 As New System.Data.SqlClient.SqlCommand(mySelectQuery9, SqlConn)
            Dim reader9 As System.Data.SqlClient.SqlDataReader
            reader9 = SqlComm9.ExecuteReader()
            While reader9.Read()
                numara = (reader9("ID"))
            End While
            datnumara = "DAT2020" & numara
            reader9.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU,SUBE) VALUES ('" & DateTime.Now & "', '" & datnumara & "','" & ComboBox1.Text & "', 'DAT','" & dat_miktar & "'  ,'C','" & TextBox4.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
            MsgBox("İslem Tamamlandı...")
            ComboBox1.Items.Clear()
            TextBox5.Text = ""
            TextBox5.Text = ""
            '---------------------------------------------------------------------------------------------------------------
            numara = ""
            datnumara = ""


            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
            Dim reader6 = SqlComm6.ExecuteReader()
            While reader6.Read()
                TextBox5.Text = reader6("TGIRIS").ToString()
            End While
            If TextBox5.Text = "" Then
                TextBox5.Text = "0"
            End If
            reader6.Close()
            cnn.Close()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
            Dim reader7 = SqlComm7.ExecuteReader()
            While reader7.Read()
                TextBox2.Text = reader7("TCIKIS").ToString()
            End While
            If TextBox2.Text = "" Then
                TextBox2.Text = "0"
            End If
            reader7.Close()
            cnn.Close()
            '--------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------
            TextBox3.Text = TextBox5.Text - TextBox2.Text







        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
       
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
                    xlWorkSheet.Cells(5, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 6, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.Range("A1").RowHeight = 30
        xlWorkSheet.Range("A1:F1").MergeCells = True
        xlWorkSheet.Range("A1").Font.Bold = True
        xlWorkSheet.Range("A1").Font.Size = 15
        xlWorkSheet.Range("A1").Value = TextBox4.Text + " YARDIMCI MALZEME DEPO STOK HAREKET RAPORU"
        xlWorkSheet.Range("A1").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("A1").VerticalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Range("A2").Value = "GIRIS MIKTARI :"
        xlWorkSheet.Range("B2").Value = TextBox5.Text
        xlWorkSheet.Range("A2").Font.Bold = True
        xlWorkSheet.Range("B2").Font.Bold = True
        xlWorkSheet.Range("B2").Font.ColorIndex = 43

        xlWorkSheet.Range("A3").Value = "CIKIS MIKTARI :"
        xlWorkSheet.Range("B3").Value = TextBox2.Text
        xlWorkSheet.Range("A3").Font.Bold = True
        xlWorkSheet.Range("B3").Font.Bold = True
        xlWorkSheet.Range("B3").Font.ColorIndex = 3

        xlWorkSheet.Range("A4").Value = "BAKIYE :"
        xlWorkSheet.Range("B4").Value = TextBox3.Text
        xlWorkSheet.Range("A4").Font.Bold = True
        xlWorkSheet.Range("B4").Font.Bold = True
        xlWorkSheet.Range("B4").Font.ColorIndex = 41

        xlWorkSheet.Range("A5:F5").Interior.ColorIndex = 23
        xlWorkSheet.Range("A5").ColumnWidth = 16
        xlWorkSheet.Range("B5").ColumnWidth = 20
        xlWorkSheet.Range("C5").ColumnWidth = 50
        xlWorkSheet.Range("D5").ColumnWidth = 13
        xlWorkSheet.Range("E5").ColumnWidth = 10
        xlWorkSheet.Range("F5").ColumnWidth = 35
        xlWorkSheet.Range("A5:F5").Font.Bold = True
        xlWorkSheet.SaveAs(TextBox1.Text)


        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("Dosya aktarılmıstır...")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class