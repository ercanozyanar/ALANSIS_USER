Public Class Form228
    Private Sub Form228_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet53.EO_ALANSIS_URETPAKET_RAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_URETPAKET_RAPORTableAdapter.Fill(Me.ALANSISDataSet53.EO_ALANSIS_URETPAKET_RAPOR)

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class