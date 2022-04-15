Public Class Form218
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "INCIR_MAMUL_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form218_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet52.EO_ALANSIS_INCIRMAMUL_RAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter.Fill(Me.ALANSISDataSet52.EO_ALANSIS_INCIRMAMUL_RAPOR)
        'TODO: Bu kod satırı 'ALANSISDataSet51.EO_ALANSIS_INCIRMAMULRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_INCIRMAMULRAPORTableAdapter1.Fill(Me.ALANSISDataSet51.EO_ALANSIS_INCIRMAMULRAPOR)
        'TODO: Bu kod satırı 'ALANSISDataSet47.EO_ALANSIS_INCIRMAMULRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_INCIRMAMULRAPORTableAdapter.Fill(Me.ALANSISDataSet47.EO_ALANSIS_INCIRMAMULRAPOR)

    End Sub
End Class