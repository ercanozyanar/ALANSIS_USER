Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.Common
Imports DevExpress.XtraTreeList

Public Class Form173
    Private Sub Form173_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet65.EO_ALANSIS_KIRAZ_MAMULDEPO' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter.Fill(Me.ALANSISDataSet65.EO_ALANSIS_KIRAZ_MAMULDEPO)
        'GridView1.Columns("ODA").Visible = False
        'GridView1.Columns("DEPO").Visible = False
        'GridView1.Columns("TIP").Visible = False
        'GridView1.Columns("USR").Visible = False
        'GridView1.Columns("STOK_ISLEM").Visible = False
        'GridView1.Columns("AKTARILAN_URETICI").Visible = False
        'GridView1.Columns("AKTARILAN_KUTUSAYI").Visible = False
        'GridView1.Columns("AKTARILAN_KG").Visible = False
        'GridView1.Columns("SEVK_ONAY").Visible = False
        'GridView1.Columns("SEVK_MIKTAR").Visible = False
        'GridView1.Columns("SEVKID").Visible = False



    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "KIRAZ_MAMUL_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter.Update(ALANSISDataSet65.EO_ALANSIS_KIRAZ_MAMULDEPO)
    End Sub
End Class