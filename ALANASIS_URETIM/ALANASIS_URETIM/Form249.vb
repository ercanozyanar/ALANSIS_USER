Public Class Form249
    Private Sub Form249_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet62.EO_ALANSIS_EXCELYURTICISATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_EXCELYURTICISATISTableAdapter.Fill(Me.ALANSISDataSet62.EO_ALANSIS_EXCELYURTICISATIS)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "ALANSIS_SATIS_EXCEL_TABLO.XLSX"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class