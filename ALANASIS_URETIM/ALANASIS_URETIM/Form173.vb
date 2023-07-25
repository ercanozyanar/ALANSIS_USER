Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.Common
Imports DevExpress.XtraTreeList
Imports System.Data.Entity

Public Class Form173
    Dim dbContext As ALANSISEntities1 = New ALANSISEntities1()
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)

    Private Sub Form173_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim grupkontrol, kontrol1, kontrol2, kontrol3, kontrol4, kontrol5, kontrol6, kontrol7, kontrol8, kontrol9, kontrol10 As String
        grupkontrol = ""
        kontrol1 = ""
        kontrol2 = ""
        kontrol3 = ""
        kontrol4 = ""
        kontrol5 = ""
        kontrol6 = ""
        kontrol7 = ""
        kontrol8 = ""
        kontrol9 = ""
        kontrol10 = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        '=================================================================
        dbContext.EO_ALANSIS_KIRAZ_MAMULDEPO.Load()
        GridControl1.DataSource = dbContext.EO_ALANSIS_KIRAZ_MAMULDEPO.Local.ToBindingList()
        GridView1.Columns("ODA").Visible = False
        GridView1.Columns("DEPO").Visible = False
        GridView1.Columns("TIP").Visible = False
        GridView1.Columns("USR").Visible = False
        GridView1.Columns("STOK_ISLEM").Visible = False
        GridView1.Columns("AKTARILAN_URETICI").Visible = False
        GridView1.Columns("AKTARILAN_KUTUSAYI").Visible = False
        GridView1.Columns("AKTARILAN_KG").Visible = False
        GridView1.Columns("SEVK_ONAY").Visible = False
        GridView1.Columns("SEVK_MIKTAR").Visible = False
        GridView1.Columns("SEVKID").Visible = False
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN1';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            kontrol1 = reader1("" & grupkontrol & "").ToString()
        End While
        reader1.Close()
        SqlConn.Close()
        If kontrol1 = "E" Then
            GridView1.Columns("EKALAN1").Visible = True
        Else
            GridView1.Columns("EKALAN1").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN2';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            kontrol2 = reader2("" & grupkontrol & "").ToString()
        End While
        reader2.Close()
        SqlConn.Close()
        If kontrol2 = "E" Then
            GridView1.Columns("EKALAN2").Visible = True
        Else
            GridView1.Columns("EKALAN2").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN3';"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            kontrol3 = reader3("" & grupkontrol & "").ToString()
        End While
        reader3.Close()
        SqlConn.Close()
        If kontrol3 = "E" Then
            GridView1.Columns("EKALAN3").Visible = True
        Else
            GridView1.Columns("EKALAN3").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery4 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN4';"
        Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        Dim reader4 As System.Data.SqlClient.SqlDataReader
        reader4 = SqlComm4.ExecuteReader()
        While reader4.Read()
            kontrol4 = reader4("" & grupkontrol & "").ToString()
        End While
        reader4.Close()
        SqlConn.Close()
        If kontrol4 = "E" Then
            GridView1.Columns("EKALAN4").Visible = True
        Else
            GridView1.Columns("EKALAN4").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery5 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN5';"
        Dim SqlComm5 As New System.Data.SqlClient.SqlCommand(mySelectQuery5, SqlConn)
        Dim reader5 As System.Data.SqlClient.SqlDataReader
        reader5 = SqlComm5.ExecuteReader()
        While reader5.Read()
            kontrol5 = reader5("" & grupkontrol & "").ToString()
        End While
        reader5.Close()
        SqlConn.Close()
        If kontrol5 = "E" Then
            GridView1.Columns("EKALAN5").Visible = True
        Else
            GridView1.Columns("EKALAN5").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN6';"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, SqlConn)
        Dim reader6 As System.Data.SqlClient.SqlDataReader
        reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            kontrol6 = reader6("" & grupkontrol & "").ToString()
        End While
        reader6.Close()
        SqlConn.Close()
        If kontrol6 = "E" Then
            GridView1.Columns("EKALAN6").Visible = True
        Else
            GridView1.Columns("EKALAN6").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN7';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, SqlConn)
        Dim reader7 As System.Data.SqlClient.SqlDataReader
        reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            kontrol7 = reader7("" & grupkontrol & "").ToString()
        End While
        reader7.Close()
        SqlConn.Close()
        If kontrol7 = "E" Then
            GridView1.Columns("EKALAN7").Visible = True
        Else
            GridView1.Columns("EKALAN7").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery8 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN8';"
        Dim SqlComm8 As New System.Data.SqlClient.SqlCommand(mySelectQuery8, SqlConn)
        Dim reader8 As System.Data.SqlClient.SqlDataReader
        reader8 = SqlComm8.ExecuteReader()
        While reader8.Read()
            kontrol8 = reader8("" & grupkontrol & "").ToString()
        End While
        reader8.Close()
        SqlConn.Close()
        If kontrol8 = "E" Then
            GridView1.Columns("EKALAN8").Visible = True
        Else
            GridView1.Columns("EKALAN8").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery9 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN9';"
        Dim SqlComm9 As New System.Data.SqlClient.SqlCommand(mySelectQuery9, SqlConn)
        Dim reader9 As System.Data.SqlClient.SqlDataReader
        reader9 = SqlComm9.ExecuteReader()
        While reader9.Read()
            kontrol9 = reader9("" & grupkontrol & "").ToString()
        End While
        reader9.Close()
        SqlConn.Close()
        If kontrol9 = "E" Then
            GridView1.Columns("EKALAN9").Visible = True
        Else
            GridView1.Columns("EKALAN9").Visible = False
        End If
        '==================================================================================================
        SqlConn.Open()
        Dim mySelectQuery10 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE " & grupkontrol & "='E' AND SAHA='EKALAN10';"
        Dim SqlComm10 As New System.Data.SqlClient.SqlCommand(mySelectQuery10, SqlConn)
        Dim reader10 As System.Data.SqlClient.SqlDataReader
        reader10 = SqlComm10.ExecuteReader()
        While reader10.Read()
            kontrol10 = reader10("" & grupkontrol & "").ToString()
        End While
        reader10.Close()
        SqlConn.Close()
        If kontrol10 = "E" Then
            GridView1.Columns("EKALAN10").Visible = True
        Else
            GridView1.Columns("EKALAN10").Visible = False
        End If

        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "KIRAZ_MAMUL_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        Process.Start(path)
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        DbContext.SaveChanges()
    End Sub
End Class