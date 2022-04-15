Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form174
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        On Error Resume Next
        '==========================================================================================================================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='101'"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit4.Text = reader1("GIRIS").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '==========================================================================================================================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='101'"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit2.Text = reader2("CIKIS").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '==========================================================================================================================================================================================================
        'SqlConn.Open()
        'Dim mySelectQuery3 As String = "Select ((SELECT ISNULL(SUM(MIKTAR),0) FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='101')- (SELECT ISNULL(SUM(MIKTAR),0) FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='101')) AS BAKIYE"
        'Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        'Dim reader3 As System.Data.SqlClient.SqlDataReader
        'reader3 = SqlComm2.ExecuteReader()
        'While reader3.Read()
        'TextEdit3.Text = reader3("BAKIYE").ToString()
        TextEdit3.Text = TextEdit4.Text - TextEdit2.Text
        'End While
        'reader3.Close()
        'SqlConn.Close()
        '==========================================================================================================================================================================================================
        If TextEdit4.Text = "" Then
            TextEdit4.Text = "0"
        End If
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        If TextEdit3.Text = "" Then
            TextEdit3.Text = "0"
        End If
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT SUBSTRING(TARIH,1,10)AS TARIH,SERI,HARAKET_TIPI,HARAKET_KODU,BELGENO,MIKTAR AS NETKG,RENK,YERLESIM,DEPO_KODU FROM EO_ALANSIS_MAMHARSERI WHERE DEPO_KODU='101'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        On Error Resume Next
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='201'"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit4.Text = reader1("GIRIS").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='201'"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit2.Text = reader2("CIKIS").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '=====================================================================================================
        'SqlConn.Open()
        'Dim mySelectQuery3 As String = "Select (SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='201')- (SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='201') AS BAKIYE"
        'Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        'Dim reader3 As System.Data.SqlClient.SqlDataReader
        'reader3 = SqlComm2.ExecuteReader()
        'While reader3.Read()
        '    TextEdit3.Text = reader3("BAKIYE").ToString()
        'End While
        'reader3.Close()
        'SqlConn.Close()
        TextEdit3.Text = TextEdit4.Text - TextEdit2.Text
        '=====================================================================================================
        If TextEdit4.Text = "" Then
            TextEdit4.Text = "0"
        End If
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        If TextEdit3.Text = "" Then
            TextEdit3.Text = "0"
        End If
        '======================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT SUBSTRING(TARIH,1,10)AS TARIH,SERI,HARAKET_TIPI,HARAKET_KODU,BELGENO,MIKTAR AS NETKG,RENK,YERLESIM,DEPO_KODU FROM EO_ALANSIS_MAMHARSERI WHERE DEPO_KODU='201'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        On Error Resume Next
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='301'"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit4.Text = reader1("GIRIS").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='301'"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit2.Text = reader2("CIKIS").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '=====================================================================================================
        'SqlConn.Open()
        'Dim mySelectQuery3 As String = "Select (SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='301')- (SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='301') AS BAKIYE"
        'Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        'Dim reader3 As System.Data.SqlClient.SqlDataReader
        'reader3 = SqlComm2.ExecuteReader()
        'While reader3.Read()
        '    TextEdit3.Text = reader3("BAKIYE").ToString()
        'End While
        'reader3.Close()
        'SqlConn.Close()
        TextEdit3.Text = TextEdit4.Text - TextEdit2.Text
        '=====================================================================================================
        If TextEdit4.Text = "" Then
            TextEdit4.Text = "0"
        End If
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        If TextEdit3.Text = "" Then
            TextEdit3.Text = "0"
        End If
        '======================================================================================================

        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT SUBSTRING(TARIH,1,10)AS TARIH,SERI,HARAKET_TIPI,HARAKET_KODU,BELGENO,MIKTAR AS NETKG,RENK,YERLESIM,DEPO_KODU FROM EO_ALANSIS_MAMHARSERI WHERE DEPO_KODU='301'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        On Error Resume Next
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='401'"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit4.Text = reader1("GIRIS").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='401'"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit2.Text = reader2("CIKIS").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '=====================================================================================================
        'SqlConn.Open()
        'Dim mySelectQuery3 As String = "Select (SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='401')- (SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='401') AS BAKIYE"
        'Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        'Dim reader3 As System.Data.SqlClient.SqlDataReader
        'reader3 = SqlComm2.ExecuteReader()
        'While reader3.Read()
        '    TextEdit3.Text = reader3("BAKIYE").ToString()
        'End While
        'reader3.Close()
        'SqlConn.Close()
        TextEdit3.Text = TextEdit4.Text - TextEdit2.Text
        '=====================================================================================================
        If TextEdit4.Text = "" Then
            TextEdit4.Text = "0"
        End If
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        If TextEdit3.Text = "" Then
            TextEdit3.Text = "0"
        End If
        '======================================================================================================

        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT SUBSTRING(TARIH,1,10)AS TARIH,SERI,HARAKET_TIPI,HARAKET_KODU,BELGENO,MIKTAR AS NETKG,RENK,YERLESIM,DEPO_KODU FROM EO_ALANSIS_MAMHARSERI WHERE DEPO_KODU='401'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        On Error Resume Next
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='30'"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit4.Text = reader1("GIRIS").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        '=====================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='30'"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit2.Text = reader2("CIKIS").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        '=====================================================================================================
        'SqlConn.Open()
        'Dim mySelectQuery3 As String = "Select (SELECT ISNULL(SUM(MIKTAR),0) AS GIRIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='G' AND DEPO_KODU='30')- (SELECT ISNULL(SUM(MIKTAR),0) AS CIKIS FROM EO_ALANSIS_MAMHARSERI WHERE HARAKET_KODU='C' AND DEPO_KODU='30') AS BAKIYE"
        'Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        'Dim reader3 As System.Data.SqlClient.SqlDataReader
        'reader3 = SqlComm2.ExecuteReader()
        'While reader3.Read()
        '    TextEdit3.Text = reader3("BAKIYE").ToString()
        'End While
        'reader3.Close()
        'SqlConn.Close()
        TextEdit3.Text = TextEdit4.Text - TextEdit2.Text
        '=====================================================================================================
        If TextEdit4.Text = "" Then
            TextEdit4.Text = "0"
        End If
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        If TextEdit3.Text = "" Then
            TextEdit3.Text = "0"
        End If
        '======================================================================================================

        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT SUBSTRING(TARIH,1,10)AS TARIH,SERI,HARAKET_TIPI,HARAKET_KODU,BELGENO,MIKTAR AS NETKG,RENK,YERLESIM,DEPO_KODU FROM EO_ALANSIS_MAMHARSERI WHERE DEPO_KODU='30'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "URETIM_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form174_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class