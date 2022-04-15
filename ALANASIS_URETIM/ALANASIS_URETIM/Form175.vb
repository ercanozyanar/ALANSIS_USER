﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets

Public Class Form175
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form175_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TIP,SIPARIS_NO,CARI_KOD,CARI_ISIM,STOK_KODU,STOK_ADI,SIPARIS_TARIH,SIPARIS_YILI,SIPARIS_AYI,SIPARIS_MIKTAR,TESLIM_MIKTAR,DOVIZ_BIRIM_FIYAT,DOVIZ_PARA_BIRIMI,BIRIM_FIYAT,TUTAR,TESLIM_TARIH,SIPARIS_NU AS SIPARIS_NUMARASI,IRSALIYE_TARIH,FISNO FROM EO_ALANSIS_SATSIP"
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
        Dim bastarih As String = Convert.ToDateTime(DateEdit1.Text).ToString("yyyy-MM-dd 00:00:00.000") 'Returns date with AM/PM'
        Dim bittarih As String = Convert.ToDateTime(DateEdit2.Text).ToString("yyyy-MM-dd 00:00:00.000")
        Dim connectionString As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TIP,SIPARIS_NO,CARI_KOD,CARI_ISIM,STOK_KODU,STOK_ADI,SIPARIS_TARIH,SIPARIS_YILI,SIPARIS_AYI,SIPARIS_MIKTAR,TESLIM_MIKTAR,DOVIZ_BIRIM_FIYAT,DOVIZ_PARA_BIRIMI,BIRIM_FIYAT,TUTAR,TESLIM_TARIH,SIPARIS_NU AS SIPARIS_NUMARASI,IRSALIYE_TARIH,FISNO FROM EO_ALANSIS_SATSIP WHERE (STHAR_TARIH BETWEEN '" & bastarih & "' AND '" & bittarih & "')"
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

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path As String = "SATINALMA_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class