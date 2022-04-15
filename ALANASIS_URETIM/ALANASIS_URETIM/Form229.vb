Public Class Form229
    Private Sub Form229_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet54.EO_ALANSIS_HAMMADDE_RAPOR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_HAMMADDE_RAPORTableAdapter.Fill(Me.ALANSISDataSet54.EO_ALANSIS_HAMMADDE_RAPOR)

    End Sub
End Class