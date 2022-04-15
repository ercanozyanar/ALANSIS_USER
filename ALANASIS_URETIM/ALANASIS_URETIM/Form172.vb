Public Class Form172
    Private Sub Form172_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet29.EO_KIRAZPAKET_KONTROL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_KIRAZPAKET_KONTROLTableAdapter1.Fill(Me.ALANSISDataSet29.EO_KIRAZPAKET_KONTROL)
        'TODO: Bu kod satırı 'ALANSISDataSet27.EO_KIRAZPAKET_KONTROL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        ' Me.EO_KIRAZPAKET_KONTROLTableAdapter.Fill(Me.ALANSISDataSet27.EO_KIRAZPAKET_KONTROL)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "PAKETLEME_ANALIZ_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Dim path As String = "RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class