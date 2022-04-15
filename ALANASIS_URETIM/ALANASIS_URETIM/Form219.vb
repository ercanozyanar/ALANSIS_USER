Public Class Form219
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "ERIK_MAMUL_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet48.EO_ALANSIS_ERIKMAMULRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_ERIKMAMULRAPORTableAdapter.Fill(Me.ALANSISDataSet48.EO_ALANSIS_ERIKMAMULRAPOR)

    End Sub
End Class