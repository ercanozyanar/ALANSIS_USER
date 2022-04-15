Public Class Form171
    Private Sub Form171_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet31.EO_ALANSIS_PAKETBESRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter2.Fill(Me.ALANSISDataSet31.EO_ALANSIS_PAKETBESRAPOR)
        'TODO: Bu kod satırı 'ALANSISDataSet30.EO_ALANSIS_PAKETBESRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter1.Fill(Me.ALANSISDataSet30.EO_ALANSIS_PAKETBESRAPOR)
        'TODO: Bu kod satırı 'ALANSISDataSet26.EO_ALANSIS_PAKETBESRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter.Fill(Me.ALANSISDataSet26.EO_ALANSIS_PAKETBESRAPOR)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "PAKETLEME_BESLEME_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class