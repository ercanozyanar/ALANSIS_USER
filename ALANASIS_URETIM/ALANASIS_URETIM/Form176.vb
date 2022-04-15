Public Class Form176
    Private Sub Form176_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet32.EO_ALANSIS_URETIMRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_URETIMRAPORTableAdapter.Fill(Me.ALANSISDataSet32.EO_ALANSIS_URETIMRAPOR)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path As String = "URETIM_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class