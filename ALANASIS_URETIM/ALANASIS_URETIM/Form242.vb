Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Imports DevExpress.XtraEditors.Controls
Imports iTextSharp.text
Imports iTextSharp.text.html
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf.PdfPTable
Imports System.IO
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form242
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form242_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT ISCI_ADSOY FROM EO_ALANSIS_MEVSIMSEL_ISCI GROUP BY ISCI_ADSOY;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBoxEdit1.Properties.Items.Add(reader1("ISCI_ADSOY"))
        End While
        reader1.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ID,ISCI_ADSOY,ISCI_DOGUM_TARIHI,ISCI_TC,ISCI_TEL FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE TARIH= '" & DateEdit1.Text & "' ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '==========================================================================================================================================
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_MEVSIMSEL_ISCI (TARIH,BOLGE,SORUMLU,ISCI_ADSOY,ISCI_DOGUM_TARIHI,ISCI_TC,ISCI_TEL,ISCI_TIP) VALUES ('" & DateEdit1.Text & "','" & TextEdit1.Text & "','" & TextEdit2.Text & "','" & ComboBoxEdit1.Text & "','" & DateEdit2.Text & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "','" & ComboBoxEdit2.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ID,ISCI_ADSOY,ISCI_DOGUM_TARIHI,ISCI_TC,ISCI_TEL FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE TARIH= '" & DateEdit1.Text & "' ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT COUNT(ISCI_TIP) AS ERKEK FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='E' GROUP BY ISCI_TIP"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit5.Text = reader1("ERKEK")
        End While
        reader1.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery2 As String = "SELECT COUNT(ISCI_TIP) AS KADIN FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='K' GROUP BY ISCI_TIP"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit6.Text = reader2("KADIN")
        End While
        reader2.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery3 As String = "SELECT COUNT(ISCI_TIP) AS DIGER FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='D' GROUP BY ISCI_TIP"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, conn1)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextEdit6.Text = reader3("DIGER")
        End While
        reader3.Close()
        conn1.Close()

    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT * FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_ADSOY='" & ComboBoxEdit1.Text & "'"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit3.Text = reader1("ISCI_TC")
            TextEdit4.Text = reader1("ISCI_TEL")
            DateEdit2.Text = reader1("ISCI_DOGUM_TARIHI")
        End While
        reader1.Close()
        conn1.Close()
    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ISCI_ADSOY,ISCI_DOGUM_TARIHI,ISCI_TC,ISCI_TEL FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE TARIH= '" & DateEdit1.Text & "' ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT COUNT(ISCI_TIP) AS ERKEK FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='E' GROUP BY ISCI_TIP"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit5.Text = reader1("ERKEK")
        End While
        reader1.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery2 As String = "SELECT COUNT(ISCI_TIP) AS KADIN FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='K' GROUP BY ISCI_TIP"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit6.Text = reader2("KADIN")
        End While
        reader2.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery3 As String = "SELECT COUNT(ISCI_TIP) AS DIGER FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='D' GROUP BY ISCI_TIP"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, conn1)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextEdit6.Text = reader3("DIGER")
        End While
        reader3.Close()
        conn1.Close()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim path As String = "MEVSIMSEL_ISCI_LISTE.XLSX"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs)
        On Error Resume Next
        '====================================================
        SaveFileDialog1.Filter = "XLS Files (*.xls*)|*.xls"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
            ' TextBox1.Text = SaveFileDialog1.FileName
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

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim id As String
        id = ""
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "DELETE FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ID='" & TextEdit8.Text & "'"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Me.Hide()
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT COUNT(ISCI_TIP) AS ERKEK FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='E' GROUP BY ISCI_TIP"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit5.Text = reader1("ERKEK")
        End While
        reader1.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery2 As String = "SELECT COUNT(ISCI_TIP) AS KADIN FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='K' GROUP BY ISCI_TIP"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit6.Text = reader2("KADIN")
        End While
        reader2.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        Dim mySelectQuery3 As String = "SELECT COUNT(ISCI_TIP) AS DIGER FROM EO_ALANSIS_MEVSIMSEL_ISCI WHERE ISCI_TIP='D' GROUP BY ISCI_TIP"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, conn1)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextEdit6.Text = reader3("DIGER")
        End While
        reader3.Close()
        conn1.Close()
        '==========================================================================================================================================
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ID,TARIH,BOLUM,VARDIYA,VARDIYA_AMIRI,VARDIYA_AMIR_YARDIMCISI,ETIKET_SEVKIYAT_SORUMLUSU,KISIM,YAPILACAK_IS,DAIMI_KADRO,KADIN,ERKEK FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE TARIH=convert(varchar, getdate(), 104) ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        TextEdit8.Text = GridView1.GetFocusedRowCellValue("ID").ToString()
    End Sub
End Class