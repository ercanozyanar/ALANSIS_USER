Imports System.Data.SqlClient

Public Class Form230
    Private Sub Form230_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM EO_KIRAZPAKET_KONTROL WHERE PAKETLEME_TARIH=convert(varchar, getdate(),104) "
            da.SelectCommand = cmd
            da.Fill(ds)
            GridControl1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class