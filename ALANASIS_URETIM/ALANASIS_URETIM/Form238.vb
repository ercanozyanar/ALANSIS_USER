Public Class Form238
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "DIGER_SEVK_RAPOR.XLSX"
        PivotGridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form238_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet56.EO_ALANSIS_SEVKDIGER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SEVKDIGERTableAdapter1.Fill(Me.ALANSISDataSet56.EO_ALANSIS_SEVKDIGER)
        'TODO: Bu kod satırı 'ALANSISDataSet55.EO_ALANSIS_SEVKDIGER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SEVKDIGERTableAdapter.Fill(Me.ALANSISDataSet55.EO_ALANSIS_SEVKDIGER)

    End Sub
End Class