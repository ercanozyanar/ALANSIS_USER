﻿Public Class Form177
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        EO_ALANSIS_YUKLEMETAKIP_HAMMADDETableAdapter1.Fill(AlansısDataSet371.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE)
    End Sub

    Private Sub Form177_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet42.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2TableAdapter3.Fill(Me.ALANSISDataSet42.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2)
        'TODO: Bu kod satırı 'ALANSISDataSet41.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2TableAdapter2.Fill(Me.ALANSISDataSet41.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2)
        'TODO: Bu kod satırı 'ALANSISDataSet40.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2TableAdapter1.Fill(Me.ALANSISDataSet40.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2)
        'TODO: Bu kod satırı 'ALANSISDataSet39.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2TableAdapter.Fill(Me.ALANSISDataSet39.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE2)
        'TODO: Bu kod satırı 'ALANSISDataSet34.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_YUKLEMETAKIP_HAMMADDETableAdapter.Fill(Me.ALANSISDataSet34.EO_ALANSIS_YUKLEMETAKIP_HAMMADDE)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "YUKLEME_EXCEL_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class