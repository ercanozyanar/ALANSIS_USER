﻿Public Class Form223
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill the SqlDataSource asynchronously
        SqlDataSource1.FillAsync()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path As String = "ERIK_URETIM_RAPOR1.HTML"

        ' PivotGridControl2.ExportToXlsx(path)

        PivotGridControl2.ExportToHtml(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub Form223_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class