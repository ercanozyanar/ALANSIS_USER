Public Class Form220
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path As String = "INCIR_URETIM_RAPOR.xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form220_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet49.EO_ALANSIS_INCIRURETIMRAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_INCIRURETIMRAPORTableAdapter.Fill(Me.ALANSISDataSet49.EO_ALANSIS_INCIRURETIMRAPOR)

    End Sub
End Class