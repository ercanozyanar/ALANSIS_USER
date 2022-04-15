Public Class Form221
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path As String = "ERIK_URETIM_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form221_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet50.EO_ALANSIS_ERIKURETIMRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_ERIKURETIMRAPORTableAdapter.Fill(Me.ALANSISDataSet50.EO_ALANSIS_ERIKURETIMRAPOR)

    End Sub
End Class