Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form13
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ODA, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA FROM EO_ALANSIS_NAR_DEPO WHERE (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY ODA;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("ODA"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sayfa1")


        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = DataGridView1(j, i).Value.ToString()
            Next
        Next

        xlWorkBook.SaveAs("C:\ALANSIS_URETIM\ALANSIS_GUNLUK_NAR_MAMUL.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
         Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MessageBox.Show("Aktarım Tamamlanmistir...")
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        ComboBox1.Items.Clear()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ODA, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA FROM EO_ALANSIS_NAR_DEPO WHERE (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY ODA;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("ODA"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim cmd As New SqlCommand()
        'Dim cnn As New SqlConnection()
        'Dim da As New SqlDataAdapter()
        'Dim ds As New DataSet

        'Try
        ' cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        ' cnn.Open()
        ' cmd.Connection = cnn
        ' cmd.CommandType = CommandType.Text
        ' cmd.CommandText = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC"
        'da.SelectCommand = cmd
        'da.Fill(ds)
        'DataGridView1.DataSource = ds.Tables(0).DefaultView
        'Catch ex As Exception
        ' MessageBox.Show(ex.Message)
        ' End Try
        ' cnn.Close()
        '-----------------------------------------------------------------------------------------------------------------------------
        ' SqlConn.Open()
        ' Dim mySelectQuery1 As String = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='HAMMADDE' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC;"
        ' Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        ' Dim reader1 As System.Data.SqlClient.SqlDataReader
        ' reader1 = SqlComm1.ExecuteReader()
        ' While reader1.Read()
        'TextBox2.Text = reader1("TOPLAM_NET").ToString()
        'TextBox1.Text = reader1("TOPLAM_BRUT").ToString()
        'End While
        'reader1.Close()
        'SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        'SqlConn.Open()
        'Dim mySelectQuery2 As String = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='YARIMAMUL' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC;"
        'Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        'Dim reader2 As System.Data.SqlClient.SqlDataReader
        'reader2 = SqlComm2.ExecuteReader()
        'While reader2.Read()
        ' TextBox4.Text = reader2("TOPLAM_NET").ToString()
        ' TextBox3.Text = reader2("TOPLAM_BRUT").ToString()
        ' End While
        ' reader2.Close()
        ' SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        'SqlConn.Open()
        'Dim mySelectQuery3 As String = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP=SULUK' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC;"
        'Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        'Dim reader3 As System.Data.SqlClient.SqlDataReader
        'reader3 = SqlComm3.ExecuteReader()
        'While reader3.Read()
        ' TextBox6.Text = reader3("TOPLAM_NET").ToString()
        ' TextBox5.Text = reader3("TOPLAM_BRUT").ToString()
        ' End While
        'reader3.Close()
        'SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        'SqlConn.Open()
        'Dim mySelectQuery4 As String = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='2.KALITE' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC;"
        'Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        'Dim reader4 As System.Data.SqlClient.SqlDataReader
        'reader4 = SqlComm4.ExecuteReader()
        'While reader4.Read()
        ' TextBox8.Text = reader4("TOPLAM_NET").ToString()
        ' TextBox7.Text = reader4("TOPLAM_BRUT").ToString()
        ' End While
        'reader4.Close()
        'SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        'SqlConn.Open()
        'Dim mySelectQuery5 As String = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='COP' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC;"
        'Dim SqlComm5 As New System.Data.SqlClient.SqlCommand(mySelectQuery5, SqlConn)
        'Dim reader5 As System.Data.SqlClient.SqlDataReader
        'reader5 = SqlComm5.ExecuteReader()
        'While reader5.Read()
        ' TextBox10.Text = reader5("TOPLAM_NET").ToString()
        ' TextBox9.Text = reader5("TOPLAM_BRUT").ToString()
        ' End While
        ' reader5.Close()
        ' SqlConn.Close()
        ' '-------------------------------------------------------------------------------------------------------------------------------
        'SqlConn.Open()
        'Dim mySelectQuery6 As String = "SELECT ODA, PARTINO, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='STOK' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "' GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP, PARTINO ORDER BY ODA DESC;"
        'Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, SqlConn)
        'Dim reader6 As System.Data.SqlClient.SqlDataReader
        'reader6 = SqlComm6.ExecuteReader()
        'While reader6.Read()
        ' TextBox12.Text = reader6("TOPLAM_NET").ToString()
        ' TextBox11.Text = reader6("TOPLAM_BRUT").ToString()
        ' End While
        ' reader6.Close()
        ' SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        'TextBox14.Text = Val(TextBox2.Text) + Val(TextBox4.Text) + Val(TextBox6.Text) + Val(TextBox8.Text) + Val(TextBox10.Text) + Val(TextBox12.Text)
        'TextBox13.Text = Val(TextBox1.Text) + Val(TextBox3.Text) + Val(TextBox5.Text) + Val(TextBox7.Text) + Val(TextBox9.Text) + Val(TextBox11.Text)

    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
            cmd.CommandText = "SELECT ODA, VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-----------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='HAMMADDE' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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
        Dim mySelectQuery2 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='YARIMAMUL' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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
        Dim mySelectQuery3 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='SULUK' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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
        Dim mySelectQuery4 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='2.KALITE' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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
        Dim mySelectQuery5 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='COP' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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
        Dim mySelectQuery6 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='STOK' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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
        Dim mySelectQuery17 As String = "SELECT ODA,VIYOL, BOLGE, ISLEM, SUM(MIKTAR) AS NET, SUM(BRUT) AS BRUT, TIP FROM dbo.EO_ALANSIS_NAR_DEPO WHERE ODA='" & ComboBox1.Text & "' AND TIP='MAMUL' AND (CONVERT(varchar, CONVERT(datetime, TARIH, 104), 104) BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker3.Text & "') GROUP BY BOLGE, ISLEM, ODA, VIYOL, TIP ORDER BY ODA DESC;"
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class