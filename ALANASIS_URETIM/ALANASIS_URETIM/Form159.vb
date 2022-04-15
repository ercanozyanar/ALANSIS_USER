Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Public Class Form159
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form159_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ''---------------------------------------------------------------------------------------------------
        'If TextBox1.Text = "" Then
        '    SqlConn.Open()
        '    Dim mySelectQuery1 As String = "SELECT TIP,CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET,SUM(BRUT) AS BRUT FROM EO_ALANSIS_KIVI_DEPO WHERE TIP='HAMMADDE' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP;"
        '    Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        '    Dim reader1 As System.Data.SqlClient.SqlDataReader
        '    reader1 = SqlComm1.ExecuteReader()
        '    While reader1.Read()
        '        Label1.Text = reader1("NET").ToString()
        '        Label12.Text = reader1("BRUT").ToString()
        '    End While
        '    reader1.Close()
        '    SqlConn.Close()
        '    '---------------------------------------------------------------------------------------------
        '    SqlConn.Open()
        '    Dim mySelectQuery2 As String = "SELECT TIP,CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET,SUM(BRUT) AS BRUT FROM EO_ALANSIS_KIVI_DEPO WHERE TIP='2KALITE_HAMMADDE' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP;"
        '    Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        '    Dim reader2 As System.Data.SqlClient.SqlDataReader
        '    reader2 = SqlComm2.ExecuteReader()
        '    While reader2.Read()
        '        Label10.Text = reader2("NET").ToString()
        '    End While
        '    reader2.Close()
        '    SqlConn.Close()
        '    SqlConn.Open()
        '    Dim mySelectQuery3 As String = "SELECT TIP,CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET,SUM(BRUT) AS BRUT FROM EO_ALANSIS_KIVI_DEPO WHERE TIP='SULUK_HAMMADDE' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP;"
        '    Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        '    Dim reader3 As System.Data.SqlClient.SqlDataReader
        '    reader3 = SqlComm3.ExecuteReader()
        '    While reader3.Read()
        '        Label8.Text = reader3("NET").ToString()
        '    End While
        '    reader3.Close()
        '    SqlConn.Close()
        '    SqlConn.Open()
        '    Dim mySelectQuery4 As String = "SELECT TIP,CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET,SUM(BRUT) AS BRUT FROM EO_ALANSIS_KIVI_DEPO WHERE TIP='YARIMAMUL_HAMMADDE' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP;"
        '    Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        '    Dim reader4 As System.Data.SqlClient.SqlDataReader
        '    reader4 = SqlComm4.ExecuteReader()
        '    While reader4.Read()
        '        Label6.Text = reader4("NET").ToString()
        '    End While
        '    reader4.Close()
        '    SqlConn.Close()

        '    '---------------------------------------------------------------------------------------------
        '    SqlConn.Open()
        '    Dim mySelectQuery9 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS MIKTAR FROM EO_SARF_TUKETIM_SERI WHERE  CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104);"
        '    Dim SqlComm9 As New System.Data.SqlClient.SqlCommand(mySelectQuery9, SqlConn)
        '    Dim reader9 As System.Data.SqlClient.SqlDataReader
        '    reader9 = SqlComm9.ExecuteReader()
        '    While reader9.Read()
        '        Label4.Text = reader9("MIKTAR").ToString()
        '    End While
        '    reader4.Close()
        '    SqlConn.Close()
        '    Form37.Show()
        'End If
        '---------------------------------------------------------------------------------------------------
        'If TextBox1.Text <> "" Then
        SqlConn.Open()
        Dim mySelectQuery5 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET,CAST(SUM(BRUT) AS DECIMAL) AS BRUT,TIP FROM EO_ALANSIS_KIRAZ_MAMULDEPO WHERE TIP='MAMUL' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP;"
        Dim SqlComm5 As New System.Data.SqlClient.SqlCommand(mySelectQuery5, SqlConn)
        Dim reader5 As System.Data.SqlClient.SqlDataReader
        reader5 = SqlComm5.ExecuteReader()
        While reader5.Read()
            Label1.Text = reader5("NET").ToString()
            Label12.Text = reader5("BRUT").ToString()
        End While
        reader5.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery6 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET, SUM(BRUT) AS BRUT,TIP FROM EO_ALANSIS_KIRAZ_MAMULDEPO WHERE TIP='2KALITE_MAMUL' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, SqlConn)
        Dim reader6 As System.Data.SqlClient.SqlDataReader
        reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            Label10.Text = reader6("NET").ToString()
        End While
        reader6.Close()
        SqlConn.Close()
        SqlConn.Open()
        Dim mySelectQuery7 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET, SUM(BRUT) AS BRUT,TIP FROM EO_ALANSIS_KIRAZ_MAMULDEPO WHERE TIP='SULUK_MAMUL' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, SqlConn)
        Dim reader7 As System.Data.SqlClient.SqlDataReader
        reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            Label8.Text = reader7("NET").ToString()
        End While
        reader7.Close()
        SqlConn.Close()
        SqlConn.Open()
        Dim mySelectQuery8 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET, SUM(BRUT) AS BRUT,TIP FROM EO_ALANSIS_KIRAZ_MAMULDEPO WHERE TIP='YARIMAMUL_MAMUL' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP"
        Dim SqlComm8 As New System.Data.SqlClient.SqlCommand(mySelectQuery8, SqlConn)
        Dim reader8 As System.Data.SqlClient.SqlDataReader
        reader8 = SqlComm8.ExecuteReader()
        While reader8.Read()
            Label6.Text = reader8("NET").ToString()
        End While
        reader8.Close()
        SqlConn.Close()
        SqlConn.Open()
        '----------------------------------------------------------------------------------------------------------------------------------------------
        Dim mySelectQuery10 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS MIKTAR FROM EO_SARF_TUKETIM_SERI WHERE  CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104))  GROUP BY CONVERT(DATE,TARIH,104)"
        Dim SqlComm10 As New System.Data.SqlClient.SqlCommand(mySelectQuery10, SqlConn)
        Dim reader10 As System.Data.SqlClient.SqlDataReader
        reader10 = SqlComm10.ExecuteReader()
        While reader10.Read()
            Label4.Text = reader10("MIKTAR").ToString()
        End While
        reader10.Close()
        SqlConn.Close()

        '----------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery31 As String = "SELECT TUKETIM FROM dbo.EO_ALANSIS_TUKETIMGUNLUK1"
        Dim SqlComm31 As New System.Data.SqlClient.SqlCommand(mySelectQuery31, SqlConn)
        Dim reader31 As System.Data.SqlClient.SqlDataReader
        reader31 = SqlComm31.ExecuteReader()
        While reader31.Read()
            Label16.Text = reader31("TUKETIM").ToString()
        End While
        reader31.Close()
        SqlConn.Close()

        '---------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery12 As String = "SELECT CONVERT(DATE,TARIH,104),CAST(SUM(MIKTAR) AS DECIMAL) AS NET, SUM(BRUT) AS BRUT,TIP FROM EO_ALANSIS_KIRAZ_MAMULDEPO WHERE TIP='COP_MAMUL' AND CONVERT(DATE,TARIH,104)=(SELECT CONVERT(DATE,GETDATE(),104)) GROUP BY CONVERT(DATE,TARIH,104),TIP"
        Dim SqlComm12 As New System.Data.SqlClient.SqlCommand(mySelectQuery12, SqlConn)
            Dim reader12 As System.Data.SqlClient.SqlDataReader
            reader12 = SqlComm7.ExecuteReader()
            While reader12.Read()
                Label14.Text = reader12("NET").ToString()
            End While
            reader12.Close()
            SqlConn.Close()
            Form37.Show()
        'End If








    End Sub
End Class