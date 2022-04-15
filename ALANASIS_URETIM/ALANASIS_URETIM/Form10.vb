Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form10
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_NAR_GUNLUK"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ODA FROM EO_ALANSIS_NAR_GUNLUK GROUP BY ODA;"
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
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_NAR_GUNLUK WHERE ODA='" & ComboBox1.Text & "'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-----------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_NARGUNLUK_TOPLAM WHERE ODA='" & ComboBox1.Text & "' and TIP='HAMMADDE';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextBox2.Text = reader1("TOPLAM_NET").ToString()
            TextBox1.Text = reader1("TOPLAM_BRUT").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_NARGUNLUK_TOPLAM WHERE ODA='" & ComboBox1.Text & "' and TIP='YARIMAMUL';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextBox4.Text = reader2("TOPLAM_NET").ToString()
            TextBox3.Text = reader2("TOPLAM_BRUT").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT* FROM EO_ALANSIS_NARGUNLUK_TOPLAM WHERE ODA='" & ComboBox1.Text & "' and TIP='SULUK';"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextBox6.Text = reader3("TOPLAM_NET").ToString()
            TextBox5.Text = reader3("TOPLAM_BRUT").ToString()
        End While
        reader3.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery4 As String = "SELECT* FROM EO_ALANSIS_NARGUNLUK_TOPLAM WHERE ODA='" & ComboBox1.Text & "' and TIP='2.KALITE';"
        Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        Dim reader4 As System.Data.SqlClient.SqlDataReader
        reader4 = SqlComm4.ExecuteReader()
        While reader4.Read()
            TextBox8.Text = reader4("TOPLAM_NET").ToString()
            TextBox7.Text = reader4("TOPLAM_BRUT").ToString()
        End While
        reader4.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery5 As String = "SELECT* FROM EO_ALANSIS_NARGUNLUK_TOPLAM WHERE ODA='" & ComboBox1.Text & "' and TIP='COP';"
        Dim SqlComm5 As New System.Data.SqlClient.SqlCommand(mySelectQuery5, SqlConn)
        Dim reader5 As System.Data.SqlClient.SqlDataReader
        reader5 = SqlComm5.ExecuteReader()
        While reader5.Read()
            TextBox10.Text = reader5("TOPLAM_NET").ToString()
            TextBox9.Text = reader5("TOPLAM_BRUT").ToString()
        End While
        reader5.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_NARGUNLUK_TOPLAM WHERE ODA='" & ComboBox1.Text & "' and TIP='STOK';"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, SqlConn)
        Dim reader6 As System.Data.SqlClient.SqlDataReader
        reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            TextBox12.Text = reader6("TOPLAM_NET").ToString()
            TextBox11.Text = reader6("TOPLAM_BRUT").ToString()
        End While
        reader6.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        TextBox14.Text = Val(TextBox2.Text) + Val(TextBox4.Text) + Val(TextBox6.Text) + Val(TextBox8.Text) + Val(TextBox10.Text) + Val(TextBox12.Text)
        TextBox13.Text = Val(TextBox1.Text) + Val(TextBox3.Text) + Val(TextBox5.Text) + Val(TextBox7.Text) + Val(TextBox9.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

        xlWorkBook.SaveAs("C:\ALANSIS_URETIM\ALANSIS_GUNLUK_NAR_HAMMADDE.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class